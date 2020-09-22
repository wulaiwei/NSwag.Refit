using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// SystemMessageStickyReq
    /// </summary>    
    public class SystemMessageStickyReq
    {
        /// <summary>
        /// 是否置顶（1是，0否）
        /// </summary>
        [AliasAs("isSticky")]
        public bool? IsSticky { get; set; }

        /// <summary>
        /// 主键
        /// </summary>
        [AliasAs("sysNo")]
        public long? SysNo { get; set; }

    }
}