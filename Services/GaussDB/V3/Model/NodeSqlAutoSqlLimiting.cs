using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class NodeSqlAutoSqlLimiting 
    {

        /// <summary>
        /// **参数解释**：  节点ID。  **取值范围**：  只能由英文字母、数字组成，前面为UUID，后缀为no07，长度为36个字符。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// **参数解释**：  自治限流规则每天生效开始时间。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// **参数解释**：  自治限流规则每天生效开始时间。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// **参数解释**：  限流策略CPU利用率和活跃会话数的关联关系。  **取值范围**：    - and：且。   - or：或。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public string Condition { get; set; }

        /// <summary>
        /// **参数解释**：  限流策略CPU利用率。  **约束限制**：  不涉及。  **取值范围**：  [70~100]。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("cpu_usage", NullValueHandling = NullValueHandling.Ignore)]
        public int? CpuUsage { get; set; }

        /// <summary>
        /// **参数解释**：  限流策略活跃会话数。  **约束限制**：  不涉及。  **取值范围**：  [1~5000]。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("active_sessions", NullValueHandling = NullValueHandling.Ignore)]
        public int? ActiveSessions { get; set; }

        /// <summary>
        /// **参数解释**：  每次最大限流时长（分钟）。  **取值范围**：  [1~1440]。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("clear_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClearTime { get; set; }

        /// <summary>
        /// **参数解释**：  限流策略满足限流条件的事件持续时间（分钟）。  **取值范围**：  [2~60]。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? Duration { get; set; }

        /// <summary>
        /// **参数解释**：  最大并发数。  **取值范围**：  [0~1000000000]。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("max_concurrency", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxConcurrency { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeSqlAutoSqlLimiting {\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  condition: ").Append(Condition).Append("\n");
            sb.Append("  cpuUsage: ").Append(CpuUsage).Append("\n");
            sb.Append("  activeSessions: ").Append(ActiveSessions).Append("\n");
            sb.Append("  clearTime: ").Append(ClearTime).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  maxConcurrency: ").Append(MaxConcurrency).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeSqlAutoSqlLimiting);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeSqlAutoSqlLimiting input)
        {
            if (input == null) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Condition != input.Condition || (this.Condition != null && !this.Condition.Equals(input.Condition))) return false;
            if (this.CpuUsage != input.CpuUsage || (this.CpuUsage != null && !this.CpuUsage.Equals(input.CpuUsage))) return false;
            if (this.ActiveSessions != input.ActiveSessions || (this.ActiveSessions != null && !this.ActiveSessions.Equals(input.ActiveSessions))) return false;
            if (this.ClearTime != input.ClearTime || (this.ClearTime != null && !this.ClearTime.Equals(input.ClearTime))) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;
            if (this.MaxConcurrency != input.MaxConcurrency || (this.MaxConcurrency != null && !this.MaxConcurrency.Equals(input.MaxConcurrency))) return false;

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
                if (this.NodeId != null) hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Condition != null) hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.CpuUsage != null) hashCode = hashCode * 59 + this.CpuUsage.GetHashCode();
                if (this.ActiveSessions != null) hashCode = hashCode * 59 + this.ActiveSessions.GetHashCode();
                if (this.ClearTime != null) hashCode = hashCode * 59 + this.ClearTime.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.MaxConcurrency != null) hashCode = hashCode * 59 + this.MaxConcurrency.GetHashCode();
                return hashCode;
            }
        }
    }
}
