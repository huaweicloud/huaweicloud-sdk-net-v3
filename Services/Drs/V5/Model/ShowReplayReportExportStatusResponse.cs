using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowReplayReportExportStatusResponse : SdkResponse
    {

        /// <summary>
        /// 导出状态。取值范围： - EXPORTING ：导出中 - EXPORT_COMPLETE ：导出完成 - EXPORT_COMMON_FAILED ：导出失败
        /// </summary>
        [JsonProperty("export_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ExportStatus { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 导出的sql文件类型。取值范围： - abnormal_sql ：异常sql列表 - error_sql_detail ：异常sql详情 - slow_sql ：慢sql列表 - slow_sql_detail ： 慢sql详情
        /// </summary>
        [JsonProperty("file_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FileType { get; set; }

        /// <summary>
        /// 失败原因
        /// </summary>
        [JsonProperty("failed_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string FailedReason { get; set; }

        /// <summary>
        /// 导出的数据总量
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// 当前已经处理数据量
        /// </summary>
        [JsonProperty("current_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? CurrentCount { get; set; }

        /// <summary>
        /// 任务进度百分数
        /// </summary>
        [JsonProperty("progress_percentage", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProgressPercentage { get; set; }

        /// <summary>
        /// 已经上传到obs的文件名称
        /// </summary>
        [JsonProperty("uploaded_file_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UploadedFileNames { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowReplayReportExportStatusResponse {\n");
            sb.Append("  exportStatus: ").Append(ExportStatus).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  fileType: ").Append(FileType).Append("\n");
            sb.Append("  failedReason: ").Append(FailedReason).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  currentCount: ").Append(CurrentCount).Append("\n");
            sb.Append("  progressPercentage: ").Append(ProgressPercentage).Append("\n");
            sb.Append("  uploadedFileNames: ").Append(UploadedFileNames).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowReplayReportExportStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowReplayReportExportStatusResponse input)
        {
            if (input == null) return false;
            if (this.ExportStatus != input.ExportStatus || (this.ExportStatus != null && !this.ExportStatus.Equals(input.ExportStatus))) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.FileType != input.FileType || (this.FileType != null && !this.FileType.Equals(input.FileType))) return false;
            if (this.FailedReason != input.FailedReason || (this.FailedReason != null && !this.FailedReason.Equals(input.FailedReason))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.CurrentCount != input.CurrentCount || (this.CurrentCount != null && !this.CurrentCount.Equals(input.CurrentCount))) return false;
            if (this.ProgressPercentage != input.ProgressPercentage || (this.ProgressPercentage != null && !this.ProgressPercentage.Equals(input.ProgressPercentage))) return false;
            if (this.UploadedFileNames != input.UploadedFileNames || (this.UploadedFileNames != null && input.UploadedFileNames != null && !this.UploadedFileNames.SequenceEqual(input.UploadedFileNames))) return false;

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
                if (this.ExportStatus != null) hashCode = hashCode * 59 + this.ExportStatus.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.FileType != null) hashCode = hashCode * 59 + this.FileType.GetHashCode();
                if (this.FailedReason != null) hashCode = hashCode * 59 + this.FailedReason.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.CurrentCount != null) hashCode = hashCode * 59 + this.CurrentCount.GetHashCode();
                if (this.ProgressPercentage != null) hashCode = hashCode * 59 + this.ProgressPercentage.GetHashCode();
                if (this.UploadedFileNames != null) hashCode = hashCode * 59 + this.UploadedFileNames.GetHashCode();
                return hashCode;
            }
        }
    }
}
