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
    public class AddSubscriptionFromSubscriptionUserResponse : SdkResponse
    {

        /// <summary>
        /// 添加订阅返回结果。
        /// </summary>
        [JsonProperty("subscriptions_result", NullValueHandling = NullValueHandling.Ignore)]
        public List<AddSubscriptionFromSubscriptionUserResponseItem> SubscriptionsResult { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddSubscriptionFromSubscriptionUserResponse {\n");
            sb.Append("  subscriptionsResult: ").Append(SubscriptionsResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddSubscriptionFromSubscriptionUserResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddSubscriptionFromSubscriptionUserResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SubscriptionsResult == input.SubscriptionsResult ||
                    this.SubscriptionsResult != null &&
                    input.SubscriptionsResult != null &&
                    this.SubscriptionsResult.SequenceEqual(input.SubscriptionsResult)
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
                if (this.SubscriptionsResult != null)
                    hashCode = hashCode * 59 + this.SubscriptionsResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
