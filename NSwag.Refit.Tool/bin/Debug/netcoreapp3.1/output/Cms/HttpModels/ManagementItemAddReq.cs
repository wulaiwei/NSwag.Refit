using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// ManagementItemAddReq
    /// </summary>    
    public class ManagementItemAddReq
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

    }
}