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
    public class ListFullSqlSwitchesResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: 总记录数量。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// **参数解释**: 开关记录列表。
        /// </summary>
        [JsonProperty("full_sql_switches", NullValueHandling = NullValueHandling.Ignore)]
        public List<FullSqlSwitchResult> FullSqlSwitches { get; set; }

        /// <summary>
        /// **参数解释**: 可选择的SQL采集类别清单列表。供开启全量SQL时做配置下发参考。
        /// </summary>
        [JsonProperty("allowed_sql_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<SqlTypeRangeConfigResult> AllowedSqlTypes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFullSqlSwitchesResponse {\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  fullSqlSwitches: ").Append(FullSqlSwitches).Append("\n");
            sb.Append("  allowedSqlTypes: ").Append(AllowedSqlTypes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListFullSqlSwitchesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFullSqlSwitchesResponse input)
        {
            if (input == null) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.FullSqlSwitches != input.FullSqlSwitches || (this.FullSqlSwitches != null && input.FullSqlSwitches != null && !this.FullSqlSwitches.SequenceEqual(input.FullSqlSwitches))) return false;
            if (this.AllowedSqlTypes != input.AllowedSqlTypes || (this.AllowedSqlTypes != null && input.AllowedSqlTypes != null && !this.AllowedSqlTypes.SequenceEqual(input.AllowedSqlTypes))) return false;

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
                if (this.FullSqlSwitches != null) hashCode = hashCode * 59 + this.FullSqlSwitches.GetHashCode();
                if (this.AllowedSqlTypes != null) hashCode = hashCode * 59 + this.AllowedSqlTypes.GetHashCode();
                return hashCode;
            }
        }
    }
}
