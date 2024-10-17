using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 隧道信息
    /// </summary>
    public class TunnelInfo 
    {

        /// <summary>
        /// 隧道ID
        /// </summary>
        [JsonProperty("tunnel_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TunnelId { get; set; }

        /// <summary>
        /// 设备ID
        /// </summary>
        [JsonProperty("device_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceId { get; set; }

        /// <summary>
        /// 隧道创建时间。格式：yyyyMMdd&#39;T&#39;HHmmss&#39;Z&#39;，如20151212T121212Z。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 隧道更新时间。格式：yyyyMMdd&#39;T&#39;HHmmss&#39;Z&#39;，如20151212T121212Z。
        /// </summary>
        [JsonProperty("closed_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ClosedTime { get; set; }

        /// <summary>
        /// 隧道状态 CLOSED | OPEN
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("source_connect_state", NullValueHandling = NullValueHandling.Ignore)]
        public ConnectState SourceConnectState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("device_connect_state", NullValueHandling = NullValueHandling.Ignore)]
        public ConnectState DeviceConnectState { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TunnelInfo {\n");
            sb.Append("  tunnelId: ").Append(TunnelId).Append("\n");
            sb.Append("  deviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  closedTime: ").Append(ClosedTime).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  sourceConnectState: ").Append(SourceConnectState).Append("\n");
            sb.Append("  deviceConnectState: ").Append(DeviceConnectState).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TunnelInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TunnelInfo input)
        {
            if (input == null) return false;
            if (this.TunnelId != input.TunnelId || (this.TunnelId != null && !this.TunnelId.Equals(input.TunnelId))) return false;
            if (this.DeviceId != input.DeviceId || (this.DeviceId != null && !this.DeviceId.Equals(input.DeviceId))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.ClosedTime != input.ClosedTime || (this.ClosedTime != null && !this.ClosedTime.Equals(input.ClosedTime))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.SourceConnectState != input.SourceConnectState || (this.SourceConnectState != null && !this.SourceConnectState.Equals(input.SourceConnectState))) return false;
            if (this.DeviceConnectState != input.DeviceConnectState || (this.DeviceConnectState != null && !this.DeviceConnectState.Equals(input.DeviceConnectState))) return false;

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
                if (this.TunnelId != null) hashCode = hashCode * 59 + this.TunnelId.GetHashCode();
                if (this.DeviceId != null) hashCode = hashCode * 59 + this.DeviceId.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.ClosedTime != null) hashCode = hashCode * 59 + this.ClosedTime.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SourceConnectState != null) hashCode = hashCode * 59 + this.SourceConnectState.GetHashCode();
                if (this.DeviceConnectState != null) hashCode = hashCode * 59 + this.DeviceConnectState.GetHashCode();
                return hashCode;
            }
        }
    }
}
