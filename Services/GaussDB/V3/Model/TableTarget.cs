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
    public class TableTarget 
    {

        /// <summary>
        /// **参数解释**：  数据库名。  获取方法请参见[查询冷热分离可归档表信息](https://support.huaweicloud.com/api-taurusdb/ListArchivableTables.html)。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// **参数解释**：  表名。  获取方法请参见[查询冷热分离可归档表信息](https://support.huaweicloud.com/api-taurusdb/ListArchivableTables.html)。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TableName { get; set; }

        /// <summary>
        /// **参数解释**：  分区名。  获取方法请参见[查询冷热分离可归档表信息](https://support.huaweicloud.com/api-taurusdb/ListArchivableTables.html)。  **约束限制**：  如果指定表下存在分区，则该参数必填。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("partition_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PartitionName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TableTarget {\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  tableName: ").Append(TableName).Append("\n");
            sb.Append("  partitionName: ").Append(PartitionName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TableTarget);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TableTarget input)
        {
            if (input == null) return false;
            if (this.DbName != input.DbName || (this.DbName != null && !this.DbName.Equals(input.DbName))) return false;
            if (this.TableName != input.TableName || (this.TableName != null && !this.TableName.Equals(input.TableName))) return false;
            if (this.PartitionName != input.PartitionName || (this.PartitionName != null && !this.PartitionName.Equals(input.PartitionName))) return false;

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
                return hashCode;
            }
        }
    }
}
