using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ChartConfig 
    {

        /// <summary>
        /// 是否开启排序
        /// </summary>
        [JsonProperty("can_sort", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanSort { get; set; }

        /// <summary>
        /// 是否开启搜索
        /// </summary>
        [JsonProperty("can_search", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanSearch { get; set; }

        /// <summary>
        /// 每页显示数量
        /// </summary>
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChartConfig {\n");
            sb.Append("  canSort: ").Append(CanSort).Append("\n");
            sb.Append("  canSearch: ").Append(CanSearch).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChartConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChartConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CanSort == input.CanSort ||
                    (this.CanSort != null &&
                    this.CanSort.Equals(input.CanSort))
                ) && 
                (
                    this.CanSearch == input.CanSearch ||
                    (this.CanSearch != null &&
                    this.CanSearch.Equals(input.CanSearch))
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    (this.PageSize != null &&
                    this.PageSize.Equals(input.PageSize))
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
                if (this.CanSort != null)
                    hashCode = hashCode * 59 + this.CanSort.GetHashCode();
                if (this.CanSearch != null)
                    hashCode = hashCode * 59 + this.CanSearch.GetHashCode();
                if (this.PageSize != null)
                    hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
