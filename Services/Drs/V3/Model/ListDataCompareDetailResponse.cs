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
    public class ListDataCompareDetailResponse : SdkResponse
    {

        /// <summary>
        /// 对比数量
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 对比信息列表
        /// </summary>
        [JsonProperty("table_line_compare_result_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<TableLineCompareResultInfo> TableLineCompareResultInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDataCompareDetailResponse {\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  tableLineCompareResultInfos: ").Append(TableLineCompareResultInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDataCompareDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDataCompareDetailResponse input)
        {
            if (input == null) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.TableLineCompareResultInfos != input.TableLineCompareResultInfos || (this.TableLineCompareResultInfos != null && input.TableLineCompareResultInfos != null && !this.TableLineCompareResultInfos.SequenceEqual(input.TableLineCompareResultInfos))) return false;

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
                if (this.TableLineCompareResultInfos != null) hashCode = hashCode * 59 + this.TableLineCompareResultInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
