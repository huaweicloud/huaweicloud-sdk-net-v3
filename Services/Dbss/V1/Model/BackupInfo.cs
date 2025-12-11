using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BackupInfo 
    {

        /// <summary>
        /// 备份失败原因
        /// </summary>
        [JsonProperty("backup_task_fail_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupTaskFailReason { get; set; }

        /// <summary>
        /// 备份时间,yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("backup_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? BackupTime { get; set; }

        /// <summary>
        /// 标记删除
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// 备份结束时间,yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// 文件大小
        /// </summary>
        [JsonProperty("file_size", NullValueHandling = NullValueHandling.Ignore)]
        public long? FileSize { get; set; }

        /// <summary>
        /// 文件大小单位 - Byte：Byte - KB：kb - MB: mb - GB: gb
        /// </summary>
        [JsonProperty("file_size_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string FileSizeUnit { get; set; }

        /// <summary>
        /// 备份ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 备份方式 - AUTO：自动备份
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }

        /// <summary>
        /// 备份名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 备份进度
        /// </summary>
        [JsonProperty("percentage", NullValueHandling = NullValueHandling.Ignore)]
        public int? Percentage { get; set; }

        /// <summary>
        /// 进度 - CLEAN_AFTER_FAILED: 清理失败 - DELETING：删除中 - DELETED：已删除 - DELETE_FAIL：删除失败 - RESTORING_WAITING：恢复等待中 - RESTORING：恢复中 - RESTORED：已恢复 - RESTORE_FAIL：恢复失败 - BACKUP_WAITING：等待备份 - FILE_UPLOAD_WAITING：等待上传备份文件 - FILE_UPLOADING：上传中 - AUTO_BACKUPING：自动备份中 - AUTO_BACKUPED：自动备份结束 - AUTO_BACKUP_FAIL：自动备份失败 - MANUAL_BACKUPING：手动备份中 - MANUAL_BACKUPED：手动备份结束 - MANUAL_BACKUP_FAIL：手动备份失败 - ISAP_WAITING：ISAP等待备份 - ISAP_BACKUPING：ISAP备份中 - ISAP_BACKUPED：ISAP备份成功 - ISAP_BACKUP_FAIL：ISAP备份失败 - ISAP_FILE_UPLOAD_WAITING：ISAP等待上传备份文件 - ISAP_FILE_UPLOADING：ISAP上传中
        /// </summary>
        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public string Progress { get; set; }

        /// <summary>
        /// 还原失败原因
        /// </summary>
        [JsonProperty("restore_task_fail_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string RestoreTaskFailReason { get; set; }

        /// <summary>
        /// 文件SHA256
        /// </summary>
        [JsonProperty("sha256", NullValueHandling = NullValueHandling.Ignore)]
        public string Sha256 { get; set; }

        /// <summary>
        /// 备份开始时间,yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupInfo {\n");
            sb.Append("  backupTaskFailReason: ").Append(BackupTaskFailReason).Append("\n");
            sb.Append("  backupTime: ").Append(BackupTime).Append("\n");
            sb.Append("  deleted: ").Append(Deleted).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  fileSize: ").Append(FileSize).Append("\n");
            sb.Append("  fileSizeUnit: ").Append(FileSizeUnit).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  percentage: ").Append(Percentage).Append("\n");
            sb.Append("  progress: ").Append(Progress).Append("\n");
            sb.Append("  restoreTaskFailReason: ").Append(RestoreTaskFailReason).Append("\n");
            sb.Append("  sha256: ").Append(Sha256).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackupInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackupInfo input)
        {
            if (input == null) return false;
            if (this.BackupTaskFailReason != input.BackupTaskFailReason || (this.BackupTaskFailReason != null && !this.BackupTaskFailReason.Equals(input.BackupTaskFailReason))) return false;
            if (this.BackupTime != input.BackupTime || (this.BackupTime != null && !this.BackupTime.Equals(input.BackupTime))) return false;
            if (this.Deleted != input.Deleted || (this.Deleted != null && !this.Deleted.Equals(input.Deleted))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.FileSize != input.FileSize || (this.FileSize != null && !this.FileSize.Equals(input.FileSize))) return false;
            if (this.FileSizeUnit != input.FileSizeUnit || (this.FileSizeUnit != null && !this.FileSizeUnit.Equals(input.FileSizeUnit))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Mode != input.Mode || (this.Mode != null && !this.Mode.Equals(input.Mode))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Percentage != input.Percentage || (this.Percentage != null && !this.Percentage.Equals(input.Percentage))) return false;
            if (this.Progress != input.Progress || (this.Progress != null && !this.Progress.Equals(input.Progress))) return false;
            if (this.RestoreTaskFailReason != input.RestoreTaskFailReason || (this.RestoreTaskFailReason != null && !this.RestoreTaskFailReason.Equals(input.RestoreTaskFailReason))) return false;
            if (this.Sha256 != input.Sha256 || (this.Sha256 != null && !this.Sha256.Equals(input.Sha256))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;

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
                if (this.BackupTaskFailReason != null) hashCode = hashCode * 59 + this.BackupTaskFailReason.GetHashCode();
                if (this.BackupTime != null) hashCode = hashCode * 59 + this.BackupTime.GetHashCode();
                if (this.Deleted != null) hashCode = hashCode * 59 + this.Deleted.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.FileSize != null) hashCode = hashCode * 59 + this.FileSize.GetHashCode();
                if (this.FileSizeUnit != null) hashCode = hashCode * 59 + this.FileSizeUnit.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Mode != null) hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Percentage != null) hashCode = hashCode * 59 + this.Percentage.GetHashCode();
                if (this.Progress != null) hashCode = hashCode * 59 + this.Progress.GetHashCode();
                if (this.RestoreTaskFailReason != null) hashCode = hashCode * 59 + this.RestoreTaskFailReason.GetHashCode();
                if (this.Sha256 != null) hashCode = hashCode * 59 + this.Sha256.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
