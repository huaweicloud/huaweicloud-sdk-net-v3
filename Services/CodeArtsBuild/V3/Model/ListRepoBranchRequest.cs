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
    public class ListRepoBranchRequest 
    {

        /// <summary>
        /// 构建的任务ID； 编辑构建任务时，浏览器URL末尾的32位数字、字母组合的字符串。
        /// </summary>
        [SDKProperty("job_id", IsQuery = true)]
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 代码仓库名，不支持中文
        /// </summary>
        [SDKProperty("repository_name", IsQuery = true)]
        [JsonProperty("repository_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RepositoryName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRepoBranchRequest {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  repositoryName: ").Append(RepositoryName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRepoBranchRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRepoBranchRequest input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.RepositoryName != input.RepositoryName || (this.RepositoryName != null && !this.RepositoryName.Equals(input.RepositoryName))) return false;

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
                return hashCode;
            }
        }
    }
}
