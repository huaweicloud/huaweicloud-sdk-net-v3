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
    /// 路由策略。
    /// </summary>
    public class RoutePolicyDetail 
    {

        /// <summary>
        /// 单台服务器最大的连接会话数。
        /// </summary>
        [JsonProperty("max_session", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxSession { get; set; }

        /// <summary>
        /// cpu使用率阈值，单位为%。
        /// </summary>
        [JsonProperty("cpu_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? CpuThreshold { get; set; }

        /// <summary>
        /// gpu显存使用率阈值，单位为%。
        /// </summary>
        [JsonProperty("gpu_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? GpuThreshold { get; set; }

        /// <summary>
        /// 内存使用率阈值，单位为%。
        /// </summary>
        [JsonProperty("mem_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? MemThreshold { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoutePolicyDetail {\n");
            sb.Append("  maxSession: ").Append(MaxSession).Append("\n");
            sb.Append("  cpuThreshold: ").Append(CpuThreshold).Append("\n");
            sb.Append("  gpuThreshold: ").Append(GpuThreshold).Append("\n");
            sb.Append("  memThreshold: ").Append(MemThreshold).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RoutePolicyDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RoutePolicyDetail input)
        {
            if (input == null) return false;
            if (this.MaxSession != input.MaxSession || (this.MaxSession != null && !this.MaxSession.Equals(input.MaxSession))) return false;
            if (this.CpuThreshold != input.CpuThreshold || (this.CpuThreshold != null && !this.CpuThreshold.Equals(input.CpuThreshold))) return false;
            if (this.GpuThreshold != input.GpuThreshold || (this.GpuThreshold != null && !this.GpuThreshold.Equals(input.GpuThreshold))) return false;
            if (this.MemThreshold != input.MemThreshold || (this.MemThreshold != null && !this.MemThreshold.Equals(input.MemThreshold))) return false;

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
                if (this.MaxSession != null) hashCode = hashCode * 59 + this.MaxSession.GetHashCode();
                if (this.CpuThreshold != null) hashCode = hashCode * 59 + this.CpuThreshold.GetHashCode();
                if (this.GpuThreshold != null) hashCode = hashCode * 59 + this.GpuThreshold.GetHashCode();
                if (this.MemThreshold != null) hashCode = hashCode * 59 + this.MemThreshold.GetHashCode();
                return hashCode;
            }
        }
    }
}
