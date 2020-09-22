using System.Collections.Generic;
using NJsonSchema.CodeGeneration;
using NSwag.CodeGeneration.CSharp.Models;

namespace NSwag.CodeGeneration.CSharp.Refit.Models
{
    public class RefitParameterModel:CSharpParameterModel
    {
        public RefitParameterModel(string parameterName, string variableName, string typeName, OpenApiParameter parameter, IList<OpenApiParameter> allParameters, CodeGeneratorSettingsBase settings, IClientGenerator generator, TypeResolverBase typeResolver) : base(parameterName, variableName, typeName, parameter, allParameters, settings, generator, typeResolver)
        {
        }

        /// <summary>
        /// 是否排序后最后项
        /// </summary>
        public bool IsSortLast { get; set; }
        
        /// <summary>
        /// KindName
        /// </summary>
        public string KindName => base.Kind.ToString();
    }
}