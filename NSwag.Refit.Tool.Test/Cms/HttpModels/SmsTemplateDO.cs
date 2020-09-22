using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// SmsTemplateDO
    /// </summary>    
    public class SmsTemplateDO
    {
        /// <summary>
        /// 创建时间
        /// </summary>
        [AliasAs("createDate")]
        public System.DateTimeOffset? CreateDate { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [AliasAs("createUser")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [AliasAs("modifyDate")]
        public System.DateTimeOffset? ModifyDate { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [AliasAs("modifyUser")]
        public string ModifyUser { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [AliasAs("status")]
        public int? Status { get; set; }

        /// <summary>
        /// 主键
        /// </summary>
        [AliasAs("sysNo")]
        public long? SysNo { get; set; }

        /// <summary>
        /// 短信平台应用系统编码
        /// </summary>
        [AliasAs("systemCode")]
        public string SystemCode { get; set; }

        /// <summary>
        /// 短信平台模板编码
        /// </summary>
        [AliasAs("templateCode")]
        public string TemplateCode { get; set; }

        /// <summary>
        /// 模板内容
        /// </summary>
        [AliasAs("templateContent")]
        public string TemplateContent { get; set; }

        /// <summary>
        /// 系统消息描述
        /// </summary>
        [AliasAs("templateDesc")]
        public string TemplateDesc { get; set; }

        /// <summary>
        /// 系统消息模板
        /// </summary>
        [AliasAs("templateType")]
        public int? TemplateType { get; set; }

    }
}