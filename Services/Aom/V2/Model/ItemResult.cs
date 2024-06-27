using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ItemResult 
    {

        /// <summary>
        /// 告警规则名称。
        /// </summary>
        [JsonProperty("alarm_rule_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmRuleName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemResult {\n");
            sb.Append("  alarmRuleName: ").Append(AlarmRuleName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ItemResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ItemResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AlarmRuleName == input.AlarmRuleName ||
                    (this.AlarmRuleName != null &&
                    this.AlarmRuleName.Equals(input.AlarmRuleName))
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
                if (this.AlarmRuleName != null)
                    hashCode = hashCode * 59 + this.AlarmRuleName.GetHashCode();
                return hashCode;
            }
        }
    }
}
