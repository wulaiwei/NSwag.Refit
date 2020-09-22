using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// BannerInfoDTO
    /// </summary>    
    public class BannerInfoDTO
    {
        /// <summary>
        /// 广告位名称
        /// </summary>
        [AliasAs("bannerBlockName")]
        public string BannerBlockName { get; set; }

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
        /// 创建时间
        /// </summary>
        [AliasAs("createDate")]
        public System.DateTimeOffset? CreateDate { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [AliasAs("createUser")]
        public string CreateUser { get; set; }

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
        /// 最后操作时间
        /// </summary>
        [AliasAs("modifyDate")]
        public System.DateTimeOffset? ModifyDate { get; set; }

        /// <summary>
        /// 最后操作人
        /// </summary>
        [AliasAs("modifyUser")]
        public string ModifyUser { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [AliasAs("sort")]
        public int? Sort { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [AliasAs("status")]
        public int? Status { get; set; }

        /// <summary>
        /// 系统编号
        /// </summary>
        [AliasAs("sysno")]
        public long? Sysno { get; set; }

        /// <summary>
        /// systemId
        /// </summary>
        [AliasAs("systemId")]
        public string SystemId { get; set; }

    }
}