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
    /// 初始化信息。
    /// </summary>
    public class CreateSubscriptionInfoInitializeInfo 
    {

        /// <summary>
        /// 初始化使用的文件源，仅支持OBS或BACKUP。
        /// </summary>
        [JsonProperty("file_source", NullValueHandling = NullValueHandling.Ignore)]
        public string FileSource { get; set; }

        /// <summary>
        /// 使用备份文件初始化的备份文件ID。
        /// </summary>
        [JsonProperty("backup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupId { get; set; }

        /// <summary>
        /// 使用OBS内备份文件恢复的bucket名称。
        /// </summary>
        [JsonProperty("bucket_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketName { get; set; }

        /// <summary>
        /// OBS桶内备份文件的路径。
        /// </summary>
        [JsonProperty("file_path", NullValueHandling = NullValueHandling.Ignore)]
        public string FilePath { get; set; }

        /// <summary>
        /// OBS桶内备份文件的名称。
        /// </summary>
        [JsonProperty("file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// 是否使用备份文件对订阅库进行覆盖还原。
        /// </summary>
        [JsonProperty("overwrite_restore", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OverwriteRestore { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSubscriptionInfoInitializeInfo {\n");
            sb.Append("  fileSource: ").Append(FileSource).Append("\n");
            sb.Append("  backupId: ").Append(BackupId).Append("\n");
            sb.Append("  bucketName: ").Append(BucketName).Append("\n");
            sb.Append("  filePath: ").Append(FilePath).Append("\n");
            sb.Append("  fileName: ").Append(FileName).Append("\n");
            sb.Append("  overwriteRestore: ").Append(OverwriteRestore).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSubscriptionInfoInitializeInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSubscriptionInfoInitializeInfo input)
        {
            if (input == null) return false;
            if (this.FileSource != input.FileSource || (this.FileSource != null && !this.FileSource.Equals(input.FileSource))) return false;
            if (this.BackupId != input.BackupId || (this.BackupId != null && !this.BackupId.Equals(input.BackupId))) return false;
            if (this.BucketName != input.BucketName || (this.BucketName != null && !this.BucketName.Equals(input.BucketName))) return false;
            if (this.FilePath != input.FilePath || (this.FilePath != null && !this.FilePath.Equals(input.FilePath))) return false;
            if (this.FileName != input.FileName || (this.FileName != null && !this.FileName.Equals(input.FileName))) return false;
            if (this.OverwriteRestore != input.OverwriteRestore || (this.OverwriteRestore != null && !this.OverwriteRestore.Equals(input.OverwriteRestore))) return false;

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
                if (this.FileSource != null) hashCode = hashCode * 59 + this.FileSource.GetHashCode();
                if (this.BackupId != null) hashCode = hashCode * 59 + this.BackupId.GetHashCode();
                if (this.BucketName != null) hashCode = hashCode * 59 + this.BucketName.GetHashCode();
                if (this.FilePath != null) hashCode = hashCode * 59 + this.FilePath.GetHashCode();
                if (this.FileName != null) hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.OverwriteRestore != null) hashCode = hashCode * 59 + this.OverwriteRestore.GetHashCode();
                return hashCode;
            }
        }
    }
}
