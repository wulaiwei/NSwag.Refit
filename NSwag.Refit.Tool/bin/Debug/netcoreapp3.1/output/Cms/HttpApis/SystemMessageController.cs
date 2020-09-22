using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace Cms
{
    public interface ISystemMessageController
    {
        /// <summary>
        /// 使用sysNo查询系统信息
        /// </summary>
        /// <param name="sysNo">sysNo</param>
        /// <returns>OK</returns>
        [Get("v1/systemmessage/get/{sysNo}")]
        [Headers()] 
        Task<StandResponseOfSystemMessageDO> GetSystemMessageUsingGETAsync([AliasAs("sysNo")] long sysNo);

        /// <summary>
        /// 创建系统信息
        /// </summary>
        /// <param name="req">req</param>
        /// <returns>OK</returns>
        [Post("v1/systemmessage/insert")]
        [Headers("Authorization")] 
        Task<StandResponseOfLong> InsertUsingPOST_1Async([Body][AliasAs("req")] SystemMessageAddReq req);

        /// <summary>
        /// 删除分类名称信息
        /// </summary>
        /// <param name="req">req</param>
        /// <returns>OK</returns>
        [Post("v1/systemmessage/managementItemDelete")]
        [Headers("Authorization")] 
        Task<StandResponseOfBoolean> ManagementItemDeleteUsingPOSTAsync([Body][AliasAs("req")] ManagementItemUpdateReq req);

        /// <summary>
        /// 新增分类名称信息
        /// </summary>
        /// <param name="req">req</param>
        /// <returns>OK</returns>
        [Post("v1/systemmessage/managementItemInsert")]
        [Headers("Authorization")] 
        Task<StandResponseOfLong> ManagementItemInsertUsingPOSTAsync([Body][AliasAs("req")] ManagementItemAddReq req);

        /// <summary>
        /// 修改分类名称信息
        /// </summary>
        /// <param name="req">req</param>
        /// <returns>OK</returns>
        [Post("v1/systemmessage/managementItemUpdate")]
        [Headers("Authorization")] 
        Task<StandResponseOfBoolean> ManagementItemUpdateUsingPOSTAsync([Body][AliasAs("req")] ManagementItemUpdateReq req);

        /// <summary>
        /// 查询分类名称信息列表
        /// </summary>
        /// <param name="req">req</param>
        /// <returns>OK</returns>
        [Post("v1/systemmessage/managementItemsSelect")]
        [Headers()] 
        Task<StandResponseOfListOfManagementItemDO> ManagementItemsSelectUsingPOSTAsync([Body][AliasAs("req")] ManagementItemQueryReq req);

        /// <summary>
        /// 查询系统信息
        /// </summary>
        /// <param name="req">req</param>
        /// <returns>OK</returns>
        [Post("v1/systemmessage/page")]
        [Headers()] 
        Task<StandResponseOfPageResultOfSystemMessageDO> GetSystemMessageListUsingPOSTAsync([Body][AliasAs("req")] SystemMessageQueryReq req);

        /// <summary>
        /// 按状态获取系统信息
        /// </summary>
        /// <param name="sysNo">sysNo</param>
        /// <param name="status">status</param>
        /// <returns>OK</returns>
        [Get("v1/systemmessage/selectByStatus/{sysNo}/{status}")]
        [Headers()] 
        Task<StandResponseOfSystemMessageDO> SelectByStatusUsingGETAsync([AliasAs("sysNo")] long sysNo,[AliasAs("status")] int status);

        /// <summary>
        /// 查询不同分类的新闻信息
        /// </summary>
        /// <param name="req">req</param>
        /// <returns>OK</returns>
        [Post("v1/systemmessage/selectNewsPage")]
        [Headers()] 
        Task<StandResponseOfPageResultOfSystemMessageDO> SelectNewsPageUsingPOSTAsync([Body][AliasAs("req")] NewsQueryReq req);

        /// <summary>
        /// 更新系统信息
        /// </summary>
        /// <param name="req">req</param>
        /// <returns>OK</returns>
        [Post("v1/systemmessage/update")]
        [Headers("Authorization")] 
        Task<StandResponseOfInt> UpdateUsingPOST_1Async([Body][AliasAs("req")] SystemMessageUpdateReq req);

        /// <summary>
        /// 更新系统信息状态
        /// </summary>
        /// <param name="req">req</param>
        /// <returns>OK</returns>
        [Post("v1/systemmessage/updatestatus")]
        [Headers("Authorization")] 
        Task<StandResponseOfInt> UpdateStatusUsingPOST_1Async([Body][AliasAs("req")] SystemMessageStatusReq req);

        /// <summary>
        /// 更新系统信息置顶
        /// </summary>
        /// <param name="req">req</param>
        /// <returns>OK</returns>
        [Post("v1/systemmessage/updatesticky")]
        [Headers("Authorization")] 
        Task<StandResponseOfInt> UpdateStickyUsingPOSTAsync([Body][AliasAs("req")] SystemMessageStickyReq req);

    }
}