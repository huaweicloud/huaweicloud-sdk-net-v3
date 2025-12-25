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
    public class RepositoryTag 
    {

        /// <summary>
        /// 版本名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 关联的制品ID
        /// </summary>
        [JsonProperty("artifact_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ArtifactId { get; set; }

        /// <summary>
        /// 关联的制品摘要
        /// </summary>
        [JsonProperty("digest", NullValueHandling = NullValueHandling.Ignore)]
        public string Digest { get; set; }

        /// <summary>
        /// 版本ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 制品仓库仓库ID
        /// </summary>
        [JsonProperty("repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepositoryId { get; set; }

        /// <summary>
        /// 制品类型，比如IMAGE
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 命名空间ID
        /// </summary>
        [JsonProperty("namespace_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? NamespaceId { get; set; }

        /// <summary>
        /// 制品MIME类型
        /// </summary>
        [JsonProperty("media_type", NullValueHandling = NullValueHandling.Ignore)]
        public string MediaType { get; set; }

        /// <summary>
        /// 制品元数据MIME类型
        /// </summary>
        [JsonProperty("manifest_media_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ManifestMediaType { get; set; }

        /// <summary>
        /// 最近一次拉取时间
        /// </summary>
        [JsonProperty("pull_time", NullValueHandling = NullValueHandling.Ignore)]
        public string PullTime { get; set; }

        /// <summary>
        /// 最近一次上传时间
        /// </summary>
        [JsonProperty("push_time", NullValueHandling = NullValueHandling.Ignore)]
        public string PushTime { get; set; }

        /// <summary>
        /// 制品大小，单位：Byte
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public long? Size { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepositoryTag {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  artifactId: ").Append(ArtifactId).Append("\n");
            sb.Append("  digest: ").Append(Digest).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  namespaceId: ").Append(NamespaceId).Append("\n");
            sb.Append("  mediaType: ").Append(MediaType).Append("\n");
            sb.Append("  manifestMediaType: ").Append(ManifestMediaType).Append("\n");
            sb.Append("  pullTime: ").Append(PullTime).Append("\n");
            sb.Append("  pushTime: ").Append(PushTime).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RepositoryTag);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RepositoryTag input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ArtifactId != input.ArtifactId || (this.ArtifactId != null && !this.ArtifactId.Equals(input.ArtifactId))) return false;
            if (this.Digest != input.Digest || (this.Digest != null && !this.Digest.Equals(input.Digest))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.NamespaceId != input.NamespaceId || (this.NamespaceId != null && !this.NamespaceId.Equals(input.NamespaceId))) return false;
            if (this.MediaType != input.MediaType || (this.MediaType != null && !this.MediaType.Equals(input.MediaType))) return false;
            if (this.ManifestMediaType != input.ManifestMediaType || (this.ManifestMediaType != null && !this.ManifestMediaType.Equals(input.ManifestMediaType))) return false;
            if (this.PullTime != input.PullTime || (this.PullTime != null && !this.PullTime.Equals(input.PullTime))) return false;
            if (this.PushTime != input.PushTime || (this.PushTime != null && !this.PushTime.Equals(input.PushTime))) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;

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
                if (this.ArtifactId != null) hashCode = hashCode * 59 + this.ArtifactId.GetHashCode();
                if (this.Digest != null) hashCode = hashCode * 59 + this.Digest.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.RepositoryId != null) hashCode = hashCode * 59 + this.RepositoryId.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.NamespaceId != null) hashCode = hashCode * 59 + this.NamespaceId.GetHashCode();
                if (this.MediaType != null) hashCode = hashCode * 59 + this.MediaType.GetHashCode();
                if (this.ManifestMediaType != null) hashCode = hashCode * 59 + this.ManifestMediaType.GetHashCode();
                if (this.PullTime != null) hashCode = hashCode * 59 + this.PullTime.GetHashCode();
                if (this.PushTime != null) hashCode = hashCode * 59 + this.PushTime.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                return hashCode;
            }
        }
    }
}
