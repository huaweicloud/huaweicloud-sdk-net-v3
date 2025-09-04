using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bss.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class LimitValue 
    {

        /// <summary>
        /// 属性值1。
        /// </summary>
        [JsonProperty("value1", NullValueHandling = NullValueHandling.Ignore)]
        public string Value1 { get; set; }

        /// <summary>
        /// 属性值2。
        /// </summary>
        [JsonProperty("value2", NullValueHandling = NullValueHandling.Ignore)]
        public string Value2 { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LimitValue {\n");
            sb.Append("  value1: ").Append(Value1).Append("\n");
            sb.Append("  value2: ").Append(Value2).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LimitValue);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LimitValue input)
        {
            if (input == null) return false;
            if (this.Value1 != input.Value1 || (this.Value1 != null && !this.Value1.Equals(input.Value1))) return false;
            if (this.Value2 != input.Value2 || (this.Value2 != null && !this.Value2.Equals(input.Value2))) return false;

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
                if (this.Value1 != null) hashCode = hashCode * 59 + this.Value1.GetHashCode();
                if (this.Value2 != null) hashCode = hashCode * 59 + this.Value2.GetHashCode();
                return hashCode;
            }
        }
    }
}
