using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CollectedWdrSnapshotInfoResult 
    {

        /// <summary>
        /// **参数解释**： 任务ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// **参数解释**： 采集类型。 **取值范围**： - 实例级则为cluster。 - 组件级则为component。
        /// </summary>
        [JsonProperty("wdr_type", NullValueHandling = NullValueHandling.Ignore)]
        public string WdrType { get; set; }

        /// <summary>
        /// **参数解释**： 文件大小单位kb。当status为SUCCESS时，该值不为空。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("file_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? FileSize { get; set; }

        /// <summary>
        /// **参数解释**： 下发采集时填写的开始snapshot时间。格式为“yyyy-mm-ddThh:mm:ssZ”。其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// **参数解释**： 下发采集时填写的结束snapshot时间。格式为“yyyy-mm-ddThh:mm:ssZ”。其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// **参数解释**： 报告下载链接，有效时间为30分钟。当status为SUCCESS时，该值不为空。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("download_url", NullValueHandling = NullValueHandling.Ignore)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// **参数解释**： 采集状态。 **取值范围**: - SUCCESS：采集成功。 - FAILED：采集失败。 - EXPORTING：采集中。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**： 备注。采集类型为组件级时，内容包括采集的组件ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("notes", NullValueHandling = NullValueHandling.Ignore)]
        public string Notes { get; set; }

        /// <summary>
        /// **参数解释**： WDR报告生成任务的创建时间。格式为“yyyy-mm-ddThh:mm:ssZ”。其中，T指某个时间的开始，Z指时区偏移量，当前时间固定为+0时区。例如，\&quot;2025-07-08T10:57:59+0000\&quot;。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("job_create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string JobCreateTime { get; set; }

        /// <summary>
        /// **参数解释**： 用于生成WDR报告的第一个对比快照ID。例如：\&quot;20024\&quot;。只针对使用报告生成模式为对比快照ID（mode&#x3D;snapshot_id）的采集任务生效；如果该任务使用的是时间区间查询方式（mode&#x3D;time_range），则该字段为空。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("start_snapshot_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StartSnapshotId { get; set; }

        /// <summary>
        /// **参数解释**： 用于生成WDR报告的第二个对比快照ID。例如：\&quot;20025\&quot;。只针对使用报告生成模式为对比快照ID（mode&#x3D;snapshot_id）的采集任务生效；如果该任务使用的是时间区间查询方式（mode&#x3D;time_range）来生成的，则该字段为空。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("end_snapshot_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EndSnapshotId { get; set; }

        /// <summary>
        /// **参数解释**： WDR报告临时文件名称。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// **参数解释**： WDR报告临时文件保存路径。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("file_path", NullValueHandling = NullValueHandling.Ignore)]
        public string FilePath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("obs_bucket", NullValueHandling = NullValueHandling.Ignore)]
        public CollectedWdrSnapshotInfoResultObsBucket ObsBucket { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CollectedWdrSnapshotInfoResult {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  wdrType: ").Append(WdrType).Append("\n");
            sb.Append("  fileSize: ").Append(FileSize).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  downloadUrl: ").Append(DownloadUrl).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  notes: ").Append(Notes).Append("\n");
            sb.Append("  jobCreateTime: ").Append(JobCreateTime).Append("\n");
            sb.Append("  startSnapshotId: ").Append(StartSnapshotId).Append("\n");
            sb.Append("  endSnapshotId: ").Append(EndSnapshotId).Append("\n");
            sb.Append("  fileName: ").Append(FileName).Append("\n");
            sb.Append("  filePath: ").Append(FilePath).Append("\n");
            sb.Append("  obsBucket: ").Append(ObsBucket).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CollectedWdrSnapshotInfoResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CollectedWdrSnapshotInfoResult input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.WdrType != input.WdrType || (this.WdrType != null && !this.WdrType.Equals(input.WdrType))) return false;
            if (this.FileSize != input.FileSize || (this.FileSize != null && !this.FileSize.Equals(input.FileSize))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.DownloadUrl != input.DownloadUrl || (this.DownloadUrl != null && !this.DownloadUrl.Equals(input.DownloadUrl))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Notes != input.Notes || (this.Notes != null && !this.Notes.Equals(input.Notes))) return false;
            if (this.JobCreateTime != input.JobCreateTime || (this.JobCreateTime != null && !this.JobCreateTime.Equals(input.JobCreateTime))) return false;
            if (this.StartSnapshotId != input.StartSnapshotId || (this.StartSnapshotId != null && !this.StartSnapshotId.Equals(input.StartSnapshotId))) return false;
            if (this.EndSnapshotId != input.EndSnapshotId || (this.EndSnapshotId != null && !this.EndSnapshotId.Equals(input.EndSnapshotId))) return false;
            if (this.FileName != input.FileName || (this.FileName != null && !this.FileName.Equals(input.FileName))) return false;
            if (this.FilePath != input.FilePath || (this.FilePath != null && !this.FilePath.Equals(input.FilePath))) return false;
            if (this.ObsBucket != input.ObsBucket || (this.ObsBucket != null && !this.ObsBucket.Equals(input.ObsBucket))) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.WdrType != null) hashCode = hashCode * 59 + this.WdrType.GetHashCode();
                if (this.FileSize != null) hashCode = hashCode * 59 + this.FileSize.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.DownloadUrl != null) hashCode = hashCode * 59 + this.DownloadUrl.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Notes != null) hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.JobCreateTime != null) hashCode = hashCode * 59 + this.JobCreateTime.GetHashCode();
                if (this.StartSnapshotId != null) hashCode = hashCode * 59 + this.StartSnapshotId.GetHashCode();
                if (this.EndSnapshotId != null) hashCode = hashCode * 59 + this.EndSnapshotId.GetHashCode();
                if (this.FileName != null) hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.FilePath != null) hashCode = hashCode * 59 + this.FilePath.GetHashCode();
                if (this.ObsBucket != null) hashCode = hashCode * 59 + this.ObsBucket.GetHashCode();
                return hashCode;
            }
        }
    }
}
