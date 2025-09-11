using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CountSqlTrendStatisticsResponse : SdkResponse
    {

        /// <summary>
        /// 列表数据
        /// </summary>
        [JsonProperty("count_statistics", NullValueHandling = NullValueHandling.Ignore)]
        public List<CountStatisticsBean> CountStatistics { get; set; }

        /// <summary>
        /// 生成时间
        /// </summary>
        [JsonProperty("generate_time", NullValueHandling = NullValueHandling.Ignore)]
        public string GenerateTime { get; set; }

        /// <summary>
        /// 状态  - FINISHED：已完成  - RUNNING：运行中
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CountSqlTrendStatisticsResponse {\n");
            sb.Append("  countStatistics: ").Append(CountStatistics).Append("\n");
            sb.Append("  generateTime: ").Append(GenerateTime).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CountSqlTrendStatisticsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CountSqlTrendStatisticsResponse input)
        {
            if (input == null) return false;
            if (this.CountStatistics != input.CountStatistics || (this.CountStatistics != null && input.CountStatistics != null && !this.CountStatistics.SequenceEqual(input.CountStatistics))) return false;
            if (this.GenerateTime != input.GenerateTime || (this.GenerateTime != null && !this.GenerateTime.Equals(input.GenerateTime))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.CountStatistics != null) hashCode = hashCode * 59 + this.CountStatistics.GetHashCode();
                if (this.GenerateTime != null) hashCode = hashCode * 59 + this.GenerateTime.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
