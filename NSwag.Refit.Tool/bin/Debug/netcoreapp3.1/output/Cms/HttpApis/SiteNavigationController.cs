using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace Cms
{
    public interface ISiteNavigationController
    {
        /// <summary>
        /// 删除栏目
        /// </summary>
        /// <param name="sysno">sysno</param>
        /// <returns>OK</returns>
        [Post("v1/navigation/delete")]
        [Headers("Authorization")] 
        Task<StandResponse> DeleteSiteNavigationUsingPOSTAsync([Query][AliasAs("sysno")] long sysno);

        /// <summary>
        /// 根据栏目所属区块sysno查询所有栏目
        /// </summary>
        /// <param name="blockSysno">blockSysno</param>
        /// <returns>OK</returns>
        [Get("v1/navigation/getByBlock/{blockSysno}")]
        [Headers("Authorization")] 
        Task<StandResponseOfListOfSiteNavigationDTO> SelectByBlockSysnoUsingGETAsync([AliasAs("blockSysno")] long blockSysno);

        /// <summary>
        /// 根据父栏目sysno查询所有子栏目
        /// </summary>
        /// <param name="parentSysno">parentSysno</param>
        /// <returns>OK</returns>
        [Get("v1/navigation/getByParent/{parentSysno}")]
        [Headers("Authorization")] 
        Task<StandResponseOfListOfSiteNavigationDTO> SelectByParentSysnoUsingGETAsync([AliasAs("parentSysno")] long parentSysno);

        /// <summary>
        /// 栏目移动（action为1表上移，2表下移）
        /// </summary>
        /// <param name="sysno">sysno</param>
        /// <param name="action">action</param>
        /// <returns>OK</returns>
        [Post("v1/navigation/move")]
        [Headers("Authorization")] 
        Task<StandResponse> MoveNavigationUsingPOSTAsync([Query][AliasAs("sysno")] long? sysno,[Query][AliasAs("action")] int? action);

        /// <summary>
        /// 新增导航区块下属栏目
        /// </summary>
        /// <param name="addReq">addReq</param>
        /// <returns>OK</returns>
        [Post("v1/navigation/save")]
        [Headers("Authorization")] 
        Task<StandResponseOfInt> CreateSiteNavigationUsingPOSTAsync([Body][AliasAs("addReq")] SiteNavigationAddReq addReq);

        /// <summary>
        /// 修改栏目
        /// </summary>
        /// <param name="updateReq">updateReq</param>
        /// <returns>OK</returns>
        [Post("v1/navigation/update")]
        [Headers("Authorization")] 
        Task<StandResponseOfInt> UpdateSiteNavigationUsingPOSTAsync([Body][AliasAs("updateReq")] SiteNavigationUpdateReq updateReq);

        /// <summary>
        /// 根据sysno查询栏目
        /// </summary>
        /// <param name="sysno">sysno</param>
        /// <returns>OK</returns>
        [Get("v1/navigation/{sysno}")]
        [Headers("Authorization")] 
        Task<StandResponseOfSiteNavigationDTO> SelectBySysnoUsingGETAsync([AliasAs("sysno")] long sysno);

    }
}