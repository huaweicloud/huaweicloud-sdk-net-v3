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
    /// 超阈值实例信息
    /// </summary>
    public class ExceededInstanceInfo 
    {

        /// <summary>
        /// **参数解释**：  实例ID。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**：  日志备份空间使用量，单位GB。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("obs_usage_gb", NullValueHandling = NullValueHandling.Ignore)]
        public double? ObsUsageGb { get; set; }

        /// <summary>
        /// **参数解释**：  日志备份免费备份空间额度，单位GB。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("obs_free_backup_space_gb", NullValueHandling = NullValueHandling.Ignore)]
        public double? ObsFreeBackupSpaceGb { get; set; }

        /// <summary>
        /// **参数解释**：  快照备份空间使用量，单位GB。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("snapshot_usage_gb", NullValueHandling = NullValueHandling.Ignore)]
        public double? SnapshotUsageGb { get; set; }

        /// <summary>
        /// **参数解释**：  快照免费备份空间额度，单位GB。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("snapshot_free_backup_space_gb", NullValueHandling = NullValueHandling.Ignore)]
        public double? SnapshotFreeBackupSpaceGb { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExceededInstanceInfo {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  obsUsageGb: ").Append(ObsUsageGb).Append("\n");
            sb.Append("  obsFreeBackupSpaceGb: ").Append(ObsFreeBackupSpaceGb).Append("\n");
            sb.Append("  snapshotUsageGb: ").Append(SnapshotUsageGb).Append("\n");
            sb.Append("  snapshotFreeBackupSpaceGb: ").Append(SnapshotFreeBackupSpaceGb).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExceededInstanceInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExceededInstanceInfo input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.ObsUsageGb != input.ObsUsageGb || (this.ObsUsageGb != null && !this.ObsUsageGb.Equals(input.ObsUsageGb))) return false;
            if (this.ObsFreeBackupSpaceGb != input.ObsFreeBackupSpaceGb || (this.ObsFreeBackupSpaceGb != null && !this.ObsFreeBackupSpaceGb.Equals(input.ObsFreeBackupSpaceGb))) return false;
            if (this.SnapshotUsageGb != input.SnapshotUsageGb || (this.SnapshotUsageGb != null && !this.SnapshotUsageGb.Equals(input.SnapshotUsageGb))) return false;
            if (this.SnapshotFreeBackupSpaceGb != input.SnapshotFreeBackupSpaceGb || (this.SnapshotFreeBackupSpaceGb != null && !this.SnapshotFreeBackupSpaceGb.Equals(input.SnapshotFreeBackupSpaceGb))) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.ObsUsageGb != null) hashCode = hashCode * 59 + this.ObsUsageGb.GetHashCode();
                if (this.ObsFreeBackupSpaceGb != null) hashCode = hashCode * 59 + this.ObsFreeBackupSpaceGb.GetHashCode();
                if (this.SnapshotUsageGb != null) hashCode = hashCode * 59 + this.SnapshotUsageGb.GetHashCode();
                if (this.SnapshotFreeBackupSpaceGb != null) hashCode = hashCode * 59 + this.SnapshotFreeBackupSpaceGb.GetHashCode();
                return hashCode;
            }
        }
    }
}
