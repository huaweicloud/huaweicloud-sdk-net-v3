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
    public class ListTaurusDbNodeProcessesResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  用户会话线程信息列表。
        /// </summary>
        [JsonProperty("processes", NullValueHandling = NullValueHandling.Ignore)]
        public List<TaurusDbProcessInfo> Processes { get; set; }

        /// <summary>
        /// **参数解释**：  节点中的用户会话线程总数。  **取值范围**：  ≥0 
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTaurusDbNodeProcessesResponse {\n");
            sb.Append("  processes: ").Append(Processes).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTaurusDbNodeProcessesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTaurusDbNodeProcessesResponse input)
        {
            if (input == null) return false;
            if (this.Processes != input.Processes || (this.Processes != null && input.Processes != null && !this.Processes.SequenceEqual(input.Processes))) return false;
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
                if (this.Processes != null) hashCode = hashCode * 59 + this.Processes.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
