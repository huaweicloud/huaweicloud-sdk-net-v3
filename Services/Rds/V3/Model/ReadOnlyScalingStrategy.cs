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
    /// 只读自动变配策略。
    /// </summary>
    public class ReadOnlyScalingStrategy 
    {

        /// <summary>
        /// **参数解释**：  只读扩容开关。  **约束限制**：  不涉及。  **取值范围**：  - ON：开启 - OFF：关闭  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("read_only_enlarge_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public string ReadOnlyEnlargeEnabled { get; set; }

        /// <summary>
        /// **参数解释**：  只读缩容开关。  **约束限制**：  不涉及。  **取值范围**：  - ON：开启 - OFF：关闭  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("read_only_reduce_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public string ReadOnlyReduceEnabled { get; set; }

        /// <summary>
        /// **参数解释**：  观测窗口时间，单位秒。  **约束限制**：  不涉及。  **取值范围**：  - 120 - 300 - 600 - 900 - 1800  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("read_only_monitor_cycle", NullValueHandling = NullValueHandling.Ignore)]
        public string ReadOnlyMonitorCycle { get; set; }

        /// <summary>
        /// **参数解释**：  静默期，单位秒。  **约束限制**：  不涉及。  **取值范围**：  - 300 - 600 - 1800 - 3600 - 7200 - 10800 - 86400 - 604800  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("read_only_silence_cycle", NullValueHandling = NullValueHandling.Ignore)]
        public string ReadOnlySilenceCycle { get; set; }

        /// <summary>
        /// **参数解释**：  只读最大节点数。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("max_read_only_count", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxReadOnlyCount { get; set; }

        /// <summary>
        /// **参数解释**：  只读扩容阈值。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("read_only_enlarge_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public string ReadOnlyEnlargeThreshold { get; set; }

        /// <summary>
        /// **参数解释**：  扩容新增只读规格。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("read_only_flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string ReadOnlyFlavor { get; set; }

        /// <summary>
        /// **参数解释**：  只读最小节点数。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("min_read_only_count", NullValueHandling = NullValueHandling.Ignore)]
        public string MinReadOnlyCount { get; set; }

        /// <summary>
        /// **参数解释**：  只读缩容阈值。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("read_only_reduce_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public string ReadOnlyReduceThreshold { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReadOnlyScalingStrategy {\n");
            sb.Append("  readOnlyEnlargeEnabled: ").Append(ReadOnlyEnlargeEnabled).Append("\n");
            sb.Append("  readOnlyReduceEnabled: ").Append(ReadOnlyReduceEnabled).Append("\n");
            sb.Append("  readOnlyMonitorCycle: ").Append(ReadOnlyMonitorCycle).Append("\n");
            sb.Append("  readOnlySilenceCycle: ").Append(ReadOnlySilenceCycle).Append("\n");
            sb.Append("  maxReadOnlyCount: ").Append(MaxReadOnlyCount).Append("\n");
            sb.Append("  readOnlyEnlargeThreshold: ").Append(ReadOnlyEnlargeThreshold).Append("\n");
            sb.Append("  readOnlyFlavor: ").Append(ReadOnlyFlavor).Append("\n");
            sb.Append("  minReadOnlyCount: ").Append(MinReadOnlyCount).Append("\n");
            sb.Append("  readOnlyReduceThreshold: ").Append(ReadOnlyReduceThreshold).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReadOnlyScalingStrategy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReadOnlyScalingStrategy input)
        {
            if (input == null) return false;
            if (this.ReadOnlyEnlargeEnabled != input.ReadOnlyEnlargeEnabled || (this.ReadOnlyEnlargeEnabled != null && !this.ReadOnlyEnlargeEnabled.Equals(input.ReadOnlyEnlargeEnabled))) return false;
            if (this.ReadOnlyReduceEnabled != input.ReadOnlyReduceEnabled || (this.ReadOnlyReduceEnabled != null && !this.ReadOnlyReduceEnabled.Equals(input.ReadOnlyReduceEnabled))) return false;
            if (this.ReadOnlyMonitorCycle != input.ReadOnlyMonitorCycle || (this.ReadOnlyMonitorCycle != null && !this.ReadOnlyMonitorCycle.Equals(input.ReadOnlyMonitorCycle))) return false;
            if (this.ReadOnlySilenceCycle != input.ReadOnlySilenceCycle || (this.ReadOnlySilenceCycle != null && !this.ReadOnlySilenceCycle.Equals(input.ReadOnlySilenceCycle))) return false;
            if (this.MaxReadOnlyCount != input.MaxReadOnlyCount || (this.MaxReadOnlyCount != null && !this.MaxReadOnlyCount.Equals(input.MaxReadOnlyCount))) return false;
            if (this.ReadOnlyEnlargeThreshold != input.ReadOnlyEnlargeThreshold || (this.ReadOnlyEnlargeThreshold != null && !this.ReadOnlyEnlargeThreshold.Equals(input.ReadOnlyEnlargeThreshold))) return false;
            if (this.ReadOnlyFlavor != input.ReadOnlyFlavor || (this.ReadOnlyFlavor != null && !this.ReadOnlyFlavor.Equals(input.ReadOnlyFlavor))) return false;
            if (this.MinReadOnlyCount != input.MinReadOnlyCount || (this.MinReadOnlyCount != null && !this.MinReadOnlyCount.Equals(input.MinReadOnlyCount))) return false;
            if (this.ReadOnlyReduceThreshold != input.ReadOnlyReduceThreshold || (this.ReadOnlyReduceThreshold != null && !this.ReadOnlyReduceThreshold.Equals(input.ReadOnlyReduceThreshold))) return false;

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
                if (this.ReadOnlyEnlargeEnabled != null) hashCode = hashCode * 59 + this.ReadOnlyEnlargeEnabled.GetHashCode();
                if (this.ReadOnlyReduceEnabled != null) hashCode = hashCode * 59 + this.ReadOnlyReduceEnabled.GetHashCode();
                if (this.ReadOnlyMonitorCycle != null) hashCode = hashCode * 59 + this.ReadOnlyMonitorCycle.GetHashCode();
                if (this.ReadOnlySilenceCycle != null) hashCode = hashCode * 59 + this.ReadOnlySilenceCycle.GetHashCode();
                if (this.MaxReadOnlyCount != null) hashCode = hashCode * 59 + this.MaxReadOnlyCount.GetHashCode();
                if (this.ReadOnlyEnlargeThreshold != null) hashCode = hashCode * 59 + this.ReadOnlyEnlargeThreshold.GetHashCode();
                if (this.ReadOnlyFlavor != null) hashCode = hashCode * 59 + this.ReadOnlyFlavor.GetHashCode();
                if (this.MinReadOnlyCount != null) hashCode = hashCode * 59 + this.MinReadOnlyCount.GetHashCode();
                if (this.ReadOnlyReduceThreshold != null) hashCode = hashCode * 59 + this.ReadOnlyReduceThreshold.GetHashCode();
                return hashCode;
            }
        }
    }
}
