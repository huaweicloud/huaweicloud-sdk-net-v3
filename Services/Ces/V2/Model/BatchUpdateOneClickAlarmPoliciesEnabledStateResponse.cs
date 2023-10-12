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
    public class BatchUpdateOneClickAlarmPoliciesEnabledStateResponse : SdkResponse
    {

        /// <summary>
        /// 成功启停的告警规则策略ID列表
        /// </summary>
        [JsonProperty("alarm_policy_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AlarmPolicyIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchUpdateOneClickAlarmPoliciesEnabledStateResponse {\n");
            sb.Append("  alarmPolicyIds: ").Append(AlarmPolicyIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchUpdateOneClickAlarmPoliciesEnabledStateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchUpdateOneClickAlarmPoliciesEnabledStateResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AlarmPolicyIds == input.AlarmPolicyIds ||
                    this.AlarmPolicyIds != null &&
                    input.AlarmPolicyIds != null &&
                    this.AlarmPolicyIds.SequenceEqual(input.AlarmPolicyIds)
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
                if (this.AlarmPolicyIds != null)
                    hashCode = hashCode * 59 + this.AlarmPolicyIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
