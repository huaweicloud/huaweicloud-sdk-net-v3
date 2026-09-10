using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class GetInstancesOpsResourceUsageResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cpu", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceUsage Cpu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mem", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceUsage Mem { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("disk", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceUsage Disk { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("io", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceUsage Io { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetInstancesOpsResourceUsageResponse {\n");
            sb.Append("  cpu: ").Append(Cpu).Append("\n");
            sb.Append("  mem: ").Append(Mem).Append("\n");
            sb.Append("  disk: ").Append(Disk).Append("\n");
            sb.Append("  io: ").Append(Io).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetInstancesOpsResourceUsageResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetInstancesOpsResourceUsageResponse input)
        {
            if (input == null) return false;
            if (this.Cpu != input.Cpu || (this.Cpu != null && !this.Cpu.Equals(input.Cpu))) return false;
            if (this.Mem != input.Mem || (this.Mem != null && !this.Mem.Equals(input.Mem))) return false;
            if (this.Disk != input.Disk || (this.Disk != null && !this.Disk.Equals(input.Disk))) return false;
            if (this.Io != input.Io || (this.Io != null && !this.Io.Equals(input.Io))) return false;

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
                if (this.Cpu != null) hashCode = hashCode * 59 + this.Cpu.GetHashCode();
                if (this.Mem != null) hashCode = hashCode * 59 + this.Mem.GetHashCode();
                if (this.Disk != null) hashCode = hashCode * 59 + this.Disk.GetHashCode();
                if (this.Io != null) hashCode = hashCode * 59 + this.Io.GetHashCode();
                return hashCode;
            }
        }
    }
}
