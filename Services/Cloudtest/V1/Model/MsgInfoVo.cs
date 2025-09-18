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
    /// 
    /// </summary>
    public class MsgInfoVo 
    {
        /// <summary>
        /// 告警类型
        /// </summary>
        /// <value>告警类型</value>
        [JsonConverter(typeof(EnumClassConverter<AlertTypeEnum>))]
        public class AlertTypeEnum
        {
            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            public static readonly AlertTypeEnum _1 = new AlertTypeEnum("1");

            /// <summary>
            /// Enum _10 for value: 10
            /// </summary>
            public static readonly AlertTypeEnum _10 = new AlertTypeEnum("10");

            /// <summary>
            /// Enum _11 for value: 11
            /// </summary>
            public static readonly AlertTypeEnum _11 = new AlertTypeEnum("11");

            /// <summary>
            /// Enum _12 for value: 12
            /// </summary>
            public static readonly AlertTypeEnum _12 = new AlertTypeEnum("12");

            /// <summary>
            /// Enum _14 for value: 14
            /// </summary>
            public static readonly AlertTypeEnum _14 = new AlertTypeEnum("14");

            /// <summary>
            /// Enum _16 for value: 16
            /// </summary>
            public static readonly AlertTypeEnum _16 = new AlertTypeEnum("16");

            /// <summary>
            /// Enum _2 for value: 2
            /// </summary>
            public static readonly AlertTypeEnum _2 = new AlertTypeEnum("2");

            /// <summary>
            /// Enum _3 for value: 3
            /// </summary>
            public static readonly AlertTypeEnum _3 = new AlertTypeEnum("3");

            /// <summary>
            /// Enum _4 for value: 4
            /// </summary>
            public static readonly AlertTypeEnum _4 = new AlertTypeEnum("4");

            /// <summary>
            /// Enum _5 for value: 5
            /// </summary>
            public static readonly AlertTypeEnum _5 = new AlertTypeEnum("5");

            /// <summary>
            /// Enum _6 for value: 6
            /// </summary>
            public static readonly AlertTypeEnum _6 = new AlertTypeEnum("6");

            /// <summary>
            /// Enum _7 for value: 7
            /// </summary>
            public static readonly AlertTypeEnum _7 = new AlertTypeEnum("7");

            /// <summary>
            /// Enum _9 for value: 9
            /// </summary>
            public static readonly AlertTypeEnum _9 = new AlertTypeEnum("9");

            private static readonly Dictionary<string, AlertTypeEnum> StaticFields =
            new Dictionary<string, AlertTypeEnum>()
            {
                { "1", _1 },
                { "10", _10 },
                { "11", _11 },
                { "12", _12 },
                { "14", _14 },
                { "16", _16 },
                { "2", _2 },
                { "3", _3 },
                { "4", _4 },
                { "5", _5 },
                { "6", _6 },
                { "7", _7 },
                { "9", _9 },
            };

            private string _value;

            public AlertTypeEnum()
            {

            }

            public AlertTypeEnum(string value)
            {
                _value = value;
            }

            public static AlertTypeEnum FromValue(string value)
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

                if (this.Equals(obj as AlertTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AlertTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AlertTypeEnum a, AlertTypeEnum b)
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

            public static bool operator !=(AlertTypeEnum a, AlertTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 发送告警类型
        /// </summary>
        /// <value>发送告警类型</value>
        [JsonConverter(typeof(EnumClassConverter<SendAlertTypeEnum>))]
        public class SendAlertTypeEnum
        {
            /// <summary>
            /// Enum LEVEL_ALERT for value: LEVEL_ALERT
            /// </summary>
            public static readonly SendAlertTypeEnum LEVEL_ALERT = new SendAlertTypeEnum("LEVEL_ALERT");

            /// <summary>
            /// Enum OPERATION_NOTICE for value: OPERATION_NOTICE
            /// </summary>
            public static readonly SendAlertTypeEnum OPERATION_NOTICE = new SendAlertTypeEnum("OPERATION_NOTICE");

            /// <summary>
            /// Enum RECOVER_ALERT for value: RECOVER_ALERT
            /// </summary>
            public static readonly SendAlertTypeEnum RECOVER_ALERT = new SendAlertTypeEnum("RECOVER_ALERT");

            /// <summary>
            /// Enum RESTRAINING for value: RESTRAINING
            /// </summary>
            public static readonly SendAlertTypeEnum RESTRAINING = new SendAlertTypeEnum("RESTRAINING");

            /// <summary>
            /// Enum RESTRAIN_ALERT for value: RESTRAIN_ALERT
            /// </summary>
            public static readonly SendAlertTypeEnum RESTRAIN_ALERT = new SendAlertTypeEnum("RESTRAIN_ALERT");

            private static readonly Dictionary<string, SendAlertTypeEnum> StaticFields =
            new Dictionary<string, SendAlertTypeEnum>()
            {
                { "LEVEL_ALERT", LEVEL_ALERT },
                { "OPERATION_NOTICE", OPERATION_NOTICE },
                { "RECOVER_ALERT", RECOVER_ALERT },
                { "RESTRAINING", RESTRAINING },
                { "RESTRAIN_ALERT", RESTRAIN_ALERT },
            };

            private string _value;

            public SendAlertTypeEnum()
            {

            }

            public SendAlertTypeEnum(string value)
            {
                _value = value;
            }

            public static SendAlertTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SendAlertTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SendAlertTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SendAlertTypeEnum a, SendAlertTypeEnum b)
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

            public static bool operator !=(SendAlertTypeEnum a, SendAlertTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 告警渠道
        /// </summary>
        [JsonProperty("alert_channels", NullValueHandling = NullValueHandling.Ignore)]
        public string AlertChannels { get; set; }

        /// <summary>
        /// 告警分组
        /// </summary>
        [JsonProperty("alert_groups", NullValueHandling = NullValueHandling.Ignore)]
        public string AlertGroups { get; set; }

        /// <summary>
        /// 告警级别
        /// </summary>
        [JsonProperty("alert_level", NullValueHandling = NullValueHandling.Ignore)]
        public int? AlertLevel { get; set; }

        /// <summary>
        /// 总告警次数
        /// </summary>
        [JsonProperty("alert_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? AlertNum { get; set; }

        /// <summary>
        /// 告警时间
        /// </summary>
        [JsonProperty("alert_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? AlertTime { get; set; }

        /// <summary>
        /// 告警类型
        /// </summary>
        [JsonProperty("alert_type", NullValueHandling = NullValueHandling.Ignore)]
        public AlertTypeEnum AlertType { get; set; }
        /// <summary>
        /// 告警内容
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        /// <summary>
        /// MsgInfo的id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 链接
        /// </summary>
        [JsonProperty("link", NullValueHandling = NullValueHandling.Ignore)]
        public string Link { get; set; }

        /// <summary>
        /// 执行机区域
        /// </summary>
        [JsonProperty("location_names", NullValueHandling = NullValueHandling.Ignore)]
        public string LocationNames { get; set; }

        /// <summary>
        /// 发送告警类型
        /// </summary>
        [JsonProperty("send_alert_type", NullValueHandling = NullValueHandling.Ignore)]
        public SendAlertTypeEnum SendAlertType { get; set; }
        /// <summary>
        /// 子任务用例id
        /// </summary>
        [JsonProperty("sub_task_case_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubTaskCaseId { get; set; }

        /// <summary>
        /// 子任务用例开始时间
        /// </summary>
        [JsonProperty("sub_task_case_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? SubTaskCaseStartTime { get; set; }

        /// <summary>
        /// 子任务id
        /// </summary>
        [JsonProperty("sub_task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubTaskId { get; set; }

        /// <summary>
        /// 子任务开始时间
        /// </summary>
        [JsonProperty("sub_task_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? SubTaskStartTime { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// 任务名
        /// </summary>
        [JsonProperty("task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskName { get; set; }

        /// <summary>
        /// 用例id
        /// </summary>
        [JsonProperty("test_case_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TestCaseId { get; set; }

        /// <summary>
        /// 用例名称
        /// </summary>
        [JsonProperty("test_case_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TestCaseName { get; set; }

        /// <summary>
        /// 测试套类型
        /// </summary>
        [JsonProperty("test_suite_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? TestSuiteType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MsgInfoVo {\n");
            sb.Append("  alertChannels: ").Append(AlertChannels).Append("\n");
            sb.Append("  alertGroups: ").Append(AlertGroups).Append("\n");
            sb.Append("  alertLevel: ").Append(AlertLevel).Append("\n");
            sb.Append("  alertNum: ").Append(AlertNum).Append("\n");
            sb.Append("  alertTime: ").Append(AlertTime).Append("\n");
            sb.Append("  alertType: ").Append(AlertType).Append("\n");
            sb.Append("  content: ").Append(Content).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  link: ").Append(Link).Append("\n");
            sb.Append("  locationNames: ").Append(LocationNames).Append("\n");
            sb.Append("  sendAlertType: ").Append(SendAlertType).Append("\n");
            sb.Append("  subTaskCaseId: ").Append(SubTaskCaseId).Append("\n");
            sb.Append("  subTaskCaseStartTime: ").Append(SubTaskCaseStartTime).Append("\n");
            sb.Append("  subTaskId: ").Append(SubTaskId).Append("\n");
            sb.Append("  subTaskStartTime: ").Append(SubTaskStartTime).Append("\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  taskName: ").Append(TaskName).Append("\n");
            sb.Append("  testCaseId: ").Append(TestCaseId).Append("\n");
            sb.Append("  testCaseName: ").Append(TestCaseName).Append("\n");
            sb.Append("  testSuiteType: ").Append(TestSuiteType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MsgInfoVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MsgInfoVo input)
        {
            if (input == null) return false;
            if (this.AlertChannels != input.AlertChannels || (this.AlertChannels != null && !this.AlertChannels.Equals(input.AlertChannels))) return false;
            if (this.AlertGroups != input.AlertGroups || (this.AlertGroups != null && !this.AlertGroups.Equals(input.AlertGroups))) return false;
            if (this.AlertLevel != input.AlertLevel || (this.AlertLevel != null && !this.AlertLevel.Equals(input.AlertLevel))) return false;
            if (this.AlertNum != input.AlertNum || (this.AlertNum != null && !this.AlertNum.Equals(input.AlertNum))) return false;
            if (this.AlertTime != input.AlertTime || (this.AlertTime != null && !this.AlertTime.Equals(input.AlertTime))) return false;
            if (this.AlertType != input.AlertType) return false;
            if (this.Content != input.Content || (this.Content != null && !this.Content.Equals(input.Content))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Link != input.Link || (this.Link != null && !this.Link.Equals(input.Link))) return false;
            if (this.LocationNames != input.LocationNames || (this.LocationNames != null && !this.LocationNames.Equals(input.LocationNames))) return false;
            if (this.SendAlertType != input.SendAlertType) return false;
            if (this.SubTaskCaseId != input.SubTaskCaseId || (this.SubTaskCaseId != null && !this.SubTaskCaseId.Equals(input.SubTaskCaseId))) return false;
            if (this.SubTaskCaseStartTime != input.SubTaskCaseStartTime || (this.SubTaskCaseStartTime != null && !this.SubTaskCaseStartTime.Equals(input.SubTaskCaseStartTime))) return false;
            if (this.SubTaskId != input.SubTaskId || (this.SubTaskId != null && !this.SubTaskId.Equals(input.SubTaskId))) return false;
            if (this.SubTaskStartTime != input.SubTaskStartTime || (this.SubTaskStartTime != null && !this.SubTaskStartTime.Equals(input.SubTaskStartTime))) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.TaskName != input.TaskName || (this.TaskName != null && !this.TaskName.Equals(input.TaskName))) return false;
            if (this.TestCaseId != input.TestCaseId || (this.TestCaseId != null && !this.TestCaseId.Equals(input.TestCaseId))) return false;
            if (this.TestCaseName != input.TestCaseName || (this.TestCaseName != null && !this.TestCaseName.Equals(input.TestCaseName))) return false;
            if (this.TestSuiteType != input.TestSuiteType || (this.TestSuiteType != null && !this.TestSuiteType.Equals(input.TestSuiteType))) return false;

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
                if (this.AlertChannels != null) hashCode = hashCode * 59 + this.AlertChannels.GetHashCode();
                if (this.AlertGroups != null) hashCode = hashCode * 59 + this.AlertGroups.GetHashCode();
                if (this.AlertLevel != null) hashCode = hashCode * 59 + this.AlertLevel.GetHashCode();
                if (this.AlertNum != null) hashCode = hashCode * 59 + this.AlertNum.GetHashCode();
                if (this.AlertTime != null) hashCode = hashCode * 59 + this.AlertTime.GetHashCode();
                hashCode = hashCode * 59 + this.AlertType.GetHashCode();
                if (this.Content != null) hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Link != null) hashCode = hashCode * 59 + this.Link.GetHashCode();
                if (this.LocationNames != null) hashCode = hashCode * 59 + this.LocationNames.GetHashCode();
                hashCode = hashCode * 59 + this.SendAlertType.GetHashCode();
                if (this.SubTaskCaseId != null) hashCode = hashCode * 59 + this.SubTaskCaseId.GetHashCode();
                if (this.SubTaskCaseStartTime != null) hashCode = hashCode * 59 + this.SubTaskCaseStartTime.GetHashCode();
                if (this.SubTaskId != null) hashCode = hashCode * 59 + this.SubTaskId.GetHashCode();
                if (this.SubTaskStartTime != null) hashCode = hashCode * 59 + this.SubTaskStartTime.GetHashCode();
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.TaskName != null) hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.TestCaseId != null) hashCode = hashCode * 59 + this.TestCaseId.GetHashCode();
                if (this.TestCaseName != null) hashCode = hashCode * 59 + this.TestCaseName.GetHashCode();
                if (this.TestSuiteType != null) hashCode = hashCode * 59 + this.TestSuiteType.GetHashCode();
                return hashCode;
            }
        }
    }
}
