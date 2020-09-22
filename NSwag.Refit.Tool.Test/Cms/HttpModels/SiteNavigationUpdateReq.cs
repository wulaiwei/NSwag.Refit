using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// SiteNavigationUpdateReq
    /// </summary>    
    public class SiteNavigationUpdateReq
    {
        /// <summary>
        /// 图标地址
        /// </summary>
        [AliasAs("iconUrl")]
        public string IconUrl { get; set; }

        /// <summary>
        /// 内部页面编码
        /// </summary>
        [AliasAs("innerCode")]
        public string InnerCode { get; set; }

        /// <summary>
        /// 内部页面路径名
        /// </summary>
        [AliasAs("innerPath")]
        public string InnerPath { get; set; }

        /// <summary>
        /// 内部页面地址
        /// </summary>
        [AliasAs("innerUrl")]
        public string InnerUrl { get; set; }

        /// <summary>
        /// 链接类型（1为内部页面，2为外部链接）
        /// </summary>        [Range(-128, 127)]

        [AliasAs("linkType")]
        public int? LinkType { get; set; }

        /// <summary>
        /// 导航栏目名称
        /// </summary>
        [AliasAs("name")]
        public string Name { get; set; }

        /// <summary>
        /// 外部链接地址
        /// </summary>
        [AliasAs("outerUrl")]
        public string OuterUrl { get; set; }

        /// <summary>
        /// 导航父栏目系统编号
        /// </summary>
        [AliasAs("parentSysno")]
        public long? ParentSysno { get; set; }

        /// <summary>
        /// 所属导航区块sysno
        /// </summary>
        [AliasAs("siteBlockSysno")]
        public long? SiteBlockSysno { get; set; }

        /// <summary>
        /// 栏目排序
        /// </summary>
        [AliasAs("sort")]
        public int? Sort { get; set; }

        /// <summary>
        /// 导航栏目系统编号
        /// </summary>
        [AliasAs("sysno")]
        public long? Sysno { get; set; }

    }
}