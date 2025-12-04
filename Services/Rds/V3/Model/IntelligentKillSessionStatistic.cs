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
    /// 实时统计信息
    /// </summary>
    public class IntelligentKillSessionStatistic 
    {

        /// <summary>
        /// **参数解释**：  该类统计维度下提取到的限流关键字。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("keyword", NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// **参数解释**：  随机选取符合sql限流关键字的用户某条sql样例。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("raw_sql", NullValueHandling = NullValueHandling.Ignore)]
        public string RawSql { get; set; }

        /// <summary>
        /// **参数解释**：  符合该统计维度的线程id。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<long?> Ids { get; set; }

        /// <summary>
        /// **参数解释**：  符合该统计维度的线程id总数量。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// **参数解释**：  符合该统计维度的线程总执行时间。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("total_time", NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalTime { get; set; }

        /// <summary>
        /// **参数解释**：  符合该统计维度的线程平均执行时间。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("avg_time", NullValueHandling = NullValueHandling.Ignore)]
        public double? AvgTime { get; set; }

        /// <summary>
        /// **参数解释**：  符合该统计维度的线程最大执行时间。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("max_time", NullValueHandling = NullValueHandling.Ignore)]
        public double? MaxTime { get; set; }

        /// <summary>
        /// **参数解释**：  统计维度。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("strategy", NullValueHandling = NullValueHandling.Ignore)]
        public string Strategy { get; set; }

        /// <summary>
        /// **参数解释**：  推荐最大并发数。type为\&quot;kill\&quot;时该参数没有返回值。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("advice_concurrency", NullValueHandling = NullValueHandling.Ignore)]
        public int? AdviceConcurrency { get; set; }

        /// <summary>
        /// **参数解释**：  该条维度数据的类型。\&quot;kill\&quot;表示当前统计时刻下一键kill会话下发后会kill该类会话；\&quot;limit\&quot;表示当前统计时刻下勾选\&quot;同步开启sql限流和添加规则\&quot;时会添加的规则。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntelligentKillSessionStatistic {\n");
            sb.Append("  keyword: ").Append(Keyword).Append("\n");
            sb.Append("  rawSql: ").Append(RawSql).Append("\n");
            sb.Append("  ids: ").Append(Ids).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  totalTime: ").Append(TotalTime).Append("\n");
            sb.Append("  avgTime: ").Append(AvgTime).Append("\n");
            sb.Append("  maxTime: ").Append(MaxTime).Append("\n");
            sb.Append("  strategy: ").Append(Strategy).Append("\n");
            sb.Append("  adviceConcurrency: ").Append(AdviceConcurrency).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IntelligentKillSessionStatistic);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IntelligentKillSessionStatistic input)
        {
            if (input == null) return false;
            if (this.Keyword != input.Keyword || (this.Keyword != null && !this.Keyword.Equals(input.Keyword))) return false;
            if (this.RawSql != input.RawSql || (this.RawSql != null && !this.RawSql.Equals(input.RawSql))) return false;
            if (this.Ids != input.Ids || (this.Ids != null && input.Ids != null && !this.Ids.SequenceEqual(input.Ids))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.TotalTime != input.TotalTime || (this.TotalTime != null && !this.TotalTime.Equals(input.TotalTime))) return false;
            if (this.AvgTime != input.AvgTime || (this.AvgTime != null && !this.AvgTime.Equals(input.AvgTime))) return false;
            if (this.MaxTime != input.MaxTime || (this.MaxTime != null && !this.MaxTime.Equals(input.MaxTime))) return false;
            if (this.Strategy != input.Strategy || (this.Strategy != null && !this.Strategy.Equals(input.Strategy))) return false;
            if (this.AdviceConcurrency != input.AdviceConcurrency || (this.AdviceConcurrency != null && !this.AdviceConcurrency.Equals(input.AdviceConcurrency))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;

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
                if (this.Keyword != null) hashCode = hashCode * 59 + this.Keyword.GetHashCode();
                if (this.RawSql != null) hashCode = hashCode * 59 + this.RawSql.GetHashCode();
                if (this.Ids != null) hashCode = hashCode * 59 + this.Ids.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.TotalTime != null) hashCode = hashCode * 59 + this.TotalTime.GetHashCode();
                if (this.AvgTime != null) hashCode = hashCode * 59 + this.AvgTime.GetHashCode();
                if (this.MaxTime != null) hashCode = hashCode * 59 + this.MaxTime.GetHashCode();
                if (this.Strategy != null) hashCode = hashCode * 59 + this.Strategy.GetHashCode();
                if (this.AdviceConcurrency != null) hashCode = hashCode * 59 + this.AdviceConcurrency.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
