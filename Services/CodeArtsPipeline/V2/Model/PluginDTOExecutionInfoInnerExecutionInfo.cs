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
    /// **参数解释**： 插件执行信息。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
    /// </summary>
    public class PluginDTOExecutionInfoInnerExecutionInfo 
    {

        /// <summary>
        /// **参数解释**： 插件类型。 **约束限制**： 不涉及。 **取值范围**： CONTAINER, ZIP, SHELL, COMPOSITE。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("execution_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("steps", NullValueHandling = NullValueHandling.Ignore)]
        public List<PluginDTOExecutionInfoInnerExecutionInfoSteps> Steps { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PluginDTOExecutionInfoInnerExecutionInfo {\n");
            sb.Append("  executionType: ").Append(ExecutionType).Append("\n");
            sb.Append("  steps: ").Append(Steps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PluginDTOExecutionInfoInnerExecutionInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PluginDTOExecutionInfoInnerExecutionInfo input)
        {
            if (input == null) return false;
            if (this.ExecutionType != input.ExecutionType || (this.ExecutionType != null && !this.ExecutionType.Equals(input.ExecutionType))) return false;
            if (this.Steps != input.Steps || (this.Steps != null && input.Steps != null && !this.Steps.SequenceEqual(input.Steps))) return false;

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
                if (this.ExecutionType != null) hashCode = hashCode * 59 + this.ExecutionType.GetHashCode();
                if (this.Steps != null) hashCode = hashCode * 59 + this.Steps.GetHashCode();
                return hashCode;
            }
        }
    }
}
