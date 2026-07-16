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
    /// **参数解释：** 定时停止配置。
    /// </summary>
    public class ScheduleConfigResponse 
    {

        /// <summary>
        /// **参数解释：** 触发时间，UTC毫秒，13位时间戳。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("due_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? DueTime { get; set; }

        /// <summary>
        /// **参数解释：** 对应的时间单位的数值。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? Duration { get; set; }

        /// <summary>
        /// **参数解释：** 调度时间单位。 **取值范围：** - MINUTES：分钟。 - HOURS：小时。 - DAYS：天。
        /// </summary>
        [JsonProperty("time_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeUnit { get; set; }

        /// <summary>
        /// **参数解释：** 调度类型，当前仅支持取值为STOP。 **取值范围：** - STOP：停止。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释：** 表示是否处理完成。 **取值范围：** - true：该定时任务已经执行过。 - false：该定时任务尚未执行。
        /// </summary>
        [JsonProperty("processed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Processed { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduleConfigResponse {\n");
            sb.Append("  dueTime: ").Append(DueTime).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  timeUnit: ").Append(TimeUnit).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  processed: ").Append(Processed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScheduleConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScheduleConfigResponse input)
        {
            if (input == null) return false;
            if (this.DueTime != input.DueTime || (this.DueTime != null && !this.DueTime.Equals(input.DueTime))) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;
            if (this.TimeUnit != input.TimeUnit || (this.TimeUnit != null && !this.TimeUnit.Equals(input.TimeUnit))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Processed != input.Processed || (this.Processed != null && !this.Processed.Equals(input.Processed))) return false;

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
                if (this.DueTime != null) hashCode = hashCode * 59 + this.DueTime.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.TimeUnit != null) hashCode = hashCode * 59 + this.TimeUnit.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Processed != null) hashCode = hashCode * 59 + this.Processed.GetHashCode();
                return hashCode;
            }
        }
    }
}
