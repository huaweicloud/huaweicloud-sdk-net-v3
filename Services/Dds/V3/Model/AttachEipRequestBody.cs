using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AttachEipRequestBody 
    {

        /// <summary>
        /// 公网IP的ID。
        /// </summary>
        [JsonProperty("public_ip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIpId { get; set; }

        /// <summary>
        /// 公网IP。
        /// </summary>
        [JsonProperty("public_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachEipRequestBody {\n");
            sb.Append("  publicIpId: ").Append(PublicIpId).Append("\n");
            sb.Append("  publicIp: ").Append(PublicIp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttachEipRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttachEipRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PublicIpId == input.PublicIpId ||
                    (this.PublicIpId != null &&
                    this.PublicIpId.Equals(input.PublicIpId))
                ) && 
                (
                    this.PublicIp == input.PublicIp ||
                    (this.PublicIp != null &&
                    this.PublicIp.Equals(input.PublicIp))
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
                if (this.PublicIpId != null)
                    hashCode = hashCode * 59 + this.PublicIpId.GetHashCode();
                if (this.PublicIp != null)
                    hashCode = hashCode * 59 + this.PublicIp.GetHashCode();
                return hashCode;
            }
        }
    }
}
