using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ArtifactTag 
    {

        /// <summary>
        /// Tag ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        /// <summary>
        /// 制品仓库ID
        /// </summary>
        [JsonProperty("repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? RepositoryId { get; set; }

        /// <summary>
        /// 制品版本ID
        /// </summary>
        [JsonProperty("artifact_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? ArtifactId { get; set; }

        /// <summary>
        /// tag名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// tag的上传时间
        /// </summary>
        [JsonProperty("push_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? PushTime { get; set; }

        /// <summary>
        /// tag的下载时间
        /// </summary>
        [JsonProperty("pull_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? PullTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArtifactTag {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  artifactId: ").Append(ArtifactId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  pushTime: ").Append(PushTime).Append("\n");
            sb.Append("  pullTime: ").Append(PullTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ArtifactTag);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ArtifactTag input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.ArtifactId != input.ArtifactId || (this.ArtifactId != null && !this.ArtifactId.Equals(input.ArtifactId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.PushTime != input.PushTime || (this.PushTime != null && !this.PushTime.Equals(input.PushTime))) return false;
            if (this.PullTime != input.PullTime || (this.PullTime != null && !this.PullTime.Equals(input.PullTime))) return false;

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
                if (this.RepositoryId != null) hashCode = hashCode * 59 + this.RepositoryId.GetHashCode();
                if (this.ArtifactId != null) hashCode = hashCode * 59 + this.ArtifactId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PushTime != null) hashCode = hashCode * 59 + this.PushTime.GetHashCode();
                if (this.PullTime != null) hashCode = hashCode * 59 + this.PullTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
