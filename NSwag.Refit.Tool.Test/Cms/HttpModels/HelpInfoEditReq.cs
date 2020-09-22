using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// HelpInfoEditReq
    /// </summary>    
    public class HelpInfoEditReq
    {
        /// <summary>
        /// 名称
        /// </summary>
        [AliasAs("name")]
        public string Name { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        [AliasAs("sysno")]
        public long? Sysno { get; set; }

    }
}