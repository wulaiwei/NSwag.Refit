using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// SystemMessageDO
    /// </summary>    
    public class SystemMessageDO
    {
        /// <summary>
        /// 系统Id
        /// </summary>
        [AliasAs("appId")]
        public string AppId { get; set; }

        /// <summary>
        /// 附件地址
        /// </summary>
        [AliasAs("attachmentUrl")]
        public string AttachmentUrl { get; set; }

        /// <summary>
        /// content
        /// </summary>
        [AliasAs("content")]
        public string Content { get; set; }

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
        /// 描述
        /// </summary>
        [AliasAs("description")]
        public string Description { get; set; }

        /// <summary>
        /// 是否置顶（1是，0否）
        /// </summary>
        [AliasAs("isSticky")]
        public bool? IsSticky { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        [AliasAs("managementItemName")]
        public string ManagementItemName { get; set; }

        /// <summary>
        /// 分类名称记录号
        /// </summary>
        [AliasAs("managementSysNo")]
        public long? ManagementSysNo { get; set; }

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
        /// 排序
        /// </summary>
        [AliasAs("orderIndex")]
        public int? OrderIndex { get; set; }

        /// <summary>
        /// 阅读数
        /// </summary>
        [AliasAs("readCount")]
        public int? ReadCount { get; set; }

        /// <summary>
        /// 文章来源
        /// </summary>
        [AliasAs("sourceFrom")]
        public string SourceFrom { get; set; }

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
        /// 标题
        /// </summary>
        [AliasAs("title")]
        public string Title { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [AliasAs("type")]
        public int? Type { get; set; }

    }
}