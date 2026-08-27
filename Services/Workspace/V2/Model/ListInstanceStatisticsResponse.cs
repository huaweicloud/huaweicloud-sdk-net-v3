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
    public class ListInstanceStatisticsResponse : SdkResponse
    {

        /// <summary>
        /// 桌面总数
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// 未配置模型桌面数
        /// </summary>
        [JsonProperty("unconfigured_model_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? UnconfiguredModelCount { get; set; }

        /// <summary>
        /// 未配置通道桌面数
        /// </summary>
        [JsonProperty("unconfigured_channel_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? UnconfiguredChannelCount { get; set; }

        /// <summary>
        /// 存在风险桌面数
        /// </summary>
        [JsonProperty("risk_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? RiskCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstanceStatisticsResponse {\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  unconfiguredModelCount: ").Append(UnconfiguredModelCount).Append("\n");
            sb.Append("  unconfiguredChannelCount: ").Append(UnconfiguredChannelCount).Append("\n");
            sb.Append("  riskCount: ").Append(RiskCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstanceStatisticsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstanceStatisticsResponse input)
        {
            if (input == null) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.UnconfiguredModelCount != input.UnconfiguredModelCount || (this.UnconfiguredModelCount != null && !this.UnconfiguredModelCount.Equals(input.UnconfiguredModelCount))) return false;
            if (this.UnconfiguredChannelCount != input.UnconfiguredChannelCount || (this.UnconfiguredChannelCount != null && !this.UnconfiguredChannelCount.Equals(input.UnconfiguredChannelCount))) return false;
            if (this.RiskCount != input.RiskCount || (this.RiskCount != null && !this.RiskCount.Equals(input.RiskCount))) return false;

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
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.UnconfiguredModelCount != null) hashCode = hashCode * 59 + this.UnconfiguredModelCount.GetHashCode();
                if (this.UnconfiguredChannelCount != null) hashCode = hashCode * 59 + this.UnconfiguredChannelCount.GetHashCode();
                if (this.RiskCount != null) hashCode = hashCode * 59 + this.RiskCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
