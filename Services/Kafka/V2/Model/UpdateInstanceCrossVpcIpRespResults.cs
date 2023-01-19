using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// 修改broker跨VPC访问的结果。
    /// </summary>
    public class UpdateInstanceCrossVpcIpRespResults 
    {

        /// <summary>
        /// advertised.listeners IP/域名。
        /// </summary>
        [JsonProperty("advertised_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string AdvertisedIp { get; set; }

        /// <summary>
        /// 修改broker跨VPC访问的状态。
        /// </summary>
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Success { get; set; }

        /// <summary>
        /// listeners IP。
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateInstanceCrossVpcIpRespResults {\n");
            sb.Append("  advertisedIp: ").Append(AdvertisedIp).Append("\n");
            sb.Append("  success: ").Append(Success).Append("\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateInstanceCrossVpcIpRespResults);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateInstanceCrossVpcIpRespResults input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdvertisedIp == input.AdvertisedIp ||
                    (this.AdvertisedIp != null &&
                    this.AdvertisedIp.Equals(input.AdvertisedIp))
                ) && 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
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
                if (this.AdvertisedIp != null)
                    hashCode = hashCode * 59 + this.AdvertisedIp.GetHashCode();
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                return hashCode;
            }
        }
    }
}
