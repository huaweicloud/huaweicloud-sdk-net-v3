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
    /// 发布下的订阅信息。
    /// </summary>
    public class Subscription4PublicationInfo 
    {

        /// <summary>
        /// 订阅服务器名称。
        /// </summary>
        [JsonProperty("subscription_instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriptionInstanceName { get; set; }

        /// <summary>
        /// 订阅服务器ip。
        /// </summary>
        [JsonProperty("subscription_instance_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriptionInstanceIp { get; set; }

        /// <summary>
        /// 订阅实例id。
        /// </summary>
        [JsonProperty("subscription_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriptionInstanceId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Subscription4PublicationInfo {\n");
            sb.Append("  subscriptionInstanceName: ").Append(SubscriptionInstanceName).Append("\n");
            sb.Append("  subscriptionInstanceIp: ").Append(SubscriptionInstanceIp).Append("\n");
            sb.Append("  subscriptionInstanceId: ").Append(SubscriptionInstanceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Subscription4PublicationInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Subscription4PublicationInfo input)
        {
            if (input == null) return false;
            if (this.SubscriptionInstanceName != input.SubscriptionInstanceName || (this.SubscriptionInstanceName != null && !this.SubscriptionInstanceName.Equals(input.SubscriptionInstanceName))) return false;
            if (this.SubscriptionInstanceIp != input.SubscriptionInstanceIp || (this.SubscriptionInstanceIp != null && !this.SubscriptionInstanceIp.Equals(input.SubscriptionInstanceIp))) return false;
            if (this.SubscriptionInstanceId != input.SubscriptionInstanceId || (this.SubscriptionInstanceId != null && !this.SubscriptionInstanceId.Equals(input.SubscriptionInstanceId))) return false;

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
                if (this.SubscriptionInstanceName != null) hashCode = hashCode * 59 + this.SubscriptionInstanceName.GetHashCode();
                if (this.SubscriptionInstanceIp != null) hashCode = hashCode * 59 + this.SubscriptionInstanceIp.GetHashCode();
                if (this.SubscriptionInstanceId != null) hashCode = hashCode * 59 + this.SubscriptionInstanceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
