using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// SmsDTO
    /// </summary>    
    public class SmsDTO
    {
        /// <summary>
        /// 业务编码
        /// </summary>
        [AliasAs("bizSysno")]
        public long? BizSysno { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [AliasAs("cellNumber")]
        public string CellNumber { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [AliasAs("createTime")]
        public System.DateTimeOffset? CreateTime { get; set; }

        /// <summary>
        /// 处理时间
        /// </summary>
        [AliasAs("handleTime")]
        public System.DateTimeOffset? HandleTime { get; set; }

        /// <summary>
        /// 优先级
        /// </summary>
        [AliasAs("priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// 重试次数
        /// </summary>
        [AliasAs("retryCount")]
        public int? RetryCount { get; set; }

        /// <summary>
        /// 短信内容
        /// </summary>
        [AliasAs("smsContent")]
        public string SmsContent { get; set; }

        /// <summary>
        /// 状态 0：待发送 1：已发送  -1：发送失败
        /// </summary>
        [AliasAs("status")]
        public int? Status { get; set; }

        /// <summary>
        /// 系统编号
        /// </summary>
        [AliasAs("sysno")]
        public long? Sysno { get; set; }

        /// <summary>
        /// 类型 1：注册验证码 2：快捷登录验证码 3：找回密码验证码 4：绑定手机号验证码 5：订单过期提醒  10:开户验证码；11：修改交易密码；12：修改交易手机号；21：企业用户发送邀请 22:企业用户认证成功 23:企业用户认证失败 24:企业用户邀请成功
        /// </summary>
        [AliasAs("type")]
        public int? Type { get; set; }

    }
}