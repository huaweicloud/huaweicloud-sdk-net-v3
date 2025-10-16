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
    /// 发布详情。
    /// </summary>
    public class QueryPublicationInfo 
    {

        /// <summary>
        /// 发布id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 发布状态。normal，abnormal，creating，modifying，createfail
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 发布名。
        /// </summary>
        [JsonProperty("publication_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicationName { get; set; }

        /// <summary>
        /// 发布数据库名。
        /// </summary>
        [JsonProperty("publication_database", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicationDatabase { get; set; }

        /// <summary>
        /// 订阅数。
        /// </summary>
        [JsonProperty("subscription_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("subscription_options", NullValueHandling = NullValueHandling.Ignore)]
        public SubscriptionOptionsResult SubscriptionOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("job_schedule", NullValueHandling = NullValueHandling.Ignore)]
        public UsedJobSchedule JobSchedule { get; set; }

        /// <summary>
        /// 是否选择所有数据表。
        /// </summary>
        [JsonProperty("is_select_all_table", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSelectAllTable { get; set; }

        /// <summary>
        /// 全选所有表后需要去除的表。
        /// </summary>
        [JsonProperty("extend_tables", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExtendTables { get; set; }

        /// <summary>
        /// 发布数据表。
        /// </summary>
        [JsonProperty("tables", NullValueHandling = NullValueHandling.Ignore)]
        public List<PublicationTableInfoResponse> Tables { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryPublicationInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  publicationName: ").Append(PublicationName).Append("\n");
            sb.Append("  publicationDatabase: ").Append(PublicationDatabase).Append("\n");
            sb.Append("  subscriptionCount: ").Append(SubscriptionCount).Append("\n");
            sb.Append("  subscriptionOptions: ").Append(SubscriptionOptions).Append("\n");
            sb.Append("  jobSchedule: ").Append(JobSchedule).Append("\n");
            sb.Append("  isSelectAllTable: ").Append(IsSelectAllTable).Append("\n");
            sb.Append("  extendTables: ").Append(ExtendTables).Append("\n");
            sb.Append("  tables: ").Append(Tables).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryPublicationInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryPublicationInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.PublicationName != input.PublicationName || (this.PublicationName != null && !this.PublicationName.Equals(input.PublicationName))) return false;
            if (this.PublicationDatabase != input.PublicationDatabase || (this.PublicationDatabase != null && !this.PublicationDatabase.Equals(input.PublicationDatabase))) return false;
            if (this.SubscriptionCount != input.SubscriptionCount || (this.SubscriptionCount != null && !this.SubscriptionCount.Equals(input.SubscriptionCount))) return false;
            if (this.SubscriptionOptions != input.SubscriptionOptions || (this.SubscriptionOptions != null && !this.SubscriptionOptions.Equals(input.SubscriptionOptions))) return false;
            if (this.JobSchedule != input.JobSchedule || (this.JobSchedule != null && !this.JobSchedule.Equals(input.JobSchedule))) return false;
            if (this.IsSelectAllTable != input.IsSelectAllTable || (this.IsSelectAllTable != null && !this.IsSelectAllTable.Equals(input.IsSelectAllTable))) return false;
            if (this.ExtendTables != input.ExtendTables || (this.ExtendTables != null && input.ExtendTables != null && !this.ExtendTables.SequenceEqual(input.ExtendTables))) return false;
            if (this.Tables != input.Tables || (this.Tables != null && input.Tables != null && !this.Tables.SequenceEqual(input.Tables))) return false;

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
                if (this.PublicationName != null) hashCode = hashCode * 59 + this.PublicationName.GetHashCode();
                if (this.PublicationDatabase != null) hashCode = hashCode * 59 + this.PublicationDatabase.GetHashCode();
                if (this.SubscriptionCount != null) hashCode = hashCode * 59 + this.SubscriptionCount.GetHashCode();
                if (this.SubscriptionOptions != null) hashCode = hashCode * 59 + this.SubscriptionOptions.GetHashCode();
                if (this.JobSchedule != null) hashCode = hashCode * 59 + this.JobSchedule.GetHashCode();
                if (this.IsSelectAllTable != null) hashCode = hashCode * 59 + this.IsSelectAllTable.GetHashCode();
                if (this.ExtendTables != null) hashCode = hashCode * 59 + this.ExtendTables.GetHashCode();
                if (this.Tables != null) hashCode = hashCode * 59 + this.Tables.GetHashCode();
                return hashCode;
            }
        }
    }
}
