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
    public class ShowWorkFlowMetricResponse : SdkResponse
    {

        /// <summary>
        /// 执行次数
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
        /// 运行中数量
        /// </summary>
        [JsonProperty("running_count", NullValueHandling = NullValueHandling.Ignore)]
        public List<SlaReportsValue> RunningCount { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowWorkFlowMetricResponse {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  failCount: ").Append(FailCount).Append("\n");
            sb.Append("  runningCount: ").Append(RunningCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowWorkFlowMetricResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowWorkFlowMetricResponse input)
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
                    this.RunningCount == input.RunningCount ||
                    this.RunningCount != null &&
                    input.RunningCount != null &&
                    this.RunningCount.SequenceEqual(input.RunningCount)
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
                if (this.RunningCount != null)
                    hashCode = hashCode * 59 + this.RunningCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
