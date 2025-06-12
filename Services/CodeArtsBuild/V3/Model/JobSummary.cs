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
    public class JobSummary 
    {

        /// <summary>
        /// 构建成功率
        /// </summary>
        [JsonProperty("avg_success_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public int? AvgSuccessRatio { get; set; }

        /// <summary>
        /// 构建总时长
        /// </summary>
        [JsonProperty("build_no", NullValueHandling = NullValueHandling.Ignore)]
        public int? BuildNo { get; set; }

        /// <summary>
        /// 任务总数
        /// </summary>
        [JsonProperty("job_total", NullValueHandling = NullValueHandling.Ignore)]
        public int? JobTotal { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [JsonProperty("version_total", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionTotal { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobSummary {\n");
            sb.Append("  avgSuccessRatio: ").Append(AvgSuccessRatio).Append("\n");
            sb.Append("  buildNo: ").Append(BuildNo).Append("\n");
            sb.Append("  jobTotal: ").Append(JobTotal).Append("\n");
            sb.Append("  versionTotal: ").Append(VersionTotal).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobSummary);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobSummary input)
        {
            if (input == null) return false;
            if (this.AvgSuccessRatio != input.AvgSuccessRatio || (this.AvgSuccessRatio != null && !this.AvgSuccessRatio.Equals(input.AvgSuccessRatio))) return false;
            if (this.BuildNo != input.BuildNo || (this.BuildNo != null && !this.BuildNo.Equals(input.BuildNo))) return false;
            if (this.JobTotal != input.JobTotal || (this.JobTotal != null && !this.JobTotal.Equals(input.JobTotal))) return false;
            if (this.VersionTotal != input.VersionTotal || (this.VersionTotal != null && !this.VersionTotal.Equals(input.VersionTotal))) return false;

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
                if (this.AvgSuccessRatio != null) hashCode = hashCode * 59 + this.AvgSuccessRatio.GetHashCode();
                if (this.BuildNo != null) hashCode = hashCode * 59 + this.BuildNo.GetHashCode();
                if (this.JobTotal != null) hashCode = hashCode * 59 + this.JobTotal.GetHashCode();
                if (this.VersionTotal != null) hashCode = hashCode * 59 + this.VersionTotal.GetHashCode();
                return hashCode;
            }
        }
    }
}
