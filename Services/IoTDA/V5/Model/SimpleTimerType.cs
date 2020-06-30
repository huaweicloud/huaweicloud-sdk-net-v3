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
    /// 条件中简单定时类型的信息，自定义结构。
    /// </summary>
    public class SimpleTimerType 
    {

        /// <summary>
        /// 规则触发的开始时间，使用UTC时区，格式：yyyyMMdd&#39;T&#39;HHmmss&#39;Z&#39;。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 规则触发的重复时间间隔，单位为秒。
        /// </summary>
        [JsonProperty("repeat_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepeatInterval { get; set; }

        /// <summary>
        /// 规则触发的重复次数。
        /// </summary>
        [JsonProperty("repeat_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepeatCount { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimpleTimerType {\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  repeatInterval: ").Append(RepeatInterval).Append("\n");
            sb.Append("  repeatCount: ").Append(RepeatCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SimpleTimerType);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SimpleTimerType input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.RepeatInterval == input.RepeatInterval ||
                    (this.RepeatInterval != null &&
                    this.RepeatInterval.Equals(input.RepeatInterval))
                ) && 
                (
                    this.RepeatCount == input.RepeatCount ||
                    (this.RepeatCount != null &&
                    this.RepeatCount.Equals(input.RepeatCount))
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
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.RepeatInterval != null)
                    hashCode = hashCode * 59 + this.RepeatInterval.GetHashCode();
                if (this.RepeatCount != null)
                    hashCode = hashCode * 59 + this.RepeatCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
