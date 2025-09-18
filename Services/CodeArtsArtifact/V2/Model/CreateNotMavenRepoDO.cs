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
    public class CreateNotMavenRepoDO 
    {

        /// <summary>
        /// 仓库格式
        /// </summary>
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public string Format { get; set; }

        /// <summary>
        /// 仓库类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 仓库名称
        /// </summary>
        [JsonProperty("repository_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// 仓库描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 路径白名单
        /// </summary>
        [JsonProperty("includes_pattern", NullValueHandling = NullValueHandling.Ignore)]
        public string IncludesPattern { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 共享策略
        /// </summary>
        [JsonProperty("share_right", NullValueHandling = NullValueHandling.Ignore)]
        public string ShareRight { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateNotMavenRepoDO {\n");
            sb.Append("  format: ").Append(Format).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  repositoryName: ").Append(RepositoryName).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  includesPattern: ").Append(IncludesPattern).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  shareRight: ").Append(ShareRight).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateNotMavenRepoDO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateNotMavenRepoDO input)
        {
            if (input == null) return false;
            if (this.Format != input.Format || (this.Format != null && !this.Format.Equals(input.Format))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.RepositoryName != input.RepositoryName || (this.RepositoryName != null && !this.RepositoryName.Equals(input.RepositoryName))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.IncludesPattern != input.IncludesPattern || (this.IncludesPattern != null && !this.IncludesPattern.Equals(input.IncludesPattern))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ShareRight != input.ShareRight || (this.ShareRight != null && !this.ShareRight.Equals(input.ShareRight))) return false;

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
                if (this.Format != null) hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.RepositoryName != null) hashCode = hashCode * 59 + this.RepositoryName.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IncludesPattern != null) hashCode = hashCode * 59 + this.IncludesPattern.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ShareRight != null) hashCode = hashCode * 59 + this.ShareRight.GetHashCode();
                return hashCode;
            }
        }
    }
}
