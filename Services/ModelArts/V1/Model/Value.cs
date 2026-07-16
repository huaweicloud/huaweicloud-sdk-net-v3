using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 资源量。
    /// </summary>
    public class Value 
    {

        /// <summary>
        /// cpu量，即计算资源量。
        /// </summary>
        [JsonProperty("cpu", NullValueHandling = NullValueHandling.Ignore)]
        public string Cpu { get; set; }

        /// <summary>
        /// 内存。
        /// </summary>
        [JsonProperty("memory", NullValueHandling = NullValueHandling.Ignore)]
        public string Memory { get; set; }

        /// <summary>
        /// GPU卡的数量。
        /// </summary>
        [JsonProperty("tnt004", NullValueHandling = NullValueHandling.Ignore)]
        public string Tnt004 { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Value {\n");
            sb.Append("  cpu: ").Append(Cpu).Append("\n");
            sb.Append("  memory: ").Append(Memory).Append("\n");
            sb.Append("  tnt004: ").Append(Tnt004).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Value);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Value input)
        {
            if (input == null) return false;
            if (this.Cpu != input.Cpu || (this.Cpu != null && !this.Cpu.Equals(input.Cpu))) return false;
            if (this.Memory != input.Memory || (this.Memory != null && !this.Memory.Equals(input.Memory))) return false;
            if (this.Tnt004 != input.Tnt004 || (this.Tnt004 != null && !this.Tnt004.Equals(input.Tnt004))) return false;

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
                if (this.Memory != null) hashCode = hashCode * 59 + this.Memory.GetHashCode();
                if (this.Tnt004 != null) hashCode = hashCode * 59 + this.Tnt004.GetHashCode();
                return hashCode;
            }
        }
    }
}
