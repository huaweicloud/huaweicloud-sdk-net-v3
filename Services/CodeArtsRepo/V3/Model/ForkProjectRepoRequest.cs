using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ForkProjectRepoRequest 
    {

        /// <summary>
        /// 是否导入项目成员，取值范围：0-&gt;不导入项目成员，1-&gt;导入项目成员
        /// </summary>
        [JsonProperty("import_members", NullValueHandling = NullValueHandling.Ignore)]
        public int? ImportMembers { get; set; }

        /// <summary>
        /// 项目名称，取值范围：可以输入英文大小写字母、数字、连字符、下划线，且必须以字母开头
        /// </summary>
        [JsonProperty("project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectName { get; set; }

        /// <summary>
        /// 仓库名称，取值范围：可以输入英文大小写字母、数字、连字符、下划线，且必须以字母开头
        /// </summary>
        [JsonProperty("repo_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoName { get; set; }

        /// <summary>
        /// 复制模板的ID
        /// </summary>
        [JsonProperty("template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 项目类型，scrum
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 仓库可见性：  *私有仓库：仓库仅对仓库成员可见，仓库成员可读写和访问仓库，取值范围为0  *公开仓库：   1.项目内成员只读仓库：仓库对项目内成员公开只读，并项目内成员可在项目下和代码组下的仓库列表中查看和搜索，取值范围为10   2.租户内成员只读仓库：仓库对租户内成员公开只读，并租户内成员可在项目下和代码组下的仓库列表中查看和搜索，取值范围为10   3.所有访客只读仓库：仓库对所有访客公开只读，并所有访客可在项目下和代码组下的仓库列表中查看和搜索，取值范围为20
        /// </summary>
        [JsonProperty("visibility_level", NullValueHandling = NullValueHandling.Ignore)]
        public int? VisibilityLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("external_project_info", NullValueHandling = NullValueHandling.Ignore)]
        public ExternalKeyMessage ExternalProjectInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForkProjectRepoRequest {\n");
            sb.Append("  importMembers: ").Append(ImportMembers).Append("\n");
            sb.Append("  projectName: ").Append(ProjectName).Append("\n");
            sb.Append("  repoName: ").Append(RepoName).Append("\n");
            sb.Append("  templateId: ").Append(TemplateId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  visibilityLevel: ").Append(VisibilityLevel).Append("\n");
            sb.Append("  externalProjectInfo: ").Append(ExternalProjectInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ForkProjectRepoRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ForkProjectRepoRequest input)
        {
            if (input == null) return false;
            if (this.ImportMembers != input.ImportMembers || (this.ImportMembers != null && !this.ImportMembers.Equals(input.ImportMembers))) return false;
            if (this.ProjectName != input.ProjectName || (this.ProjectName != null && !this.ProjectName.Equals(input.ProjectName))) return false;
            if (this.RepoName != input.RepoName || (this.RepoName != null && !this.RepoName.Equals(input.RepoName))) return false;
            if (this.TemplateId != input.TemplateId || (this.TemplateId != null && !this.TemplateId.Equals(input.TemplateId))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.VisibilityLevel != input.VisibilityLevel || (this.VisibilityLevel != null && !this.VisibilityLevel.Equals(input.VisibilityLevel))) return false;
            if (this.ExternalProjectInfo != input.ExternalProjectInfo || (this.ExternalProjectInfo != null && !this.ExternalProjectInfo.Equals(input.ExternalProjectInfo))) return false;

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
                if (this.ImportMembers != null) hashCode = hashCode * 59 + this.ImportMembers.GetHashCode();
                if (this.ProjectName != null) hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.RepoName != null) hashCode = hashCode * 59 + this.RepoName.GetHashCode();
                if (this.TemplateId != null) hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.VisibilityLevel != null) hashCode = hashCode * 59 + this.VisibilityLevel.GetHashCode();
                if (this.ExternalProjectInfo != null) hashCode = hashCode * 59 + this.ExternalProjectInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
