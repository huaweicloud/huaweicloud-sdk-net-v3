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
    /// 回收站保留备份信息。
    /// </summary>
    public class RetainedBackupInfo 
    {

        /// <summary>
        /// **参数解释**：  备份ID。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("backup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupId { get; set; }

        /// <summary>
        /// **参数解释**：  源实例ID（已释放实例）。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**：  备份状态。  **约束限制**：  不涉及。  **取值范围**：  Active：可用。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**：  备份名称。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("backup_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupName { get; set; }

        /// <summary>
        /// **参数解释**：  备份大小，单位MB。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// **参数解释**：  备份开始时间，格式为“yyyy-mm-ddThh:mm:ssZ”。  其中，T指某个时间的开始；Z指时区偏移量，例如偏移1个小时显示为+0100。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string BeginTime { get; set; }

        /// <summary>
        /// **参数解释**：  备份结束时间，格式为“yyyy-mm-ddThh:mm:ssZ”，且大于备份开始时间。  其中，T指某个时间的开始；Z指时区偏移量，例如偏移1个小时显示为+0100。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// **参数解释**：  备份类型。  **约束限制**：  不涉及。  **取值范围**：  - auto：自动全量备份。 - manual：手动全量备份。 - differential：差量备份。 - sparse：稀疏备份。 - recycle: 回收站备份。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("backup_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupType { get; set; }

        /// <summary>
        /// **参数解释**：  备份级别，即备份位置。  **约束限制**：  不涉及。  **取值范围**：  - 1：一级备份。 - 2：二级备份。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("backup_level", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupLevel { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetainedBackupInfo {\n");
            sb.Append("  backupId: ").Append(BackupId).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  backupName: ").Append(BackupName).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  backupType: ").Append(BackupType).Append("\n");
            sb.Append("  backupLevel: ").Append(BackupLevel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RetainedBackupInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RetainedBackupInfo input)
        {
            if (input == null) return false;
            if (this.BackupId != input.BackupId || (this.BackupId != null && !this.BackupId.Equals(input.BackupId))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.BackupName != input.BackupName || (this.BackupName != null && !this.BackupName.Equals(input.BackupName))) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.BeginTime != input.BeginTime || (this.BeginTime != null && !this.BeginTime.Equals(input.BeginTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.BackupType != input.BackupType || (this.BackupType != null && !this.BackupType.Equals(input.BackupType))) return false;
            if (this.BackupLevel != input.BackupLevel || (this.BackupLevel != null && !this.BackupLevel.Equals(input.BackupLevel))) return false;

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
                if (this.BackupId != null) hashCode = hashCode * 59 + this.BackupId.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.BackupName != null) hashCode = hashCode * 59 + this.BackupName.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.BeginTime != null) hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.BackupType != null) hashCode = hashCode * 59 + this.BackupType.GetHashCode();
                if (this.BackupLevel != null) hashCode = hashCode * 59 + this.BackupLevel.GetHashCode();
                return hashCode;
            }
        }
    }
}
