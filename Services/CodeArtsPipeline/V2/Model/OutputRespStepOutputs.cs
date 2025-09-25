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
    public class OutputRespStepOutputs 
    {

        /// <summary>
        /// **参数解释**： 步骤ID。 **取值范围**： 32位字符，由数字和字母组成。 
        /// </summary>
        [JsonProperty("step_run_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StepRunId { get; set; }

        /// <summary>
        /// **参数解释**： 步骤输出。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("output_result", NullValueHandling = NullValueHandling.Ignore)]
        public List<OutputRespOutputResult> OutputResult { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutputRespStepOutputs {\n");
            sb.Append("  stepRunId: ").Append(StepRunId).Append("\n");
            sb.Append("  outputResult: ").Append(OutputResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OutputRespStepOutputs);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OutputRespStepOutputs input)
        {
            if (input == null) return false;
            if (this.StepRunId != input.StepRunId || (this.StepRunId != null && !this.StepRunId.Equals(input.StepRunId))) return false;
            if (this.OutputResult != input.OutputResult || (this.OutputResult != null && input.OutputResult != null && !this.OutputResult.SequenceEqual(input.OutputResult))) return false;

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
                if (this.StepRunId != null) hashCode = hashCode * 59 + this.StepRunId.GetHashCode();
                if (this.OutputResult != null) hashCode = hashCode * 59 + this.OutputResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
