﻿using System;
using System.Collections.Generic;
using System.Linq;
using NJsonSchema;
using NJsonSchema.CodeGeneration;
using NJsonSchema.CodeGeneration.CSharp;
using NSwag.CodeGeneration.CSharp.Models;
using NSwag.CodeGeneration.CSharp.Refit.Models;

namespace NSwag.CodeGeneration.CSharp.Refit
{
    public class CSharpRefitGenerator : CSharpGeneratorBase
    {
        private readonly OpenApiDocument _document;

        /// <summary>Initializes a new instance of the <see cref="CSharpControllerGenerator" /> class.</summary>
        /// <param name="document">The Swagger document.</param>
        /// <param name="settings">The settings.</param>
        /// <exception cref="ArgumentNullException"><paramref name="document" /> is <see langword="null" />.</exception>
        public CSharpRefitGenerator(OpenApiDocument document, CSharpRefitGeneratorSettings settings)
            : this(document, settings, CreateRefitResolverWithExceptionSchema(settings.CSharpGeneratorSettings, document))
        {
        }
        
        /// <summary>Creates a new resolver, adds the given schema definitions and registers an exception schema if available.</summary>
        /// <param name="settings">The settings.</param>
        /// <param name="document">The document </param>
        public static CSharpTypeResolver CreateRefitResolverWithExceptionSchema(
            CSharpGeneratorSettings settings,
            OpenApiDocument document)
        {
            JsonSchema exceptionSchema = document.Definitions.ContainsKey("Exception") ? document.Definitions["Exception"] : (JsonSchema) null;
            CSharpTypeResolver csharpTypeResolver = new RefitCSharpTypeResolver(settings, exceptionSchema);
            csharpTypeResolver.RegisterSchemaDefinitions((IDictionary<string, JsonSchema>) document.Definitions.Where<KeyValuePair<string, JsonSchema>>((Func<KeyValuePair<string, JsonSchema>, bool>) (p => p.Value != exceptionSchema)).ToDictionary<KeyValuePair<string, JsonSchema>, string, JsonSchema>((Func<KeyValuePair<string, JsonSchema>, string>) (p => p.Key), (Func<KeyValuePair<string, JsonSchema>, JsonSchema>) (p => p.Value)));
            return csharpTypeResolver;
        }

        /// <summary>Initializes a new instance of the <see cref="CSharpControllerGenerator" /> class.</summary>
        /// <param name="document">The Swagger document.</param>
        /// <param name="settings">The settings.</param>
        /// <param name="resolver">The resolver.</param>
        /// <exception cref="ArgumentNullException"><paramref name="document" /> is <see langword="null" />.</exception>
        public CSharpRefitGenerator(OpenApiDocument document, CSharpRefitGeneratorSettings settings,
            CSharpTypeResolver resolver)
            : base(document, settings, resolver)
        {
            _document = document ?? throw new ArgumentNullException(nameof(document));
            Settings = settings ?? throw new ArgumentNullException(nameof(settings));
        }

        /// <summary>Gets or sets the generator settings.</summary>
        public CSharpRefitGeneratorSettings Settings { get; set; }

        /// <summary>Gets the base settings.</summary>
        public override ClientGeneratorBaseSettings BaseSettings => Settings;

        /// <summary>Generates the client types.</summary>
        /// <returns>The code artifact collection.</returns>
        protected override IEnumerable<CodeArtifact> GenerateAllClientTypes()
        {
            var artifacts = base.GenerateAllClientTypes().ToList();
            return artifacts;
        }

        public IEnumerable<CodeArtifact> GetAllClientType()
        {
            var allClientTypes = this.GenerateAllClientTypes();
            return allClientTypes;
        }

        public IEnumerable<CodeArtifact> GetAllGenerateDtoType()
        {
            var allClientTypes = base.GenerateDtoTypes();
            return allClientTypes;
        }

        /// <summary>Generates the client class.</summary>
        /// <param name="controllerName">Name of the controller.</param>
        /// <param name="controllerClassName">Name of the controller class.</param>
        /// <param name="operations">The operations.</param>
        /// <returns>The code.</returns>
        protected override IEnumerable<CodeArtifact> GenerateClientTypes(string controllerName,
            string controllerClassName, IEnumerable<CSharpOperationModel> operations)
        {
            var cSharpOperationModels = operations as CSharpOperationModel[] ?? operations.ToArray();
            OpenApiTag tag = null;
            var currentPath= cSharpOperationModels.FirstOrDefault()?.Path;
            if (!string.IsNullOrWhiteSpace(currentPath))
            {
                var tagName = _document?.Operations?.FirstOrDefault(x =>  x.Path.EndsWith(currentPath))
                    ?.Operation?.Tags
                    ?.FirstOrDefault(); 
                tag = _document?.Tags.FirstOrDefault(x => x.Name == tagName);
            }

            var model = new CSharpRefitTemplateModel(controllerClassName, cSharpOperationModels, _document, Settings, tag);

            var template = Settings.CodeGeneratorSettings.TemplateFactory.CreateTemplate("CSharp", "Refit", model);
            var data = new CodeArtifact(model.Class, CodeArtifactType.Class, CodeArtifactLanguage.CSharp,
                CodeArtifactCategory.Client, template);
            yield return data;
        }

        /// <summary>Creates an operation model.</summary>
        /// <param name="operation">The operation.</param>
        /// <param name="settings">The settings.</param>
        /// <returns>The operation model.</returns>
        protected override CSharpOperationModel CreateOperationModel(OpenApiOperation operation,
            ClientGeneratorBaseSettings settings)
        {
            return new CSharpRefitOperationModel(operation, (CSharpRefitGeneratorSettings) settings, this,
                (CSharpTypeResolver) Resolver);
        }
    }
}