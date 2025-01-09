using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
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
        /// 视频识别阈值。取值范围为[0-500]。默认：10。
        /// </summary>
        [JsonProperty("video_recognition_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? VideoRecognitionThreshold { get; set; }

        /// <summary>
        /// 帧率统计长度。取值范围为[2-100]。默认：4。
        /// </summary>
        [JsonProperty("frame_rate_statistical_length", NullValueHandling = NullValueHandling.Ignore)]
        public int? FrameRateStatisticalLength { get; set; }

        /// <summary>
        /// 图像质量阈值。取值范围为[0-100]。默认：0。
        /// </summary>
        [JsonProperty("image_quality_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? ImageQualityThreshold { get; set; }

        /// <summary>
        /// 刷新率阈值。取值范围为[1-100]。默认：3。
        /// </summary>
        [JsonProperty("refresh_frequency_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? RefreshFrequencyThreshold { get; set; }

        /// <summary>
        /// 退出视频区域阈值。取值范围为[0-100]。默认：8。
        /// </summary>
        [JsonProperty("exiting_video_area_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExitingVideoAreaThreshold { get; set; }

        /// <summary>
        /// 识别为视频的最小宽。取值范围为[0-1280]。默认：191。
        /// </summary>
        [JsonProperty("min_video_width", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinVideoWidth { get; set; }

        /// <summary>
        /// 识别为视频的最小高。取值范围为[0-1280]。默认：191。
        /// </summary>
        [JsonProperty("min_video_length", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinVideoLength { get; set; }

        /// <summary>
        /// 单帧自然图像块占比阈值。取值范围为[0.000001-1]。默认：0.3。
        /// </summary>
        [JsonProperty("single_frame_natural_percentage", NullValueHandling = NullValueHandling.Ignore)]
        public string SingleFrameNaturalPercentage { get; set; }

        /// <summary>
        /// 周期自然图像数目占比阈值。取值范围为[0-100]。默认：2。
        /// </summary>
        [JsonProperty("cyclical_natural_images_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? CyclicalNaturalImagesNumber { get; set; }

        /// <summary>
        /// 非自然图面积占比阈值。取值范围为[0.000001-1]。默认：0.85。
        /// </summary>
        [JsonProperty("non_natural_image_percentage", NullValueHandling = NullValueHandling.Ignore)]
        public string NonNaturalImagePercentage { get; set; }

        /// <summary>
        /// 非自然图数目占比阈值。取值范围为[0-100]。默认：25。
        /// </summary>
        [JsonProperty("non_natural_images_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? NonNaturalImagesNumber { get; set; }



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
            sb.Append("  videoRecognitionThreshold: ").Append(VideoRecognitionThreshold).Append("\n");
            sb.Append("  frameRateStatisticalLength: ").Append(FrameRateStatisticalLength).Append("\n");
            sb.Append("  imageQualityThreshold: ").Append(ImageQualityThreshold).Append("\n");
            sb.Append("  refreshFrequencyThreshold: ").Append(RefreshFrequencyThreshold).Append("\n");
            sb.Append("  exitingVideoAreaThreshold: ").Append(ExitingVideoAreaThreshold).Append("\n");
            sb.Append("  minVideoWidth: ").Append(MinVideoWidth).Append("\n");
            sb.Append("  minVideoLength: ").Append(MinVideoLength).Append("\n");
            sb.Append("  singleFrameNaturalPercentage: ").Append(SingleFrameNaturalPercentage).Append("\n");
            sb.Append("  cyclicalNaturalImagesNumber: ").Append(CyclicalNaturalImagesNumber).Append("\n");
            sb.Append("  nonNaturalImagePercentage: ").Append(NonNaturalImagePercentage).Append("\n");
            sb.Append("  nonNaturalImagesNumber: ").Append(NonNaturalImagesNumber).Append("\n");
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
            if (this.VideoRecognitionThreshold != input.VideoRecognitionThreshold || (this.VideoRecognitionThreshold != null && !this.VideoRecognitionThreshold.Equals(input.VideoRecognitionThreshold))) return false;
            if (this.FrameRateStatisticalLength != input.FrameRateStatisticalLength || (this.FrameRateStatisticalLength != null && !this.FrameRateStatisticalLength.Equals(input.FrameRateStatisticalLength))) return false;
            if (this.ImageQualityThreshold != input.ImageQualityThreshold || (this.ImageQualityThreshold != null && !this.ImageQualityThreshold.Equals(input.ImageQualityThreshold))) return false;
            if (this.RefreshFrequencyThreshold != input.RefreshFrequencyThreshold || (this.RefreshFrequencyThreshold != null && !this.RefreshFrequencyThreshold.Equals(input.RefreshFrequencyThreshold))) return false;
            if (this.ExitingVideoAreaThreshold != input.ExitingVideoAreaThreshold || (this.ExitingVideoAreaThreshold != null && !this.ExitingVideoAreaThreshold.Equals(input.ExitingVideoAreaThreshold))) return false;
            if (this.MinVideoWidth != input.MinVideoWidth || (this.MinVideoWidth != null && !this.MinVideoWidth.Equals(input.MinVideoWidth))) return false;
            if (this.MinVideoLength != input.MinVideoLength || (this.MinVideoLength != null && !this.MinVideoLength.Equals(input.MinVideoLength))) return false;
            if (this.SingleFrameNaturalPercentage != input.SingleFrameNaturalPercentage || (this.SingleFrameNaturalPercentage != null && !this.SingleFrameNaturalPercentage.Equals(input.SingleFrameNaturalPercentage))) return false;
            if (this.CyclicalNaturalImagesNumber != input.CyclicalNaturalImagesNumber || (this.CyclicalNaturalImagesNumber != null && !this.CyclicalNaturalImagesNumber.Equals(input.CyclicalNaturalImagesNumber))) return false;
            if (this.NonNaturalImagePercentage != input.NonNaturalImagePercentage || (this.NonNaturalImagePercentage != null && !this.NonNaturalImagePercentage.Equals(input.NonNaturalImagePercentage))) return false;
            if (this.NonNaturalImagesNumber != input.NonNaturalImagesNumber || (this.NonNaturalImagesNumber != null && !this.NonNaturalImagesNumber.Equals(input.NonNaturalImagesNumber))) return false;

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
                if (this.VideoRecognitionThreshold != null) hashCode = hashCode * 59 + this.VideoRecognitionThreshold.GetHashCode();
                if (this.FrameRateStatisticalLength != null) hashCode = hashCode * 59 + this.FrameRateStatisticalLength.GetHashCode();
                if (this.ImageQualityThreshold != null) hashCode = hashCode * 59 + this.ImageQualityThreshold.GetHashCode();
                if (this.RefreshFrequencyThreshold != null) hashCode = hashCode * 59 + this.RefreshFrequencyThreshold.GetHashCode();
                if (this.ExitingVideoAreaThreshold != null) hashCode = hashCode * 59 + this.ExitingVideoAreaThreshold.GetHashCode();
                if (this.MinVideoWidth != null) hashCode = hashCode * 59 + this.MinVideoWidth.GetHashCode();
                if (this.MinVideoLength != null) hashCode = hashCode * 59 + this.MinVideoLength.GetHashCode();
                if (this.SingleFrameNaturalPercentage != null) hashCode = hashCode * 59 + this.SingleFrameNaturalPercentage.GetHashCode();
                if (this.CyclicalNaturalImagesNumber != null) hashCode = hashCode * 59 + this.CyclicalNaturalImagesNumber.GetHashCode();
                if (this.NonNaturalImagePercentage != null) hashCode = hashCode * 59 + this.NonNaturalImagePercentage.GetHashCode();
                if (this.NonNaturalImagesNumber != null) hashCode = hashCode * 59 + this.NonNaturalImagesNumber.GetHashCode();
                return hashCode;
            }
        }
    }
}
