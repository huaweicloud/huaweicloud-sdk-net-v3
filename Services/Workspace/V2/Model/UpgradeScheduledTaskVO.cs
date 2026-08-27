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
    /// 升级任务VO
    /// </summary>
    public class UpgradeScheduledTaskVO 
    {
        /// <summary>
        /// 执行周期类型：FIXED_TIME-指定时间 DAY-按天 WEEK-按周 MONTH-按月
        /// </summary>
        /// <value>执行周期类型：FIXED_TIME-指定时间 DAY-按天 WEEK-按周 MONTH-按月</value>
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

            private static readonly Dictionary<string, ScheduledTypeEnum> StaticFields =
            new Dictionary<string, ScheduledTypeEnum>()
            {
                { "FIXED_TIME", FIXED_TIME },
                { "DAY", DAY },
                { "WEEK", WEEK },
                { "MONTH", MONTH },
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
        /// 任务ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskName { get; set; }

        /// <summary>
        /// 任务类型：0-云桌面 1-应用服务器 2-镜像
        /// </summary>
        [JsonProperty("task_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? TaskType { get; set; }

        /// <summary>
        /// 执行周期类型：FIXED_TIME-指定时间 DAY-按天 WEEK-按周 MONTH-按月
        /// </summary>
        [JsonProperty("scheduled_type", NullValueHandling = NullValueHandling.Ignore)]
        public ScheduledTypeEnum ScheduledType { get; set; }
        /// <summary>
        /// 时区
        /// </summary>
        [JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)]
        public string Timezone { get; set; }

        /// <summary>
        /// 最近一次执行情况：SUCCESS-成功 FAILED-失败 RUNNING-执行中 WAITING-等待
        /// </summary>
        [JsonProperty("last_execute_status", NullValueHandling = NullValueHandling.Ignore)]
        public string LastExecuteStatus { get; set; }

        /// <summary>
        /// 下次执行时间
        /// </summary>
        [JsonProperty("next_execute_time", NullValueHandling = NullValueHandling.Ignore)]
        public string NextExecuteTime { get; set; }

        /// <summary>
        /// 启用状态：0-未启用 1-启用
        /// </summary>
        [JsonProperty("is_enable", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsEnable { get; set; }

        /// <summary>
        /// 目标版本
        /// </summary>
        [JsonProperty("target_version", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetVersion { get; set; }

        /// <summary>
        /// 执行策略：0-全量下发 1-灰度下发
        /// </summary>
        [JsonProperty("execute_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExecuteStrategy { get; set; }

        /// <summary>
        /// 任务描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradeScheduledTaskVO {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  taskName: ").Append(TaskName).Append("\n");
            sb.Append("  taskType: ").Append(TaskType).Append("\n");
            sb.Append("  scheduledType: ").Append(ScheduledType).Append("\n");
            sb.Append("  timezone: ").Append(Timezone).Append("\n");
            sb.Append("  lastExecuteStatus: ").Append(LastExecuteStatus).Append("\n");
            sb.Append("  nextExecuteTime: ").Append(NextExecuteTime).Append("\n");
            sb.Append("  isEnable: ").Append(IsEnable).Append("\n");
            sb.Append("  targetVersion: ").Append(TargetVersion).Append("\n");
            sb.Append("  executeStrategy: ").Append(ExecuteStrategy).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpgradeScheduledTaskVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpgradeScheduledTaskVO input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.TaskName != input.TaskName || (this.TaskName != null && !this.TaskName.Equals(input.TaskName))) return false;
            if (this.TaskType != input.TaskType || (this.TaskType != null && !this.TaskType.Equals(input.TaskType))) return false;
            if (this.ScheduledType != input.ScheduledType) return false;
            if (this.Timezone != input.Timezone || (this.Timezone != null && !this.Timezone.Equals(input.Timezone))) return false;
            if (this.LastExecuteStatus != input.LastExecuteStatus || (this.LastExecuteStatus != null && !this.LastExecuteStatus.Equals(input.LastExecuteStatus))) return false;
            if (this.NextExecuteTime != input.NextExecuteTime || (this.NextExecuteTime != null && !this.NextExecuteTime.Equals(input.NextExecuteTime))) return false;
            if (this.IsEnable != input.IsEnable || (this.IsEnable != null && !this.IsEnable.Equals(input.IsEnable))) return false;
            if (this.TargetVersion != input.TargetVersion || (this.TargetVersion != null && !this.TargetVersion.Equals(input.TargetVersion))) return false;
            if (this.ExecuteStrategy != input.ExecuteStrategy || (this.ExecuteStrategy != null && !this.ExecuteStrategy.Equals(input.ExecuteStrategy))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                if (this.TaskType != null) hashCode = hashCode * 59 + this.TaskType.GetHashCode();
                hashCode = hashCode * 59 + this.ScheduledType.GetHashCode();
                if (this.Timezone != null) hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.LastExecuteStatus != null) hashCode = hashCode * 59 + this.LastExecuteStatus.GetHashCode();
                if (this.NextExecuteTime != null) hashCode = hashCode * 59 + this.NextExecuteTime.GetHashCode();
                if (this.IsEnable != null) hashCode = hashCode * 59 + this.IsEnable.GetHashCode();
                if (this.TargetVersion != null) hashCode = hashCode * 59 + this.TargetVersion.GetHashCode();
                if (this.ExecuteStrategy != null) hashCode = hashCode * 59 + this.ExecuteStrategy.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
