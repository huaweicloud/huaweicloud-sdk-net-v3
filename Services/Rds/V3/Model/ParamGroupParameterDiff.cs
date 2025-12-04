using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 参数差异信息
    /// </summary>
    public class ParamGroupParameterDiff 
    {

        /// <summary>
        /// **参数解释**：  参数名称  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：  源模板参数值。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("source_value", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceValue { get; set; }

        /// <summary>
        /// **参数解释**：  目标模板参数值。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("target_value", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParamGroupParameterDiff {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  sourceValue: ").Append(SourceValue).Append("\n");
            sb.Append("  targetValue: ").Append(TargetValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ParamGroupParameterDiff);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ParamGroupParameterDiff input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.SourceValue != input.SourceValue || (this.SourceValue != null && !this.SourceValue.Equals(input.SourceValue))) return false;
            if (this.TargetValue != input.TargetValue || (this.TargetValue != null && !this.TargetValue.Equals(input.TargetValue))) return false;

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
                if (this.SourceValue != null) hashCode = hashCode * 59 + this.SourceValue.GetHashCode();
                if (this.TargetValue != null) hashCode = hashCode * 59 + this.TargetValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
