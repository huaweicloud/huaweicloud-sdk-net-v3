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
    public class BatchUpdateOneClickAlarmsEnabledStateRequest 
    {

        /// <summary>
        /// 一键告警ID
        /// </summary>
        [SDKProperty("one_click_alarm_id", IsPath = true)]
        [JsonProperty("one_click_alarm_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OneClickAlarmId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public BatchEnableAlarmsRequestBody Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchUpdateOneClickAlarmsEnabledStateRequest {\n");
            sb.Append("  oneClickAlarmId: ").Append(OneClickAlarmId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchUpdateOneClickAlarmsEnabledStateRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchUpdateOneClickAlarmsEnabledStateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OneClickAlarmId == input.OneClickAlarmId ||
                    (this.OneClickAlarmId != null &&
                    this.OneClickAlarmId.Equals(input.OneClickAlarmId))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
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
                if (this.OneClickAlarmId != null)
                    hashCode = hashCode * 59 + this.OneClickAlarmId.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
