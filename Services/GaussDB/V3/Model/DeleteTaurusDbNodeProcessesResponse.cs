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
    public class DeleteTaurusDbNodeProcessesResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  已终止的用户会话线程ID列表。
        /// </summary>
        [JsonProperty("processes_killed", NullValueHandling = NullValueHandling.Ignore)]
        public List<long?> ProcessesKilled { get; set; }

        /// <summary>
        /// **参数解释**：  不存在的用户会话线程ID列表。
        /// </summary>
        [JsonProperty("processes_not_found", NullValueHandling = NullValueHandling.Ignore)]
        public List<long?> ProcessesNotFound { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteTaurusDbNodeProcessesResponse {\n");
            sb.Append("  processesKilled: ").Append(ProcessesKilled).Append("\n");
            sb.Append("  processesNotFound: ").Append(ProcessesNotFound).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteTaurusDbNodeProcessesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteTaurusDbNodeProcessesResponse input)
        {
            if (input == null) return false;
            if (this.ProcessesKilled != input.ProcessesKilled || (this.ProcessesKilled != null && input.ProcessesKilled != null && !this.ProcessesKilled.SequenceEqual(input.ProcessesKilled))) return false;
            if (this.ProcessesNotFound != input.ProcessesNotFound || (this.ProcessesNotFound != null && input.ProcessesNotFound != null && !this.ProcessesNotFound.SequenceEqual(input.ProcessesNotFound))) return false;

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
                if (this.ProcessesKilled != null) hashCode = hashCode * 59 + this.ProcessesKilled.GetHashCode();
                if (this.ProcessesNotFound != null) hashCode = hashCode * 59 + this.ProcessesNotFound.GetHashCode();
                return hashCode;
            }
        }
    }
}
