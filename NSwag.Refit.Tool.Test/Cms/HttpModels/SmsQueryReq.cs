using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// SmsQueryReq
    /// </summary>    
    public class SmsQueryReq
    {
        /// <summary>
        /// 手机号码
        /// </summary>
        [AliasAs("cellPhone")]
        public string CellPhone { get; set; }


        /// <summary>
        /// OrderBy
        /// </summary> 

        [AliasAs("orderBy")]
        public string OrderBy { get; set; }


        /// <summary>
        /// PageIndex
        /// </summary> 

        [AliasAs("pageIndex")]
        public int? PageIndex { get; set; }


        /// <summary>
        /// PageSize
        /// </summary> 

        [AliasAs("pageSize")]
        public int? PageSize { get; set; }

        /// <summary>
        /// 发送状态
        /// </summary>
        [AliasAs("smsStatus")]
        public int? SmsStatus { get; set; }

        /// <summary>
        /// 短信类型 1：注册验证码 2：快捷登录验证码 3：找回密码验证码 4：绑定手机号验证码 5：订单过期提醒  10:开户验证码；11：修改交易密码；12：修改交易手机号；21：企业用户发送邀请 22:企业用户认证成功 23:企业用户认证失败 24:企业用户邀请成功
        /// </summary>
        [AliasAs("smsType")]
        public int? SmsType { get; set; }

    }
}