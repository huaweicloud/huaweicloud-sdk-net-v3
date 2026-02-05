using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ESDBSlowSqlTemplateItem 
    {

        /// <summary>
        /// **参数解释**：  示例。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("query_sample", NullValueHandling = NullValueHandling.Ignore)]
        public string QuerySample { get; set; }

        /// <summary>
        /// **参数解释**：  数据库。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("database", NullValueHandling = NullValueHandling.Ignore)]
        public string Database { get; set; }

        /// <summary>
        /// **参数解释**：  执行时间。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("execute_times", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? ExecuteTimes { get; set; }

        /// <summary>
        /// **参数解释**：  平均检查行数。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("avg_rows_examined", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? AvgRowsExamined { get; set; }

        /// <summary>
        /// **参数解释**：  最大时间。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("max_time", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? MaxTime { get; set; }

        /// <summary>
        /// **参数解释**：  平均时间。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("avg_time", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? AvgTime { get; set; }

        /// <summary>
        /// **参数解释**：  最大检查行数。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("max_rows_examined", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? MaxRowsExamined { get; set; }

        /// <summary>
        /// **参数解释**：  总检查行数。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("rows_examined_sum", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? RowsExaminedSum { get; set; }

        /// <summary>
        /// **参数解释**：  总耗时。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("cost_time_sum", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? CostTimeSum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ESDBSlowSqlTemplateItem {\n");
            sb.Append("  querySample: ").Append(QuerySample).Append("\n");
            sb.Append("  database: ").Append(Database).Append("\n");
            sb.Append("  executeTimes: ").Append(ExecuteTimes).Append("\n");
            sb.Append("  avgRowsExamined: ").Append(AvgRowsExamined).Append("\n");
            sb.Append("  maxTime: ").Append(MaxTime).Append("\n");
            sb.Append("  avgTime: ").Append(AvgTime).Append("\n");
            sb.Append("  maxRowsExamined: ").Append(MaxRowsExamined).Append("\n");
            sb.Append("  rowsExaminedSum: ").Append(RowsExaminedSum).Append("\n");
            sb.Append("  costTimeSum: ").Append(CostTimeSum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ESDBSlowSqlTemplateItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ESDBSlowSqlTemplateItem input)
        {
            if (input == null) return false;
            if (this.QuerySample != input.QuerySample || (this.QuerySample != null && !this.QuerySample.Equals(input.QuerySample))) return false;
            if (this.Database != input.Database || (this.Database != null && !this.Database.Equals(input.Database))) return false;
            if (this.ExecuteTimes != input.ExecuteTimes || (this.ExecuteTimes != null && !this.ExecuteTimes.Equals(input.ExecuteTimes))) return false;
            if (this.AvgRowsExamined != input.AvgRowsExamined || (this.AvgRowsExamined != null && !this.AvgRowsExamined.Equals(input.AvgRowsExamined))) return false;
            if (this.MaxTime != input.MaxTime || (this.MaxTime != null && !this.MaxTime.Equals(input.MaxTime))) return false;
            if (this.AvgTime != input.AvgTime || (this.AvgTime != null && !this.AvgTime.Equals(input.AvgTime))) return false;
            if (this.MaxRowsExamined != input.MaxRowsExamined || (this.MaxRowsExamined != null && !this.MaxRowsExamined.Equals(input.MaxRowsExamined))) return false;
            if (this.RowsExaminedSum != input.RowsExaminedSum || (this.RowsExaminedSum != null && !this.RowsExaminedSum.Equals(input.RowsExaminedSum))) return false;
            if (this.CostTimeSum != input.CostTimeSum || (this.CostTimeSum != null && !this.CostTimeSum.Equals(input.CostTimeSum))) return false;

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
                if (this.QuerySample != null) hashCode = hashCode * 59 + this.QuerySample.GetHashCode();
                if (this.Database != null) hashCode = hashCode * 59 + this.Database.GetHashCode();
                if (this.ExecuteTimes != null) hashCode = hashCode * 59 + this.ExecuteTimes.GetHashCode();
                if (this.AvgRowsExamined != null) hashCode = hashCode * 59 + this.AvgRowsExamined.GetHashCode();
                if (this.MaxTime != null) hashCode = hashCode * 59 + this.MaxTime.GetHashCode();
                if (this.AvgTime != null) hashCode = hashCode * 59 + this.AvgTime.GetHashCode();
                if (this.MaxRowsExamined != null) hashCode = hashCode * 59 + this.MaxRowsExamined.GetHashCode();
                if (this.RowsExaminedSum != null) hashCode = hashCode * 59 + this.RowsExaminedSum.GetHashCode();
                if (this.CostTimeSum != null) hashCode = hashCode * 59 + this.CostTimeSum.GetHashCode();
                return hashCode;
            }
        }
    }
}
