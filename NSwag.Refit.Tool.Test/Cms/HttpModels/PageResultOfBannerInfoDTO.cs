using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// PageResultOfBannerInfoDTO
    /// </summary>    
    public class PageResultOfBannerInfoDTO
    {

        /// <summary>
        /// List
        /// </summary> 

        [AliasAs("list")]
        public List<BannerInfoDTO> List { get; set; }


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
        /// TotalCount
        /// </summary> 

        [AliasAs("totalCount")]
        public long? TotalCount { get; set; }


        /// <summary>
        /// TotalPage
        /// </summary> 

        [AliasAs("totalPage")]
        public int? TotalPage { get; set; }

    }
}