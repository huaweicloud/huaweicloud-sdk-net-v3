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
    /// Request Object
    /// </summary>
    public class ShowJobBuildSuccessRatioRequest 
    {

        /// <summary>
        /// 构建的任务ID； 编辑构建任务时，浏览器URL末尾的32位数字、字母组合的字符串。
        /// </summary>
        [SDKProperty("job_id", IsQuery = true)]
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 代码仓名称。
        /// </summary>
        [SDKProperty("repository_name", IsQuery = true)]
        [JsonProperty("repository_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// 代码仓分支名。
        /// </summary>
        [SDKProperty("branch", IsQuery = true)]
        [JsonProperty("branch", NullValueHandling = NullValueHandling.Ignore)]
        public string Branch { get; set; }

        /// <summary>
        /// 查询时间，查最近几天的。
        /// </summary>
        [SDKProperty("interval", IsQuery = true)]
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? Interval { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowJobBuildSuccessRatioRequest {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  repositoryName: ").Append(RepositoryName).Append("\n");
            sb.Append("  branch: ").Append(Branch).Append("\n");
            sb.Append("  interval: ").Append(Interval).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowJobBuildSuccessRatioRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowJobBuildSuccessRatioRequest input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.RepositoryName != input.RepositoryName || (this.RepositoryName != null && !this.RepositoryName.Equals(input.RepositoryName))) return false;
            if (this.Branch != input.Branch || (this.Branch != null && !this.Branch.Equals(input.Branch))) return false;
            if (this.Interval != input.Interval || (this.Interval != null && !this.Interval.Equals(input.Interval))) return false;

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
                if (this.RepositoryName != null) hashCode = hashCode * 59 + this.RepositoryName.GetHashCode();
                if (this.Branch != null) hashCode = hashCode * 59 + this.Branch.GetHashCode();
                if (this.Interval != null) hashCode = hashCode * 59 + this.Interval.GetHashCode();
                return hashCode;
            }
        }
    }
}
