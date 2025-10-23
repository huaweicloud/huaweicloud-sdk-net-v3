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
    public class ModifyAutoEnlargePolicyRequestBody 
    {

        /// <summary>
        /// **参数解释**: 磁盘自动扩容开关。 **约束限制**: 不涉及。 **取值范围**: - true：开启磁盘自动扩容。 - false：关闭磁盘自动扩容。  **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("switch_option", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SwitchOption { get; set; }

        /// <summary>
        /// **参数解释**: 存储自动扩容上限。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("limit_volume_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? LimitVolumeSize { get; set; }

        /// <summary>
        /// **参数解释**: 可用存储空间率。 **约束限制**: 不涉及。 **取值范围**: 0-100。 **默认取值**: 20。
        /// </summary>
        [JsonProperty("trigger_available_percent", NullValueHandling = NullValueHandling.Ignore)]
        public int? TriggerAvailablePercent { get; set; }

        /// <summary>
        /// **参数解释**: 扩容步长，固定大小扩容方式。 **约束限制**: 40的倍数。 **取值范围**: 不涉及。 **默认取值**: 40。
        /// </summary>
        [JsonProperty("step_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? StepSize { get; set; }

        /// <summary>
        /// **参数解释**: 扩容步长，百分比扩容方式。 **约束限制**: 不能小于1。 **取值范围**: 不涉及。 **默认取值**: 20。
        /// </summary>
        [JsonProperty("step_percent", NullValueHandling = NullValueHandling.Ignore)]
        public int? StepPercent { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyAutoEnlargePolicyRequestBody {\n");
            sb.Append("  switchOption: ").Append(SwitchOption).Append("\n");
            sb.Append("  limitVolumeSize: ").Append(LimitVolumeSize).Append("\n");
            sb.Append("  triggerAvailablePercent: ").Append(TriggerAvailablePercent).Append("\n");
            sb.Append("  stepSize: ").Append(StepSize).Append("\n");
            sb.Append("  stepPercent: ").Append(StepPercent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyAutoEnlargePolicyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyAutoEnlargePolicyRequestBody input)
        {
            if (input == null) return false;
            if (this.SwitchOption != input.SwitchOption || (this.SwitchOption != null && !this.SwitchOption.Equals(input.SwitchOption))) return false;
            if (this.LimitVolumeSize != input.LimitVolumeSize || (this.LimitVolumeSize != null && !this.LimitVolumeSize.Equals(input.LimitVolumeSize))) return false;
            if (this.TriggerAvailablePercent != input.TriggerAvailablePercent || (this.TriggerAvailablePercent != null && !this.TriggerAvailablePercent.Equals(input.TriggerAvailablePercent))) return false;
            if (this.StepSize != input.StepSize || (this.StepSize != null && !this.StepSize.Equals(input.StepSize))) return false;
            if (this.StepPercent != input.StepPercent || (this.StepPercent != null && !this.StepPercent.Equals(input.StepPercent))) return false;

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
                if (this.SwitchOption != null) hashCode = hashCode * 59 + this.SwitchOption.GetHashCode();
                if (this.LimitVolumeSize != null) hashCode = hashCode * 59 + this.LimitVolumeSize.GetHashCode();
                if (this.TriggerAvailablePercent != null) hashCode = hashCode * 59 + this.TriggerAvailablePercent.GetHashCode();
                if (this.StepSize != null) hashCode = hashCode * 59 + this.StepSize.GetHashCode();
                if (this.StepPercent != null) hashCode = hashCode * 59 + this.StepPercent.GetHashCode();
                return hashCode;
            }
        }
    }
}
