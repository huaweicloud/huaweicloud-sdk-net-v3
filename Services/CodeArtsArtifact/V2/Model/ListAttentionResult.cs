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
    public class ListAttentionResult 
    {

        /// <summary>
        /// **参数解释**： 序号。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**： 租户ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("domainId", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// **参数解释**： 仓库ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("repositoryId", NullValueHandling = NullValueHandling.Ignore)]
        public string RepositoryId { get; set; }

        /// <summary>
        /// **参数解释**： 仓库名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("repositoryName", NullValueHandling = NullValueHandling.Ignore)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// **参数解释**： 制品类型。 **取值范围**： maven2|docker|npm|go|pypi|rpm|composer|debian|conan|nuget|docker2|cocoapods|ohpm|generic。 
        /// </summary>
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public string Format { get; set; }

        /// <summary>
        /// **参数解释**： 仓库策略。 **取值范围**： - release：正式仓库。 - snapshot：快照仓库。 
        /// </summary>
        [JsonProperty("policy", NullValueHandling = NullValueHandling.Ignore)]
        public string Policy { get; set; }

        /// <summary>
        /// **参数解释**： 关注的组件序号。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("artifactId", NullValueHandling = NullValueHandling.Ignore)]
        public string ArtifactId { get; set; }

        /// <summary>
        /// **参数解释**： 关注的组件路径。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// **参数解释**： 修改人名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("modifiedUserName", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedUserName { get; set; }

        /// <summary>
        /// **参数解释**： 修改人ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("modifiedUserId", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedUserId { get; set; }

        /// <summary>
        /// **参数解释**： 用户id。 **取值范围**： 只能由英文字母、数字组成，且长度为32个字符。 
        /// </summary>
        [JsonProperty("userId", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// **参数解释**： 修改时间，时间格式：yyyy-MM-dd HH:mm:ss。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("modifiedTime", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// **参数解释**： 区域。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAttentionResult {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  repositoryName: ").Append(RepositoryName).Append("\n");
            sb.Append("  format: ").Append(Format).Append("\n");
            sb.Append("  policy: ").Append(Policy).Append("\n");
            sb.Append("  artifactId: ").Append(ArtifactId).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  modifiedUserName: ").Append(ModifiedUserName).Append("\n");
            sb.Append("  modifiedUserId: ").Append(ModifiedUserId).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  modifiedTime: ").Append(ModifiedTime).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAttentionResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAttentionResult input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.RepositoryName != input.RepositoryName || (this.RepositoryName != null && !this.RepositoryName.Equals(input.RepositoryName))) return false;
            if (this.Format != input.Format || (this.Format != null && !this.Format.Equals(input.Format))) return false;
            if (this.Policy != input.Policy || (this.Policy != null && !this.Policy.Equals(input.Policy))) return false;
            if (this.ArtifactId != input.ArtifactId || (this.ArtifactId != null && !this.ArtifactId.Equals(input.ArtifactId))) return false;
            if (this.Path != input.Path || (this.Path != null && !this.Path.Equals(input.Path))) return false;
            if (this.ModifiedUserName != input.ModifiedUserName || (this.ModifiedUserName != null && !this.ModifiedUserName.Equals(input.ModifiedUserName))) return false;
            if (this.ModifiedUserId != input.ModifiedUserId || (this.ModifiedUserId != null && !this.ModifiedUserId.Equals(input.ModifiedUserId))) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.ModifiedTime != input.ModifiedTime || (this.ModifiedTime != null && !this.ModifiedTime.Equals(input.ModifiedTime))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;

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
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.RepositoryId != null) hashCode = hashCode * 59 + this.RepositoryId.GetHashCode();
                if (this.RepositoryName != null) hashCode = hashCode * 59 + this.RepositoryName.GetHashCode();
                if (this.Format != null) hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.Policy != null) hashCode = hashCode * 59 + this.Policy.GetHashCode();
                if (this.ArtifactId != null) hashCode = hashCode * 59 + this.ArtifactId.GetHashCode();
                if (this.Path != null) hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.ModifiedUserName != null) hashCode = hashCode * 59 + this.ModifiedUserName.GetHashCode();
                if (this.ModifiedUserId != null) hashCode = hashCode * 59 + this.ModifiedUserId.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.ModifiedTime != null) hashCode = hashCode * 59 + this.ModifiedTime.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                return hashCode;
            }
        }
    }
}
