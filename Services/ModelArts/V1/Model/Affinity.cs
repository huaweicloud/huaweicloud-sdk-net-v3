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
    /// **参数解释：** 节点亲和类型。 **约束限制：** AFFINITY/ANTI_AFFINITY
    /// </summary>
    public class Affinity 
    {

        /// <summary>
        /// **参数解释：** 节点亲和类型。 **约束限制：** 不涉及。 **取值范围：** - AFFINITY：亲和。 - ANTI_AFFINITY：反亲和。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("affinity_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AffinityType { get; set; }

        /// <summary>
        /// **参数解释：** 是否设置强亲和。 **约束限制：** 不涉及。 **取值范围：** - true：设置强亲和。 - false：不设置强亲和。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Required { get; set; }

        /// <summary>
        /// **参数解释：** 选择节点方式。 **约束限制：** 不涉及。 **取值范围：** IP **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("selection_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string SelectionMode { get; set; }

        /// <summary>
        /// **参数解释：** 通过上述方式选择的列表，长度不能超过20。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("targets", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Targets { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Affinity {\n");
            sb.Append("  affinityType: ").Append(AffinityType).Append("\n");
            sb.Append("  required: ").Append(Required).Append("\n");
            sb.Append("  selectionMode: ").Append(SelectionMode).Append("\n");
            sb.Append("  targets: ").Append(Targets).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Affinity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Affinity input)
        {
            if (input == null) return false;
            if (this.AffinityType != input.AffinityType || (this.AffinityType != null && !this.AffinityType.Equals(input.AffinityType))) return false;
            if (this.Required != input.Required || (this.Required != null && !this.Required.Equals(input.Required))) return false;
            if (this.SelectionMode != input.SelectionMode || (this.SelectionMode != null && !this.SelectionMode.Equals(input.SelectionMode))) return false;
            if (this.Targets != input.Targets || (this.Targets != null && input.Targets != null && !this.Targets.SequenceEqual(input.Targets))) return false;

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
                if (this.AffinityType != null) hashCode = hashCode * 59 + this.AffinityType.GetHashCode();
                if (this.Required != null) hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.SelectionMode != null) hashCode = hashCode * 59 + this.SelectionMode.GetHashCode();
                if (this.Targets != null) hashCode = hashCode * 59 + this.Targets.GetHashCode();
                return hashCode;
            }
        }
    }
}
