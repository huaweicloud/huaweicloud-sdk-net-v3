using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 设置自动变配策略请求体
    /// </summary>
    public class UpdateAutoScalingPolicyRequestBody 
    {

        /// <summary>
        /// 自动变配开关状态。  取值：  - ON：开启。 - OFF：关闭。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 监测周期（单位：秒）。 在整个观测窗口期内，若CPU平均使用率大于等于设定值，则在观测窗口结束后，进行扩容。  取值范围：300、600、900、1800。  status为ON时必填。
        /// </summary>
        [JsonProperty("monitor_cycle", NullValueHandling = NullValueHandling.Ignore)]
        public int? MonitorCycle { get; set; }

        /// <summary>
        /// 静默周期（单位：秒）。 两次自动扩容或自动回缩的最小间隔时间。  取值范围：300、600、1800、3600、7200、10800、86400、604800。  status为ON时必填。
        /// </summary>
        [JsonProperty("silence_cycle", NullValueHandling = NullValueHandling.Ignore)]
        public int? SilenceCycle { get; set; }

        /// <summary>
        /// CPU平均使用率（百分比数值）。  取值范围：50-100。  status为ON时必填。
        /// </summary>
        [JsonProperty("enlarge_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? EnlargeThreshold { get; set; }

        /// <summary>
        /// 扩容规格上限。开启扩缩规格时必填。
        /// </summary>
        [JsonProperty("max_flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxFlavor { get; set; }

        /// <summary>
        /// 是否开启自动回缩。开启自动变配时必填。 - true：是。 - false：否。
        /// </summary>
        [JsonProperty("reduce_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReduceEnabled { get; set; }

        /// <summary>
        /// 只读节点数量上限。开启增删只读节点时必填。
        /// </summary>
        [JsonProperty("max_read_only_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxReadOnlyCount { get; set; }

        /// <summary>
        /// 只读节点读写分离权重。开启增删只读节点时必填。
        /// </summary>
        [JsonProperty("read_only_weight", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReadOnlyWeight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("scaling_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public ScalingStrategyReqInfo ScalingStrategy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAutoScalingPolicyRequestBody {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  monitorCycle: ").Append(MonitorCycle).Append("\n");
            sb.Append("  silenceCycle: ").Append(SilenceCycle).Append("\n");
            sb.Append("  enlargeThreshold: ").Append(EnlargeThreshold).Append("\n");
            sb.Append("  maxFlavor: ").Append(MaxFlavor).Append("\n");
            sb.Append("  reduceEnabled: ").Append(ReduceEnabled).Append("\n");
            sb.Append("  maxReadOnlyCount: ").Append(MaxReadOnlyCount).Append("\n");
            sb.Append("  readOnlyWeight: ").Append(ReadOnlyWeight).Append("\n");
            sb.Append("  scalingStrategy: ").Append(ScalingStrategy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateAutoScalingPolicyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateAutoScalingPolicyRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.MonitorCycle == input.MonitorCycle ||
                    (this.MonitorCycle != null &&
                    this.MonitorCycle.Equals(input.MonitorCycle))
                ) && 
                (
                    this.SilenceCycle == input.SilenceCycle ||
                    (this.SilenceCycle != null &&
                    this.SilenceCycle.Equals(input.SilenceCycle))
                ) && 
                (
                    this.EnlargeThreshold == input.EnlargeThreshold ||
                    (this.EnlargeThreshold != null &&
                    this.EnlargeThreshold.Equals(input.EnlargeThreshold))
                ) && 
                (
                    this.MaxFlavor == input.MaxFlavor ||
                    (this.MaxFlavor != null &&
                    this.MaxFlavor.Equals(input.MaxFlavor))
                ) && 
                (
                    this.ReduceEnabled == input.ReduceEnabled ||
                    (this.ReduceEnabled != null &&
                    this.ReduceEnabled.Equals(input.ReduceEnabled))
                ) && 
                (
                    this.MaxReadOnlyCount == input.MaxReadOnlyCount ||
                    (this.MaxReadOnlyCount != null &&
                    this.MaxReadOnlyCount.Equals(input.MaxReadOnlyCount))
                ) && 
                (
                    this.ReadOnlyWeight == input.ReadOnlyWeight ||
                    (this.ReadOnlyWeight != null &&
                    this.ReadOnlyWeight.Equals(input.ReadOnlyWeight))
                ) && 
                (
                    this.ScalingStrategy == input.ScalingStrategy ||
                    (this.ScalingStrategy != null &&
                    this.ScalingStrategy.Equals(input.ScalingStrategy))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.MonitorCycle != null)
                    hashCode = hashCode * 59 + this.MonitorCycle.GetHashCode();
                if (this.SilenceCycle != null)
                    hashCode = hashCode * 59 + this.SilenceCycle.GetHashCode();
                if (this.EnlargeThreshold != null)
                    hashCode = hashCode * 59 + this.EnlargeThreshold.GetHashCode();
                if (this.MaxFlavor != null)
                    hashCode = hashCode * 59 + this.MaxFlavor.GetHashCode();
                if (this.ReduceEnabled != null)
                    hashCode = hashCode * 59 + this.ReduceEnabled.GetHashCode();
                if (this.MaxReadOnlyCount != null)
                    hashCode = hashCode * 59 + this.MaxReadOnlyCount.GetHashCode();
                if (this.ReadOnlyWeight != null)
                    hashCode = hashCode * 59 + this.ReadOnlyWeight.GetHashCode();
                if (this.ScalingStrategy != null)
                    hashCode = hashCode * 59 + this.ScalingStrategy.GetHashCode();
                return hashCode;
            }
        }
    }
}
