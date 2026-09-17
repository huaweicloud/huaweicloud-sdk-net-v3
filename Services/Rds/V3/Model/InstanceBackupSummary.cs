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
    /// 实例备份概览
    /// </summary>
    public class InstanceBackupSummary 
    {

        /// <summary>
        /// **参数解释**：  实例ID。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**：  实例名称。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：  备份用量，单位MB。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("backup_used_space", NullValueHandling = NullValueHandling.Ignore)]
        public double? BackupUsedSpace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("datastore", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceBackupDatastore Datastore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("space", NullValueHandling = NullValueHandling.Ignore)]
        public Space Space { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceBackupSummary {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  backupUsedSpace: ").Append(BackupUsedSpace).Append("\n");
            sb.Append("  datastore: ").Append(Datastore).Append("\n");
            sb.Append("  space: ").Append(Space).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstanceBackupSummary);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstanceBackupSummary input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.BackupUsedSpace != input.BackupUsedSpace || (this.BackupUsedSpace != null && !this.BackupUsedSpace.Equals(input.BackupUsedSpace))) return false;
            if (this.Datastore != input.Datastore || (this.Datastore != null && !this.Datastore.Equals(input.Datastore))) return false;
            if (this.Space != input.Space || (this.Space != null && !this.Space.Equals(input.Space))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.BackupUsedSpace != null) hashCode = hashCode * 59 + this.BackupUsedSpace.GetHashCode();
                if (this.Datastore != null) hashCode = hashCode * 59 + this.Datastore.GetHashCode();
                if (this.Space != null) hashCode = hashCode * 59 + this.Space.GetHashCode();
                return hashCode;
            }
        }
    }
}
