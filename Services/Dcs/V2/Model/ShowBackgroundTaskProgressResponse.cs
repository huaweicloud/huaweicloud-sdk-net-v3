using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowBackgroundTaskProgressResponse : SdkResponse
    {

        /// <summary>
        /// 总体进度,百分比
        /// </summary>
        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public int? Progress { get; set; }

        /// <summary>
        /// 剩余时间(单位秒)
        /// </summary>
        [JsonProperty("remain_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? RemainTime { get; set; }

        /// <summary>
        /// 任务详情列表
        /// </summary>
        [JsonProperty("step_details", NullValueHandling = NullValueHandling.Ignore)]
        public List<StepDetail> StepDetails { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBackgroundTaskProgressResponse {\n");
            sb.Append("  progress: ").Append(Progress).Append("\n");
            sb.Append("  remainTime: ").Append(RemainTime).Append("\n");
            sb.Append("  stepDetails: ").Append(StepDetails).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowBackgroundTaskProgressResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowBackgroundTaskProgressResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Progress == input.Progress ||
                    (this.Progress != null &&
                    this.Progress.Equals(input.Progress))
                ) && 
                (
                    this.RemainTime == input.RemainTime ||
                    (this.RemainTime != null &&
                    this.RemainTime.Equals(input.RemainTime))
                ) && 
                (
                    this.StepDetails == input.StepDetails ||
                    this.StepDetails != null &&
                    input.StepDetails != null &&
                    this.StepDetails.SequenceEqual(input.StepDetails)
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
                if (this.Progress != null)
                    hashCode = hashCode * 59 + this.Progress.GetHashCode();
                if (this.RemainTime != null)
                    hashCode = hashCode * 59 + this.RemainTime.GetHashCode();
                if (this.StepDetails != null)
                    hashCode = hashCode * 59 + this.StepDetails.GetHashCode();
                return hashCode;
            }
        }
    }
}
