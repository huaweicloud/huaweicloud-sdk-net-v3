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
    public class ListSubfilesRequest 
    {

        /// <summary>
        /// 仓库id
        /// </summary>
        [SDKProperty("repository_uuid", IsPath = true)]
        [JsonProperty("repository_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string RepositoryUuid { get; set; }

        /// <summary>
        /// 分支名称
        /// </summary>
        [SDKProperty("branch_name", IsPath = true)]
        [JsonProperty("branch_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchName { get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        [SDKProperty("path", IsQuery = true)]
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// 偏移量
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 记录数量
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSubfilesRequest {\n");
            sb.Append("  repositoryUuid: ").Append(RepositoryUuid).Append("\n");
            sb.Append("  branchName: ").Append(BranchName).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSubfilesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSubfilesRequest input)
        {
            if (input == null) return false;
            if (this.RepositoryUuid != input.RepositoryUuid || (this.RepositoryUuid != null && !this.RepositoryUuid.Equals(input.RepositoryUuid))) return false;
            if (this.BranchName != input.BranchName || (this.BranchName != null && !this.BranchName.Equals(input.BranchName))) return false;
            if (this.Path != input.Path || (this.Path != null && !this.Path.Equals(input.Path))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                if (this.RepositoryUuid != null) hashCode = hashCode * 59 + this.RepositoryUuid.GetHashCode();
                if (this.BranchName != null) hashCode = hashCode * 59 + this.BranchName.GetHashCode();
                if (this.Path != null) hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
