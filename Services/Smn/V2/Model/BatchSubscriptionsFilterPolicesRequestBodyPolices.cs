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
    public class BatchSubscriptionsFilterPolicesRequestBodyPolices 
    {

        /// <summary>
        /// 订阅者的唯一的资源标识，可通过[查询订阅者列表](ListSubscriptions.xml)获取该标识。
        /// </summary>
        [JsonProperty("subscription_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriptionUrn { get; set; }

        /// <summary>
        /// 订阅者的过滤策略。策略name不能重复
        /// </summary>
        [JsonProperty("filter_polices", NullValueHandling = NullValueHandling.Ignore)]
        public List<SubscriptionsFilterPolicy> FilterPolices { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchSubscriptionsFilterPolicesRequestBodyPolices {\n");
            sb.Append("  subscriptionUrn: ").Append(SubscriptionUrn).Append("\n");
            sb.Append("  filterPolices: ").Append(FilterPolices).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchSubscriptionsFilterPolicesRequestBodyPolices);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchSubscriptionsFilterPolicesRequestBodyPolices input)
        {
            if (input == null) return false;
            if (this.SubscriptionUrn != input.SubscriptionUrn || (this.SubscriptionUrn != null && !this.SubscriptionUrn.Equals(input.SubscriptionUrn))) return false;
            if (this.FilterPolices != input.FilterPolices || (this.FilterPolices != null && input.FilterPolices != null && !this.FilterPolices.SequenceEqual(input.FilterPolices))) return false;

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
                if (this.SubscriptionUrn != null) hashCode = hashCode * 59 + this.SubscriptionUrn.GetHashCode();
                if (this.FilterPolices != null) hashCode = hashCode * 59 + this.FilterPolices.GetHashCode();
                return hashCode;
            }
        }
    }
}
