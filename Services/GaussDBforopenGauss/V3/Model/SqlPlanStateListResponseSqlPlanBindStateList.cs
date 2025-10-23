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
    /// 
    /// </summary>
    public class SqlPlanStateListResponseSqlPlanBindStateList 
    {

        /// <summary>
        /// **参数解释**: 当前计划的概览。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("outline", NullValueHandling = NullValueHandling.Ignore)]
        public string Outline { get; set; }

        /// <summary>
        /// **参数解释**: SQL执行计划的开销。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("cost", NullValueHandling = NullValueHandling.Ignore)]
        public string Cost { get; set; }

        /// <summary>
        /// **参数解释**: 绑定状态。 **取值范围**: - bind：绑定。 - drop：解绑。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**: SQL文本的哈希值。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("sql_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlHash { get; set; }

        /// <summary>
        /// **参数解释**: SQL执行计划ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("plan_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SqlPlanStateListResponseSqlPlanBindStateList {\n");
            sb.Append("  outline: ").Append(Outline).Append("\n");
            sb.Append("  cost: ").Append(Cost).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  sqlHash: ").Append(SqlHash).Append("\n");
            sb.Append("  planId: ").Append(PlanId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SqlPlanStateListResponseSqlPlanBindStateList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SqlPlanStateListResponseSqlPlanBindStateList input)
        {
            if (input == null) return false;
            if (this.Outline != input.Outline || (this.Outline != null && !this.Outline.Equals(input.Outline))) return false;
            if (this.Cost != input.Cost || (this.Cost != null && !this.Cost.Equals(input.Cost))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.SqlHash != input.SqlHash || (this.SqlHash != null && !this.SqlHash.Equals(input.SqlHash))) return false;
            if (this.PlanId != input.PlanId || (this.PlanId != null && !this.PlanId.Equals(input.PlanId))) return false;

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
                if (this.Outline != null) hashCode = hashCode * 59 + this.Outline.GetHashCode();
                if (this.Cost != null) hashCode = hashCode * 59 + this.Cost.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SqlHash != null) hashCode = hashCode * 59 + this.SqlHash.GetHashCode();
                if (this.PlanId != null) hashCode = hashCode * 59 + this.PlanId.GetHashCode();
                return hashCode;
            }
        }
    }
}
