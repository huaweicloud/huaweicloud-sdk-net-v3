using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 内核耗时详细信息
    /// </summary>
    public class KernelExecTimeDetails 
    {

        /// <summary>
        /// **参数解释**: 执行器内执行时间（单位：微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("execution_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExecutionTime { get; set; }

        /// <summary>
        /// **参数解释**: 执行器内执行时间（单位：微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("other_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? OtherTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KernelExecTimeDetails {\n");
            sb.Append("  executionTime: ").Append(ExecutionTime).Append("\n");
            sb.Append("  otherTime: ").Append(OtherTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KernelExecTimeDetails);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KernelExecTimeDetails input)
        {
            if (input == null) return false;
            if (this.ExecutionTime != input.ExecutionTime || (this.ExecutionTime != null && !this.ExecutionTime.Equals(input.ExecutionTime))) return false;
            if (this.OtherTime != input.OtherTime || (this.OtherTime != null && !this.OtherTime.Equals(input.OtherTime))) return false;

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
                if (this.ExecutionTime != null) hashCode = hashCode * 59 + this.ExecutionTime.GetHashCode();
                if (this.OtherTime != null) hashCode = hashCode * 59 + this.OtherTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
