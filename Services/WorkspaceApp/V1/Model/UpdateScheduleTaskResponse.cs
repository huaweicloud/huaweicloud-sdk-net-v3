using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UpdateScheduleTaskResponse : SdkResponse
    {

        /// <summary>
        /// 定时任务主键id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 任务名称。
        /// </summary>
        [JsonProperty("task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("last_status", NullValueHandling = NullValueHandling.Ignore)]
        public ScheduleTaskStatus? LastStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("task_type", NullValueHandling = NullValueHandling.Ignore)]
        public ScheduleTaskTypeEnum? TaskType { get; set; }

        /// <summary>
        /// 定时任务表达式。
        /// </summary>
        [JsonProperty("task_cron", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskCron { get; set; }

        /// <summary>
        /// 下一次执行时间。
        /// </summary>
        [JsonProperty("next_execution_time", NullValueHandling = NullValueHandling.Ignore)]
        public string NextExecutionTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("schedule_task_policy", NullValueHandling = NullValueHandling.Ignore)]
        public ScheduleTaskPolicy ScheduleTaskPolicy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("scheduled_type", NullValueHandling = NullValueHandling.Ignore)]
        public ScheduledTypeEnum? ScheduledType { get; set; }

        /// <summary>
        /// 周期按天时：按x天间隔执行。
        /// </summary>
        [JsonProperty("day_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? DayInterval { get; set; }

        /// <summary>
        /// 周期按周时：取值1~7，英文逗号分隔，如1,2,7。
        /// </summary>
        [JsonProperty("week_list", NullValueHandling = NullValueHandling.Ignore)]
        public string WeekList { get; set; }

        /// <summary>
        /// 周期按月时：取值1~12，英文逗号分隔，如1,3,12。
        /// </summary>
        [JsonProperty("month_list", NullValueHandling = NullValueHandling.Ignore)]
        public string MonthList { get; set; }

        /// <summary>
        /// 周期按月时：取值1~31及L(代表当月最后一天)，英文逗号分隔，如1,2,28,L。
        /// </summary>
        [JsonProperty("date_list", NullValueHandling = NullValueHandling.Ignore)]
        public string DateList { get; set; }

        /// <summary>
        /// 时区。
        /// </summary>
        [JsonProperty("time_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeZone { get; set; }

        /// <summary>
        /// 周期指定时间时：表示指定的日期，格式为yyyy-MM-dd。
        /// </summary>
        [JsonProperty("scheduled_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ScheduledDate { get; set; }

        /// <summary>
        /// 指定的执行时间点，格式为HH:mm:ss。
        /// </summary>
        [JsonProperty("scheduled_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ScheduledTime { get; set; }

        /// <summary>
        /// 到期时间。
        /// </summary>
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExpireTime { get; set; }

        /// <summary>
        /// 任务描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 是否是开启状态。
        /// </summary>
        [JsonProperty("is_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsEnable { get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 更新时间。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateScheduleTaskResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  taskName: ").Append(TaskName).Append("\n");
            sb.Append("  lastStatus: ").Append(LastStatus).Append("\n");
            sb.Append("  taskType: ").Append(TaskType).Append("\n");
            sb.Append("  taskCron: ").Append(TaskCron).Append("\n");
            sb.Append("  nextExecutionTime: ").Append(NextExecutionTime).Append("\n");
            sb.Append("  scheduleTaskPolicy: ").Append(ScheduleTaskPolicy).Append("\n");
            sb.Append("  scheduledType: ").Append(ScheduledType).Append("\n");
            sb.Append("  dayInterval: ").Append(DayInterval).Append("\n");
            sb.Append("  weekList: ").Append(WeekList).Append("\n");
            sb.Append("  monthList: ").Append(MonthList).Append("\n");
            sb.Append("  dateList: ").Append(DateList).Append("\n");
            sb.Append("  timeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  scheduledDate: ").Append(ScheduledDate).Append("\n");
            sb.Append("  scheduledTime: ").Append(ScheduledTime).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  isEnable: ").Append(IsEnable).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateScheduleTaskResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateScheduleTaskResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.TaskName != input.TaskName || (this.TaskName != null && !this.TaskName.Equals(input.TaskName))) return false;
            if (this.LastStatus != input.LastStatus || (this.LastStatus != null && !this.LastStatus.Equals(input.LastStatus))) return false;
            if (this.TaskType != input.TaskType || (this.TaskType != null && !this.TaskType.Equals(input.TaskType))) return false;
            if (this.TaskCron != input.TaskCron || (this.TaskCron != null && !this.TaskCron.Equals(input.TaskCron))) return false;
            if (this.NextExecutionTime != input.NextExecutionTime || (this.NextExecutionTime != null && !this.NextExecutionTime.Equals(input.NextExecutionTime))) return false;
            if (this.ScheduleTaskPolicy != input.ScheduleTaskPolicy || (this.ScheduleTaskPolicy != null && !this.ScheduleTaskPolicy.Equals(input.ScheduleTaskPolicy))) return false;
            if (this.ScheduledType != input.ScheduledType || (this.ScheduledType != null && !this.ScheduledType.Equals(input.ScheduledType))) return false;
            if (this.DayInterval != input.DayInterval || (this.DayInterval != null && !this.DayInterval.Equals(input.DayInterval))) return false;
            if (this.WeekList != input.WeekList || (this.WeekList != null && !this.WeekList.Equals(input.WeekList))) return false;
            if (this.MonthList != input.MonthList || (this.MonthList != null && !this.MonthList.Equals(input.MonthList))) return false;
            if (this.DateList != input.DateList || (this.DateList != null && !this.DateList.Equals(input.DateList))) return false;
            if (this.TimeZone != input.TimeZone || (this.TimeZone != null && !this.TimeZone.Equals(input.TimeZone))) return false;
            if (this.ScheduledDate != input.ScheduledDate || (this.ScheduledDate != null && !this.ScheduledDate.Equals(input.ScheduledDate))) return false;
            if (this.ScheduledTime != input.ScheduledTime || (this.ScheduledTime != null && !this.ScheduledTime.Equals(input.ScheduledTime))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.IsEnable != input.IsEnable || (this.IsEnable != null && !this.IsEnable.Equals(input.IsEnable))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.TaskName != null) hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.LastStatus != null) hashCode = hashCode * 59 + this.LastStatus.GetHashCode();
                if (this.TaskType != null) hashCode = hashCode * 59 + this.TaskType.GetHashCode();
                if (this.TaskCron != null) hashCode = hashCode * 59 + this.TaskCron.GetHashCode();
                if (this.NextExecutionTime != null) hashCode = hashCode * 59 + this.NextExecutionTime.GetHashCode();
                if (this.ScheduleTaskPolicy != null) hashCode = hashCode * 59 + this.ScheduleTaskPolicy.GetHashCode();
                if (this.ScheduledType != null) hashCode = hashCode * 59 + this.ScheduledType.GetHashCode();
                if (this.DayInterval != null) hashCode = hashCode * 59 + this.DayInterval.GetHashCode();
                if (this.WeekList != null) hashCode = hashCode * 59 + this.WeekList.GetHashCode();
                if (this.MonthList != null) hashCode = hashCode * 59 + this.MonthList.GetHashCode();
                if (this.DateList != null) hashCode = hashCode * 59 + this.DateList.GetHashCode();
                if (this.TimeZone != null) hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                if (this.ScheduledDate != null) hashCode = hashCode * 59 + this.ScheduledDate.GetHashCode();
                if (this.ScheduledTime != null) hashCode = hashCode * 59 + this.ScheduledTime.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IsEnable != null) hashCode = hashCode * 59 + this.IsEnable.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
