using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// CheckVerifyCodeWithCredentialReq
    /// </summary>    
    public class CheckVerifyCodeWithCredentialReq
    {
        /// <summary>
        /// 手机号码
        /// </summary>
        [AliasAs("cellPhone")]
        public string CellPhone { get; set; }

        /// <summary>
        /// 短信验证码
        /// </summary>
        [AliasAs("code")]
        public string Code { get; set; }

        /// <summary>
        /// 凭证失效时间（单位秒，默认60*60秒）
        /// </summary>
        [AliasAs("credentialExpire")]
        public long? CredentialExpire { get; set; }

        /// <summary>
        /// 短信指令号
        /// </summary>
        [AliasAs("smsInstructions")]
        public string SmsInstructions { get; set; }

    }
}