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
    public class UpdateRuleSetStatusReq 
    {

        /// <summary>
        /// **参数解释**： 规则模板实例状态。 **约束限制**： 不涉及。 **取值范围**： - true：开。 - false：关。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("is_valid", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsValid { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateRuleSetStatusReq {\n");
            sb.Append("  isValid: ").Append(IsValid).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateRuleSetStatusReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateRuleSetStatusReq input)
        {
            if (input == null) return false;
            if (this.IsValid != input.IsValid || (this.IsValid != null && !this.IsValid.Equals(input.IsValid))) return false;

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
                if (this.IsValid != null) hashCode = hashCode * 59 + this.IsValid.GetHashCode();
                return hashCode;
            }
        }
    }
}
