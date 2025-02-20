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
    /// 一键诊断响应体。
    /// </summary>
    public class QueryDiagnosisResult 
    {

        /// <summary>
        /// 得分。
        /// </summary>
        [JsonProperty("score", NullValueHandling = NullValueHandling.Ignore)]
        public int? Score { get; set; }

        /// <summary>
        /// 状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 进度。
        /// </summary>
        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public int? Progress { get; set; }

        /// <summary>
        /// 失败原因。
        /// </summary>
        [JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 开始时间。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 诊断项总数。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public long? Total { get; set; }

        /// <summary>
        /// 正常数量。
        /// </summary>
        [JsonProperty("normal_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? NormalCount { get; set; }

        /// <summary>
        /// 异常数量。
        /// </summary>
        [JsonProperty("abnormal_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? AbnormalCount { get; set; }

        /// <summary>
        /// 告警数量。
        /// </summary>
        [JsonProperty("alarm_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? AlarmCount { get; set; }

        /// <summary>
        /// 失败数量。
        /// </summary>
        [JsonProperty("failure_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? FailureCount { get; set; }

        /// <summary>
        /// 超时数量。
        /// </summary>
        [JsonProperty("timeout_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? TimeoutCount { get; set; }

        /// <summary>
        /// 诊断结果。
        /// </summary>
        [JsonProperty("diagnosis_results", NullValueHandling = NullValueHandling.Ignore)]
        public List<QueryDiagnosisResultDiagnosisResults> DiagnosisResults { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryDiagnosisResult {\n");
            sb.Append("  score: ").Append(Score).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  progress: ").Append(Progress).Append("\n");
            sb.Append("  errorMsg: ").Append(ErrorMsg).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  normalCount: ").Append(NormalCount).Append("\n");
            sb.Append("  abnormalCount: ").Append(AbnormalCount).Append("\n");
            sb.Append("  alarmCount: ").Append(AlarmCount).Append("\n");
            sb.Append("  failureCount: ").Append(FailureCount).Append("\n");
            sb.Append("  timeoutCount: ").Append(TimeoutCount).Append("\n");
            sb.Append("  diagnosisResults: ").Append(DiagnosisResults).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryDiagnosisResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryDiagnosisResult input)
        {
            if (input == null) return false;
            if (this.Score != input.Score || (this.Score != null && !this.Score.Equals(input.Score))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Progress != input.Progress || (this.Progress != null && !this.Progress.Equals(input.Progress))) return false;
            if (this.ErrorMsg != input.ErrorMsg || (this.ErrorMsg != null && !this.ErrorMsg.Equals(input.ErrorMsg))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.NormalCount != input.NormalCount || (this.NormalCount != null && !this.NormalCount.Equals(input.NormalCount))) return false;
            if (this.AbnormalCount != input.AbnormalCount || (this.AbnormalCount != null && !this.AbnormalCount.Equals(input.AbnormalCount))) return false;
            if (this.AlarmCount != input.AlarmCount || (this.AlarmCount != null && !this.AlarmCount.Equals(input.AlarmCount))) return false;
            if (this.FailureCount != input.FailureCount || (this.FailureCount != null && !this.FailureCount.Equals(input.FailureCount))) return false;
            if (this.TimeoutCount != input.TimeoutCount || (this.TimeoutCount != null && !this.TimeoutCount.Equals(input.TimeoutCount))) return false;
            if (this.DiagnosisResults != input.DiagnosisResults || (this.DiagnosisResults != null && input.DiagnosisResults != null && !this.DiagnosisResults.SequenceEqual(input.DiagnosisResults))) return false;

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
                if (this.Score != null) hashCode = hashCode * 59 + this.Score.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Progress != null) hashCode = hashCode * 59 + this.Progress.GetHashCode();
                if (this.ErrorMsg != null) hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.NormalCount != null) hashCode = hashCode * 59 + this.NormalCount.GetHashCode();
                if (this.AbnormalCount != null) hashCode = hashCode * 59 + this.AbnormalCount.GetHashCode();
                if (this.AlarmCount != null) hashCode = hashCode * 59 + this.AlarmCount.GetHashCode();
                if (this.FailureCount != null) hashCode = hashCode * 59 + this.FailureCount.GetHashCode();
                if (this.TimeoutCount != null) hashCode = hashCode * 59 + this.TimeoutCount.GetHashCode();
                if (this.DiagnosisResults != null) hashCode = hashCode * 59 + this.DiagnosisResults.GetHashCode();
                return hashCode;
            }
        }
    }
}
