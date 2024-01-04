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
    public class BatchDeleteSubscriptionsFilterPolicesRequestBody 
    {

        /// <summary>
        /// 订阅者的唯一的资源标识，可通过[查询订阅者列表](ListSubscriptions.xml)获取该标识。
        /// </summary>
        [JsonProperty("subscription_urns", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SubscriptionUrns { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteSubscriptionsFilterPolicesRequestBody {\n");
            sb.Append("  subscriptionUrns: ").Append(SubscriptionUrns).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteSubscriptionsFilterPolicesRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteSubscriptionsFilterPolicesRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SubscriptionUrns == input.SubscriptionUrns ||
                    this.SubscriptionUrns != null &&
                    input.SubscriptionUrns != null &&
                    this.SubscriptionUrns.SequenceEqual(input.SubscriptionUrns)
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
                if (this.SubscriptionUrns != null)
                    hashCode = hashCode * 59 + this.SubscriptionUrns.GetHashCode();
                return hashCode;
            }
        }
    }
}
