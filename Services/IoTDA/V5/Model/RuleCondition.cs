using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 规则条件结构体
    /// </summary>
    public class RuleCondition 
    {

        /// <summary>
        /// **参数说明**：规则条件的类型。 **取值范围**： - DEVICE_DATA：设备属性数据类型条件。 - SIMPLE_TIMER：简单定时类型条件。 - DAILY_TIMER：每日定时类型条件。 - DEVICE_LINKAGE_STATUS：设备状态类型条件。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("device_property_condition", NullValueHandling = NullValueHandling.Ignore)]
        public DeviceDataCondition DevicePropertyCondition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("simple_timer_condition", NullValueHandling = NullValueHandling.Ignore)]
        public SimpleTimerType SimpleTimerCondition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("daily_timer_condition", NullValueHandling = NullValueHandling.Ignore)]
        public DailyTimerType DailyTimerCondition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("device_linkage_status_condition", NullValueHandling = NullValueHandling.Ignore)]
        public DeviceLinkageStatusCondition DeviceLinkageStatusCondition { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleCondition {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  devicePropertyCondition: ").Append(DevicePropertyCondition).Append("\n");
            sb.Append("  simpleTimerCondition: ").Append(SimpleTimerCondition).Append("\n");
            sb.Append("  dailyTimerCondition: ").Append(DailyTimerCondition).Append("\n");
            sb.Append("  deviceLinkageStatusCondition: ").Append(DeviceLinkageStatusCondition).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RuleCondition);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RuleCondition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.DevicePropertyCondition == input.DevicePropertyCondition ||
                    (this.DevicePropertyCondition != null &&
                    this.DevicePropertyCondition.Equals(input.DevicePropertyCondition))
                ) && 
                (
                    this.SimpleTimerCondition == input.SimpleTimerCondition ||
                    (this.SimpleTimerCondition != null &&
                    this.SimpleTimerCondition.Equals(input.SimpleTimerCondition))
                ) && 
                (
                    this.DailyTimerCondition == input.DailyTimerCondition ||
                    (this.DailyTimerCondition != null &&
                    this.DailyTimerCondition.Equals(input.DailyTimerCondition))
                ) && 
                (
                    this.DeviceLinkageStatusCondition == input.DeviceLinkageStatusCondition ||
                    (this.DeviceLinkageStatusCondition != null &&
                    this.DeviceLinkageStatusCondition.Equals(input.DeviceLinkageStatusCondition))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.DevicePropertyCondition != null)
                    hashCode = hashCode * 59 + this.DevicePropertyCondition.GetHashCode();
                if (this.SimpleTimerCondition != null)
                    hashCode = hashCode * 59 + this.SimpleTimerCondition.GetHashCode();
                if (this.DailyTimerCondition != null)
                    hashCode = hashCode * 59 + this.DailyTimerCondition.GetHashCode();
                if (this.DeviceLinkageStatusCondition != null)
                    hashCode = hashCode * 59 + this.DeviceLinkageStatusCondition.GetHashCode();
                return hashCode;
            }
        }
    }
}
