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
    /// 创建发布详情。
    /// </summary>
    public class CreateSubscriptionRequestBody 
    {

        /// <summary>
        /// 订阅详情。一次最多创建十个订阅。
        /// </summary>
        [JsonProperty("subscriptions", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateSubscriptionInfo> Subscriptions { get; set; }

        /// <summary>
        /// 给发布创建订阅时的发布id。给发布创建订阅时必传，不传时则为创建本地订阅。
        /// </summary>
        [JsonProperty("current_publication_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentPublicationId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSubscriptionRequestBody {\n");
            sb.Append("  subscriptions: ").Append(Subscriptions).Append("\n");
            sb.Append("  currentPublicationId: ").Append(CurrentPublicationId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSubscriptionRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSubscriptionRequestBody input)
        {
            if (input == null) return false;
            if (this.Subscriptions != input.Subscriptions || (this.Subscriptions != null && input.Subscriptions != null && !this.Subscriptions.SequenceEqual(input.Subscriptions))) return false;
            if (this.CurrentPublicationId != input.CurrentPublicationId || (this.CurrentPublicationId != null && !this.CurrentPublicationId.Equals(input.CurrentPublicationId))) return false;

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
                if (this.Subscriptions != null) hashCode = hashCode * 59 + this.Subscriptions.GetHashCode();
                if (this.CurrentPublicationId != null) hashCode = hashCode * 59 + this.CurrentPublicationId.GetHashCode();
                return hashCode;
            }
        }
    }
}
