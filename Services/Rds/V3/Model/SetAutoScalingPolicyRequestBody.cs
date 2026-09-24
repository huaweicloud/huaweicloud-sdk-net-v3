using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 设置自动变配策略请求体。
    /// </summary>
    public class SetAutoScalingPolicyRequestBody 
    {

        /// <summary>
        /// **参数解释**：  是否开启自动变配。  **约束限制**：  不涉及。  **取值范围**：  - ON：开启自动变配 - OFF：关闭自动变配  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**：  观察窗口，单位秒。  **约束限制**：  不涉及。  **取值范围**：  300-1800  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("monitor_cycle", NullValueHandling = NullValueHandling.Ignore)]
        public int? MonitorCycle { get; set; }

        /// <summary>
        /// **参数解释**：  静默期，单位秒。  **约束限制**：  不涉及。  **取值范围**：  300-604800  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("silence_cycle", NullValueHandling = NullValueHandling.Ignore)]
        public int? SilenceCycle { get; set; }

        /// <summary>
        /// **参数解释**：  自动升配触发阈值，单位百分比。  **约束限制**：  不涉及。  **取值范围**：  50-100  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("enlarge_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? EnlargeThreshold { get; set; }

        /// <summary>
        /// **参数解释**：  最大变配规格上限。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("max_flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxFlavor { get; set; }

        /// <summary>
        /// **参数解释**：  自动降配状态。  **约束限制**：  不涉及。  **取值范围**：  - ON：自动降配开启 - OFF：自动降配关闭  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("reduce_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public string ReduceEnabled { get; set; }

        /// <summary>
        /// **参数解释**：  自动降配触发阈值。  **约束限制**：  不涉及。  **取值范围**：  10-30  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("reduce_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReduceThreshold { get; set; }

        /// <summary>
        /// **参数解释**：  最小变配规格下限。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("min_flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string MinFlavor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("read_only_scaling_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public ReadOnlyScalingStrategy ReadOnlyScalingStrategy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetAutoScalingPolicyRequestBody {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  monitorCycle: ").Append(MonitorCycle).Append("\n");
            sb.Append("  silenceCycle: ").Append(SilenceCycle).Append("\n");
            sb.Append("  enlargeThreshold: ").Append(EnlargeThreshold).Append("\n");
            sb.Append("  maxFlavor: ").Append(MaxFlavor).Append("\n");
            sb.Append("  reduceEnabled: ").Append(ReduceEnabled).Append("\n");
            sb.Append("  reduceThreshold: ").Append(ReduceThreshold).Append("\n");
            sb.Append("  minFlavor: ").Append(MinFlavor).Append("\n");
            sb.Append("  readOnlyScalingStrategy: ").Append(ReadOnlyScalingStrategy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetAutoScalingPolicyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetAutoScalingPolicyRequestBody input)
        {
            if (input == null) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.MonitorCycle != input.MonitorCycle || (this.MonitorCycle != null && !this.MonitorCycle.Equals(input.MonitorCycle))) return false;
            if (this.SilenceCycle != input.SilenceCycle || (this.SilenceCycle != null && !this.SilenceCycle.Equals(input.SilenceCycle))) return false;
            if (this.EnlargeThreshold != input.EnlargeThreshold || (this.EnlargeThreshold != null && !this.EnlargeThreshold.Equals(input.EnlargeThreshold))) return false;
            if (this.MaxFlavor != input.MaxFlavor || (this.MaxFlavor != null && !this.MaxFlavor.Equals(input.MaxFlavor))) return false;
            if (this.ReduceEnabled != input.ReduceEnabled || (this.ReduceEnabled != null && !this.ReduceEnabled.Equals(input.ReduceEnabled))) return false;
            if (this.ReduceThreshold != input.ReduceThreshold || (this.ReduceThreshold != null && !this.ReduceThreshold.Equals(input.ReduceThreshold))) return false;
            if (this.MinFlavor != input.MinFlavor || (this.MinFlavor != null && !this.MinFlavor.Equals(input.MinFlavor))) return false;
            if (this.ReadOnlyScalingStrategy != input.ReadOnlyScalingStrategy || (this.ReadOnlyScalingStrategy != null && !this.ReadOnlyScalingStrategy.Equals(input.ReadOnlyScalingStrategy))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.MonitorCycle != null) hashCode = hashCode * 59 + this.MonitorCycle.GetHashCode();
                if (this.SilenceCycle != null) hashCode = hashCode * 59 + this.SilenceCycle.GetHashCode();
                if (this.EnlargeThreshold != null) hashCode = hashCode * 59 + this.EnlargeThreshold.GetHashCode();
                if (this.MaxFlavor != null) hashCode = hashCode * 59 + this.MaxFlavor.GetHashCode();
                if (this.ReduceEnabled != null) hashCode = hashCode * 59 + this.ReduceEnabled.GetHashCode();
                if (this.ReduceThreshold != null) hashCode = hashCode * 59 + this.ReduceThreshold.GetHashCode();
                if (this.MinFlavor != null) hashCode = hashCode * 59 + this.MinFlavor.GetHashCode();
                if (this.ReadOnlyScalingStrategy != null) hashCode = hashCode * 59 + this.ReadOnlyScalingStrategy.GetHashCode();
                return hashCode;
            }
        }
    }
}
