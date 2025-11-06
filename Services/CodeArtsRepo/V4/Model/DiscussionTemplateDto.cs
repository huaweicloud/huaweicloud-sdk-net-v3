using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// 检视意见模板返回体
    /// </summary>
    public class DiscussionTemplateDto 
    {

        /// <summary>
        /// **参数解释：** 检视意见模板主键id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** 模板名称。
        /// </summary>
        [JsonProperty("template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        /// <summary>
        /// **参数解释：** 描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释：** 默认指派人。
        /// </summary>
        [JsonProperty("assignee_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? AssigneeId { get; set; }

        /// <summary>
        /// **参数解释：** 意见分类key。
        /// </summary>
        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        public string Categories { get; set; }

        /// <summary>
        /// **参数解释：** 意见分类英文。
        /// </summary>
        [JsonProperty("categories_en", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoriesEn { get; set; }

        /// <summary>
        /// **参数解释：** 意见分类中文。
        /// </summary>
        [JsonProperty("categories_cn", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoriesCn { get; set; }

        /// <summary>
        /// **参数解释：** 检视意见模块。
        /// </summary>
        [JsonProperty("modules", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Modules { get; set; }

        /// <summary>
        /// **参数解释：** 严重程度key。
        /// </summary>
        [JsonProperty("review_severity", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewSeverity { get; set; }

        /// <summary>
        /// **参数解释：** 是否设置为默认模板。
        /// </summary>
        [JsonProperty("is_default", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// **参数解释：** 模板作者id。
        /// </summary>
        [JsonProperty("creator_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? CreatorId { get; set; }

        /// <summary>
        /// **参数解释：** 创建时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// **参数解释：** 更新时间。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public UserBasicDto Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("assignee", NullValueHandling = NullValueHandling.Ignore)]
        public UserBasicDto Assignee { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiscussionTemplateDto {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  templateName: ").Append(TemplateName).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  assigneeId: ").Append(AssigneeId).Append("\n");
            sb.Append("  categories: ").Append(Categories).Append("\n");
            sb.Append("  categoriesEn: ").Append(CategoriesEn).Append("\n");
            sb.Append("  categoriesCn: ").Append(CategoriesCn).Append("\n");
            sb.Append("  modules: ").Append(Modules).Append("\n");
            sb.Append("  reviewSeverity: ").Append(ReviewSeverity).Append("\n");
            sb.Append("  isDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  creatorId: ").Append(CreatorId).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  creator: ").Append(Creator).Append("\n");
            sb.Append("  assignee: ").Append(Assignee).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DiscussionTemplateDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DiscussionTemplateDto input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.TemplateName != input.TemplateName || (this.TemplateName != null && !this.TemplateName.Equals(input.TemplateName))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.AssigneeId != input.AssigneeId || (this.AssigneeId != null && !this.AssigneeId.Equals(input.AssigneeId))) return false;
            if (this.Categories != input.Categories || (this.Categories != null && !this.Categories.Equals(input.Categories))) return false;
            if (this.CategoriesEn != input.CategoriesEn || (this.CategoriesEn != null && !this.CategoriesEn.Equals(input.CategoriesEn))) return false;
            if (this.CategoriesCn != input.CategoriesCn || (this.CategoriesCn != null && !this.CategoriesCn.Equals(input.CategoriesCn))) return false;
            if (this.Modules != input.Modules || (this.Modules != null && input.Modules != null && !this.Modules.SequenceEqual(input.Modules))) return false;
            if (this.ReviewSeverity != input.ReviewSeverity || (this.ReviewSeverity != null && !this.ReviewSeverity.Equals(input.ReviewSeverity))) return false;
            if (this.IsDefault != input.IsDefault || (this.IsDefault != null && !this.IsDefault.Equals(input.IsDefault))) return false;
            if (this.CreatorId != input.CreatorId || (this.CreatorId != null && !this.CreatorId.Equals(input.CreatorId))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.Creator != input.Creator || (this.Creator != null && !this.Creator.Equals(input.Creator))) return false;
            if (this.Assignee != input.Assignee || (this.Assignee != null && !this.Assignee.Equals(input.Assignee))) return false;

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
                if (this.TemplateName != null) hashCode = hashCode * 59 + this.TemplateName.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.AssigneeId != null) hashCode = hashCode * 59 + this.AssigneeId.GetHashCode();
                if (this.Categories != null) hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.CategoriesEn != null) hashCode = hashCode * 59 + this.CategoriesEn.GetHashCode();
                if (this.CategoriesCn != null) hashCode = hashCode * 59 + this.CategoriesCn.GetHashCode();
                if (this.Modules != null) hashCode = hashCode * 59 + this.Modules.GetHashCode();
                if (this.ReviewSeverity != null) hashCode = hashCode * 59 + this.ReviewSeverity.GetHashCode();
                if (this.IsDefault != null) hashCode = hashCode * 59 + this.IsDefault.GetHashCode();
                if (this.CreatorId != null) hashCode = hashCode * 59 + this.CreatorId.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Creator != null) hashCode = hashCode * 59 + this.Creator.GetHashCode();
                if (this.Assignee != null) hashCode = hashCode * 59 + this.Assignee.GetHashCode();
                return hashCode;
            }
        }
    }
}
