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
    /// Get the simplest project info, used to the list of projects
    /// </summary>
    public class ProjectSimpleDto 
    {

        /// <summary>
        /// 仓库id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 仓库描述信息
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 仓库名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 组织名/组织名.../仓库名
        /// </summary>
        [JsonProperty("name_with_namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string NameWithNamespace { get; set; }

        /// <summary>
        /// 仓库路径
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// 仓库完整路径
        /// </summary>
        [JsonProperty("path_with_namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string PathWithNamespace { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 是否归档
        /// </summary>
        [JsonProperty("archived", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Archived { get; set; }

        /// <summary>
        /// 是否机密
        /// </summary>
        [JsonProperty("is_kia", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsKia { get; set; }

        /// <summary>
        /// 仓库ssh地址
        /// </summary>
        [JsonProperty("ssh_url_to_repo", NullValueHandling = NullValueHandling.Ignore)]
        public string SshUrlToRepo { get; set; }

        /// <summary>
        /// 仓库http地址
        /// </summary>
        [JsonProperty("http_url_to_repo", NullValueHandling = NullValueHandling.Ignore)]
        public string HttpUrlToRepo { get; set; }

        /// <summary>
        /// 仓库页面链接
        /// </summary>
        [JsonProperty("web_url", NullValueHandling = NullValueHandling.Ignore)]
        public string WebUrl { get; set; }

        /// <summary>
        /// 仓库readme文件链接
        /// </summary>
        [JsonProperty("readme_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ReadmeUrl { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [JsonProperty("project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectName { get; set; }

        /// <summary>
        /// 仓库开发模式：normal、CR
        /// </summary>
        [JsonProperty("develop_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string DevelopMode { get; set; }

        /// <summary>
        /// 审核状态
        /// </summary>
        [JsonProperty("moderation_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ModerationResult { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectSimpleDto {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  nameWithNamespace: ").Append(NameWithNamespace).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  pathWithNamespace: ").Append(PathWithNamespace).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  archived: ").Append(Archived).Append("\n");
            sb.Append("  isKia: ").Append(IsKia).Append("\n");
            sb.Append("  sshUrlToRepo: ").Append(SshUrlToRepo).Append("\n");
            sb.Append("  httpUrlToRepo: ").Append(HttpUrlToRepo).Append("\n");
            sb.Append("  webUrl: ").Append(WebUrl).Append("\n");
            sb.Append("  readmeUrl: ").Append(ReadmeUrl).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  projectName: ").Append(ProjectName).Append("\n");
            sb.Append("  developMode: ").Append(DevelopMode).Append("\n");
            sb.Append("  moderationResult: ").Append(ModerationResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProjectSimpleDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProjectSimpleDto input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.NameWithNamespace != input.NameWithNamespace || (this.NameWithNamespace != null && !this.NameWithNamespace.Equals(input.NameWithNamespace))) return false;
            if (this.Path != input.Path || (this.Path != null && !this.Path.Equals(input.Path))) return false;
            if (this.PathWithNamespace != input.PathWithNamespace || (this.PathWithNamespace != null && !this.PathWithNamespace.Equals(input.PathWithNamespace))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.Archived != input.Archived || (this.Archived != null && !this.Archived.Equals(input.Archived))) return false;
            if (this.IsKia != input.IsKia || (this.IsKia != null && !this.IsKia.Equals(input.IsKia))) return false;
            if (this.SshUrlToRepo != input.SshUrlToRepo || (this.SshUrlToRepo != null && !this.SshUrlToRepo.Equals(input.SshUrlToRepo))) return false;
            if (this.HttpUrlToRepo != input.HttpUrlToRepo || (this.HttpUrlToRepo != null && !this.HttpUrlToRepo.Equals(input.HttpUrlToRepo))) return false;
            if (this.WebUrl != input.WebUrl || (this.WebUrl != null && !this.WebUrl.Equals(input.WebUrl))) return false;
            if (this.ReadmeUrl != input.ReadmeUrl || (this.ReadmeUrl != null && !this.ReadmeUrl.Equals(input.ReadmeUrl))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ProjectName != input.ProjectName || (this.ProjectName != null && !this.ProjectName.Equals(input.ProjectName))) return false;
            if (this.DevelopMode != input.DevelopMode || (this.DevelopMode != null && !this.DevelopMode.Equals(input.DevelopMode))) return false;
            if (this.ModerationResult != input.ModerationResult || (this.ModerationResult != null && !this.ModerationResult.Equals(input.ModerationResult))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NameWithNamespace != null) hashCode = hashCode * 59 + this.NameWithNamespace.GetHashCode();
                if (this.Path != null) hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.PathWithNamespace != null) hashCode = hashCode * 59 + this.PathWithNamespace.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Archived != null) hashCode = hashCode * 59 + this.Archived.GetHashCode();
                if (this.IsKia != null) hashCode = hashCode * 59 + this.IsKia.GetHashCode();
                if (this.SshUrlToRepo != null) hashCode = hashCode * 59 + this.SshUrlToRepo.GetHashCode();
                if (this.HttpUrlToRepo != null) hashCode = hashCode * 59 + this.HttpUrlToRepo.GetHashCode();
                if (this.WebUrl != null) hashCode = hashCode * 59 + this.WebUrl.GetHashCode();
                if (this.ReadmeUrl != null) hashCode = hashCode * 59 + this.ReadmeUrl.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProjectName != null) hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.DevelopMode != null) hashCode = hashCode * 59 + this.DevelopMode.GetHashCode();
                if (this.ModerationResult != null) hashCode = hashCode * 59 + this.ModerationResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
