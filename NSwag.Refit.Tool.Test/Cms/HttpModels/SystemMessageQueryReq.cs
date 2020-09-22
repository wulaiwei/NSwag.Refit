using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// SystemMessageQueryReq
    /// </summary>    
    public class SystemMessageQueryReq
    {
        /// <summary>
        /// 系统Id
        /// </summary>
        [AliasAs("appId")]
        public string AppId { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [AliasAs("createUser")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [AliasAs("modifyUser")]
        public string ModifyUser { get; set; }


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
        /// 状态（0 删除，1 启用，2 停用）
        /// </summary>
        [AliasAs("status")]
        public int? Status { get; set; }

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