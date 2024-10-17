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
    /// 
    /// </summary>
    public class DedicatedResourceCapacity 
    {

        /// <summary>
        /// 内存大小，单位GB
        /// </summary>
        [JsonProperty("ram", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ram { get; set; }

        /// <summary>
        /// 磁盘容量，单位GB
        /// </summary>
        [JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)]
        public long? Volume { get; set; }

        /// <summary>
        /// cpu核数
        /// </summary>
        [JsonProperty("vcpus", NullValueHandling = NullValueHandling.Ignore)]
        public int? Vcpus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DedicatedResourceCapacity {\n");
            sb.Append("  ram: ").Append(Ram).Append("\n");
            sb.Append("  volume: ").Append(Volume).Append("\n");
            sb.Append("  vcpus: ").Append(Vcpus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DedicatedResourceCapacity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DedicatedResourceCapacity input)
        {
            if (input == null) return false;
            if (this.Ram != input.Ram || (this.Ram != null && !this.Ram.Equals(input.Ram))) return false;
            if (this.Volume != input.Volume || (this.Volume != null && !this.Volume.Equals(input.Volume))) return false;
            if (this.Vcpus != input.Vcpus || (this.Vcpus != null && !this.Vcpus.Equals(input.Vcpus))) return false;

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
                if (this.Ram != null) hashCode = hashCode * 59 + this.Ram.GetHashCode();
                if (this.Volume != null) hashCode = hashCode * 59 + this.Volume.GetHashCode();
                if (this.Vcpus != null) hashCode = hashCode * 59 + this.Vcpus.GetHashCode();
                return hashCode;
            }
        }
    }
}
