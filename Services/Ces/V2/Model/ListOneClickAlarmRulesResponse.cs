using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListOneClickAlarmRulesResponse : SdkResponse
    {

        /// <summary>
        /// 告警规则列表
        /// </summary>
        [JsonProperty("alarms", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListAlarmsRespAlarms> Alarms { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListOneClickAlarmRulesResponse {\n");
            sb.Append("  alarms: ").Append(Alarms).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListOneClickAlarmRulesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListOneClickAlarmRulesResponse input)
        {
            if (input == null) return false;
            if (this.Alarms != input.Alarms || (this.Alarms != null && input.Alarms != null && !this.Alarms.SequenceEqual(input.Alarms))) return false;

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
                if (this.Alarms != null) hashCode = hashCode * 59 + this.Alarms.GetHashCode();
                return hashCode;
            }
        }
    }
}
