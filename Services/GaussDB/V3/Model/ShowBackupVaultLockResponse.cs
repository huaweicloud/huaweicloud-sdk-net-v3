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
    /// Response Object
    /// </summary>
    public class ShowBackupVaultLockResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("backup_vaultlock_info", NullValueHandling = NullValueHandling.Ignore)]
        public BackupVaultLockInfo BackupVaultlockInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBackupVaultLockResponse {\n");
            sb.Append("  backupVaultlockInfo: ").Append(BackupVaultlockInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowBackupVaultLockResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowBackupVaultLockResponse input)
        {
            if (input == null) return false;
            if (this.BackupVaultlockInfo != input.BackupVaultlockInfo || (this.BackupVaultlockInfo != null && !this.BackupVaultlockInfo.Equals(input.BackupVaultlockInfo))) return false;

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
                if (this.BackupVaultlockInfo != null) hashCode = hashCode * 59 + this.BackupVaultlockInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
