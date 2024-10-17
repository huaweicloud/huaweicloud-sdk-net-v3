using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListContentCompareDetailResponse : SdkResponse
    {

        /// <summary>
        /// 对比数量
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 对比信息列表
        /// </summary>
        [JsonProperty("content_compare_result_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<NodeContentCompareDetailResult> ContentCompareResultInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListContentCompareDetailResponse {\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  contentCompareResultInfos: ").Append(ContentCompareResultInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListContentCompareDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListContentCompareDetailResponse input)
        {
            if (input == null) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.ContentCompareResultInfos != input.ContentCompareResultInfos || (this.ContentCompareResultInfos != null && input.ContentCompareResultInfos != null && !this.ContentCompareResultInfos.SequenceEqual(input.ContentCompareResultInfos))) return false;

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
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.ContentCompareResultInfos != null) hashCode = hashCode * 59 + this.ContentCompareResultInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
