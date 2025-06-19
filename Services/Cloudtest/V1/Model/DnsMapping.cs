using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// DNS配置结果集
    /// </summary>
    public class DnsMapping 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dns", NullValueHandling = NullValueHandling.Ignore)]
        public List<DnsMappingNode> Dns { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DnsMapping {\n");
            sb.Append("  dns: ").Append(Dns).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DnsMapping);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DnsMapping input)
        {
            if (input == null) return false;
            if (this.Dns != input.Dns || (this.Dns != null && input.Dns != null && !this.Dns.SequenceEqual(input.Dns))) return false;

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
                if (this.Dns != null) hashCode = hashCode * 59 + this.Dns.GetHashCode();
                return hashCode;
            }
        }
    }
}
