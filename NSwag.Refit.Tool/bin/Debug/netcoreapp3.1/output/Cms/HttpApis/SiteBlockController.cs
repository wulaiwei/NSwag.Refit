using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace Cms
{
    public interface ISiteBlockController
    {
        /// <summary>
        /// 根据sysno删除导航区块
        /// </summary>
        /// <param name="sysno">sysno</param>
        /// <returns>OK</returns>
        [Post("v1/block/delete")]
        [Headers("Authorization")] 
        Task<StandResponse> DeleteSiteBlockUsingPOSTAsync([Query][AliasAs("sysno")] long sysno);

        /// <summary>
        /// 新增导航区块
        /// </summary>
        /// <param name="addReq">addReq</param>
        /// <returns>OK</returns>
        [Post("v1/block/save")]
        [Headers("Authorization")] 
        Task<StandResponseOfInt> CreateSiteBlockUsingPOSTAsync([Body][AliasAs("addReq")] SiteBlockAddReq addReq);

        /// <summary>
        /// 获取指定systemId下所有导航区块
        /// </summary>
        /// <param name="systemId">systemId</param>
        /// <returns>OK</returns>
        [Get("v1/block/selectBySystemId/{systemId}")]
        [Headers()] 
        Task<StandResponseOfListOfSiteBlockDTO> SelectSiteBlockUsingGETAsync([AliasAs("systemId")] string systemId);

        /// <summary>
        /// 修改导航区块
        /// </summary>
        /// <param name="updateReq">updateReq</param>
        /// <returns>OK</returns>
        [Post("v1/block/update")]
        [Headers("Authorization")] 
        Task<StandResponseOfInt> UpdateSiteBlockUsingPOSTAsync([Body][AliasAs("updateReq")] SiteBlockUpdateReq updateReq);

        /// <summary>
        /// 根据sysno获取导航区块
        /// </summary>
        /// <param name="sysno">sysno</param>
        /// <returns>OK</returns>
        [Get("v1/block/{sysno}")]
        [Headers("Authorization")] 
        Task<StandResponseOfSiteBlockDTO> GetSiteBlockUsingGETAsync([AliasAs("sysno")] long sysno);

    }
}