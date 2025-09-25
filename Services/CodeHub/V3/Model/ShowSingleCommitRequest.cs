using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowSingleCommitRequest 
    {

        /// <summary>
        /// 仓库短id
        /// </summary>
        [SDKProperty("repo_id", IsPath = true)]
        [JsonProperty("repo_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepoId { get; set; }

        /// <summary>
        /// commit id，仓库的branch名或tag名
        /// </summary>
        [SDKProperty("sha", IsPath = true)]
        [JsonProperty("sha", NullValueHandling = NullValueHandling.Ignore)]
        public string Sha { get; set; }

        /// <summary>
        /// 包括提交统计信息。默认值为true
        /// </summary>
        [SDKProperty("stats", IsQuery = true)]
        [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Stats { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSingleCommitRequest {\n");
            sb.Append("  repoId: ").Append(RepoId).Append("\n");
            sb.Append("  sha: ").Append(Sha).Append("\n");
            sb.Append("  stats: ").Append(Stats).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSingleCommitRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSingleCommitRequest input)
        {
            if (input == null) return false;
            if (this.RepoId != input.RepoId || (this.RepoId != null && !this.RepoId.Equals(input.RepoId))) return false;
            if (this.Sha != input.Sha || (this.Sha != null && !this.Sha.Equals(input.Sha))) return false;
            if (this.Stats != input.Stats || (this.Stats != null && !this.Stats.Equals(input.Stats))) return false;

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
                if (this.RepoId != null) hashCode = hashCode * 59 + this.RepoId.GetHashCode();
                if (this.Sha != null) hashCode = hashCode * 59 + this.Sha.GetHashCode();
                if (this.Stats != null) hashCode = hashCode * 59 + this.Stats.GetHashCode();
                return hashCode;
            }
        }
    }
}
