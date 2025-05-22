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
    /// 构建成功率
    /// </summary>
    public class ShowJobBuildSuccessRatioResult 
    {

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 分支
        /// </summary>
        [JsonProperty("branch", NullValueHandling = NullValueHandling.Ignore)]
        public string Branch { get; set; }

        /// <summary>
        /// 构建成功总数
        /// </summary>
        [JsonProperty("total_success_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalSuccessCount { get; set; }

        /// <summary>
        /// 构建总数
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 总成功比率分数
        /// </summary>
        [JsonProperty("total_success_ratio_fraction", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalSuccessRatioFraction { get; set; }

        /// <summary>
        /// 每日构建成功率
        /// </summary>
        [JsonProperty("every_day_report", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowJobBuildSuccessRatioResultEveryDayReport> EveryDayReport { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowJobBuildSuccessRatioResult {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  branch: ").Append(Branch).Append("\n");
            sb.Append("  totalSuccessCount: ").Append(TotalSuccessCount).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  totalSuccessRatioFraction: ").Append(TotalSuccessRatioFraction).Append("\n");
            sb.Append("  everyDayReport: ").Append(EveryDayReport).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowJobBuildSuccessRatioResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowJobBuildSuccessRatioResult input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.Branch != input.Branch || (this.Branch != null && !this.Branch.Equals(input.Branch))) return false;
            if (this.TotalSuccessCount != input.TotalSuccessCount || (this.TotalSuccessCount != null && !this.TotalSuccessCount.Equals(input.TotalSuccessCount))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.TotalSuccessRatioFraction != input.TotalSuccessRatioFraction || (this.TotalSuccessRatioFraction != null && !this.TotalSuccessRatioFraction.Equals(input.TotalSuccessRatioFraction))) return false;
            if (this.EveryDayReport != input.EveryDayReport || (this.EveryDayReport != null && input.EveryDayReport != null && !this.EveryDayReport.SequenceEqual(input.EveryDayReport))) return false;

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
                if (this.Branch != null) hashCode = hashCode * 59 + this.Branch.GetHashCode();
                if (this.TotalSuccessCount != null) hashCode = hashCode * 59 + this.TotalSuccessCount.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.TotalSuccessRatioFraction != null) hashCode = hashCode * 59 + this.TotalSuccessRatioFraction.GetHashCode();
                if (this.EveryDayReport != null) hashCode = hashCode * 59 + this.EveryDayReport.GetHashCode();
                return hashCode;
            }
        }
    }
}
