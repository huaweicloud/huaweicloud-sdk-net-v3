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
    /// 冷表元信息
    /// </summary>
    public class ColdTableMetaInfo 
    {

        /// <summary>
        /// **参数解释**：  表空间ID。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("space_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SpaceId { get; set; }

        /// <summary>
        /// **参数解释**：  表ID。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("dd_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DdId { get; set; }

        /// <summary>
        /// **参数解释**：  冷表库名。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("database_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// **参数解释**：  冷表表名。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TableName { get; set; }

        /// <summary>
        /// **参数解释**：  冷表分区名。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("partition_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PartitionName { get; set; }

        /// <summary>
        /// **参数解释**：  冷表有效周期（秒）。  **取值范围**：  ≥0。
        /// </summary>
        [JsonProperty("expiration_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExpirationTime { get; set; }

        /// <summary>
        /// **参数解释**：  冷表已保留时间（秒）。  **取值范围**：  ≥0。
        /// </summary>
        [JsonProperty("retained_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? RetainedTime { get; set; }

        /// <summary>
        /// **参数解释**：  冷表数据量大小（MB）。  **取值范围**：  ≥0。
        /// </summary>
        [JsonProperty("data_size", NullValueHandling = NullValueHandling.Ignore)]
        public float? DataSize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ColdTableMetaInfo {\n");
            sb.Append("  spaceId: ").Append(SpaceId).Append("\n");
            sb.Append("  ddId: ").Append(DdId).Append("\n");
            sb.Append("  databaseName: ").Append(DatabaseName).Append("\n");
            sb.Append("  tableName: ").Append(TableName).Append("\n");
            sb.Append("  partitionName: ").Append(PartitionName).Append("\n");
            sb.Append("  expirationTime: ").Append(ExpirationTime).Append("\n");
            sb.Append("  retainedTime: ").Append(RetainedTime).Append("\n");
            sb.Append("  dataSize: ").Append(DataSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ColdTableMetaInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ColdTableMetaInfo input)
        {
            if (input == null) return false;
            if (this.SpaceId != input.SpaceId || (this.SpaceId != null && !this.SpaceId.Equals(input.SpaceId))) return false;
            if (this.DdId != input.DdId || (this.DdId != null && !this.DdId.Equals(input.DdId))) return false;
            if (this.DatabaseName != input.DatabaseName || (this.DatabaseName != null && !this.DatabaseName.Equals(input.DatabaseName))) return false;
            if (this.TableName != input.TableName || (this.TableName != null && !this.TableName.Equals(input.TableName))) return false;
            if (this.PartitionName != input.PartitionName || (this.PartitionName != null && !this.PartitionName.Equals(input.PartitionName))) return false;
            if (this.ExpirationTime != input.ExpirationTime || (this.ExpirationTime != null && !this.ExpirationTime.Equals(input.ExpirationTime))) return false;
            if (this.RetainedTime != input.RetainedTime || (this.RetainedTime != null && !this.RetainedTime.Equals(input.RetainedTime))) return false;
            if (this.DataSize != input.DataSize || (this.DataSize != null && !this.DataSize.Equals(input.DataSize))) return false;

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
                if (this.SpaceId != null) hashCode = hashCode * 59 + this.SpaceId.GetHashCode();
                if (this.DdId != null) hashCode = hashCode * 59 + this.DdId.GetHashCode();
                if (this.DatabaseName != null) hashCode = hashCode * 59 + this.DatabaseName.GetHashCode();
                if (this.TableName != null) hashCode = hashCode * 59 + this.TableName.GetHashCode();
                if (this.PartitionName != null) hashCode = hashCode * 59 + this.PartitionName.GetHashCode();
                if (this.ExpirationTime != null) hashCode = hashCode * 59 + this.ExpirationTime.GetHashCode();
                if (this.RetainedTime != null) hashCode = hashCode * 59 + this.RetainedTime.GetHashCode();
                if (this.DataSize != null) hashCode = hashCode * 59 + this.DataSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
