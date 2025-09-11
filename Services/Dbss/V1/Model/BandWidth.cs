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
    /// 带宽参数
    /// </summary>
    public class BandWidth 
    {

        /// <summary>
        /// 计费类型
        /// </summary>
        [JsonProperty("chargemode", NullValueHandling = NullValueHandling.Ignore)]
        public string Chargemode { get; set; }

        /// <summary>
        /// 带宽对应产品ID
        /// </summary>
        [JsonProperty("productid", NullValueHandling = NullValueHandling.Ignore)]
        public string Productid { get; set; }

        /// <summary>
        /// 共享类型，目前仅支持PER
        /// </summary>
        [JsonProperty("sharetype", NullValueHandling = NullValueHandling.Ignore)]
        public string Sharetype { get; set; }

        /// <summary>
        /// 带宽，按需1-100M，包年包月1-300M
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BandWidth {\n");
            sb.Append("  chargemode: ").Append(Chargemode).Append("\n");
            sb.Append("  productid: ").Append(Productid).Append("\n");
            sb.Append("  sharetype: ").Append(Sharetype).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BandWidth);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BandWidth input)
        {
            if (input == null) return false;
            if (this.Chargemode != input.Chargemode || (this.Chargemode != null && !this.Chargemode.Equals(input.Chargemode))) return false;
            if (this.Productid != input.Productid || (this.Productid != null && !this.Productid.Equals(input.Productid))) return false;
            if (this.Sharetype != input.Sharetype || (this.Sharetype != null && !this.Sharetype.Equals(input.Sharetype))) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;

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
                if (this.Chargemode != null) hashCode = hashCode * 59 + this.Chargemode.GetHashCode();
                if (this.Productid != null) hashCode = hashCode * 59 + this.Productid.GetHashCode();
                if (this.Sharetype != null) hashCode = hashCode * 59 + this.Sharetype.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                return hashCode;
            }
        }
    }
}
