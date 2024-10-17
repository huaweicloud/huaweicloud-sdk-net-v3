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
    /// 搜索的相关信息。
    /// </summary>
    public class SearchRestInfo 
    {

        /// <summary>
        /// 搜索结果列表。
        /// </summary>
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<SearchItem> Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("search_info", NullValueHandling = NullValueHandling.Ignore)]
        public SearchInfo SearchInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("image_info", NullValueHandling = NullValueHandling.Ignore)]
        public SearchRestInfoImageInfo ImageInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchRestInfo {\n");
            sb.Append("  items: ").Append(Items).Append("\n");
            sb.Append("  searchInfo: ").Append(SearchInfo).Append("\n");
            sb.Append("  imageInfo: ").Append(ImageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchRestInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchRestInfo input)
        {
            if (input == null) return false;
            if (this.Items != input.Items || (this.Items != null && input.Items != null && !this.Items.SequenceEqual(input.Items))) return false;
            if (this.SearchInfo != input.SearchInfo || (this.SearchInfo != null && !this.SearchInfo.Equals(input.SearchInfo))) return false;
            if (this.ImageInfo != input.ImageInfo || (this.ImageInfo != null && !this.ImageInfo.Equals(input.ImageInfo))) return false;

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
                if (this.Items != null) hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.SearchInfo != null) hashCode = hashCode * 59 + this.SearchInfo.GetHashCode();
                if (this.ImageInfo != null) hashCode = hashCode * 59 + this.ImageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
