using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// CPU阈值查询结果结构体
    /// </summary>
    public class CPUThresholdData 
    {

        /// <summary>
        /// 自定义的cpu阈值，单位为百分比(%)
        /// </summary>
        [JsonProperty("cpu", NullValueHandling = NullValueHandling.Ignore)]
        public int? Cpu { get; set; }

        /// <summary>
        /// cpu阈值默认值，单位为百分比(%)
        /// </summary>
        [JsonProperty("cpuDefault", NullValueHandling = NullValueHandling.Ignore)]
        public int? CpuDefault { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CPUThresholdData {\n");
            sb.Append("  cpu: ").Append(Cpu).Append("\n");
            sb.Append("  cpuDefault: ").Append(CpuDefault).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CPUThresholdData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CPUThresholdData input)
        {
            if (input == null) return false;
            if (this.Cpu != input.Cpu || (this.Cpu != null && !this.Cpu.Equals(input.Cpu))) return false;
            if (this.CpuDefault != input.CpuDefault || (this.CpuDefault != null && !this.CpuDefault.Equals(input.CpuDefault))) return false;

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
                if (this.CpuDefault != null) hashCode = hashCode * 59 + this.CpuDefault.GetHashCode();
                return hashCode;
            }
        }
    }
}
