using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace Cms
{
    public interface IMetricsController
    {
        /// <summary>
        /// metrics
        /// </summary>
        /// <returns>OK</returns>
        [Get("v1/metrics")]
        [Headers()] 
        Task MetricsUsingGETAsync();

    }
}