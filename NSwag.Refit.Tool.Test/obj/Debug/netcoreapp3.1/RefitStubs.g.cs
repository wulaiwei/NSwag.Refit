﻿// <auto-generated />
using System;
using System.Net.Http;
using System.Collections.Generic;
using NSwag.Refit.Tool.Test.RefitInternalGenerated;

/* ******** Hey You! *********
 *
 * This is a generated file, and gets rewritten every time you build the
 * project. If you want to edit it, you need to edit the mustache template
 * in the Refit package */

#pragma warning disable
namespace NSwag.Refit.Tool.Test.RefitInternalGenerated
{
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
    sealed class PreserveAttribute : Attribute
    {

        //
        // Fields
        //
        public bool AllMembers;

        public bool Conditional;
    }
}
#pragma warning restore

#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#pragma warning disable CS8669 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context. Auto-generated code requires an explicit '#nullable' directive in source.
namespace Cms
{
    using global::System.Threading.Tasks;
    using global::System.Collections.Generic;
    using global::Refit;

    /// <inheritdoc />
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [global::System.Diagnostics.DebuggerNonUserCode]
    [Preserve]
    [global::System.Reflection.Obfuscation(Exclude=true)]
    partial class AutoGeneratedIBannerController : IBannerController
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        /// <inheritdoc />
        public AutoGeneratedIBannerController(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        Task<StandResponseOfLong> IBannerController.InsertBannerBlockUsingPOSTAsync(BannerBlockAddReq addReq)
        {
            var arguments = new object[] { addReq };
            var func = requestBuilder.BuildRestResultFuncForMethod("InsertBannerBlockUsingPOSTAsync", new Type[] { typeof(BannerBlockAddReq) });
            return (Task<StandResponseOfLong>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfInt> IBannerController.DeleteBannerBlockUsingPOSTAsync(long sysno)
        {
            var arguments = new object[] { sysno };
            var func = requestBuilder.BuildRestResultFuncForMethod("DeleteBannerBlockUsingPOSTAsync", new Type[] { typeof(long) });
            return (Task<StandResponseOfInt>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfPageResultOfBannerBlockDTO> IBannerController.QueryPagedBannerBlockUsingPOSTAsync(BannerBlockQueryReq queryReq)
        {
            var arguments = new object[] { queryReq };
            var func = requestBuilder.BuildRestResultFuncForMethod("QueryPagedBannerBlockUsingPOSTAsync", new Type[] { typeof(BannerBlockQueryReq) });
            return (Task<StandResponseOfPageResultOfBannerBlockDTO>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfInt> IBannerController.UpdateBannerBlockUsingPOSTAsync(BannerBlockUpdateReq req)
        {
            var arguments = new object[] { req };
            var func = requestBuilder.BuildRestResultFuncForMethod("UpdateBannerBlockUsingPOSTAsync", new Type[] { typeof(BannerBlockUpdateReq) });
            return (Task<StandResponseOfInt>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfBannerBlockDTO> IBannerController.GetBannerBlockUsingGETAsync(long sysno)
        {
            var arguments = new object[] { sysno };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetBannerBlockUsingGETAsync", new Type[] { typeof(long) });
            return (Task<StandResponseOfBannerBlockDTO>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfInt> IBannerController.BatchDisableUsingPOSTAsync(IEnumerable<long> sysnos)
        {
            var arguments = new object[] { sysnos };
            var func = requestBuilder.BuildRestResultFuncForMethod("BatchDisableUsingPOSTAsync", new Type[] { typeof(IEnumerable<long>) });
            return (Task<StandResponseOfInt>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfInt> IBannerController.BatchEnableUsingPOSTAsync(IEnumerable<long> sysnos)
        {
            var arguments = new object[] { sysnos };
            var func = requestBuilder.BuildRestResultFuncForMethod("BatchEnableUsingPOSTAsync", new Type[] { typeof(IEnumerable<long>) });
            return (Task<StandResponseOfInt>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfLong> IBannerController.InsertBannerInfoUsingPOSTAsync(BannerInfoAddReq addReq)
        {
            var arguments = new object[] { addReq };
            var func = requestBuilder.BuildRestResultFuncForMethod("InsertBannerInfoUsingPOSTAsync", new Type[] { typeof(BannerInfoAddReq) });
            return (Task<StandResponseOfLong>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfInt> IBannerController.DeleteBannerInfoUsingPOSTAsync(long sysno)
        {
            var arguments = new object[] { sysno };
            var func = requestBuilder.BuildRestResultFuncForMethod("DeleteBannerInfoUsingPOSTAsync", new Type[] { typeof(long) });
            return (Task<StandResponseOfInt>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfPageResultOfBannerInfoDTO> IBannerController.QueryPagedBannerInfoUsingPOSTAsync(BannerInfoQueryReq queryReq)
        {
            var arguments = new object[] { queryReq };
            var func = requestBuilder.BuildRestResultFuncForMethod("QueryPagedBannerInfoUsingPOSTAsync", new Type[] { typeof(BannerInfoQueryReq) });
            return (Task<StandResponseOfPageResultOfBannerInfoDTO>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfInt> IBannerController.UpdateBannerInfoUsingPOSTAsync(BannerInfoUpdateReq req)
        {
            var arguments = new object[] { req };
            var func = requestBuilder.BuildRestResultFuncForMethod("UpdateBannerInfoUsingPOSTAsync", new Type[] { typeof(BannerInfoUpdateReq) });
            return (Task<StandResponseOfInt>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfBannerInfoDTO> IBannerController.GetBannerInfoUsingGETAsync(long sysno)
        {
            var arguments = new object[] { sysno };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetBannerInfoUsingGETAsync", new Type[] { typeof(long) });
            return (Task<StandResponseOfBannerInfoDTO>)func(Client, arguments);
        }
    }
}

namespace Cms
{
    using global::System.Threading.Tasks;
    using global::System.Collections.Generic;
    using global::Refit;

    /// <inheritdoc />
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [global::System.Diagnostics.DebuggerNonUserCode]
    [Preserve]
    [global::System.Reflection.Obfuscation(Exclude=true)]
    partial class AutoGeneratedIHelpInfoController : IHelpInfoController
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        /// <inheritdoc />
        public AutoGeneratedIHelpInfoController(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        Task<StandResponseOfBoolean> IHelpInfoController.DeleteNodeBySysNoUsingGETAsync(long sysno)
        {
            var arguments = new object[] { sysno };
            var func = requestBuilder.BuildRestResultFuncForMethod("DeleteNodeBySysNoUsingGETAsync", new Type[] { typeof(long) });
            return (Task<StandResponseOfBoolean>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfHelpInfoDO> IHelpInfoController.GetUsingGETAsync(long sysno)
        {
            var arguments = new object[] { sysno };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetUsingGETAsync", new Type[] { typeof(long) });
            return (Task<StandResponseOfHelpInfoDO>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfLong> IHelpInfoController.InsertChildUsingPOSTAsync(HelpInfoAddChildReq req)
        {
            var arguments = new object[] { req };
            var func = requestBuilder.BuildRestResultFuncForMethod("InsertChildUsingPOSTAsync", new Type[] { typeof(HelpInfoAddChildReq) });
            return (Task<StandResponseOfLong>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfLong> IHelpInfoController.InsertLeafUsingPOSTAsync(HelpInfoAddLeafReq req)
        {
            var arguments = new object[] { req };
            var func = requestBuilder.BuildRestResultFuncForMethod("InsertLeafUsingPOSTAsync", new Type[] { typeof(HelpInfoAddLeafReq) });
            return (Task<StandResponseOfLong>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfListOfHelpInfoTreeDTO> IHelpInfoController.ListUsingGETAsync(string systemId)
        {
            var arguments = new object[] { systemId };
            var func = requestBuilder.BuildRestResultFuncForMethod("ListUsingGETAsync", new Type[] { typeof(string) });
            return (Task<StandResponseOfListOfHelpInfoTreeDTO>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfBoolean> IHelpInfoController.MoveDownUsingGETAsync(long sysno)
        {
            var arguments = new object[] { sysno };
            var func = requestBuilder.BuildRestResultFuncForMethod("MoveDownUsingGETAsync", new Type[] { typeof(long) });
            return (Task<StandResponseOfBoolean>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfBoolean> IHelpInfoController.MoveUpUsingGETAsync(long sysno)
        {
            var arguments = new object[] { sysno };
            var func = requestBuilder.BuildRestResultFuncForMethod("MoveUpUsingGETAsync", new Type[] { typeof(long) });
            return (Task<StandResponseOfBoolean>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfBoolean> IHelpInfoController.SaveContentUsingPOSTAsync(HelpInfoContentEditReq req)
        {
            var arguments = new object[] { req };
            var func = requestBuilder.BuildRestResultFuncForMethod("SaveContentUsingPOSTAsync", new Type[] { typeof(HelpInfoContentEditReq) });
            return (Task<StandResponseOfBoolean>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfBoolean> IHelpInfoController.SubmitContentUsingPOSTAsync(HelpInfoContentEditReq req)
        {
            var arguments = new object[] { req };
            var func = requestBuilder.BuildRestResultFuncForMethod("SubmitContentUsingPOSTAsync", new Type[] { typeof(HelpInfoContentEditReq) });
            return (Task<StandResponseOfBoolean>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfBoolean> IHelpInfoController.UpdateNameBySysNoUsingPOSTAsync(HelpInfoEditReq req)
        {
            var arguments = new object[] { req };
            var func = requestBuilder.BuildRestResultFuncForMethod("UpdateNameBySysNoUsingPOSTAsync", new Type[] { typeof(HelpInfoEditReq) });
            return (Task<StandResponseOfBoolean>)func(Client, arguments);
        }
    }
}

namespace Cms
{
    using global::System.Threading.Tasks;
    using global::System.Collections.Generic;
    using global::Refit;

    /// <inheritdoc />
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [global::System.Diagnostics.DebuggerNonUserCode]
    [Preserve]
    [global::System.Reflection.Obfuscation(Exclude=true)]
    partial class AutoGeneratedIMetricsController : IMetricsController
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        /// <inheritdoc />
        public AutoGeneratedIMetricsController(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        Task IMetricsController.MetricsUsingGETAsync()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("MetricsUsingGETAsync", new Type[] {  });
            return (Task)func(Client, arguments);
        }
    }
}

namespace Cms
{
    using global::System.Threading.Tasks;
    using global::System.Collections.Generic;
    using global::Refit;

    /// <inheritdoc />
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [global::System.Diagnostics.DebuggerNonUserCode]
    [Preserve]
    [global::System.Reflection.Obfuscation(Exclude=true)]
    partial class AutoGeneratedISiteBlockController : ISiteBlockController
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        /// <inheritdoc />
        public AutoGeneratedISiteBlockController(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        Task<StandResponse> ISiteBlockController.DeleteSiteBlockUsingPOSTAsync(long sysno)
        {
            var arguments = new object[] { sysno };
            var func = requestBuilder.BuildRestResultFuncForMethod("DeleteSiteBlockUsingPOSTAsync", new Type[] { typeof(long) });
            return (Task<StandResponse>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfInt> ISiteBlockController.CreateSiteBlockUsingPOSTAsync(SiteBlockAddReq addReq)
        {
            var arguments = new object[] { addReq };
            var func = requestBuilder.BuildRestResultFuncForMethod("CreateSiteBlockUsingPOSTAsync", new Type[] { typeof(SiteBlockAddReq) });
            return (Task<StandResponseOfInt>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfListOfSiteBlockDTO> ISiteBlockController.SelectSiteBlockUsingGETAsync(string systemId)
        {
            var arguments = new object[] { systemId };
            var func = requestBuilder.BuildRestResultFuncForMethod("SelectSiteBlockUsingGETAsync", new Type[] { typeof(string) });
            return (Task<StandResponseOfListOfSiteBlockDTO>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfInt> ISiteBlockController.UpdateSiteBlockUsingPOSTAsync(SiteBlockUpdateReq updateReq)
        {
            var arguments = new object[] { updateReq };
            var func = requestBuilder.BuildRestResultFuncForMethod("UpdateSiteBlockUsingPOSTAsync", new Type[] { typeof(SiteBlockUpdateReq) });
            return (Task<StandResponseOfInt>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfSiteBlockDTO> ISiteBlockController.GetSiteBlockUsingGETAsync(long sysno)
        {
            var arguments = new object[] { sysno };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetSiteBlockUsingGETAsync", new Type[] { typeof(long) });
            return (Task<StandResponseOfSiteBlockDTO>)func(Client, arguments);
        }
    }
}

namespace Cms
{
    using global::System.Threading.Tasks;
    using global::System.Collections.Generic;
    using global::Refit;

    /// <inheritdoc />
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [global::System.Diagnostics.DebuggerNonUserCode]
    [Preserve]
    [global::System.Reflection.Obfuscation(Exclude=true)]
    partial class AutoGeneratedISiteNavigationController : ISiteNavigationController
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        /// <inheritdoc />
        public AutoGeneratedISiteNavigationController(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        Task<StandResponse> ISiteNavigationController.DeleteSiteNavigationUsingPOSTAsync(long sysno)
        {
            var arguments = new object[] { sysno };
            var func = requestBuilder.BuildRestResultFuncForMethod("DeleteSiteNavigationUsingPOSTAsync", new Type[] { typeof(long) });
            return (Task<StandResponse>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfListOfSiteNavigationDTO> ISiteNavigationController.SelectByBlockSysnoUsingGETAsync(long blockSysno)
        {
            var arguments = new object[] { blockSysno };
            var func = requestBuilder.BuildRestResultFuncForMethod("SelectByBlockSysnoUsingGETAsync", new Type[] { typeof(long) });
            return (Task<StandResponseOfListOfSiteNavigationDTO>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfListOfSiteNavigationDTO> ISiteNavigationController.SelectByParentSysnoUsingGETAsync(long parentSysno)
        {
            var arguments = new object[] { parentSysno };
            var func = requestBuilder.BuildRestResultFuncForMethod("SelectByParentSysnoUsingGETAsync", new Type[] { typeof(long) });
            return (Task<StandResponseOfListOfSiteNavigationDTO>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponse> ISiteNavigationController.MoveNavigationUsingPOSTAsync(long? sysno, int? action)
        {
            var arguments = new object[] { sysno, action };
            var func = requestBuilder.BuildRestResultFuncForMethod("MoveNavigationUsingPOSTAsync", new Type[] { ToNullable(typeof(long)), ToNullable(typeof(int)) });
            return (Task<StandResponse>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfInt> ISiteNavigationController.CreateSiteNavigationUsingPOSTAsync(SiteNavigationAddReq addReq)
        {
            var arguments = new object[] { addReq };
            var func = requestBuilder.BuildRestResultFuncForMethod("CreateSiteNavigationUsingPOSTAsync", new Type[] { typeof(SiteNavigationAddReq) });
            return (Task<StandResponseOfInt>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfInt> ISiteNavigationController.UpdateSiteNavigationUsingPOSTAsync(SiteNavigationUpdateReq updateReq)
        {
            var arguments = new object[] { updateReq };
            var func = requestBuilder.BuildRestResultFuncForMethod("UpdateSiteNavigationUsingPOSTAsync", new Type[] { typeof(SiteNavigationUpdateReq) });
            return (Task<StandResponseOfInt>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfSiteNavigationDTO> ISiteNavigationController.SelectBySysnoUsingGETAsync(long sysno)
        {
            var arguments = new object[] { sysno };
            var func = requestBuilder.BuildRestResultFuncForMethod("SelectBySysnoUsingGETAsync", new Type[] { typeof(long) });
            return (Task<StandResponseOfSiteNavigationDTO>)func(Client, arguments);
        }

        private static Type ToNullable(Type type) => !type.IsValueType ? type : typeof(Nullable<>).MakeGenericType(type);
    }
}

namespace Cms
{
    using global::System.Threading.Tasks;
    using global::System.Collections.Generic;
    using global::Refit;

    /// <inheritdoc />
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [global::System.Diagnostics.DebuggerNonUserCode]
    [Preserve]
    [global::System.Reflection.Obfuscation(Exclude=true)]
    partial class AutoGeneratedISmsController : ISmsController
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        /// <inheritdoc />
        public AutoGeneratedISmsController(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        Task<StandResponseOfBoolean> ISmsController.CheckCredentialUsingGETAsync(string credential)
        {
            var arguments = new object[] { credential };
            var func = requestBuilder.BuildRestResultFuncForMethod("CheckCredentialUsingGETAsync", new Type[] { typeof(string) });
            return (Task<StandResponseOfBoolean>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfBoolean> ISmsController.CheckVerifyCodeUsingPOSTAsync(string cellPhone, string smsInstructions, string code)
        {
            var arguments = new object[] { cellPhone, smsInstructions, code };
            var func = requestBuilder.BuildRestResultFuncForMethod("CheckVerifyCodeUsingPOSTAsync", new Type[] { typeof(string), typeof(string), typeof(string) });
            return (Task<StandResponseOfBoolean>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfBoolean> ISmsController.CheckVerifyCodeV2UsingPOSTAsync(CheckVerifyCodeReq req)
        {
            var arguments = new object[] { req };
            var func = requestBuilder.BuildRestResultFuncForMethod("CheckVerifyCodeV2UsingPOSTAsync", new Type[] { typeof(CheckVerifyCodeReq) });
            return (Task<StandResponseOfBoolean>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfString> ISmsController.CheckVerifyCodeWithCredentialUsingPOSTAsync(CheckVerifyCodeWithCredentialReq req)
        {
            var arguments = new object[] { req };
            var func = requestBuilder.BuildRestResultFuncForMethod("CheckVerifyCodeWithCredentialUsingPOSTAsync", new Type[] { typeof(CheckVerifyCodeWithCredentialReq) });
            return (Task<StandResponseOfString>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfJSONObject> ISmsController.GenerateVerifyCodeUsingPOSTAsync(string cellPhone)
        {
            var arguments = new object[] { cellPhone };
            var func = requestBuilder.BuildRestResultFuncForMethod("GenerateVerifyCodeUsingPOSTAsync", new Type[] { typeof(string) });
            return (Task<StandResponseOfJSONObject>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfJSONObject> ISmsController.GenerateVerifyCodeWithExpireUsingPOSTAsync(string cellPhone, long expireTime)
        {
            var arguments = new object[] { cellPhone, expireTime };
            var func = requestBuilder.BuildRestResultFuncForMethod("GenerateVerifyCodeWithExpireUsingPOSTAsync", new Type[] { typeof(string), typeof(long) });
            return (Task<StandResponseOfJSONObject>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfSmsDTO> ISmsController.GetByBizSysnoUsingPOSTAsync(long bizSysno)
        {
            var arguments = new object[] { bizSysno };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetByBizSysnoUsingPOSTAsync", new Type[] { typeof(long) });
            return (Task<StandResponseOfSmsDTO>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfPageResultOfSmsDTO> ISmsController.QueryPagedUsingPOSTAsync(SmsQueryReq req)
        {
            var arguments = new object[] { req };
            var func = requestBuilder.BuildRestResultFuncForMethod("QueryPagedUsingPOSTAsync", new Type[] { typeof(SmsQueryReq) });
            return (Task<StandResponseOfPageResultOfSmsDTO>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfBoolean> ISmsController.SendUsingPOSTAsync(SmsSendReq req)
        {
            var arguments = new object[] { req };
            var func = requestBuilder.BuildRestResultFuncForMethod("SendUsingPOSTAsync", new Type[] { typeof(SmsSendReq) });
            return (Task<StandResponseOfBoolean>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfBoolean> ISmsController.SendAgainUsingPOSTAsync(long sysno)
        {
            var arguments = new object[] { sysno };
            var func = requestBuilder.BuildRestResultFuncForMethod("SendAgainUsingPOSTAsync", new Type[] { typeof(long) });
            return (Task<StandResponseOfBoolean>)func(Client, arguments);
        }
    }
}

namespace Cms
{
    using global::System.Threading.Tasks;
    using global::System.Collections.Generic;
    using global::Refit;

    /// <inheritdoc />
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [global::System.Diagnostics.DebuggerNonUserCode]
    [Preserve]
    [global::System.Reflection.Obfuscation(Exclude=true)]
    partial class AutoGeneratedISmsTemplateController : ISmsTemplateController
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        /// <inheritdoc />
        public AutoGeneratedISmsTemplateController(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        Task<StandResponseOfSmsTemplateDO> ISmsTemplateController.GetShortMessageTemplateUsingGETAsync(long sysNo)
        {
            var arguments = new object[] { sysNo };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetShortMessageTemplateUsingGETAsync", new Type[] { typeof(long) });
            return (Task<StandResponseOfSmsTemplateDO>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfInt> ISmsTemplateController.InsertUsingPOSTAsync(SmsTemplateAddReq req)
        {
            var arguments = new object[] { req };
            var func = requestBuilder.BuildRestResultFuncForMethod("InsertUsingPOSTAsync", new Type[] { typeof(SmsTemplateAddReq) });
            return (Task<StandResponseOfInt>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfPageResultOfSmsTemplateDO> ISmsTemplateController.GetShortMessageTemplateListUsingPOSTAsync(SmsTemplateQueryReq req)
        {
            var arguments = new object[] { req };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetShortMessageTemplateListUsingPOSTAsync", new Type[] { typeof(SmsTemplateQueryReq) });
            return (Task<StandResponseOfPageResultOfSmsTemplateDO>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfInt> ISmsTemplateController.UpdateUsingPOSTAsync(SmsTemplateUpdateReq req)
        {
            var arguments = new object[] { req };
            var func = requestBuilder.BuildRestResultFuncForMethod("UpdateUsingPOSTAsync", new Type[] { typeof(SmsTemplateUpdateReq) });
            return (Task<StandResponseOfInt>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfInt> ISmsTemplateController.UpdateStatusUsingPOSTAsync(SmsTemplateStatusReq req)
        {
            var arguments = new object[] { req };
            var func = requestBuilder.BuildRestResultFuncForMethod("UpdateStatusUsingPOSTAsync", new Type[] { typeof(SmsTemplateStatusReq) });
            return (Task<StandResponseOfInt>)func(Client, arguments);
        }
    }
}

namespace Cms
{
    using global::System.Threading.Tasks;
    using global::System.Collections.Generic;
    using global::Refit;

    /// <inheritdoc />
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [global::System.Diagnostics.DebuggerNonUserCode]
    [Preserve]
    [global::System.Reflection.Obfuscation(Exclude=true)]
    partial class AutoGeneratedISystemMessageController : ISystemMessageController
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        /// <inheritdoc />
        public AutoGeneratedISystemMessageController(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        Task<StandResponseOfSystemMessageDO> ISystemMessageController.GetSystemMessageUsingGETAsync(long sysNo)
        {
            var arguments = new object[] { sysNo };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetSystemMessageUsingGETAsync", new Type[] { typeof(long) });
            return (Task<StandResponseOfSystemMessageDO>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfLong> ISystemMessageController.InsertUsingPOST_1Async(SystemMessageAddReq req)
        {
            var arguments = new object[] { req };
            var func = requestBuilder.BuildRestResultFuncForMethod("InsertUsingPOST_1Async", new Type[] { typeof(SystemMessageAddReq) });
            return (Task<StandResponseOfLong>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfBoolean> ISystemMessageController.ManagementItemDeleteUsingPOSTAsync(ManagementItemUpdateReq req)
        {
            var arguments = new object[] { req };
            var func = requestBuilder.BuildRestResultFuncForMethod("ManagementItemDeleteUsingPOSTAsync", new Type[] { typeof(ManagementItemUpdateReq) });
            return (Task<StandResponseOfBoolean>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfLong> ISystemMessageController.ManagementItemInsertUsingPOSTAsync(ManagementItemAddReq req)
        {
            var arguments = new object[] { req };
            var func = requestBuilder.BuildRestResultFuncForMethod("ManagementItemInsertUsingPOSTAsync", new Type[] { typeof(ManagementItemAddReq) });
            return (Task<StandResponseOfLong>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfBoolean> ISystemMessageController.ManagementItemUpdateUsingPOSTAsync(ManagementItemUpdateReq req)
        {
            var arguments = new object[] { req };
            var func = requestBuilder.BuildRestResultFuncForMethod("ManagementItemUpdateUsingPOSTAsync", new Type[] { typeof(ManagementItemUpdateReq) });
            return (Task<StandResponseOfBoolean>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfListOfManagementItemDO> ISystemMessageController.ManagementItemsSelectUsingPOSTAsync(ManagementItemQueryReq req)
        {
            var arguments = new object[] { req };
            var func = requestBuilder.BuildRestResultFuncForMethod("ManagementItemsSelectUsingPOSTAsync", new Type[] { typeof(ManagementItemQueryReq) });
            return (Task<StandResponseOfListOfManagementItemDO>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfPageResultOfSystemMessageDO> ISystemMessageController.GetSystemMessageListUsingPOSTAsync(SystemMessageQueryReq req)
        {
            var arguments = new object[] { req };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetSystemMessageListUsingPOSTAsync", new Type[] { typeof(SystemMessageQueryReq) });
            return (Task<StandResponseOfPageResultOfSystemMessageDO>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfSystemMessageDO> ISystemMessageController.SelectByStatusUsingGETAsync(long sysNo, int status)
        {
            var arguments = new object[] { sysNo, status };
            var func = requestBuilder.BuildRestResultFuncForMethod("SelectByStatusUsingGETAsync", new Type[] { typeof(long), typeof(int) });
            return (Task<StandResponseOfSystemMessageDO>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfPageResultOfSystemMessageDO> ISystemMessageController.SelectNewsPageUsingPOSTAsync(NewsQueryReq req)
        {
            var arguments = new object[] { req };
            var func = requestBuilder.BuildRestResultFuncForMethod("SelectNewsPageUsingPOSTAsync", new Type[] { typeof(NewsQueryReq) });
            return (Task<StandResponseOfPageResultOfSystemMessageDO>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfInt> ISystemMessageController.UpdateUsingPOST_1Async(SystemMessageUpdateReq req)
        {
            var arguments = new object[] { req };
            var func = requestBuilder.BuildRestResultFuncForMethod("UpdateUsingPOST_1Async", new Type[] { typeof(SystemMessageUpdateReq) });
            return (Task<StandResponseOfInt>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfInt> ISystemMessageController.UpdateStatusUsingPOST_1Async(SystemMessageStatusReq req)
        {
            var arguments = new object[] { req };
            var func = requestBuilder.BuildRestResultFuncForMethod("UpdateStatusUsingPOST_1Async", new Type[] { typeof(SystemMessageStatusReq) });
            return (Task<StandResponseOfInt>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<StandResponseOfInt> ISystemMessageController.UpdateStickyUsingPOSTAsync(SystemMessageStickyReq req)
        {
            var arguments = new object[] { req };
            var func = requestBuilder.BuildRestResultFuncForMethod("UpdateStickyUsingPOSTAsync", new Type[] { typeof(SystemMessageStickyReq) });
            return (Task<StandResponseOfInt>)func(Client, arguments);
        }
    }
}

#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#pragma warning restore CS8669 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context. Auto-generated code requires an explicit '#nullable' directive in source.
