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
    /// Response Object
    /// </summary>
    public class CreateRepositoryLabelResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 标签ID。 **取值范围：** 1-2147483647
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** 标签名。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 标签颜色，以6位十六进制表示法给出，带有前导“#”符号（例如，#FFAABB）。 **取值范围：** 正则&#x60;^#([a-fA-F0-9]{6}|[a-fA-F0-9]{3})$&#x60;
        /// </summary>
        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }

        /// <summary>
        /// **参数解释：** 描述。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释：** 字体颜色，以6位十六进制表示法给出，带有前导“#”符号（例如，#FFAABB）。 **取值范围：** 正则&#x60;^#([a-fA-F0-9]{6}|[a-fA-F0-9]{3})$&#x60;
        /// </summary>
        [JsonProperty("text_color", NullValueHandling = NullValueHandling.Ignore)]
        public string TextColor { get; set; }

        /// <summary>
        /// **参数解释：** 失效时间。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("expires_at", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// **参数解释：** 是否失效。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("is_expired", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsExpired { get; set; }

        /// <summary>
        /// **参数解释：** 关联开启状态MR的数量。 **约束限制：** MR仓库返回此字段。 **取值范围：** 0-2147483647
        /// </summary>
        [JsonProperty("open_merge_requests_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? OpenMergeRequestsCount { get; set; }

        /// <summary>
        /// **参数解释：**  关联开启状态CR的数量。  **约束限制：**  CR仓库返回此字段。  **取值范围：**  0-2147483647
        /// </summary>
        [JsonProperty("open_change_request_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? OpenChangeRequestCount { get; set; }

        /// <summary>
        /// **参数解释：** 优先级 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// **参数解释：** 是否为仓库标签 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("is_repository_label", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsRepositoryLabel { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRepositoryLabelResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  color: ").Append(Color).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  textColor: ").Append(TextColor).Append("\n");
            sb.Append("  expiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  isExpired: ").Append(IsExpired).Append("\n");
            sb.Append("  openMergeRequestsCount: ").Append(OpenMergeRequestsCount).Append("\n");
            sb.Append("  openChangeRequestCount: ").Append(OpenChangeRequestCount).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  isRepositoryLabel: ").Append(IsRepositoryLabel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateRepositoryLabelResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateRepositoryLabelResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Color != input.Color || (this.Color != null && !this.Color.Equals(input.Color))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.TextColor != input.TextColor || (this.TextColor != null && !this.TextColor.Equals(input.TextColor))) return false;
            if (this.ExpiresAt != input.ExpiresAt || (this.ExpiresAt != null && !this.ExpiresAt.Equals(input.ExpiresAt))) return false;
            if (this.IsExpired != input.IsExpired || (this.IsExpired != null && !this.IsExpired.Equals(input.IsExpired))) return false;
            if (this.OpenMergeRequestsCount != input.OpenMergeRequestsCount || (this.OpenMergeRequestsCount != null && !this.OpenMergeRequestsCount.Equals(input.OpenMergeRequestsCount))) return false;
            if (this.OpenChangeRequestCount != input.OpenChangeRequestCount || (this.OpenChangeRequestCount != null && !this.OpenChangeRequestCount.Equals(input.OpenChangeRequestCount))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.IsRepositoryLabel != input.IsRepositoryLabel || (this.IsRepositoryLabel != null && !this.IsRepositoryLabel.Equals(input.IsRepositoryLabel))) return false;

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
                if (this.Color != null) hashCode = hashCode * 59 + this.Color.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.TextColor != null) hashCode = hashCode * 59 + this.TextColor.GetHashCode();
                if (this.ExpiresAt != null) hashCode = hashCode * 59 + this.ExpiresAt.GetHashCode();
                if (this.IsExpired != null) hashCode = hashCode * 59 + this.IsExpired.GetHashCode();
                if (this.OpenMergeRequestsCount != null) hashCode = hashCode * 59 + this.OpenMergeRequestsCount.GetHashCode();
                if (this.OpenChangeRequestCount != null) hashCode = hashCode * 59 + this.OpenChangeRequestCount.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.IsRepositoryLabel != null) hashCode = hashCode * 59 + this.IsRepositoryLabel.GetHashCode();
                return hashCode;
            }
        }
    }
}
