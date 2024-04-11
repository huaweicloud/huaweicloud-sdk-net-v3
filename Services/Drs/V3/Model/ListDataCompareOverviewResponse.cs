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
    public class ListDataCompareOverviewResponse : SdkResponse
    {

        /// <summary>
        /// 对比信息数量
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 信息列表
        /// </summary>
        [JsonProperty("data_compare_overview_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataCompareOverviewInfo> DataCompareOverviewInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDataCompareOverviewResponse {\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  dataCompareOverviewInfos: ").Append(DataCompareOverviewInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDataCompareOverviewResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDataCompareOverviewResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
                ) && 
                (
                    this.DataCompareOverviewInfos == input.DataCompareOverviewInfos ||
                    this.DataCompareOverviewInfos != null &&
                    input.DataCompareOverviewInfos != null &&
                    this.DataCompareOverviewInfos.SequenceEqual(input.DataCompareOverviewInfos)
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
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.DataCompareOverviewInfos != null)
                    hashCode = hashCode * 59 + this.DataCompareOverviewInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
