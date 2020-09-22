using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// SiteBlockUpdateReq
    /// </summary>    
    public class SiteBlockUpdateReq
    {
        /// <summary>
        /// logo地址
        /// </summary>
        [AliasAs("logoUrl")]
        public string LogoUrl { get; set; }

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