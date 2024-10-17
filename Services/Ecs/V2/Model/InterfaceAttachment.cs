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
    public class InterfaceAttachment 
    {

        /// <summary>
        /// 网卡私网IP信息列表。
        /// </summary>
        [JsonProperty("fixed_ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServerInterfaceFixedIp> FixedIps { get; set; }

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
        /// 卸载网卡时，是否删除网卡。
        /// </summary>
        [JsonProperty("delete_on_termination", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeleteOnTermination { get; set; }

        /// <summary>
        /// 从guest os中，网卡的驱动类型。可选值为virtio和hinic，默认为virtio
        /// </summary>
        [JsonProperty("driver_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string DriverMode { get; set; }

        /// <summary>
        /// 网卡带宽下限。
        /// </summary>
        [JsonProperty("min_rate", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinRate { get; set; }

        /// <summary>
        /// 网卡多队列个数。
        /// </summary>
        [JsonProperty("multiqueue_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? MultiqueueNum { get; set; }

        /// <summary>
        /// 弹性网卡在Linux GuestOS里的BDF号
        /// </summary>
        [JsonProperty("pci_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PciAddress { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InterfaceAttachment {\n");
            sb.Append("  fixedIps: ").Append(FixedIps).Append("\n");
            sb.Append("  macAddr: ").Append(MacAddr).Append("\n");
            sb.Append("  netId: ").Append(NetId).Append("\n");
            sb.Append("  portId: ").Append(PortId).Append("\n");
            sb.Append("  portState: ").Append(PortState).Append("\n");
            sb.Append("  deleteOnTermination: ").Append(DeleteOnTermination).Append("\n");
            sb.Append("  driverMode: ").Append(DriverMode).Append("\n");
            sb.Append("  minRate: ").Append(MinRate).Append("\n");
            sb.Append("  multiqueueNum: ").Append(MultiqueueNum).Append("\n");
            sb.Append("  pciAddress: ").Append(PciAddress).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InterfaceAttachment);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InterfaceAttachment input)
        {
            if (input == null) return false;
            if (this.FixedIps != input.FixedIps || (this.FixedIps != null && input.FixedIps != null && !this.FixedIps.SequenceEqual(input.FixedIps))) return false;
            if (this.MacAddr != input.MacAddr || (this.MacAddr != null && !this.MacAddr.Equals(input.MacAddr))) return false;
            if (this.NetId != input.NetId || (this.NetId != null && !this.NetId.Equals(input.NetId))) return false;
            if (this.PortId != input.PortId || (this.PortId != null && !this.PortId.Equals(input.PortId))) return false;
            if (this.PortState != input.PortState || (this.PortState != null && !this.PortState.Equals(input.PortState))) return false;
            if (this.DeleteOnTermination != input.DeleteOnTermination || (this.DeleteOnTermination != null && !this.DeleteOnTermination.Equals(input.DeleteOnTermination))) return false;
            if (this.DriverMode != input.DriverMode || (this.DriverMode != null && !this.DriverMode.Equals(input.DriverMode))) return false;
            if (this.MinRate != input.MinRate || (this.MinRate != null && !this.MinRate.Equals(input.MinRate))) return false;
            if (this.MultiqueueNum != input.MultiqueueNum || (this.MultiqueueNum != null && !this.MultiqueueNum.Equals(input.MultiqueueNum))) return false;
            if (this.PciAddress != input.PciAddress || (this.PciAddress != null && !this.PciAddress.Equals(input.PciAddress))) return false;

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
                if (this.DeleteOnTermination != null) hashCode = hashCode * 59 + this.DeleteOnTermination.GetHashCode();
                if (this.DriverMode != null) hashCode = hashCode * 59 + this.DriverMode.GetHashCode();
                if (this.MinRate != null) hashCode = hashCode * 59 + this.MinRate.GetHashCode();
                if (this.MultiqueueNum != null) hashCode = hashCode * 59 + this.MultiqueueNum.GetHashCode();
                if (this.PciAddress != null) hashCode = hashCode * 59 + this.PciAddress.GetHashCode();
                return hashCode;
            }
        }
    }
}
