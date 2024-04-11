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
    /// 对比列表信息体
    /// </summary>
    public class CompareJobInfo 
    {

        /// <summary>
        /// 对比任务ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 对比类型。 - lines：行数对比 - contents：内容对比 - random：抽样对比，当前仅支持gaussdbv5、gaussdbv5-to-postgresql、gaussdbv5ha-to-postgresql链路。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 对比配置项，key-value形式。 内容对比支持以下配置项： - 对比方式配置，key：contentCompareType，value：dynamic表示动态对比，static表示静态对比。 - lob字段对比类型配置，key：lobCompare，value：ignore表示忽略，length表示长度对比。  行数对比支持以下配置项： - 对比策略配置，多表归一情况下适用，key：comparePolicy，value：normal表示正常对比，manyToOne表示多对一对比。
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Options { get; set; }

        /// <summary>
        /// 开始时间，UTC时间，例如：2020-09-01T18:50:20Z。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间，UTC时间，例如：2020-09-01T18:50:20Z。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 对比任务的状态。 - RUNNING-运行中 - WAITING_FOR_RUNNING-等待启动中 - SUCCESSFUL-完成 - FAILED-失败 - CANCELLED-已取消 - TIMEOUT_INTERRUPT-超时中断 - FULL_DOING-全量校验中 - INCRE_DOING-增量校验中
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 导出对比结果状态。 - INIT：初始状态 - EXPORTING：对比结果导出中 - EXPORT_COMPLETE：对比结果导出完成 - EXPORT_COMMON_FAILED：对比结果导出失败
        /// </summary>
        [JsonProperty("export_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ExportStatus { get; set; }

        /// <summary>
        /// 导出比对结果有效期剩余时间。
        /// </summary>
        [JsonProperty("report_remain_seconds", NullValueHandling = NullValueHandling.Ignore)]
        public long? ReportRemainSeconds { get; set; }

        /// <summary>
        /// 对比任务的标签，当前仅涉及对比策略时返回。
        /// </summary>
        [JsonProperty("compare_job_tag", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> CompareJobTag { get; set; }

        /// <summary>
        /// 抽样比例，对比类型为抽样对比时填写。
        /// </summary>
        [JsonProperty("proportion_value", NullValueHandling = NullValueHandling.Ignore)]
        public string ProportionValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompareJobInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  options: ").Append(Options).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  exportStatus: ").Append(ExportStatus).Append("\n");
            sb.Append("  reportRemainSeconds: ").Append(ReportRemainSeconds).Append("\n");
            sb.Append("  compareJobTag: ").Append(CompareJobTag).Append("\n");
            sb.Append("  proportionValue: ").Append(ProportionValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CompareJobInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CompareJobInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    input.Options != null &&
                    this.Options.SequenceEqual(input.Options)
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
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
                    this.CompareJobTag == input.CompareJobTag ||
                    this.CompareJobTag != null &&
                    input.CompareJobTag != null &&
                    this.CompareJobTag.SequenceEqual(input.CompareJobTag)
                ) && 
                (
                    this.ProportionValue == input.ProportionValue ||
                    (this.ProportionValue != null &&
                    this.ProportionValue.Equals(input.ProportionValue))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ExportStatus != null)
                    hashCode = hashCode * 59 + this.ExportStatus.GetHashCode();
                if (this.ReportRemainSeconds != null)
                    hashCode = hashCode * 59 + this.ReportRemainSeconds.GetHashCode();
                if (this.CompareJobTag != null)
                    hashCode = hashCode * 59 + this.CompareJobTag.GetHashCode();
                if (this.ProportionValue != null)
                    hashCode = hashCode * 59 + this.ProportionValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
