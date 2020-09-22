using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// BannerBlockDTO
    /// </summary>    
    public class BannerBlockDTO
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
        /// 已存在广告数量
        /// </summary>
        [AliasAs("existBannerCount")]
        public int? ExistBannerCount { get; set; }

        /// <summary>
        /// 最大广告数量
        /// </summary>
        [AliasAs("maxBannerCount")]
        public int? MaxBannerCount { get; set; }

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