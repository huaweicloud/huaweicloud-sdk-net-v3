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
    /// **参数解释**：  开启自治限流规则请求体。  **约束限制**：  不涉及。
    /// </summary>
    public class SetAutoSqlLimitingReq 
    {

        /// <summary>
        /// **参数解释**：  开启自治限流规则。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("auto_sql_limiting_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<AutoSqlLimitingRule> AutoSqlLimitingRules { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetAutoSqlLimitingReq {\n");
            sb.Append("  autoSqlLimitingRules: ").Append(AutoSqlLimitingRules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetAutoSqlLimitingReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetAutoSqlLimitingReq input)
        {
            if (input == null) return false;
            if (this.AutoSqlLimitingRules != input.AutoSqlLimitingRules || (this.AutoSqlLimitingRules != null && input.AutoSqlLimitingRules != null && !this.AutoSqlLimitingRules.SequenceEqual(input.AutoSqlLimitingRules))) return false;

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
                if (this.AutoSqlLimitingRules != null) hashCode = hashCode * 59 + this.AutoSqlLimitingRules.GetHashCode();
                return hashCode;
            }
        }
    }
}
