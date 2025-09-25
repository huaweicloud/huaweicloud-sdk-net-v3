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
    public class ForkRepositoryDto 
    {

        /// <summary>
        /// **参数解释：** 仓库ID。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** 仓库名称。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 是否归档。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("archived", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Archived { get; set; }

        /// <summary>
        /// **参数解释：** 产品ID。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// **参数解释：** 产品名称。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("product_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductName { get; set; }

        /// <summary>
        /// **参数解释：** 带命名空间的仓库路径。 **约束限制：** view&#x3D;least时返回
        /// </summary>
        [JsonProperty("path_with_namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string PathWithNamespace { get; set; }

        /// <summary>
        /// **参数解释：** 命名空间。 **约束限制：** view&#x3D;basic时返回
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// **参数解释：** 仓库路径。 **约束限制：** view&#x3D;basic时返回
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// **参数解释：** 开发模式。 **约束限制：** view&#x3D;basic时返回
        /// </summary>
        [JsonProperty("develop_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string DevelopMode { get; set; }

        /// <summary>
        /// **参数解释：** 可见性。 **约束限制：** view&#x3D;basic时返回
        /// </summary>
        [JsonProperty("visibility", NullValueHandling = NullValueHandling.Ignore)]
        public string Visibility { get; set; }

        /// <summary>
        /// **参数解释：** 安全级别。 **约束限制：**  view&#x3D;basic时返回
        /// </summary>
        [JsonProperty("security", NullValueHandling = NullValueHandling.Ignore)]
        public string Security { get; set; }

        /// <summary>
        /// **参数解释：** 关注数。 **约束限制：** view&#x3D;basic时返回
        /// </summary>
        [JsonProperty("star_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? StarCount { get; set; }

        /// <summary>
        /// **参数解释：** Fork数。 **约束限制：** view&#x3D;basic时返回
        /// </summary>
        [JsonProperty("forks_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ForksCount { get; set; }

        /// <summary>
        /// **参数解释：** 开启的合并请求数。 **约束限制：** view&#x3D;basic时返回
        /// </summary>
        [JsonProperty("open_merge_requests_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? OpenMergeRequestsCount { get; set; }

        /// <summary>
        /// **参数解释：** 是否已关注。 **约束限制：** view&#x3D;basic时返回
        /// </summary>
        [JsonProperty("starred", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Starred { get; set; }

        /// <summary>
        /// **参数解释：** 带命名空间的仓库名称。 **约束限制：** view&#x3D;basic时返回
        /// </summary>
        [JsonProperty("name_with_namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string NameWithNamespace { get; set; }

        /// <summary>
        /// **参数解释：** 最后活动时间。 **约束限制：** view&#x3D;basic时返回
        /// </summary>
        [JsonProperty("last_activity_at", NullValueHandling = NullValueHandling.Ignore)]
        public string LastActivityAt { get; set; }

        /// <summary>
        /// **参数解释：** 创建时间。 **约束限制：** view&#x3D;basic时返回
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForkRepositoryDto {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  archived: ").Append(Archived).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  productName: ").Append(ProductName).Append("\n");
            sb.Append("  pathWithNamespace: ").Append(PathWithNamespace).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  developMode: ").Append(DevelopMode).Append("\n");
            sb.Append("  visibility: ").Append(Visibility).Append("\n");
            sb.Append("  security: ").Append(Security).Append("\n");
            sb.Append("  starCount: ").Append(StarCount).Append("\n");
            sb.Append("  forksCount: ").Append(ForksCount).Append("\n");
            sb.Append("  openMergeRequestsCount: ").Append(OpenMergeRequestsCount).Append("\n");
            sb.Append("  starred: ").Append(Starred).Append("\n");
            sb.Append("  nameWithNamespace: ").Append(NameWithNamespace).Append("\n");
            sb.Append("  lastActivityAt: ").Append(LastActivityAt).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ForkRepositoryDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ForkRepositoryDto input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Archived != input.Archived || (this.Archived != null && !this.Archived.Equals(input.Archived))) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.ProductName != input.ProductName || (this.ProductName != null && !this.ProductName.Equals(input.ProductName))) return false;
            if (this.PathWithNamespace != input.PathWithNamespace || (this.PathWithNamespace != null && !this.PathWithNamespace.Equals(input.PathWithNamespace))) return false;
            if (this.Namespace != input.Namespace || (this.Namespace != null && !this.Namespace.Equals(input.Namespace))) return false;
            if (this.Path != input.Path || (this.Path != null && !this.Path.Equals(input.Path))) return false;
            if (this.DevelopMode != input.DevelopMode || (this.DevelopMode != null && !this.DevelopMode.Equals(input.DevelopMode))) return false;
            if (this.Visibility != input.Visibility || (this.Visibility != null && !this.Visibility.Equals(input.Visibility))) return false;
            if (this.Security != input.Security || (this.Security != null && !this.Security.Equals(input.Security))) return false;
            if (this.StarCount != input.StarCount || (this.StarCount != null && !this.StarCount.Equals(input.StarCount))) return false;
            if (this.ForksCount != input.ForksCount || (this.ForksCount != null && !this.ForksCount.Equals(input.ForksCount))) return false;
            if (this.OpenMergeRequestsCount != input.OpenMergeRequestsCount || (this.OpenMergeRequestsCount != null && !this.OpenMergeRequestsCount.Equals(input.OpenMergeRequestsCount))) return false;
            if (this.Starred != input.Starred || (this.Starred != null && !this.Starred.Equals(input.Starred))) return false;
            if (this.NameWithNamespace != input.NameWithNamespace || (this.NameWithNamespace != null && !this.NameWithNamespace.Equals(input.NameWithNamespace))) return false;
            if (this.LastActivityAt != input.LastActivityAt || (this.LastActivityAt != null && !this.LastActivityAt.Equals(input.LastActivityAt))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Archived != null) hashCode = hashCode * 59 + this.Archived.GetHashCode();
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.ProductName != null) hashCode = hashCode * 59 + this.ProductName.GetHashCode();
                if (this.PathWithNamespace != null) hashCode = hashCode * 59 + this.PathWithNamespace.GetHashCode();
                if (this.Namespace != null) hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.Path != null) hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.DevelopMode != null) hashCode = hashCode * 59 + this.DevelopMode.GetHashCode();
                if (this.Visibility != null) hashCode = hashCode * 59 + this.Visibility.GetHashCode();
                if (this.Security != null) hashCode = hashCode * 59 + this.Security.GetHashCode();
                if (this.StarCount != null) hashCode = hashCode * 59 + this.StarCount.GetHashCode();
                if (this.ForksCount != null) hashCode = hashCode * 59 + this.ForksCount.GetHashCode();
                if (this.OpenMergeRequestsCount != null) hashCode = hashCode * 59 + this.OpenMergeRequestsCount.GetHashCode();
                if (this.Starred != null) hashCode = hashCode * 59 + this.Starred.GetHashCode();
                if (this.NameWithNamespace != null) hashCode = hashCode * 59 + this.NameWithNamespace.GetHashCode();
                if (this.LastActivityAt != null) hashCode = hashCode * 59 + this.LastActivityAt.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
