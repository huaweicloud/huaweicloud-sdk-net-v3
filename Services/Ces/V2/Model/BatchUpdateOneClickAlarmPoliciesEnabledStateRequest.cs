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
    /// Request Object
    /// </summary>
    public class BatchUpdateOneClickAlarmPoliciesEnabledStateRequest 
    {

        /// <summary>
        /// 一键告警ID
        /// </summary>
        [SDKProperty("one_click_alarm_id", IsPath = true)]
        [JsonProperty("one_click_alarm_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OneClickAlarmId { get; set; }

        /// <summary>
        /// 告警规则ID
        /// </summary>
        [SDKProperty("alarm_id", IsPath = true)]
        [JsonProperty("alarm_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public BatchEnableAlarmPoliciesRequestBody Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchUpdateOneClickAlarmPoliciesEnabledStateRequest {\n");
            sb.Append("  oneClickAlarmId: ").Append(OneClickAlarmId).Append("\n");
            sb.Append("  alarmId: ").Append(AlarmId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchUpdateOneClickAlarmPoliciesEnabledStateRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchUpdateOneClickAlarmPoliciesEnabledStateRequest input)
        {
            if (input == null) return false;
            if (this.OneClickAlarmId != input.OneClickAlarmId || (this.OneClickAlarmId != null && !this.OneClickAlarmId.Equals(input.OneClickAlarmId))) return false;
            if (this.AlarmId != input.AlarmId || (this.AlarmId != null && !this.AlarmId.Equals(input.AlarmId))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

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
                if (this.OneClickAlarmId != null) hashCode = hashCode * 59 + this.OneClickAlarmId.GetHashCode();
                if (this.AlarmId != null) hashCode = hashCode * 59 + this.AlarmId.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
