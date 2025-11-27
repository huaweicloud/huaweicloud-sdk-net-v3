using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomQosLimit 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("l4", NullValueHandling = NullValueHandling.Ignore)]
        public L4Limit L4 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("l7", NullValueHandling = NullValueHandling.Ignore)]
        public L7Limit L7 { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomQosLimit {\n");
            sb.Append("  l4: ").Append(L4).Append("\n");
            sb.Append("  l7: ").Append(L7).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CustomQosLimit);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CustomQosLimit input)
        {
            if (input == null) return false;
            if (this.L4 != input.L4 || (this.L4 != null && !this.L4.Equals(input.L4))) return false;
            if (this.L7 != input.L7 || (this.L7 != null && !this.L7.Equals(input.L7))) return false;

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
                if (this.L4 != null) hashCode = hashCode * 59 + this.L4.GetHashCode();
                if (this.L7 != null) hashCode = hashCode * 59 + this.L7.GetHashCode();
                return hashCode;
            }
        }
    }
}
