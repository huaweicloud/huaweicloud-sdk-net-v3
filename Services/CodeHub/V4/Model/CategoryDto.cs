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
    public class CategoryDto 
    {

        /// <summary>
        /// **参数解释：** 检视意见分类key。
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// **参数解释：** 检视意见分类中文名。
        /// </summary>
        [JsonProperty("name_zh", NullValueHandling = NullValueHandling.Ignore)]
        public string NameZh { get; set; }

        /// <summary>
        /// **参数解释：** 检视意见分类英文名。
        /// </summary>
        [JsonProperty("name_en", NullValueHandling = NullValueHandling.Ignore)]
        public string NameEn { get; set; }

        /// <summary>
        /// **参数解释：** 子检视意见分类。
        /// </summary>
        [JsonProperty("sub_categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<CategoryDto> SubCategories { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CategoryDto {\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  nameZh: ").Append(NameZh).Append("\n");
            sb.Append("  nameEn: ").Append(NameEn).Append("\n");
            sb.Append("  subCategories: ").Append(SubCategories).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CategoryDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CategoryDto input)
        {
            if (input == null) return false;
            if (this.Key != input.Key || (this.Key != null && !this.Key.Equals(input.Key))) return false;
            if (this.NameZh != input.NameZh || (this.NameZh != null && !this.NameZh.Equals(input.NameZh))) return false;
            if (this.NameEn != input.NameEn || (this.NameEn != null && !this.NameEn.Equals(input.NameEn))) return false;
            if (this.SubCategories != input.SubCategories || (this.SubCategories != null && input.SubCategories != null && !this.SubCategories.SequenceEqual(input.SubCategories))) return false;

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
                if (this.Key != null) hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.NameZh != null) hashCode = hashCode * 59 + this.NameZh.GetHashCode();
                if (this.NameEn != null) hashCode = hashCode * 59 + this.NameEn.GetHashCode();
                if (this.SubCategories != null) hashCode = hashCode * 59 + this.SubCategories.GetHashCode();
                return hashCode;
            }
        }
    }
}
