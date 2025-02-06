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
    public class DatabaseBackupInfo 
    {

        /// <summary>
        /// 库名
        /// </summary>
        [JsonProperty("database_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// 备份文件名
        /// </summary>
        [JsonProperty("backup_file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupFileName { get; set; }

        /// <summary>
        /// 备份文件大小
        /// </summary>
        [JsonProperty("backup_file_size", NullValueHandling = NullValueHandling.Ignore)]
        public long? BackupFileSize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatabaseBackupInfo {\n");
            sb.Append("  databaseName: ").Append(DatabaseName).Append("\n");
            sb.Append("  backupFileName: ").Append(BackupFileName).Append("\n");
            sb.Append("  backupFileSize: ").Append(BackupFileSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DatabaseBackupInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DatabaseBackupInfo input)
        {
            if (input == null) return false;
            if (this.DatabaseName != input.DatabaseName || (this.DatabaseName != null && !this.DatabaseName.Equals(input.DatabaseName))) return false;
            if (this.BackupFileName != input.BackupFileName || (this.BackupFileName != null && !this.BackupFileName.Equals(input.BackupFileName))) return false;
            if (this.BackupFileSize != input.BackupFileSize || (this.BackupFileSize != null && !this.BackupFileSize.Equals(input.BackupFileSize))) return false;

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
                if (this.DatabaseName != null) hashCode = hashCode * 59 + this.DatabaseName.GetHashCode();
                if (this.BackupFileName != null) hashCode = hashCode * 59 + this.BackupFileName.GetHashCode();
                if (this.BackupFileSize != null) hashCode = hashCode * 59 + this.BackupFileSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
