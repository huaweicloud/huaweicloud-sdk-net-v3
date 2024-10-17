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
    /// - 开启/关闭sql限流参数体。
    /// </summary>
    public class OperateSqlFilterRuleReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sql_filter_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<NodeSqlFilterRuleInfo> SqlFilterRules { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperateSqlFilterRuleReq {\n");
            sb.Append("  sqlFilterRules: ").Append(SqlFilterRules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OperateSqlFilterRuleReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OperateSqlFilterRuleReq input)
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
