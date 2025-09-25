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
    /// 
    /// </summary>
    public class ActionsPipelineRunsPollingQueryDTO 
    {

        /// <summary>
        /// **参数解释**： 流水线运行实例ID列表。 **约束限制**： 不涉及。 **取值范围**： 32位字符，仅由数字和字母组成。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("pipeline_run_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PipelineRunIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionsPipelineRunsPollingQueryDTO {\n");
            sb.Append("  pipelineRunIds: ").Append(PipelineRunIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ActionsPipelineRunsPollingQueryDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ActionsPipelineRunsPollingQueryDTO input)
        {
            if (input == null) return false;
            if (this.PipelineRunIds != input.PipelineRunIds || (this.PipelineRunIds != null && input.PipelineRunIds != null && !this.PipelineRunIds.SequenceEqual(input.PipelineRunIds))) return false;

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
                if (this.PipelineRunIds != null) hashCode = hashCode * 59 + this.PipelineRunIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
