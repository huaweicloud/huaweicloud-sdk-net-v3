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
    /// Response Object
    /// </summary>
    public class QueryAutoSqlLimitingResponse : SdkResponse
    {

        /// <summary>
        /// 限流策略CPU利用率。
        /// </summary>
        [JsonProperty("cpu_usage", NullValueHandling = NullValueHandling.Ignore)]
        public int? CpuUsage { get; set; }

        /// <summary>
        /// 限流策略活跃会话数。
        /// </summary>
        [JsonProperty("active_sessions", NullValueHandling = NullValueHandling.Ignore)]
        public int? ActiveSessions { get; set; }

        /// <summary>
        /// 限流策略CPU利用率和活跃会话数的关联关系。取值范围：and、or。
        /// </summary>
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public string Condition { get; set; }

        /// <summary>
        /// 限流策略满足限流条件的事件持续时间（分钟）。
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? Duration { get; set; }

        /// <summary>
        /// 自治限流规则每天生效开始时间。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 自治限流规则每天生效结束时间。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 允许的会话数。
        /// </summary>
        [JsonProperty("session_allow", NullValueHandling = NullValueHandling.Ignore)]
        public int? SessionAllow { get; set; }

        /// <summary>
        /// 限流规则适用的用户列表。
        /// </summary>
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> User { get; set; }

        /// <summary>
        /// 限流规则适用的数据库列表。
        /// </summary>
        [JsonProperty("db", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Db { get; set; }

        /// <summary>
        /// 每次最大限流时长（分钟）。
        /// </summary>
        [JsonProperty("clear_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClearTime { get; set; }

        /// <summary>
        /// 是否启用自治限流规则。
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        /// <summary>
        /// 是否为关键字限流。
        /// </summary>
        [JsonProperty("is_keyword", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsKeyword { get; set; }

        /// <summary>
        /// 最大并发数。
        /// </summary>
        [JsonProperty("max_concurrency", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxConcurrency { get; set; }

        /// <summary>
        /// 是否保留SQL限流规则。
        /// </summary>
        [JsonProperty("retain_sql_rule", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RetainSqlRule { get; set; }

        /// <summary>
        /// 是否开启kill会话开关。
        /// </summary>
        [JsonProperty("kill_session_switch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? KillSessionSwitch { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryAutoSqlLimitingResponse {\n");
            sb.Append("  cpuUsage: ").Append(CpuUsage).Append("\n");
            sb.Append("  activeSessions: ").Append(ActiveSessions).Append("\n");
            sb.Append("  condition: ").Append(Condition).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  sessionAllow: ").Append(SessionAllow).Append("\n");
            sb.Append("  user: ").Append(User).Append("\n");
            sb.Append("  db: ").Append(Db).Append("\n");
            sb.Append("  clearTime: ").Append(ClearTime).Append("\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  isKeyword: ").Append(IsKeyword).Append("\n");
            sb.Append("  maxConcurrency: ").Append(MaxConcurrency).Append("\n");
            sb.Append("  retainSqlRule: ").Append(RetainSqlRule).Append("\n");
            sb.Append("  killSessionSwitch: ").Append(KillSessionSwitch).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryAutoSqlLimitingResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryAutoSqlLimitingResponse input)
        {
            if (input == null) return false;
            if (this.CpuUsage != input.CpuUsage || (this.CpuUsage != null && !this.CpuUsage.Equals(input.CpuUsage))) return false;
            if (this.ActiveSessions != input.ActiveSessions || (this.ActiveSessions != null && !this.ActiveSessions.Equals(input.ActiveSessions))) return false;
            if (this.Condition != input.Condition || (this.Condition != null && !this.Condition.Equals(input.Condition))) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.SessionAllow != input.SessionAllow || (this.SessionAllow != null && !this.SessionAllow.Equals(input.SessionAllow))) return false;
            if (this.User != input.User || (this.User != null && input.User != null && !this.User.SequenceEqual(input.User))) return false;
            if (this.Db != input.Db || (this.Db != null && input.Db != null && !this.Db.SequenceEqual(input.Db))) return false;
            if (this.ClearTime != input.ClearTime || (this.ClearTime != null && !this.ClearTime.Equals(input.ClearTime))) return false;
            if (this.Enable != input.Enable || (this.Enable != null && !this.Enable.Equals(input.Enable))) return false;
            if (this.IsKeyword != input.IsKeyword || (this.IsKeyword != null && !this.IsKeyword.Equals(input.IsKeyword))) return false;
            if (this.MaxConcurrency != input.MaxConcurrency || (this.MaxConcurrency != null && !this.MaxConcurrency.Equals(input.MaxConcurrency))) return false;
            if (this.RetainSqlRule != input.RetainSqlRule || (this.RetainSqlRule != null && !this.RetainSqlRule.Equals(input.RetainSqlRule))) return false;
            if (this.KillSessionSwitch != input.KillSessionSwitch || (this.KillSessionSwitch != null && !this.KillSessionSwitch.Equals(input.KillSessionSwitch))) return false;

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
                if (this.CpuUsage != null) hashCode = hashCode * 59 + this.CpuUsage.GetHashCode();
                if (this.ActiveSessions != null) hashCode = hashCode * 59 + this.ActiveSessions.GetHashCode();
                if (this.Condition != null) hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.SessionAllow != null) hashCode = hashCode * 59 + this.SessionAllow.GetHashCode();
                if (this.User != null) hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Db != null) hashCode = hashCode * 59 + this.Db.GetHashCode();
                if (this.ClearTime != null) hashCode = hashCode * 59 + this.ClearTime.GetHashCode();
                if (this.Enable != null) hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.IsKeyword != null) hashCode = hashCode * 59 + this.IsKeyword.GetHashCode();
                if (this.MaxConcurrency != null) hashCode = hashCode * 59 + this.MaxConcurrency.GetHashCode();
                if (this.RetainSqlRule != null) hashCode = hashCode * 59 + this.RetainSqlRule.GetHashCode();
                if (this.KillSessionSwitch != null) hashCode = hashCode * 59 + this.KillSessionSwitch.GetHashCode();
                return hashCode;
            }
        }
    }
}
