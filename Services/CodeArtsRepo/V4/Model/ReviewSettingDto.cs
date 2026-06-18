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
    /// 检视意见设置返回体
    /// </summary>
    public class ReviewSettingDto 
    {

        /// <summary>
        /// **参数解释：** 是否启用启用检视意见分类与模块。
        /// </summary>
        [JsonProperty("categories_and_modules_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CategoriesAndModulesEnabled { get; set; }

        /// <summary>
        /// **参数解释：** 是否启用系统预置检视意见分类。
        /// </summary>
        [JsonProperty("secondary_category_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SecondaryCategoryEnabled { get; set; }

        /// <summary>
        /// **参数解释：** 检视意见分类(已勾选)。
        /// </summary>
        [JsonProperty("primary_categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<CategoryDto> PrimaryCategories { get; set; }

        /// <summary>
        /// **参数解释：** 检视意见分类的key(已勾选)。
        /// </summary>
        [JsonProperty("review_default_categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ReviewDefaultCategories { get; set; }

        /// <summary>
        /// **参数解释：** 自定义分类。
        /// </summary>
        [JsonProperty("review_customized_categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ReviewCustomizedCategories { get; set; }

        /// <summary>
        /// **参数解释：** 检视意见模块。
        /// </summary>
        [JsonProperty("review_modules", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ReviewModules { get; set; }

        /// <summary>
        /// **参数解释：** 系统预置检视意见分类类型(启用系统预置检视意见分类时返回，默认&#39;HiCode&#39;)。
        /// </summary>
        [JsonProperty("secondary_category_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SecondaryCategoryType { get; set; }

        /// <summary>
        /// **参数解释：** 系统预置检视意见分类详情(启用系统预置检视意见分类时返回)。
        /// </summary>
        [JsonProperty("secondary_categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<CategoryDto> SecondaryCategories { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReviewSettingDto {\n");
            sb.Append("  categoriesAndModulesEnabled: ").Append(CategoriesAndModulesEnabled).Append("\n");
            sb.Append("  secondaryCategoryEnabled: ").Append(SecondaryCategoryEnabled).Append("\n");
            sb.Append("  primaryCategories: ").Append(PrimaryCategories).Append("\n");
            sb.Append("  reviewDefaultCategories: ").Append(ReviewDefaultCategories).Append("\n");
            sb.Append("  reviewCustomizedCategories: ").Append(ReviewCustomizedCategories).Append("\n");
            sb.Append("  reviewModules: ").Append(ReviewModules).Append("\n");
            sb.Append("  secondaryCategoryType: ").Append(SecondaryCategoryType).Append("\n");
            sb.Append("  secondaryCategories: ").Append(SecondaryCategories).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReviewSettingDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReviewSettingDto input)
        {
            if (input == null) return false;
            if (this.CategoriesAndModulesEnabled != input.CategoriesAndModulesEnabled || (this.CategoriesAndModulesEnabled != null && !this.CategoriesAndModulesEnabled.Equals(input.CategoriesAndModulesEnabled))) return false;
            if (this.SecondaryCategoryEnabled != input.SecondaryCategoryEnabled || (this.SecondaryCategoryEnabled != null && !this.SecondaryCategoryEnabled.Equals(input.SecondaryCategoryEnabled))) return false;
            if (this.PrimaryCategories != input.PrimaryCategories || (this.PrimaryCategories != null && input.PrimaryCategories != null && !this.PrimaryCategories.SequenceEqual(input.PrimaryCategories))) return false;
            if (this.ReviewDefaultCategories != input.ReviewDefaultCategories || (this.ReviewDefaultCategories != null && input.ReviewDefaultCategories != null && !this.ReviewDefaultCategories.SequenceEqual(input.ReviewDefaultCategories))) return false;
            if (this.ReviewCustomizedCategories != input.ReviewCustomizedCategories || (this.ReviewCustomizedCategories != null && input.ReviewCustomizedCategories != null && !this.ReviewCustomizedCategories.SequenceEqual(input.ReviewCustomizedCategories))) return false;
            if (this.ReviewModules != input.ReviewModules || (this.ReviewModules != null && input.ReviewModules != null && !this.ReviewModules.SequenceEqual(input.ReviewModules))) return false;
            if (this.SecondaryCategoryType != input.SecondaryCategoryType || (this.SecondaryCategoryType != null && !this.SecondaryCategoryType.Equals(input.SecondaryCategoryType))) return false;
            if (this.SecondaryCategories != input.SecondaryCategories || (this.SecondaryCategories != null && input.SecondaryCategories != null && !this.SecondaryCategories.SequenceEqual(input.SecondaryCategories))) return false;

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
                if (this.SecondaryCategoryEnabled != null) hashCode = hashCode * 59 + this.SecondaryCategoryEnabled.GetHashCode();
                if (this.PrimaryCategories != null) hashCode = hashCode * 59 + this.PrimaryCategories.GetHashCode();
                if (this.ReviewDefaultCategories != null) hashCode = hashCode * 59 + this.ReviewDefaultCategories.GetHashCode();
                if (this.ReviewCustomizedCategories != null) hashCode = hashCode * 59 + this.ReviewCustomizedCategories.GetHashCode();
                if (this.ReviewModules != null) hashCode = hashCode * 59 + this.ReviewModules.GetHashCode();
                if (this.SecondaryCategoryType != null) hashCode = hashCode * 59 + this.SecondaryCategoryType.GetHashCode();
                if (this.SecondaryCategories != null) hashCode = hashCode * 59 + this.SecondaryCategories.GetHashCode();
                return hashCode;
            }
        }
    }
}
