using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 修复详情。
    /// </summary>
    public class QueryRepairDetailResp 
    {

        /// <summary>
        /// 总数。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 修复详情。
        /// </summary>
        [JsonProperty("repair_details", NullValueHandling = NullValueHandling.Ignore)]
        public List<QueryRepairDetailRespRepairDetails> RepairDetails { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryRepairDetailResp {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  repairDetails: ").Append(RepairDetails).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryRepairDetailResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryRepairDetailResp input)
        {
            if (input == null) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.RepairDetails != input.RepairDetails || (this.RepairDetails != null && input.RepairDetails != null && !this.RepairDetails.SequenceEqual(input.RepairDetails))) return false;

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
                if (this.RepairDetails != null) hashCode = hashCode * 59 + this.RepairDetails.GetHashCode();
                return hashCode;
            }
        }
    }
}
