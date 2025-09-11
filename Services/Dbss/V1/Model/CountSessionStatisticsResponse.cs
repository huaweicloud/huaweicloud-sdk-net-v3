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
    public class CountSessionStatisticsResponse : SdkResponse
    {

        /// <summary>
        /// 生成时间
        /// </summary>
        [JsonProperty("generate_time", NullValueHandling = NullValueHandling.Ignore)]
        public string GenerateTime { get; set; }

        /// <summary>
        /// 统计数据列表
        /// </summary>
        [JsonProperty("session_statistics", NullValueHandling = NullValueHandling.Ignore)]
        public List<SessionStatisticsBean> SessionStatistics { get; set; }

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
            sb.Append("class CountSessionStatisticsResponse {\n");
            sb.Append("  generateTime: ").Append(GenerateTime).Append("\n");
            sb.Append("  sessionStatistics: ").Append(SessionStatistics).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CountSessionStatisticsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CountSessionStatisticsResponse input)
        {
            if (input == null) return false;
            if (this.GenerateTime != input.GenerateTime || (this.GenerateTime != null && !this.GenerateTime.Equals(input.GenerateTime))) return false;
            if (this.SessionStatistics != input.SessionStatistics || (this.SessionStatistics != null && input.SessionStatistics != null && !this.SessionStatistics.SequenceEqual(input.SessionStatistics))) return false;
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
                if (this.GenerateTime != null) hashCode = hashCode * 59 + this.GenerateTime.GetHashCode();
                if (this.SessionStatistics != null) hashCode = hashCode * 59 + this.SessionStatistics.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
