using Humanizer;
using NJsonSchema;
using NJsonSchema.CodeGeneration.CSharp;

namespace NSwag.CodeGeneration.CSharp.Refit.Models
{
    public class RefitCSharpTypeResolver:CSharpTypeResolver
    {
        public RefitCSharpTypeResolver(CSharpGeneratorSettings settings) : base(settings)
        {
        }

        public RefitCSharpTypeResolver(CSharpGeneratorSettings settings, JsonSchema exceptionSchema) : base(settings, exceptionSchema)
        {
        }

        public override string GetOrGenerateTypeName(JsonSchema schema, string typeNameHint)
        {
            var data= base.GetOrGenerateTypeName(schema, typeNameHint);
            return data.Replace("»", "").Replace("«", " Of ").Pascalize();
        }
    }
}