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
    /// 搜索结果的相关信息。
    /// </summary>
    public class SearchInfo 
    {

        /// <summary>
        /// 搜索结果总数。
        /// </summary>
        [JsonProperty("total_num", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? TotalNum { get; set; }

        /// <summary>
        /// 返回结果总数。
        /// </summary>
        [JsonProperty("return_num", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? ReturnNum { get; set; }

        /// <summary>
        /// 搜索过程耗时，单位为毫秒。
        /// </summary>
        [JsonProperty("search_time", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? SearchTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("last_item", NullValueHandling = NullValueHandling.Ignore)]
        public SearchAfterParam LastItem { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchInfo {\n");
            sb.Append("  totalNum: ").Append(TotalNum).Append("\n");
            sb.Append("  returnNum: ").Append(ReturnNum).Append("\n");
            sb.Append("  searchTime: ").Append(SearchTime).Append("\n");
            sb.Append("  lastItem: ").Append(LastItem).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalNum == input.TotalNum ||
                    (this.TotalNum != null &&
                    this.TotalNum.Equals(input.TotalNum))
                ) && 
                (
                    this.ReturnNum == input.ReturnNum ||
                    (this.ReturnNum != null &&
                    this.ReturnNum.Equals(input.ReturnNum))
                ) && 
                (
                    this.SearchTime == input.SearchTime ||
                    (this.SearchTime != null &&
                    this.SearchTime.Equals(input.SearchTime))
                ) && 
                (
                    this.LastItem == input.LastItem ||
                    (this.LastItem != null &&
                    this.LastItem.Equals(input.LastItem))
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
                if (this.TotalNum != null)
                    hashCode = hashCode * 59 + this.TotalNum.GetHashCode();
                if (this.ReturnNum != null)
                    hashCode = hashCode * 59 + this.ReturnNum.GetHashCode();
                if (this.SearchTime != null)
                    hashCode = hashCode * 59 + this.SearchTime.GetHashCode();
                if (this.LastItem != null)
                    hashCode = hashCode * 59 + this.LastItem.GetHashCode();
                return hashCode;
            }
        }
    }
}
