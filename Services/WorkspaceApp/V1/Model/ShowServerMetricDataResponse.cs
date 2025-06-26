using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowServerMetricDataResponse : SdkResponse
    {

        /// <summary>
        /// cpu使用率信息。
        /// </summary>
        [JsonProperty("cpu_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataPoints> CpuInfo { get; set; }

        /// <summary>
        /// 内存使用率信息。
        /// </summary>
        [JsonProperty("memory_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataPoints> MemoryInfo { get; set; }

        /// <summary>
        /// 磁盘使用率。
        /// </summary>
        [JsonProperty("disk_util_inband", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataPoints> DiskUtilInband { get; set; }

        /// <summary>
        /// 磁盘读带宽。
        /// </summary>
        [JsonProperty("disk_read_bytes_rate", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataPoints> DiskReadBytesRate { get; set; }

        /// <summary>
        /// 磁盘写带宽。
        /// </summary>
        [JsonProperty("disk_write_bytes_rate", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataPoints> DiskWriteBytesRate { get; set; }

        /// <summary>
        /// 磁盘读IOPS。
        /// </summary>
        [JsonProperty("disk_read_requests_rate", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataPoints> DiskReadRequestsRate { get; set; }

        /// <summary>
        /// 磁盘写IOPS。
        /// </summary>
        [JsonProperty("disk_write_requests_rate", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataPoints> DiskWriteRequestsRate { get; set; }

        /// <summary>
        /// 带内网络流入速率。
        /// </summary>
        [JsonProperty("network_incoming_bytes_rate_inband", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataPoints> NetworkIncomingBytesRateInband { get; set; }

        /// <summary>
        /// 带内网络流出速率。
        /// </summary>
        [JsonProperty("network_outgoing_bytes_rate_inband", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataPoints> NetworkOutgoingBytesRateInband { get; set; }

        /// <summary>
        /// 带外网络流入速率。
        /// </summary>
        [JsonProperty("network_incoming_bytes_aggregate_rate", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataPoints> NetworkIncomingBytesAggregateRate { get; set; }

        /// <summary>
        /// 带外网络流出速率。
        /// </summary>
        [JsonProperty("network_outgoing_bytes_aggregate_rate", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataPoints> NetworkOutgoingBytesAggregateRate { get; set; }

        /// <summary>
        /// 网络连接数。
        /// </summary>
        [JsonProperty("network_vm_connections", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataPoints> NetworkVmConnections { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowServerMetricDataResponse {\n");
            sb.Append("  cpuInfo: ").Append(CpuInfo).Append("\n");
            sb.Append("  memoryInfo: ").Append(MemoryInfo).Append("\n");
            sb.Append("  diskUtilInband: ").Append(DiskUtilInband).Append("\n");
            sb.Append("  diskReadBytesRate: ").Append(DiskReadBytesRate).Append("\n");
            sb.Append("  diskWriteBytesRate: ").Append(DiskWriteBytesRate).Append("\n");
            sb.Append("  diskReadRequestsRate: ").Append(DiskReadRequestsRate).Append("\n");
            sb.Append("  diskWriteRequestsRate: ").Append(DiskWriteRequestsRate).Append("\n");
            sb.Append("  networkIncomingBytesRateInband: ").Append(NetworkIncomingBytesRateInband).Append("\n");
            sb.Append("  networkOutgoingBytesRateInband: ").Append(NetworkOutgoingBytesRateInband).Append("\n");
            sb.Append("  networkIncomingBytesAggregateRate: ").Append(NetworkIncomingBytesAggregateRate).Append("\n");
            sb.Append("  networkOutgoingBytesAggregateRate: ").Append(NetworkOutgoingBytesAggregateRate).Append("\n");
            sb.Append("  networkVmConnections: ").Append(NetworkVmConnections).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowServerMetricDataResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowServerMetricDataResponse input)
        {
            if (input == null) return false;
            if (this.CpuInfo != input.CpuInfo || (this.CpuInfo != null && input.CpuInfo != null && !this.CpuInfo.SequenceEqual(input.CpuInfo))) return false;
            if (this.MemoryInfo != input.MemoryInfo || (this.MemoryInfo != null && input.MemoryInfo != null && !this.MemoryInfo.SequenceEqual(input.MemoryInfo))) return false;
            if (this.DiskUtilInband != input.DiskUtilInband || (this.DiskUtilInband != null && input.DiskUtilInband != null && !this.DiskUtilInband.SequenceEqual(input.DiskUtilInband))) return false;
            if (this.DiskReadBytesRate != input.DiskReadBytesRate || (this.DiskReadBytesRate != null && input.DiskReadBytesRate != null && !this.DiskReadBytesRate.SequenceEqual(input.DiskReadBytesRate))) return false;
            if (this.DiskWriteBytesRate != input.DiskWriteBytesRate || (this.DiskWriteBytesRate != null && input.DiskWriteBytesRate != null && !this.DiskWriteBytesRate.SequenceEqual(input.DiskWriteBytesRate))) return false;
            if (this.DiskReadRequestsRate != input.DiskReadRequestsRate || (this.DiskReadRequestsRate != null && input.DiskReadRequestsRate != null && !this.DiskReadRequestsRate.SequenceEqual(input.DiskReadRequestsRate))) return false;
            if (this.DiskWriteRequestsRate != input.DiskWriteRequestsRate || (this.DiskWriteRequestsRate != null && input.DiskWriteRequestsRate != null && !this.DiskWriteRequestsRate.SequenceEqual(input.DiskWriteRequestsRate))) return false;
            if (this.NetworkIncomingBytesRateInband != input.NetworkIncomingBytesRateInband || (this.NetworkIncomingBytesRateInband != null && input.NetworkIncomingBytesRateInband != null && !this.NetworkIncomingBytesRateInband.SequenceEqual(input.NetworkIncomingBytesRateInband))) return false;
            if (this.NetworkOutgoingBytesRateInband != input.NetworkOutgoingBytesRateInband || (this.NetworkOutgoingBytesRateInband != null && input.NetworkOutgoingBytesRateInband != null && !this.NetworkOutgoingBytesRateInband.SequenceEqual(input.NetworkOutgoingBytesRateInband))) return false;
            if (this.NetworkIncomingBytesAggregateRate != input.NetworkIncomingBytesAggregateRate || (this.NetworkIncomingBytesAggregateRate != null && input.NetworkIncomingBytesAggregateRate != null && !this.NetworkIncomingBytesAggregateRate.SequenceEqual(input.NetworkIncomingBytesAggregateRate))) return false;
            if (this.NetworkOutgoingBytesAggregateRate != input.NetworkOutgoingBytesAggregateRate || (this.NetworkOutgoingBytesAggregateRate != null && input.NetworkOutgoingBytesAggregateRate != null && !this.NetworkOutgoingBytesAggregateRate.SequenceEqual(input.NetworkOutgoingBytesAggregateRate))) return false;
            if (this.NetworkVmConnections != input.NetworkVmConnections || (this.NetworkVmConnections != null && input.NetworkVmConnections != null && !this.NetworkVmConnections.SequenceEqual(input.NetworkVmConnections))) return false;

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
                if (this.CpuInfo != null) hashCode = hashCode * 59 + this.CpuInfo.GetHashCode();
                if (this.MemoryInfo != null) hashCode = hashCode * 59 + this.MemoryInfo.GetHashCode();
                if (this.DiskUtilInband != null) hashCode = hashCode * 59 + this.DiskUtilInband.GetHashCode();
                if (this.DiskReadBytesRate != null) hashCode = hashCode * 59 + this.DiskReadBytesRate.GetHashCode();
                if (this.DiskWriteBytesRate != null) hashCode = hashCode * 59 + this.DiskWriteBytesRate.GetHashCode();
                if (this.DiskReadRequestsRate != null) hashCode = hashCode * 59 + this.DiskReadRequestsRate.GetHashCode();
                if (this.DiskWriteRequestsRate != null) hashCode = hashCode * 59 + this.DiskWriteRequestsRate.GetHashCode();
                if (this.NetworkIncomingBytesRateInband != null) hashCode = hashCode * 59 + this.NetworkIncomingBytesRateInband.GetHashCode();
                if (this.NetworkOutgoingBytesRateInband != null) hashCode = hashCode * 59 + this.NetworkOutgoingBytesRateInband.GetHashCode();
                if (this.NetworkIncomingBytesAggregateRate != null) hashCode = hashCode * 59 + this.NetworkIncomingBytesAggregateRate.GetHashCode();
                if (this.NetworkOutgoingBytesAggregateRate != null) hashCode = hashCode * 59 + this.NetworkOutgoingBytesAggregateRate.GetHashCode();
                if (this.NetworkVmConnections != null) hashCode = hashCode * 59 + this.NetworkVmConnections.GetHashCode();
                return hashCode;
            }
        }
    }
}
