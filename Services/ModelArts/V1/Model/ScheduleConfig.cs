using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// **参数解释：** 创建服务请求体。 **取值范围：** 不涉及。
    /// </summary>
    public class ScheduleConfig 
    {

        /// <summary>
        /// **参数解释：** 对应的时间单位的数值。 **约束限制：** 与time_unit共同确认时间设置的范围是1分钟~7天之间。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? Duration { get; set; }

        /// <summary>
        /// **参数解释：** 时间的单位。 **约束限制：** 与duration共同确认时间设置的范围是1分钟~7天之间。 **取值范围：** - MINUTES：分钟。 - HOURS：小时。 - DAYS：天。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("time_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeUnit { get; set; }

        /// <summary>
        /// **参数解释：** 调度类型，当前仅支持取值为STOP。 **约束限制：** 不涉及。 **取值范围：** - STOP：停止。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduleConfig {\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  timeUnit: ").Append(TimeUnit).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScheduleConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScheduleConfig input)
        {
            if (input == null) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;
            if (this.TimeUnit != input.TimeUnit || (this.TimeUnit != null && !this.TimeUnit.Equals(input.TimeUnit))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;

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
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.TimeUnit != null) hashCode = hashCode * 59 + this.TimeUnit.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
