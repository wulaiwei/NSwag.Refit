﻿//-----------------------------------------------------------------------
// <copyright file="CSharpControllerOperationModel.cs" company="NSwag">
//     Copyright (c) Rico Suter. All rights reserved.
// </copyright>
// <license>https://github.com/RicoSuter/NSwag/blob/master/LICENSE.md</license>
// <author>Rico Suter, mail@rsuter.com</author>
//-----------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;
using Humanizer;
using NJsonSchema.CodeGeneration.CSharp;
using NSwag.CodeGeneration.CSharp.Models;

namespace NSwag.CodeGeneration.CSharp.Refit.Models
{
    /// <summary>The CSharp controller operation model.</summary>
    public class CSharpRefitOperationModel : CSharpOperationModel
    {
        private readonly CSharpRefitGeneratorSettings _settings;
        private readonly OpenApiOperation _operation;
        private readonly CSharpGeneratorBase _generator;
        private readonly CSharpTypeResolver _resolver;

        /// <summary>Initializes a new instance of the <see cref="CSharpRefitOperationModel" /> class.</summary>
        /// <param name="operation">The operation.</param>
        /// <param name="settings">The settings.</param>
        /// <param name="generator">The generator.</param>
        /// <param name="resolver">The resolver.</param>
        public CSharpRefitOperationModel(OpenApiOperation operation, CSharpRefitGeneratorSettings settings,
            CSharpRefitGenerator generator, CSharpTypeResolver resolver)
            : base(operation, settings, generator, resolver)
        {
            _operation = operation;
            _generator = generator;
            _resolver = resolver;
            _settings = settings;
        }

        /// <summary>
        /// HeaderInAction
        /// </summary>
        public bool HeaderInAction => _settings.HeaderInAction;

        /// <summary>
        /// NoHeaderParameters
        /// </summary>
        public List<RefitParameterModel> NoHeaderParameters
        {
            get
            {
                var data = RefitParameters.Where(x => x?.IsHeader == false).ToList();
                foreach (var item in data.Where(item => data.IndexOf(item) == data.Count - 1))
                {
                    item.IsSortLast = true;
                }

                return data;
            }
        }

        /// <summary>
        /// Parameters
        /// </summary>
        public IList<OpenApiParameter> BaseParameters => base.GetActualParameters();

        /// <summary>
        /// RefitParameterModels
        /// </summary>
        public List<RefitParameterModel> RefitParameters => BaseParameters.Select(parameter =>
                new RefitParameterModel(parameter.Name, GetParameterVariableName(parameter, _operation.Parameters),
                    ResolveParameterType(parameter), parameter, BaseParameters,
                    _settings.CodeGeneratorSettings,
                    _generator,
                    _resolver))
            .ToList();

        /// <summary>
        /// 格式化
        /// </summary>
        // ReSharper disable once IdentifierTypo
        public string PascalizeResultType => this.ResultType.Replace("»", "").Replace("«", " Of ").Pascalize();

        public override string ResultType
        {
            get
            {
                if (_settings.UseActionResultType)
                {
                    return SyncResultType == "void" || SyncResultType == "FileResponse"
                        ? "Task"
                        : "Task<" + SyncResultType + ">";
                }

                return base.ResultType;
            }
        }
    }
}