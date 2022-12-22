using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ModifyPublicIpRequestBody 
    {

        /// <summary>
        /// 操作标识。取值： - BIND，表示绑定弹性公网IP。 - UNBIND，表示解绑弹性公网IP。
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// 弹性公网IP。
        /// </summary>
        [JsonProperty("public_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIp { get; set; }

        /// <summary>
        /// 弹性公网IP的ID。
        /// </summary>
        [JsonProperty("public_ip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIpId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyPublicIpRequestBody {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  publicIp: ").Append(PublicIp).Append("\n");
            sb.Append("  publicIpId: ").Append(PublicIpId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyPublicIpRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyPublicIpRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.PublicIp == input.PublicIp ||
                    (this.PublicIp != null &&
                    this.PublicIp.Equals(input.PublicIp))
                ) && 
                (
                    this.PublicIpId == input.PublicIpId ||
                    (this.PublicIpId != null &&
                    this.PublicIpId.Equals(input.PublicIpId))
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
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.PublicIp != null)
                    hashCode = hashCode * 59 + this.PublicIp.GetHashCode();
                if (this.PublicIpId != null)
                    hashCode = hashCode * 59 + this.PublicIpId.GetHashCode();
                return hashCode;
            }
        }
    }
}
