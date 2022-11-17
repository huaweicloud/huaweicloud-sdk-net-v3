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
    ///  
    /// </summary>
    public class NovaNetwork 
    {

        /// <summary>
        /// IP地址。
        /// </summary>
        [JsonProperty("addr", NullValueHandling = NullValueHandling.Ignore)]
        public string Addr { get; set; }

        /// <summary>
        /// IP地址类型，值为4或6。  4：IP地址类型是IPv4 6：IP地址类型是IPv6
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public int? Version { get; set; }

        /// <summary>
        /// 扩展属性，MAC地址。
        /// </summary>
        [JsonProperty("OS-EXT-IPS-MAC:mac_addr", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTIPSMACmacAddr { get; set; }

        /// <summary>
        /// 扩展属性，分配IP地址方式。
        /// </summary>
        [JsonProperty("OS-EXT-IPS:type", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTIPStype { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NovaNetwork {\n");
            sb.Append("  addr: ").Append(Addr).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  oSEXTIPSMACmacAddr: ").Append(OSEXTIPSMACmacAddr).Append("\n");
            sb.Append("  oSEXTIPStype: ").Append(OSEXTIPStype).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NovaNetwork);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NovaNetwork input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Addr == input.Addr ||
                    (this.Addr != null &&
                    this.Addr.Equals(input.Addr))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.OSEXTIPSMACmacAddr == input.OSEXTIPSMACmacAddr ||
                    (this.OSEXTIPSMACmacAddr != null &&
                    this.OSEXTIPSMACmacAddr.Equals(input.OSEXTIPSMACmacAddr))
                ) && 
                (
                    this.OSEXTIPStype == input.OSEXTIPStype ||
                    (this.OSEXTIPStype != null &&
                    this.OSEXTIPStype.Equals(input.OSEXTIPStype))
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
                if (this.Addr != null)
                    hashCode = hashCode * 59 + this.Addr.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.OSEXTIPSMACmacAddr != null)
                    hashCode = hashCode * 59 + this.OSEXTIPSMACmacAddr.GetHashCode();
                if (this.OSEXTIPStype != null)
                    hashCode = hashCode * 59 + this.OSEXTIPStype.GetHashCode();
                return hashCode;
            }
        }
    }
}
