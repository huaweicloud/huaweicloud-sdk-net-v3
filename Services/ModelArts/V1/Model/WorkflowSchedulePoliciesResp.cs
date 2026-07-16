using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 工作流调度策略。
    /// </summary>
    public class WorkflowSchedulePoliciesResp 
    {

        /// <summary>
        /// **参数解释**：定时调度策略中的标记，失败时触发。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("on_failure", NullValueHandling = NullValueHandling.Ignore)]
        public string OnFailure { get; set; }

        /// <summary>
        /// **参数解释**：定时调度策略中的标记，running时触发。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("on_running", NullValueHandling = NullValueHandling.Ignore)]
        public string OnRunning { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowSchedulePoliciesResp {\n");
            sb.Append("  onFailure: ").Append(OnFailure).Append("\n");
            sb.Append("  onRunning: ").Append(OnRunning).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkflowSchedulePoliciesResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkflowSchedulePoliciesResp input)
        {
            if (input == null) return false;
            if (this.OnFailure != input.OnFailure || (this.OnFailure != null && !this.OnFailure.Equals(input.OnFailure))) return false;
            if (this.OnRunning != input.OnRunning || (this.OnRunning != null && !this.OnRunning.Equals(input.OnRunning))) return false;

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
                if (this.OnFailure != null) hashCode = hashCode * 59 + this.OnFailure.GetHashCode();
                if (this.OnRunning != null) hashCode = hashCode * 59 + this.OnRunning.GetHashCode();
                return hashCode;
            }
        }
    }
}
