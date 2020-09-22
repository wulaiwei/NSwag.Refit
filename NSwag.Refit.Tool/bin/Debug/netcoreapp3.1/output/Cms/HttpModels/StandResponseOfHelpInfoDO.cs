using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// StandResponseOfHelpInfoDO
    /// </summary>    
    public class StandResponseOfHelpInfoDO
    {

        /// <summary>
        /// Code
        /// </summary> 

        [AliasAs("code")]
        public int? Code { get; set; }


        /// <summary>
        /// Data
        /// </summary> 

        [AliasAs("data")]
        public HelpInfoDO Data { get; set; }


        /// <summary>
        /// Msg
        /// </summary> 

        [AliasAs("msg")]
        public string Msg { get; set; }


        /// <summary>
        /// MsgId
        /// </summary> 

        [AliasAs("msgId")]
        public string MsgId { get; set; }


        /// <summary>
        /// Success
        /// </summary> 

        [AliasAs("success")]
        public bool? Success { get; set; }

    }
}