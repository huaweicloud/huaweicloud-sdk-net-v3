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
    public class Namespace 
    {

        /// <summary>
        /// 命名空间名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public NamespaceMetadata Metadata { get; set; }

        /// <summary>
        /// 命名空间ID
        /// </summary>
        [JsonProperty("namespace_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? NamespaceId { get; set; }

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
        /// 镜像数量
        /// </summary>
        [JsonProperty("repo_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepoCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cve_allowlist", NullValueHandling = NullValueHandling.Ignore)]
        public CVEAllowlist CveAllowlist { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Namespace {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  namespaceId: ").Append(NamespaceId).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  repoCount: ").Append(RepoCount).Append("\n");
            sb.Append("  cveAllowlist: ").Append(CveAllowlist).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Namespace);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Namespace input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Metadata != input.Metadata || (this.Metadata != null && !this.Metadata.Equals(input.Metadata))) return false;
            if (this.NamespaceId != input.NamespaceId || (this.NamespaceId != null && !this.NamespaceId.Equals(input.NamespaceId))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.RepoCount != input.RepoCount || (this.RepoCount != null && !this.RepoCount.Equals(input.RepoCount))) return false;
            if (this.CveAllowlist != input.CveAllowlist || (this.CveAllowlist != null && !this.CveAllowlist.Equals(input.CveAllowlist))) return false;

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
                if (this.Metadata != null) hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.NamespaceId != null) hashCode = hashCode * 59 + this.NamespaceId.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.RepoCount != null) hashCode = hashCode * 59 + this.RepoCount.GetHashCode();
                if (this.CveAllowlist != null) hashCode = hashCode * 59 + this.CveAllowlist.GetHashCode();
                return hashCode;
            }
        }
    }
}
