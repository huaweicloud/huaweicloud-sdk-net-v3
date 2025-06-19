using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowOperationalDataCurrentMonthUsingResponse : SdkResponse
    {

        /// <summary>
        /// 告警成功比率，恒为1
        /// </summary>
        [JsonProperty("alert_success_rate", NullValueHandling = NullValueHandling.Ignore)]
        public int? AlertSuccessRate { get; set; }

        /// <summary>
        /// 正在运行的任务个数
        /// </summary>
        [JsonProperty("running_tasks", NullValueHandling = NullValueHandling.Ignore)]
        public int? RunningTasks { get; set; }

        /// <summary>
        /// 总告警数
        /// </summary>
        [JsonProperty("total_alerts", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalAlerts { get; set; }

        /// <summary>
        /// 总运行天数
        /// </summary>
        [JsonProperty("total_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalDays { get; set; }

        /// <summary>
        /// 总运行个数
        /// </summary>
        [JsonProperty("total_runs", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalRuns { get; set; }

        /// <summary>
        /// 总任务个数
        /// </summary>
        [JsonProperty("total_tasks", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalTasks { get; set; }

        /// <summary>
        /// 工作项个数
        /// </summary>
        [JsonProperty("work_item_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? WorkItemCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowOperationalDataCurrentMonthUsingResponse {\n");
            sb.Append("  alertSuccessRate: ").Append(AlertSuccessRate).Append("\n");
            sb.Append("  runningTasks: ").Append(RunningTasks).Append("\n");
            sb.Append("  totalAlerts: ").Append(TotalAlerts).Append("\n");
            sb.Append("  totalDays: ").Append(TotalDays).Append("\n");
            sb.Append("  totalRuns: ").Append(TotalRuns).Append("\n");
            sb.Append("  totalTasks: ").Append(TotalTasks).Append("\n");
            sb.Append("  workItemCount: ").Append(WorkItemCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowOperationalDataCurrentMonthUsingResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowOperationalDataCurrentMonthUsingResponse input)
        {
            if (input == null) return false;
            if (this.AlertSuccessRate != input.AlertSuccessRate || (this.AlertSuccessRate != null && !this.AlertSuccessRate.Equals(input.AlertSuccessRate))) return false;
            if (this.RunningTasks != input.RunningTasks || (this.RunningTasks != null && !this.RunningTasks.Equals(input.RunningTasks))) return false;
            if (this.TotalAlerts != input.TotalAlerts || (this.TotalAlerts != null && !this.TotalAlerts.Equals(input.TotalAlerts))) return false;
            if (this.TotalDays != input.TotalDays || (this.TotalDays != null && !this.TotalDays.Equals(input.TotalDays))) return false;
            if (this.TotalRuns != input.TotalRuns || (this.TotalRuns != null && !this.TotalRuns.Equals(input.TotalRuns))) return false;
            if (this.TotalTasks != input.TotalTasks || (this.TotalTasks != null && !this.TotalTasks.Equals(input.TotalTasks))) return false;
            if (this.WorkItemCount != input.WorkItemCount || (this.WorkItemCount != null && !this.WorkItemCount.Equals(input.WorkItemCount))) return false;

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
                if (this.AlertSuccessRate != null) hashCode = hashCode * 59 + this.AlertSuccessRate.GetHashCode();
                if (this.RunningTasks != null) hashCode = hashCode * 59 + this.RunningTasks.GetHashCode();
                if (this.TotalAlerts != null) hashCode = hashCode * 59 + this.TotalAlerts.GetHashCode();
                if (this.TotalDays != null) hashCode = hashCode * 59 + this.TotalDays.GetHashCode();
                if (this.TotalRuns != null) hashCode = hashCode * 59 + this.TotalRuns.GetHashCode();
                if (this.TotalTasks != null) hashCode = hashCode * 59 + this.TotalTasks.GetHashCode();
                if (this.WorkItemCount != null) hashCode = hashCode * 59 + this.WorkItemCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
