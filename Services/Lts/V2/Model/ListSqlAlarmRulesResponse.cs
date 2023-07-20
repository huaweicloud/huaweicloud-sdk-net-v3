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
    public class ListSqlAlarmRulesResponse : SdkResponse
    {

        /// <summary>
        /// SQL告警
        /// </summary>
        [JsonProperty("sql_alarm_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<SqlAlarmRuleRespList> SqlAlarmRules { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSqlAlarmRulesResponse {\n");
            sb.Append("  sqlAlarmRules: ").Append(SqlAlarmRules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSqlAlarmRulesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSqlAlarmRulesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SqlAlarmRules == input.SqlAlarmRules ||
                    this.SqlAlarmRules != null &&
                    input.SqlAlarmRules != null &&
                    this.SqlAlarmRules.SequenceEqual(input.SqlAlarmRules)
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
                if (this.SqlAlarmRules != null)
                    hashCode = hashCode * 59 + this.SqlAlarmRules.GetHashCode();
                return hashCode;
            }
        }
    }
}
