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
    /// Response Object
    /// </summary>
    public class ShowHistoricalSqlFilterRuleResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  历史SQL限流规则。
        /// </summary>
        [JsonProperty("sql_filter_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<HistoricalSqlFilterRule> SqlFilterRules { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowHistoricalSqlFilterRuleResponse {\n");
            sb.Append("  sqlFilterRules: ").Append(SqlFilterRules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowHistoricalSqlFilterRuleResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowHistoricalSqlFilterRuleResponse input)
        {
            if (input == null) return false;
            if (this.SqlFilterRules != input.SqlFilterRules || (this.SqlFilterRules != null && input.SqlFilterRules != null && !this.SqlFilterRules.SequenceEqual(input.SqlFilterRules))) return false;

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
                if (this.SqlFilterRules != null) hashCode = hashCode * 59 + this.SqlFilterRules.GetHashCode();
                return hashCode;
            }
        }
    }
}
