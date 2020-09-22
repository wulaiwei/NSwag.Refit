using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// HelpInfoContentEditReq
    /// </summary>    
    public class HelpInfoContentEditReq
    {
        /// <summary>
        /// 附件,示例:[{name:"附件名称",url:"http://domain.com/img.jpg",size:25461(说明：此值是字节),type:"image/jpeg"}]
        /// </summary>
        [AliasAs("attachment")]
        public string Attachment { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        [AliasAs("content")]
        public string Content { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        [AliasAs("sysno")]
        public long? Sysno { get; set; }

    }
}