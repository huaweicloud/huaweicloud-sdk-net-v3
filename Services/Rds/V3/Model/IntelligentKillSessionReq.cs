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
    /// 一键自动kill会话请求体
    /// </summary>
    public class IntelligentKillSessionReq 
    {

        /// <summary>
        /// 是否自动SQL限流
        /// </summary>
        [JsonProperty("auto_add_sql_limit_rule", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoAddSqlLimitRule { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntelligentKillSessionReq {\n");
            sb.Append("  autoAddSqlLimitRule: ").Append(AutoAddSqlLimitRule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IntelligentKillSessionReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IntelligentKillSessionReq input)
        {
            if (input == null) return false;
            if (this.AutoAddSqlLimitRule != input.AutoAddSqlLimitRule || (this.AutoAddSqlLimitRule != null && !this.AutoAddSqlLimitRule.Equals(input.AutoAddSqlLimitRule))) return false;

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
                if (this.AutoAddSqlLimitRule != null) hashCode = hashCode * 59 + this.AutoAddSqlLimitRule.GetHashCode();
                return hashCode;
            }
        }
    }
}
