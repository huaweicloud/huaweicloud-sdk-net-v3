using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RepositoryStatisticsDto 
    {

        /// <summary>
        /// **参数解释：** 提交数量。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("commit_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? CommitCount { get; set; }

        /// <summary>
        /// **参数解释：** 存储大小。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("storage_size", NullValueHandling = NullValueHandling.Ignore)]
        public double? StorageSize { get; set; }

        /// <summary>
        /// **参数解释：** 仓库大小。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("repository_size", NullValueHandling = NullValueHandling.Ignore)]
        public double? RepositorySize { get; set; }

        /// <summary>
        /// **参数解释：** LFS对象大小。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("lfs_objects_size", NullValueHandling = NullValueHandling.Ignore)]
        public double? LfsObjectsSize { get; set; }

        /// <summary>
        /// **参数解释：** 租户仓库大小限制。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("tenant_repo_size_limit", NullValueHandling = NullValueHandling.Ignore)]
        public long? TenantRepoSizeLimit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepositoryStatisticsDto {\n");
            sb.Append("  commitCount: ").Append(CommitCount).Append("\n");
            sb.Append("  storageSize: ").Append(StorageSize).Append("\n");
            sb.Append("  repositorySize: ").Append(RepositorySize).Append("\n");
            sb.Append("  lfsObjectsSize: ").Append(LfsObjectsSize).Append("\n");
            sb.Append("  tenantRepoSizeLimit: ").Append(TenantRepoSizeLimit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RepositoryStatisticsDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RepositoryStatisticsDto input)
        {
            if (input == null) return false;
            if (this.CommitCount != input.CommitCount || (this.CommitCount != null && !this.CommitCount.Equals(input.CommitCount))) return false;
            if (this.StorageSize != input.StorageSize || (this.StorageSize != null && !this.StorageSize.Equals(input.StorageSize))) return false;
            if (this.RepositorySize != input.RepositorySize || (this.RepositorySize != null && !this.RepositorySize.Equals(input.RepositorySize))) return false;
            if (this.LfsObjectsSize != input.LfsObjectsSize || (this.LfsObjectsSize != null && !this.LfsObjectsSize.Equals(input.LfsObjectsSize))) return false;
            if (this.TenantRepoSizeLimit != input.TenantRepoSizeLimit || (this.TenantRepoSizeLimit != null && !this.TenantRepoSizeLimit.Equals(input.TenantRepoSizeLimit))) return false;

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
                if (this.CommitCount != null) hashCode = hashCode * 59 + this.CommitCount.GetHashCode();
                if (this.StorageSize != null) hashCode = hashCode * 59 + this.StorageSize.GetHashCode();
                if (this.RepositorySize != null) hashCode = hashCode * 59 + this.RepositorySize.GetHashCode();
                if (this.LfsObjectsSize != null) hashCode = hashCode * 59 + this.LfsObjectsSize.GetHashCode();
                if (this.TenantRepoSizeLimit != null) hashCode = hashCode * 59 + this.TenantRepoSizeLimit.GetHashCode();
                return hashCode;
            }
        }
    }
}
