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
    /// 训练作业的保留时长配置。
    /// </summary>
    public class ReserveTime 
    {

        /// <summary>
        /// **参数解释**：时间单位。  **约束限制**：不涉及。  **取值范围**：  - HOURS：小时   **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("time_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeUnit { get; set; }

        /// <summary>
        /// **参数解释**：保留时长。  **约束限制**：不涉及。  **取值范围**：最小值为1。  **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? Duration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReserveTime {\n");
            sb.Append("  timeUnit: ").Append(TimeUnit).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReserveTime);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReserveTime input)
        {
            if (input == null) return false;
            if (this.TimeUnit != input.TimeUnit || (this.TimeUnit != null && !this.TimeUnit.Equals(input.TimeUnit))) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;

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
                if (this.TimeUnit != null) hashCode = hashCode * 59 + this.TimeUnit.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                return hashCode;
            }
        }
    }
}
