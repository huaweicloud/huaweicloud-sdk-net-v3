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
    public class PipelineByTemplateDTOVariables 
    {

        /// <summary>
        /// **参数解释**： 参数名称。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public Object Name { get; set; }

        /// <summary>
        /// **参数解释**： 参数序号，从1开始递增。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; }

        /// <summary>
        /// **参数解释**： 参数类型。 **约束限制**： 不涉及。 **取值范围**： - autoIncrement：自增长参数。 - enum：枚举参数。 - string：字符串参数。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**： 参数值。 **约束限制**： 不涉及。 **取值范围**： 不超过8192字符。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// **参数解释**： 是否私密参数。 **约束限制**： 不涉及。 **取值范围**： - true：是私密参数。 - false：不是私密参数。 **默认取值**： false。 
        /// </summary>
        [JsonProperty("is_secret", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSecret { get; set; }

        /// <summary>
        /// **参数解释**： 参数描述。 **约束限制**： 不涉及。 **取值范围**： 不超过512字符。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 是否运行时设置参数。 **约束限制**： 不涉及。 **取值范围**： - true：是运行时设置参数。 - false：不是运行时设置参数。 **默认取值**： false。 
        /// </summary>
        [JsonProperty("is_runtime", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsRuntime { get; set; }

        /// <summary>
        /// **参数解释**： 是否重置。自增长参数被编辑，则使用编辑后的值，否则进行末位数字递增。 **约束限制**： 不涉及。 **取值范围**： - true：使用编辑后的参数值。 - false：使用自增长参数。 **默认取值**： false 
        /// </summary>
        [JsonProperty("is_reset", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsReset { get; set; }

        /// <summary>
        /// **参数解释**： 最近一次运行的参数值。 **约束限制**： 不涉及。 **取值范围**： 不超过8192字符。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("latest_value", NullValueHandling = NullValueHandling.Ignore)]
        public string LatestValue { get; set; }

        /// <summary>
        /// **参数解释**： 枚举值列表。 **约束限制**： 不涉及。 **取值范围**： 每个枚举值不超过1024字符。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("limits", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Limits { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PipelineByTemplateDTOVariables {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  sequence: ").Append(Sequence).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  isSecret: ").Append(IsSecret).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  isRuntime: ").Append(IsRuntime).Append("\n");
            sb.Append("  isReset: ").Append(IsReset).Append("\n");
            sb.Append("  latestValue: ").Append(LatestValue).Append("\n");
            sb.Append("  limits: ").Append(Limits).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PipelineByTemplateDTOVariables);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PipelineByTemplateDTOVariables input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Sequence != input.Sequence || (this.Sequence != null && !this.Sequence.Equals(input.Sequence))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
            if (this.IsSecret != input.IsSecret || (this.IsSecret != null && !this.IsSecret.Equals(input.IsSecret))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.IsRuntime != input.IsRuntime || (this.IsRuntime != null && !this.IsRuntime.Equals(input.IsRuntime))) return false;
            if (this.IsReset != input.IsReset || (this.IsReset != null && !this.IsReset.Equals(input.IsReset))) return false;
            if (this.LatestValue != input.LatestValue || (this.LatestValue != null && !this.LatestValue.Equals(input.LatestValue))) return false;
            if (this.Limits != input.Limits || (this.Limits != null && input.Limits != null && !this.Limits.SequenceEqual(input.Limits))) return false;

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
                if (this.Sequence != null) hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.IsSecret != null) hashCode = hashCode * 59 + this.IsSecret.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IsRuntime != null) hashCode = hashCode * 59 + this.IsRuntime.GetHashCode();
                if (this.IsReset != null) hashCode = hashCode * 59 + this.IsReset.GetHashCode();
                if (this.LatestValue != null) hashCode = hashCode * 59 + this.LatestValue.GetHashCode();
                if (this.Limits != null) hashCode = hashCode * 59 + this.Limits.GetHashCode();
                return hashCode;
            }
        }
    }
}
