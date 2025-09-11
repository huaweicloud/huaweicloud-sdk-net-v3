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
    /// Response Object
    /// </summary>
    public class BatchDeleteSubscriptionsByTopicResponse : SdkResponse
    {

        /// <summary>
        /// 取消订阅结果列表。
        /// </summary>
        [JsonProperty("subscriptions_result", NullValueHandling = NullValueHandling.Ignore)]
        public List<BatchDeleteSubscriptionsResponseItemInfo> SubscriptionsResult { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteSubscriptionsByTopicResponse {\n");
            sb.Append("  subscriptionsResult: ").Append(SubscriptionsResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteSubscriptionsByTopicResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteSubscriptionsByTopicResponse input)
        {
            if (input == null) return false;
            if (this.SubscriptionsResult != input.SubscriptionsResult || (this.SubscriptionsResult != null && input.SubscriptionsResult != null && !this.SubscriptionsResult.SequenceEqual(input.SubscriptionsResult))) return false;

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
                if (this.SubscriptionsResult != null) hashCode = hashCode * 59 + this.SubscriptionsResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
