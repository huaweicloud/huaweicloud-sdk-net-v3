using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 容灾监控数据响应体
    /// </summary>
    public class QueryDataGuardMonitorResponse 
    {

        /// <summary>
        /// 带宽。
        /// </summary>
        [JsonProperty("bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public string Bandwidth { get; set; }

        /// <summary>
        /// cpu百分比。
        /// </summary>
        [JsonProperty("cpuUsed_percent", NullValueHandling = NullValueHandling.Ignore)]
        public string CpuUsedPercent { get; set; }

        /// <summary>
        /// 目标库时延。
        /// </summary>
        [JsonProperty("dst_delay", NullValueHandling = NullValueHandling.Ignore)]
        public long? DstDelay { get; set; }

        /// <summary>
        /// 目标io。
        /// </summary>
        [JsonProperty("dst_io", NullValueHandling = NullValueHandling.Ignore)]
        public string DstIo { get; set; }

        /// <summary>
        /// 目标库连接状态。
        /// </summary>
        [JsonProperty("dst_normal", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DstNormal { get; set; }

        /// <summary>
        /// 目标库offSet位点。
        /// </summary>
        [JsonProperty("dst_offset", NullValueHandling = NullValueHandling.Ignore)]
        public string DstOffset { get; set; }

        /// <summary>
        /// 目标rps。
        /// </summary>
        [JsonProperty("dst_rps", NullValueHandling = NullValueHandling.Ignore)]
        public string DstRps { get; set; }

        /// <summary>
        /// 内存使用。
        /// </summary>
        [JsonProperty("mem_used_inMB", NullValueHandling = NullValueHandling.Ignore)]
        public string MemUsedInMB { get; set; }

        /// <summary>
        /// node内存总大小。
        /// </summary>
        [JsonProperty("node_mem_inMB", NullValueHandling = NullValueHandling.Ignore)]
        public long? NodeMemInMB { get; set; }

        /// <summary>
        /// 迁移实例offSet位点。
        /// </summary>
        [JsonProperty("node_offset", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeOffset { get; set; }

        /// <summary>
        /// node磁盘总大小。
        /// </summary>
        [JsonProperty("node_volume_inGB", NullValueHandling = NullValueHandling.Ignore)]
        public long? NodeVolumeInGB { get; set; }

        /// <summary>
        /// 源库时延。
        /// </summary>
        [JsonProperty("sr_delay", NullValueHandling = NullValueHandling.Ignore)]
        public long? SrDelay { get; set; }

        /// <summary>
        /// 源库offSet位点。
        /// </summary>
        [JsonProperty("sr_offset", NullValueHandling = NullValueHandling.Ignore)]
        public string SrOffset { get; set; }

        /// <summary>
        /// 源io。
        /// </summary>
        [JsonProperty("src_io", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcIo { get; set; }

        /// <summary>
        /// 源库连接状态。
        /// </summary>
        [JsonProperty("src_normal", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SrcNormal { get; set; }

        /// <summary>
        /// 源rps。
        /// </summary>
        [JsonProperty("src_rps", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcRps { get; set; }

        /// <summary>
        /// 迁移数据量。
        /// </summary>
        [JsonProperty("trans_inMB", NullValueHandling = NullValueHandling.Ignore)]
        public string TransInMB { get; set; }

        /// <summary>
        /// 迁移数据行数。
        /// </summary>
        [JsonProperty("trans_lines", NullValueHandling = NullValueHandling.Ignore)]
        public string TransLines { get; set; }

        /// <summary>
        /// 磁盘使用。
        /// </summary>
        [JsonProperty("volume_used_inGB", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeUsedInGB { get; set; }

        /// <summary>
        /// 每秒迁移字节大小。
        /// </summary>
        [JsonProperty("migration_bytes_per_second", NullValueHandling = NullValueHandling.Ignore)]
        public long? MigrationBytesPerSecond { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryDataGuardMonitorResponse {\n");
            sb.Append("  bandwidth: ").Append(Bandwidth).Append("\n");
            sb.Append("  cpuUsedPercent: ").Append(CpuUsedPercent).Append("\n");
            sb.Append("  dstDelay: ").Append(DstDelay).Append("\n");
            sb.Append("  dstIo: ").Append(DstIo).Append("\n");
            sb.Append("  dstNormal: ").Append(DstNormal).Append("\n");
            sb.Append("  dstOffset: ").Append(DstOffset).Append("\n");
            sb.Append("  dstRps: ").Append(DstRps).Append("\n");
            sb.Append("  memUsedInMB: ").Append(MemUsedInMB).Append("\n");
            sb.Append("  nodeMemInMB: ").Append(NodeMemInMB).Append("\n");
            sb.Append("  nodeOffset: ").Append(NodeOffset).Append("\n");
            sb.Append("  nodeVolumeInGB: ").Append(NodeVolumeInGB).Append("\n");
            sb.Append("  srDelay: ").Append(SrDelay).Append("\n");
            sb.Append("  srOffset: ").Append(SrOffset).Append("\n");
            sb.Append("  srcIo: ").Append(SrcIo).Append("\n");
            sb.Append("  srcNormal: ").Append(SrcNormal).Append("\n");
            sb.Append("  srcRps: ").Append(SrcRps).Append("\n");
            sb.Append("  transInMB: ").Append(TransInMB).Append("\n");
            sb.Append("  transLines: ").Append(TransLines).Append("\n");
            sb.Append("  volumeUsedInGB: ").Append(VolumeUsedInGB).Append("\n");
            sb.Append("  migrationBytesPerSecond: ").Append(MigrationBytesPerSecond).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryDataGuardMonitorResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryDataGuardMonitorResponse input)
        {
            if (input == null) return false;
            if (this.Bandwidth != input.Bandwidth || (this.Bandwidth != null && !this.Bandwidth.Equals(input.Bandwidth))) return false;
            if (this.CpuUsedPercent != input.CpuUsedPercent || (this.CpuUsedPercent != null && !this.CpuUsedPercent.Equals(input.CpuUsedPercent))) return false;
            if (this.DstDelay != input.DstDelay || (this.DstDelay != null && !this.DstDelay.Equals(input.DstDelay))) return false;
            if (this.DstIo != input.DstIo || (this.DstIo != null && !this.DstIo.Equals(input.DstIo))) return false;
            if (this.DstNormal != input.DstNormal || (this.DstNormal != null && !this.DstNormal.Equals(input.DstNormal))) return false;
            if (this.DstOffset != input.DstOffset || (this.DstOffset != null && !this.DstOffset.Equals(input.DstOffset))) return false;
            if (this.DstRps != input.DstRps || (this.DstRps != null && !this.DstRps.Equals(input.DstRps))) return false;
            if (this.MemUsedInMB != input.MemUsedInMB || (this.MemUsedInMB != null && !this.MemUsedInMB.Equals(input.MemUsedInMB))) return false;
            if (this.NodeMemInMB != input.NodeMemInMB || (this.NodeMemInMB != null && !this.NodeMemInMB.Equals(input.NodeMemInMB))) return false;
            if (this.NodeOffset != input.NodeOffset || (this.NodeOffset != null && !this.NodeOffset.Equals(input.NodeOffset))) return false;
            if (this.NodeVolumeInGB != input.NodeVolumeInGB || (this.NodeVolumeInGB != null && !this.NodeVolumeInGB.Equals(input.NodeVolumeInGB))) return false;
            if (this.SrDelay != input.SrDelay || (this.SrDelay != null && !this.SrDelay.Equals(input.SrDelay))) return false;
            if (this.SrOffset != input.SrOffset || (this.SrOffset != null && !this.SrOffset.Equals(input.SrOffset))) return false;
            if (this.SrcIo != input.SrcIo || (this.SrcIo != null && !this.SrcIo.Equals(input.SrcIo))) return false;
            if (this.SrcNormal != input.SrcNormal || (this.SrcNormal != null && !this.SrcNormal.Equals(input.SrcNormal))) return false;
            if (this.SrcRps != input.SrcRps || (this.SrcRps != null && !this.SrcRps.Equals(input.SrcRps))) return false;
            if (this.TransInMB != input.TransInMB || (this.TransInMB != null && !this.TransInMB.Equals(input.TransInMB))) return false;
            if (this.TransLines != input.TransLines || (this.TransLines != null && !this.TransLines.Equals(input.TransLines))) return false;
            if (this.VolumeUsedInGB != input.VolumeUsedInGB || (this.VolumeUsedInGB != null && !this.VolumeUsedInGB.Equals(input.VolumeUsedInGB))) return false;
            if (this.MigrationBytesPerSecond != input.MigrationBytesPerSecond || (this.MigrationBytesPerSecond != null && !this.MigrationBytesPerSecond.Equals(input.MigrationBytesPerSecond))) return false;

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
                if (this.Bandwidth != null) hashCode = hashCode * 59 + this.Bandwidth.GetHashCode();
                if (this.CpuUsedPercent != null) hashCode = hashCode * 59 + this.CpuUsedPercent.GetHashCode();
                if (this.DstDelay != null) hashCode = hashCode * 59 + this.DstDelay.GetHashCode();
                if (this.DstIo != null) hashCode = hashCode * 59 + this.DstIo.GetHashCode();
                if (this.DstNormal != null) hashCode = hashCode * 59 + this.DstNormal.GetHashCode();
                if (this.DstOffset != null) hashCode = hashCode * 59 + this.DstOffset.GetHashCode();
                if (this.DstRps != null) hashCode = hashCode * 59 + this.DstRps.GetHashCode();
                if (this.MemUsedInMB != null) hashCode = hashCode * 59 + this.MemUsedInMB.GetHashCode();
                if (this.NodeMemInMB != null) hashCode = hashCode * 59 + this.NodeMemInMB.GetHashCode();
                if (this.NodeOffset != null) hashCode = hashCode * 59 + this.NodeOffset.GetHashCode();
                if (this.NodeVolumeInGB != null) hashCode = hashCode * 59 + this.NodeVolumeInGB.GetHashCode();
                if (this.SrDelay != null) hashCode = hashCode * 59 + this.SrDelay.GetHashCode();
                if (this.SrOffset != null) hashCode = hashCode * 59 + this.SrOffset.GetHashCode();
                if (this.SrcIo != null) hashCode = hashCode * 59 + this.SrcIo.GetHashCode();
                if (this.SrcNormal != null) hashCode = hashCode * 59 + this.SrcNormal.GetHashCode();
                if (this.SrcRps != null) hashCode = hashCode * 59 + this.SrcRps.GetHashCode();
                if (this.TransInMB != null) hashCode = hashCode * 59 + this.TransInMB.GetHashCode();
                if (this.TransLines != null) hashCode = hashCode * 59 + this.TransLines.GetHashCode();
                if (this.VolumeUsedInGB != null) hashCode = hashCode * 59 + this.VolumeUsedInGB.GetHashCode();
                if (this.MigrationBytesPerSecond != null) hashCode = hashCode * 59 + this.MigrationBytesPerSecond.GetHashCode();
                return hashCode;
            }
        }
    }
}
