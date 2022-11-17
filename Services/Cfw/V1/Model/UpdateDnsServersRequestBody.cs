using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateDnsServersRequestBody 
    {

        /// <summary>
        /// DNS服务器
        /// </summary>
        [JsonProperty("dns_server", NullValueHandling = NullValueHandling.Ignore)]
        public List<UpdateDnsServersRequestBodyDnsServer> DnsServer { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDnsServersRequestBody {\n");
            sb.Append("  dnsServer: ").Append(DnsServer).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateDnsServersRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateDnsServersRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DnsServer == input.DnsServer ||
                    this.DnsServer != null &&
                    input.DnsServer != null &&
                    this.DnsServer.SequenceEqual(input.DnsServer)
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
                if (this.DnsServer != null)
                    hashCode = hashCode * 59 + this.DnsServer.GetHashCode();
                return hashCode;
            }
        }
    }
}
