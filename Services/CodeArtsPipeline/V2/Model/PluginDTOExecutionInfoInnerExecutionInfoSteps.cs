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
    public class PluginDTOExecutionInfoInnerExecutionInfoSteps 
    {

        /// <summary>
        /// **参数解释**： 任务名称。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 任务类型。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("task", NullValueHandling = NullValueHandling.Ignore)]
        public string Task { get; set; }

        /// <summary>
        /// **参数解释**： 参数信息。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("variables", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> Variables { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PluginDTOExecutionInfoInnerExecutionInfoSteps {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  task: ").Append(Task).Append("\n");
            sb.Append("  variables: ").Append(Variables).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PluginDTOExecutionInfoInnerExecutionInfoSteps);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PluginDTOExecutionInfoInnerExecutionInfoSteps input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Task != input.Task || (this.Task != null && !this.Task.Equals(input.Task))) return false;
            if (this.Variables != input.Variables || (this.Variables != null && input.Variables != null && !this.Variables.SequenceEqual(input.Variables))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Task != null) hashCode = hashCode * 59 + this.Task.GetHashCode();
                if (this.Variables != null) hashCode = hashCode * 59 + this.Variables.GetHashCode();
                return hashCode;
            }
        }
    }
}
