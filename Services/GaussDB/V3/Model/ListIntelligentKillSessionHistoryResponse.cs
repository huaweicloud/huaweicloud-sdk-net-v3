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
    public class ListIntelligentKillSessionHistoryResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  智能Kill会话历史记录列表。
        /// </summary>
        [JsonProperty("intelligent_kill_session_histories", NullValueHandling = NullValueHandling.Ignore)]
        public List<IntelligentKillSessionHistory> IntelligentKillSessionHistories { get; set; }

        /// <summary>
        /// **参数解释**：  数据总数。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListIntelligentKillSessionHistoryResponse {\n");
            sb.Append("  intelligentKillSessionHistories: ").Append(IntelligentKillSessionHistories).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListIntelligentKillSessionHistoryResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListIntelligentKillSessionHistoryResponse input)
        {
            if (input == null) return false;
            if (this.IntelligentKillSessionHistories != input.IntelligentKillSessionHistories || (this.IntelligentKillSessionHistories != null && input.IntelligentKillSessionHistories != null && !this.IntelligentKillSessionHistories.SequenceEqual(input.IntelligentKillSessionHistories))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;

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
                if (this.IntelligentKillSessionHistories != null) hashCode = hashCode * 59 + this.IntelligentKillSessionHistories.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
