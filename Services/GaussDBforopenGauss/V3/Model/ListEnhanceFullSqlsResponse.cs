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
    public class ListEnhanceFullSqlsResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: 总记录数量。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// **参数解释**: 全量SQL列表。
        /// </summary>
        [JsonProperty("full_sqls", NullValueHandling = NullValueHandling.Ignore)]
        public List<FullSqlResult> FullSqls { get; set; }

        /// <summary>
        /// **参数解释**: 最大查询记录数量。主要供前端交互控制使用。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("limit_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? LimitCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEnhanceFullSqlsResponse {\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  fullSqls: ").Append(FullSqls).Append("\n");
            sb.Append("  limitCount: ").Append(LimitCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEnhanceFullSqlsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEnhanceFullSqlsResponse input)
        {
            if (input == null) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.FullSqls != input.FullSqls || (this.FullSqls != null && input.FullSqls != null && !this.FullSqls.SequenceEqual(input.FullSqls))) return false;
            if (this.LimitCount != input.LimitCount || (this.LimitCount != null && !this.LimitCount.Equals(input.LimitCount))) return false;

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
                if (this.FullSqls != null) hashCode = hashCode * 59 + this.FullSqls.GetHashCode();
                if (this.LimitCount != null) hashCode = hashCode * 59 + this.LimitCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
