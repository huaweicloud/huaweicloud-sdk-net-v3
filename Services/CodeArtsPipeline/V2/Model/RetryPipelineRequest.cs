using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// 重试运行流水线请求体。
    /// </summary>
    public class RetryPipelineRequest 
    {

        /// <summary>
        /// **参数解释**： 仓库HTTPS地址。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("repo_https_url", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoHttpsUrl { get; set; }

        /// <summary>
        /// **参数解释**： 流水线任务运行ID列表。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("job_run_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> JobRunIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetryPipelineRequest {\n");
            sb.Append("  repoHttpsUrl: ").Append(RepoHttpsUrl).Append("\n");
            sb.Append("  jobRunIds: ").Append(JobRunIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RetryPipelineRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RetryPipelineRequest input)
        {
            if (input == null) return false;
            if (this.RepoHttpsUrl != input.RepoHttpsUrl || (this.RepoHttpsUrl != null && !this.RepoHttpsUrl.Equals(input.RepoHttpsUrl))) return false;
            if (this.JobRunIds != input.JobRunIds || (this.JobRunIds != null && input.JobRunIds != null && !this.JobRunIds.SequenceEqual(input.JobRunIds))) return false;

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
                if (this.RepoHttpsUrl != null) hashCode = hashCode * 59 + this.RepoHttpsUrl.GetHashCode();
                if (this.JobRunIds != null) hashCode = hashCode * 59 + this.JobRunIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
