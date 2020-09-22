using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// BannerInfoQueryReq
    /// </summary>    
    public class BannerInfoQueryReq
    {
        /// <summary>
        /// 广告标识
        /// </summary>
        [AliasAs("bannerBlockKey")]
        public string BannerBlockKey { get; set; }

        /// <summary>
        /// 广告位置编号
        /// </summary>
        [AliasAs("bannerBlockSysno")]
        public long? BannerBlockSysno { get; set; }

        /// <summary>
        /// 广告名称
        /// </summary>
        [AliasAs("bannerName")]
        public string BannerName { get; set; }


        /// <summary>
        /// OrderBy
        /// </summary> 

        [AliasAs("orderBy")]
        public string OrderBy { get; set; }


        /// <summary>
        /// PageIndex
        /// </summary> 

        [AliasAs("pageIndex")]
        public int? PageIndex { get; set; }


        /// <summary>
        /// PageSize
        /// </summary> 

        [AliasAs("pageSize")]
        public int? PageSize { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [AliasAs("status")]
        public int? Status { get; set; }

        /// <summary>
        /// systemId
        /// </summary>
        [AliasAs("systemId")]
        public string SystemId { get; set; }

    }
}