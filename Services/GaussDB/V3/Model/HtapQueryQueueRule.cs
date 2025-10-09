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
    /// **参数解释**：  HTAP标准版查询队列规则。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认值**：  不涉及。
    /// </summary>
    public class HtapQueryQueueRule 
    {

        /// <summary>
        /// **参数解释**：  查询队列中的查询数量上限。  **约束限制**：  不涉及。  **取值范围**：  非负整数。  **默认值**：  1024。
        /// </summary>
        [JsonProperty("query_queue_max_queued_queries", NullValueHandling = NullValueHandling.Ignore)]
        public int? QueryQueueMaxQueuedQueries { get; set; }

        /// <summary>
        /// **参数解释**：  查询阻塞时间上限。  **约束限制**：  不涉及。  **取值范围**：  非负整数。  **默认值**：  300。
        /// </summary>
        [JsonProperty("query_queue_pending_timeout_second", NullValueHandling = NullValueHandling.Ignore)]
        public int? QueryQueuePendingTimeoutSecond { get; set; }

        /// <summary>
        /// **参数解释**：  查询队列并发值。  **约束限制**：  不涉及。  **取值范围**：  0~100的整数，0表示没有限制。  **默认值**：  0。
        /// </summary>
        [JsonProperty("query_queue_concurrency_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? QueryQueueConcurrencyLimit { get; set; }

        /// <summary>
        /// **参数解释**：  内存使用百分比。  **约束限制**：  不涉及。  **取值范围**：  0~100的整数，0表示没有限制。  **默认值**：  0。
        /// </summary>
        [JsonProperty("query_queue_mem_used_pct_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? QueryQueueMemUsedPctLimit { get; set; }

        /// <summary>
        /// **参数解释**：  CPU使用百分比。  **约束限制**：  不涉及。  **取值范围**：  0~100的整数，0表示没有限制。  **默认值**：  0。
        /// </summary>
        [JsonProperty("query_queue_cpu_used_pct_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? QueryQueueCpuUsedPctLimit { get; set; }

        /// <summary>
        /// **参数解释**：  查询队列开关状态。  **约束限制**：  不涉及。  **取值范围**：  - true：表示开启。 - false：表示关闭。  **默认值**：  false。
        /// </summary>
        [JsonProperty("enable_query_queue_select", NullValueHandling = NullValueHandling.Ignore)]
        public string EnableQueryQueueSelect { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HtapQueryQueueRule {\n");
            sb.Append("  queryQueueMaxQueuedQueries: ").Append(QueryQueueMaxQueuedQueries).Append("\n");
            sb.Append("  queryQueuePendingTimeoutSecond: ").Append(QueryQueuePendingTimeoutSecond).Append("\n");
            sb.Append("  queryQueueConcurrencyLimit: ").Append(QueryQueueConcurrencyLimit).Append("\n");
            sb.Append("  queryQueueMemUsedPctLimit: ").Append(QueryQueueMemUsedPctLimit).Append("\n");
            sb.Append("  queryQueueCpuUsedPctLimit: ").Append(QueryQueueCpuUsedPctLimit).Append("\n");
            sb.Append("  enableQueryQueueSelect: ").Append(EnableQueryQueueSelect).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HtapQueryQueueRule);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HtapQueryQueueRule input)
        {
            if (input == null) return false;
            if (this.QueryQueueMaxQueuedQueries != input.QueryQueueMaxQueuedQueries || (this.QueryQueueMaxQueuedQueries != null && !this.QueryQueueMaxQueuedQueries.Equals(input.QueryQueueMaxQueuedQueries))) return false;
            if (this.QueryQueuePendingTimeoutSecond != input.QueryQueuePendingTimeoutSecond || (this.QueryQueuePendingTimeoutSecond != null && !this.QueryQueuePendingTimeoutSecond.Equals(input.QueryQueuePendingTimeoutSecond))) return false;
            if (this.QueryQueueConcurrencyLimit != input.QueryQueueConcurrencyLimit || (this.QueryQueueConcurrencyLimit != null && !this.QueryQueueConcurrencyLimit.Equals(input.QueryQueueConcurrencyLimit))) return false;
            if (this.QueryQueueMemUsedPctLimit != input.QueryQueueMemUsedPctLimit || (this.QueryQueueMemUsedPctLimit != null && !this.QueryQueueMemUsedPctLimit.Equals(input.QueryQueueMemUsedPctLimit))) return false;
            if (this.QueryQueueCpuUsedPctLimit != input.QueryQueueCpuUsedPctLimit || (this.QueryQueueCpuUsedPctLimit != null && !this.QueryQueueCpuUsedPctLimit.Equals(input.QueryQueueCpuUsedPctLimit))) return false;
            if (this.EnableQueryQueueSelect != input.EnableQueryQueueSelect || (this.EnableQueryQueueSelect != null && !this.EnableQueryQueueSelect.Equals(input.EnableQueryQueueSelect))) return false;

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
                if (this.QueryQueueMaxQueuedQueries != null) hashCode = hashCode * 59 + this.QueryQueueMaxQueuedQueries.GetHashCode();
                if (this.QueryQueuePendingTimeoutSecond != null) hashCode = hashCode * 59 + this.QueryQueuePendingTimeoutSecond.GetHashCode();
                if (this.QueryQueueConcurrencyLimit != null) hashCode = hashCode * 59 + this.QueryQueueConcurrencyLimit.GetHashCode();
                if (this.QueryQueueMemUsedPctLimit != null) hashCode = hashCode * 59 + this.QueryQueueMemUsedPctLimit.GetHashCode();
                if (this.QueryQueueCpuUsedPctLimit != null) hashCode = hashCode * 59 + this.QueryQueueCpuUsedPctLimit.GetHashCode();
                if (this.EnableQueryQueueSelect != null) hashCode = hashCode * 59 + this.EnableQueryQueueSelect.GetHashCode();
                return hashCode;
            }
        }
    }
}
