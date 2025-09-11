using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Smn.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BatchDeleteSubscriptionsRequestBody 
    {

        /// <summary>
        /// 订阅者信息列表。
        /// </summary>
        [JsonProperty("subscription_urns", NullValueHandling = NullValueHandling.Ignore)]
        public List<BatchDeleteSubscriptionsRequestItemInfo> SubscriptionUrns { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteSubscriptionsRequestBody {\n");
            sb.Append("  subscriptionUrns: ").Append(SubscriptionUrns).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteSubscriptionsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteSubscriptionsRequestBody input)
        {
            if (input == null) return false;
            if (this.SubscriptionUrns != input.SubscriptionUrns || (this.SubscriptionUrns != null && input.SubscriptionUrns != null && !this.SubscriptionUrns.SequenceEqual(input.SubscriptionUrns))) return false;

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
                if (this.SubscriptionUrns != null) hashCode = hashCode * 59 + this.SubscriptionUrns.GetHashCode();
                return hashCode;
            }
        }
    }
}
