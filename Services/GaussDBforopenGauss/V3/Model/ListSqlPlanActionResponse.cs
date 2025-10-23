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
    public class ListSqlPlanActionResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: sql执行计划总数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// **参数解释**: 执行计划列表。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("sql_plan_bind_state_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<SqlPlanStateListResponseSqlPlanBindStateList> SqlPlanBindStateList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSqlPlanActionResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  sqlPlanBindStateList: ").Append(SqlPlanBindStateList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSqlPlanActionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSqlPlanActionResponse input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.SqlPlanBindStateList != input.SqlPlanBindStateList || (this.SqlPlanBindStateList != null && input.SqlPlanBindStateList != null && !this.SqlPlanBindStateList.SequenceEqual(input.SqlPlanBindStateList))) return false;

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
                if (this.SqlPlanBindStateList != null) hashCode = hashCode * 59 + this.SqlPlanBindStateList.GetHashCode();
                return hashCode;
            }
        }
    }
}
