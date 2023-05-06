namespace ReDocSample
{
    public class WeatherForecast
    {
        /// <summary>
        /// 日期
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// 攝氏
        /// </summary>
        public int TemperatureC { get; set; }

        /// <summary>
        /// 華氏
        /// </summary>
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        /// <summary>
        /// 摘要
        /// </summary>
        public string? Summary { get; set; }
    }
}