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
    /// 给发布创建订阅时需要的参数。
    /// </summary>
    public class CreateSubscription4PublicationInfo 
    {

        /// <summary>
        /// 订阅服务器来源为云上实例时的订阅实例id。
        /// </summary>
        [JsonProperty("subscription_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriptionInstanceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("user_info", NullValueHandling = NullValueHandling.Ignore)]
        public ReplicationUserInfo UserInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSubscription4PublicationInfo {\n");
            sb.Append("  subscriptionInstanceId: ").Append(SubscriptionInstanceId).Append("\n");
            sb.Append("  userInfo: ").Append(UserInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSubscription4PublicationInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSubscription4PublicationInfo input)
        {
            if (input == null) return false;
            if (this.SubscriptionInstanceId != input.SubscriptionInstanceId || (this.SubscriptionInstanceId != null && !this.SubscriptionInstanceId.Equals(input.SubscriptionInstanceId))) return false;
            if (this.UserInfo != input.UserInfo || (this.UserInfo != null && !this.UserInfo.Equals(input.UserInfo))) return false;

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
                if (this.SubscriptionInstanceId != null) hashCode = hashCode * 59 + this.SubscriptionInstanceId.GetHashCode();
                if (this.UserInfo != null) hashCode = hashCode * 59 + this.UserInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
