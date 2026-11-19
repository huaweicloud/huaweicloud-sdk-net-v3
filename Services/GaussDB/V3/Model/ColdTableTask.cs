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
    public class ColdTableTask 
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
        /// **参数解释**：  分区名，为空表示无分区表。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("partition_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PartitionName { get; set; }

        /// <summary>
        /// **参数解释**：  任务状态。  **取值范围**：  - BEGIN：开始。 - RUNNING：进行中。 - FINISH：已完成。 - FAIL：失败。 - REVOKE：回滚。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**：  操作类型。  **取值范围**：  - OBS：创建冷表。 - SLICE：回迁冷表。
        /// </summary>
        [JsonProperty("target_storage", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetStorage { get; set; }

        /// <summary>
        /// **参数解释**：  任务进度百分比。  **取值范围**：  0-1。
        /// </summary>
        [JsonProperty("percent", NullValueHandling = NullValueHandling.Ignore)]
        public double? Percent { get; set; }

        /// <summary>
        /// **参数解释**：  对象数。  **取值范围**：  非负数。
        /// </summary>
        [JsonProperty("total_cnt", NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalCnt { get; set; }

        /// <summary>
        /// **参数解释**：  表空间ID。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("space_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SpaceId { get; set; }

        /// <summary>
        /// **参数解释**：  冷表版本。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ColdTableTask {\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  tableName: ").Append(TableName).Append("\n");
            sb.Append("  partitionName: ").Append(PartitionName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  targetStorage: ").Append(TargetStorage).Append("\n");
            sb.Append("  percent: ").Append(Percent).Append("\n");
            sb.Append("  totalCnt: ").Append(TotalCnt).Append("\n");
            sb.Append("  spaceId: ").Append(SpaceId).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ColdTableTask);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ColdTableTask input)
        {
            if (input == null) return false;
            if (this.DbName != input.DbName || (this.DbName != null && !this.DbName.Equals(input.DbName))) return false;
            if (this.TableName != input.TableName || (this.TableName != null && !this.TableName.Equals(input.TableName))) return false;
            if (this.PartitionName != input.PartitionName || (this.PartitionName != null && !this.PartitionName.Equals(input.PartitionName))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.TargetStorage != input.TargetStorage || (this.TargetStorage != null && !this.TargetStorage.Equals(input.TargetStorage))) return false;
            if (this.Percent != input.Percent || (this.Percent != null && !this.Percent.Equals(input.Percent))) return false;
            if (this.TotalCnt != input.TotalCnt || (this.TotalCnt != null && !this.TotalCnt.Equals(input.TotalCnt))) return false;
            if (this.SpaceId != input.SpaceId || (this.SpaceId != null && !this.SpaceId.Equals(input.SpaceId))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;

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
                if (this.TargetStorage != null) hashCode = hashCode * 59 + this.TargetStorage.GetHashCode();
                if (this.Percent != null) hashCode = hashCode * 59 + this.Percent.GetHashCode();
                if (this.TotalCnt != null) hashCode = hashCode * 59 + this.TotalCnt.GetHashCode();
                if (this.SpaceId != null) hashCode = hashCode * 59 + this.SpaceId.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }
    }
}
