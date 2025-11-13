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
    /// 订阅详情。
    /// </summary>
    public class ListSubscriptionInfo 
    {

        /// <summary>
        /// 订阅id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 订阅状态。normal，abnormal，creating，createfail
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 发布id。
        /// </summary>
        [JsonProperty("publication_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicationId { get; set; }

        /// <summary>
        /// 发布名称。
        /// </summary>
        [JsonProperty("publication_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicationName { get; set; }

        /// <summary>
        /// 订阅服务器来源。true：订阅服务器为云上实例, false：订阅服务器非云上实例。
        /// </summary>
        [JsonProperty("is_cloud", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCloud { get; set; }

        /// <summary>
        /// 目标数据库名。
        /// </summary>
        [JsonProperty("subscription_database", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriptionDatabase { get; set; }

        /// <summary>
        /// 订阅方式，push:推送。
        /// </summary>
        [JsonProperty("subscription_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriptionType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("publication_subscription", NullValueHandling = NullValueHandling.Ignore)]
        public Subscription4PublicationInfo PublicationSubscription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("local_subscription", NullValueHandling = NullValueHandling.Ignore)]
        public Subscription4InstanceInfo LocalSubscription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("job_schedule", NullValueHandling = NullValueHandling.Ignore)]
        public UsedJobSchedule JobSchedule { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSubscriptionInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  publicationId: ").Append(PublicationId).Append("\n");
            sb.Append("  publicationName: ").Append(PublicationName).Append("\n");
            sb.Append("  isCloud: ").Append(IsCloud).Append("\n");
            sb.Append("  subscriptionDatabase: ").Append(SubscriptionDatabase).Append("\n");
            sb.Append("  subscriptionType: ").Append(SubscriptionType).Append("\n");
            sb.Append("  publicationSubscription: ").Append(PublicationSubscription).Append("\n");
            sb.Append("  localSubscription: ").Append(LocalSubscription).Append("\n");
            sb.Append("  jobSchedule: ").Append(JobSchedule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSubscriptionInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSubscriptionInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.PublicationId != input.PublicationId || (this.PublicationId != null && !this.PublicationId.Equals(input.PublicationId))) return false;
            if (this.PublicationName != input.PublicationName || (this.PublicationName != null && !this.PublicationName.Equals(input.PublicationName))) return false;
            if (this.IsCloud != input.IsCloud || (this.IsCloud != null && !this.IsCloud.Equals(input.IsCloud))) return false;
            if (this.SubscriptionDatabase != input.SubscriptionDatabase || (this.SubscriptionDatabase != null && !this.SubscriptionDatabase.Equals(input.SubscriptionDatabase))) return false;
            if (this.SubscriptionType != input.SubscriptionType || (this.SubscriptionType != null && !this.SubscriptionType.Equals(input.SubscriptionType))) return false;
            if (this.PublicationSubscription != input.PublicationSubscription || (this.PublicationSubscription != null && !this.PublicationSubscription.Equals(input.PublicationSubscription))) return false;
            if (this.LocalSubscription != input.LocalSubscription || (this.LocalSubscription != null && !this.LocalSubscription.Equals(input.LocalSubscription))) return false;
            if (this.JobSchedule != input.JobSchedule || (this.JobSchedule != null && !this.JobSchedule.Equals(input.JobSchedule))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.PublicationId != null) hashCode = hashCode * 59 + this.PublicationId.GetHashCode();
                if (this.PublicationName != null) hashCode = hashCode * 59 + this.PublicationName.GetHashCode();
                if (this.IsCloud != null) hashCode = hashCode * 59 + this.IsCloud.GetHashCode();
                if (this.SubscriptionDatabase != null) hashCode = hashCode * 59 + this.SubscriptionDatabase.GetHashCode();
                if (this.SubscriptionType != null) hashCode = hashCode * 59 + this.SubscriptionType.GetHashCode();
                if (this.PublicationSubscription != null) hashCode = hashCode * 59 + this.PublicationSubscription.GetHashCode();
                if (this.LocalSubscription != null) hashCode = hashCode * 59 + this.LocalSubscription.GetHashCode();
                if (this.JobSchedule != null) hashCode = hashCode * 59 + this.JobSchedule.GetHashCode();
                return hashCode;
            }
        }
    }
}
