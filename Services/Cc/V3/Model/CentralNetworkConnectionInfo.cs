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
    /// 
    /// </summary>
    public class CentralNetworkConnectionInfo 
    {

        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 中心网络平面ID。
        /// </summary>
        [JsonProperty("plane_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PlaneId { get; set; }

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
        /// 
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public CentralNetworkConnectionStateEnum State { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CentralNetworkConnectionInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  planeId: ").Append(PlaneId).Append("\n");
            sb.Append("  globalConnectionBandwidthId: ").Append(GlobalConnectionBandwidthId).Append("\n");
            sb.Append("  bandwidthSize: ").Append(BandwidthSize).Append("\n");
            sb.Append("  connectionType: ").Append(ConnectionType).Append("\n");
            sb.Append("  connectionPointPair: ").Append(ConnectionPointPair).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CentralNetworkConnectionInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CentralNetworkConnectionInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.PlaneId != input.PlaneId || (this.PlaneId != null && !this.PlaneId.Equals(input.PlaneId))) return false;
            if (this.GlobalConnectionBandwidthId != input.GlobalConnectionBandwidthId || (this.GlobalConnectionBandwidthId != null && !this.GlobalConnectionBandwidthId.Equals(input.GlobalConnectionBandwidthId))) return false;
            if (this.BandwidthSize != input.BandwidthSize || (this.BandwidthSize != null && !this.BandwidthSize.Equals(input.BandwidthSize))) return false;
            if (this.ConnectionType != input.ConnectionType) return false;
            if (this.ConnectionPointPair != input.ConnectionPointPair || (this.ConnectionPointPair != null && input.ConnectionPointPair != null && !this.ConnectionPointPair.SequenceEqual(input.ConnectionPointPair))) return false;
            if (this.State != input.State) return false;

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
                if (this.PlaneId != null) hashCode = hashCode * 59 + this.PlaneId.GetHashCode();
                if (this.GlobalConnectionBandwidthId != null) hashCode = hashCode * 59 + this.GlobalConnectionBandwidthId.GetHashCode();
                if (this.BandwidthSize != null) hashCode = hashCode * 59 + this.BandwidthSize.GetHashCode();
                hashCode = hashCode * 59 + this.ConnectionType.GetHashCode();
                if (this.ConnectionPointPair != null) hashCode = hashCode * 59 + this.ConnectionPointPair.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                return hashCode;
            }
        }
    }
}
