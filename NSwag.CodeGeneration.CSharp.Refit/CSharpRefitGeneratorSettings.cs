using NSwag.CodeGeneration.CSharp.Models;
using NSwag.CodeGeneration.CSharp.Refit.Models;

namespace NSwag.CodeGeneration.CSharp.Refit
{
    /// <summary>
    /// CSharpRefitGeneratorSettings
    /// </summary>
    public class CSharpRefitGeneratorSettings : CSharpGeneratorBaseSettings
    {
        /// <summary>Initializes a new instance of the <see cref="CSharpControllerGeneratorSettings"/> class.</summary>
        public CSharpRefitGeneratorSettings()
        {
            ClassName = "{controller}";
            CSharpGeneratorSettings.ArrayType = "System.Collections.Generic.List";
            CSharpGeneratorSettings.ArrayInstanceType = "System.Collections.Generic.List";
            RefitStyle = CSharpRefitStyle.Partial;
            RefitTarget = CSharpRefitTarget.AspNetCore;
            RouteNamingStrategy = CSharpRefitRouteNamingStrategy.None;
            GenerateModelValidationAttributes = false;
            UseCancellationToken = false;
        }

        /// <summary>Returns the route name for a controller method.</summary>
        /// <param name="operation">Swagger operation</param>
        /// <returns>Route name.</returns>
        public string GetRouteName(OpenApiOperation operation)
        {
            if (RouteNamingStrategy == CSharpRefitRouteNamingStrategy.OperationId)
            {
                return operation.OperationId;
            }

            return null;
        }

        /// <summary>Gets or sets the full name of the base class.</summary>
        public string ControllerBaseClass { get; set; }

        /// <summary>Gets or sets the controller generation style (partial, abstract; default: partial).</summary>
        public CSharpRefitStyle RefitStyle { get; set; }

        /// <summary>Gets or sets the controller target framework.</summary>
        public CSharpRefitTarget RefitTarget { get; set; }

        /// <summary>Gets or sets a value indicating whether to allow adding cancellation token </summary>
        public bool UseCancellationToken { get; set; }

        /// <summary>Gets or sets the strategy for naming routes (default: CSharpRouteNamingStrategy.None).</summary>
        public CSharpRefitRouteNamingStrategy RouteNamingStrategy { get; set; }

        /// <summary>Gets or sets a value indicating whether to add model validation attributes.</summary>
        public bool GenerateModelValidationAttributes { get; set; }

        /// <summary>Gets or sets a value indicating whether ASP.Net Core (2.1) ActionResult type is used (default: false).</summary>
        public bool UseActionResultType { get; set; }
        
        /// <summary>
        /// HeaderInAction
        /// </summary>
        public bool HeaderInAction { get; set; }

        /// <summary>Gets or sets the base path on which the API is served, which is relative to the Host.</summary>
        public string BasePath { get; set; }
    }
}