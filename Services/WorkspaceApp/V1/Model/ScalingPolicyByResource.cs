using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 基于资源的弹性策略。
    /// </summary>
    public class ScalingPolicyByResource 
    {

        /// <summary>
        /// 分组的总cpu使用率(达到阈值后扩容)。
        /// </summary>
        [JsonProperty("cpu_usage_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? CpuUsageThreshold { get; set; }

        /// <summary>
        /// 分组的总mem使用率(达到改阈值后扩容)。
        /// </summary>
        [JsonProperty("mem_usage_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? MemUsageThreshold { get; set; }

        /// <summary>
        /// 分组的总显存使用率(达到改阈值后扩容)。
        /// </summary>
        [JsonProperty("gpu_usage_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? GpuUsageThreshold { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScalingPolicyByResource {\n");
            sb.Append("  cpuUsageThreshold: ").Append(CpuUsageThreshold).Append("\n");
            sb.Append("  memUsageThreshold: ").Append(MemUsageThreshold).Append("\n");
            sb.Append("  gpuUsageThreshold: ").Append(GpuUsageThreshold).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScalingPolicyByResource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScalingPolicyByResource input)
        {
            if (input == null) return false;
            if (this.CpuUsageThreshold != input.CpuUsageThreshold || (this.CpuUsageThreshold != null && !this.CpuUsageThreshold.Equals(input.CpuUsageThreshold))) return false;
            if (this.MemUsageThreshold != input.MemUsageThreshold || (this.MemUsageThreshold != null && !this.MemUsageThreshold.Equals(input.MemUsageThreshold))) return false;
            if (this.GpuUsageThreshold != input.GpuUsageThreshold || (this.GpuUsageThreshold != null && !this.GpuUsageThreshold.Equals(input.GpuUsageThreshold))) return false;

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
                if (this.CpuUsageThreshold != null) hashCode = hashCode * 59 + this.CpuUsageThreshold.GetHashCode();
                if (this.MemUsageThreshold != null) hashCode = hashCode * 59 + this.MemUsageThreshold.GetHashCode();
                if (this.GpuUsageThreshold != null) hashCode = hashCode * 59 + this.GpuUsageThreshold.GetHashCode();
                return hashCode;
            }
        }
    }
}
