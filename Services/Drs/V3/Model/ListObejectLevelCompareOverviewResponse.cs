using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListObejectLevelCompareOverviewResponse : SdkResponse
    {

        /// <summary>
        /// 对比任务创建时间，UTC时间，例如：2024-04-09T07:00:57Z。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 对比任务开始时间，UTC时间，例如：2024-04-09T07:00:57Z。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 对比任务状态。 取值： - RUNNING：运行中。 - WAITING_FOR_RUNNING：等待启动中。 - SUCCESSFUL：完成。 - FAILED：失败。 - CANCELLED：已取消。 - TIMEOUT_INTERRUPT：超时中断。 - FULL_DOING：全量校验中。 - INCRE_DOING：增量校验中。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 生成对比结果报告文件的状态：  - INIT：初始状态。  - EXPORTING：对比结果导出中。  - EXPORT_COMPLETE：对比结果导出完成。  - EXPORT_COMMON_FAILED：对比结果导出失败。
        /// </summary>
        [JsonProperty("export_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ExportStatus { get; set; }

        /// <summary>
        /// 对比结果报告文件有效期剩余时间，单位秒，报告未生成时返回-1。
        /// </summary>
        [JsonProperty("report_remain_seconds", NullValueHandling = NullValueHandling.Ignore)]
        public long? ReportRemainSeconds { get; set; }

        /// <summary>
        /// 对比任务ID。
        /// </summary>
        [JsonProperty("compare_job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CompareJobId { get; set; }

        /// <summary>
        /// 失败原因。
        /// </summary>
        [JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 对比结果。
        /// </summary>
        [JsonProperty("compare_result", NullValueHandling = NullValueHandling.Ignore)]
        public List<ObjectsCompareOverviewInfo> CompareResult { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListObejectLevelCompareOverviewResponse {\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  exportStatus: ").Append(ExportStatus).Append("\n");
            sb.Append("  reportRemainSeconds: ").Append(ReportRemainSeconds).Append("\n");
            sb.Append("  compareJobId: ").Append(CompareJobId).Append("\n");
            sb.Append("  errorMsg: ").Append(ErrorMsg).Append("\n");
            sb.Append("  compareResult: ").Append(CompareResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListObejectLevelCompareOverviewResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListObejectLevelCompareOverviewResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.ExportStatus == input.ExportStatus ||
                    (this.ExportStatus != null &&
                    this.ExportStatus.Equals(input.ExportStatus))
                ) && 
                (
                    this.ReportRemainSeconds == input.ReportRemainSeconds ||
                    (this.ReportRemainSeconds != null &&
                    this.ReportRemainSeconds.Equals(input.ReportRemainSeconds))
                ) && 
                (
                    this.CompareJobId == input.CompareJobId ||
                    (this.CompareJobId != null &&
                    this.CompareJobId.Equals(input.CompareJobId))
                ) && 
                (
                    this.ErrorMsg == input.ErrorMsg ||
                    (this.ErrorMsg != null &&
                    this.ErrorMsg.Equals(input.ErrorMsg))
                ) && 
                (
                    this.CompareResult == input.CompareResult ||
                    this.CompareResult != null &&
                    input.CompareResult != null &&
                    this.CompareResult.SequenceEqual(input.CompareResult)
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
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ExportStatus != null)
                    hashCode = hashCode * 59 + this.ExportStatus.GetHashCode();
                if (this.ReportRemainSeconds != null)
                    hashCode = hashCode * 59 + this.ReportRemainSeconds.GetHashCode();
                if (this.CompareJobId != null)
                    hashCode = hashCode * 59 + this.CompareJobId.GetHashCode();
                if (this.ErrorMsg != null)
                    hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
                if (this.CompareResult != null)
                    hashCode = hashCode * 59 + this.CompareResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
