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
    public class ListCommitStatisticsRequest 
    {

        /// <summary>
        /// 分支名
        /// </summary>
        [SDKProperty("branch_name", IsQuery = true)]
        [JsonProperty("branch_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchName { get; set; }

        /// <summary>
        /// 仓库的主键id
        /// </summary>
        [SDKProperty("repository_id", IsPath = true)]
        [JsonProperty("repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RepositoryId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCommitStatisticsRequest {\n");
            sb.Append("  branchName: ").Append(BranchName).Append("\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCommitStatisticsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCommitStatisticsRequest input)
        {
            if (input == null) return false;
            if (this.BranchName != input.BranchName || (this.BranchName != null && !this.BranchName.Equals(input.BranchName))) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;

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
                if (this.BranchName != null) hashCode = hashCode * 59 + this.BranchName.GetHashCode();
                if (this.RepositoryId != null) hashCode = hashCode * 59 + this.RepositoryId.GetHashCode();
                return hashCode;
            }
        }
    }
}
