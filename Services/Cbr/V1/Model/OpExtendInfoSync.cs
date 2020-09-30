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
    public class OpExtendInfoSync 
    {

        /// <summary>
        /// 同步备份副本数
        /// </summary>
        [JsonProperty("sync_backup_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? SyncBackupNum { get; set; }

        /// <summary>
        /// 删除的备份副本数
        /// </summary>
        [JsonProperty("delete_backup_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? DeleteBackupNum { get; set; }

        /// <summary>
        /// 同步失败备副本数
        /// </summary>
        [JsonProperty("err_sync_backup_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? ErrSyncBackupNum { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpExtendInfoSync {\n");
            sb.Append("  syncBackupNum: ").Append(SyncBackupNum).Append("\n");
            sb.Append("  deleteBackupNum: ").Append(DeleteBackupNum).Append("\n");
            sb.Append("  errSyncBackupNum: ").Append(ErrSyncBackupNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OpExtendInfoSync);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OpExtendInfoSync input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SyncBackupNum == input.SyncBackupNum ||
                    (this.SyncBackupNum != null &&
                    this.SyncBackupNum.Equals(input.SyncBackupNum))
                ) && 
                (
                    this.DeleteBackupNum == input.DeleteBackupNum ||
                    (this.DeleteBackupNum != null &&
                    this.DeleteBackupNum.Equals(input.DeleteBackupNum))
                ) && 
                (
                    this.ErrSyncBackupNum == input.ErrSyncBackupNum ||
                    (this.ErrSyncBackupNum != null &&
                    this.ErrSyncBackupNum.Equals(input.ErrSyncBackupNum))
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
                if (this.SyncBackupNum != null)
                    hashCode = hashCode * 59 + this.SyncBackupNum.GetHashCode();
                if (this.DeleteBackupNum != null)
                    hashCode = hashCode * 59 + this.DeleteBackupNum.GetHashCode();
                if (this.ErrSyncBackupNum != null)
                    hashCode = hashCode * 59 + this.ErrSyncBackupNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
