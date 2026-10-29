using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowTaskDefectsStatisticResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public StatisticSeverityV2 Severity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatisticStatusV2 Status { get; set; }

        /// <summary>
        /// **参数解释：** 检查开始时间，使用UTC时间，格式为yyyy-MM-ddTHH:mm:ssZ。例如：2020-09-25T12:05:00Z。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("last_check_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastCheckTime { get; set; }

        /// <summary>
        /// **参数解释：** 检查结束时间，使用UTC时间，格式为yyyy-MM-ddTHH:mm:ssZ。例如：2020-09-25T12:05:00Z。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("last_check_finish_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastCheckFinishTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTaskDefectsStatisticResponse {\n");
            sb.Append("  severity: ").Append(Severity).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  lastCheckTime: ").Append(LastCheckTime).Append("\n");
            sb.Append("  lastCheckFinishTime: ").Append(LastCheckFinishTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTaskDefectsStatisticResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTaskDefectsStatisticResponse input)
        {
            if (input == null) return false;
            if (this.Severity != input.Severity || (this.Severity != null && !this.Severity.Equals(input.Severity))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.LastCheckTime != input.LastCheckTime || (this.LastCheckTime != null && !this.LastCheckTime.Equals(input.LastCheckTime))) return false;
            if (this.LastCheckFinishTime != input.LastCheckFinishTime || (this.LastCheckFinishTime != null && !this.LastCheckFinishTime.Equals(input.LastCheckFinishTime))) return false;

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
                if (this.Severity != null) hashCode = hashCode * 59 + this.Severity.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.LastCheckTime != null) hashCode = hashCode * 59 + this.LastCheckTime.GetHashCode();
                if (this.LastCheckFinishTime != null) hashCode = hashCode * 59 + this.LastCheckFinishTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
