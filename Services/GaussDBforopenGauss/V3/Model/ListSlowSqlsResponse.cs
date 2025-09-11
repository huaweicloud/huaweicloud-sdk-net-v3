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
    public class ListSlowSqlsResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: 总数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// **参数解释**: 慢SQL列表。
        /// </summary>
        [JsonProperty("slow_sql_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<SlowSQLInfoResult> SlowSqlInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSlowSqlsResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  slowSqlInfos: ").Append(SlowSqlInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSlowSqlsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSlowSqlsResponse input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.SlowSqlInfos != input.SlowSqlInfos || (this.SlowSqlInfos != null && input.SlowSqlInfos != null && !this.SlowSqlInfos.SequenceEqual(input.SlowSqlInfos))) return false;

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
                if (this.SlowSqlInfos != null) hashCode = hashCode * 59 + this.SlowSqlInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
