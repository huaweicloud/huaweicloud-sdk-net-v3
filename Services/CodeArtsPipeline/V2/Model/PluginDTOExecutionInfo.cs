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
    /// **参数解释**： 执行信息。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
    /// </summary>
    public class PluginDTOExecutionInfo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("inner_execution_info", NullValueHandling = NullValueHandling.Ignore)]
        public PluginDTOExecutionInfoInnerExecutionInfo InnerExecutionInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PluginDTOExecutionInfo {\n");
            sb.Append("  innerExecutionInfo: ").Append(InnerExecutionInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PluginDTOExecutionInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PluginDTOExecutionInfo input)
        {
            if (input == null) return false;
            if (this.InnerExecutionInfo != input.InnerExecutionInfo || (this.InnerExecutionInfo != null && !this.InnerExecutionInfo.Equals(input.InnerExecutionInfo))) return false;

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
                if (this.InnerExecutionInfo != null) hashCode = hashCode * 59 + this.InnerExecutionInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
