using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowBackgroundTaskProgressResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 后台任务处理进度。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("progress_percentage", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProgressPercentage { get; set; }

        /// <summary>
        /// **参数解释**： 剩余时间。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("remain_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? RemainTime { get; set; }

        /// <summary>
        /// **参数解释**： 步骤列表。   **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("step_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<StepDetail> StepList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBackgroundTaskProgressResponse {\n");
            sb.Append("  progressPercentage: ").Append(ProgressPercentage).Append("\n");
            sb.Append("  remainTime: ").Append(RemainTime).Append("\n");
            sb.Append("  stepList: ").Append(StepList).Append("\n");
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
            if (input == null) return false;
            if (this.ProgressPercentage != input.ProgressPercentage || (this.ProgressPercentage != null && !this.ProgressPercentage.Equals(input.ProgressPercentage))) return false;
            if (this.RemainTime != input.RemainTime || (this.RemainTime != null && !this.RemainTime.Equals(input.RemainTime))) return false;
            if (this.StepList != input.StepList || (this.StepList != null && input.StepList != null && !this.StepList.SequenceEqual(input.StepList))) return false;

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
                if (this.ProgressPercentage != null) hashCode = hashCode * 59 + this.ProgressPercentage.GetHashCode();
                if (this.RemainTime != null) hashCode = hashCode * 59 + this.RemainTime.GetHashCode();
                if (this.StepList != null) hashCode = hashCode * 59 + this.StepList.GetHashCode();
                return hashCode;
            }
        }
    }
}
