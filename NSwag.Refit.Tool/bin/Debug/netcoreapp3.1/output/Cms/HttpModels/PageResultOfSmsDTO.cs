﻿using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// PageResultOfSmsDTO
    /// </summary>    
    public class PageResultOfSmsDTO
    {

        /// <summary>
        /// List
        /// </summary> 

        [AliasAs("list")]
        public List<SmsDTO> List { get; set; }


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