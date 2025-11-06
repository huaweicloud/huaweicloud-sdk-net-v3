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
    /// Response Object
    /// </summary>
    public class ListDefaultReviewCategoriesResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 检视意见分类(所有可勾选的，需传参with_default_review_categories: true才返回)。
        /// </summary>
        [JsonProperty("codehub_default_categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<CategoryDto> CodehubDefaultCategories { get; set; }

        /// <summary>
        /// **参数解释：** 系统预置检视意见分类(需传参with_default_review_categories: true才返回)。
        /// </summary>
        [JsonProperty("hicode_default_categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<CategoryDto> HicodeDefaultCategories { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDefaultReviewCategoriesResponse {\n");
            sb.Append("  codehubDefaultCategories: ").Append(CodehubDefaultCategories).Append("\n");
            sb.Append("  hicodeDefaultCategories: ").Append(HicodeDefaultCategories).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDefaultReviewCategoriesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDefaultReviewCategoriesResponse input)
        {
            if (input == null) return false;
            if (this.CodehubDefaultCategories != input.CodehubDefaultCategories || (this.CodehubDefaultCategories != null && input.CodehubDefaultCategories != null && !this.CodehubDefaultCategories.SequenceEqual(input.CodehubDefaultCategories))) return false;
            if (this.HicodeDefaultCategories != input.HicodeDefaultCategories || (this.HicodeDefaultCategories != null && input.HicodeDefaultCategories != null && !this.HicodeDefaultCategories.SequenceEqual(input.HicodeDefaultCategories))) return false;

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
                if (this.CodehubDefaultCategories != null) hashCode = hashCode * 59 + this.CodehubDefaultCategories.GetHashCode();
                if (this.HicodeDefaultCategories != null) hashCode = hashCode * 59 + this.HicodeDefaultCategories.GetHashCode();
                return hashCode;
            }
        }
    }
}
