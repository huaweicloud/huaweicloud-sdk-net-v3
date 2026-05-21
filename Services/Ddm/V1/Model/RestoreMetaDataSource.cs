using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RestoreMetaDataSource 
    {

        /// <summary>
        /// 恢复时间。
        /// </summary>
        [JsonProperty("restore_time", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? RestoreTime { get; set; }

        /// <summary>
        /// 备份id。
        /// </summary>
        [JsonProperty("backup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestoreMetaDataSource {\n");
            sb.Append("  restoreTime: ").Append(RestoreTime).Append("\n");
            sb.Append("  backupId: ").Append(BackupId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestoreMetaDataSource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestoreMetaDataSource input)
        {
            if (input == null) return false;
            if (this.RestoreTime != input.RestoreTime || (this.RestoreTime != null && !this.RestoreTime.Equals(input.RestoreTime))) return false;
            if (this.BackupId != input.BackupId || (this.BackupId != null && !this.BackupId.Equals(input.BackupId))) return false;

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
                if (this.RestoreTime != null) hashCode = hashCode * 59 + this.RestoreTime.GetHashCode();
                if (this.BackupId != null) hashCode = hashCode * 59 + this.BackupId.GetHashCode();
                return hashCode;
            }
        }
    }
}
