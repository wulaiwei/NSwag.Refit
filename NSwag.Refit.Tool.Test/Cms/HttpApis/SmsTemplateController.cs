using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace Cms
{
    public interface ISmsTemplateController
    {
        /// <summary>使用sysNo短信系统信息</summary>
        /// <param name="sysNo">sysNo</param>
        /// <returns>OK</returns>
        [Get("v1/smsTemplate/getTemplate/{sysNo}")]
        [Headers("Authorization")]
        Task<StandResponseOfSmsTemplateDO> GetShortMessageTemplateUsingGETAsync([AliasAs("sysNo")] long sysNo);

        /// <summary>创建短信模板</summary>
        /// <param name="req">req</param>
        /// <returns>OK</returns>
        [Post("v1/smsTemplate/insert")]
        [Headers("Authorization")]
        Task<StandResponseOfInt> InsertUsingPOSTAsync([Body][AliasAs("req")] SmsTemplateAddReq req);

        /// <summary>短信系统信息</summary>
        /// <param name="req">req</param>
        /// <returns>OK</returns>
        [Post("v1/smsTemplate/list")]
        [Headers("Authorization")]
        Task<StandResponseOfPageResultOfSmsTemplateDO> GetShortMessageTemplateListUsingPOSTAsync([Body][AliasAs("req")] SmsTemplateQueryReq req);

        /// <summary>更新短信模板</summary>
        /// <param name="req">req</param>
        /// <returns>OK</returns>
        [Post("v1/smsTemplate/update")]
        [Headers("Authorization")]
        Task<StandResponseOfInt> UpdateUsingPOSTAsync([Body][AliasAs("req")] SmsTemplateUpdateReq req);

        /// <summary>更新短信模板状态</summary>
        /// <param name="req">req</param>
        /// <returns>OK</returns>
        [Post("v1/smsTemplate/updatestatus")]
        [Headers("Authorization")]
        Task<StandResponseOfInt> UpdateStatusUsingPOSTAsync([Body][AliasAs("req")] SmsTemplateStatusReq req);

    }
}