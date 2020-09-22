using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// ManagementItemDO
    /// </summary>    
    public class ManagementItemDO
    {
        /// <summary>
        /// 系统Id
        /// </summary>
        [AliasAs("appId")]
        public string AppId { get; set; }

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
        /// 标题
        /// </summary>
        [AliasAs("itemName")]
        public string ItemName { get; set; }

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
        /// 状态（0启用 1停用 2删除）
        /// </summary>
        [AliasAs("status")]
        public int? Status { get; set; }

        /// <summary>
        /// 主键
        /// </summary>
        [AliasAs("sysNo")]
        public long? SysNo { get; set; }

    }
}