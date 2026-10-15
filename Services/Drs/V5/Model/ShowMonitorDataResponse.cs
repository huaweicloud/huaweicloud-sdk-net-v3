using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowMonitorDataResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  EIP带宽，用于评估公网传输速率是否满足迁移需求。单位：MB/s。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public string Bandwidth { get; set; }

        /// <summary>
        /// **参数解释**：  源库连接状态是否正常。  **约束限制**：  不涉及。  **取值范围**：  - true：源库连接正常 - false：源库连接异常  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("is_src_normal", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSrcNormal { get; set; }

        /// <summary>
        /// **参数解释**：  目标库连接状态是否正常。  **约束限制**：  不涉及。  **取值范围**：  - true：目标库连接正常 - false：目标库连接异常  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("is_dst_normal", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDstNormal { get; set; }

        /// <summary>
        /// **参数解释**：  源库offset位点，用于判断源库数据同步进度。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("src_offset", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcOffset { get; set; }

        /// <summary>
        /// **参数解释**：  迁移实例offset位点，用于判断迁移实例数据同步进度。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("node_offset", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeOffset { get; set; }

        /// <summary>
        /// **参数解释**：  目标库offset位点，用于判断目标库数据同步进度。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("dst_offset", NullValueHandling = NullValueHandling.Ignore)]
        public string DstOffset { get; set; }

        /// <summary>
        /// **参数解释**：  源库时延，用于判断数据同步的实时性。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("src_delay", NullValueHandling = NullValueHandling.Ignore)]
        public int? SrcDelay { get; set; }

        /// <summary>
        /// **参数解释**：  目标库时延，用于判断数据同步的实时性。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("dst_delay", NullValueHandling = NullValueHandling.Ignore)]
        public int? DstDelay { get; set; }

        /// <summary>
        /// **参数解释**：  源库RPS（Requests Per Second，每秒请求数），用于评估源库的数据变更速率。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("src_rps", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcRps { get; set; }

        /// <summary>
        /// **参数解释**：  源库IO（Input/Output，每秒输入输出操作量），用于评估源库的磁盘读写负载。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("src_io", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcIo { get; set; }

        /// <summary>
        /// **参数解释**：  目标库RPS（Requests Per Second，每秒请求数），用于评估目标库的数据写入速率。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("dst_rps", NullValueHandling = NullValueHandling.Ignore)]
        public string DstRps { get; set; }

        /// <summary>
        /// **参数解释**：  目标库IO（Input/Output，每秒输入输出操作量），用于评估目标库的磁盘读写负载。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("dst_io", NullValueHandling = NullValueHandling.Ignore)]
        public string DstIo { get; set; }

        /// <summary>
        /// **参数解释**：  已迁移的数据量，用于评估迁移进度。单位：MB。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("trans_data", NullValueHandling = NullValueHandling.Ignore)]
        public string TransData { get; set; }

        /// <summary>
        /// **参数解释**：  已迁移的数据行数，用于评估迁移进度。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("trans_lines", NullValueHandling = NullValueHandling.Ignore)]
        public string TransLines { get; set; }

        /// <summary>
        /// **参数解释**：  迁移实例磁盘使用量，用于监控迁移实例存储容量。单位：GB。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("used_volumes", NullValueHandling = NullValueHandling.Ignore)]
        public string UsedVolumes { get; set; }

        /// <summary>
        /// **参数解释**：  迁移实例内存使用量，用于监控迁移实例内存消耗。单位：MB。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("used_memory", NullValueHandling = NullValueHandling.Ignore)]
        public string UsedMemory { get; set; }

        /// <summary>
        /// **参数解释**：  迁移实例CPU使用百分比，用于监控迁移实例计算负载。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("used_cpu_percent", NullValueHandling = NullValueHandling.Ignore)]
        public string UsedCpuPercent { get; set; }

        /// <summary>
        /// **参数解释**：  迁移实例磁盘总大小，与used_volumes配合评估磁盘使用率。单位：GB。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("node_volume_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? NodeVolumeSize { get; set; }

        /// <summary>
        /// **参数解释**：  迁移实例内存总大小，与used_memory配合评估内存使用率。单位：MB。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("node_memory_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? NodeMemorySize { get; set; }

        /// <summary>
        /// **参数解释**：  监控数据的更新时间，UTC格式，如2023-07-19T03:09:25Z。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// **参数解释**：  同步速度，用于评估数据回放速率。单位：byte/s。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("apply_rate", NullValueHandling = NullValueHandling.Ignore)]
        public int? ApplyRate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowMonitorDataResponse {\n");
            sb.Append("  bandwidth: ").Append(Bandwidth).Append("\n");
            sb.Append("  isSrcNormal: ").Append(IsSrcNormal).Append("\n");
            sb.Append("  isDstNormal: ").Append(IsDstNormal).Append("\n");
            sb.Append("  srcOffset: ").Append(SrcOffset).Append("\n");
            sb.Append("  nodeOffset: ").Append(NodeOffset).Append("\n");
            sb.Append("  dstOffset: ").Append(DstOffset).Append("\n");
            sb.Append("  srcDelay: ").Append(SrcDelay).Append("\n");
            sb.Append("  dstDelay: ").Append(DstDelay).Append("\n");
            sb.Append("  srcRps: ").Append(SrcRps).Append("\n");
            sb.Append("  srcIo: ").Append(SrcIo).Append("\n");
            sb.Append("  dstRps: ").Append(DstRps).Append("\n");
            sb.Append("  dstIo: ").Append(DstIo).Append("\n");
            sb.Append("  transData: ").Append(TransData).Append("\n");
            sb.Append("  transLines: ").Append(TransLines).Append("\n");
            sb.Append("  usedVolumes: ").Append(UsedVolumes).Append("\n");
            sb.Append("  usedMemory: ").Append(UsedMemory).Append("\n");
            sb.Append("  usedCpuPercent: ").Append(UsedCpuPercent).Append("\n");
            sb.Append("  nodeVolumeSize: ").Append(NodeVolumeSize).Append("\n");
            sb.Append("  nodeMemorySize: ").Append(NodeMemorySize).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  applyRate: ").Append(ApplyRate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowMonitorDataResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowMonitorDataResponse input)
        {
            if (input == null) return false;
            if (this.Bandwidth != input.Bandwidth || (this.Bandwidth != null && !this.Bandwidth.Equals(input.Bandwidth))) return false;
            if (this.IsSrcNormal != input.IsSrcNormal || (this.IsSrcNormal != null && !this.IsSrcNormal.Equals(input.IsSrcNormal))) return false;
            if (this.IsDstNormal != input.IsDstNormal || (this.IsDstNormal != null && !this.IsDstNormal.Equals(input.IsDstNormal))) return false;
            if (this.SrcOffset != input.SrcOffset || (this.SrcOffset != null && !this.SrcOffset.Equals(input.SrcOffset))) return false;
            if (this.NodeOffset != input.NodeOffset || (this.NodeOffset != null && !this.NodeOffset.Equals(input.NodeOffset))) return false;
            if (this.DstOffset != input.DstOffset || (this.DstOffset != null && !this.DstOffset.Equals(input.DstOffset))) return false;
            if (this.SrcDelay != input.SrcDelay || (this.SrcDelay != null && !this.SrcDelay.Equals(input.SrcDelay))) return false;
            if (this.DstDelay != input.DstDelay || (this.DstDelay != null && !this.DstDelay.Equals(input.DstDelay))) return false;
            if (this.SrcRps != input.SrcRps || (this.SrcRps != null && !this.SrcRps.Equals(input.SrcRps))) return false;
            if (this.SrcIo != input.SrcIo || (this.SrcIo != null && !this.SrcIo.Equals(input.SrcIo))) return false;
            if (this.DstRps != input.DstRps || (this.DstRps != null && !this.DstRps.Equals(input.DstRps))) return false;
            if (this.DstIo != input.DstIo || (this.DstIo != null && !this.DstIo.Equals(input.DstIo))) return false;
            if (this.TransData != input.TransData || (this.TransData != null && !this.TransData.Equals(input.TransData))) return false;
            if (this.TransLines != input.TransLines || (this.TransLines != null && !this.TransLines.Equals(input.TransLines))) return false;
            if (this.UsedVolumes != input.UsedVolumes || (this.UsedVolumes != null && !this.UsedVolumes.Equals(input.UsedVolumes))) return false;
            if (this.UsedMemory != input.UsedMemory || (this.UsedMemory != null && !this.UsedMemory.Equals(input.UsedMemory))) return false;
            if (this.UsedCpuPercent != input.UsedCpuPercent || (this.UsedCpuPercent != null && !this.UsedCpuPercent.Equals(input.UsedCpuPercent))) return false;
            if (this.NodeVolumeSize != input.NodeVolumeSize || (this.NodeVolumeSize != null && !this.NodeVolumeSize.Equals(input.NodeVolumeSize))) return false;
            if (this.NodeMemorySize != input.NodeMemorySize || (this.NodeMemorySize != null && !this.NodeMemorySize.Equals(input.NodeMemorySize))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.ApplyRate != input.ApplyRate || (this.ApplyRate != null && !this.ApplyRate.Equals(input.ApplyRate))) return false;

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
                if (this.IsSrcNormal != null) hashCode = hashCode * 59 + this.IsSrcNormal.GetHashCode();
                if (this.IsDstNormal != null) hashCode = hashCode * 59 + this.IsDstNormal.GetHashCode();
                if (this.SrcOffset != null) hashCode = hashCode * 59 + this.SrcOffset.GetHashCode();
                if (this.NodeOffset != null) hashCode = hashCode * 59 + this.NodeOffset.GetHashCode();
                if (this.DstOffset != null) hashCode = hashCode * 59 + this.DstOffset.GetHashCode();
                if (this.SrcDelay != null) hashCode = hashCode * 59 + this.SrcDelay.GetHashCode();
                if (this.DstDelay != null) hashCode = hashCode * 59 + this.DstDelay.GetHashCode();
                if (this.SrcRps != null) hashCode = hashCode * 59 + this.SrcRps.GetHashCode();
                if (this.SrcIo != null) hashCode = hashCode * 59 + this.SrcIo.GetHashCode();
                if (this.DstRps != null) hashCode = hashCode * 59 + this.DstRps.GetHashCode();
                if (this.DstIo != null) hashCode = hashCode * 59 + this.DstIo.GetHashCode();
                if (this.TransData != null) hashCode = hashCode * 59 + this.TransData.GetHashCode();
                if (this.TransLines != null) hashCode = hashCode * 59 + this.TransLines.GetHashCode();
                if (this.UsedVolumes != null) hashCode = hashCode * 59 + this.UsedVolumes.GetHashCode();
                if (this.UsedMemory != null) hashCode = hashCode * 59 + this.UsedMemory.GetHashCode();
                if (this.UsedCpuPercent != null) hashCode = hashCode * 59 + this.UsedCpuPercent.GetHashCode();
                if (this.NodeVolumeSize != null) hashCode = hashCode * 59 + this.NodeVolumeSize.GetHashCode();
                if (this.NodeMemorySize != null) hashCode = hashCode * 59 + this.NodeMemorySize.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.ApplyRate != null) hashCode = hashCode * 59 + this.ApplyRate.GetHashCode();
                return hashCode;
            }
        }
    }
}
