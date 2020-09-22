using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// CheckVerifyCodeReq
    /// </summary>    
    public class CheckVerifyCodeReq
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
        /// 验证完成即失效
        /// </summary>
        [AliasAs("immediatelyInvalid")]
        public bool? ImmediatelyInvalid { get; set; }

        /// <summary>
        /// 短信指令号
        /// </summary>
        [AliasAs("smsInstructions")]
        public string SmsInstructions { get; set; }

    }
}