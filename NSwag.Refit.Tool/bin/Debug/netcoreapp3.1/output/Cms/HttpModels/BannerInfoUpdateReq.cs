using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// BannerInfoUpdateReq
    /// </summary>    
    public class BannerInfoUpdateReq
    {
        /// <summary>
        /// 广告位编号
        /// </summary>
        [AliasAs("bannerBlockSysno")]
        public long? BannerBlockSysno { get; set; }

        /// <summary>
        /// 广告描述
        /// </summary>
        [AliasAs("bannerDesc")]
        public string BannerDesc { get; set; }

        /// <summary>
        /// 广告名称
        /// </summary>
        [AliasAs("bannerName")]
        public string BannerName { get; set; }

        /// <summary>
        /// 广告图片地址
        /// </summary>
        [AliasAs("imageUrl")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 跳转地址
        /// </summary>
        [AliasAs("linkUrl")]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [AliasAs("sort")]
        public int? Sort { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [AliasAs("status")]
        public int? Status { get; set; }

        /// <summary>
        /// 系统编号
        /// </summary>
        [AliasAs("sysno")]
        public long? Sysno { get; set; }

    }
}