using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// SiteBlockDTO
    /// </summary>    
    public class SiteBlockDTO
    {
        /// <summary>
        /// 导航区块key值
        /// </summary>
        [AliasAs("blockKey")]
        public string BlockKey { get; set; }

        /// <summary>
        /// logo地址
        /// </summary>
        [AliasAs("logoUrl")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 栏目集合
        /// </summary>
        [AliasAs("navigations")]
        public List<SiteNavigationDTO> Navigations { get; set; }

        /// <summary>
        /// 平台热线
        /// </summary>
        [AliasAs("platHotline")]
        public string PlatHotline { get; set; }

        /// <summary>
        /// 二维码地址
        /// </summary>
        [AliasAs("qrCodeUrl")]
        public string QrCodeUrl { get; set; }

        /// <summary>
        /// 导航区块文本内容
        /// </summary>
        [AliasAs("siteBlockContent")]
        public string SiteBlockContent { get; set; }

        /// <summary>
        /// 导航区块名称
        /// </summary>
        [AliasAs("siteBlockName")]
        public string SiteBlockName { get; set; }

        /// <summary>
        /// 系统编号
        /// </summary>
        [AliasAs("sysno")]
        public long? Sysno { get; set; }

        /// <summary>
        /// 应用id
        /// </summary>
        [AliasAs("systemId")]
        public string SystemId { get; set; }

    }
}