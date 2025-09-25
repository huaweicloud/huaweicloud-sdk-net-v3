using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowStepOutputsResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 步骤输出列表，记录每个步骤输出的ID和结果信息。 **约束限制**： 不涉及。 
        /// </summary>
        [JsonProperty("step_outputs", NullValueHandling = NullValueHandling.Ignore)]
        public List<OutputRespStepOutputs> StepOutputs { get; set; }

        /// <summary>
        /// **参数解释**： 当前系统时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("current_system_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CurrentSystemTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowStepOutputsResponse {\n");
            sb.Append("  stepOutputs: ").Append(StepOutputs).Append("\n");
            sb.Append("  currentSystemTime: ").Append(CurrentSystemTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowStepOutputsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowStepOutputsResponse input)
        {
            if (input == null) return false;
            if (this.StepOutputs != input.StepOutputs || (this.StepOutputs != null && input.StepOutputs != null && !this.StepOutputs.SequenceEqual(input.StepOutputs))) return false;
            if (this.CurrentSystemTime != input.CurrentSystemTime || (this.CurrentSystemTime != null && !this.CurrentSystemTime.Equals(input.CurrentSystemTime))) return false;

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
                if (this.StepOutputs != null) hashCode = hashCode * 59 + this.StepOutputs.GetHashCode();
                if (this.CurrentSystemTime != null) hashCode = hashCode * 59 + this.CurrentSystemTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
