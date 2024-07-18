using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ASICAcceleratorInfo 
    {

        /// <summary>
        /// ASIC设备名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// ASIC设备数量。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// ASIC设备的内存，单位为MB。
        /// </summary>
        [JsonProperty("memory_mb", NullValueHandling = NullValueHandling.Ignore)]
        public int? MemoryMb { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ASICAcceleratorInfo {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  memoryMb: ").Append(MemoryMb).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ASICAcceleratorInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ASICAcceleratorInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.MemoryMb == input.MemoryMb ||
                    (this.MemoryMb != null &&
                    this.MemoryMb.Equals(input.MemoryMb))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.MemoryMb != null)
                    hashCode = hashCode * 59 + this.MemoryMb.GetHashCode();
                return hashCode;
            }
        }
    }
}
