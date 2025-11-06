using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateBranchResponse : SdkResponse
    {

        /// <summary>
        /// 分支名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 是否为默认分支
        /// </summary>
        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Default { get; set; }

        /// <summary>
        /// 用户是否为默认分支
        /// </summary>
        [JsonProperty("can_delete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanDelete { get; set; }

        /// <summary>
        /// 是否为默认分支
        /// </summary>
        [JsonProperty("can_read", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanRead { get; set; }

        /// <summary>
        /// 是否为默认分支
        /// </summary>
        [JsonProperty("can_download", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanDownload { get; set; }

        /// <summary>
        /// 是否为默认分支
        /// </summary>
        [JsonProperty("can_push", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanPush { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("commit", NullValueHandling = NullValueHandling.Ignore)]
        public CommitDto Commit { get; set; }

        /// <summary>
        /// 所有提交是否合入到默认分支
        /// </summary>
        [JsonProperty("merged", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Merged { get; set; }

        /// <summary>
        /// 是否为保护分支
        /// </summary>
        [JsonProperty("protected", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Protected { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public UserBasicDto Creator { get; set; }

        /// <summary>
        /// 分支描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 基于分支
        /// </summary>
        [JsonProperty("create_source", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateSource { get; set; }

        /// <summary>
        /// 基于分支是否存在
        /// </summary>
        [JsonProperty("create_source_exists", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CreateSourceExists { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("latest_pipeline", NullValueHandling = NullValueHandling.Ignore)]
        public PipelineBasicDto LatestPipeline { get; set; }

        /// <summary>
        /// 该分支正在开启的合并请求个数
        /// </summary>
        [JsonProperty("opened_mr_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? OpenedMrCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("diverging_commit_counts", NullValueHandling = NullValueHandling.Ignore)]
        public DivergingCommitCounts DivergingCommitCounts { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateBranchResponse {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  canDelete: ").Append(CanDelete).Append("\n");
            sb.Append("  canRead: ").Append(CanRead).Append("\n");
            sb.Append("  canDownload: ").Append(CanDownload).Append("\n");
            sb.Append("  canPush: ").Append(CanPush).Append("\n");
            sb.Append("  commit: ").Append(Commit).Append("\n");
            sb.Append("  merged: ").Append(Merged).Append("\n");
            sb.Append("  Protected: ").Append(Protected).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  creator: ").Append(Creator).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  createSource: ").Append(CreateSource).Append("\n");
            sb.Append("  createSourceExists: ").Append(CreateSourceExists).Append("\n");
            sb.Append("  latestPipeline: ").Append(LatestPipeline).Append("\n");
            sb.Append("  openedMrCount: ").Append(OpenedMrCount).Append("\n");
            sb.Append("  divergingCommitCounts: ").Append(DivergingCommitCounts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateBranchResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateBranchResponse input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Default != input.Default || (this.Default != null && !this.Default.Equals(input.Default))) return false;
            if (this.CanDelete != input.CanDelete || (this.CanDelete != null && !this.CanDelete.Equals(input.CanDelete))) return false;
            if (this.CanRead != input.CanRead || (this.CanRead != null && !this.CanRead.Equals(input.CanRead))) return false;
            if (this.CanDownload != input.CanDownload || (this.CanDownload != null && !this.CanDownload.Equals(input.CanDownload))) return false;
            if (this.CanPush != input.CanPush || (this.CanPush != null && !this.CanPush.Equals(input.CanPush))) return false;
            if (this.Commit != input.Commit || (this.Commit != null && !this.Commit.Equals(input.Commit))) return false;
            if (this.Merged != input.Merged || (this.Merged != null && !this.Merged.Equals(input.Merged))) return false;
            if (this.Protected != input.Protected || (this.Protected != null && !this.Protected.Equals(input.Protected))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.Creator != input.Creator || (this.Creator != null && !this.Creator.Equals(input.Creator))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.CreateSource != input.CreateSource || (this.CreateSource != null && !this.CreateSource.Equals(input.CreateSource))) return false;
            if (this.CreateSourceExists != input.CreateSourceExists || (this.CreateSourceExists != null && !this.CreateSourceExists.Equals(input.CreateSourceExists))) return false;
            if (this.LatestPipeline != input.LatestPipeline || (this.LatestPipeline != null && !this.LatestPipeline.Equals(input.LatestPipeline))) return false;
            if (this.OpenedMrCount != input.OpenedMrCount || (this.OpenedMrCount != null && !this.OpenedMrCount.Equals(input.OpenedMrCount))) return false;
            if (this.DivergingCommitCounts != input.DivergingCommitCounts || (this.DivergingCommitCounts != null && !this.DivergingCommitCounts.Equals(input.DivergingCommitCounts))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Default != null) hashCode = hashCode * 59 + this.Default.GetHashCode();
                if (this.CanDelete != null) hashCode = hashCode * 59 + this.CanDelete.GetHashCode();
                if (this.CanRead != null) hashCode = hashCode * 59 + this.CanRead.GetHashCode();
                if (this.CanDownload != null) hashCode = hashCode * 59 + this.CanDownload.GetHashCode();
                if (this.CanPush != null) hashCode = hashCode * 59 + this.CanPush.GetHashCode();
                if (this.Commit != null) hashCode = hashCode * 59 + this.Commit.GetHashCode();
                if (this.Merged != null) hashCode = hashCode * 59 + this.Merged.GetHashCode();
                if (this.Protected != null) hashCode = hashCode * 59 + this.Protected.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Creator != null) hashCode = hashCode * 59 + this.Creator.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CreateSource != null) hashCode = hashCode * 59 + this.CreateSource.GetHashCode();
                if (this.CreateSourceExists != null) hashCode = hashCode * 59 + this.CreateSourceExists.GetHashCode();
                if (this.LatestPipeline != null) hashCode = hashCode * 59 + this.LatestPipeline.GetHashCode();
                if (this.OpenedMrCount != null) hashCode = hashCode * 59 + this.OpenedMrCount.GetHashCode();
                if (this.DivergingCommitCounts != null) hashCode = hashCode * 59 + this.DivergingCommitCounts.GetHashCode();
                return hashCode;
            }
        }
    }
}
