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
    public class ShowMySqlProxySlowLogListResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  数据库代理慢日志信息列表。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("slow_log_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProxySlowLogDetail> SlowLogList { get; set; }

        /// <summary>
        /// **参数解释**：  慢日志展示列表，该字段定义slow_log_list返回哪些字段信息，line_num字段一定返回。  **约束限制**：  不涉及。  **取值范围**：  - source_ip：客户端IP。 - desc_ip：后端数据库IP回。 - user：数据库用户。 - reaction_time：响应时长，单位ms。 - trace_id：SQL执行跟踪ID。 - sql：执行语句。 - start_time：SQL语句执行开始时间，毫秒级时间戳。 - end_time：SQL语句执行结束时间，毫秒级时间戳。 - database：数据库名称，默认不返回。 - log_time：日志上报时间，毫秒级时间戳，默认不返回。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("slow_log_column", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SlowLogColumn { get; set; }

        /// <summary>
        /// **参数解释**：  慢日志阈值，单位ms。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("slow_log_query_time", NullValueHandling = NullValueHandling.Ignore)]
        public string SlowLogQueryTime { get; set; }

        /// <summary>
        /// **参数解释**：  慢日志上报开关状态。  **约束限制**：  不涉及。  **取值范围**：  - on：开启。 - off：关闭。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("lts_slow_log_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public string LtsSlowLogEnabled { get; set; }

        /// <summary>
        /// **参数解释**：  数据库代理版本是否支持慢日志上报。  **约束限制**：  不涉及。  **取值范围**：  - true：支持。 - false：不支持。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("support_switch_lts_slow_log", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportSwitchLtsSlowLog { get; set; }

        /// <summary>
        /// **参数解释**：  每次查询到的慢日志数量。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowMySqlProxySlowLogListResponse {\n");
            sb.Append("  slowLogList: ").Append(SlowLogList).Append("\n");
            sb.Append("  slowLogColumn: ").Append(SlowLogColumn).Append("\n");
            sb.Append("  slowLogQueryTime: ").Append(SlowLogQueryTime).Append("\n");
            sb.Append("  ltsSlowLogEnabled: ").Append(LtsSlowLogEnabled).Append("\n");
            sb.Append("  supportSwitchLtsSlowLog: ").Append(SupportSwitchLtsSlowLog).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowMySqlProxySlowLogListResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowMySqlProxySlowLogListResponse input)
        {
            if (input == null) return false;
            if (this.SlowLogList != input.SlowLogList || (this.SlowLogList != null && input.SlowLogList != null && !this.SlowLogList.SequenceEqual(input.SlowLogList))) return false;
            if (this.SlowLogColumn != input.SlowLogColumn || (this.SlowLogColumn != null && input.SlowLogColumn != null && !this.SlowLogColumn.SequenceEqual(input.SlowLogColumn))) return false;
            if (this.SlowLogQueryTime != input.SlowLogQueryTime || (this.SlowLogQueryTime != null && !this.SlowLogQueryTime.Equals(input.SlowLogQueryTime))) return false;
            if (this.LtsSlowLogEnabled != input.LtsSlowLogEnabled || (this.LtsSlowLogEnabled != null && !this.LtsSlowLogEnabled.Equals(input.LtsSlowLogEnabled))) return false;
            if (this.SupportSwitchLtsSlowLog != input.SupportSwitchLtsSlowLog || (this.SupportSwitchLtsSlowLog != null && !this.SupportSwitchLtsSlowLog.Equals(input.SupportSwitchLtsSlowLog))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;

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
                if (this.SlowLogList != null) hashCode = hashCode * 59 + this.SlowLogList.GetHashCode();
                if (this.SlowLogColumn != null) hashCode = hashCode * 59 + this.SlowLogColumn.GetHashCode();
                if (this.SlowLogQueryTime != null) hashCode = hashCode * 59 + this.SlowLogQueryTime.GetHashCode();
                if (this.LtsSlowLogEnabled != null) hashCode = hashCode * 59 + this.LtsSlowLogEnabled.GetHashCode();
                if (this.SupportSwitchLtsSlowLog != null) hashCode = hashCode * 59 + this.SupportSwitchLtsSlowLog.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
