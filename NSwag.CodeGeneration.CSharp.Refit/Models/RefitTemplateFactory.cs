using System.IO;
using System.Reflection;
using NJsonSchema.CodeGeneration;

namespace NSwag.CodeGeneration.CSharp.Refit.Models
{
    public class RefitTemplateFactory : NJsonSchema.CodeGeneration.DefaultTemplateFactory
    {
        /// <summary>Initializes a new instance of the <see cref="RefitTemplateFactory" /> class.</summary>
        /// <param name="settings">The settings.</param>
        /// <param name="assemblies">The assemblies.</param>
        public RefitTemplateFactory(CodeGeneratorSettingsBase settings, Assembly[] assemblies)
            : base(settings, assemblies)
        {

        }

        /// <summary>Gets the current toolchain version.</summary>
        /// <returns>The toolchain version.</returns>
        protected override string GetToolchainVersion()
        {
            return OpenApiDocument.ToolchainVersion + " (NJsonSchema v" + base.GetToolchainVersion() + ")";
        }

        /// <summary>Tries to load an embedded Liquid template.</summary>
        /// <param name="language">The language.</param>
        /// <param name="template">The template name.</param>
        /// <returns>The template.</returns>
        protected override string GetEmbeddedLiquidTemplate(string language, string template)
        {
            template = template.TrimEnd('!');
            var assembly = GetLiquidAssembly($"NSwag.CodeGeneration.{language}.Refit");
            var resourceName = $"NSwag.CodeGeneration.{language}.Refit.Templates." + template + ".liquid";

            var resource = assembly.GetManifestResourceStream(resourceName);
            if (resource == null) 
                return base.GetEmbeddedLiquidTemplate(language, template);
            using var reader = new StreamReader(resource);
            return reader.ReadToEnd();

        }
    }
}