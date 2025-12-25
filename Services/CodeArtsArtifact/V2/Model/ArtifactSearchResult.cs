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
    public class ArtifactSearchResult 
    {

        /// <summary>
        /// **参数解释**： 文件名。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 文件相对路径。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("relativePath", NullValueHandling = NullValueHandling.Ignore)]
        public string RelativePath { get; set; }

        /// <summary>
        /// **参数解释**： 仓库ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("repo", NullValueHandling = NullValueHandling.Ignore)]
        public string Repo { get; set; }

        /// <summary>
        /// **参数解释**： 仓库名。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("repoName", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoName { get; set; }

        /// <summary>
        /// **参数解释**： 展示名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("displayName", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// **参数解释**： 制品类型。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("repoType", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoType { get; set; }

        /// <summary>
        /// **参数解释**： 创建人ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("createdBy", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// **参数解释**： 创建人名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("createdUserName", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedUserName { get; set; }

        /// <summary>
        /// **参数解释**： 创建时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }

        /// <summary>
        /// **参数解释**： 修改时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("modified", NullValueHandling = NullValueHandling.Ignore)]
        public string Modified { get; set; }

        /// <summary>
        /// **参数解释**： 旧仓库ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("oldRepoId", NullValueHandling = NullValueHandling.Ignore)]
        public string OldRepoId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArtifactSearchResult {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  relativePath: ").Append(RelativePath).Append("\n");
            sb.Append("  repo: ").Append(Repo).Append("\n");
            sb.Append("  repoName: ").Append(RepoName).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  repoType: ").Append(RepoType).Append("\n");
            sb.Append("  createdBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  createdUserName: ").Append(CreatedUserName).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  modified: ").Append(Modified).Append("\n");
            sb.Append("  oldRepoId: ").Append(OldRepoId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ArtifactSearchResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ArtifactSearchResult input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.RelativePath != input.RelativePath || (this.RelativePath != null && !this.RelativePath.Equals(input.RelativePath))) return false;
            if (this.Repo != input.Repo || (this.Repo != null && !this.Repo.Equals(input.Repo))) return false;
            if (this.RepoName != input.RepoName || (this.RepoName != null && !this.RepoName.Equals(input.RepoName))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.RepoType != input.RepoType || (this.RepoType != null && !this.RepoType.Equals(input.RepoType))) return false;
            if (this.CreatedBy != input.CreatedBy || (this.CreatedBy != null && !this.CreatedBy.Equals(input.CreatedBy))) return false;
            if (this.CreatedUserName != input.CreatedUserName || (this.CreatedUserName != null && !this.CreatedUserName.Equals(input.CreatedUserName))) return false;
            if (this.Created != input.Created || (this.Created != null && !this.Created.Equals(input.Created))) return false;
            if (this.Modified != input.Modified || (this.Modified != null && !this.Modified.Equals(input.Modified))) return false;
            if (this.OldRepoId != input.OldRepoId || (this.OldRepoId != null && !this.OldRepoId.Equals(input.OldRepoId))) return false;

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
                if (this.RelativePath != null) hashCode = hashCode * 59 + this.RelativePath.GetHashCode();
                if (this.Repo != null) hashCode = hashCode * 59 + this.Repo.GetHashCode();
                if (this.RepoName != null) hashCode = hashCode * 59 + this.RepoName.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.RepoType != null) hashCode = hashCode * 59 + this.RepoType.GetHashCode();
                if (this.CreatedBy != null) hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedUserName != null) hashCode = hashCode * 59 + this.CreatedUserName.GetHashCode();
                if (this.Created != null) hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Modified != null) hashCode = hashCode * 59 + this.Modified.GetHashCode();
                if (this.OldRepoId != null) hashCode = hashCode * 59 + this.OldRepoId.GetHashCode();
                return hashCode;
            }
        }
    }
}
