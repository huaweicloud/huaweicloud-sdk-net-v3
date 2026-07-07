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
    /// **参数解释**: 运维窗口。
    /// </summary>
    public class ExecuteWindowResult 
    {

        /// <summary>
        /// **参数解释**: 计划执行时间，格式为\&quot;yyyy-mm-ddThh:mm:ssZ\&quot;。其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("planned_execution_time", NullValueHandling = NullValueHandling.Ignore)]
        public string PlannedExecutionTime { get; set; }

        /// <summary>
        /// **参数解释**: 执行时间窗口开始时间，格式为\&quot;yyyy-mm-ddThh:mm:ssZ\&quot;。其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// **参数解释**: 执行时间窗口结束时间，格式为\&quot;yyyy-mm-ddThh:mm:ssZ\&quot;。其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecuteWindowResult {\n");
            sb.Append("  plannedExecutionTime: ").Append(PlannedExecutionTime).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExecuteWindowResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExecuteWindowResult input)
        {
            if (input == null) return false;
            if (this.PlannedExecutionTime != input.PlannedExecutionTime || (this.PlannedExecutionTime != null && !this.PlannedExecutionTime.Equals(input.PlannedExecutionTime))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;

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
                if (this.PlannedExecutionTime != null) hashCode = hashCode * 59 + this.PlannedExecutionTime.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
