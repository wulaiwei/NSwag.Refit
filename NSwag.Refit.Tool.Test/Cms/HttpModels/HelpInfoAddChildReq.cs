using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// HelpInfoAddChildReq
    /// </summary>    
    public class HelpInfoAddChildReq
    {
        /// <summary>
        /// 名称
        /// </summary>
        [AliasAs("name")]
        public string Name { get; set; }

        /// <summary>
        /// 父级编号
        /// </summary>
        [AliasAs("parentSysno")]
        public long? ParentSysno { get; set; }

    }
}