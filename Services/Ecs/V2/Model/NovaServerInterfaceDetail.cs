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
    public class NovaServerInterfaceDetail 
    {

        /// <summary>
        /// 网卡私网IP信息列表。
        /// </summary>
        [JsonProperty("fixed_ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<NovaServerInterfaceFixedIp> FixedIps { get; set; }

        /// <summary>
        /// 网卡Mac地址信息。
        /// </summary>
        [JsonProperty("mac_addr", NullValueHandling = NullValueHandling.Ignore)]
        public string MacAddr { get; set; }

        /// <summary>
        /// 网卡端口所属网络ID。
        /// </summary>
        [JsonProperty("net_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NetId { get; set; }

        /// <summary>
        /// 网卡端口ID。
        /// </summary>
        [JsonProperty("port_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PortId { get; set; }

        /// <summary>
        /// 网卡端口状态。
        /// </summary>
        [JsonProperty("port_state", NullValueHandling = NullValueHandling.Ignore)]
        public string PortState { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NovaServerInterfaceDetail {\n");
            sb.Append("  fixedIps: ").Append(FixedIps).Append("\n");
            sb.Append("  macAddr: ").Append(MacAddr).Append("\n");
            sb.Append("  netId: ").Append(NetId).Append("\n");
            sb.Append("  portId: ").Append(PortId).Append("\n");
            sb.Append("  portState: ").Append(PortState).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NovaServerInterfaceDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NovaServerInterfaceDetail input)
        {
            if (input == null) return false;
            if (this.FixedIps != input.FixedIps || (this.FixedIps != null && input.FixedIps != null && !this.FixedIps.SequenceEqual(input.FixedIps))) return false;
            if (this.MacAddr != input.MacAddr || (this.MacAddr != null && !this.MacAddr.Equals(input.MacAddr))) return false;
            if (this.NetId != input.NetId || (this.NetId != null && !this.NetId.Equals(input.NetId))) return false;
            if (this.PortId != input.PortId || (this.PortId != null && !this.PortId.Equals(input.PortId))) return false;
            if (this.PortState != input.PortState || (this.PortState != null && !this.PortState.Equals(input.PortState))) return false;

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
                if (this.FixedIps != null) hashCode = hashCode * 59 + this.FixedIps.GetHashCode();
                if (this.MacAddr != null) hashCode = hashCode * 59 + this.MacAddr.GetHashCode();
                if (this.NetId != null) hashCode = hashCode * 59 + this.NetId.GetHashCode();
                if (this.PortId != null) hashCode = hashCode * 59 + this.PortId.GetHashCode();
                if (this.PortState != null) hashCode = hashCode * 59 + this.PortState.GetHashCode();
                return hashCode;
            }
        }
    }
}
