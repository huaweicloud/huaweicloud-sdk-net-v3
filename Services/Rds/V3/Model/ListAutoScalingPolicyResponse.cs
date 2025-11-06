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
    /// Response Object
    /// </summary>
    public class ListAutoScalingPolicyResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  实例ID。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**：  是否开启autoScaling，OFF为关闭，ON为开启  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**：  观察窗口，单位秒  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("monitor_cycle", NullValueHandling = NullValueHandling.Ignore)]
        public int? MonitorCycle { get; set; }

        /// <summary>
        /// **参数解释**：  静默期，单位秒  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("silence_cycle", NullValueHandling = NullValueHandling.Ignore)]
        public int? SilenceCycle { get; set; }

        /// <summary>
        /// **参数解释**：  自动升配触发阈值，单位百分比  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("enlarge_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? EnlargeThreshold { get; set; }

        /// <summary>
        /// **参数解释**：  最大变配规格上限  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("max_flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxFlavor { get; set; }

        /// <summary>
        /// **参数解释**：  自动降配状态，on为自动降配开启；off为关闭  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("reduce_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public string ReduceEnabled { get; set; }

        /// <summary>
        /// **参数解释**：  自动降配触发阈值  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("reduce_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReduceThreshold { get; set; }

        /// <summary>
        /// **参数解释**：  最大变配规格下限  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("min_flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string MinFlavor { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAutoScalingPolicyResponse {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  monitorCycle: ").Append(MonitorCycle).Append("\n");
            sb.Append("  silenceCycle: ").Append(SilenceCycle).Append("\n");
            sb.Append("  enlargeThreshold: ").Append(EnlargeThreshold).Append("\n");
            sb.Append("  maxFlavor: ").Append(MaxFlavor).Append("\n");
            sb.Append("  reduceEnabled: ").Append(ReduceEnabled).Append("\n");
            sb.Append("  reduceThreshold: ").Append(ReduceThreshold).Append("\n");
            sb.Append("  minFlavor: ").Append(MinFlavor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAutoScalingPolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAutoScalingPolicyResponse input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.MonitorCycle != input.MonitorCycle || (this.MonitorCycle != null && !this.MonitorCycle.Equals(input.MonitorCycle))) return false;
            if (this.SilenceCycle != input.SilenceCycle || (this.SilenceCycle != null && !this.SilenceCycle.Equals(input.SilenceCycle))) return false;
            if (this.EnlargeThreshold != input.EnlargeThreshold || (this.EnlargeThreshold != null && !this.EnlargeThreshold.Equals(input.EnlargeThreshold))) return false;
            if (this.MaxFlavor != input.MaxFlavor || (this.MaxFlavor != null && !this.MaxFlavor.Equals(input.MaxFlavor))) return false;
            if (this.ReduceEnabled != input.ReduceEnabled || (this.ReduceEnabled != null && !this.ReduceEnabled.Equals(input.ReduceEnabled))) return false;
            if (this.ReduceThreshold != input.ReduceThreshold || (this.ReduceThreshold != null && !this.ReduceThreshold.Equals(input.ReduceThreshold))) return false;
            if (this.MinFlavor != input.MinFlavor || (this.MinFlavor != null && !this.MinFlavor.Equals(input.MinFlavor))) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.MonitorCycle != null) hashCode = hashCode * 59 + this.MonitorCycle.GetHashCode();
                if (this.SilenceCycle != null) hashCode = hashCode * 59 + this.SilenceCycle.GetHashCode();
                if (this.EnlargeThreshold != null) hashCode = hashCode * 59 + this.EnlargeThreshold.GetHashCode();
                if (this.MaxFlavor != null) hashCode = hashCode * 59 + this.MaxFlavor.GetHashCode();
                if (this.ReduceEnabled != null) hashCode = hashCode * 59 + this.ReduceEnabled.GetHashCode();
                if (this.ReduceThreshold != null) hashCode = hashCode * 59 + this.ReduceThreshold.GetHashCode();
                if (this.MinFlavor != null) hashCode = hashCode * 59 + this.MinFlavor.GetHashCode();
                return hashCode;
            }
        }
    }
}
