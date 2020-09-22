using System;
using System.IO;
using System.Reflection;
using System.Text;
using NJsonSchema.CodeGeneration;
using NJsonSchema.CodeGeneration.CSharp;
using NSwag.CodeGeneration.CSharp;
using NSwag.CodeGeneration.CSharp.Refit;
using NSwag.CodeGeneration.CSharp.Refit.Models;
using NSwag.CodeGeneration.OperationNameGenerators;

namespace NSwag.Refit.Tool
{
    class Program
    {
        static void Main(string[] args)
        {
             var swagger ="baseUrl";
             var result = OpenApiDocument.FromUrlAsync(swagger).Result;
            var clientSettings = new CSharpRefitGeneratorSettings
            {
                UseActionResultType = true,
                WrapResponses = false,
                OperationNameGenerator = new MultipleClientsFromFirstTagAndOperationIdGenerator()
            };
     
            clientSettings.CodeGeneratorSettings.TemplateFactory = new RefitTemplateFactory(clientSettings.CSharpGeneratorSettings, new Assembly[3]
            {
                typeof (CSharpGeneratorSettings).GetTypeInfo().Assembly,
                typeof (CSharpGeneratorBaseSettings).GetTypeInfo().Assembly,
                typeof (CSharpRefitGeneratorSettings).GetTypeInfo().Assembly
            });
            clientSettings.CSharpGeneratorSettings.Namespace = "Cms";
            clientSettings.CSharpGeneratorSettings.ArrayType = "List";
            clientSettings.CSharpGeneratorSettings.ArrayInstanceType = "List";
            clientSettings.ResponseArrayType = "ICollection";
            clientSettings.ResponseDictionaryType = "IDictionary";

            clientSettings.ParameterArrayType = "IEnumerable";
            clientSettings.ParameterDictionaryType = "IDictionary";
            var clientGenerator = new CSharpRefitGenerator(result, clientSettings);
            var data = clientGenerator.GetAllClientType();
            var models = clientGenerator.GetAllGenerateDtoType();
            var dir = Path.Combine("output",clientSettings.CSharpGeneratorSettings.Namespace);
            var apisPath = Path.Combine(dir, "HttpApis");
            var modelsPath = Path.Combine(dir, "HttpModels");

            Directory.CreateDirectory(apisPath);
            Directory.CreateDirectory(modelsPath);

            foreach (var api in data)
            {
                var file = Path.Combine(apisPath, $"{api.TypeName}.cs");
                File.WriteAllText(file, api.Code, Encoding.UTF8);
                Console.WriteLine($"输出接口文件：{file}");
            }
            foreach (var model in models)
            {
                var file = Path.Combine(modelsPath, $"{model.TypeName}.cs");
                File.WriteAllText(file, model.Code, Encoding.UTF8);
                Console.WriteLine($"输出模型文件：{file}");
            }
            Console.WriteLine("Hello World!");
        }
    }
}