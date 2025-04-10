using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowAutopilotMaintenanceWindowResponse : SdkResponse
    {

        /// <summary>
        /// 升级周期，从\&quot;Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday\&quot;中进行选择，以英文逗号分隔 如：\&quot;Friday,Saturday\&quot; 
        /// </summary>
        [JsonProperty("weekly_period", NullValueHandling = NullValueHandling.Ignore)]
        public string WeeklyPeriod { get; set; }

        /// <summary>
        /// 升级起始时间（UTC时间）
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 升级时长
        /// </summary>
        [JsonProperty("duration_hours", NullValueHandling = NullValueHandling.Ignore)]
        public int? DurationHours { get; set; }

        /// <summary>
        /// 升级版本范围，当前只支持小版本自动升级
        /// </summary>
        [JsonProperty("upgrade_scope", NullValueHandling = NullValueHandling.Ignore)]
        public string UpgradeScope { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAutopilotMaintenanceWindowResponse {\n");
            sb.Append("  weeklyPeriod: ").Append(WeeklyPeriod).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  durationHours: ").Append(DurationHours).Append("\n");
            sb.Append("  upgradeScope: ").Append(UpgradeScope).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAutopilotMaintenanceWindowResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAutopilotMaintenanceWindowResponse input)
        {
            if (input == null) return false;
            if (this.WeeklyPeriod != input.WeeklyPeriod || (this.WeeklyPeriod != null && !this.WeeklyPeriod.Equals(input.WeeklyPeriod))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.DurationHours != input.DurationHours || (this.DurationHours != null && !this.DurationHours.Equals(input.DurationHours))) return false;
            if (this.UpgradeScope != input.UpgradeScope || (this.UpgradeScope != null && !this.UpgradeScope.Equals(input.UpgradeScope))) return false;

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
                if (this.WeeklyPeriod != null) hashCode = hashCode * 59 + this.WeeklyPeriod.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.DurationHours != null) hashCode = hashCode * 59 + this.DurationHours.GetHashCode();
                if (this.UpgradeScope != null) hashCode = hashCode * 59 + this.UpgradeScope.GetHashCode();
                return hashCode;
            }
        }
    }
}
