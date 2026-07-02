using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListDdlLogsResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  DDL下载日志列表。  **取值范围**：  不涉及。 
        /// </summary>
        [JsonProperty("ddl_logs", NullValueHandling = NullValueHandling.Ignore)]
        public List<DdlLogInfo> DdlLogs { get; set; }

        /// <summary>
        /// **参数解释**：  总条数。  **取值范围**：  不涉及。 
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// **参数解释**：  日志保留天数。  **取值范围**：  不涉及。 
        /// </summary>
        [JsonProperty("keey_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? KeeyDays { get; set; }

        /// <summary>
        /// **参数解释**：  DDL日志下载开关状态。  **取值范围**：  - ON，开启。 - OFF，关闭。 
        /// </summary>
        [JsonProperty("switch_status", NullValueHandling = NullValueHandling.Ignore)]
        public string SwitchStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDdlLogsResponse {\n");
            sb.Append("  ddlLogs: ").Append(DdlLogs).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  keeyDays: ").Append(KeeyDays).Append("\n");
            sb.Append("  switchStatus: ").Append(SwitchStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDdlLogsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDdlLogsResponse input)
        {
            if (input == null) return false;
            if (this.DdlLogs != input.DdlLogs || (this.DdlLogs != null && input.DdlLogs != null && !this.DdlLogs.SequenceEqual(input.DdlLogs))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.KeeyDays != input.KeeyDays || (this.KeeyDays != null && !this.KeeyDays.Equals(input.KeeyDays))) return false;
            if (this.SwitchStatus != input.SwitchStatus || (this.SwitchStatus != null && !this.SwitchStatus.Equals(input.SwitchStatus))) return false;

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
                if (this.DdlLogs != null) hashCode = hashCode * 59 + this.DdlLogs.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.KeeyDays != null) hashCode = hashCode * 59 + this.KeeyDays.GetHashCode();
                if (this.SwitchStatus != null) hashCode = hashCode * 59 + this.SwitchStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
