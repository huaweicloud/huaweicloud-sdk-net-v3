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
    /// 
    /// </summary>
    public class BindingVifDetails 
    {

        /// <summary>
        /// 参数解释：表示该网卡是否为云服务器的主网卡。取值范围：true，主网卡；false，非主网卡。
        /// </summary>
        [JsonProperty("primary_interface", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PrimaryInterface { get; set; }

        /// <summary>
        /// 参数解释：表示该网络服务提供端口过滤特性，如安全组和反MAC/IP欺骗。取值范围：true，提供端口过滤特性；false，未提供端口过滤特性。
        /// </summary>
        [JsonProperty("port_filter", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PortFilter { get; set; }

        /// <summary>
        /// 参数解释：是否为ovs/bridge混合模式。取值范围：true，ovs/bridge混合模式；false，非ovs/bridge混合模式。
        /// </summary>
        [JsonProperty("ovs_hybrid_plug", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OvsHybridPlug { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BindingVifDetails {\n");
            sb.Append("  primaryInterface: ").Append(PrimaryInterface).Append("\n");
            sb.Append("  portFilter: ").Append(PortFilter).Append("\n");
            sb.Append("  ovsHybridPlug: ").Append(OvsHybridPlug).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BindingVifDetails);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BindingVifDetails input)
        {
            if (input == null) return false;
            if (this.PrimaryInterface != input.PrimaryInterface || (this.PrimaryInterface != null && !this.PrimaryInterface.Equals(input.PrimaryInterface))) return false;
            if (this.PortFilter != input.PortFilter || (this.PortFilter != null && !this.PortFilter.Equals(input.PortFilter))) return false;
            if (this.OvsHybridPlug != input.OvsHybridPlug || (this.OvsHybridPlug != null && !this.OvsHybridPlug.Equals(input.OvsHybridPlug))) return false;

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
                if (this.PrimaryInterface != null) hashCode = hashCode * 59 + this.PrimaryInterface.GetHashCode();
                if (this.PortFilter != null) hashCode = hashCode * 59 + this.PortFilter.GetHashCode();
                if (this.OvsHybridPlug != null) hashCode = hashCode * 59 + this.OvsHybridPlug.GetHashCode();
                return hashCode;
            }
        }
    }
}
