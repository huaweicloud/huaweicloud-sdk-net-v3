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
    /// Request Object
    /// </summary>
    public class CancelSubscriptionRequest 
    {

        /// <summary>
        /// 订阅者的唯一的资源标识，可通过[查询订阅者列表](ListSubscriptions.xml)获取该标识。
        /// </summary>
        [SDKProperty("subscription_urn", IsPath = true)]
        [JsonProperty("subscription_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriptionUrn { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CancelSubscriptionRequest {\n");
            sb.Append("  subscriptionUrn: ").Append(SubscriptionUrn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CancelSubscriptionRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CancelSubscriptionRequest input)
        {
            if (input == null) return false;
            if (this.SubscriptionUrn != input.SubscriptionUrn || (this.SubscriptionUrn != null && !this.SubscriptionUrn.Equals(input.SubscriptionUrn))) return false;

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
                return hashCode;
            }
        }
    }
}
