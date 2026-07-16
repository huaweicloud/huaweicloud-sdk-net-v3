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
    /// Response Object
    /// </summary>
    public class ShowWorkflowScheduleListResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：工作流定时调度列表
        /// </summary>
        [JsonProperty("schedules", NullValueHandling = NullValueHandling.Ignore)]
        public List<WorkflowScheduleResp> Schedules { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowWorkflowScheduleListResponse {\n");
            sb.Append("  schedules: ").Append(Schedules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowWorkflowScheduleListResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowWorkflowScheduleListResponse input)
        {
            if (input == null) return false;
            if (this.Schedules != input.Schedules || (this.Schedules != null && input.Schedules != null && !this.Schedules.SequenceEqual(input.Schedules))) return false;

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
                if (this.Schedules != null) hashCode = hashCode * 59 + this.Schedules.GetHashCode();
                return hashCode;
            }
        }
    }
}
