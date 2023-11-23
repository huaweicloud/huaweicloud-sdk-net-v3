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
    public class ListTrafficMirrorSessionsRequest 
    {

        /// <summary>
        /// 使用镜像会话ID过滤或排序
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 使用镜像会话名称过滤或排序
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 使用镜像会话描述过滤
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
        /// 使用镜像目的ID过滤
        /// </summary>
        [SDKProperty("traffic_mirror_target_id", IsQuery = true)]
        [JsonProperty("traffic_mirror_target_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TrafficMirrorTargetId { get; set; }

        /// <summary>
        /// 使用镜像目的类型过滤
        /// </summary>
        [SDKProperty("traffic_mirror_target_type", IsQuery = true)]
        [JsonProperty("traffic_mirror_target_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TrafficMirrorTargetType { get; set; }

        /// <summary>
        /// 使用VNI过滤
        /// </summary>
        [SDKProperty("virtual_network_id", IsQuery = true)]
        [JsonProperty("virtual_network_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VirtualNetworkId { get; set; }

        /// <summary>
        /// 使用最大传输单元MTU过滤
        /// </summary>
        [SDKProperty("packet_length", IsQuery = true)]
        [JsonProperty("packet_length", NullValueHandling = NullValueHandling.Ignore)]
        public string PacketLength { get; set; }

        /// <summary>
        /// 使用镜像会话优先级过滤
        /// </summary>
        [SDKProperty("priority", IsQuery = true)]
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public string Priority { get; set; }

        /// <summary>
        /// 使用enabled过滤
        /// </summary>
        [SDKProperty("enabled", IsQuery = true)]
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public string Enabled { get; set; }

        /// <summary>
        /// 使用镜像源类型过滤
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 使用创建时间戳排序
        /// </summary>
        [SDKProperty("created_at", IsQuery = true)]
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 使用更新时间戳排序
        /// </summary>
        [SDKProperty("updated_at", IsQuery = true)]
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 功能说明：每页返回的个数 取值范围：0-2000
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 分页查询起始的资源ID，为空时查询第一页
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTrafficMirrorSessionsRequest {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  trafficMirrorFilterId: ").Append(TrafficMirrorFilterId).Append("\n");
            sb.Append("  trafficMirrorTargetId: ").Append(TrafficMirrorTargetId).Append("\n");
            sb.Append("  trafficMirrorTargetType: ").Append(TrafficMirrorTargetType).Append("\n");
            sb.Append("  virtualNetworkId: ").Append(VirtualNetworkId).Append("\n");
            sb.Append("  packetLength: ").Append(PacketLength).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTrafficMirrorSessionsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTrafficMirrorSessionsRequest input)
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
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                return hashCode;
            }
        }
    }
}
