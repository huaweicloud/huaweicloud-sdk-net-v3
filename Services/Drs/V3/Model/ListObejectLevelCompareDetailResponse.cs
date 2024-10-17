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
    public class ListObejectLevelCompareDetailResponse : SdkResponse
    {

        /// <summary>
        /// 对比数量。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 对象级对比详情。
        /// </summary>
        [JsonProperty("compare_detail", NullValueHandling = NullValueHandling.Ignore)]
        public List<ObjectsCompareDetailInfo> CompareDetail { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListObejectLevelCompareDetailResponse {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  compareDetail: ").Append(CompareDetail).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListObejectLevelCompareDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListObejectLevelCompareDetailResponse input)
        {
            if (input == null) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.CompareDetail != input.CompareDetail || (this.CompareDetail != null && input.CompareDetail != null && !this.CompareDetail.SequenceEqual(input.CompareDetail))) return false;

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
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.CompareDetail != null) hashCode = hashCode * 59 + this.CompareDetail.GetHashCode();
                return hashCode;
            }
        }
    }
}
