using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.AntiDDoS.V1.Model
{
    /// <summary>
    /// WeeklyTop10
    /// </summary>
    public class WeeklyTop10 
    {

        /// <summary>
        /// 弹性IP地址
        /// </summary>
        [JsonProperty("floating_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string FloatingIpAddress { get; set; }

        /// <summary>
        /// DDoS拦截次数，包括清洗和黑洞
        /// </summary>
        [JsonProperty("times", NullValueHandling = NullValueHandling.Ignore)]
        public int? Times { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WeeklyTop10 {\n");
            sb.Append("  floatingIpAddress: ").Append(FloatingIpAddress).Append("\n");
            sb.Append("  times: ").Append(Times).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WeeklyTop10);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WeeklyTop10 input)
        {
            if (input == null) return false;
            if (this.FloatingIpAddress != input.FloatingIpAddress || (this.FloatingIpAddress != null && !this.FloatingIpAddress.Equals(input.FloatingIpAddress))) return false;
            if (this.Times != input.Times || (this.Times != null && !this.Times.Equals(input.Times))) return false;

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
                if (this.FloatingIpAddress != null) hashCode = hashCode * 59 + this.FloatingIpAddress.GetHashCode();
                if (this.Times != null) hashCode = hashCode * 59 + this.Times.GetHashCode();
                return hashCode;
            }
        }
    }
}
