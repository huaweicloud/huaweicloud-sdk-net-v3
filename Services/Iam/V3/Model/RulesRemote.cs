using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RulesRemote 
    {

        /// <summary>
        /// 表示IdP断言中的属性。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 输入属性值中包含指定值才生效，并返回布尔值，返回值不能用于local块中的占位符。在同一个remote数组元素中，any_one_of与not_any_of互斥，两者至多填写一个，不能同时填写。
        /// </summary>
        [JsonProperty("any_one_of", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AnyOneOf { get; set; }

        /// <summary>
        /// 输入属性值中不包含指定值才生效，并返回布尔值，返回值不能用于local块中的占位符。在同一个remote数组元素中，any_one_of与not_any_of互斥，两者至多填写一个，不能同时填写。
        /// </summary>
        [JsonProperty("not_any_of", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NotAnyOf { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RulesRemote {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  anyOneOf: ").Append(AnyOneOf).Append("\n");
            sb.Append("  notAnyOf: ").Append(NotAnyOf).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RulesRemote);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RulesRemote input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.AnyOneOf != input.AnyOneOf || (this.AnyOneOf != null && input.AnyOneOf != null && !this.AnyOneOf.SequenceEqual(input.AnyOneOf))) return false;
            if (this.NotAnyOf != input.NotAnyOf || (this.NotAnyOf != null && input.NotAnyOf != null && !this.NotAnyOf.SequenceEqual(input.NotAnyOf))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.AnyOneOf != null) hashCode = hashCode * 59 + this.AnyOneOf.GetHashCode();
                if (this.NotAnyOf != null) hashCode = hashCode * 59 + this.NotAnyOf.GetHashCode();
                return hashCode;
            }
        }
    }
}
