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
    /// 删除订阅。
    /// </summary>
    public class DeleteSubscriptionRequestBody 
    {

        /// <summary>
        /// 删除的订阅id列表。每次删除的订阅必须属于同一实例。
        /// </summary>
        [JsonProperty("subscription_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SubscriptionIds { get; set; }

        /// <summary>
        /// 清理订阅配置。默认为false。  true：清理。 false：不清理。
        /// </summary>
        [JsonProperty("clean_subscription", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CleanSubscription { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteSubscriptionRequestBody {\n");
            sb.Append("  subscriptionIds: ").Append(SubscriptionIds).Append("\n");
            sb.Append("  cleanSubscription: ").Append(CleanSubscription).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteSubscriptionRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteSubscriptionRequestBody input)
        {
            if (input == null) return false;
            if (this.SubscriptionIds != input.SubscriptionIds || (this.SubscriptionIds != null && input.SubscriptionIds != null && !this.SubscriptionIds.SequenceEqual(input.SubscriptionIds))) return false;
            if (this.CleanSubscription != input.CleanSubscription || (this.CleanSubscription != null && !this.CleanSubscription.Equals(input.CleanSubscription))) return false;

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
                if (this.CleanSubscription != null) hashCode = hashCode * 59 + this.CleanSubscription.GetHashCode();
                return hashCode;
            }
        }
    }
}
