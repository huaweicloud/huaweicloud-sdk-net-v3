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
    /// Response Object
    /// </summary>
    public class CreateSqlAlarmRuleResponse : SdkResponse
    {

        /// <summary>
        /// 告警规则id
        /// </summary>
        [JsonProperty("sql_alarm_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlAlarmRuleId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSqlAlarmRuleResponse {\n");
            sb.Append("  sqlAlarmRuleId: ").Append(SqlAlarmRuleId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSqlAlarmRuleResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSqlAlarmRuleResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SqlAlarmRuleId == input.SqlAlarmRuleId ||
                    (this.SqlAlarmRuleId != null &&
                    this.SqlAlarmRuleId.Equals(input.SqlAlarmRuleId))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.SqlAlarmRuleId != null)
                    hashCode = hashCode * 59 + this.SqlAlarmRuleId.GetHashCode();
                return hashCode;
            }
        }
    }
}
