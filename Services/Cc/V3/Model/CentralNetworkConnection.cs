using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 中心网络连接。
    /// </summary>
    public class CentralNetworkConnection 
    {

        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 实例描述。不支持 &lt;&gt;。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 实例所属账号ID。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 实例所属企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 中心网络ID。
        /// </summary>
        [JsonProperty("central_network_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CentralNetworkId { get; set; }

        /// <summary>
        /// 中心网络平面ID。
        /// </summary>
        [JsonProperty("central_network_plane_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CentralNetworkPlaneId { get; set; }

        /// <summary>
        /// 全域互联带宽ID。
        /// </summary>
        [JsonProperty("global_connection_bandwidth_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GlobalConnectionBandwidthId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bandwidth_type", NullValueHandling = NullValueHandling.Ignore)]
        public BandwidthTypeEnum BandwidthType { get; set; }
        /// <summary>
        /// 带宽值，单位Mbps。
        /// </summary>
        [JsonProperty("bandwidth_size", NullValueHandling = NullValueHandling.Ignore)]
        public long? BandwidthSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public CentralNetworkConnectionStateEnum State { get; set; }
        /// <summary>
        /// 是否冻结。
        /// </summary>
        [JsonProperty("is_frozen", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFrozen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("connection_type", NullValueHandling = NullValueHandling.Ignore)]
        public ConnectionTypeEnum ConnectionType { get; set; }
        /// <summary>
        /// 中心网络连接的两个端点定义，长度固定为2的数组。
        /// </summary>
        [JsonProperty("connection_point_pair", NullValueHandling = NullValueHandling.Ignore)]
        public List<ConnectionPoint> ConnectionPointPair { get; set; }

        /// <summary>
        /// 实例创建时间。UTC时间格式，yyyy-MM-ddTHH:mm:ss。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 实例更新时间。UTC时间格式，yyyy-MM-ddTHH:mm:ss。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CentralNetworkConnection {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  centralNetworkId: ").Append(CentralNetworkId).Append("\n");
            sb.Append("  centralNetworkPlaneId: ").Append(CentralNetworkPlaneId).Append("\n");
            sb.Append("  globalConnectionBandwidthId: ").Append(GlobalConnectionBandwidthId).Append("\n");
            sb.Append("  bandwidthType: ").Append(BandwidthType).Append("\n");
            sb.Append("  bandwidthSize: ").Append(BandwidthSize).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  isFrozen: ").Append(IsFrozen).Append("\n");
            sb.Append("  connectionType: ").Append(ConnectionType).Append("\n");
            sb.Append("  connectionPointPair: ").Append(ConnectionPointPair).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CentralNetworkConnection);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CentralNetworkConnection input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.CentralNetworkId != input.CentralNetworkId || (this.CentralNetworkId != null && !this.CentralNetworkId.Equals(input.CentralNetworkId))) return false;
            if (this.CentralNetworkPlaneId != input.CentralNetworkPlaneId || (this.CentralNetworkPlaneId != null && !this.CentralNetworkPlaneId.Equals(input.CentralNetworkPlaneId))) return false;
            if (this.GlobalConnectionBandwidthId != input.GlobalConnectionBandwidthId || (this.GlobalConnectionBandwidthId != null && !this.GlobalConnectionBandwidthId.Equals(input.GlobalConnectionBandwidthId))) return false;
            if (this.BandwidthType != input.BandwidthType) return false;
            if (this.BandwidthSize != input.BandwidthSize || (this.BandwidthSize != null && !this.BandwidthSize.Equals(input.BandwidthSize))) return false;
            if (this.State != input.State) return false;
            if (this.IsFrozen != input.IsFrozen || (this.IsFrozen != null && !this.IsFrozen.Equals(input.IsFrozen))) return false;
            if (this.ConnectionType != input.ConnectionType) return false;
            if (this.ConnectionPointPair != input.ConnectionPointPair || (this.ConnectionPointPair != null && input.ConnectionPointPair != null && !this.ConnectionPointPair.SequenceEqual(input.ConnectionPointPair))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.CentralNetworkId != null) hashCode = hashCode * 59 + this.CentralNetworkId.GetHashCode();
                if (this.CentralNetworkPlaneId != null) hashCode = hashCode * 59 + this.CentralNetworkPlaneId.GetHashCode();
                if (this.GlobalConnectionBandwidthId != null) hashCode = hashCode * 59 + this.GlobalConnectionBandwidthId.GetHashCode();
                hashCode = hashCode * 59 + this.BandwidthType.GetHashCode();
                if (this.BandwidthSize != null) hashCode = hashCode * 59 + this.BandwidthSize.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.IsFrozen != null) hashCode = hashCode * 59 + this.IsFrozen.GetHashCode();
                hashCode = hashCode * 59 + this.ConnectionType.GetHashCode();
                if (this.ConnectionPointPair != null) hashCode = hashCode * 59 + this.ConnectionPointPair.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
