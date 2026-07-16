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
    /// 资源规格详细信息。
    /// </summary>
    public class FlavorInfo 
    {

        /// <summary>
        /// 可以选择的最大节点数量（max_num，为1代表不支持分布式）。
        /// </summary>
        [JsonProperty("max_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cpu", NullValueHandling = NullValueHandling.Ignore)]
        public Cpu Cpu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("gpu", NullValueHandling = NullValueHandling.Ignore)]
        public Gpu Gpu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("npu", NullValueHandling = NullValueHandling.Ignore)]
        public Npu Npu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("memory", NullValueHandling = NullValueHandling.Ignore)]
        public Memory Memory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("disk", NullValueHandling = NullValueHandling.Ignore)]
        public Disk Disk { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlavorInfo {\n");
            sb.Append("  maxNum: ").Append(MaxNum).Append("\n");
            sb.Append("  cpu: ").Append(Cpu).Append("\n");
            sb.Append("  gpu: ").Append(Gpu).Append("\n");
            sb.Append("  npu: ").Append(Npu).Append("\n");
            sb.Append("  memory: ").Append(Memory).Append("\n");
            sb.Append("  disk: ").Append(Disk).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FlavorInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FlavorInfo input)
        {
            if (input == null) return false;
            if (this.MaxNum != input.MaxNum || (this.MaxNum != null && !this.MaxNum.Equals(input.MaxNum))) return false;
            if (this.Cpu != input.Cpu || (this.Cpu != null && !this.Cpu.Equals(input.Cpu))) return false;
            if (this.Gpu != input.Gpu || (this.Gpu != null && !this.Gpu.Equals(input.Gpu))) return false;
            if (this.Npu != input.Npu || (this.Npu != null && !this.Npu.Equals(input.Npu))) return false;
            if (this.Memory != input.Memory || (this.Memory != null && !this.Memory.Equals(input.Memory))) return false;
            if (this.Disk != input.Disk || (this.Disk != null && !this.Disk.Equals(input.Disk))) return false;

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
                if (this.MaxNum != null) hashCode = hashCode * 59 + this.MaxNum.GetHashCode();
                if (this.Cpu != null) hashCode = hashCode * 59 + this.Cpu.GetHashCode();
                if (this.Gpu != null) hashCode = hashCode * 59 + this.Gpu.GetHashCode();
                if (this.Npu != null) hashCode = hashCode * 59 + this.Npu.GetHashCode();
                if (this.Memory != null) hashCode = hashCode * 59 + this.Memory.GetHashCode();
                if (this.Disk != null) hashCode = hashCode * 59 + this.Disk.GetHashCode();
                return hashCode;
            }
        }
    }
}
