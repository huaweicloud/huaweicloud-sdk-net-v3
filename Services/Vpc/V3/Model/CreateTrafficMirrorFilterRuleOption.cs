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
    public class CreateTrafficMirrorFilterRuleOption 
    {

        /// <summary>
        /// 功能说明：端口镜像筛选规则的描述信息 取值范围：0-255个字符，不能包含“&lt;”和“&gt;”
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 功能说明：流量镜像筛选条件ID
        /// </summary>
        [JsonProperty("traffic_mirror_filter_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TrafficMirrorFilterId { get; set; }

        /// <summary>
        /// 功能说明：流量方向 取值范围：     ingress：入方向     egress：出方向
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public string Direction { get; set; }

        /// <summary>
        /// 功能说明：镜像流量的协议类型 取值范围：TCP、UDP、ICMP、ICMPV6、ALL
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }

        /// <summary>
        /// 功能说明：镜像流量的地址协议版本 取值范围：IPv4，IPv6
        /// </summary>
        [JsonProperty("ethertype", NullValueHandling = NullValueHandling.Ignore)]
        public string Ethertype { get; set; }

        /// <summary>
        /// 功能说明：镜像流量的源网段
        /// </summary>
        [JsonProperty("source_cidr_block", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceCidrBlock { get; set; }

        /// <summary>
        /// 功能说明：镜像流量的目的网段
        /// </summary>
        [JsonProperty("destination_cidr_block", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationCidrBlock { get; set; }

        /// <summary>
        /// 功能说明：流量源端口范围 取值范围：1~65535 格式：80-200
        /// </summary>
        [JsonProperty("source_port_range", NullValueHandling = NullValueHandling.Ignore)]
        public string SourcePortRange { get; set; }

        /// <summary>
        /// 功能说明：流量目的端口范围 取值范围：1~65535 格式：80-200
        /// </summary>
        [JsonProperty("destination_port_range", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationPortRange { get; set; }

        /// <summary>
        /// 功能说明：镜像策略 取值范围：accept（采集）、reject（不采集）
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// 功能说明：镜像规则优先级 取值范围：1~65535，数字越小，优先级越高
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTrafficMirrorFilterRuleOption {\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  trafficMirrorFilterId: ").Append(TrafficMirrorFilterId).Append("\n");
            sb.Append("  direction: ").Append(Direction).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  ethertype: ").Append(Ethertype).Append("\n");
            sb.Append("  sourceCidrBlock: ").Append(SourceCidrBlock).Append("\n");
            sb.Append("  destinationCidrBlock: ").Append(DestinationCidrBlock).Append("\n");
            sb.Append("  sourcePortRange: ").Append(SourcePortRange).Append("\n");
            sb.Append("  destinationPortRange: ").Append(DestinationPortRange).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTrafficMirrorFilterRuleOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTrafficMirrorFilterRuleOption input)
        {
            if (input == null) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.TrafficMirrorFilterId != input.TrafficMirrorFilterId || (this.TrafficMirrorFilterId != null && !this.TrafficMirrorFilterId.Equals(input.TrafficMirrorFilterId))) return false;
            if (this.Direction != input.Direction || (this.Direction != null && !this.Direction.Equals(input.Direction))) return false;
            if (this.Protocol != input.Protocol || (this.Protocol != null && !this.Protocol.Equals(input.Protocol))) return false;
            if (this.Ethertype != input.Ethertype || (this.Ethertype != null && !this.Ethertype.Equals(input.Ethertype))) return false;
            if (this.SourceCidrBlock != input.SourceCidrBlock || (this.SourceCidrBlock != null && !this.SourceCidrBlock.Equals(input.SourceCidrBlock))) return false;
            if (this.DestinationCidrBlock != input.DestinationCidrBlock || (this.DestinationCidrBlock != null && !this.DestinationCidrBlock.Equals(input.DestinationCidrBlock))) return false;
            if (this.SourcePortRange != input.SourcePortRange || (this.SourcePortRange != null && !this.SourcePortRange.Equals(input.SourcePortRange))) return false;
            if (this.DestinationPortRange != input.DestinationPortRange || (this.DestinationPortRange != null && !this.DestinationPortRange.Equals(input.DestinationPortRange))) return false;
            if (this.Action != input.Action || (this.Action != null && !this.Action.Equals(input.Action))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;

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
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.TrafficMirrorFilterId != null) hashCode = hashCode * 59 + this.TrafficMirrorFilterId.GetHashCode();
                if (this.Direction != null) hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.Protocol != null) hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.Ethertype != null) hashCode = hashCode * 59 + this.Ethertype.GetHashCode();
                if (this.SourceCidrBlock != null) hashCode = hashCode * 59 + this.SourceCidrBlock.GetHashCode();
                if (this.DestinationCidrBlock != null) hashCode = hashCode * 59 + this.DestinationCidrBlock.GetHashCode();
                if (this.SourcePortRange != null) hashCode = hashCode * 59 + this.SourcePortRange.GetHashCode();
                if (this.DestinationPortRange != null) hashCode = hashCode * 59 + this.DestinationPortRange.GetHashCode();
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                return hashCode;
            }
        }
    }
}
