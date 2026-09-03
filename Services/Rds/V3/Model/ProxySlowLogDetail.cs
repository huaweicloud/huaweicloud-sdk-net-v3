using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 数据库代理慢日志详情
    /// </summary>
    public class ProxySlowLogDetail 
    {

        /// <summary>
        /// **参数解释**：  客户端IP。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("source_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceIp { get; set; }

        /// <summary>
        /// **参数解释**：  后端数据库IP。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("desc_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string DescIp { get; set; }

        /// <summary>
        /// **参数解释**：  数据库用户。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public string User { get; set; }

        /// <summary>
        /// **参数解释**：  响应时长，单位ms。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("reaction_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ReactionTime { get; set; }

        /// <summary>
        /// **参数解释**：  SQL执行跟踪ID。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("trace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TraceId { get; set; }

        /// <summary>
        /// **参数解释**：  执行语句。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("sql", NullValueHandling = NullValueHandling.Ignore)]
        public string Sql { get; set; }

        /// <summary>
        /// **参数解释**：  SQL语句执行开始时间，毫秒级时间戳。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// **参数解释**：  SQL语句执行结束时间，毫秒级时间戳。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// **参数解释**：  每次查询起始记录ID，用于获取后续数据时在请求中传入。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("line_num", NullValueHandling = NullValueHandling.Ignore)]
        public string LineNum { get; set; }

        /// <summary>
        /// **参数解释**：  数据库名称。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("database", NullValueHandling = NullValueHandling.Ignore)]
        public string Database { get; set; }

        /// <summary>
        /// **参数解释**：  日志上报时间，毫秒级时间戳。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("log_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LogTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProxySlowLogDetail {\n");
            sb.Append("  sourceIp: ").Append(SourceIp).Append("\n");
            sb.Append("  descIp: ").Append(DescIp).Append("\n");
            sb.Append("  user: ").Append(User).Append("\n");
            sb.Append("  reactionTime: ").Append(ReactionTime).Append("\n");
            sb.Append("  traceId: ").Append(TraceId).Append("\n");
            sb.Append("  sql: ").Append(Sql).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  lineNum: ").Append(LineNum).Append("\n");
            sb.Append("  database: ").Append(Database).Append("\n");
            sb.Append("  logTime: ").Append(LogTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProxySlowLogDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProxySlowLogDetail input)
        {
            if (input == null) return false;
            if (this.SourceIp != input.SourceIp || (this.SourceIp != null && !this.SourceIp.Equals(input.SourceIp))) return false;
            if (this.DescIp != input.DescIp || (this.DescIp != null && !this.DescIp.Equals(input.DescIp))) return false;
            if (this.User != input.User || (this.User != null && !this.User.Equals(input.User))) return false;
            if (this.ReactionTime != input.ReactionTime || (this.ReactionTime != null && !this.ReactionTime.Equals(input.ReactionTime))) return false;
            if (this.TraceId != input.TraceId || (this.TraceId != null && !this.TraceId.Equals(input.TraceId))) return false;
            if (this.Sql != input.Sql || (this.Sql != null && !this.Sql.Equals(input.Sql))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.LineNum != input.LineNum || (this.LineNum != null && !this.LineNum.Equals(input.LineNum))) return false;
            if (this.Database != input.Database || (this.Database != null && !this.Database.Equals(input.Database))) return false;
            if (this.LogTime != input.LogTime || (this.LogTime != null && !this.LogTime.Equals(input.LogTime))) return false;

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
                if (this.SourceIp != null) hashCode = hashCode * 59 + this.SourceIp.GetHashCode();
                if (this.DescIp != null) hashCode = hashCode * 59 + this.DescIp.GetHashCode();
                if (this.User != null) hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.ReactionTime != null) hashCode = hashCode * 59 + this.ReactionTime.GetHashCode();
                if (this.TraceId != null) hashCode = hashCode * 59 + this.TraceId.GetHashCode();
                if (this.Sql != null) hashCode = hashCode * 59 + this.Sql.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.LineNum != null) hashCode = hashCode * 59 + this.LineNum.GetHashCode();
                if (this.Database != null) hashCode = hashCode * 59 + this.Database.GetHashCode();
                if (this.LogTime != null) hashCode = hashCode * 59 + this.LogTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
