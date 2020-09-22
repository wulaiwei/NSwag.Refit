using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// ManagementItemQueryReq
    /// </summary>    
    public class ManagementItemQueryReq
    {
        /// <summary>
        /// 系统Id
        /// </summary>
        [AliasAs("appId")]
        public string AppId { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        [AliasAs("itemName")]
        public string ItemName { get; set; }

        /// <summary>
        /// 分类名称记录号
        /// </summary>
        [AliasAs("sysNo")]
        public long? SysNo { get; set; }

    }
}