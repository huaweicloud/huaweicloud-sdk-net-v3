using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2.Model
{
    /// <summary>
    /// **参数解释：** 自定义参数。 **取值范围：** 不涉及。
    /// </summary>
    public class CustomParameter 
    {

        /// <summary>
        /// **参数解释：** 是否是私密参数。 **取值范围：** - true：私密参数。 - false：非私密参数。
        /// </summary>
        [JsonProperty("isPrivate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPrivate { get; set; }

        /// <summary>
        /// **参数解释：** 自定义参数的key。 **取值范围：** 长度为[1~128]个字符。
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// **参数解释：** 自定义参数的Value。 **取值范围：** 长度为[1~8192]个字符。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomParameter {\n");
            sb.Append("  isPrivate: ").Append(IsPrivate).Append("\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CustomParameter);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CustomParameter input)
        {
            if (input == null) return false;
            if (this.IsPrivate != input.IsPrivate || (this.IsPrivate != null && !this.IsPrivate.Equals(input.IsPrivate))) return false;
            if (this.Key != input.Key || (this.Key != null && !this.Key.Equals(input.Key))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;

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
                if (this.IsPrivate != null) hashCode = hashCode * 59 + this.IsPrivate.GetHashCode();
                if (this.Key != null) hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }
}
