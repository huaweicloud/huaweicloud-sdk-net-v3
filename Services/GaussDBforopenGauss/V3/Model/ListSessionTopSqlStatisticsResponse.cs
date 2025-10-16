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
    public class ListSessionTopSqlStatisticsResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: 统计总条数。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// **参数解释**: 统计数据。 
        /// </summary>
        [JsonProperty("top_sql_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<SessionTopSqlStatisticInfo> TopSqlInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSessionTopSqlStatisticsResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  topSqlInfo: ").Append(TopSqlInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSessionTopSqlStatisticsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSessionTopSqlStatisticsResponse input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.TopSqlInfo != input.TopSqlInfo || (this.TopSqlInfo != null && input.TopSqlInfo != null && !this.TopSqlInfo.SequenceEqual(input.TopSqlInfo))) return false;

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
                if (this.TopSqlInfo != null) hashCode = hashCode * 59 + this.TopSqlInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
