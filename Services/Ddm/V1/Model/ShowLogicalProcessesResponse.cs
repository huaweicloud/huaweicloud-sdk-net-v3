using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowLogicalProcessesResponse : SdkResponse
    {

        /// <summary>
        /// 逻辑会话列表
        /// </summary>
        [JsonProperty("logical_processes", NullValueHandling = NullValueHandling.Ignore)]
        public List<LogicalProcessInfo> LogicalProcesses { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowLogicalProcessesResponse {\n");
            sb.Append("  logicalProcesses: ").Append(LogicalProcesses).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowLogicalProcessesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowLogicalProcessesResponse input)
        {
            if (input == null) return false;
            if (this.LogicalProcesses != input.LogicalProcesses || (this.LogicalProcesses != null && input.LogicalProcesses != null && !this.LogicalProcesses.SequenceEqual(input.LogicalProcesses))) return false;
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
                if (this.LogicalProcesses != null) hashCode = hashCode * 59 + this.LogicalProcesses.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
