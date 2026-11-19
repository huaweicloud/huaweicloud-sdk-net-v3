using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ColdTableWaitingTask 
    {

        /// <summary>
        /// **参数解释**：  数据库名。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// **参数解释**：  表名。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TableName { get; set; }

        /// <summary>
        /// **参数解释**：  分区名。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("partition_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PartitionName { get; set; }

        /// <summary>
        /// **参数解释**：  任务状态。  **取值范围**：  - waiting_archive：等待归档。 - waiting_unarchive：等待回迁。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**：  任务创建时间，13位毫秒级时间戳。  **取值范围**：  非负整数。
        /// </summary>
        [JsonProperty("create_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ColdTableWaitingTask {\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  tableName: ").Append(TableName).Append("\n");
            sb.Append("  partitionName: ").Append(PartitionName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  createAt: ").Append(CreateAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ColdTableWaitingTask);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ColdTableWaitingTask input)
        {
            if (input == null) return false;
            if (this.DbName != input.DbName || (this.DbName != null && !this.DbName.Equals(input.DbName))) return false;
            if (this.TableName != input.TableName || (this.TableName != null && !this.TableName.Equals(input.TableName))) return false;
            if (this.PartitionName != input.PartitionName || (this.PartitionName != null && !this.PartitionName.Equals(input.PartitionName))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.CreateAt != input.CreateAt || (this.CreateAt != null && !this.CreateAt.Equals(input.CreateAt))) return false;

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
                if (this.DbName != null) hashCode = hashCode * 59 + this.DbName.GetHashCode();
                if (this.TableName != null) hashCode = hashCode * 59 + this.TableName.GetHashCode();
                if (this.PartitionName != null) hashCode = hashCode * 59 + this.PartitionName.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreateAt != null) hashCode = hashCode * 59 + this.CreateAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
