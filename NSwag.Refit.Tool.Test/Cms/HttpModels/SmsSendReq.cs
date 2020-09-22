using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// SmsSendReq
    /// </summary>    
    public class SmsSendReq
    {
        /// <summary>
        /// 业务编号（如果类型为5，传订单号）
        /// </summary>
        [AliasAs("bizSysno")]
        public long? BizSysno { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [AliasAs("cellPhone")]
        public string CellPhone { get; set; }

        /// <summary>
        /// 短信内容（具体内容由业务系统根据短信平台模板传过来）
        /// </summary>
        [AliasAs("content")]
        public object Content { get; set; }

        /// <summary>
        /// 短信类型 1：注册验证码 2：快捷登录验证码 3：找回密码验证码 4：绑定手机号验证码 5：订单过期提醒  10:开户验证码；11：修改交易密码；12：修改交易手机号；17：订单支付，18：退款交易；19:余额提现;21：企业用户发送邀请 22:企业用户认证成功 23:企业用户认证失败 24:企业用户邀请成功 27:磅差短信提醒
        /// </summary>
        [AliasAs("smsType")]
        public int? SmsType { get; set; }

        /// <summary>
        /// 短信平台短信模板编码
        /// </summary>
        [AliasAs("templateCode")]
        public string TemplateCode { get; set; }

    }
}