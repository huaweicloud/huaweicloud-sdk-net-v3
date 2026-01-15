using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 创建定时任务请求体。
    /// </summary>
    public class CreateScheduledTasksReq 
    {
        /// <summary>
        /// 执行周期类型，可选值为： - FIXED_TIME：指定时间。 - DAY：按天。 - WEEK：按周。 - MONTH：按月。 - LIFE_CYCLE：指定场景下触发。
        /// </summary>
        /// <value>执行周期类型，可选值为： - FIXED_TIME：指定时间。 - DAY：按天。 - WEEK：按周。 - MONTH：按月。 - LIFE_CYCLE：指定场景下触发。</value>
        [JsonConverter(typeof(EnumClassConverter<ScheduledTypeEnum>))]
        public class ScheduledTypeEnum
        {
            /// <summary>
            /// Enum FIXED_TIME for value: FIXED_TIME
            /// </summary>
            public static readonly ScheduledTypeEnum FIXED_TIME = new ScheduledTypeEnum("FIXED_TIME");

            /// <summary>
            /// Enum DAY for value: DAY
            /// </summary>
            public static readonly ScheduledTypeEnum DAY = new ScheduledTypeEnum("DAY");

            /// <summary>
            /// Enum WEEK for value: WEEK
            /// </summary>
            public static readonly ScheduledTypeEnum WEEK = new ScheduledTypeEnum("WEEK");

            /// <summary>
            /// Enum MONTH for value: MONTH
            /// </summary>
            public static readonly ScheduledTypeEnum MONTH = new ScheduledTypeEnum("MONTH");

            /// <summary>
            /// Enum LIFE_CYCLE for value: LIFE_CYCLE
            /// </summary>
            public static readonly ScheduledTypeEnum LIFE_CYCLE = new ScheduledTypeEnum("LIFE_CYCLE");

            private static readonly Dictionary<string, ScheduledTypeEnum> StaticFields =
            new Dictionary<string, ScheduledTypeEnum>()
            {
                { "FIXED_TIME", FIXED_TIME },
                { "DAY", DAY },
                { "WEEK", WEEK },
                { "MONTH", MONTH },
                { "LIFE_CYCLE", LIFE_CYCLE },
            };

            private string _value;

            public ScheduledTypeEnum()
            {

            }

            public ScheduledTypeEnum(string value)
            {
                _value = value;
            }

            public static ScheduledTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as ScheduledTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ScheduledTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ScheduledTypeEnum a, ScheduledTypeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ScheduledTypeEnum a, ScheduledTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 任务类型，可选值为： - START：开机。 - STOP：关机。 - REBOOT：重启。 - HIBERNATE：休眠。 - REBUILD：重建系统盘。 - EXECUTE_SCRIPT：执行脚本。 - CREATE_SNAPSHOT：创建快照。 - DELETE_BLACK_ECS: 删除黑产ecs
        /// </summary>
        /// <value>任务类型，可选值为： - START：开机。 - STOP：关机。 - REBOOT：重启。 - HIBERNATE：休眠。 - REBUILD：重建系统盘。 - EXECUTE_SCRIPT：执行脚本。 - CREATE_SNAPSHOT：创建快照。 - DELETE_BLACK_ECS: 删除黑产ecs</value>
        [JsonConverter(typeof(EnumClassConverter<TaskTypeEnum>))]
        public class TaskTypeEnum
        {
            /// <summary>
            /// Enum START for value: START
            /// </summary>
            public static readonly TaskTypeEnum START = new TaskTypeEnum("START");

            /// <summary>
            /// Enum STOP for value: STOP
            /// </summary>
            public static readonly TaskTypeEnum STOP = new TaskTypeEnum("STOP");

            /// <summary>
            /// Enum REBOOT for value: REBOOT
            /// </summary>
            public static readonly TaskTypeEnum REBOOT = new TaskTypeEnum("REBOOT");

            /// <summary>
            /// Enum HIBERNATE for value: HIBERNATE
            /// </summary>
            public static readonly TaskTypeEnum HIBERNATE = new TaskTypeEnum("HIBERNATE");

            /// <summary>
            /// Enum REBUILD for value: REBUILD
            /// </summary>
            public static readonly TaskTypeEnum REBUILD = new TaskTypeEnum("REBUILD");

            /// <summary>
            /// Enum EXECUTE_SCRIPT for value: EXECUTE_SCRIPT
            /// </summary>
            public static readonly TaskTypeEnum EXECUTE_SCRIPT = new TaskTypeEnum("EXECUTE_SCRIPT");

            /// <summary>
            /// Enum CREATE_SNAPSHOT for value: CREATE_SNAPSHOT
            /// </summary>
            public static readonly TaskTypeEnum CREATE_SNAPSHOT = new TaskTypeEnum("CREATE_SNAPSHOT");

            /// <summary>
            /// Enum DELETE_BLACK_ECS for value: DELETE_BLACK_ECS
            /// </summary>
            public static readonly TaskTypeEnum DELETE_BLACK_ECS = new TaskTypeEnum("DELETE_BLACK_ECS");

            private static readonly Dictionary<string, TaskTypeEnum> StaticFields =
            new Dictionary<string, TaskTypeEnum>()
            {
                { "START", START },
                { "STOP", STOP },
                { "REBOOT", REBOOT },
                { "HIBERNATE", HIBERNATE },
                { "REBUILD", REBUILD },
                { "EXECUTE_SCRIPT", EXECUTE_SCRIPT },
                { "CREATE_SNAPSHOT", CREATE_SNAPSHOT },
                { "DELETE_BLACK_ECS", DELETE_BLACK_ECS },
            };

            private string _value;

            public TaskTypeEnum()
            {

            }

            public TaskTypeEnum(string value)
            {
                _value = value;
            }

            public static TaskTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as TaskTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TaskTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TaskTypeEnum a, TaskTypeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(TaskTypeEnum a, TaskTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 执行周期类型，可选值为： - FIXED_TIME：指定时间。 - DAY：按天。 - WEEK：按周。 - MONTH：按月。 - LIFE_CYCLE：指定场景下触发。
        /// </summary>
        [JsonProperty("scheduled_type", NullValueHandling = NullValueHandling.Ignore)]
        public ScheduledTypeEnum ScheduledType { get; set; }
        /// <summary>
        /// 周期按天时：按x天间隔执行。
        /// </summary>
        [JsonProperty("day_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? DayInterval { get; set; }

        /// <summary>
        /// 周期按周时：取值1~7，分别对应周日~周六，英文逗号分隔，如1,2,7。
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
        /// 到期时间，格式为yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 灰度对象数量，优先级高于gray_desktop_ids。只支持脚本执行。
        /// </summary>
        [JsonProperty("gray_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? GrayCount { get; set; }

        /// <summary>
        /// 灰度执行的桌面id列表，优先级低于gray_count。只支持脚本执行。
        /// </summary>
        [JsonProperty("gray_desktop_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> GrayDesktopIds { get; set; }

        /// <summary>
        /// 灰度失败阈值，灰度执行失败次数达到该值时，不执行下一批任务。只支持脚本执行。
        /// </summary>
        [JsonProperty("gray_fail_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? GrayFailThreshold { get; set; }

        /// <summary>
        /// 触发场景。POST_CREATE_DESKTOP_SUCCESS：创建桌面成功后，POST_REBUILD_DESKTOP_SUCCESS：重建桌面成功后，POST_REATTACH_DESKTOP_SUCCESS：触发重建的分配用户任务成功后，POST_DESKTOP_DISCONNECTED：桌面断开连接后。
        /// </summary>
        [JsonProperty("life_cycle_type", NullValueHandling = NullValueHandling.Ignore)]
        public string LifeCycleType { get; set; }

        /// <summary>
        /// 时区。
        /// </summary>
        [JsonProperty("time_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeZone { get; set; }

        /// <summary>
        /// 任务类型，可选值为： - START：开机。 - STOP：关机。 - REBOOT：重启。 - HIBERNATE：休眠。 - REBUILD：重建系统盘。 - EXECUTE_SCRIPT：执行脚本。 - CREATE_SNAPSHOT：创建快照。 - DELETE_BLACK_ECS: 删除黑产ecs
        /// </summary>
        [JsonProperty("task_type", NullValueHandling = NullValueHandling.Ignore)]
        public TaskTypeEnum TaskType { get; set; }
        /// <summary>
        /// 任务名称。
        /// </summary>
        [JsonProperty("task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskName { get; set; }

        /// <summary>
        /// 是否强制执行，true表示强制执行，false表示不强制执行。
        /// </summary>
        [JsonProperty("force_execute", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForceExecute { get; set; }

        /// <summary>
        /// 描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 扩展参数，json格式。
        /// </summary>
        [JsonProperty("extra_params", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtraParams { get; set; }

        /// <summary>
        /// 定时任务应用的对象列表。
        /// </summary>
        [JsonProperty("apply_objects", NullValueHandling = NullValueHandling.Ignore)]
        public List<ApplyObject> ApplyObjects { get; set; }

        /// <summary>
        /// 触发式任务触发后，等待时长。
        /// </summary>
        [JsonProperty("wait_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? WaitTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateScheduledTasksReq {\n");
            sb.Append("  scheduledType: ").Append(ScheduledType).Append("\n");
            sb.Append("  dayInterval: ").Append(DayInterval).Append("\n");
            sb.Append("  weekList: ").Append(WeekList).Append("\n");
            sb.Append("  monthList: ").Append(MonthList).Append("\n");
            sb.Append("  dateList: ").Append(DateList).Append("\n");
            sb.Append("  scheduledDate: ").Append(ScheduledDate).Append("\n");
            sb.Append("  scheduledTime: ").Append(ScheduledTime).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  grayCount: ").Append(GrayCount).Append("\n");
            sb.Append("  grayDesktopIds: ").Append(GrayDesktopIds).Append("\n");
            sb.Append("  grayFailThreshold: ").Append(GrayFailThreshold).Append("\n");
            sb.Append("  lifeCycleType: ").Append(LifeCycleType).Append("\n");
            sb.Append("  timeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  taskType: ").Append(TaskType).Append("\n");
            sb.Append("  taskName: ").Append(TaskName).Append("\n");
            sb.Append("  forceExecute: ").Append(ForceExecute).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  extraParams: ").Append(ExtraParams).Append("\n");
            sb.Append("  applyObjects: ").Append(ApplyObjects).Append("\n");
            sb.Append("  waitTime: ").Append(WaitTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateScheduledTasksReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateScheduledTasksReq input)
        {
            if (input == null) return false;
            if (this.ScheduledType != input.ScheduledType) return false;
            if (this.DayInterval != input.DayInterval || (this.DayInterval != null && !this.DayInterval.Equals(input.DayInterval))) return false;
            if (this.WeekList != input.WeekList || (this.WeekList != null && !this.WeekList.Equals(input.WeekList))) return false;
            if (this.MonthList != input.MonthList || (this.MonthList != null && !this.MonthList.Equals(input.MonthList))) return false;
            if (this.DateList != input.DateList || (this.DateList != null && !this.DateList.Equals(input.DateList))) return false;
            if (this.ScheduledDate != input.ScheduledDate || (this.ScheduledDate != null && !this.ScheduledDate.Equals(input.ScheduledDate))) return false;
            if (this.ScheduledTime != input.ScheduledTime || (this.ScheduledTime != null && !this.ScheduledTime.Equals(input.ScheduledTime))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;
            if (this.GrayCount != input.GrayCount || (this.GrayCount != null && !this.GrayCount.Equals(input.GrayCount))) return false;
            if (this.GrayDesktopIds != input.GrayDesktopIds || (this.GrayDesktopIds != null && input.GrayDesktopIds != null && !this.GrayDesktopIds.SequenceEqual(input.GrayDesktopIds))) return false;
            if (this.GrayFailThreshold != input.GrayFailThreshold || (this.GrayFailThreshold != null && !this.GrayFailThreshold.Equals(input.GrayFailThreshold))) return false;
            if (this.LifeCycleType != input.LifeCycleType || (this.LifeCycleType != null && !this.LifeCycleType.Equals(input.LifeCycleType))) return false;
            if (this.TimeZone != input.TimeZone || (this.TimeZone != null && !this.TimeZone.Equals(input.TimeZone))) return false;
            if (this.TaskType != input.TaskType) return false;
            if (this.TaskName != input.TaskName || (this.TaskName != null && !this.TaskName.Equals(input.TaskName))) return false;
            if (this.ForceExecute != input.ForceExecute || (this.ForceExecute != null && !this.ForceExecute.Equals(input.ForceExecute))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.ExtraParams != input.ExtraParams || (this.ExtraParams != null && !this.ExtraParams.Equals(input.ExtraParams))) return false;
            if (this.ApplyObjects != input.ApplyObjects || (this.ApplyObjects != null && input.ApplyObjects != null && !this.ApplyObjects.SequenceEqual(input.ApplyObjects))) return false;
            if (this.WaitTime != input.WaitTime || (this.WaitTime != null && !this.WaitTime.Equals(input.WaitTime))) return false;

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
                hashCode = hashCode * 59 + this.ScheduledType.GetHashCode();
                if (this.DayInterval != null) hashCode = hashCode * 59 + this.DayInterval.GetHashCode();
                if (this.WeekList != null) hashCode = hashCode * 59 + this.WeekList.GetHashCode();
                if (this.MonthList != null) hashCode = hashCode * 59 + this.MonthList.GetHashCode();
                if (this.DateList != null) hashCode = hashCode * 59 + this.DateList.GetHashCode();
                if (this.ScheduledDate != null) hashCode = hashCode * 59 + this.ScheduledDate.GetHashCode();
                if (this.ScheduledTime != null) hashCode = hashCode * 59 + this.ScheduledTime.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                if (this.GrayCount != null) hashCode = hashCode * 59 + this.GrayCount.GetHashCode();
                if (this.GrayDesktopIds != null) hashCode = hashCode * 59 + this.GrayDesktopIds.GetHashCode();
                if (this.GrayFailThreshold != null) hashCode = hashCode * 59 + this.GrayFailThreshold.GetHashCode();
                if (this.LifeCycleType != null) hashCode = hashCode * 59 + this.LifeCycleType.GetHashCode();
                if (this.TimeZone != null) hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                hashCode = hashCode * 59 + this.TaskType.GetHashCode();
                if (this.TaskName != null) hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.ForceExecute != null) hashCode = hashCode * 59 + this.ForceExecute.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ExtraParams != null) hashCode = hashCode * 59 + this.ExtraParams.GetHashCode();
                if (this.ApplyObjects != null) hashCode = hashCode * 59 + this.ApplyObjects.GetHashCode();
                if (this.WaitTime != null) hashCode = hashCode * 59 + this.WaitTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
