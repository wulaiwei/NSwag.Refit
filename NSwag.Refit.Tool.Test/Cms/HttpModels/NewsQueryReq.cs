using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// NewsQueryReq
    /// </summary>    
    public class NewsQueryReq
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
        /// 新闻类型记录号
        /// </summary>
        [AliasAs("managementSysNo")]
        public long? ManagementSysNo { get; set; }

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
        /// 状态（0删除，1启用，2停用）
        /// </summary>
        [AliasAs("status")]
        public int? Status { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [AliasAs("title")]
        public string Title { get; set; }

    }
}