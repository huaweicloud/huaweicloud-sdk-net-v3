using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.AntiDDoS.V1.Model
{
    /// <summary>
    /// ddos状态响应体
    /// </summary>
    public class DDosStatus 
    {

        /// <summary>
        /// EIP的ID
        /// </summary>
        [JsonProperty("floating_ip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FloatingIpId { get; set; }

        /// <summary>
        /// 浮动IP地址
        /// </summary>
        [JsonProperty("floating_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string FloatingIpAddress { get; set; }

        /// <summary>
        /// EIP所属类型，可选范围： - EIP：未绑定到ECS的EIP或绑定到ECS的EIP - ELB：绑定到ELB的EIP
        /// </summary>
        [JsonProperty("network_type", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkType { get; set; }

        /// <summary>
        /// 防护状态，可选范围： - normal：表示正常 - configging：表示设置中 - notConfig：表示未设置 - packetcleaning：表示清洗 - packetdropping：表示黑洞
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 黑洞结束时间
        /// </summary>
        [JsonProperty("blackhole_endtime", NullValueHandling = NullValueHandling.Ignore)]
        public long? BlackholeEndtime { get; set; }

        /// <summary>
        /// 防护类型
        /// </summary>
        [JsonProperty("protect_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ProtectType { get; set; }

        /// <summary>
        /// 流量阈值
        /// </summary>
        [JsonProperty("traffic_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public long? TrafficThreshold { get; set; }

        /// <summary>
        /// http流量阈值
        /// </summary>
        [JsonProperty("http_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public long? HttpThreshold { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DDosStatus {\n");
            sb.Append("  floatingIpId: ").Append(FloatingIpId).Append("\n");
            sb.Append("  floatingIpAddress: ").Append(FloatingIpAddress).Append("\n");
            sb.Append("  networkType: ").Append(NetworkType).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  blackholeEndtime: ").Append(BlackholeEndtime).Append("\n");
            sb.Append("  protectType: ").Append(ProtectType).Append("\n");
            sb.Append("  trafficThreshold: ").Append(TrafficThreshold).Append("\n");
            sb.Append("  httpThreshold: ").Append(HttpThreshold).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DDosStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DDosStatus input)
        {
            if (input == null) return false;
            if (this.FloatingIpId != input.FloatingIpId || (this.FloatingIpId != null && !this.FloatingIpId.Equals(input.FloatingIpId))) return false;
            if (this.FloatingIpAddress != input.FloatingIpAddress || (this.FloatingIpAddress != null && !this.FloatingIpAddress.Equals(input.FloatingIpAddress))) return false;
            if (this.NetworkType != input.NetworkType || (this.NetworkType != null && !this.NetworkType.Equals(input.NetworkType))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.BlackholeEndtime != input.BlackholeEndtime || (this.BlackholeEndtime != null && !this.BlackholeEndtime.Equals(input.BlackholeEndtime))) return false;
            if (this.ProtectType != input.ProtectType || (this.ProtectType != null && !this.ProtectType.Equals(input.ProtectType))) return false;
            if (this.TrafficThreshold != input.TrafficThreshold || (this.TrafficThreshold != null && !this.TrafficThreshold.Equals(input.TrafficThreshold))) return false;
            if (this.HttpThreshold != input.HttpThreshold || (this.HttpThreshold != null && !this.HttpThreshold.Equals(input.HttpThreshold))) return false;

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
                if (this.FloatingIpId != null) hashCode = hashCode * 59 + this.FloatingIpId.GetHashCode();
                if (this.FloatingIpAddress != null) hashCode = hashCode * 59 + this.FloatingIpAddress.GetHashCode();
                if (this.NetworkType != null) hashCode = hashCode * 59 + this.NetworkType.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.BlackholeEndtime != null) hashCode = hashCode * 59 + this.BlackholeEndtime.GetHashCode();
                if (this.ProtectType != null) hashCode = hashCode * 59 + this.ProtectType.GetHashCode();
                if (this.TrafficThreshold != null) hashCode = hashCode * 59 + this.TrafficThreshold.GetHashCode();
                if (this.HttpThreshold != null) hashCode = hashCode * 59 + this.HttpThreshold.GetHashCode();
                return hashCode;
            }
        }
    }
}
