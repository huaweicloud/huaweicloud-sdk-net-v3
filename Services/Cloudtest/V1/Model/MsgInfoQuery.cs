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
    public class MsgInfoQuery 
    {
        /// <summary>
        /// Defines alertTypes
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<AlertTypesEnum>))]
        public class AlertTypesEnum
        {
            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            public static readonly AlertTypesEnum _1 = new AlertTypesEnum("1");

            /// <summary>
            /// Enum _10 for value: 10
            /// </summary>
            public static readonly AlertTypesEnum _10 = new AlertTypesEnum("10");

            /// <summary>
            /// Enum _11 for value: 11
            /// </summary>
            public static readonly AlertTypesEnum _11 = new AlertTypesEnum("11");

            /// <summary>
            /// Enum _12 for value: 12
            /// </summary>
            public static readonly AlertTypesEnum _12 = new AlertTypesEnum("12");

            /// <summary>
            /// Enum _14 for value: 14
            /// </summary>
            public static readonly AlertTypesEnum _14 = new AlertTypesEnum("14");

            /// <summary>
            /// Enum _16 for value: 16
            /// </summary>
            public static readonly AlertTypesEnum _16 = new AlertTypesEnum("16");

            /// <summary>
            /// Enum _2 for value: 2
            /// </summary>
            public static readonly AlertTypesEnum _2 = new AlertTypesEnum("2");

            /// <summary>
            /// Enum _3 for value: 3
            /// </summary>
            public static readonly AlertTypesEnum _3 = new AlertTypesEnum("3");

            /// <summary>
            /// Enum _4 for value: 4
            /// </summary>
            public static readonly AlertTypesEnum _4 = new AlertTypesEnum("4");

            /// <summary>
            /// Enum _5 for value: 5
            /// </summary>
            public static readonly AlertTypesEnum _5 = new AlertTypesEnum("5");

            /// <summary>
            /// Enum _6 for value: 6
            /// </summary>
            public static readonly AlertTypesEnum _6 = new AlertTypesEnum("6");

            /// <summary>
            /// Enum _7 for value: 7
            /// </summary>
            public static readonly AlertTypesEnum _7 = new AlertTypesEnum("7");

            /// <summary>
            /// Enum _9 for value: 9
            /// </summary>
            public static readonly AlertTypesEnum _9 = new AlertTypesEnum("9");

            private static readonly Dictionary<string, AlertTypesEnum> StaticFields =
            new Dictionary<string, AlertTypesEnum>()
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

            public AlertTypesEnum()
            {

            }

            public AlertTypesEnum(string value)
            {
                _value = value;
            }

            public static AlertTypesEnum FromValue(string value)
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

                if (this.Equals(obj as AlertTypesEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AlertTypesEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AlertTypesEnum a, AlertTypesEnum b)
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

            public static bool operator !=(AlertTypesEnum a, AlertTypesEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 发送类型
        /// </summary>
        /// <value>发送类型</value>
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
        /// 告警类型
        /// </summary>
        [JsonProperty("alert_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<AlertTypesEnum> AlertTypes { get; set; }
        /// <summary>
        /// 用例id
        /// </summary>
        [JsonProperty("case_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CaseId { get; set; }

        /// <summary>
        /// 用例名
        /// </summary>
        [JsonProperty("case_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CaseName { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("page_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 发送类型
        /// </summary>
        [JsonProperty("send_alert_type", NullValueHandling = NullValueHandling.Ignore)]
        public SendAlertTypeEnum SendAlertType { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTime { get; set; }

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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MsgInfoQuery {\n");
            sb.Append("  alertTypes: ").Append(AlertTypes).Append("\n");
            sb.Append("  caseId: ").Append(CaseId).Append("\n");
            sb.Append("  caseName: ").Append(CaseName).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  pageNum: ").Append(PageNum).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("  sendAlertType: ").Append(SendAlertType).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  taskName: ").Append(TaskName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MsgInfoQuery);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MsgInfoQuery input)
        {
            if (input == null) return false;
            if (this.AlertTypes != input.AlertTypes || (this.AlertTypes != null && input.AlertTypes != null && !this.AlertTypes.SequenceEqual(input.AlertTypes))) return false;
            if (this.CaseId != input.CaseId || (this.CaseId != null && !this.CaseId.Equals(input.CaseId))) return false;
            if (this.CaseName != input.CaseName || (this.CaseName != null && !this.CaseName.Equals(input.CaseName))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.PageNum != input.PageNum || (this.PageNum != null && !this.PageNum.Equals(input.PageNum))) return false;
            if (this.PageSize != input.PageSize || (this.PageSize != null && !this.PageSize.Equals(input.PageSize))) return false;
            if (this.SendAlertType != input.SendAlertType) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.TaskName != input.TaskName || (this.TaskName != null && !this.TaskName.Equals(input.TaskName))) return false;

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
                hashCode = hashCode * 59 + this.AlertTypes.GetHashCode();
                if (this.CaseId != null) hashCode = hashCode * 59 + this.CaseId.GetHashCode();
                if (this.CaseName != null) hashCode = hashCode * 59 + this.CaseName.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.PageNum != null) hashCode = hashCode * 59 + this.PageNum.GetHashCode();
                if (this.PageSize != null) hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                hashCode = hashCode * 59 + this.SendAlertType.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.TaskName != null) hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                return hashCode;
            }
        }
    }
}
