using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace Cms
{
    public interface IHelpInfoController
    {
        /// <summary>根据编号删除整个节点</summary>
        /// <param name="sysno">sysno</param>
        /// <returns>OK</returns>
        [Get("v1/helpinfo/deleteNodeBySysNo/{sysno}")]
        [Headers("Authorization")]
        Task<StandResponseOfBoolean> DeleteNodeBySysNoUsingGETAsync([AliasAs("sysno")] long sysno);

        /// <summary>根据sysno获取菜单的详情信息</summary>
        /// <param name="sysno">sysno</param>
        /// <returns>OK</returns>
        [Get("v1/helpinfo/get/{sysno}")]
        Task<StandResponseOfHelpInfoDO> GetUsingGETAsync([AliasAs("sysno")] long sysno);

        /// <summary>新增子级栏目</summary>
        /// <param name="req">req</param>
        /// <returns>OK</returns>
        [Post("v1/helpinfo/insertChild")]
        [Headers("Authorization")]
        Task<StandResponseOfLong> InsertChildUsingPOSTAsync([Body][AliasAs("req")] HelpInfoAddChildReq req);

        /// <summary>新增第一级栏目</summary>
        /// <param name="req">req</param>
        /// <returns>OK</returns>
        [Post("v1/helpinfo/insertLeaf")]
        [Headers("Authorization")]
        Task<StandResponseOfLong> InsertLeafUsingPOSTAsync([Body][AliasAs("req")] HelpInfoAddLeafReq req);

        /// <summary>根据systemId获取树视图</summary>
        /// <param name="systemId">systemId</param>
        /// <returns>OK</returns>
        [Get("v1/helpinfo/list/{systemId}")]
        Task<StandResponseOfListOfHelpInfoTreeDTO> ListUsingGETAsync([AliasAs("systemId")] string systemId);

        /// <summary>下移指定菜单</summary>
        /// <param name="sysno">sysno</param>
        /// <returns>OK</returns>
        [Get("v1/helpinfo/moveDown/{sysno}")]
        [Headers("Authorization")]
        Task<StandResponseOfBoolean> MoveDownUsingGETAsync([AliasAs("sysno")] long sysno);

        /// <summary>上移指定菜单</summary>
        /// <param name="sysno">sysno</param>
        /// <returns>OK</returns>
        [Get("v1/helpinfo/moveUp/{sysno}")]
        [Headers("Authorization")]
        Task<StandResponseOfBoolean> MoveUpUsingGETAsync([AliasAs("sysno")] long sysno);

        /// <summary>保存菜单内容</summary>
        /// <param name="req">req</param>
        /// <returns>OK</returns>
        [Post("v1/helpinfo/saveContent")]
        [Headers("Authorization")]
        Task<StandResponseOfBoolean> SaveContentUsingPOSTAsync([Body][AliasAs("req")] HelpInfoContentEditReq req);

        /// <summary>提交更新菜单内容</summary>
        /// <param name="req">req</param>
        /// <returns>OK</returns>
        [Post("v1/helpinfo/submitContent")]
        [Headers("Authorization")]
        Task<StandResponseOfBoolean> SubmitContentUsingPOSTAsync([Body][AliasAs("req")] HelpInfoContentEditReq req);

        /// <summary>编辑菜单名称</summary>
        /// <param name="req">req</param>
        /// <returns>OK</returns>
        [Post("v1/helpinfo/updateNameBySysNo")]
        [Headers("Authorization")]
        Task<StandResponseOfBoolean> UpdateNameBySysNoUsingPOSTAsync([Body][AliasAs("req")] HelpInfoEditReq req);

    }
}