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
    /// Request Object
    /// </summary>
    public class ListUpgradeTasksRequest 
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
        /// 任务id
        /// </summary>
        [SDKProperty("task_id", IsQuery = true)]
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// 任务名称（支持模糊查询）
        /// </summary>
        [SDKProperty("task_name", IsQuery = true)]
        [JsonProperty("task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskName { get; set; }

        /// <summary>
        /// 任务类型：0-云桌面 1-应用服务器 2-镜像
        /// </summary>
        [SDKProperty("task_type", IsQuery = true)]
        [JsonProperty("task_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? TaskType { get; set; }

        /// <summary>
        /// 执行周期类型：FIXED_TIME-指定时间 DAY-按天 WEEK-按周 MONTH-按月
        /// </summary>
        [SDKProperty("scheduled_type", IsQuery = true)]
        [JsonProperty("scheduled_type", NullValueHandling = NullValueHandling.Ignore)]
        public ScheduledTypeEnum ScheduledType { get; set; }
        /// <summary>
        /// 启用状态：0-未启用 1-启用
        /// </summary>
        [SDKProperty("is_enable", IsQuery = true)]
        [JsonProperty("is_enable", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsEnable { get; set; }

        /// <summary>
        /// 上次执行状态
        /// </summary>
        [SDKProperty("last_execute_status", IsQuery = true)]
        [JsonProperty("last_execute_status", NullValueHandling = NullValueHandling.Ignore)]
        public string LastExecuteStatus { get; set; }

        /// <summary>
        /// 偏移量，默认0
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每页数量，默认10，最大100
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListUpgradeTasksRequest {\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  taskName: ").Append(TaskName).Append("\n");
            sb.Append("  taskType: ").Append(TaskType).Append("\n");
            sb.Append("  scheduledType: ").Append(ScheduledType).Append("\n");
            sb.Append("  isEnable: ").Append(IsEnable).Append("\n");
            sb.Append("  lastExecuteStatus: ").Append(LastExecuteStatus).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListUpgradeTasksRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListUpgradeTasksRequest input)
        {
            if (input == null) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.TaskName != input.TaskName || (this.TaskName != null && !this.TaskName.Equals(input.TaskName))) return false;
            if (this.TaskType != input.TaskType || (this.TaskType != null && !this.TaskType.Equals(input.TaskType))) return false;
            if (this.ScheduledType != input.ScheduledType) return false;
            if (this.IsEnable != input.IsEnable || (this.IsEnable != null && !this.IsEnable.Equals(input.IsEnable))) return false;
            if (this.LastExecuteStatus != input.LastExecuteStatus || (this.LastExecuteStatus != null && !this.LastExecuteStatus.Equals(input.LastExecuteStatus))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.TaskName != null) hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.TaskType != null) hashCode = hashCode * 59 + this.TaskType.GetHashCode();
                hashCode = hashCode * 59 + this.ScheduledType.GetHashCode();
                if (this.IsEnable != null) hashCode = hashCode * 59 + this.IsEnable.GetHashCode();
                if (this.LastExecuteStatus != null) hashCode = hashCode * 59 + this.LastExecuteStatus.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
