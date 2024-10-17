using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 用户自定义属性
    /// </summary>
    public class UserPropDTO 
    {

        /// <summary>
        /// **参数说明**：用户自定义属性键。 **取值范围**：长度不超过128，只允许字母、数字、下划线（_）、连接符（-）的组合。
        /// </summary>
        [JsonProperty("prop_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PropKey { get; set; }

        /// <summary>
        /// **参数说明**：用户自定义属性值。 **取值范围**：长度不超过128，只允许中文、字母、数字、以及_? &#39;#().,&amp;%@!-等字符的组合。
        /// </summary>
        [JsonProperty("prop_value", NullValueHandling = NullValueHandling.Ignore)]
        public string PropValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserPropDTO {\n");
            sb.Append("  propKey: ").Append(PropKey).Append("\n");
            sb.Append("  propValue: ").Append(PropValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserPropDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UserPropDTO input)
        {
            if (input == null) return false;
            if (this.PropKey != input.PropKey || (this.PropKey != null && !this.PropKey.Equals(input.PropKey))) return false;
            if (this.PropValue != input.PropValue || (this.PropValue != null && !this.PropValue.Equals(input.PropValue))) return false;

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
                if (this.PropKey != null) hashCode = hashCode * 59 + this.PropKey.GetHashCode();
                if (this.PropValue != null) hashCode = hashCode * 59 + this.PropValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
