using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// BannerBlockAddReq
    /// </summary>    
    public class BannerBlockAddReq
    {
        /// <summary>
        /// 广告位置描述
        /// </summary>
        [AliasAs("bannerBlockDesc")]
        public string BannerBlockDesc { get; set; }

        /// <summary>
        /// 广告位置标识
        /// </summary>
        [AliasAs("bannerBlockKey")]
        public string BannerBlockKey { get; set; }

        /// <summary>
        /// 广告位置名称
        /// </summary>
        [AliasAs("bannerBlockName")]
        public string BannerBlockName { get; set; }

        /// <summary>
        /// 最大广告数量
        /// </summary>
        [AliasAs("maxBannerCount")]
        public int? MaxBannerCount { get; set; }

        /// <summary>
        /// systemId
        /// </summary>
        [AliasAs("systemId")]
        public string SystemId { get; set; }

    }
}