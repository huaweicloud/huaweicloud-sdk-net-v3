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
    /// 修改订阅详情。
    /// </summary>
    public class ModifySubscriptionsRequestBody 
    {

        /// <summary>
        /// 修改的订阅id列表。每次修改的订阅必须属于同一实例。
        /// </summary>
        [JsonProperty("subscription_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SubscriptionIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("job_schedule", NullValueHandling = NullValueHandling.Ignore)]
        public OperateUsedJobSchedule JobSchedule { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifySubscriptionsRequestBody {\n");
            sb.Append("  subscriptionIds: ").Append(SubscriptionIds).Append("\n");
            sb.Append("  jobSchedule: ").Append(JobSchedule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifySubscriptionsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifySubscriptionsRequestBody input)
        {
            if (input == null) return false;
            if (this.SubscriptionIds != input.SubscriptionIds || (this.SubscriptionIds != null && input.SubscriptionIds != null && !this.SubscriptionIds.SequenceEqual(input.SubscriptionIds))) return false;
            if (this.JobSchedule != input.JobSchedule || (this.JobSchedule != null && !this.JobSchedule.Equals(input.JobSchedule))) return false;

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
                if (this.SubscriptionIds != null) hashCode = hashCode * 59 + this.SubscriptionIds.GetHashCode();
                if (this.JobSchedule != null) hashCode = hashCode * 59 + this.JobSchedule.GetHashCode();
                return hashCode;
            }
        }
    }
}
