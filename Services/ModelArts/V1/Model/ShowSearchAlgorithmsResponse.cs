using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowSearchAlgorithmsResponse : SdkResponse
    {

        /// <summary>
        /// 超参搜索算法的个数。
        /// </summary>
        [JsonProperty("search_algo_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? SearchAlgoCount { get; set; }

        /// <summary>
        /// 所有超参搜索算法的列表。
        /// </summary>
        [JsonProperty("search_algo_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListSearchAlgorithmsSearchAlgoList> SearchAlgoList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSearchAlgorithmsResponse {\n");
            sb.Append("  searchAlgoCount: ").Append(SearchAlgoCount).Append("\n");
            sb.Append("  searchAlgoList: ").Append(SearchAlgoList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSearchAlgorithmsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSearchAlgorithmsResponse input)
        {
            if (input == null) return false;
            if (this.SearchAlgoCount != input.SearchAlgoCount || (this.SearchAlgoCount != null && !this.SearchAlgoCount.Equals(input.SearchAlgoCount))) return false;
            if (this.SearchAlgoList != input.SearchAlgoList || (this.SearchAlgoList != null && input.SearchAlgoList != null && !this.SearchAlgoList.SequenceEqual(input.SearchAlgoList))) return false;

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
                if (this.SearchAlgoCount != null) hashCode = hashCode * 59 + this.SearchAlgoCount.GetHashCode();
                if (this.SearchAlgoList != null) hashCode = hashCode * 59 + this.SearchAlgoList.GetHashCode();
                return hashCode;
            }
        }
    }
}
