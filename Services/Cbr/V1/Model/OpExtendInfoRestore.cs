using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class OpExtendInfoRestore 
    {

        /// <summary>
        /// 备份副本ID
        /// </summary>
        [JsonProperty("backup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupId { get; set; }

        /// <summary>
        /// 备份名称
        /// </summary>
        [JsonProperty("backup_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupName { get; set; }

        /// <summary>
        /// 恢复目标资源ID
        /// </summary>
        [JsonProperty("target_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetResourceId { get; set; }

        /// <summary>
        /// 恢复目标资源名称
        /// </summary>
        [JsonProperty("target_resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetResourceName { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpExtendInfoRestore {\n");
            sb.Append("  backupId: ").Append(BackupId).Append("\n");
            sb.Append("  backupName: ").Append(BackupName).Append("\n");
            sb.Append("  targetResourceId: ").Append(TargetResourceId).Append("\n");
            sb.Append("  targetResourceName: ").Append(TargetResourceName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OpExtendInfoRestore);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OpExtendInfoRestore input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupId == input.BackupId ||
                    (this.BackupId != null &&
                    this.BackupId.Equals(input.BackupId))
                ) && 
                (
                    this.BackupName == input.BackupName ||
                    (this.BackupName != null &&
                    this.BackupName.Equals(input.BackupName))
                ) && 
                (
                    this.TargetResourceId == input.TargetResourceId ||
                    (this.TargetResourceId != null &&
                    this.TargetResourceId.Equals(input.TargetResourceId))
                ) && 
                (
                    this.TargetResourceName == input.TargetResourceName ||
                    (this.TargetResourceName != null &&
                    this.TargetResourceName.Equals(input.TargetResourceName))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.BackupId != null)
                    hashCode = hashCode * 59 + this.BackupId.GetHashCode();
                if (this.BackupName != null)
                    hashCode = hashCode * 59 + this.BackupName.GetHashCode();
                if (this.TargetResourceId != null)
                    hashCode = hashCode * 59 + this.TargetResourceId.GetHashCode();
                if (this.TargetResourceName != null)
                    hashCode = hashCode * 59 + this.TargetResourceName.GetHashCode();
                return hashCode;
            }
        }
    }
}
