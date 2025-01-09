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
    /// 自适应流控控制选项。
    /// </summary>
    public class PoliciesDisplayAdaptiveBitrateControlOptions 
    {

        /// <summary>
        /// 峰值带宽抑制：取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("peak_bandwidth_suppression_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PeakBandwidthSuppressionEnable { get; set; }

        /// <summary>
        /// 网络平均期望延时。取值范围为[1-2000]。默认：160。
        /// </summary>
        [JsonProperty("expected_average_network_latency", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpectedAverageNetworkLatency { get; set; }

        /// <summary>
        /// 网络延时阈值1（ms）。取值范围为[1-2000]。默认：160。
        /// </summary>
        [JsonProperty("network_latency_threshold1", NullValueHandling = NullValueHandling.Ignore)]
        public int? NetworkLatencyThreshold1 { get; set; }

        /// <summary>
        /// 网络延时阈值2（ms）。取值范围为[1-2000]。默认：300。
        /// </summary>
        [JsonProperty("network_latency_threshold2", NullValueHandling = NullValueHandling.Ignore)]
        public int? NetworkLatencyThreshold2 { get; set; }

        /// <summary>
        /// 最小动态帧率（fps）。取值范围为[1-60]。默认：17。
        /// </summary>
        [JsonProperty("min_dynamic_frame_rate", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinDynamicFrameRate { get; set; }

        /// <summary>
        /// 最小动态帧率Lv1（fps）。取值范围为[1-60]。默认：17。
        /// </summary>
        [JsonProperty("min_dynamic_frame_rate_lv1", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinDynamicFrameRateLv1 { get; set; }

        /// <summary>
        /// 最小动态帧率Lv2（fps）。取值范围为[1-60]。默认：10。
        /// </summary>
        [JsonProperty("min_dynamic_frame_rate_lv2", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinDynamicFrameRateLv2 { get; set; }

        /// <summary>
        /// 帧率控制参数1。取值范围为[0-1000]。默认：20。
        /// </summary>
        [JsonProperty("rtt_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? RttThreshold { get; set; }

        /// <summary>
        /// 帧率控制参数2。取值范围为[0-120]。默认：8。
        /// </summary>
        [JsonProperty("min_add_framerate", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinAddFramerate { get; set; }

        /// <summary>
        /// 帧率控制参数3。取值范围为[0-120]。默认：20。
        /// </summary>
        [JsonProperty("max_add_framerate", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxAddFramerate { get; set; }

        /// <summary>
        /// 帧率控制参数4。取值范围为[0-120]。默认：25。
        /// </summary>
        [JsonProperty("sub_framerate", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubFramerate { get; set; }

        /// <summary>
        /// 自适应带宽下限。取值范围为[100-20000]。默认：500。
        /// </summary>
        [JsonProperty("adaptive_bandwidth_lower_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? AdaptiveBandwidthLowerLimit { get; set; }

        /// <summary>
        /// 自适应有损压缩质量下限。取值范围为[1-100]。默认：60。
        /// </summary>
        [JsonProperty("adaptive_compression_quality_lower_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? AdaptiveCompressionQualityLowerLimit { get; set; }

        /// <summary>
        /// 自适应有损压缩质量上限。取值范围为[1-100]。默认：85。
        /// </summary>
        [JsonProperty("adaptive_compression_quality_upper_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? AdaptiveCompressionQualityUpperLimit { get; set; }

        /// <summary>
        /// 自适应有损压缩质量增限。取值范围为[1-100]。默认：5。
        /// </summary>
        [JsonProperty("adaptive_compression_quality_increase_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? AdaptiveCompressionQualityIncreaseLimit { get; set; }

        /// <summary>
        /// 自适应有损压缩质量减限。取值范围为[1-100]。默认：10。
        /// </summary>
        [JsonProperty("adaptive_compression_quality_decrease_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? AdaptiveCompressionQualityDecreaseLimit { get; set; }

        /// <summary>
        /// 自适应视频平均质量下限。取值范围为[5-50]。默认：15。
        /// </summary>
        [JsonProperty("adaptive_average_quality_lower_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? AdaptiveAverageQualityLowerLimit { get; set; }

        /// <summary>
        /// 自适应视频平均质量上限。取值范围为[5-50]。默认：25。
        /// </summary>
        [JsonProperty("adaptive_average_quality_upper_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? AdaptiveAverageQualityUpperLimit { get; set; }

        /// <summary>
        /// 自适应视频平均质量增限。取值范围为[1-50]。默认：3。
        /// </summary>
        [JsonProperty("adaptive_average_quality_increase_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? AdaptiveAverageQualityIncreaseLimit { get; set; }

        /// <summary>
        /// 自适应视频平均质量减限。取值范围为[1-50]。默认：1。
        /// </summary>
        [JsonProperty("adaptive_average_quality_decrease_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? AdaptiveAverageQualityDecreaseLimit { get; set; }

        /// <summary>
        /// 自适应视频最低质量下限。取值范围为[5-69]。默认：25。
        /// </summary>
        [JsonProperty("adaptive_min_quality_lower_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? AdaptiveMinQualityLowerLimit { get; set; }

        /// <summary>
        /// 自适应视频最低质量上限。取值范围为[5-69]。默认：30。
        /// </summary>
        [JsonProperty("adaptive_min_quality_upper_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? AdaptiveMinQualityUpperLimit { get; set; }

        /// <summary>
        /// 自适应视频最低质量增限。取值范围为[1-50]。默认：3。
        /// </summary>
        [JsonProperty("adaptive_min_quality_increase_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? AdaptiveMinQualityIncreaseLimit { get; set; }

        /// <summary>
        /// 自适应视频最低质量减限。取值范围为[1-50]。默认：1。
        /// </summary>
        [JsonProperty("adaptive_min_quality_decrease_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? AdaptiveMinQualityDecreaseLimit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesDisplayAdaptiveBitrateControlOptions {\n");
            sb.Append("  peakBandwidthSuppressionEnable: ").Append(PeakBandwidthSuppressionEnable).Append("\n");
            sb.Append("  expectedAverageNetworkLatency: ").Append(ExpectedAverageNetworkLatency).Append("\n");
            sb.Append("  networkLatencyThreshold1: ").Append(NetworkLatencyThreshold1).Append("\n");
            sb.Append("  networkLatencyThreshold2: ").Append(NetworkLatencyThreshold2).Append("\n");
            sb.Append("  minDynamicFrameRate: ").Append(MinDynamicFrameRate).Append("\n");
            sb.Append("  minDynamicFrameRateLv1: ").Append(MinDynamicFrameRateLv1).Append("\n");
            sb.Append("  minDynamicFrameRateLv2: ").Append(MinDynamicFrameRateLv2).Append("\n");
            sb.Append("  rttThreshold: ").Append(RttThreshold).Append("\n");
            sb.Append("  minAddFramerate: ").Append(MinAddFramerate).Append("\n");
            sb.Append("  maxAddFramerate: ").Append(MaxAddFramerate).Append("\n");
            sb.Append("  subFramerate: ").Append(SubFramerate).Append("\n");
            sb.Append("  adaptiveBandwidthLowerLimit: ").Append(AdaptiveBandwidthLowerLimit).Append("\n");
            sb.Append("  adaptiveCompressionQualityLowerLimit: ").Append(AdaptiveCompressionQualityLowerLimit).Append("\n");
            sb.Append("  adaptiveCompressionQualityUpperLimit: ").Append(AdaptiveCompressionQualityUpperLimit).Append("\n");
            sb.Append("  adaptiveCompressionQualityIncreaseLimit: ").Append(AdaptiveCompressionQualityIncreaseLimit).Append("\n");
            sb.Append("  adaptiveCompressionQualityDecreaseLimit: ").Append(AdaptiveCompressionQualityDecreaseLimit).Append("\n");
            sb.Append("  adaptiveAverageQualityLowerLimit: ").Append(AdaptiveAverageQualityLowerLimit).Append("\n");
            sb.Append("  adaptiveAverageQualityUpperLimit: ").Append(AdaptiveAverageQualityUpperLimit).Append("\n");
            sb.Append("  adaptiveAverageQualityIncreaseLimit: ").Append(AdaptiveAverageQualityIncreaseLimit).Append("\n");
            sb.Append("  adaptiveAverageQualityDecreaseLimit: ").Append(AdaptiveAverageQualityDecreaseLimit).Append("\n");
            sb.Append("  adaptiveMinQualityLowerLimit: ").Append(AdaptiveMinQualityLowerLimit).Append("\n");
            sb.Append("  adaptiveMinQualityUpperLimit: ").Append(AdaptiveMinQualityUpperLimit).Append("\n");
            sb.Append("  adaptiveMinQualityIncreaseLimit: ").Append(AdaptiveMinQualityIncreaseLimit).Append("\n");
            sb.Append("  adaptiveMinQualityDecreaseLimit: ").Append(AdaptiveMinQualityDecreaseLimit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesDisplayAdaptiveBitrateControlOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesDisplayAdaptiveBitrateControlOptions input)
        {
            if (input == null) return false;
            if (this.PeakBandwidthSuppressionEnable != input.PeakBandwidthSuppressionEnable || (this.PeakBandwidthSuppressionEnable != null && !this.PeakBandwidthSuppressionEnable.Equals(input.PeakBandwidthSuppressionEnable))) return false;
            if (this.ExpectedAverageNetworkLatency != input.ExpectedAverageNetworkLatency || (this.ExpectedAverageNetworkLatency != null && !this.ExpectedAverageNetworkLatency.Equals(input.ExpectedAverageNetworkLatency))) return false;
            if (this.NetworkLatencyThreshold1 != input.NetworkLatencyThreshold1 || (this.NetworkLatencyThreshold1 != null && !this.NetworkLatencyThreshold1.Equals(input.NetworkLatencyThreshold1))) return false;
            if (this.NetworkLatencyThreshold2 != input.NetworkLatencyThreshold2 || (this.NetworkLatencyThreshold2 != null && !this.NetworkLatencyThreshold2.Equals(input.NetworkLatencyThreshold2))) return false;
            if (this.MinDynamicFrameRate != input.MinDynamicFrameRate || (this.MinDynamicFrameRate != null && !this.MinDynamicFrameRate.Equals(input.MinDynamicFrameRate))) return false;
            if (this.MinDynamicFrameRateLv1 != input.MinDynamicFrameRateLv1 || (this.MinDynamicFrameRateLv1 != null && !this.MinDynamicFrameRateLv1.Equals(input.MinDynamicFrameRateLv1))) return false;
            if (this.MinDynamicFrameRateLv2 != input.MinDynamicFrameRateLv2 || (this.MinDynamicFrameRateLv2 != null && !this.MinDynamicFrameRateLv2.Equals(input.MinDynamicFrameRateLv2))) return false;
            if (this.RttThreshold != input.RttThreshold || (this.RttThreshold != null && !this.RttThreshold.Equals(input.RttThreshold))) return false;
            if (this.MinAddFramerate != input.MinAddFramerate || (this.MinAddFramerate != null && !this.MinAddFramerate.Equals(input.MinAddFramerate))) return false;
            if (this.MaxAddFramerate != input.MaxAddFramerate || (this.MaxAddFramerate != null && !this.MaxAddFramerate.Equals(input.MaxAddFramerate))) return false;
            if (this.SubFramerate != input.SubFramerate || (this.SubFramerate != null && !this.SubFramerate.Equals(input.SubFramerate))) return false;
            if (this.AdaptiveBandwidthLowerLimit != input.AdaptiveBandwidthLowerLimit || (this.AdaptiveBandwidthLowerLimit != null && !this.AdaptiveBandwidthLowerLimit.Equals(input.AdaptiveBandwidthLowerLimit))) return false;
            if (this.AdaptiveCompressionQualityLowerLimit != input.AdaptiveCompressionQualityLowerLimit || (this.AdaptiveCompressionQualityLowerLimit != null && !this.AdaptiveCompressionQualityLowerLimit.Equals(input.AdaptiveCompressionQualityLowerLimit))) return false;
            if (this.AdaptiveCompressionQualityUpperLimit != input.AdaptiveCompressionQualityUpperLimit || (this.AdaptiveCompressionQualityUpperLimit != null && !this.AdaptiveCompressionQualityUpperLimit.Equals(input.AdaptiveCompressionQualityUpperLimit))) return false;
            if (this.AdaptiveCompressionQualityIncreaseLimit != input.AdaptiveCompressionQualityIncreaseLimit || (this.AdaptiveCompressionQualityIncreaseLimit != null && !this.AdaptiveCompressionQualityIncreaseLimit.Equals(input.AdaptiveCompressionQualityIncreaseLimit))) return false;
            if (this.AdaptiveCompressionQualityDecreaseLimit != input.AdaptiveCompressionQualityDecreaseLimit || (this.AdaptiveCompressionQualityDecreaseLimit != null && !this.AdaptiveCompressionQualityDecreaseLimit.Equals(input.AdaptiveCompressionQualityDecreaseLimit))) return false;
            if (this.AdaptiveAverageQualityLowerLimit != input.AdaptiveAverageQualityLowerLimit || (this.AdaptiveAverageQualityLowerLimit != null && !this.AdaptiveAverageQualityLowerLimit.Equals(input.AdaptiveAverageQualityLowerLimit))) return false;
            if (this.AdaptiveAverageQualityUpperLimit != input.AdaptiveAverageQualityUpperLimit || (this.AdaptiveAverageQualityUpperLimit != null && !this.AdaptiveAverageQualityUpperLimit.Equals(input.AdaptiveAverageQualityUpperLimit))) return false;
            if (this.AdaptiveAverageQualityIncreaseLimit != input.AdaptiveAverageQualityIncreaseLimit || (this.AdaptiveAverageQualityIncreaseLimit != null && !this.AdaptiveAverageQualityIncreaseLimit.Equals(input.AdaptiveAverageQualityIncreaseLimit))) return false;
            if (this.AdaptiveAverageQualityDecreaseLimit != input.AdaptiveAverageQualityDecreaseLimit || (this.AdaptiveAverageQualityDecreaseLimit != null && !this.AdaptiveAverageQualityDecreaseLimit.Equals(input.AdaptiveAverageQualityDecreaseLimit))) return false;
            if (this.AdaptiveMinQualityLowerLimit != input.AdaptiveMinQualityLowerLimit || (this.AdaptiveMinQualityLowerLimit != null && !this.AdaptiveMinQualityLowerLimit.Equals(input.AdaptiveMinQualityLowerLimit))) return false;
            if (this.AdaptiveMinQualityUpperLimit != input.AdaptiveMinQualityUpperLimit || (this.AdaptiveMinQualityUpperLimit != null && !this.AdaptiveMinQualityUpperLimit.Equals(input.AdaptiveMinQualityUpperLimit))) return false;
            if (this.AdaptiveMinQualityIncreaseLimit != input.AdaptiveMinQualityIncreaseLimit || (this.AdaptiveMinQualityIncreaseLimit != null && !this.AdaptiveMinQualityIncreaseLimit.Equals(input.AdaptiveMinQualityIncreaseLimit))) return false;
            if (this.AdaptiveMinQualityDecreaseLimit != input.AdaptiveMinQualityDecreaseLimit || (this.AdaptiveMinQualityDecreaseLimit != null && !this.AdaptiveMinQualityDecreaseLimit.Equals(input.AdaptiveMinQualityDecreaseLimit))) return false;

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
                if (this.PeakBandwidthSuppressionEnable != null) hashCode = hashCode * 59 + this.PeakBandwidthSuppressionEnable.GetHashCode();
                if (this.ExpectedAverageNetworkLatency != null) hashCode = hashCode * 59 + this.ExpectedAverageNetworkLatency.GetHashCode();
                if (this.NetworkLatencyThreshold1 != null) hashCode = hashCode * 59 + this.NetworkLatencyThreshold1.GetHashCode();
                if (this.NetworkLatencyThreshold2 != null) hashCode = hashCode * 59 + this.NetworkLatencyThreshold2.GetHashCode();
                if (this.MinDynamicFrameRate != null) hashCode = hashCode * 59 + this.MinDynamicFrameRate.GetHashCode();
                if (this.MinDynamicFrameRateLv1 != null) hashCode = hashCode * 59 + this.MinDynamicFrameRateLv1.GetHashCode();
                if (this.MinDynamicFrameRateLv2 != null) hashCode = hashCode * 59 + this.MinDynamicFrameRateLv2.GetHashCode();
                if (this.RttThreshold != null) hashCode = hashCode * 59 + this.RttThreshold.GetHashCode();
                if (this.MinAddFramerate != null) hashCode = hashCode * 59 + this.MinAddFramerate.GetHashCode();
                if (this.MaxAddFramerate != null) hashCode = hashCode * 59 + this.MaxAddFramerate.GetHashCode();
                if (this.SubFramerate != null) hashCode = hashCode * 59 + this.SubFramerate.GetHashCode();
                if (this.AdaptiveBandwidthLowerLimit != null) hashCode = hashCode * 59 + this.AdaptiveBandwidthLowerLimit.GetHashCode();
                if (this.AdaptiveCompressionQualityLowerLimit != null) hashCode = hashCode * 59 + this.AdaptiveCompressionQualityLowerLimit.GetHashCode();
                if (this.AdaptiveCompressionQualityUpperLimit != null) hashCode = hashCode * 59 + this.AdaptiveCompressionQualityUpperLimit.GetHashCode();
                if (this.AdaptiveCompressionQualityIncreaseLimit != null) hashCode = hashCode * 59 + this.AdaptiveCompressionQualityIncreaseLimit.GetHashCode();
                if (this.AdaptiveCompressionQualityDecreaseLimit != null) hashCode = hashCode * 59 + this.AdaptiveCompressionQualityDecreaseLimit.GetHashCode();
                if (this.AdaptiveAverageQualityLowerLimit != null) hashCode = hashCode * 59 + this.AdaptiveAverageQualityLowerLimit.GetHashCode();
                if (this.AdaptiveAverageQualityUpperLimit != null) hashCode = hashCode * 59 + this.AdaptiveAverageQualityUpperLimit.GetHashCode();
                if (this.AdaptiveAverageQualityIncreaseLimit != null) hashCode = hashCode * 59 + this.AdaptiveAverageQualityIncreaseLimit.GetHashCode();
                if (this.AdaptiveAverageQualityDecreaseLimit != null) hashCode = hashCode * 59 + this.AdaptiveAverageQualityDecreaseLimit.GetHashCode();
                if (this.AdaptiveMinQualityLowerLimit != null) hashCode = hashCode * 59 + this.AdaptiveMinQualityLowerLimit.GetHashCode();
                if (this.AdaptiveMinQualityUpperLimit != null) hashCode = hashCode * 59 + this.AdaptiveMinQualityUpperLimit.GetHashCode();
                if (this.AdaptiveMinQualityIncreaseLimit != null) hashCode = hashCode * 59 + this.AdaptiveMinQualityIncreaseLimit.GetHashCode();
                if (this.AdaptiveMinQualityDecreaseLimit != null) hashCode = hashCode * 59 + this.AdaptiveMinQualityDecreaseLimit.GetHashCode();
                return hashCode;
            }
        }
    }
}
