using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// 调度配置
    /// </summary>
    public class SchedulerConfigBase 
    {
        /// <summary>
        /// 文件类型
        /// </summary>
        /// <value>文件类型</value>
        [JsonConverter(typeof(EnumClassConverter<FormatEnum>))]
        public class FormatEnum
        {
            /// <summary>
            /// Enum PDF for value: PDF
            /// </summary>
            public static readonly FormatEnum PDF = new FormatEnum("PDF");

            /// <summary>
            /// Enum ZIP for value: ZIP
            /// </summary>
            public static readonly FormatEnum ZIP = new FormatEnum("ZIP");

            private static readonly Dictionary<string, FormatEnum> StaticFields =
            new Dictionary<string, FormatEnum>()
            {
                { "PDF", PDF },
                { "ZIP", ZIP },
            };

            private string _value;

            public FormatEnum()
            {

            }

            public FormatEnum(string value)
            {
                _value = value;
            }

            public static FormatEnum FromValue(string value)
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

                if (this.Equals(obj as FormatEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FormatEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FormatEnum a, FormatEnum b)
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

            public static bool operator !=(FormatEnum a, FormatEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 周期 - AUDIT_REPORT_DAY: 天 - AUDIT_REPORT_WEEK：周 - AUDIT_REPORT_MONTH：月 - AUDIT_REPORT_YEAR：年 - AUDIT_REPORT_REAL_TIME：实时
        /// </summary>
        /// <value>周期 - AUDIT_REPORT_DAY: 天 - AUDIT_REPORT_WEEK：周 - AUDIT_REPORT_MONTH：月 - AUDIT_REPORT_YEAR：年 - AUDIT_REPORT_REAL_TIME：实时</value>
        [JsonConverter(typeof(EnumClassConverter<FrequencyEnum>))]
        public class FrequencyEnum
        {
            /// <summary>
            /// Enum AUDIT_REPORT_DAY for value: AUDIT_REPORT_DAY
            /// </summary>
            public static readonly FrequencyEnum AUDIT_REPORT_DAY = new FrequencyEnum("AUDIT_REPORT_DAY");

            /// <summary>
            /// Enum AUDIT_REPORT_WEEK for value: AUDIT_REPORT_WEEK
            /// </summary>
            public static readonly FrequencyEnum AUDIT_REPORT_WEEK = new FrequencyEnum("AUDIT_REPORT_WEEK");

            /// <summary>
            /// Enum AUDIT_REPORT_MONTH for value: AUDIT_REPORT_MONTH
            /// </summary>
            public static readonly FrequencyEnum AUDIT_REPORT_MONTH = new FrequencyEnum("AUDIT_REPORT_MONTH");

            /// <summary>
            /// Enum AUDIT_REPORT_YEAR for value: AUDIT_REPORT_YEAR
            /// </summary>
            public static readonly FrequencyEnum AUDIT_REPORT_YEAR = new FrequencyEnum("AUDIT_REPORT_YEAR");

            /// <summary>
            /// Enum AUDIT_REPORT_REAL_TIME for value: AUDIT_REPORT_REAL_TIME
            /// </summary>
            public static readonly FrequencyEnum AUDIT_REPORT_REAL_TIME = new FrequencyEnum("AUDIT_REPORT_REAL_TIME");

            private static readonly Dictionary<string, FrequencyEnum> StaticFields =
            new Dictionary<string, FrequencyEnum>()
            {
                { "AUDIT_REPORT_DAY", AUDIT_REPORT_DAY },
                { "AUDIT_REPORT_WEEK", AUDIT_REPORT_WEEK },
                { "AUDIT_REPORT_MONTH", AUDIT_REPORT_MONTH },
                { "AUDIT_REPORT_YEAR", AUDIT_REPORT_YEAR },
                { "AUDIT_REPORT_REAL_TIME", AUDIT_REPORT_REAL_TIME },
            };

            private string _value;

            public FrequencyEnum()
            {

            }

            public FrequencyEnum(string value)
            {
                _value = value;
            }

            public static FrequencyEnum FromValue(string value)
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

                if (this.Equals(obj as FrequencyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FrequencyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FrequencyEnum a, FrequencyEnum b)
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

            public static bool operator !=(FrequencyEnum a, FrequencyEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 调度方式
        /// </summary>
        /// <value>调度方式</value>
        [JsonConverter(typeof(EnumClassConverter<ModeEnum>))]
        public class ModeEnum
        {
            /// <summary>
            /// Enum ONCE for value: ONCE
            /// </summary>
            public static readonly ModeEnum ONCE = new ModeEnum("ONCE");

            /// <summary>
            /// Enum CYCLE for value: CYCLE
            /// </summary>
            public static readonly ModeEnum CYCLE = new ModeEnum("CYCLE");

            private static readonly Dictionary<string, ModeEnum> StaticFields =
            new Dictionary<string, ModeEnum>()
            {
                { "ONCE", ONCE },
                { "CYCLE", CYCLE },
            };

            private string _value;

            public ModeEnum()
            {

            }

            public ModeEnum(string value)
            {
                _value = value;
            }

            public static ModeEnum FromValue(string value)
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

                if (this.Equals(obj as ModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ModeEnum a, ModeEnum b)
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

            public static bool operator !=(ModeEnum a, ModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 是否通知  - OFF：不通知  - ON：通知
        /// </summary>
        /// <value>是否通知  - OFF：不通知  - ON：通知</value>
        [JsonConverter(typeof(EnumClassConverter<NoticeEnum>))]
        public class NoticeEnum
        {
            /// <summary>
            /// Enum OFF for value: OFF
            /// </summary>
            public static readonly NoticeEnum OFF = new NoticeEnum("OFF");

            /// <summary>
            /// Enum ON for value: ON
            /// </summary>
            public static readonly NoticeEnum ON = new NoticeEnum("ON");

            private static readonly Dictionary<string, NoticeEnum> StaticFields =
            new Dictionary<string, NoticeEnum>()
            {
                { "OFF", OFF },
                { "ON", ON },
            };

            private string _value;

            public NoticeEnum()
            {

            }

            public NoticeEnum(string value)
            {
                _value = value;
            }

            public static NoticeEnum FromValue(string value)
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

                if (this.Equals(obj as NoticeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NoticeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(NoticeEnum a, NoticeEnum b)
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

            public static bool operator !=(NoticeEnum a, NoticeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 模板状态
        /// </summary>
        /// <value>模板状态</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum OFF for value: OFF
            /// </summary>
            public static readonly StatusEnum OFF = new StatusEnum("OFF");

            /// <summary>
            /// Enum ON for value: ON
            /// </summary>
            public static readonly StatusEnum ON = new StatusEnum("ON");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "OFF", OFF },
                { "ON", ON },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 数据库ID
        /// </summary>
        [JsonProperty("db_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string DbIds { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public FormatEnum Format { get; set; }
        /// <summary>
        /// 周期 - AUDIT_REPORT_DAY: 天 - AUDIT_REPORT_WEEK：周 - AUDIT_REPORT_MONTH：月 - AUDIT_REPORT_YEAR：年 - AUDIT_REPORT_REAL_TIME：实时
        /// </summary>
        [JsonProperty("frequency", NullValueHandling = NullValueHandling.Ignore)]
        public FrequencyEnum Frequency { get; set; }
        /// <summary>
        /// 报表模板ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 调度方式
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public ModeEnum Mode { get; set; }
        /// <summary>
        /// 是否通知  - OFF：不通知  - ON：通知
        /// </summary>
        [JsonProperty("notice", NullValueHandling = NullValueHandling.Ignore)]
        public NoticeEnum Notice { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 模板状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 主题URN
        /// </summary>
        [JsonProperty("topic_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicUrn { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SchedulerConfigBase {\n");
            sb.Append("  dbIds: ").Append(DbIds).Append("\n");
            sb.Append("  format: ").Append(Format).Append("\n");
            sb.Append("  frequency: ").Append(Frequency).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  notice: ").Append(Notice).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  topicUrn: ").Append(TopicUrn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SchedulerConfigBase);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SchedulerConfigBase input)
        {
            if (input == null) return false;
            if (this.DbIds != input.DbIds || (this.DbIds != null && !this.DbIds.Equals(input.DbIds))) return false;
            if (this.Format != input.Format) return false;
            if (this.Frequency != input.Frequency) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Mode != input.Mode) return false;
            if (this.Notice != input.Notice) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.Status != input.Status) return false;
            if (this.TopicUrn != input.TopicUrn || (this.TopicUrn != null && !this.TopicUrn.Equals(input.TopicUrn))) return false;

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
                if (this.DbIds != null) hashCode = hashCode * 59 + this.DbIds.GetHashCode();
                hashCode = hashCode * 59 + this.Format.GetHashCode();
                hashCode = hashCode * 59 + this.Frequency.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.Mode.GetHashCode();
                hashCode = hashCode * 59 + this.Notice.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TopicUrn != null) hashCode = hashCode * 59 + this.TopicUrn.GetHashCode();
                return hashCode;
            }
        }
    }
}
