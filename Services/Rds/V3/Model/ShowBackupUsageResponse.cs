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
    /// Response Object
    /// </summary>
    public class ShowBackupUsageResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  备份总使用量，各类备份占用的备份总大小。 单位：MB  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("backup_use_space", NullValueHandling = NullValueHandling.Ignore)]
        public double? BackupUseSpace { get; set; }

        /// <summary>
        /// **参数解释**：  物理备份总使用量，包括本区域的物理全量备份，binlog日志备份，审计日志。 单位：MB  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("db_use_space", NullValueHandling = NullValueHandling.Ignore)]
        public double? DbUseSpace { get; set; }

        /// <summary>
        /// **参数解释**：  由RDS计费的cbr快照备份总使用量， 单位MB  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("rds_snapshot_use_space", NullValueHandling = NullValueHandling.Ignore)]
        public double? RdsSnapshotUseSpace { get; set; }

        /// <summary>
        /// **参数解释**：  跨区域备份总使用量，包括跨区域的物理全量备份，binlog日志备份， 单位：MB  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("offsite_use_space", NullValueHandling = NullValueHandling.Ignore)]
        public double? OffsiteUseSpace { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBackupUsageResponse {\n");
            sb.Append("  backupUseSpace: ").Append(BackupUseSpace).Append("\n");
            sb.Append("  dbUseSpace: ").Append(DbUseSpace).Append("\n");
            sb.Append("  rdsSnapshotUseSpace: ").Append(RdsSnapshotUseSpace).Append("\n");
            sb.Append("  offsiteUseSpace: ").Append(OffsiteUseSpace).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowBackupUsageResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowBackupUsageResponse input)
        {
            if (input == null) return false;
            if (this.BackupUseSpace != input.BackupUseSpace || (this.BackupUseSpace != null && !this.BackupUseSpace.Equals(input.BackupUseSpace))) return false;
            if (this.DbUseSpace != input.DbUseSpace || (this.DbUseSpace != null && !this.DbUseSpace.Equals(input.DbUseSpace))) return false;
            if (this.RdsSnapshotUseSpace != input.RdsSnapshotUseSpace || (this.RdsSnapshotUseSpace != null && !this.RdsSnapshotUseSpace.Equals(input.RdsSnapshotUseSpace))) return false;
            if (this.OffsiteUseSpace != input.OffsiteUseSpace || (this.OffsiteUseSpace != null && !this.OffsiteUseSpace.Equals(input.OffsiteUseSpace))) return false;

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
                if (this.BackupUseSpace != null) hashCode = hashCode * 59 + this.BackupUseSpace.GetHashCode();
                if (this.DbUseSpace != null) hashCode = hashCode * 59 + this.DbUseSpace.GetHashCode();
                if (this.RdsSnapshotUseSpace != null) hashCode = hashCode * 59 + this.RdsSnapshotUseSpace.GetHashCode();
                if (this.OffsiteUseSpace != null) hashCode = hashCode * 59 + this.OffsiteUseSpace.GetHashCode();
                return hashCode;
            }
        }
    }
}
