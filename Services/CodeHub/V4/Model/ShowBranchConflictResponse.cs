using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowBranchConflictResponse : SdkResponse
    {

        /// <summary>
        /// 源仓库id
        /// </summary>
        [JsonProperty("source_repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SourceRepositoryId { get; set; }

        /// <summary>
        /// 目标仓库id
        /// </summary>
        [JsonProperty("target_repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? TargetRepositoryId { get; set; }

        /// <summary>
        /// 源分支
        /// </summary>
        [JsonProperty("source_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceBranch { get; set; }

        /// <summary>
        /// 目标分支
        /// </summary>
        [JsonProperty("target_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetBranch { get; set; }

        /// <summary>
        /// 是否有冲突
        /// </summary>
        [JsonProperty("is_conflict", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsConflict { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBranchConflictResponse {\n");
            sb.Append("  sourceRepositoryId: ").Append(SourceRepositoryId).Append("\n");
            sb.Append("  targetRepositoryId: ").Append(TargetRepositoryId).Append("\n");
            sb.Append("  sourceBranch: ").Append(SourceBranch).Append("\n");
            sb.Append("  targetBranch: ").Append(TargetBranch).Append("\n");
            sb.Append("  isConflict: ").Append(IsConflict).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowBranchConflictResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowBranchConflictResponse input)
        {
            if (input == null) return false;
            if (this.SourceRepositoryId != input.SourceRepositoryId || (this.SourceRepositoryId != null && !this.SourceRepositoryId.Equals(input.SourceRepositoryId))) return false;
            if (this.TargetRepositoryId != input.TargetRepositoryId || (this.TargetRepositoryId != null && !this.TargetRepositoryId.Equals(input.TargetRepositoryId))) return false;
            if (this.SourceBranch != input.SourceBranch || (this.SourceBranch != null && !this.SourceBranch.Equals(input.SourceBranch))) return false;
            if (this.TargetBranch != input.TargetBranch || (this.TargetBranch != null && !this.TargetBranch.Equals(input.TargetBranch))) return false;
            if (this.IsConflict != input.IsConflict || (this.IsConflict != null && !this.IsConflict.Equals(input.IsConflict))) return false;

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
                if (this.SourceRepositoryId != null) hashCode = hashCode * 59 + this.SourceRepositoryId.GetHashCode();
                if (this.TargetRepositoryId != null) hashCode = hashCode * 59 + this.TargetRepositoryId.GetHashCode();
                if (this.SourceBranch != null) hashCode = hashCode * 59 + this.SourceBranch.GetHashCode();
                if (this.TargetBranch != null) hashCode = hashCode * 59 + this.TargetBranch.GetHashCode();
                if (this.IsConflict != null) hashCode = hashCode * 59 + this.IsConflict.GetHashCode();
                return hashCode;
            }
        }
    }
}
