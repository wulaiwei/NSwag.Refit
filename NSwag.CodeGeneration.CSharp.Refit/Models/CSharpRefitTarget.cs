//-----------------------------------------------------------------------
// <copyright file="CSharpControllerTarget.cs" company="NSwag">
//     Copyright (c) Rico Suter. All rights reserved.
// </copyright>
// <license>https://github.com/RicoSuter/NSwag/blob/master/LICENSE.md</license>
// <author>Rico Suter, mail@rsuter.com</author>
//-----------------------------------------------------------------------

namespace NSwag.CodeGeneration.CSharp.Refit.Models
{
    /// <summary>The CSharp controller target framework.</summary>
    public enum CSharpRefitTarget
    {
        /// <summary>ASP.NET MVC.</summary>
        AspNet,

        /// <summary>ASP.NET Core.</summary>
        AspNetCore
    }
}