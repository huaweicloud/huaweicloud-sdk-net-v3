using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListTopSqlsResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: Top SQL总条数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// **参数解释**: Top SQL信息列表。
        /// </summary>
        [JsonProperty("top_sql_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopSQLInfoResult> TopSqlInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTopSqlsResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  topSqlInfos: ").Append(TopSqlInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTopSqlsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTopSqlsResponse input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.TopSqlInfos != input.TopSqlInfos || (this.TopSqlInfos != null && input.TopSqlInfos != null && !this.TopSqlInfos.SequenceEqual(input.TopSqlInfos))) return false;

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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.TopSqlInfos != null) hashCode = hashCode * 59 + this.TopSqlInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
