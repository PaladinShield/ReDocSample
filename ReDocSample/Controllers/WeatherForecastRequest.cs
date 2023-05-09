using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ReDocSample.Controllers
{
    /// <summary>
    /// 查詢參數
    /// </summary>
    public class WeatherForecastRequest
    {
        /// <summary>
        /// 名稱
        /// </summary>
        [DefaultValue("Bracing")]
        [Required]
        public string Name { get; set; }

        [MaxLength(5)]
        public List<long> Seq { get; set; }

        /// <summary>
        /// 測        
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /Todo
        ///     {
        ///        "id": 1,
        ///        "name": "Item #1",
        ///        "isComplete": true
        ///     }
        /// </remarks>
        /// </summary>
        public string Test { get; set; }

        /// <summary>
        /// <remarks>
        /// <a href="https://github.com/Redocly/redoc">Redoc Github</a>
        /// </remarks>
        /// </summary>
        public string HyperLink { get; set; }
    }
}