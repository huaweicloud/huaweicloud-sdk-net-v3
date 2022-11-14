using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowBandwidthCalcResponse : SdkResponse
    {

        /// <summary>
        /// 95峰值，日峰值月平均线信息
        /// </summary>
        [JsonProperty("bandwidth_calc", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> BandwidthCalc { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBandwidthCalcResponse {\n");
            sb.Append("  bandwidthCalc: ").Append(BandwidthCalc).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowBandwidthCalcResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowBandwidthCalcResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BandwidthCalc == input.BandwidthCalc ||
                    this.BandwidthCalc != null &&
                    input.BandwidthCalc != null &&
                    this.BandwidthCalc.SequenceEqual(input.BandwidthCalc)
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
                if (this.BandwidthCalc != null)
                    hashCode = hashCode * 59 + this.BandwidthCalc.GetHashCode();
                return hashCode;
            }
        }
    }
}
