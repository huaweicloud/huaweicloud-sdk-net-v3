using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class InstancesMetricResult 
    {

        /// <summary>
        /// **参数解释**： 实例ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**： 实例名称。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 实例状态。 **取值范围**： - creating，表示实例正在创建。 - normal，表示实例正常。 - abnormal，表示实例异常。 - createfail，表示实例创建失败。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**： 实例类型。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }

        /// <summary>
        /// **参数解释**： 引擎名称。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("engine_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineName { get; set; }

        /// <summary>
        /// **参数解释**： 引擎版本。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("engine_version", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// **参数解释**： 部署形态。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("solution", NullValueHandling = NullValueHandling.Ignore)]
        public string Solution { get; set; }

        /// <summary>
        /// **参数解释**： 实例数据磁盘已使用大小。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("disk_used_size", NullValueHandling = NullValueHandling.Ignore)]
        public string DiskUsedSize { get; set; }

        /// <summary>
        /// **参数解释**： 实例数据磁盘总大小。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("disk_total_size", NullValueHandling = NullValueHandling.Ignore)]
        public string DiskTotalSize { get; set; }

        /// <summary>
        /// **参数解释**： 实例数据磁盘已使用百分比。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("disk_usage", NullValueHandling = NullValueHandling.Ignore)]
        public string DiskUsage { get; set; }

        /// <summary>
        /// **参数解释**： 80% SQL的响应时间。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("p80", NullValueHandling = NullValueHandling.Ignore)]
        public string P80 { get; set; }

        /// <summary>
        /// **参数解释**： 95% SQL的响应时间。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("p95", NullValueHandling = NullValueHandling.Ignore)]
        public string P95 { get; set; }

        /// <summary>
        /// **参数解释**： 死锁次数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("deadlocks", NullValueHandling = NullValueHandling.Ignore)]
        public string Deadlocks { get; set; }

        /// <summary>
        /// **参数解释**： buffer 命中率。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("buffer_hit_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public string BufferHitRatio { get; set; }

        /// <summary>
        /// **参数解释**： 实例节点信息列表。
        /// </summary>
        [JsonProperty("nodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<InstancesNodesResult> Nodes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstancesMetricResult {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  engineName: ").Append(EngineName).Append("\n");
            sb.Append("  engineVersion: ").Append(EngineVersion).Append("\n");
            sb.Append("  solution: ").Append(Solution).Append("\n");
            sb.Append("  diskUsedSize: ").Append(DiskUsedSize).Append("\n");
            sb.Append("  diskTotalSize: ").Append(DiskTotalSize).Append("\n");
            sb.Append("  diskUsage: ").Append(DiskUsage).Append("\n");
            sb.Append("  p80: ").Append(P80).Append("\n");
            sb.Append("  p95: ").Append(P95).Append("\n");
            sb.Append("  deadlocks: ").Append(Deadlocks).Append("\n");
            sb.Append("  bufferHitRatio: ").Append(BufferHitRatio).Append("\n");
            sb.Append("  nodes: ").Append(Nodes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstancesMetricResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstancesMetricResult input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Mode != input.Mode || (this.Mode != null && !this.Mode.Equals(input.Mode))) return false;
            if (this.EngineName != input.EngineName || (this.EngineName != null && !this.EngineName.Equals(input.EngineName))) return false;
            if (this.EngineVersion != input.EngineVersion || (this.EngineVersion != null && !this.EngineVersion.Equals(input.EngineVersion))) return false;
            if (this.Solution != input.Solution || (this.Solution != null && !this.Solution.Equals(input.Solution))) return false;
            if (this.DiskUsedSize != input.DiskUsedSize || (this.DiskUsedSize != null && !this.DiskUsedSize.Equals(input.DiskUsedSize))) return false;
            if (this.DiskTotalSize != input.DiskTotalSize || (this.DiskTotalSize != null && !this.DiskTotalSize.Equals(input.DiskTotalSize))) return false;
            if (this.DiskUsage != input.DiskUsage || (this.DiskUsage != null && !this.DiskUsage.Equals(input.DiskUsage))) return false;
            if (this.P80 != input.P80 || (this.P80 != null && !this.P80.Equals(input.P80))) return false;
            if (this.P95 != input.P95 || (this.P95 != null && !this.P95.Equals(input.P95))) return false;
            if (this.Deadlocks != input.Deadlocks || (this.Deadlocks != null && !this.Deadlocks.Equals(input.Deadlocks))) return false;
            if (this.BufferHitRatio != input.BufferHitRatio || (this.BufferHitRatio != null && !this.BufferHitRatio.Equals(input.BufferHitRatio))) return false;
            if (this.Nodes != input.Nodes || (this.Nodes != null && input.Nodes != null && !this.Nodes.SequenceEqual(input.Nodes))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Mode != null) hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.EngineName != null) hashCode = hashCode * 59 + this.EngineName.GetHashCode();
                if (this.EngineVersion != null) hashCode = hashCode * 59 + this.EngineVersion.GetHashCode();
                if (this.Solution != null) hashCode = hashCode * 59 + this.Solution.GetHashCode();
                if (this.DiskUsedSize != null) hashCode = hashCode * 59 + this.DiskUsedSize.GetHashCode();
                if (this.DiskTotalSize != null) hashCode = hashCode * 59 + this.DiskTotalSize.GetHashCode();
                if (this.DiskUsage != null) hashCode = hashCode * 59 + this.DiskUsage.GetHashCode();
                if (this.P80 != null) hashCode = hashCode * 59 + this.P80.GetHashCode();
                if (this.P95 != null) hashCode = hashCode * 59 + this.P95.GetHashCode();
                if (this.Deadlocks != null) hashCode = hashCode * 59 + this.Deadlocks.GetHashCode();
                if (this.BufferHitRatio != null) hashCode = hashCode * 59 + this.BufferHitRatio.GetHashCode();
                if (this.Nodes != null) hashCode = hashCode * 59 + this.Nodes.GetHashCode();
                return hashCode;
            }
        }
    }
}
