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
    /// 构建执行SCM
    /// </summary>
    public class CreateBuildJobScm 
    {

        /// <summary>
        /// 代码分支
        /// </summary>
        [JsonProperty("branch", NullValueHandling = NullValueHandling.Ignore)]
        public string Branch { get; set; }

        /// <summary>
        /// 代码仓地址
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// repo的id
        /// </summary>
        [JsonProperty("repo_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoId { get; set; }

        /// <summary>
        /// 代码仓http地址
        /// </summary>
        [JsonProperty("web_url", NullValueHandling = NullValueHandling.Ignore)]
        public string WebUrl { get; set; }

        /// <summary>
        /// 仓库类别，Repo、Github等
        /// </summary>
        [JsonProperty("scm_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ScmType { get; set; }

        /// <summary>
        /// 是否自动构建
        /// </summary>
        [JsonProperty("is_auto_build", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAutoBuild { get; set; }

        /// <summary>
        /// 是否启用gitlfs
        /// </summary>
        [JsonProperty("enable_git_lfs", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableGitLfs { get; set; }

        /// <summary>
        /// 构建类别
        /// </summary>
        [JsonProperty("build_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildType { get; set; }

        /// <summary>
        /// 克隆深度
        /// </summary>
        [JsonProperty("depth", NullValueHandling = NullValueHandling.Ignore)]
        public string Depth { get; set; }

        /// <summary>
        /// endpointId
        /// </summary>
        [JsonProperty("end_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EndPointId { get; set; }

        /// <summary>
        /// source
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        /// 仓库分组
        /// </summary>
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// 仓库名称
        /// </summary>
        [JsonProperty("repo_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateBuildJobScm {\n");
            sb.Append("  branch: ").Append(Branch).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  repoId: ").Append(RepoId).Append("\n");
            sb.Append("  webUrl: ").Append(WebUrl).Append("\n");
            sb.Append("  scmType: ").Append(ScmType).Append("\n");
            sb.Append("  isAutoBuild: ").Append(IsAutoBuild).Append("\n");
            sb.Append("  enableGitLfs: ").Append(EnableGitLfs).Append("\n");
            sb.Append("  buildType: ").Append(BuildType).Append("\n");
            sb.Append("  depth: ").Append(Depth).Append("\n");
            sb.Append("  endPointId: ").Append(EndPointId).Append("\n");
            sb.Append("  source: ").Append(Source).Append("\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  repoName: ").Append(RepoName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateBuildJobScm);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateBuildJobScm input)
        {
            if (input == null) return false;
            if (this.Branch != input.Branch || (this.Branch != null && !this.Branch.Equals(input.Branch))) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.RepoId != input.RepoId || (this.RepoId != null && !this.RepoId.Equals(input.RepoId))) return false;
            if (this.WebUrl != input.WebUrl || (this.WebUrl != null && !this.WebUrl.Equals(input.WebUrl))) return false;
            if (this.ScmType != input.ScmType || (this.ScmType != null && !this.ScmType.Equals(input.ScmType))) return false;
            if (this.IsAutoBuild != input.IsAutoBuild || (this.IsAutoBuild != null && !this.IsAutoBuild.Equals(input.IsAutoBuild))) return false;
            if (this.EnableGitLfs != input.EnableGitLfs || (this.EnableGitLfs != null && !this.EnableGitLfs.Equals(input.EnableGitLfs))) return false;
            if (this.BuildType != input.BuildType || (this.BuildType != null && !this.BuildType.Equals(input.BuildType))) return false;
            if (this.Depth != input.Depth || (this.Depth != null && !this.Depth.Equals(input.Depth))) return false;
            if (this.EndPointId != input.EndPointId || (this.EndPointId != null && !this.EndPointId.Equals(input.EndPointId))) return false;
            if (this.Source != input.Source || (this.Source != null && !this.Source.Equals(input.Source))) return false;
            if (this.GroupName != input.GroupName || (this.GroupName != null && !this.GroupName.Equals(input.GroupName))) return false;
            if (this.RepoName != input.RepoName || (this.RepoName != null && !this.RepoName.Equals(input.RepoName))) return false;

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
                if (this.Branch != null) hashCode = hashCode * 59 + this.Branch.GetHashCode();
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.RepoId != null) hashCode = hashCode * 59 + this.RepoId.GetHashCode();
                if (this.WebUrl != null) hashCode = hashCode * 59 + this.WebUrl.GetHashCode();
                if (this.ScmType != null) hashCode = hashCode * 59 + this.ScmType.GetHashCode();
                if (this.IsAutoBuild != null) hashCode = hashCode * 59 + this.IsAutoBuild.GetHashCode();
                if (this.EnableGitLfs != null) hashCode = hashCode * 59 + this.EnableGitLfs.GetHashCode();
                if (this.BuildType != null) hashCode = hashCode * 59 + this.BuildType.GetHashCode();
                if (this.Depth != null) hashCode = hashCode * 59 + this.Depth.GetHashCode();
                if (this.EndPointId != null) hashCode = hashCode * 59 + this.EndPointId.GetHashCode();
                if (this.Source != null) hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.GroupName != null) hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.RepoName != null) hashCode = hashCode * 59 + this.RepoName.GetHashCode();
                return hashCode;
            }
        }
    }
}
