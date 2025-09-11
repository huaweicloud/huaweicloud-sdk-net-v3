using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// EIP信息
    /// </summary>
    public class Eip 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public BandWidth Bandwidth { get; set; }

        /// <summary>
        /// IP产品ID
        /// </summary>
        [JsonProperty("ipproductid", NullValueHandling = NullValueHandling.Ignore)]
        public string Ipproductid { get; set; }

        /// <summary>
        /// EIP类型
        /// </summary>
        [JsonProperty("iptype", NullValueHandling = NullValueHandling.Ignore)]
        public string Iptype { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Eip {\n");
            sb.Append("  bandwidth: ").Append(Bandwidth).Append("\n");
            sb.Append("  ipproductid: ").Append(Ipproductid).Append("\n");
            sb.Append("  iptype: ").Append(Iptype).Append("\n");
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
            if (this.Bandwidth != input.Bandwidth || (this.Bandwidth != null && !this.Bandwidth.Equals(input.Bandwidth))) return false;
            if (this.Ipproductid != input.Ipproductid || (this.Ipproductid != null && !this.Ipproductid.Equals(input.Ipproductid))) return false;
            if (this.Iptype != input.Iptype || (this.Iptype != null && !this.Iptype.Equals(input.Iptype))) return false;

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
                if (this.Bandwidth != null) hashCode = hashCode * 59 + this.Bandwidth.GetHashCode();
                if (this.Ipproductid != null) hashCode = hashCode * 59 + this.Ipproductid.GetHashCode();
                if (this.Iptype != null) hashCode = hashCode * 59 + this.Iptype.GetHashCode();
                return hashCode;
            }
        }
    }
}
