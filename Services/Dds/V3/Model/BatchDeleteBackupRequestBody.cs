using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BatchDeleteBackupRequestBody 
    {

        /// <summary>
        /// 需要批量删除的手动备份id列表，最多一次不超过10条。
        /// </summary>
        [JsonProperty("backup_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> BackupIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteBackupRequestBody {\n");
            sb.Append("  backupIds: ").Append(BackupIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteBackupRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteBackupRequestBody input)
        {
            if (input == null) return false;
            if (this.BackupIds != input.BackupIds || (this.BackupIds != null && input.BackupIds != null && !this.BackupIds.SequenceEqual(input.BackupIds))) return false;

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
                if (this.BackupIds != null) hashCode = hashCode * 59 + this.BackupIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
