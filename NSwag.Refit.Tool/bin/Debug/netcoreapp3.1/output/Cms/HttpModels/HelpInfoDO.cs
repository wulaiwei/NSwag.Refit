using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// HelpInfoDO
    /// </summary>    
    public class HelpInfoDO
    {
        /// <summary>
        /// 附件
        /// </summary>
        [AliasAs("attachment")]
        public string Attachment { get; set; }

        /// <summary>
        /// 草稿附件
        /// </summary>
        [AliasAs("attachmentDraft")]
        public string AttachmentDraft { get; set; }

        /// <summary>
        /// 文档内容
        /// </summary>
        [AliasAs("content")]
        public string Content { get; set; }

        /// <summary>
        /// 草稿内容
        /// </summary>
        [AliasAs("contentDraft")]
        public string ContentDraft { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [AliasAs("createDate")]
        public System.DateTimeOffset? CreateDate { get; set; }

        /// <summary>
        /// 创建人编号
        /// </summary>
        [AliasAs("createUser")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [AliasAs("modifyDate")]
        public System.DateTimeOffset? ModifyDate { get; set; }

        /// <summary>
        /// 修改人编号
        /// </summary>
        [AliasAs("modifyUser")]
        public string ModifyUser { get; set; }

        /// <summary>
        /// 帮助菜单名
        /// </summary>
        [AliasAs("name")]
        public string Name { get; set; }

        /// <summary>
        /// 父级编号
        /// </summary>
        [AliasAs("parentSysno")]
        public string ParentSysno { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [AliasAs("sort")]
        public int? Sort { get; set; }

        /// <summary>
        /// 状态，0草稿，1正常
        /// </summary>
        [AliasAs("status")]
        public int? Status { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        [AliasAs("sysno")]
        public string Sysno { get; set; }

        /// <summary>
        /// systemId
        /// </summary>
        [AliasAs("systemId")]
        public string SystemId { get; set; }

    }
}