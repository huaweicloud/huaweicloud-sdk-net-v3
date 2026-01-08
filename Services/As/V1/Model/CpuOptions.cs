using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CpuOptions 
    {

        /// <summary>
        /// 是否关闭实例超线程，1是关闭，2是开启
        /// </summary>
        [JsonProperty("hw_cpu_threads", NullValueHandling = NullValueHandling.Ignore)]
        public int? HwCpuThreads { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CpuOptions {\n");
            sb.Append("  hwCpuThreads: ").Append(HwCpuThreads).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CpuOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CpuOptions input)
        {
            if (input == null) return false;
            if (this.HwCpuThreads != input.HwCpuThreads || (this.HwCpuThreads != null && !this.HwCpuThreads.Equals(input.HwCpuThreads))) return false;

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
                if (this.HwCpuThreads != null) hashCode = hashCode * 59 + this.HwCpuThreads.GetHashCode();
                return hashCode;
            }
        }
    }
}
