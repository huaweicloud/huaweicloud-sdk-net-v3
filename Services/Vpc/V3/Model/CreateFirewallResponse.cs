using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateFirewallResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("firewall", NullValueHandling = NullValueHandling.Ignore)]
        public FirewallDetail Firewall { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateFirewallResponse {\n");
            sb.Append("  firewall: ").Append(Firewall).Append("\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateFirewallResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateFirewallResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Firewall == input.Firewall ||
                    (this.Firewall != null &&
                    this.Firewall.Equals(input.Firewall))
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
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
                if (this.Firewall != null)
                    hashCode = hashCode * 59 + this.Firewall.GetHashCode();
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
