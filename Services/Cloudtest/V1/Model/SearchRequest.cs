using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SearchRequest 
    {

        /// <summary>
        /// 过滤类型
        /// </summary>
        [JsonProperty("search_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SearchType { get; set; }

        /// <summary>
        /// 过滤条件
        /// </summary>
        [JsonProperty("search_value", NullValueHandling = NullValueHandling.Ignore)]
        public string SearchValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchRequest {\n");
            sb.Append("  searchType: ").Append(SearchType).Append("\n");
            sb.Append("  searchValue: ").Append(SearchValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchRequest input)
        {
            if (input == null) return false;
            if (this.SearchType != input.SearchType || (this.SearchType != null && !this.SearchType.Equals(input.SearchType))) return false;
            if (this.SearchValue != input.SearchValue || (this.SearchValue != null && !this.SearchValue.Equals(input.SearchValue))) return false;

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
                if (this.SearchType != null) hashCode = hashCode * 59 + this.SearchType.GetHashCode();
                if (this.SearchValue != null) hashCode = hashCode * 59 + this.SearchValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
