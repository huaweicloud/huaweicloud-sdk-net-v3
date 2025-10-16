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
    /// 订阅详情
    /// </summary>
    public class CreateSubscriptionInfo 
    {

        /// <summary>
        /// 订阅数据库名。
        /// </summary>
        [JsonProperty("subscription_database", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriptionDatabase { get; set; }

        /// <summary>
        /// 订阅方式，push:推送。
        /// </summary>
        [JsonProperty("subscription_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriptionType { get; set; }

        /// <summary>
        /// 初始化类型：不初始化(do_not)、立即初始化(immediate)、首次同步初始化(at_first_sync)。
        /// </summary>
        [JsonProperty("initialize_at", NullValueHandling = NullValueHandling.Ignore)]
        public string InitializeAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("initialize_info", NullValueHandling = NullValueHandling.Ignore)]
        public CreateSubscriptionInfoInitializeInfo InitializeInfo { get; set; }

        /// <summary>
        /// 独立的分发代理。  true：使用。 false：不使用。
        /// </summary>
        [JsonProperty("independent_agent", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IndependentAgent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("job_schedule", NullValueHandling = NullValueHandling.Ignore)]
        public OperateUsedJobSchedule JobSchedule { get; set; }

        /// <summary>
        /// 备份文件名称。若该值不为空，则订阅初始化方式为通过备份文件初始化。
        /// </summary>
        [JsonProperty("bak_file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BakFileName { get; set; }

        /// <summary>
        /// 备份文件所在的obs桶名。 若bak_file_name为空，该参数无效。 若该值为空，则备份文件来源为rds的备份文件。 若该值不为空，则备份文件来源为用户obs桶。
        /// </summary>
        [JsonProperty("bak_bucket_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BakBucketName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("publication_subscription", NullValueHandling = NullValueHandling.Ignore)]
        public CreateSubscription4PublicationInfo PublicationSubscription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("local_subscription", NullValueHandling = NullValueHandling.Ignore)]
        public CreateSubscription4InstanceInfo LocalSubscription { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSubscriptionInfo {\n");
            sb.Append("  subscriptionDatabase: ").Append(SubscriptionDatabase).Append("\n");
            sb.Append("  subscriptionType: ").Append(SubscriptionType).Append("\n");
            sb.Append("  initializeAt: ").Append(InitializeAt).Append("\n");
            sb.Append("  initializeInfo: ").Append(InitializeInfo).Append("\n");
            sb.Append("  independentAgent: ").Append(IndependentAgent).Append("\n");
            sb.Append("  jobSchedule: ").Append(JobSchedule).Append("\n");
            sb.Append("  bakFileName: ").Append(BakFileName).Append("\n");
            sb.Append("  bakBucketName: ").Append(BakBucketName).Append("\n");
            sb.Append("  publicationSubscription: ").Append(PublicationSubscription).Append("\n");
            sb.Append("  localSubscription: ").Append(LocalSubscription).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSubscriptionInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSubscriptionInfo input)
        {
            if (input == null) return false;
            if (this.SubscriptionDatabase != input.SubscriptionDatabase || (this.SubscriptionDatabase != null && !this.SubscriptionDatabase.Equals(input.SubscriptionDatabase))) return false;
            if (this.SubscriptionType != input.SubscriptionType || (this.SubscriptionType != null && !this.SubscriptionType.Equals(input.SubscriptionType))) return false;
            if (this.InitializeAt != input.InitializeAt || (this.InitializeAt != null && !this.InitializeAt.Equals(input.InitializeAt))) return false;
            if (this.InitializeInfo != input.InitializeInfo || (this.InitializeInfo != null && !this.InitializeInfo.Equals(input.InitializeInfo))) return false;
            if (this.IndependentAgent != input.IndependentAgent || (this.IndependentAgent != null && !this.IndependentAgent.Equals(input.IndependentAgent))) return false;
            if (this.JobSchedule != input.JobSchedule || (this.JobSchedule != null && !this.JobSchedule.Equals(input.JobSchedule))) return false;
            if (this.BakFileName != input.BakFileName || (this.BakFileName != null && !this.BakFileName.Equals(input.BakFileName))) return false;
            if (this.BakBucketName != input.BakBucketName || (this.BakBucketName != null && !this.BakBucketName.Equals(input.BakBucketName))) return false;
            if (this.PublicationSubscription != input.PublicationSubscription || (this.PublicationSubscription != null && !this.PublicationSubscription.Equals(input.PublicationSubscription))) return false;
            if (this.LocalSubscription != input.LocalSubscription || (this.LocalSubscription != null && !this.LocalSubscription.Equals(input.LocalSubscription))) return false;

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
                if (this.SubscriptionDatabase != null) hashCode = hashCode * 59 + this.SubscriptionDatabase.GetHashCode();
                if (this.SubscriptionType != null) hashCode = hashCode * 59 + this.SubscriptionType.GetHashCode();
                if (this.InitializeAt != null) hashCode = hashCode * 59 + this.InitializeAt.GetHashCode();
                if (this.InitializeInfo != null) hashCode = hashCode * 59 + this.InitializeInfo.GetHashCode();
                if (this.IndependentAgent != null) hashCode = hashCode * 59 + this.IndependentAgent.GetHashCode();
                if (this.JobSchedule != null) hashCode = hashCode * 59 + this.JobSchedule.GetHashCode();
                if (this.BakFileName != null) hashCode = hashCode * 59 + this.BakFileName.GetHashCode();
                if (this.BakBucketName != null) hashCode = hashCode * 59 + this.BakBucketName.GetHashCode();
                if (this.PublicationSubscription != null) hashCode = hashCode * 59 + this.PublicationSubscription.GetHashCode();
                if (this.LocalSubscription != null) hashCode = hashCode * 59 + this.LocalSubscription.GetHashCode();
                return hashCode;
            }
        }
    }
}
