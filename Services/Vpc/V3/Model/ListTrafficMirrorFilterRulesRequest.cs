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
    /// Request Object
    /// </summary>
    public class ListTrafficMirrorFilterRulesRequest 
    {

        /// <summary>
        /// 使用规则ID过滤或排序
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 使用规则描述过滤
        /// </summary>
        [SDKProperty("description", IsQuery = true)]
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 使用筛选条件ID过滤
        /// </summary>
        [SDKProperty("traffic_mirror_filter_id", IsQuery = true)]
        [JsonProperty("traffic_mirror_filter_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TrafficMirrorFilterId { get; set; }

        /// <summary>
        /// 使用规则方向过滤
        /// </summary>
        [SDKProperty("direction", IsQuery = true)]
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public string Direction { get; set; }

        /// <summary>
        /// 使用规则协议过滤
        /// </summary>
        [SDKProperty("protocol", IsQuery = true)]
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }

        /// <summary>
        /// 使用规则源网段过滤
        /// </summary>
        [SDKProperty("source_cidr_block", IsQuery = true)]
        [JsonProperty("source_cidr_block", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceCidrBlock { get; set; }

        /// <summary>
        /// 使用规则目的网段过滤
        /// </summary>
        [SDKProperty("destination_cidr_block", IsQuery = true)]
        [JsonProperty("destination_cidr_block", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationCidrBlock { get; set; }

        /// <summary>
        /// 使用规则源端口范围过滤
        /// </summary>
        [SDKProperty("source_port_range", IsQuery = true)]
        [JsonProperty("source_port_range", NullValueHandling = NullValueHandling.Ignore)]
        public string SourcePortRange { get; set; }

        /// <summary>
        /// 使用规则目的端口范围过滤
        /// </summary>
        [SDKProperty("destination_port_range", IsQuery = true)]
        [JsonProperty("destination_port_range", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationPortRange { get; set; }

        /// <summary>
        /// 使用规则action过滤
        /// </summary>
        [SDKProperty("action", IsQuery = true)]
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// 使用规则优先级过滤
        /// </summary>
        [SDKProperty("priority", IsQuery = true)]
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public string Priority { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTrafficMirrorFilterRulesRequest {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  trafficMirrorFilterId: ").Append(TrafficMirrorFilterId).Append("\n");
            sb.Append("  direction: ").Append(Direction).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
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
            return this.Equals(input as ListTrafficMirrorFilterRulesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTrafficMirrorFilterRulesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                    this.Direction == input.Direction ||
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && 
                (
                    this.SourceCidrBlock == input.SourceCidrBlock ||
                    (this.SourceCidrBlock != null &&
                    this.SourceCidrBlock.Equals(input.SourceCidrBlock))
                ) && 
                (
                    this.DestinationCidrBlock == input.DestinationCidrBlock ||
                    (this.DestinationCidrBlock != null &&
                    this.DestinationCidrBlock.Equals(input.DestinationCidrBlock))
                ) && 
                (
                    this.SourcePortRange == input.SourcePortRange ||
                    (this.SourcePortRange != null &&
                    this.SourcePortRange.Equals(input.SourcePortRange))
                ) && 
                (
                    this.DestinationPortRange == input.DestinationPortRange ||
                    (this.DestinationPortRange != null &&
                    this.DestinationPortRange.Equals(input.DestinationPortRange))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.TrafficMirrorFilterId != null)
                    hashCode = hashCode * 59 + this.TrafficMirrorFilterId.GetHashCode();
                if (this.Direction != null)
                    hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.SourceCidrBlock != null)
                    hashCode = hashCode * 59 + this.SourceCidrBlock.GetHashCode();
                if (this.DestinationCidrBlock != null)
                    hashCode = hashCode * 59 + this.DestinationCidrBlock.GetHashCode();
                if (this.SourcePortRange != null)
                    hashCode = hashCode * 59 + this.SourcePortRange.GetHashCode();
                if (this.DestinationPortRange != null)
                    hashCode = hashCode * 59 + this.DestinationPortRange.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                return hashCode;
            }
        }
    }
}
