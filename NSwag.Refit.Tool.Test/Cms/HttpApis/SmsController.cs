using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace Cms
{
    public interface ISmsController
    {
        /// <summary>校验验证码通过后的凭证，成功后销毁</summary>
        /// <param name="credential">credential</param>
        /// <param name="authorization">获取accessToken后，传入Bearer +token访问</param>
        /// <returns>OK</returns>
        [Get("v1/sms/checkCredential")]
        [Headers("Authorization")]
        Task<StandResponseOfBoolean> CheckCredentialUsingGETAsync([Query][AliasAs("credential")] string credential);

        /// <summary>验证验证码</summary>
        /// <param name="cellPhone">cellPhone</param>
        /// <param name="smsInstructions">smsInstructions</param>
        /// <param name="code">code</param>
        /// <param name="authorization">获取accessToken后，传入Bearer +token访问</param>
        /// <returns>OK</returns>
        [Post("v1/sms/checkVerifyCode")]
        [Headers("Authorization")]
        Task<StandResponseOfBoolean> CheckVerifyCodeUsingPOSTAsync([Query][AliasAs("cellPhone")] string cellPhone,[Query][AliasAs("smsInstructions")] string smsInstructions,[Query][AliasAs("code")] string code);

        /// <summary>验证验证码</summary>
        /// <param name="req">req</param>
        /// <param name="authorization">获取accessToken后，传入Bearer +token访问</param>
        /// <returns>OK</returns>
        [Post("v1/sms/checkVerifyCodeV2")]
        [Headers("Authorization")]
        Task<StandResponseOfBoolean> CheckVerifyCodeV2UsingPOSTAsync([Body][AliasAs("req")] CheckVerifyCodeReq req);

        /// <summary>验证验证码（校验成功则返回唯一凭证）</summary>
        /// <param name="req">req</param>
        /// <param name="authorization">获取accessToken后，传入Bearer +token访问</param>
        /// <returns>OK</returns>
        [Post("v1/sms/checkVerifyCodeWithCredential")]
        [Headers("Authorization")]
        Task<StandResponseOfString> CheckVerifyCodeWithCredentialUsingPOSTAsync([Body][AliasAs("req")] CheckVerifyCodeWithCredentialReq req);

        /// <summary>获取验证码</summary>
        /// <param name="cellPhone">cellPhone</param>
        /// <param name="authorization">获取accessToken后，传入Bearer +token访问</param>
        /// <returns>OK</returns>
        [Post("v1/sms/generateVerifyCode")]
        [Headers("Authorization")]
        Task<StandResponseOfJSONObject> GenerateVerifyCodeUsingPOSTAsync([Query][AliasAs("cellPhone")] string cellPhone);

        /// <summary>获取验证码，设置有效期(默认为120秒)</summary>
        /// <param name="cellPhone">cellPhone</param>
        /// <param name="expireTime">expireTime</param>
        /// <param name="authorization">获取accessToken后，传入Bearer +token访问</param>
        /// <returns>OK</returns>
        [Post("v1/sms/generateVerifyCodeWithExpire")]
        [Headers("Authorization")]
        Task<StandResponseOfJSONObject> GenerateVerifyCodeWithExpireUsingPOSTAsync([Query][AliasAs("cellPhone")] string cellPhone,[Query][AliasAs("expireTime")] long expireTime);

        /// <summary>根据业务编号查询短信发送记录</summary>
        /// <param name="bizSysno">bizSysno</param>
        /// <param name="authorization">获取accessToken后，传入Bearer +token访问</param>
        /// <returns>OK</returns>
        [Post("v1/sms/getByBizSysno")]
        [Headers("Authorization")]
        Task<StandResponseOfSmsDTO> GetByBizSysnoUsingPOSTAsync([Query][AliasAs("bizSysno")] long bizSysno);

        /// <summary>分页查询短信发送记录</summary>
        /// <param name="req">req</param>
        /// <param name="authorization">获取accessToken后，传入Bearer +token访问</param>
        /// <returns>OK</returns>
        [Post("v1/sms/query/page")]
        [Headers("Authorization")]
        Task<StandResponseOfPageResultOfSmsDTO> QueryPagedUsingPOSTAsync([Body][AliasAs("req")] SmsQueryReq req);

        /// <summary>发送短信服务</summary>
        /// <param name="req">req</param>
        /// <param name="authorization">获取accessToken后，传入Bearer +token访问</param>
        /// <returns>OK</returns>
        [Post("v1/sms/send")]
        [Headers("Authorization")]
        Task<StandResponseOfBoolean> SendUsingPOSTAsync([Body][AliasAs("req")] SmsSendReq req);

        /// <summary>根据短信编号再次发送</summary>
        /// <param name="sysno">sysno</param>
        /// <param name="authorization">获取accessToken后，传入Bearer +token访问</param>
        /// <returns>OK</returns>
        [Post("v1/sms/sendAgain")]
        [Headers("Authorization")]
        Task<StandResponseOfBoolean> SendAgainUsingPOSTAsync([Query][AliasAs("sysno")] long sysno);

    }
}