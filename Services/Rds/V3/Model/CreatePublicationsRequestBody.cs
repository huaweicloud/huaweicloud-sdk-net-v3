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
    public class CreatePublicationsRequestBody 
    {

        /// <summary>
        /// 发布名称。  发布名称长度可在5～64个字符之间，由字母、数字或下划线组成，不能包含其他特殊字符。
        /// </summary>
        [JsonProperty("publication_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicationName { get; set; }

        /// <summary>
        /// 发布数据库名。
        /// </summary>
        [JsonProperty("publication_database", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicationDatabase { get; set; }

        /// <summary>
        /// 是否立即创建快照。
        /// </summary>
        [JsonProperty("is_create_snapshot_immediately", NullValueHandling = NullValueHandling.Ignore)]
        public string IsCreateSnapshotImmediately { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("subscription_options", NullValueHandling = NullValueHandling.Ignore)]
        public SubscriptionOption SubscriptionOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("job_schedule", NullValueHandling = NullValueHandling.Ignore)]
        public OperateUsedJobSchedule JobSchedule { get; set; }

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
        public List<PublicationTableInfoRequest> Tables { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePublicationsRequestBody {\n");
            sb.Append("  publicationName: ").Append(PublicationName).Append("\n");
            sb.Append("  publicationDatabase: ").Append(PublicationDatabase).Append("\n");
            sb.Append("  isCreateSnapshotImmediately: ").Append(IsCreateSnapshotImmediately).Append("\n");
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
            return this.Equals(input as CreatePublicationsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreatePublicationsRequestBody input)
        {
            if (input == null) return false;
            if (this.PublicationName != input.PublicationName || (this.PublicationName != null && !this.PublicationName.Equals(input.PublicationName))) return false;
            if (this.PublicationDatabase != input.PublicationDatabase || (this.PublicationDatabase != null && !this.PublicationDatabase.Equals(input.PublicationDatabase))) return false;
            if (this.IsCreateSnapshotImmediately != input.IsCreateSnapshotImmediately || (this.IsCreateSnapshotImmediately != null && !this.IsCreateSnapshotImmediately.Equals(input.IsCreateSnapshotImmediately))) return false;
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
                if (this.PublicationName != null) hashCode = hashCode * 59 + this.PublicationName.GetHashCode();
                if (this.PublicationDatabase != null) hashCode = hashCode * 59 + this.PublicationDatabase.GetHashCode();
                if (this.IsCreateSnapshotImmediately != null) hashCode = hashCode * 59 + this.IsCreateSnapshotImmediately.GetHashCode();
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
