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
    public class UpdateAlarmRulePoliciesRequest 
    {

        /// <summary>
        /// **参数解释**： 告警规则ID。 **约束限制**： 不涉及。 **取值范围**： 以al开头，只能由大写字母、小写字母、数字组成，且长度为24个字符。           **默认取值**： 不涉及。 
        /// </summary>
        [SDKProperty("alarm_id", IsPath = true)]
        [JsonProperty("alarm_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateAlarmRulePoliciesReqBodyV2 Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAlarmRulePoliciesRequest {\n");
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
            return this.Equals(input as UpdateAlarmRulePoliciesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateAlarmRulePoliciesRequest input)
        {
            if (input == null) return false;
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
                if (this.AlarmId != null) hashCode = hashCode * 59 + this.AlarmId.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
