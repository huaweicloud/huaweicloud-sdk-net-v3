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
    /// 
    /// </summary>
    public class CreateRepoRequest 
    {

        /// <summary>
        /// 是否导入项目成员，取值范围：0-&gt;不导入项目成员，1-&gt;导入项目成员
        /// </summary>
        [JsonProperty("import_members", NullValueHandling = NullValueHandling.Ignore)]
        public int? ImportMembers { get; set; }

        /// <summary>
        /// 仓库名称，取值范围：可以输入英文大小写字母、数字、连字符、下划线，且必须以字母开头
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 指定项目ID，获取方式请参见[获取项目ID](codehub_api_0014.xml)。
        /// </summary>
        [JsonProperty("project_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectUuid { get; set; }

        /// <summary>
        /// 复制模板的ID
        /// </summary>
        [JsonProperty("template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 仓库状态，取值范围：0-&gt;私有，20-&gt;公开只读
        /// </summary>
        [JsonProperty("visibility_level", NullValueHandling = NullValueHandling.Ignore)]
        public int? VisibilityLevel { get; set; }

        /// <summary>
        /// 模板仓库的https地址的base64加密
        /// </summary>
        [JsonProperty("import_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ImportUrl { get; set; }

        /// <summary>
        /// 仓库描述信息
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 根据编程语言生成.gitignore文件
        /// </summary>
        [JsonProperty("gitignore_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GitignoreId { get; set; }

        /// <summary>
        /// 许可证id
        /// </summary>
        [JsonProperty("license_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? LicenseId { get; set; }

        /// <summary>
        /// 是否允许生成README文件
        /// </summary>
        [JsonProperty("enable_readme", NullValueHandling = NullValueHandling.Ignore)]
        public int? EnableReadme { get; set; }

        /// <summary>
        /// 调用者
        /// </summary>
        [JsonProperty("caller", NullValueHandling = NullValueHandling.Ignore)]
        public string Caller { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRepoRequest {\n");
            sb.Append("  importMembers: ").Append(ImportMembers).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  projectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("  templateId: ").Append(TemplateId).Append("\n");
            sb.Append("  visibilityLevel: ").Append(VisibilityLevel).Append("\n");
            sb.Append("  importUrl: ").Append(ImportUrl).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  gitignoreId: ").Append(GitignoreId).Append("\n");
            sb.Append("  licenseId: ").Append(LicenseId).Append("\n");
            sb.Append("  enableReadme: ").Append(EnableReadme).Append("\n");
            sb.Append("  caller: ").Append(Caller).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateRepoRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateRepoRequest input)
        {
            if (input == null) return false;
            if (this.ImportMembers != input.ImportMembers || (this.ImportMembers != null && !this.ImportMembers.Equals(input.ImportMembers))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ProjectUuid != input.ProjectUuid || (this.ProjectUuid != null && !this.ProjectUuid.Equals(input.ProjectUuid))) return false;
            if (this.TemplateId != input.TemplateId || (this.TemplateId != null && !this.TemplateId.Equals(input.TemplateId))) return false;
            if (this.VisibilityLevel != input.VisibilityLevel || (this.VisibilityLevel != null && !this.VisibilityLevel.Equals(input.VisibilityLevel))) return false;
            if (this.ImportUrl != input.ImportUrl || (this.ImportUrl != null && !this.ImportUrl.Equals(input.ImportUrl))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.GitignoreId != input.GitignoreId || (this.GitignoreId != null && !this.GitignoreId.Equals(input.GitignoreId))) return false;
            if (this.LicenseId != input.LicenseId || (this.LicenseId != null && !this.LicenseId.Equals(input.LicenseId))) return false;
            if (this.EnableReadme != input.EnableReadme || (this.EnableReadme != null && !this.EnableReadme.Equals(input.EnableReadme))) return false;
            if (this.Caller != input.Caller || (this.Caller != null && !this.Caller.Equals(input.Caller))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProjectUuid != null) hashCode = hashCode * 59 + this.ProjectUuid.GetHashCode();
                if (this.TemplateId != null) hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.VisibilityLevel != null) hashCode = hashCode * 59 + this.VisibilityLevel.GetHashCode();
                if (this.ImportUrl != null) hashCode = hashCode * 59 + this.ImportUrl.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.GitignoreId != null) hashCode = hashCode * 59 + this.GitignoreId.GetHashCode();
                if (this.LicenseId != null) hashCode = hashCode * 59 + this.LicenseId.GetHashCode();
                if (this.EnableReadme != null) hashCode = hashCode * 59 + this.EnableReadme.GetHashCode();
                if (this.Caller != null) hashCode = hashCode * 59 + this.Caller.GetHashCode();
                return hashCode;
            }
        }
    }
}
