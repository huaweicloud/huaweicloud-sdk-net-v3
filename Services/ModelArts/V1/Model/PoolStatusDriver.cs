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
    /// **参数解释**：资源池驱动状态信息。
    /// </summary>
    public class PoolStatusDriver 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("gpu", NullValueHandling = NullValueHandling.Ignore)]
        public PoolDriverStatus Gpu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("npu", NullValueHandling = NullValueHandling.Ignore)]
        public PoolDriverStatus Npu { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoolStatusDriver {\n");
            sb.Append("  gpu: ").Append(Gpu).Append("\n");
            sb.Append("  npu: ").Append(Npu).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoolStatusDriver);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoolStatusDriver input)
        {
            if (input == null) return false;
            if (this.Gpu != input.Gpu || (this.Gpu != null && !this.Gpu.Equals(input.Gpu))) return false;
            if (this.Npu != input.Npu || (this.Npu != null && !this.Npu.Equals(input.Npu))) return false;

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
                if (this.Gpu != null) hashCode = hashCode * 59 + this.Gpu.GetHashCode();
                if (this.Npu != null) hashCode = hashCode * 59 + this.Npu.GetHashCode();
                return hashCode;
            }
        }
    }
}
