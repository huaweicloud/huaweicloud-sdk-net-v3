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
    /// 检视意见设置请求体
    /// </summary>
    public class PostNoteRequiredAttributeDto 
    {

        /// <summary>
        /// **参数解释：** 是否勾选指派给。
        /// </summary>
        [JsonProperty("is_assignee_id_required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAssigneeIdRequired { get; set; }

        /// <summary>
        /// **参数解释：** 是否勾选意见分类。
        /// </summary>
        [JsonProperty("is_review_categories_required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsReviewCategoriesRequired { get; set; }

        /// <summary>
        /// **参数解释：** 是否勾选意见模块。
        /// </summary>
        [JsonProperty("is_review_modules_required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsReviewModulesRequired { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostNoteRequiredAttributeDto {\n");
            sb.Append("  isAssigneeIdRequired: ").Append(IsAssigneeIdRequired).Append("\n");
            sb.Append("  isReviewCategoriesRequired: ").Append(IsReviewCategoriesRequired).Append("\n");
            sb.Append("  isReviewModulesRequired: ").Append(IsReviewModulesRequired).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PostNoteRequiredAttributeDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PostNoteRequiredAttributeDto input)
        {
            if (input == null) return false;
            if (this.IsAssigneeIdRequired != input.IsAssigneeIdRequired || (this.IsAssigneeIdRequired != null && !this.IsAssigneeIdRequired.Equals(input.IsAssigneeIdRequired))) return false;
            if (this.IsReviewCategoriesRequired != input.IsReviewCategoriesRequired || (this.IsReviewCategoriesRequired != null && !this.IsReviewCategoriesRequired.Equals(input.IsReviewCategoriesRequired))) return false;
            if (this.IsReviewModulesRequired != input.IsReviewModulesRequired || (this.IsReviewModulesRequired != null && !this.IsReviewModulesRequired.Equals(input.IsReviewModulesRequired))) return false;

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
                if (this.IsAssigneeIdRequired != null) hashCode = hashCode * 59 + this.IsAssigneeIdRequired.GetHashCode();
                if (this.IsReviewCategoriesRequired != null) hashCode = hashCode * 59 + this.IsReviewCategoriesRequired.GetHashCode();
                if (this.IsReviewModulesRequired != null) hashCode = hashCode * 59 + this.IsReviewModulesRequired.GetHashCode();
                return hashCode;
            }
        }
    }
}
