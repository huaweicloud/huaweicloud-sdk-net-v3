using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Eip 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("protected", NullValueHandling = NullValueHandling.Ignore)]
        public ChangedVO Protected { get; set; }

        /// <summary>
        /// **参数解释**： EIP数量 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Eip {\n");
            sb.Append("  Protected: ").Append(Protected).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Eip);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Eip input)
        {
            if (input == null) return false;
            if (this.Protected != input.Protected || (this.Protected != null && !this.Protected.Equals(input.Protected))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;

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
                if (this.Protected != null) hashCode = hashCode * 59 + this.Protected.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
