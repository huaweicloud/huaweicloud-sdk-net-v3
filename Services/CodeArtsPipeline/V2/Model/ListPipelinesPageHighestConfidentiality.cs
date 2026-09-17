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
    /// **参数解释**： 最高密级。 **约束限制**： 非涉密场景无该字段。 **取值范围**： 不涉及。 
    /// </summary>
    public class ListPipelinesPageHighestConfidentiality 
    {

        /// <summary>
        /// **参数解释**： 密级ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**： 密级等级逻辑ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// **参数解释**： 预留字段。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("reserve_1", NullValueHandling = NullValueHandling.Ignore)]
        public string Reserve1 { get; set; }

        /// <summary>
        /// **参数解释**： 密级等级中文名。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// **参数解释**： 密级等级英文名。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("value_en", NullValueHandling = NullValueHandling.Ignore)]
        public string ValueEn { get; set; }

        /// <summary>
        /// **参数解释**： 密级等级序号，密级越高数字越大。 **取值范围**： 正整数。 
        /// </summary>
        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPipelinesPageHighestConfidentiality {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  reserve1: ").Append(Reserve1).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  valueEn: ").Append(ValueEn).Append("\n");
            sb.Append("  sequence: ").Append(Sequence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPipelinesPageHighestConfidentiality);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPipelinesPageHighestConfidentiality input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.Reserve1 != input.Reserve1 || (this.Reserve1 != null && !this.Reserve1.Equals(input.Reserve1))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
            if (this.ValueEn != input.ValueEn || (this.ValueEn != null && !this.ValueEn.Equals(input.ValueEn))) return false;
            if (this.Sequence != input.Sequence || (this.Sequence != null && !this.Sequence.Equals(input.Sequence))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Reserve1 != null) hashCode = hashCode * 59 + this.Reserve1.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.ValueEn != null) hashCode = hashCode * 59 + this.ValueEn.GetHashCode();
                if (this.Sequence != null) hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                return hashCode;
            }
        }
    }
}
