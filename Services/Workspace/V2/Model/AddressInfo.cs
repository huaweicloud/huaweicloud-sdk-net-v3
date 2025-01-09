using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AddressInfo 
    {

        /// <summary>
        /// IP地址信息。
        /// </summary>
        [JsonProperty("addr", NullValueHandling = NullValueHandling.Ignore)]
        public string Addr { get; set; }

        /// <summary>
        /// IP地址类型，值为4或6，分别表示IPV4和IPV6。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// MAC地址。
        /// </summary>
        [JsonProperty("OS-EXT-IPS-MAC:mac_addr", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTIPSMACmacAddr { get; set; }

        /// <summary>
        /// IP地址分配方式。 -fixed  私有IP地址。 -floating 浮动IP地址。
        /// </summary>
        [JsonProperty("OS-EXT-IPS:type", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTIPStype { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddressInfo {\n");
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
            return this.Equals(input as AddressInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddressInfo input)
        {
            if (input == null) return false;
            if (this.Addr != input.Addr || (this.Addr != null && !this.Addr.Equals(input.Addr))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.OSEXTIPSMACmacAddr != input.OSEXTIPSMACmacAddr || (this.OSEXTIPSMACmacAddr != null && !this.OSEXTIPSMACmacAddr.Equals(input.OSEXTIPSMACmacAddr))) return false;
            if (this.OSEXTIPStype != input.OSEXTIPStype || (this.OSEXTIPStype != null && !this.OSEXTIPStype.Equals(input.OSEXTIPStype))) return false;

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
                if (this.Addr != null) hashCode = hashCode * 59 + this.Addr.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.OSEXTIPSMACmacAddr != null) hashCode = hashCode * 59 + this.OSEXTIPSMACmacAddr.GetHashCode();
                if (this.OSEXTIPStype != null) hashCode = hashCode * 59 + this.OSEXTIPStype.GetHashCode();
                return hashCode;
            }
        }
    }
}
