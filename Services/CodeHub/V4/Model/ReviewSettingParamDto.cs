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
    public class ReviewSettingParamDto 
    {

        /// <summary>
        /// **参数解释：** 是否启用启用检视意见分类与模块。
        /// </summary>
        [JsonProperty("categories_and_modules_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CategoriesAndModulesEnabled { get; set; }

        /// <summary>
        /// **参数解释：** 检视意见模块。
        /// </summary>
        [JsonProperty("review_modules", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ReviewModules { get; set; }

        /// <summary>
        /// **参数解释：** 是否启用系统预置检视意见分类。
        /// </summary>
        [JsonProperty("secondary_category_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SecondaryCategoryEnabled { get; set; }

        /// <summary>
        /// **参数解释：** 检视意见分类(已勾选的分类的key列表)。
        /// </summary>
        [JsonProperty("review_default_categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ReviewDefaultCategories { get; set; }

        /// <summary>
        /// **参数解释：** 自定义分类列表。
        /// </summary>
        [JsonProperty("review_customized_categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ReviewCustomizedCategories { get; set; }

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
            sb.Append("class ReviewSettingParamDto {\n");
            sb.Append("  categoriesAndModulesEnabled: ").Append(CategoriesAndModulesEnabled).Append("\n");
            sb.Append("  reviewModules: ").Append(ReviewModules).Append("\n");
            sb.Append("  secondaryCategoryEnabled: ").Append(SecondaryCategoryEnabled).Append("\n");
            sb.Append("  reviewDefaultCategories: ").Append(ReviewDefaultCategories).Append("\n");
            sb.Append("  reviewCustomizedCategories: ").Append(ReviewCustomizedCategories).Append("\n");
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
            return this.Equals(input as ReviewSettingParamDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReviewSettingParamDto input)
        {
            if (input == null) return false;
            if (this.CategoriesAndModulesEnabled != input.CategoriesAndModulesEnabled || (this.CategoriesAndModulesEnabled != null && !this.CategoriesAndModulesEnabled.Equals(input.CategoriesAndModulesEnabled))) return false;
            if (this.ReviewModules != input.ReviewModules || (this.ReviewModules != null && input.ReviewModules != null && !this.ReviewModules.SequenceEqual(input.ReviewModules))) return false;
            if (this.SecondaryCategoryEnabled != input.SecondaryCategoryEnabled || (this.SecondaryCategoryEnabled != null && !this.SecondaryCategoryEnabled.Equals(input.SecondaryCategoryEnabled))) return false;
            if (this.ReviewDefaultCategories != input.ReviewDefaultCategories || (this.ReviewDefaultCategories != null && input.ReviewDefaultCategories != null && !this.ReviewDefaultCategories.SequenceEqual(input.ReviewDefaultCategories))) return false;
            if (this.ReviewCustomizedCategories != input.ReviewCustomizedCategories || (this.ReviewCustomizedCategories != null && input.ReviewCustomizedCategories != null && !this.ReviewCustomizedCategories.SequenceEqual(input.ReviewCustomizedCategories))) return false;
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
                if (this.CategoriesAndModulesEnabled != null) hashCode = hashCode * 59 + this.CategoriesAndModulesEnabled.GetHashCode();
                if (this.ReviewModules != null) hashCode = hashCode * 59 + this.ReviewModules.GetHashCode();
                if (this.SecondaryCategoryEnabled != null) hashCode = hashCode * 59 + this.SecondaryCategoryEnabled.GetHashCode();
                if (this.ReviewDefaultCategories != null) hashCode = hashCode * 59 + this.ReviewDefaultCategories.GetHashCode();
                if (this.ReviewCustomizedCategories != null) hashCode = hashCode * 59 + this.ReviewCustomizedCategories.GetHashCode();
                if (this.IsAssigneeIdRequired != null) hashCode = hashCode * 59 + this.IsAssigneeIdRequired.GetHashCode();
                if (this.IsReviewCategoriesRequired != null) hashCode = hashCode * 59 + this.IsReviewCategoriesRequired.GetHashCode();
                if (this.IsReviewModulesRequired != null) hashCode = hashCode * 59 + this.IsReviewModulesRequired.GetHashCode();
                return hashCode;
            }
        }
    }
}
