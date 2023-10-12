using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ImageSearch.V2.Model
{
    /// <summary>
    /// 搜索图像的相关信息，不同服务类型返回信息不同，具体可参见服务类型说明。
    /// </summary>
    public class SearchRestInfoImageInfo 
    {

        /// <summary>
        /// 用于搜索的主体目标框。
        /// </summary>
        [JsonProperty("box", NullValueHandling = NullValueHandling.Ignore)]
        public string Box { get; set; }

        /// <summary>
        /// 用于搜索的主体类目序号。
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public int? Category { get; set; }

        /// <summary>
        /// 用于搜索的主体类目名称。
        /// </summary>
        [JsonProperty("category_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryName { get; set; }

        /// <summary>
        /// 搜索图像中的所有主体列表。
        /// </summary>
        [JsonProperty("objects", NullValueHandling = NullValueHandling.Ignore)]
        public List<AddDataRestInfoImageInfoObjects> Objects { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchRestInfoImageInfo {\n");
            sb.Append("  box: ").Append(Box).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  categoryName: ").Append(CategoryName).Append("\n");
            sb.Append("  objects: ").Append(Objects).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchRestInfoImageInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchRestInfoImageInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Box == input.Box ||
                    (this.Box != null &&
                    this.Box.Equals(input.Box))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.CategoryName == input.CategoryName ||
                    (this.CategoryName != null &&
                    this.CategoryName.Equals(input.CategoryName))
                ) && 
                (
                    this.Objects == input.Objects ||
                    this.Objects != null &&
                    input.Objects != null &&
                    this.Objects.SequenceEqual(input.Objects)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Box != null)
                    hashCode = hashCode * 59 + this.Box.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.CategoryName != null)
                    hashCode = hashCode * 59 + this.CategoryName.GetHashCode();
                if (this.Objects != null)
                    hashCode = hashCode * 59 + this.Objects.GetHashCode();
                return hashCode;
            }
        }
    }
}
