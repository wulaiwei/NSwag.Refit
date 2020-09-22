using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace Cms
{
    public interface IBannerController
    {
        /// <summary>
        /// 添加广告位
        /// </summary>
        /// <param name="addReq">addReq</param>
        /// <returns>OK</returns>
        [Post("v1/banner/block/create")]
        [Headers("Authorization")] 
        Task<StandResponseOfLong> InsertBannerBlockUsingPOSTAsync([Body][AliasAs("addReq")] BannerBlockAddReq addReq);

        /// <summary>
        /// 删除广告位
        /// </summary>
        /// <param name="sysno">sysno</param>
        /// <returns>OK</returns>
        [Post("v1/banner/block/delete")]
        [Headers("Authorization")] 
        Task<StandResponseOfInt> DeleteBannerBlockUsingPOSTAsync([Query][AliasAs("sysno")] long sysno);

        /// <summary>
        /// 根据条件查询广告位列表并分页
        /// </summary>
        /// <param name="queryReq">queryReq</param>
        /// <returns>OK</returns>
        [Post("v1/banner/block/page")]
        [Headers("Authorization")] 
        Task<StandResponseOfPageResultOfBannerBlockDTO> QueryPagedBannerBlockUsingPOSTAsync([Body][AliasAs("queryReq")] BannerBlockQueryReq queryReq);

        /// <summary>
        /// 更新广告位信息
        /// </summary>
        /// <param name="req">req</param>
        /// <returns>OK</returns>
        [Post("v1/banner/block/update")]
        [Headers("Authorization")] 
        Task<StandResponseOfInt> UpdateBannerBlockUsingPOSTAsync([Body][AliasAs("req")] BannerBlockUpdateReq req);

        /// <summary>
        /// 根据sysno获取广告位信息
        /// </summary>
        /// <param name="sysno">sysno</param>
        /// <returns>OK</returns>
        [Get("v1/banner/block/{sysno}")]
        [Headers("Authorization")] 
        Task<StandResponseOfBannerBlockDTO> GetBannerBlockUsingGETAsync([AliasAs("sysno")] long sysno);

        /// <summary>
        /// 批量停用广告
        /// </summary>
        /// <param name="sysnos">sysnos</param>
        /// <returns>OK</returns>
        [Post("v1/banner/info/batchDisable")]
        [Headers("Authorization")] 
        Task<StandResponseOfInt> BatchDisableUsingPOSTAsync([Body][AliasAs("sysnos")] IEnumerable<long> sysnos);

        /// <summary>
        /// 批量启用广告
        /// </summary>
        /// <param name="sysnos">sysnos</param>
        /// <returns>OK</returns>
        [Post("v1/banner/info/batchEnable")]
        [Headers("Authorization")] 
        Task<StandResponseOfInt> BatchEnableUsingPOSTAsync([Body][AliasAs("sysnos")] IEnumerable<long> sysnos);

        /// <summary>
        /// 添加广告
        /// </summary>
        /// <param name="addReq">addReq</param>
        /// <returns>OK</returns>
        [Post("v1/banner/info/create")]
        [Headers("Authorization")] 
        Task<StandResponseOfLong> InsertBannerInfoUsingPOSTAsync([Body][AliasAs("addReq")] BannerInfoAddReq addReq);

        /// <summary>
        /// 删除广告
        /// </summary>
        /// <param name="sysno">sysno</param>
        /// <returns>OK</returns>
        [Post("v1/banner/info/delete")]
        [Headers("Authorization")] 
        Task<StandResponseOfInt> DeleteBannerInfoUsingPOSTAsync([Query][AliasAs("sysno")] long sysno);

        /// <summary>
        /// 根据条件查询广告列表并分页
        /// </summary>
        /// <param name="queryReq">queryReq</param>
        /// <returns>OK</returns>
        [Post("v1/banner/info/page")]
        [Headers()] 
        Task<StandResponseOfPageResultOfBannerInfoDTO> QueryPagedBannerInfoUsingPOSTAsync([Body][AliasAs("queryReq")] BannerInfoQueryReq queryReq);

        /// <summary>
        /// 更新广告信息
        /// </summary>
        /// <param name="req">req</param>
        /// <returns>OK</returns>
        [Post("v1/banner/info/update")]
        [Headers("Authorization")] 
        Task<StandResponseOfInt> UpdateBannerInfoUsingPOSTAsync([Body][AliasAs("req")] BannerInfoUpdateReq req);

        /// <summary>
        /// 根据sysno获取广告信息
        /// </summary>
        /// <param name="sysno">sysno</param>
        /// <returns>OK</returns>
        [Get("v1/banner/info/{sysno}")]
        [Headers("Authorization")] 
        Task<StandResponseOfBannerInfoDTO> GetBannerInfoUsingGETAsync([AliasAs("sysno")] long sysno);

    }
}