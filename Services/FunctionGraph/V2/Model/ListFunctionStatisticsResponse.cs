using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListFunctionStatisticsResponse : SdkResponse
    {

        /// <summary>
        /// 调用次数
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public List<SlaReportsValue> Count { get; set; }

        /// <summary>
        /// 平均时延，单位毫秒
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public List<SlaReportsValue> Duration { get; set; }

        /// <summary>
        /// 错误次数
        /// </summary>
        [JsonProperty("fail_count", NullValueHandling = NullValueHandling.Ignore)]
        public List<SlaReportsValue> FailCount { get; set; }

        /// <summary>
        /// 最大时延，单位毫秒
        /// </summary>
        [JsonProperty("max_duration", NullValueHandling = NullValueHandling.Ignore)]
        public List<SlaReportsValue> MaxDuration { get; set; }

        /// <summary>
        /// 最小时延，单位毫秒
        /// </summary>
        [JsonProperty("min_duration", NullValueHandling = NullValueHandling.Ignore)]
        public List<SlaReportsValue> MinDuration { get; set; }

        /// <summary>
        /// 被拒绝次数
        /// </summary>
        [JsonProperty("reject_count", NullValueHandling = NullValueHandling.Ignore)]
        public List<SlaReportsValue> RejectCount { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFunctionStatisticsResponse {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  failCount: ").Append(FailCount).Append("\n");
            sb.Append("  maxDuration: ").Append(MaxDuration).Append("\n");
            sb.Append("  minDuration: ").Append(MinDuration).Append("\n");
            sb.Append("  rejectCount: ").Append(RejectCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListFunctionStatisticsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFunctionStatisticsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Count == input.Count ||
                    this.Count != null &&
                    input.Count != null &&
                    this.Count.SequenceEqual(input.Count)
                ) && 
                (
                    this.Duration == input.Duration ||
                    this.Duration != null &&
                    input.Duration != null &&
                    this.Duration.SequenceEqual(input.Duration)
                ) && 
                (
                    this.FailCount == input.FailCount ||
                    this.FailCount != null &&
                    input.FailCount != null &&
                    this.FailCount.SequenceEqual(input.FailCount)
                ) && 
                (
                    this.MaxDuration == input.MaxDuration ||
                    this.MaxDuration != null &&
                    input.MaxDuration != null &&
                    this.MaxDuration.SequenceEqual(input.MaxDuration)
                ) && 
                (
                    this.MinDuration == input.MinDuration ||
                    this.MinDuration != null &&
                    input.MinDuration != null &&
                    this.MinDuration.SequenceEqual(input.MinDuration)
                ) && 
                (
                    this.RejectCount == input.RejectCount ||
                    this.RejectCount != null &&
                    input.RejectCount != null &&
                    this.RejectCount.SequenceEqual(input.RejectCount)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.FailCount != null)
                    hashCode = hashCode * 59 + this.FailCount.GetHashCode();
                if (this.MaxDuration != null)
                    hashCode = hashCode * 59 + this.MaxDuration.GetHashCode();
                if (this.MinDuration != null)
                    hashCode = hashCode * 59 + this.MinDuration.GetHashCode();
                if (this.RejectCount != null)
                    hashCode = hashCode * 59 + this.RejectCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
