using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Ips 
    {

        /// <summary>
        /// ip id
        /// </summary>
        [JsonProperty("ip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IpId { get; set; }

        /// <summary>
        /// ip
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// 线路
        /// </summary>
        [JsonProperty("isp", NullValueHandling = NullValueHandling.Ignore)]
        public string Isp { get; set; }

        /// <summary>
        /// 数据中心
        /// </summary>
        [JsonProperty("data_center", NullValueHandling = NullValueHandling.Ignore)]
        public string DataCenter { get; set; }

        /// <summary>
        /// 海外区域封禁状态 0-关闭 1-开启
        /// </summary>
        [JsonProperty("foreign_switch_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? ForeignSwitchStatus { get; set; }

        /// <summary>
        /// UDP协议禁用 0-关闭 1-开启
        /// </summary>
        [JsonProperty("udp_switch_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? UdpSwitchStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ips {\n");
            sb.Append("  ipId: ").Append(IpId).Append("\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("  isp: ").Append(Isp).Append("\n");
            sb.Append("  dataCenter: ").Append(DataCenter).Append("\n");
            sb.Append("  foreignSwitchStatus: ").Append(ForeignSwitchStatus).Append("\n");
            sb.Append("  udpSwitchStatus: ").Append(UdpSwitchStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Ips);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Ips input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IpId == input.IpId ||
                    (this.IpId != null &&
                    this.IpId.Equals(input.IpId))
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) && 
                (
                    this.Isp == input.Isp ||
                    (this.Isp != null &&
                    this.Isp.Equals(input.Isp))
                ) && 
                (
                    this.DataCenter == input.DataCenter ||
                    (this.DataCenter != null &&
                    this.DataCenter.Equals(input.DataCenter))
                ) && 
                (
                    this.ForeignSwitchStatus == input.ForeignSwitchStatus ||
                    (this.ForeignSwitchStatus != null &&
                    this.ForeignSwitchStatus.Equals(input.ForeignSwitchStatus))
                ) && 
                (
                    this.UdpSwitchStatus == input.UdpSwitchStatus ||
                    (this.UdpSwitchStatus != null &&
                    this.UdpSwitchStatus.Equals(input.UdpSwitchStatus))
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
                if (this.IpId != null)
                    hashCode = hashCode * 59 + this.IpId.GetHashCode();
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.Isp != null)
                    hashCode = hashCode * 59 + this.Isp.GetHashCode();
                if (this.DataCenter != null)
                    hashCode = hashCode * 59 + this.DataCenter.GetHashCode();
                if (this.ForeignSwitchStatus != null)
                    hashCode = hashCode * 59 + this.ForeignSwitchStatus.GetHashCode();
                if (this.UdpSwitchStatus != null)
                    hashCode = hashCode * 59 + this.UdpSwitchStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
