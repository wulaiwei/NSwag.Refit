using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// BannerBlockQueryReq
    /// </summary>    
    public class BannerBlockQueryReq
    {
        /// <summary>
        /// 广告位标识
        /// </summary>
        [AliasAs("bannerBlockKey")]
        public string BannerBlockKey { get; set; }

        /// <summary>
        /// 广告位名称
        /// </summary>
        [AliasAs("bannerBlockName")]
        public string BannerBlockName { get; set; }


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
        /// systemId
        /// </summary>
        [AliasAs("systemId")]
        public string SystemId { get; set; }

    }
}