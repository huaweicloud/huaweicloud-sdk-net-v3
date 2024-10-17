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
    /// SQL限流规则。
    /// </summary>
    public class SqlFilterRule 
    {

        /// <summary>
        /// Sql限流类型。  取值范围： - SELECT - UPDATE - DELETE
        /// </summary>
        [JsonProperty("sql_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlType { get; set; }

        /// <summary>
        /// SQL限流具体规则。
        /// </summary>
        [JsonProperty("patterns", NullValueHandling = NullValueHandling.Ignore)]
        public List<SqlFilterRulePattern> Patterns { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SqlFilterRule {\n");
            sb.Append("  sqlType: ").Append(SqlType).Append("\n");
            sb.Append("  patterns: ").Append(Patterns).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SqlFilterRule);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SqlFilterRule input)
        {
            if (input == null) return false;
            if (this.SqlType != input.SqlType || (this.SqlType != null && !this.SqlType.Equals(input.SqlType))) return false;
            if (this.Patterns != input.Patterns || (this.Patterns != null && input.Patterns != null && !this.Patterns.SequenceEqual(input.Patterns))) return false;

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
                if (this.SqlType != null) hashCode = hashCode * 59 + this.SqlType.GetHashCode();
                if (this.Patterns != null) hashCode = hashCode * 59 + this.Patterns.GetHashCode();
                return hashCode;
            }
        }
    }
}
