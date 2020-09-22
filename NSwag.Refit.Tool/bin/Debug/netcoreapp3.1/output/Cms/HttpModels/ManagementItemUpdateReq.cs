using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// ManagementItemUpdateReq
    /// </summary>    
    public class ManagementItemUpdateReq
    {
        /// <summary>
        /// 分类名称
        /// </summary>
        [AliasAs("itemName")]
        public string ItemName { get; set; }

        /// <summary>
        /// 数据状态（0启用 1停用 2删除）
        /// </summary>
        [AliasAs("status")]
        public int? Status { get; set; }

        /// <summary>
        /// 分类名称记录号
        /// </summary>
        [AliasAs("sysNo")]
        public long? SysNo { get; set; }

    }
}