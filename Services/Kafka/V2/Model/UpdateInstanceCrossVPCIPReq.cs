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
    /// 
    /// </summary>
    public class UpdateInstanceCrossVPCIPReq 
    {

        /// <summary>
        /// 用户自定义的advertised_ip_contents键值对。  键是listeners IP。  值是advertised.listeners IP，或者域名。  &gt; IP修改未修改项也需填上。
        /// </summary>
        [JsonProperty("advertised_ip_contents", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> AdvertisedIpContents { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateInstanceCrossVPCIPReq {\n");
            sb.Append("  advertisedIpContents: ").Append(AdvertisedIpContents).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateInstanceCrossVPCIPReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateInstanceCrossVPCIPReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdvertisedIpContents == input.AdvertisedIpContents ||
                    this.AdvertisedIpContents != null &&
                    input.AdvertisedIpContents != null &&
                    this.AdvertisedIpContents.SequenceEqual(input.AdvertisedIpContents)
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
                if (this.AdvertisedIpContents != null)
                    hashCode = hashCode * 59 + this.AdvertisedIpContents.GetHashCode();
                return hashCode;
            }
        }
    }
}
