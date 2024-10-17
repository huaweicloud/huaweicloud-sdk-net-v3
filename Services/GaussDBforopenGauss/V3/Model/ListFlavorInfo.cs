using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 规格信息。
    /// </summary>
    public class ListFlavorInfo 
    {

        /// <summary>
        /// cpu核数。
        /// </summary>
        [JsonProperty("vcpu", NullValueHandling = NullValueHandling.Ignore)]
        public int? Vcpu { get; set; }

        /// <summary>
        /// 内存大小。
        /// </summary>
        [JsonProperty("mem", NullValueHandling = NullValueHandling.Ignore)]
        public int? Mem { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFlavorInfo {\n");
            sb.Append("  vcpu: ").Append(Vcpu).Append("\n");
            sb.Append("  mem: ").Append(Mem).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListFlavorInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFlavorInfo input)
        {
            if (input == null) return false;
            if (this.Vcpu != input.Vcpu || (this.Vcpu != null && !this.Vcpu.Equals(input.Vcpu))) return false;
            if (this.Mem != input.Mem || (this.Mem != null && !this.Mem.Equals(input.Mem))) return false;

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
                if (this.Vcpu != null) hashCode = hashCode * 59 + this.Vcpu.GetHashCode();
                if (this.Mem != null) hashCode = hashCode * 59 + this.Mem.GetHashCode();
                return hashCode;
            }
        }
    }
}
