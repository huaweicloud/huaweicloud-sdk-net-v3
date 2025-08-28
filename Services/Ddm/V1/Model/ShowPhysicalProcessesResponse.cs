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
    public class ShowPhysicalProcessesResponse : SdkResponse
    {

        /// <summary>
        /// 物理会话信息列表
        /// </summary>
        [JsonProperty("physical_processes", NullValueHandling = NullValueHandling.Ignore)]
        public List<PhysicalProcessInfo> PhysicalProcesses { get; set; }

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
            sb.Append("class ShowPhysicalProcessesResponse {\n");
            sb.Append("  physicalProcesses: ").Append(PhysicalProcesses).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPhysicalProcessesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPhysicalProcessesResponse input)
        {
            if (input == null) return false;
            if (this.PhysicalProcesses != input.PhysicalProcesses || (this.PhysicalProcesses != null && input.PhysicalProcesses != null && !this.PhysicalProcesses.SequenceEqual(input.PhysicalProcesses))) return false;
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
                if (this.PhysicalProcesses != null) hashCode = hashCode * 59 + this.PhysicalProcesses.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
