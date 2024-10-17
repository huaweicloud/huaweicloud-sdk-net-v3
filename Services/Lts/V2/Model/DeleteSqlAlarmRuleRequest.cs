using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteSqlAlarmRuleRequest 
    {

        /// <summary>
        /// Sql告警规则id
        /// </summary>
        [SDKProperty("sql_alarm_rule_id", IsPath = true)]
        [JsonProperty("sql_alarm_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlAlarmRuleId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteSqlAlarmRuleRequest {\n");
            sb.Append("  sqlAlarmRuleId: ").Append(SqlAlarmRuleId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteSqlAlarmRuleRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteSqlAlarmRuleRequest input)
        {
            if (input == null) return false;
            if (this.SqlAlarmRuleId != input.SqlAlarmRuleId || (this.SqlAlarmRuleId != null && !this.SqlAlarmRuleId.Equals(input.SqlAlarmRuleId))) return false;

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
                if (this.SqlAlarmRuleId != null) hashCode = hashCode * 59 + this.SqlAlarmRuleId.GetHashCode();
                return hashCode;
            }
        }
    }
}
