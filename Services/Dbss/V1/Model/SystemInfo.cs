using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SystemInfo 
    {

        /// <summary>
        /// CPU使用量
        /// </summary>
        [JsonProperty("cpu_use", NullValueHandling = NullValueHandling.Ignore)]
        public double? CpuUse { get; set; }

        /// <summary>
        /// 记录ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 内存使用量
        /// </summary>
        [JsonProperty("mem_use", NullValueHandling = NullValueHandling.Ignore)]
        public double? MemUse { get; set; }

        /// <summary>
        /// 记录时间
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemInfo {\n");
            sb.Append("  cpuUse: ").Append(CpuUse).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  memUse: ").Append(MemUse).Append("\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SystemInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SystemInfo input)
        {
            if (input == null) return false;
            if (this.CpuUse != input.CpuUse || (this.CpuUse != null && !this.CpuUse.Equals(input.CpuUse))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.MemUse != input.MemUse || (this.MemUse != null && !this.MemUse.Equals(input.MemUse))) return false;
            if (this.Time != input.Time || (this.Time != null && !this.Time.Equals(input.Time))) return false;

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
                if (this.CpuUse != null) hashCode = hashCode * 59 + this.CpuUse.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.MemUse != null) hashCode = hashCode * 59 + this.MemUse.GetHashCode();
                if (this.Time != null) hashCode = hashCode * 59 + this.Time.GetHashCode();
                return hashCode;
            }
        }
    }
}
