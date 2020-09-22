using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// HelpInfoAddLeafReq
    /// </summary>    
    public class HelpInfoAddLeafReq
    {
        /// <summary>
        /// 名称
        /// </summary>
        [AliasAs("name")]
        public string Name { get; set; }

        /// <summary>
        /// systemId
        /// </summary>
        [AliasAs("systemId")]
        public string SystemId { get; set; }

    }
}