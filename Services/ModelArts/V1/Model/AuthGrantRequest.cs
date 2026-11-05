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
    /// 
    /// </summary>
    public class AuthGrantRequest 
    {

        /// <summary>
        /// **参数解释**：是否重置授权。 **约束限制**：不涉及。 **取值范围**： - true：重置已有委托（先删除再创建）。 - false：普通授权。 **默认取值**：false。
        /// </summary>
        [JsonProperty("is_reset", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsReset { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthGrantRequest {\n");
            sb.Append("  isReset: ").Append(IsReset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuthGrantRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AuthGrantRequest input)
        {
            if (input == null) return false;
            if (this.IsReset != input.IsReset || (this.IsReset != null && !this.IsReset.Equals(input.IsReset))) return false;

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
                if (this.IsReset != null) hashCode = hashCode * 59 + this.IsReset.GetHashCode();
                return hashCode;
            }
        }
    }
}
