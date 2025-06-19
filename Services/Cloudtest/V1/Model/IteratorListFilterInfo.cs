using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 过滤条件
    /// </summary>
    public class IteratorListFilterInfo 
    {

        /// <summary>
        /// pi过滤条件
        /// </summary>
        [JsonProperty("pi_sprints", NullValueHandling = NullValueHandling.Ignore)]
        public List<IssueListPiFilterInfo> PiSprints { get; set; }

        /// <summary>
        /// 计划结束间过滤开始时间点
        /// </summary>
        [JsonProperty("plan_end_date_start", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? PlanEndDateStart { get; set; }

        /// <summary>
        /// 计划结束时间过滤结束时间点
        /// </summary>
        [JsonProperty("plan_end_date_end", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? PlanEndDateEnd { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IteratorListFilterInfo {\n");
            sb.Append("  piSprints: ").Append(PiSprints).Append("\n");
            sb.Append("  planEndDateStart: ").Append(PlanEndDateStart).Append("\n");
            sb.Append("  planEndDateEnd: ").Append(PlanEndDateEnd).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IteratorListFilterInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IteratorListFilterInfo input)
        {
            if (input == null) return false;
            if (this.PiSprints != input.PiSprints || (this.PiSprints != null && input.PiSprints != null && !this.PiSprints.SequenceEqual(input.PiSprints))) return false;
            if (this.PlanEndDateStart != input.PlanEndDateStart || (this.PlanEndDateStart != null && !this.PlanEndDateStart.Equals(input.PlanEndDateStart))) return false;
            if (this.PlanEndDateEnd != input.PlanEndDateEnd || (this.PlanEndDateEnd != null && !this.PlanEndDateEnd.Equals(input.PlanEndDateEnd))) return false;

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
                if (this.PiSprints != null) hashCode = hashCode * 59 + this.PiSprints.GetHashCode();
                if (this.PlanEndDateStart != null) hashCode = hashCode * 59 + this.PlanEndDateStart.GetHashCode();
                if (this.PlanEndDateEnd != null) hashCode = hashCode * 59 + this.PlanEndDateEnd.GetHashCode();
                return hashCode;
            }
        }
    }
}
