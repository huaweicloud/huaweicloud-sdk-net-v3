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
    public class CancelColdTableWaitingTask 
    {

        /// <summary>
        /// **参数解释**：  数据库名。  获取方法请参见[查询冷热分离待下发任务列表](https://support.huaweicloud.com/api-taurusdb/ListColdTableWaitingTasks.html)。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// **参数解释**：  表名。 获取方法请参见[查询冷热分离待下发任务列表](https://support.huaweicloud.com/api-taurusdb/ListColdTableWaitingTasks.html)。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TableName { get; set; }

        /// <summary>
        /// **参数解释**：  分区名。  获取方法请参见[查询冷热分离待下发任务列表](https://support.huaweicloud.com/api-taurusdb/ListColdTableWaitingTasks.html)。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("partition_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PartitionName { get; set; }

        /// <summary>
        /// **参数解释**：  任务类型。  **约束限制**：  不涉及。  **取值范围**：  - waiting_archive：待归档。 - waiting_unarchive：待回迁。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CancelColdTableWaitingTask {\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  tableName: ").Append(TableName).Append("\n");
            sb.Append("  partitionName: ").Append(PartitionName).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CancelColdTableWaitingTask);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CancelColdTableWaitingTask input)
        {
            if (input == null) return false;
            if (this.DbName != input.DbName || (this.DbName != null && !this.DbName.Equals(input.DbName))) return false;
            if (this.TableName != input.TableName || (this.TableName != null && !this.TableName.Equals(input.TableName))) return false;
            if (this.PartitionName != input.PartitionName || (this.PartitionName != null && !this.PartitionName.Equals(input.PartitionName))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
