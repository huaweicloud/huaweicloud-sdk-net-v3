using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 单元测试报告
    /// </summary>
    public class ShowReportSummary 
    {

        /// <summary>
        /// 任务编号
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 构建编号
        /// </summary>
        [JsonProperty("build_no", NullValueHandling = NullValueHandling.Ignore)]
        public int? BuildNo { get; set; }

        /// <summary>
        /// 步骤名称，对应构建步骤，例如stage2
        /// </summary>
        [JsonProperty("stage_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StageName { get; set; }

        /// <summary>
        /// 报告编号
        /// </summary>
        [JsonProperty("root_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RootId { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 成功数量
        /// </summary>
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public int? Success { get; set; }

        /// <summary>
        /// 失败数量
        /// </summary>
        [JsonProperty("failures", NullValueHandling = NullValueHandling.Ignore)]
        public int? Failures { get; set; }

        /// <summary>
        /// 错误数量
        /// </summary>
        [JsonProperty("errors", NullValueHandling = NullValueHandling.Ignore)]
        public int? Errors { get; set; }

        /// <summary>
        /// 其他
        /// </summary>
        [JsonProperty("others", NullValueHandling = NullValueHandling.Ignore)]
        public int? Others { get; set; }

        /// <summary>
        /// 执行耗时
        /// </summary>
        [JsonProperty("execution_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExecutionTime { get; set; }

        /// <summary>
        /// 生成时间
        /// </summary>
        [JsonProperty("genrate_time", NullValueHandling = NullValueHandling.Ignore)]
        public string GenrateTime { get; set; }

        /// <summary>
        /// 局点
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 是否通过
        /// </summary>
        [JsonProperty("is_success", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSuccess { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowReportSummary {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  buildNo: ").Append(BuildNo).Append("\n");
            sb.Append("  stageName: ").Append(StageName).Append("\n");
            sb.Append("  rootId: ").Append(RootId).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  success: ").Append(Success).Append("\n");
            sb.Append("  failures: ").Append(Failures).Append("\n");
            sb.Append("  errors: ").Append(Errors).Append("\n");
            sb.Append("  others: ").Append(Others).Append("\n");
            sb.Append("  executionTime: ").Append(ExecutionTime).Append("\n");
            sb.Append("  genrateTime: ").Append(GenrateTime).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  isSuccess: ").Append(IsSuccess).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowReportSummary);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowReportSummary input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.BuildNo != input.BuildNo || (this.BuildNo != null && !this.BuildNo.Equals(input.BuildNo))) return false;
            if (this.StageName != input.StageName || (this.StageName != null && !this.StageName.Equals(input.StageName))) return false;
            if (this.RootId != input.RootId || (this.RootId != null && !this.RootId.Equals(input.RootId))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.Success != input.Success || (this.Success != null && !this.Success.Equals(input.Success))) return false;
            if (this.Failures != input.Failures || (this.Failures != null && !this.Failures.Equals(input.Failures))) return false;
            if (this.Errors != input.Errors || (this.Errors != null && !this.Errors.Equals(input.Errors))) return false;
            if (this.Others != input.Others || (this.Others != null && !this.Others.Equals(input.Others))) return false;
            if (this.ExecutionTime != input.ExecutionTime || (this.ExecutionTime != null && !this.ExecutionTime.Equals(input.ExecutionTime))) return false;
            if (this.GenrateTime != input.GenrateTime || (this.GenrateTime != null && !this.GenrateTime.Equals(input.GenrateTime))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.IsSuccess != input.IsSuccess || (this.IsSuccess != null && !this.IsSuccess.Equals(input.IsSuccess))) return false;

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
                if (this.BuildNo != null) hashCode = hashCode * 59 + this.BuildNo.GetHashCode();
                if (this.StageName != null) hashCode = hashCode * 59 + this.StageName.GetHashCode();
                if (this.RootId != null) hashCode = hashCode * 59 + this.RootId.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Success != null) hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.Failures != null) hashCode = hashCode * 59 + this.Failures.GetHashCode();
                if (this.Errors != null) hashCode = hashCode * 59 + this.Errors.GetHashCode();
                if (this.Others != null) hashCode = hashCode * 59 + this.Others.GetHashCode();
                if (this.ExecutionTime != null) hashCode = hashCode * 59 + this.ExecutionTime.GetHashCode();
                if (this.GenrateTime != null) hashCode = hashCode * 59 + this.GenrateTime.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.IsSuccess != null) hashCode = hashCode * 59 + this.IsSuccess.GetHashCode();
                return hashCode;
            }
        }
    }
}
