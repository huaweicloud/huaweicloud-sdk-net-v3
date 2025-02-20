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
    /// 
    /// </summary>
    public class QueryRepairDetailRespRepairDetails 
    {

        /// <summary>
        /// 源表标志列值。
        /// </summary>
        [JsonProperty("source_meta", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceMeta { get; set; }

        /// <summary>
        /// 目标表标志列值。
        /// </summary>
        [JsonProperty("target_meta", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetMeta { get; set; }

        /// <summary>
        /// 修复SQL状态。
        /// </summary>
        [JsonProperty("repair_sql_state", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepairSqlState { get; set; }

        /// <summary>
        /// 修复SQL。
        /// </summary>
        [JsonProperty("repair_sql_info", NullValueHandling = NullValueHandling.Ignore)]
        public string RepairSqlInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryRepairDetailRespRepairDetails {\n");
            sb.Append("  sourceMeta: ").Append(SourceMeta).Append("\n");
            sb.Append("  targetMeta: ").Append(TargetMeta).Append("\n");
            sb.Append("  repairSqlState: ").Append(RepairSqlState).Append("\n");
            sb.Append("  repairSqlInfo: ").Append(RepairSqlInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryRepairDetailRespRepairDetails);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryRepairDetailRespRepairDetails input)
        {
            if (input == null) return false;
            if (this.SourceMeta != input.SourceMeta || (this.SourceMeta != null && !this.SourceMeta.Equals(input.SourceMeta))) return false;
            if (this.TargetMeta != input.TargetMeta || (this.TargetMeta != null && !this.TargetMeta.Equals(input.TargetMeta))) return false;
            if (this.RepairSqlState != input.RepairSqlState || (this.RepairSqlState != null && !this.RepairSqlState.Equals(input.RepairSqlState))) return false;
            if (this.RepairSqlInfo != input.RepairSqlInfo || (this.RepairSqlInfo != null && !this.RepairSqlInfo.Equals(input.RepairSqlInfo))) return false;

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
                if (this.SourceMeta != null) hashCode = hashCode * 59 + this.SourceMeta.GetHashCode();
                if (this.TargetMeta != null) hashCode = hashCode * 59 + this.TargetMeta.GetHashCode();
                if (this.RepairSqlState != null) hashCode = hashCode * 59 + this.RepairSqlState.GetHashCode();
                if (this.RepairSqlInfo != null) hashCode = hashCode * 59 + this.RepairSqlInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
