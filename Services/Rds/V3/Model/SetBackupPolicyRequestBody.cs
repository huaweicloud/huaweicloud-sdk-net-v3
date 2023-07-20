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
    /// 
    /// </summary>
    public class SetBackupPolicyRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("backup_policy", NullValueHandling = NullValueHandling.Ignore)]
        public BackupPolicy BackupPolicy { get; set; }

        /// <summary>
        /// 仅关闭备份策略时有效。  - true（默认），表示保留自动备份和差异备份。 - false，表示关闭备份策略的同时，删除已有的自动备份和差异备份。
        /// </summary>
        [JsonProperty("reserve_backups", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReserveBackups { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetBackupPolicyRequestBody {\n");
            sb.Append("  backupPolicy: ").Append(BackupPolicy).Append("\n");
            sb.Append("  reserveBackups: ").Append(ReserveBackups).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetBackupPolicyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetBackupPolicyRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupPolicy == input.BackupPolicy ||
                    (this.BackupPolicy != null &&
                    this.BackupPolicy.Equals(input.BackupPolicy))
                ) && 
                (
                    this.ReserveBackups == input.ReserveBackups ||
                    (this.ReserveBackups != null &&
                    this.ReserveBackups.Equals(input.ReserveBackups))
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
                if (this.BackupPolicy != null)
                    hashCode = hashCode * 59 + this.BackupPolicy.GetHashCode();
                if (this.ReserveBackups != null)
                    hashCode = hashCode * 59 + this.ReserveBackups.GetHashCode();
                return hashCode;
            }
        }
    }
}
