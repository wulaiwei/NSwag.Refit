using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// HelpInfoTreeDTO
    /// </summary>    
    public class HelpInfoTreeDTO
    {
        /// <summary>
        /// 子菜单
        /// </summary>
        [AliasAs("childs")]
        public List<HelpInfoTreeDTO> Childs { get; set; }

        /// <summary>
        /// 帮助菜单名
        /// </summary>
        [AliasAs("name")]
        public string Name { get; set; }

        /// <summary>
        /// 父级编号
        /// </summary>
        [AliasAs("parentSysno")]
        public string ParentSysno { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [AliasAs("sort")]
        public int? Sort { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        [AliasAs("sysno")]
        public string Sysno { get; set; }

        /// <summary>
        /// systemId
        /// </summary>
        [AliasAs("systemId")]
        public string SystemId { get; set; }

    }
}