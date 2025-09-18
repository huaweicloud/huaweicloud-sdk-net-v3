using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsArtifact.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateNotMavenRepoDO 
    {

        /// <summary>
        /// 仓库名称
        /// </summary>
        [JsonProperty("repo_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoName { get; set; }

        /// <summary>
        /// 仓库格式
        /// </summary>
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public string Format { get; set; }

        /// <summary>
        /// 仓库描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 仓库id列表
        /// </summary>
        [JsonProperty("repository_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RepositoryIds { get; set; }

        /// <summary>
        /// 路径白名单
        /// </summary>
        [JsonProperty("includes_pattern", NullValueHandling = NullValueHandling.Ignore)]
        public string IncludesPattern { get; set; }

        /// <summary>
        /// 仓库属性-覆盖策略
        /// </summary>
        [JsonProperty("deployment_policy", NullValueHandling = NullValueHandling.Ignore)]
        public string DeploymentPolicy { get; set; }

        /// <summary>
        /// 自动清理快照
        /// </summary>
        [JsonProperty("auto_clean_snapshot", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoCleanSnapshot { get; set; }

        /// <summary>
        /// 快照保存时间长度
        /// </summary>
        [JsonProperty("snapshot_alive_days", NullValueHandling = NullValueHandling.Ignore)]
        public string SnapshotAliveDays { get; set; }

        /// <summary>
        /// 最大不同快照个数
        /// </summary>
        [JsonProperty("max_unique_snapshots", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxUniqueSnapshots { get; set; }

        /// <summary>
        /// 是否允许匿名
        /// </summary>
        [JsonProperty("allow_anonymous", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowAnonymous { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateNotMavenRepoDO {\n");
            sb.Append("  repoName: ").Append(RepoName).Append("\n");
            sb.Append("  format: ").Append(Format).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  repositoryIds: ").Append(RepositoryIds).Append("\n");
            sb.Append("  includesPattern: ").Append(IncludesPattern).Append("\n");
            sb.Append("  deploymentPolicy: ").Append(DeploymentPolicy).Append("\n");
            sb.Append("  autoCleanSnapshot: ").Append(AutoCleanSnapshot).Append("\n");
            sb.Append("  snapshotAliveDays: ").Append(SnapshotAliveDays).Append("\n");
            sb.Append("  maxUniqueSnapshots: ").Append(MaxUniqueSnapshots).Append("\n");
            sb.Append("  allowAnonymous: ").Append(AllowAnonymous).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateNotMavenRepoDO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateNotMavenRepoDO input)
        {
            if (input == null) return false;
            if (this.RepoName != input.RepoName || (this.RepoName != null && !this.RepoName.Equals(input.RepoName))) return false;
            if (this.Format != input.Format || (this.Format != null && !this.Format.Equals(input.Format))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.RepositoryIds != input.RepositoryIds || (this.RepositoryIds != null && input.RepositoryIds != null && !this.RepositoryIds.SequenceEqual(input.RepositoryIds))) return false;
            if (this.IncludesPattern != input.IncludesPattern || (this.IncludesPattern != null && !this.IncludesPattern.Equals(input.IncludesPattern))) return false;
            if (this.DeploymentPolicy != input.DeploymentPolicy || (this.DeploymentPolicy != null && !this.DeploymentPolicy.Equals(input.DeploymentPolicy))) return false;
            if (this.AutoCleanSnapshot != input.AutoCleanSnapshot || (this.AutoCleanSnapshot != null && !this.AutoCleanSnapshot.Equals(input.AutoCleanSnapshot))) return false;
            if (this.SnapshotAliveDays != input.SnapshotAliveDays || (this.SnapshotAliveDays != null && !this.SnapshotAliveDays.Equals(input.SnapshotAliveDays))) return false;
            if (this.MaxUniqueSnapshots != input.MaxUniqueSnapshots || (this.MaxUniqueSnapshots != null && !this.MaxUniqueSnapshots.Equals(input.MaxUniqueSnapshots))) return false;
            if (this.AllowAnonymous != input.AllowAnonymous || (this.AllowAnonymous != null && !this.AllowAnonymous.Equals(input.AllowAnonymous))) return false;

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
                if (this.RepoName != null) hashCode = hashCode * 59 + this.RepoName.GetHashCode();
                if (this.Format != null) hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.RepositoryIds != null) hashCode = hashCode * 59 + this.RepositoryIds.GetHashCode();
                if (this.IncludesPattern != null) hashCode = hashCode * 59 + this.IncludesPattern.GetHashCode();
                if (this.DeploymentPolicy != null) hashCode = hashCode * 59 + this.DeploymentPolicy.GetHashCode();
                if (this.AutoCleanSnapshot != null) hashCode = hashCode * 59 + this.AutoCleanSnapshot.GetHashCode();
                if (this.SnapshotAliveDays != null) hashCode = hashCode * 59 + this.SnapshotAliveDays.GetHashCode();
                if (this.MaxUniqueSnapshots != null) hashCode = hashCode * 59 + this.MaxUniqueSnapshots.GetHashCode();
                if (this.AllowAnonymous != null) hashCode = hashCode * 59 + this.AllowAnonymous.GetHashCode();
                return hashCode;
            }
        }
    }
}
