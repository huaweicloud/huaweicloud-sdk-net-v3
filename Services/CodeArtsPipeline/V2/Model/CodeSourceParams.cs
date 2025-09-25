using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// **参数解释**： 流水线源参数，包含流水线源的详细信息。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
    /// </summary>
    public class CodeSourceParams 
    {

        /// <summary>
        /// **参数解释**： 代码仓类型。 **约束限制**： 不涉及。 **取值范围**： - codehub。 - gitee。 - github。 - gitcode。 - gitlab。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("git_type", NullValueHandling = NullValueHandling.Ignore)]
        public string GitType { get; set; }

        /// <summary>
        /// **参数解释**： CodeArts Repo代码仓ID。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("codehub_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CodehubId { get; set; }

        /// <summary>
        /// **参数解释**： 代码源扩展点ID。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("endpoint_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointId { get; set; }

        /// <summary>
        /// **参数解释**： 默认分支。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("default_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultBranch { get; set; }

        /// <summary>
        /// **参数解释**： Git仓库https地址，例如https://example.com/CloudPipelinezycs00001/2000.git。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("git_url", NullValueHandling = NullValueHandling.Ignore)]
        public string GitUrl { get; set; }

        /// <summary>
        /// **参数解释**： ssh_git链接地址，例如https://example.com/CloudPipelinezycs00001/2000.git。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("ssh_git_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SshGitUrl { get; set; }

        /// <summary>
        /// **参数解释**： 网页url。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("web_url", NullValueHandling = NullValueHandling.Ignore)]
        public string WebUrl { get; set; }

        /// <summary>
        /// **参数解释**： 流水线源名称。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("repo_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoName { get; set; }

        /// <summary>
        /// **参数解释**： 代码仓别名。 **约束限制**： 不涉及。 **取值范围**： 仅支持输入大小写英文字母、数字、“_”，至多128个字符。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("alias", NullValueHandling = NullValueHandling.Ignore)]
        public string Alias { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CodeSourceParams {\n");
            sb.Append("  gitType: ").Append(GitType).Append("\n");
            sb.Append("  codehubId: ").Append(CodehubId).Append("\n");
            sb.Append("  endpointId: ").Append(EndpointId).Append("\n");
            sb.Append("  defaultBranch: ").Append(DefaultBranch).Append("\n");
            sb.Append("  gitUrl: ").Append(GitUrl).Append("\n");
            sb.Append("  sshGitUrl: ").Append(SshGitUrl).Append("\n");
            sb.Append("  webUrl: ").Append(WebUrl).Append("\n");
            sb.Append("  repoName: ").Append(RepoName).Append("\n");
            sb.Append("  alias: ").Append(Alias).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CodeSourceParams);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CodeSourceParams input)
        {
            if (input == null) return false;
            if (this.GitType != input.GitType || (this.GitType != null && !this.GitType.Equals(input.GitType))) return false;
            if (this.CodehubId != input.CodehubId || (this.CodehubId != null && !this.CodehubId.Equals(input.CodehubId))) return false;
            if (this.EndpointId != input.EndpointId || (this.EndpointId != null && !this.EndpointId.Equals(input.EndpointId))) return false;
            if (this.DefaultBranch != input.DefaultBranch || (this.DefaultBranch != null && !this.DefaultBranch.Equals(input.DefaultBranch))) return false;
            if (this.GitUrl != input.GitUrl || (this.GitUrl != null && !this.GitUrl.Equals(input.GitUrl))) return false;
            if (this.SshGitUrl != input.SshGitUrl || (this.SshGitUrl != null && !this.SshGitUrl.Equals(input.SshGitUrl))) return false;
            if (this.WebUrl != input.WebUrl || (this.WebUrl != null && !this.WebUrl.Equals(input.WebUrl))) return false;
            if (this.RepoName != input.RepoName || (this.RepoName != null && !this.RepoName.Equals(input.RepoName))) return false;
            if (this.Alias != input.Alias || (this.Alias != null && !this.Alias.Equals(input.Alias))) return false;

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
                if (this.GitType != null) hashCode = hashCode * 59 + this.GitType.GetHashCode();
                if (this.CodehubId != null) hashCode = hashCode * 59 + this.CodehubId.GetHashCode();
                if (this.EndpointId != null) hashCode = hashCode * 59 + this.EndpointId.GetHashCode();
                if (this.DefaultBranch != null) hashCode = hashCode * 59 + this.DefaultBranch.GetHashCode();
                if (this.GitUrl != null) hashCode = hashCode * 59 + this.GitUrl.GetHashCode();
                if (this.SshGitUrl != null) hashCode = hashCode * 59 + this.SshGitUrl.GetHashCode();
                if (this.WebUrl != null) hashCode = hashCode * 59 + this.WebUrl.GetHashCode();
                if (this.RepoName != null) hashCode = hashCode * 59 + this.RepoName.GetHashCode();
                if (this.Alias != null) hashCode = hashCode * 59 + this.Alias.GetHashCode();
                return hashCode;
            }
        }
    }
}
