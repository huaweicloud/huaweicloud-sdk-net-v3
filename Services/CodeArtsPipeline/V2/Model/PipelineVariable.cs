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
    /// 流水线自定义参数
    /// </summary>
    public class PipelineVariable 
    {

        /// <summary>
        /// **参数解释**： 自定义参数名称。 **取值范围**： 仅支持大小写英文字母、数字、“_”，不超过128个字符。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 序号。 **取值范围**： [1, 2147483647]。 
        /// </summary>
        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; }

        /// <summary>
        /// **参数解释**： 自定义参数的类型。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**： 自定义参数的默认值。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// **参数解释**： 是否为私密参数。 **取值范围**： - true：是私密参数。 - false：不是私密参数。 
        /// </summary>
        [JsonProperty("is_secret", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSecret { get; set; }

        /// <summary>
        /// **参数解释**： 自定义参数描述。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 是否运行时设置。 **取值范围**： - true：运行时设置。 - false：非运行时设置。 
        /// </summary>
        [JsonProperty("is_runtime", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsRuntime { get; set; }

        /// <summary>
        /// **参数解释**： 限定枚举值列表。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("limits", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Limits { get; set; }

        /// <summary>
        /// **参数解释**： 自增长参数是否被重置。 **取值范围**： - true：被重置。 - false：不被重置。 
        /// </summary>
        [JsonProperty("is_reset", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsReset { get; set; }

        /// <summary>
        /// **参数解释**： 自增长参数最新值。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("latest_value", NullValueHandling = NullValueHandling.Ignore)]
        public string LatestValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PipelineVariable {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  sequence: ").Append(Sequence).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  isSecret: ").Append(IsSecret).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  isRuntime: ").Append(IsRuntime).Append("\n");
            sb.Append("  limits: ").Append(Limits).Append("\n");
            sb.Append("  isReset: ").Append(IsReset).Append("\n");
            sb.Append("  latestValue: ").Append(LatestValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PipelineVariable);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PipelineVariable input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Sequence != input.Sequence || (this.Sequence != null && !this.Sequence.Equals(input.Sequence))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
            if (this.IsSecret != input.IsSecret || (this.IsSecret != null && !this.IsSecret.Equals(input.IsSecret))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.IsRuntime != input.IsRuntime || (this.IsRuntime != null && !this.IsRuntime.Equals(input.IsRuntime))) return false;
            if (this.Limits != input.Limits || (this.Limits != null && input.Limits != null && !this.Limits.SequenceEqual(input.Limits))) return false;
            if (this.IsReset != input.IsReset || (this.IsReset != null && !this.IsReset.Equals(input.IsReset))) return false;
            if (this.LatestValue != input.LatestValue || (this.LatestValue != null && !this.LatestValue.Equals(input.LatestValue))) return false;

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
                if (this.Limits != null) hashCode = hashCode * 59 + this.Limits.GetHashCode();
                if (this.IsReset != null) hashCode = hashCode * 59 + this.IsReset.GetHashCode();
                if (this.LatestValue != null) hashCode = hashCode * 59 + this.LatestValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
