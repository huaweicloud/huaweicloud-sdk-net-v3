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
    /// 自定义CPU选项。
    /// </summary>
    public class CpuOptions 
    {

        /// <summary>
        /// CPU超线程数， 决定CPU是否开启超线程
        /// </summary>
        [JsonProperty("hw:cpu_threads", NullValueHandling = NullValueHandling.Ignore)]
        public int? HwcpuThreads { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CpuOptions {\n");
            sb.Append("  hwcpuThreads: ").Append(HwcpuThreads).Append("\n");
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
            if (input == null)
                return false;

            return 
                (
                    this.HwcpuThreads == input.HwcpuThreads ||
                    (this.HwcpuThreads != null &&
                    this.HwcpuThreads.Equals(input.HwcpuThreads))
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
                if (this.HwcpuThreads != null)
                    hashCode = hashCode * 59 + this.HwcpuThreads.GetHashCode();
                return hashCode;
            }
        }
    }
}
