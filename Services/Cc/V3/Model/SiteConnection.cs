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
    /// 分支连接。
    /// </summary>
    public class SiteConnection 
    {

        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 分支网络ID。
        /// </summary>
        [JsonProperty("site_network_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SiteNetworkId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public SiteConnectionStateEnum State { get; set; }
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
        /// 分支网络连接的两个端点定义，长度固定为2的数组。
        /// </summary>
        [JsonProperty("edge_pair", NullValueHandling = NullValueHandling.Ignore)]
        public List<DirectedEdge> EdgePair { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cross_region_type", NullValueHandling = NullValueHandling.Ignore)]
        public CrossRegionTypeEnum CrossRegionType { get; set; }
        /// <summary>
        /// 全域互联带宽ID。
        /// </summary>
        [JsonProperty("global_connection_bandwidth_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GlobalConnectionBandwidthId { get; set; }

        /// <summary>
        /// 带宽值，单位Mbps。
        /// </summary>
        [JsonProperty("bandwidth_size", NullValueHandling = NullValueHandling.Ignore)]
        public long? BandwidthSize { get; set; }

        /// <summary>
        /// 是否冻结。
        /// </summary>
        [JsonProperty("is_frozen", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFrozen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("frozen_effect", NullValueHandling = NullValueHandling.Ignore)]
        public FrozenEffectEnum FrozenEffect { get; set; }
        /// <summary>
        /// 是否绑定带宽包。
        /// </summary>
        [JsonProperty("is_bind_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBindBandwidth { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SiteConnection {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  siteNetworkId: ").Append(SiteNetworkId).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  edgePair: ").Append(EdgePair).Append("\n");
            sb.Append("  crossRegionType: ").Append(CrossRegionType).Append("\n");
            sb.Append("  globalConnectionBandwidthId: ").Append(GlobalConnectionBandwidthId).Append("\n");
            sb.Append("  bandwidthSize: ").Append(BandwidthSize).Append("\n");
            sb.Append("  isFrozen: ").Append(IsFrozen).Append("\n");
            sb.Append("  frozenEffect: ").Append(FrozenEffect).Append("\n");
            sb.Append("  isBindBandwidth: ").Append(IsBindBandwidth).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SiteConnection);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SiteConnection input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.SiteNetworkId != input.SiteNetworkId || (this.SiteNetworkId != null && !this.SiteNetworkId.Equals(input.SiteNetworkId))) return false;
            if (this.State != input.State) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.EdgePair != input.EdgePair || (this.EdgePair != null && input.EdgePair != null && !this.EdgePair.SequenceEqual(input.EdgePair))) return false;
            if (this.CrossRegionType != input.CrossRegionType) return false;
            if (this.GlobalConnectionBandwidthId != input.GlobalConnectionBandwidthId || (this.GlobalConnectionBandwidthId != null && !this.GlobalConnectionBandwidthId.Equals(input.GlobalConnectionBandwidthId))) return false;
            if (this.BandwidthSize != input.BandwidthSize || (this.BandwidthSize != null && !this.BandwidthSize.Equals(input.BandwidthSize))) return false;
            if (this.IsFrozen != input.IsFrozen || (this.IsFrozen != null && !this.IsFrozen.Equals(input.IsFrozen))) return false;
            if (this.FrozenEffect != input.FrozenEffect) return false;
            if (this.IsBindBandwidth != input.IsBindBandwidth || (this.IsBindBandwidth != null && !this.IsBindBandwidth.Equals(input.IsBindBandwidth))) return false;

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
                if (this.SiteNetworkId != null) hashCode = hashCode * 59 + this.SiteNetworkId.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.EdgePair != null) hashCode = hashCode * 59 + this.EdgePair.GetHashCode();
                hashCode = hashCode * 59 + this.CrossRegionType.GetHashCode();
                if (this.GlobalConnectionBandwidthId != null) hashCode = hashCode * 59 + this.GlobalConnectionBandwidthId.GetHashCode();
                if (this.BandwidthSize != null) hashCode = hashCode * 59 + this.BandwidthSize.GetHashCode();
                if (this.IsFrozen != null) hashCode = hashCode * 59 + this.IsFrozen.GetHashCode();
                hashCode = hashCode * 59 + this.FrozenEffect.GetHashCode();
                if (this.IsBindBandwidth != null) hashCode = hashCode * 59 + this.IsBindBandwidth.GetHashCode();
                return hashCode;
            }
        }
    }
}
