using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListAlarmStatisticsResponse : SdkResponse
    {

        /// <summary>
        /// 紧急告警记录列表总数。
        /// </summary>
        [JsonProperty("critical_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? CriticalCount { get; set; }

        /// <summary>
        /// 重要告警记录列表总数。
        /// </summary>
        [JsonProperty("major_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? MajorCount { get; set; }

        /// <summary>
        /// 次要告警记录列表总数。
        /// </summary>
        [JsonProperty("minor_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinorCount { get; set; }

        /// <summary>
        /// 提示告警记录列表总数。
        /// </summary>
        [JsonProperty("info_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? InfoCount { get; set; }

        /// <summary>
        /// 告警记录列表总数。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAlarmStatisticsResponse {\n");
            sb.Append("  criticalCount: ").Append(CriticalCount).Append("\n");
            sb.Append("  majorCount: ").Append(MajorCount).Append("\n");
            sb.Append("  minorCount: ").Append(MinorCount).Append("\n");
            sb.Append("  infoCount: ").Append(InfoCount).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAlarmStatisticsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAlarmStatisticsResponse input)
        {
            if (input == null) return false;
            if (this.CriticalCount != input.CriticalCount || (this.CriticalCount != null && !this.CriticalCount.Equals(input.CriticalCount))) return false;
            if (this.MajorCount != input.MajorCount || (this.MajorCount != null && !this.MajorCount.Equals(input.MajorCount))) return false;
            if (this.MinorCount != input.MinorCount || (this.MinorCount != null && !this.MinorCount.Equals(input.MinorCount))) return false;
            if (this.InfoCount != input.InfoCount || (this.InfoCount != null && !this.InfoCount.Equals(input.InfoCount))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;

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
                if (this.CriticalCount != null) hashCode = hashCode * 59 + this.CriticalCount.GetHashCode();
                if (this.MajorCount != null) hashCode = hashCode * 59 + this.MajorCount.GetHashCode();
                if (this.MinorCount != null) hashCode = hashCode * 59 + this.MinorCount.GetHashCode();
                if (this.InfoCount != null) hashCode = hashCode * 59 + this.InfoCount.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
