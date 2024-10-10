using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListWafBandwidthResponse : SdkResponse
    {

        /// <summary>
        /// 曲线
        /// </summary>
        [JsonProperty("curve", NullValueHandling = NullValueHandling.Ignore)]
        public List<Curve> Curve { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListWafBandwidthResponse {\n");
            sb.Append("  curve: ").Append(Curve).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListWafBandwidthResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListWafBandwidthResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Curve == input.Curve ||
                    this.Curve != null &&
                    input.Curve != null &&
                    this.Curve.SequenceEqual(input.Curve)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Curve != null)
                    hashCode = hashCode * 59 + this.Curve.GetHashCode();
                return hashCode;
            }
        }
    }
}
