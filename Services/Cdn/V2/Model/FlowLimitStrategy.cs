using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// **参数解释：** 用量封顶配置 **约束限制：** 不涉及
    /// </summary>
    public class FlowLimitStrategy 
    {

        /// <summary>
        /// **参数解释：**  用量统计类型 **约束限制：** 不涉及 **取值范围：** - instant: 瞬时用量 - hour: 累计用量（小时） - day: 累计用量（天） **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("strategy_type", NullValueHandling = NullValueHandling.Ignore)]
        public string StrategyType { get; set; }

        /// <summary>
        /// **参数解释：**  用量封顶类型 **约束限制：** 不涉及 **取值范围：** - bandwidth: 带宽封顶，单位: bit/s - traffic: 流量封顶，单位: bit **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("item_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemType { get; set; }

        /// <summary>
        /// **参数解释：** 用量封顶阈值，域名用量达到该阈值后，将会停用域名 **约束限制：** 不涉及 **取值范围：** 必须为正整数 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("limit_value", NullValueHandling = NullValueHandling.Ignore)]
        public string LimitValue { get; set; }

        /// <summary>
        /// **参数解释：** 用量告警阈值，域名用量达到该阈值后，将会发送告警 **约束限制：** 不涉及 **取值范围：** 1-90 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("alarm_percent_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmPercentThreshold { get; set; }

        /// <summary>
        /// **参数解释：** 域名封禁周期 **约束限制：** ban_time设置为0时，表示不自动解封，需要客户手动解封域名 **取值范围：** - 0: 不自动解封 - 60: 60分钟，即1个小时 - 720: 720分钟，即12个小时 - 1440: 1440分钟，即24个小时 - 4320: 4320分钟，即3天 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("ban_time", NullValueHandling = NullValueHandling.Ignore)]
        public string BanTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowLimitStrategy {\n");
            sb.Append("  strategyType: ").Append(StrategyType).Append("\n");
            sb.Append("  itemType: ").Append(ItemType).Append("\n");
            sb.Append("  limitValue: ").Append(LimitValue).Append("\n");
            sb.Append("  alarmPercentThreshold: ").Append(AlarmPercentThreshold).Append("\n");
            sb.Append("  banTime: ").Append(BanTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FlowLimitStrategy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FlowLimitStrategy input)
        {
            if (input == null) return false;
            if (this.StrategyType != input.StrategyType || (this.StrategyType != null && !this.StrategyType.Equals(input.StrategyType))) return false;
            if (this.ItemType != input.ItemType || (this.ItemType != null && !this.ItemType.Equals(input.ItemType))) return false;
            if (this.LimitValue != input.LimitValue || (this.LimitValue != null && !this.LimitValue.Equals(input.LimitValue))) return false;
            if (this.AlarmPercentThreshold != input.AlarmPercentThreshold || (this.AlarmPercentThreshold != null && !this.AlarmPercentThreshold.Equals(input.AlarmPercentThreshold))) return false;
            if (this.BanTime != input.BanTime || (this.BanTime != null && !this.BanTime.Equals(input.BanTime))) return false;

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
                if (this.StrategyType != null) hashCode = hashCode * 59 + this.StrategyType.GetHashCode();
                if (this.ItemType != null) hashCode = hashCode * 59 + this.ItemType.GetHashCode();
                if (this.LimitValue != null) hashCode = hashCode * 59 + this.LimitValue.GetHashCode();
                if (this.AlarmPercentThreshold != null) hashCode = hashCode * 59 + this.AlarmPercentThreshold.GetHashCode();
                if (this.BanTime != null) hashCode = hashCode * 59 + this.BanTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
