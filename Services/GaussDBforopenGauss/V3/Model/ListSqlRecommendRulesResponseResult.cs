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
    public class ListSqlRecommendRulesResponseResult 
    {

        /// <summary>
        /// **参数解释**: 推荐类型。 **取值范围**: - all：全部 - exec_count：执行次数 - avg_exec_time：平均执行时间 - max_exec_time：最大执行时间
        /// </summary>
        [JsonProperty("recommend_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RecommendType { get; set; }

        /// <summary>
        /// **参数解释**: SQL ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("sql_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlId { get; set; }

        /// <summary>
        /// **参数解释**: SQL模板。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("sql_model", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlModel { get; set; }

        /// <summary>
        /// **参数解释**: SQL关键字。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("sql_keyword", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlKeyword { get; set; }

        /// <summary>
        /// **参数解释**: SQL类型。 **取值范围**: - SELECT - INSERT - UPDATE - DELETE - MERGE - OTHER
        /// </summary>
        [JsonProperty("sql_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlType { get; set; }

        /// <summary>
        /// **参数解释**: 数据库名称。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("database", NullValueHandling = NullValueHandling.Ignore)]
        public string Database { get; set; }

        /// <summary>
        /// **参数解释**: 平均执行时间。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("avg_exec_time", NullValueHandling = NullValueHandling.Ignore)]
        public double? AvgExecTime { get; set; }

        /// <summary>
        /// **参数解释**: 最长执行时间。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("max_exec_time", NullValueHandling = NullValueHandling.Ignore)]
        public double? MaxExecTime { get; set; }

        /// <summary>
        /// **参数解释**: 执行次数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("exec_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExecCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSqlRecommendRulesResponseResult {\n");
            sb.Append("  recommendType: ").Append(RecommendType).Append("\n");
            sb.Append("  sqlId: ").Append(SqlId).Append("\n");
            sb.Append("  sqlModel: ").Append(SqlModel).Append("\n");
            sb.Append("  sqlKeyword: ").Append(SqlKeyword).Append("\n");
            sb.Append("  sqlType: ").Append(SqlType).Append("\n");
            sb.Append("  database: ").Append(Database).Append("\n");
            sb.Append("  avgExecTime: ").Append(AvgExecTime).Append("\n");
            sb.Append("  maxExecTime: ").Append(MaxExecTime).Append("\n");
            sb.Append("  execCount: ").Append(ExecCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSqlRecommendRulesResponseResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSqlRecommendRulesResponseResult input)
        {
            if (input == null) return false;
            if (this.RecommendType != input.RecommendType || (this.RecommendType != null && !this.RecommendType.Equals(input.RecommendType))) return false;
            if (this.SqlId != input.SqlId || (this.SqlId != null && !this.SqlId.Equals(input.SqlId))) return false;
            if (this.SqlModel != input.SqlModel || (this.SqlModel != null && !this.SqlModel.Equals(input.SqlModel))) return false;
            if (this.SqlKeyword != input.SqlKeyword || (this.SqlKeyword != null && !this.SqlKeyword.Equals(input.SqlKeyword))) return false;
            if (this.SqlType != input.SqlType || (this.SqlType != null && !this.SqlType.Equals(input.SqlType))) return false;
            if (this.Database != input.Database || (this.Database != null && !this.Database.Equals(input.Database))) return false;
            if (this.AvgExecTime != input.AvgExecTime || (this.AvgExecTime != null && !this.AvgExecTime.Equals(input.AvgExecTime))) return false;
            if (this.MaxExecTime != input.MaxExecTime || (this.MaxExecTime != null && !this.MaxExecTime.Equals(input.MaxExecTime))) return false;
            if (this.ExecCount != input.ExecCount || (this.ExecCount != null && !this.ExecCount.Equals(input.ExecCount))) return false;

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
                if (this.RecommendType != null) hashCode = hashCode * 59 + this.RecommendType.GetHashCode();
                if (this.SqlId != null) hashCode = hashCode * 59 + this.SqlId.GetHashCode();
                if (this.SqlModel != null) hashCode = hashCode * 59 + this.SqlModel.GetHashCode();
                if (this.SqlKeyword != null) hashCode = hashCode * 59 + this.SqlKeyword.GetHashCode();
                if (this.SqlType != null) hashCode = hashCode * 59 + this.SqlType.GetHashCode();
                if (this.Database != null) hashCode = hashCode * 59 + this.Database.GetHashCode();
                if (this.AvgExecTime != null) hashCode = hashCode * 59 + this.AvgExecTime.GetHashCode();
                if (this.MaxExecTime != null) hashCode = hashCode * 59 + this.MaxExecTime.GetHashCode();
                if (this.ExecCount != null) hashCode = hashCode * 59 + this.ExecCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
