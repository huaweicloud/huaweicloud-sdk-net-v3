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
    /// 渲染加速控制选项。
    /// </summary>
    public class PoliciesDisplayRenderingAccelerationOptions 
    {

        /// <summary>
        /// 视频加速增强配置。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("video_acceleration_enhancement_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? VideoAccelerationEnhancementEnable { get; set; }

        /// <summary>
        /// 是否开启视频场景优化。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("video_optimization_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? VideoOptimizationEnable { get; set; }

        /// <summary>
        /// 是否开启GPU色彩优化。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("gpu_color_optimization_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? GpuColorOptimizationEnable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesDisplayRenderingAccelerationOptions {\n");
            sb.Append("  videoAccelerationEnhancementEnable: ").Append(VideoAccelerationEnhancementEnable).Append("\n");
            sb.Append("  videoOptimizationEnable: ").Append(VideoOptimizationEnable).Append("\n");
            sb.Append("  gpuColorOptimizationEnable: ").Append(GpuColorOptimizationEnable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesDisplayRenderingAccelerationOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesDisplayRenderingAccelerationOptions input)
        {
            if (input == null) return false;
            if (this.VideoAccelerationEnhancementEnable != input.VideoAccelerationEnhancementEnable || (this.VideoAccelerationEnhancementEnable != null && !this.VideoAccelerationEnhancementEnable.Equals(input.VideoAccelerationEnhancementEnable))) return false;
            if (this.VideoOptimizationEnable != input.VideoOptimizationEnable || (this.VideoOptimizationEnable != null && !this.VideoOptimizationEnable.Equals(input.VideoOptimizationEnable))) return false;
            if (this.GpuColorOptimizationEnable != input.GpuColorOptimizationEnable || (this.GpuColorOptimizationEnable != null && !this.GpuColorOptimizationEnable.Equals(input.GpuColorOptimizationEnable))) return false;

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
                if (this.VideoAccelerationEnhancementEnable != null) hashCode = hashCode * 59 + this.VideoAccelerationEnhancementEnable.GetHashCode();
                if (this.VideoOptimizationEnable != null) hashCode = hashCode * 59 + this.VideoOptimizationEnable.GetHashCode();
                if (this.GpuColorOptimizationEnable != null) hashCode = hashCode * 59 + this.GpuColorOptimizationEnable.GetHashCode();
                return hashCode;
            }
        }
    }
}
