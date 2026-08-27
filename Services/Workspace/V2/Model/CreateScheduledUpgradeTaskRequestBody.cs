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
    /// 新增升级任务请求
    /// </summary>
    public class CreateScheduledUpgradeTaskRequestBody 
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
        /// 周期按周时：取值1~7，英文逗号分隔，如1,2,7
        /// </summary>
        [JsonProperty("week_list", NullValueHandling = NullValueHandling.Ignore)]
        public string WeekList { get; set; }

        /// <summary>
        /// 周期按月时：取值1~12，英文逗号分隔
        /// </summary>
        [JsonProperty("month_list", NullValueHandling = NullValueHandling.Ignore)]
        public string MonthList { get; set; }

        /// <summary>
        /// 周期按月时：取值1~31及L(代表当月最后一天)
        /// </summary>
        [JsonProperty("date_list", NullValueHandling = NullValueHandling.Ignore)]
        public string DateList { get; set; }

        /// <summary>
        /// 按天跳过天数
        /// </summary>
        [JsonProperty("day_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? DayInterval { get; set; }

        /// <summary>
        /// 周期指定时间时：表示指定的日期
        /// </summary>
        [JsonProperty("scheduled_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ScheduledDate { get; set; }

        /// <summary>
        /// 指定的执行时间点
        /// </summary>
        [JsonProperty("scheduled_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ScheduledTime { get; set; }

        /// <summary>
        /// 是否强制升级：0-否 1-是
        /// </summary>
        [JsonProperty("is_force_execute", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsForceExecute { get; set; }

        /// <summary>
        /// 低于此版本升级
        /// </summary>
        [JsonProperty("min_version", NullValueHandling = NullValueHandling.Ignore)]
        public string MinVersion { get; set; }

        /// <summary>
        /// 升级目标版本
        /// </summary>
        [JsonProperty("target_version", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetVersion { get; set; }

        /// <summary>
        /// 过期时间开启：0-未开启 1-开启
        /// </summary>
        [JsonProperty("expire_enable", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpireEnable { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 是否通知：0-不通知 1-通知
        /// </summary>
        [JsonProperty("is_notify", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsNotify { get; set; }

        /// <summary>
        /// 扩展参数（JSON格式）
        /// </summary>
        [JsonProperty("extra_params", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtraParams { get; set; }

        /// <summary>
        /// 执行策略：0-全量下发 1-灰度下发
        /// </summary>
        [JsonProperty("execute_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExecuteStrategy { get; set; }

        /// <summary>
        /// 灰度规则：0-确定 1-随机（execute_strategy&#x3D;1时使用）
        /// </summary>
        [JsonProperty("grayscale_rule", NullValueHandling = NullValueHandling.Ignore)]
        public int? GrayscaleRule { get; set; }

        /// <summary>
        /// 随机首批执行数
        /// </summary>
        [JsonProperty("random_first_batch_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? RandomFirstBatchCount { get; set; }

        /// <summary>
        /// 灰度对象id列表（JSON数组格式）
        /// </summary>
        [JsonProperty("gray_object_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string GrayObjectIds { get; set; }

        /// <summary>
        /// 首批执行失败阈值
        /// </summary>
        [JsonProperty("gray_fail_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? GrayFailThreshold { get; set; }

        /// <summary>
        /// 时间窗结束时间
        /// </summary>
        [JsonProperty("scheduled_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ScheduledEndTime { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        [JsonProperty("is_enable", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsEnable { get; set; }

        /// <summary>
        /// 任务描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 应用对象列表
        /// </summary>
        [JsonProperty("apply_objects", NullValueHandling = NullValueHandling.Ignore)]
        public List<TaskApplyObjectInfo> ApplyObjects { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateScheduledUpgradeTaskRequestBody {\n");
            sb.Append("  taskName: ").Append(TaskName).Append("\n");
            sb.Append("  taskType: ").Append(TaskType).Append("\n");
            sb.Append("  scheduledType: ").Append(ScheduledType).Append("\n");
            sb.Append("  timezone: ").Append(Timezone).Append("\n");
            sb.Append("  weekList: ").Append(WeekList).Append("\n");
            sb.Append("  monthList: ").Append(MonthList).Append("\n");
            sb.Append("  dateList: ").Append(DateList).Append("\n");
            sb.Append("  dayInterval: ").Append(DayInterval).Append("\n");
            sb.Append("  scheduledDate: ").Append(ScheduledDate).Append("\n");
            sb.Append("  scheduledTime: ").Append(ScheduledTime).Append("\n");
            sb.Append("  isForceExecute: ").Append(IsForceExecute).Append("\n");
            sb.Append("  minVersion: ").Append(MinVersion).Append("\n");
            sb.Append("  targetVersion: ").Append(TargetVersion).Append("\n");
            sb.Append("  expireEnable: ").Append(ExpireEnable).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  isNotify: ").Append(IsNotify).Append("\n");
            sb.Append("  extraParams: ").Append(ExtraParams).Append("\n");
            sb.Append("  executeStrategy: ").Append(ExecuteStrategy).Append("\n");
            sb.Append("  grayscaleRule: ").Append(GrayscaleRule).Append("\n");
            sb.Append("  randomFirstBatchCount: ").Append(RandomFirstBatchCount).Append("\n");
            sb.Append("  grayObjectIds: ").Append(GrayObjectIds).Append("\n");
            sb.Append("  grayFailThreshold: ").Append(GrayFailThreshold).Append("\n");
            sb.Append("  scheduledEndTime: ").Append(ScheduledEndTime).Append("\n");
            sb.Append("  isEnable: ").Append(IsEnable).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  applyObjects: ").Append(ApplyObjects).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateScheduledUpgradeTaskRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateScheduledUpgradeTaskRequestBody input)
        {
            if (input == null) return false;
            if (this.TaskName != input.TaskName || (this.TaskName != null && !this.TaskName.Equals(input.TaskName))) return false;
            if (this.TaskType != input.TaskType || (this.TaskType != null && !this.TaskType.Equals(input.TaskType))) return false;
            if (this.ScheduledType != input.ScheduledType) return false;
            if (this.Timezone != input.Timezone || (this.Timezone != null && !this.Timezone.Equals(input.Timezone))) return false;
            if (this.WeekList != input.WeekList || (this.WeekList != null && !this.WeekList.Equals(input.WeekList))) return false;
            if (this.MonthList != input.MonthList || (this.MonthList != null && !this.MonthList.Equals(input.MonthList))) return false;
            if (this.DateList != input.DateList || (this.DateList != null && !this.DateList.Equals(input.DateList))) return false;
            if (this.DayInterval != input.DayInterval || (this.DayInterval != null && !this.DayInterval.Equals(input.DayInterval))) return false;
            if (this.ScheduledDate != input.ScheduledDate || (this.ScheduledDate != null && !this.ScheduledDate.Equals(input.ScheduledDate))) return false;
            if (this.ScheduledTime != input.ScheduledTime || (this.ScheduledTime != null && !this.ScheduledTime.Equals(input.ScheduledTime))) return false;
            if (this.IsForceExecute != input.IsForceExecute || (this.IsForceExecute != null && !this.IsForceExecute.Equals(input.IsForceExecute))) return false;
            if (this.MinVersion != input.MinVersion || (this.MinVersion != null && !this.MinVersion.Equals(input.MinVersion))) return false;
            if (this.TargetVersion != input.TargetVersion || (this.TargetVersion != null && !this.TargetVersion.Equals(input.TargetVersion))) return false;
            if (this.ExpireEnable != input.ExpireEnable || (this.ExpireEnable != null && !this.ExpireEnable.Equals(input.ExpireEnable))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;
            if (this.IsNotify != input.IsNotify || (this.IsNotify != null && !this.IsNotify.Equals(input.IsNotify))) return false;
            if (this.ExtraParams != input.ExtraParams || (this.ExtraParams != null && !this.ExtraParams.Equals(input.ExtraParams))) return false;
            if (this.ExecuteStrategy != input.ExecuteStrategy || (this.ExecuteStrategy != null && !this.ExecuteStrategy.Equals(input.ExecuteStrategy))) return false;
            if (this.GrayscaleRule != input.GrayscaleRule || (this.GrayscaleRule != null && !this.GrayscaleRule.Equals(input.GrayscaleRule))) return false;
            if (this.RandomFirstBatchCount != input.RandomFirstBatchCount || (this.RandomFirstBatchCount != null && !this.RandomFirstBatchCount.Equals(input.RandomFirstBatchCount))) return false;
            if (this.GrayObjectIds != input.GrayObjectIds || (this.GrayObjectIds != null && !this.GrayObjectIds.Equals(input.GrayObjectIds))) return false;
            if (this.GrayFailThreshold != input.GrayFailThreshold || (this.GrayFailThreshold != null && !this.GrayFailThreshold.Equals(input.GrayFailThreshold))) return false;
            if (this.ScheduledEndTime != input.ScheduledEndTime || (this.ScheduledEndTime != null && !this.ScheduledEndTime.Equals(input.ScheduledEndTime))) return false;
            if (this.IsEnable != input.IsEnable || (this.IsEnable != null && !this.IsEnable.Equals(input.IsEnable))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.ApplyObjects != input.ApplyObjects || (this.ApplyObjects != null && input.ApplyObjects != null && !this.ApplyObjects.SequenceEqual(input.ApplyObjects))) return false;

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
                if (this.TaskName != null) hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.TaskType != null) hashCode = hashCode * 59 + this.TaskType.GetHashCode();
                hashCode = hashCode * 59 + this.ScheduledType.GetHashCode();
                if (this.Timezone != null) hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.WeekList != null) hashCode = hashCode * 59 + this.WeekList.GetHashCode();
                if (this.MonthList != null) hashCode = hashCode * 59 + this.MonthList.GetHashCode();
                if (this.DateList != null) hashCode = hashCode * 59 + this.DateList.GetHashCode();
                if (this.DayInterval != null) hashCode = hashCode * 59 + this.DayInterval.GetHashCode();
                if (this.ScheduledDate != null) hashCode = hashCode * 59 + this.ScheduledDate.GetHashCode();
                if (this.ScheduledTime != null) hashCode = hashCode * 59 + this.ScheduledTime.GetHashCode();
                if (this.IsForceExecute != null) hashCode = hashCode * 59 + this.IsForceExecute.GetHashCode();
                if (this.MinVersion != null) hashCode = hashCode * 59 + this.MinVersion.GetHashCode();
                if (this.TargetVersion != null) hashCode = hashCode * 59 + this.TargetVersion.GetHashCode();
                if (this.ExpireEnable != null) hashCode = hashCode * 59 + this.ExpireEnable.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                if (this.IsNotify != null) hashCode = hashCode * 59 + this.IsNotify.GetHashCode();
                if (this.ExtraParams != null) hashCode = hashCode * 59 + this.ExtraParams.GetHashCode();
                if (this.ExecuteStrategy != null) hashCode = hashCode * 59 + this.ExecuteStrategy.GetHashCode();
                if (this.GrayscaleRule != null) hashCode = hashCode * 59 + this.GrayscaleRule.GetHashCode();
                if (this.RandomFirstBatchCount != null) hashCode = hashCode * 59 + this.RandomFirstBatchCount.GetHashCode();
                if (this.GrayObjectIds != null) hashCode = hashCode * 59 + this.GrayObjectIds.GetHashCode();
                if (this.GrayFailThreshold != null) hashCode = hashCode * 59 + this.GrayFailThreshold.GetHashCode();
                if (this.ScheduledEndTime != null) hashCode = hashCode * 59 + this.ScheduledEndTime.GetHashCode();
                if (this.IsEnable != null) hashCode = hashCode * 59 + this.IsEnable.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ApplyObjects != null) hashCode = hashCode * 59 + this.ApplyObjects.GetHashCode();
                return hashCode;
            }
        }
    }
}
