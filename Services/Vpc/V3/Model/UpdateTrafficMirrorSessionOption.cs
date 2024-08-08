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
    public class UpdateTrafficMirrorSessionOption 
    {

        /// <summary>
        /// 功能说明：流量镜像会话名称 取值范围：1-64个字符，支持数字、字母、中文、_(下划线)、-（中划线）、.（点）
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 功能说明：流量镜像会话的描述信息 取值范围：0-255个字符，不能包含“&lt;”和“&gt;”
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 功能说明：流量镜像筛选条件ID
        /// </summary>
        [JsonProperty("traffic_mirror_filter_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TrafficMirrorFilterId { get; set; }

        /// <summary>
        /// 功能说明：镜像目标ID
        /// </summary>
        [JsonProperty("traffic_mirror_target_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TrafficMirrorTargetId { get; set; }

        /// <summary>
        /// 功能说明：镜像目的类型 取值范围：     eni：弹性网卡     elb：私网弹性负载均衡
        /// </summary>
        [JsonProperty("traffic_mirror_target_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TrafficMirrorTargetType { get; set; }

        /// <summary>
        /// 功能说明：指定VNI，用于在镜像目的区分不同会话的镜像流量 取值范围：0~16777215
        /// </summary>
        [JsonProperty("virtual_network_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? VirtualNetworkId { get; set; }

        /// <summary>
        /// 功能说明：最大传输单元MTU 取值范围：1~1460
        /// </summary>
        [JsonProperty("packet_length", NullValueHandling = NullValueHandling.Ignore)]
        public int? PacketLength { get; set; }

        /// <summary>
        /// 功能说明：会话优先级 取值范围：1~32766
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// 功能说明：是否开启会话 取值范围：true、false
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public string Enabled { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTrafficMirrorSessionOption {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  trafficMirrorFilterId: ").Append(TrafficMirrorFilterId).Append("\n");
            sb.Append("  trafficMirrorTargetId: ").Append(TrafficMirrorTargetId).Append("\n");
            sb.Append("  trafficMirrorTargetType: ").Append(TrafficMirrorTargetType).Append("\n");
            sb.Append("  virtualNetworkId: ").Append(VirtualNetworkId).Append("\n");
            sb.Append("  packetLength: ").Append(PacketLength).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateTrafficMirrorSessionOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateTrafficMirrorSessionOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.TrafficMirrorFilterId == input.TrafficMirrorFilterId ||
                    (this.TrafficMirrorFilterId != null &&
                    this.TrafficMirrorFilterId.Equals(input.TrafficMirrorFilterId))
                ) && 
                (
                    this.TrafficMirrorTargetId == input.TrafficMirrorTargetId ||
                    (this.TrafficMirrorTargetId != null &&
                    this.TrafficMirrorTargetId.Equals(input.TrafficMirrorTargetId))
                ) && 
                (
                    this.TrafficMirrorTargetType == input.TrafficMirrorTargetType ||
                    (this.TrafficMirrorTargetType != null &&
                    this.TrafficMirrorTargetType.Equals(input.TrafficMirrorTargetType))
                ) && 
                (
                    this.VirtualNetworkId == input.VirtualNetworkId ||
                    (this.VirtualNetworkId != null &&
                    this.VirtualNetworkId.Equals(input.VirtualNetworkId))
                ) && 
                (
                    this.PacketLength == input.PacketLength ||
                    (this.PacketLength != null &&
                    this.PacketLength.Equals(input.PacketLength))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.TrafficMirrorFilterId != null)
                    hashCode = hashCode * 59 + this.TrafficMirrorFilterId.GetHashCode();
                if (this.TrafficMirrorTargetId != null)
                    hashCode = hashCode * 59 + this.TrafficMirrorTargetId.GetHashCode();
                if (this.TrafficMirrorTargetType != null)
                    hashCode = hashCode * 59 + this.TrafficMirrorTargetType.GetHashCode();
                if (this.VirtualNetworkId != null)
                    hashCode = hashCode * 59 + this.VirtualNetworkId.GetHashCode();
                if (this.PacketLength != null)
                    hashCode = hashCode * 59 + this.PacketLength.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                return hashCode;
            }
        }
    }
}
