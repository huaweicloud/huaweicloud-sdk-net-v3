using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DnsAssignMent 
    {

        /// <summary>
        /// 端口hostname
        /// </summary>
        [JsonProperty("hostname", NullValueHandling = NullValueHandling.Ignore)]
        public string Hostname { get; set; }

        /// <summary>
        /// 端口IP地址
        /// </summary>
        [JsonProperty("ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string IpAddress { get; set; }

        /// <summary>
        /// 端口内网fqdn
        /// </summary>
        [JsonProperty("fqdn", NullValueHandling = NullValueHandling.Ignore)]
        public string Fqdn { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DnsAssignMent {\n");
            sb.Append("  hostname: ").Append(Hostname).Append("\n");
            sb.Append("  ipAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  fqdn: ").Append(Fqdn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DnsAssignMent);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DnsAssignMent input)
        {
            if (input == null) return false;
            if (this.Hostname != input.Hostname || (this.Hostname != null && !this.Hostname.Equals(input.Hostname))) return false;
            if (this.IpAddress != input.IpAddress || (this.IpAddress != null && !this.IpAddress.Equals(input.IpAddress))) return false;
            if (this.Fqdn != input.Fqdn || (this.Fqdn != null && !this.Fqdn.Equals(input.Fqdn))) return false;

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
                if (this.Hostname != null) hashCode = hashCode * 59 + this.Hostname.GetHashCode();
                if (this.IpAddress != null) hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.Fqdn != null) hashCode = hashCode * 59 + this.Fqdn.GetHashCode();
                return hashCode;
            }
        }
    }
}
