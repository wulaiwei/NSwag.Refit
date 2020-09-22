using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// SystemMessageUpdateReq
    /// </summary>    
    public class SystemMessageUpdateReq
    {
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
        /// 描述
        /// </summary>
        [AliasAs("description")]
        public string Description { get; set; }

        /// <summary>
        /// 分类名称记录号
        /// </summary>
        [AliasAs("managementSysNo")]
        public long? ManagementSysNo { get; set; }

        /// <summary>
        /// 排序（大于0的整数，不能重复，最小为1，最大9999）
        /// </summary>
        [AliasAs("orderIndex")]
        public int? OrderIndex { get; set; }

        /// <summary>
        /// 文章来源
        /// </summary>
        [AliasAs("sourceFrom")]
        public string SourceFrom { get; set; }

        /// <summary>
        /// 状态（0删除，1启用，2停用）
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
        /// 类型（1系统公告，2平台通知，3文章如关于我们，4平台介绍，5新闻资讯）
        /// </summary>
        [AliasAs("type")]
        public int? Type { get; set; }

    }
}