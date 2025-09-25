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
    /// 
    /// </summary>
    public class ExecutionTimeDetailsInfo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resource_time", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceTime ResourceTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("kernel_time", NullValueHandling = NullValueHandling.Ignore)]
        public KernelTime KernelTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("kernel_execution_time", NullValueHandling = NullValueHandling.Ignore)]
        public KernelExecutionTime KernelExecutionTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("wait_event_time", NullValueHandling = NullValueHandling.Ignore)]
        public WaitEventTime WaitEventTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecutionTimeDetailsInfo {\n");
            sb.Append("  resourceTime: ").Append(ResourceTime).Append("\n");
            sb.Append("  kernelTime: ").Append(KernelTime).Append("\n");
            sb.Append("  kernelExecutionTime: ").Append(KernelExecutionTime).Append("\n");
            sb.Append("  waitEventTime: ").Append(WaitEventTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExecutionTimeDetailsInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExecutionTimeDetailsInfo input)
        {
            if (input == null) return false;
            if (this.ResourceTime != input.ResourceTime || (this.ResourceTime != null && !this.ResourceTime.Equals(input.ResourceTime))) return false;
            if (this.KernelTime != input.KernelTime || (this.KernelTime != null && !this.KernelTime.Equals(input.KernelTime))) return false;
            if (this.KernelExecutionTime != input.KernelExecutionTime || (this.KernelExecutionTime != null && !this.KernelExecutionTime.Equals(input.KernelExecutionTime))) return false;
            if (this.WaitEventTime != input.WaitEventTime || (this.WaitEventTime != null && !this.WaitEventTime.Equals(input.WaitEventTime))) return false;

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
                if (this.ResourceTime != null) hashCode = hashCode * 59 + this.ResourceTime.GetHashCode();
                if (this.KernelTime != null) hashCode = hashCode * 59 + this.KernelTime.GetHashCode();
                if (this.KernelExecutionTime != null) hashCode = hashCode * 59 + this.KernelExecutionTime.GetHashCode();
                if (this.WaitEventTime != null) hashCode = hashCode * 59 + this.WaitEventTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
