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
    public class IntelligentKillSessionStatistic 
    {

        /// <summary>
        /// **参数解释**：  预览智能Kill会话SQL模板关键字。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("keyword", NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// **参数解释**：  预览智能Kill会话中的SQL模板命中的首个会话正在执行的SQL语句。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("example_sql_text", NullValueHandling = NullValueHandling.Ignore)]
        public string ExampleSqlText { get; set; }

        /// <summary>
        /// **参数解释**：  预览智能Kill会话中的SQL模板命中的会话线程ID列表。
        /// </summary>
        [JsonProperty("ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<long?> Ids { get; set; }

        /// <summary>
        /// **参数解释**：  预览智能Kill会话中的SQL模板命中的会话个数。  **取值范围**：  &gt;&#x3D;0。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// **参数解释**：  预览智能Kill会话中的SQL模板命中的会话总执行时间，单位为秒。  **取值范围**：  &gt;&#x3D;0。
        /// </summary>
        [JsonProperty("total_time", NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalTime { get; set; }

        /// <summary>
        /// **参数解释**：  预览智能Kill会话中的SQL模板命中的会话平均执行时间，单位为秒。  **取值范围**：  &gt;&#x3D;0。
        /// </summary>
        [JsonProperty("avg_time", NullValueHandling = NullValueHandling.Ignore)]
        public double? AvgTime { get; set; }

        /// <summary>
        /// **参数解释**：  预览智能Kill会话中的SQL模板命中的会话中最长会话执行时间，单位为秒。  **取值范围**：  &gt;&#x3D;0。
        /// </summary>
        [JsonProperty("max_time", NullValueHandling = NullValueHandling.Ignore)]
        public double? MaxTime { get; set; }

        /// <summary>
        /// **参数解释**：  预览智能Kill会话中的SQL模板命中Kill会话策略。  **取值范围**：  - top3_time: 以每组内会话最长的执行时长排序，选择排名前三的组内会话进行Kill。 - top3_count: 以每组内会话数量排序，选择排名前三的组内会话进行Kill。 - top3_avg_time: 以每组内会话平均执行时长排序，选择排名前三的组内会话进行Kill。
        /// </summary>
        [JsonProperty("strategy", NullValueHandling = NullValueHandling.Ignore)]
        public string Strategy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntelligentKillSessionStatistic {\n");
            sb.Append("  keyword: ").Append(Keyword).Append("\n");
            sb.Append("  exampleSqlText: ").Append(ExampleSqlText).Append("\n");
            sb.Append("  ids: ").Append(Ids).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  totalTime: ").Append(TotalTime).Append("\n");
            sb.Append("  avgTime: ").Append(AvgTime).Append("\n");
            sb.Append("  maxTime: ").Append(MaxTime).Append("\n");
            sb.Append("  strategy: ").Append(Strategy).Append("\n");
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
            if (this.ExampleSqlText != input.ExampleSqlText || (this.ExampleSqlText != null && !this.ExampleSqlText.Equals(input.ExampleSqlText))) return false;
            if (this.Ids != input.Ids || (this.Ids != null && input.Ids != null && !this.Ids.SequenceEqual(input.Ids))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.TotalTime != input.TotalTime || (this.TotalTime != null && !this.TotalTime.Equals(input.TotalTime))) return false;
            if (this.AvgTime != input.AvgTime || (this.AvgTime != null && !this.AvgTime.Equals(input.AvgTime))) return false;
            if (this.MaxTime != input.MaxTime || (this.MaxTime != null && !this.MaxTime.Equals(input.MaxTime))) return false;
            if (this.Strategy != input.Strategy || (this.Strategy != null && !this.Strategy.Equals(input.Strategy))) return false;

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
                if (this.ExampleSqlText != null) hashCode = hashCode * 59 + this.ExampleSqlText.GetHashCode();
                if (this.Ids != null) hashCode = hashCode * 59 + this.Ids.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.TotalTime != null) hashCode = hashCode * 59 + this.TotalTime.GetHashCode();
                if (this.AvgTime != null) hashCode = hashCode * 59 + this.AvgTime.GetHashCode();
                if (this.MaxTime != null) hashCode = hashCode * 59 + this.MaxTime.GetHashCode();
                if (this.Strategy != null) hashCode = hashCode * 59 + this.Strategy.GetHashCode();
                return hashCode;
            }
        }
    }
}
