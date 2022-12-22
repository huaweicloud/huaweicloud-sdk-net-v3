using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 弹性云服务器的网络属性。
    /// </summary>
    public class UpdateServerAddress 
    {

        /// <summary>
        /// IP地址版本。  - 4：代表IPv4。 - 6：代表IPv6。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public int? Version { get; set; }

        /// <summary>
        /// IP地址。
        /// </summary>
        [JsonProperty("addr", NullValueHandling = NullValueHandling.Ignore)]
        public string Addr { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateServerAddress {\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  addr: ").Append(Addr).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateServerAddress);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateServerAddress input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Addr == input.Addr ||
                    (this.Addr != null &&
                    this.Addr.Equals(input.Addr))
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
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Addr != null)
                    hashCode = hashCode * 59 + this.Addr.GetHashCode();
                return hashCode;
            }
        }
    }
}
