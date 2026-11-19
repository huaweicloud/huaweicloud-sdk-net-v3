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
    public class FailedItem 
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
        /// **参数解释**：  失败原因。  **取值范围**：  - restricted：内核限制无法下发。 - incorrect：库名、表名、分区名有误。 - duplicate：该表正在进行其他操作（待归档、待回迁、归档中、回迁中、已归档、已回迁）。
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FailedItem {\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  tableName: ").Append(TableName).Append("\n");
            sb.Append("  partitionName: ").Append(PartitionName).Append("\n");
            sb.Append("  reason: ").Append(Reason).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FailedItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FailedItem input)
        {
            if (input == null) return false;
            if (this.DbName != input.DbName || (this.DbName != null && !this.DbName.Equals(input.DbName))) return false;
            if (this.TableName != input.TableName || (this.TableName != null && !this.TableName.Equals(input.TableName))) return false;
            if (this.PartitionName != input.PartitionName || (this.PartitionName != null && !this.PartitionName.Equals(input.PartitionName))) return false;
            if (this.Reason != input.Reason || (this.Reason != null && !this.Reason.Equals(input.Reason))) return false;

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
                if (this.Reason != null) hashCode = hashCode * 59 + this.Reason.GetHashCode();
                return hashCode;
            }
        }
    }
}
