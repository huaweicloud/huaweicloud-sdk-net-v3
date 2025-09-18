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
    public class IDERepositoryPair 
    {

        /// <summary>
        /// 仓库名称
        /// </summary>
        [JsonProperty("repo_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoName { get; set; }

        /// <summary>
        /// 路径
        /// </summary>
        [JsonProperty("includes_pattern", NullValueHandling = NullValueHandling.Ignore)]
        public string IncludesPattern { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// snapshot仓库名称
        /// </summary>
        [JsonProperty("snapshot", NullValueHandling = NullValueHandling.Ignore)]
        public string Snapshot { get; set; }

        /// <summary>
        /// release仓库名称
        /// </summary>
        [JsonProperty("release", NullValueHandling = NullValueHandling.Ignore)]
        public string Release { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IDERepositoryPair {\n");
            sb.Append("  repoName: ").Append(RepoName).Append("\n");
            sb.Append("  includesPattern: ").Append(IncludesPattern).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  snapshot: ").Append(Snapshot).Append("\n");
            sb.Append("  release: ").Append(Release).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IDERepositoryPair);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IDERepositoryPair input)
        {
            if (input == null) return false;
            if (this.RepoName != input.RepoName || (this.RepoName != null && !this.RepoName.Equals(input.RepoName))) return false;
            if (this.IncludesPattern != input.IncludesPattern || (this.IncludesPattern != null && !this.IncludesPattern.Equals(input.IncludesPattern))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Snapshot != input.Snapshot || (this.Snapshot != null && !this.Snapshot.Equals(input.Snapshot))) return false;
            if (this.Release != input.Release || (this.Release != null && !this.Release.Equals(input.Release))) return false;

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
                if (this.IncludesPattern != null) hashCode = hashCode * 59 + this.IncludesPattern.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Snapshot != null) hashCode = hashCode * 59 + this.Snapshot.GetHashCode();
                if (this.Release != null) hashCode = hashCode * 59 + this.Release.GetHashCode();
                return hashCode;
            }
        }
    }
}
