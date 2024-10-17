using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Geip.V3.Model
{
    /// <summary>
    /// 请求参数对象
    /// </summary>
    public class AttachInternetBandwidthGlobalEipRequestBodyGlobalEip 
    {

        /// <summary>
        /// 全域公网带宽的ID
        /// </summary>
        [JsonProperty("internet_bandwidth_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InternetBandwidthId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachInternetBandwidthGlobalEipRequestBodyGlobalEip {\n");
            sb.Append("  internetBandwidthId: ").Append(InternetBandwidthId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttachInternetBandwidthGlobalEipRequestBodyGlobalEip);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttachInternetBandwidthGlobalEipRequestBodyGlobalEip input)
        {
            if (input == null) return false;
            if (this.InternetBandwidthId != input.InternetBandwidthId || (this.InternetBandwidthId != null && !this.InternetBandwidthId.Equals(input.InternetBandwidthId))) return false;

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
                if (this.InternetBandwidthId != null) hashCode = hashCode * 59 + this.InternetBandwidthId.GetHashCode();
                return hashCode;
            }
        }
    }
}
