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
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**：  实例名称。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：  备份用量，单位MB。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("backup_use_space", NullValueHandling = NullValueHandling.Ignore)]
        public double? BackupUseSpace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("datastore", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceBackupDatastore Datastore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("spaces", NullValueHandling = NullValueHandling.Ignore)]
        public Spaces Spaces { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceBackupSummary {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  backupUseSpace: ").Append(BackupUseSpace).Append("\n");
            sb.Append("  datastore: ").Append(Datastore).Append("\n");
            sb.Append("  spaces: ").Append(Spaces).Append("\n");
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
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.BackupUseSpace != input.BackupUseSpace || (this.BackupUseSpace != null && !this.BackupUseSpace.Equals(input.BackupUseSpace))) return false;
            if (this.Datastore != input.Datastore || (this.Datastore != null && !this.Datastore.Equals(input.Datastore))) return false;
            if (this.Spaces != input.Spaces || (this.Spaces != null && !this.Spaces.Equals(input.Spaces))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.BackupUseSpace != null) hashCode = hashCode * 59 + this.BackupUseSpace.GetHashCode();
                if (this.Datastore != null) hashCode = hashCode * 59 + this.Datastore.GetHashCode();
                if (this.Spaces != null) hashCode = hashCode * 59 + this.Spaces.GetHashCode();
                return hashCode;
            }
        }
    }
}
