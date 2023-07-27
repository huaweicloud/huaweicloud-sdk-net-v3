using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 创建日志流参数。
    /// </summary>
    public class CreateLogStreamParams 
    {
        /// <summary>
        /// 需要创建的日志流名称。
        /// </summary>
        /// <value>需要创建的日志流名称。</value>
        [JsonConverter(typeof(EnumClassConverter<LogStreamNameEnum>))]
        public class LogStreamNameEnum
        {
            /// <summary>
            /// Enum LTS_STREAM_13CI for value: lts-stream-13ci
            /// </summary>
            public static readonly LogStreamNameEnum LTS_STREAM_13CI = new LogStreamNameEnum("lts-stream-13ci");

            private static readonly Dictionary<string, LogStreamNameEnum> StaticFields =
            new Dictionary<string, LogStreamNameEnum>()
            {
                { "lts-stream-13ci", LTS_STREAM_13CI },
            };

            private string _value;

            public LogStreamNameEnum()
            {

            }

            public LogStreamNameEnum(string value)
            {
                _value = value;
            }

            public static LogStreamNameEnum FromValue(string value)
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

                if (this.Equals(obj as LogStreamNameEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LogStreamNameEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LogStreamNameEnum a, LogStreamNameEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(LogStreamNameEnum a, LogStreamNameEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 日志存储时间  最小值：1 最大值：365 说明： 该参数仅对华东-上海一、华北-北京四、华南-广州用户开放。
        /// </summary>
        /// <value>日志存储时间  最小值：1 最大值：365 说明： 该参数仅对华东-上海一、华北-北京四、华南-广州用户开放。</value>
        [JsonConverter(typeof(EnumClassConverter<TtlInDaysEnum>))]
        public class TtlInDaysEnum
        {
            /// <summary>
            /// Enum _7 for value: 7
            /// </summary>
            public static readonly TtlInDaysEnum _7 = new TtlInDaysEnum("7");

            private static readonly Dictionary<string, TtlInDaysEnum> StaticFields =
            new Dictionary<string, TtlInDaysEnum>()
            {
                { "7", _7 },
            };

            private string _value;

            public TtlInDaysEnum()
            {

            }

            public TtlInDaysEnum(string value)
            {
                _value = value;
            }

            public static TtlInDaysEnum FromValue(string value)
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

                if (this.Equals(obj as TtlInDaysEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TtlInDaysEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TtlInDaysEnum a, TtlInDaysEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(TtlInDaysEnum a, TtlInDaysEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 需要创建的日志流名称。
        /// </summary>
        [JsonProperty("log_stream_name", NullValueHandling = NullValueHandling.Ignore)]
        public LogStreamNameEnum LogStreamName { get; set; }
        /// <summary>
        /// 企业项目名称。
        /// </summary>
        [JsonProperty("enterprise_project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectName { get; set; }

        /// <summary>
        /// 日志存储时间  最小值：1 最大值：365 说明： 该参数仅对华东-上海一、华北-北京四、华南-广州用户开放。
        /// </summary>
        [JsonProperty("ttl_in_days", NullValueHandling = NullValueHandling.Ignore)]
        public TtlInDaysEnum TtlInDays { get; set; }
        /// <summary>
        /// 标签字段信息
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagsBody> Tags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateLogStreamParams {\n");
            sb.Append("  logStreamName: ").Append(LogStreamName).Append("\n");
            sb.Append("  enterpriseProjectName: ").Append(EnterpriseProjectName).Append("\n");
            sb.Append("  ttlInDays: ").Append(TtlInDays).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateLogStreamParams);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateLogStreamParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LogStreamName == input.LogStreamName ||
                    (this.LogStreamName != null &&
                    this.LogStreamName.Equals(input.LogStreamName))
                ) && 
                (
                    this.EnterpriseProjectName == input.EnterpriseProjectName ||
                    (this.EnterpriseProjectName != null &&
                    this.EnterpriseProjectName.Equals(input.EnterpriseProjectName))
                ) && 
                (
                    this.TtlInDays == input.TtlInDays ||
                    (this.TtlInDays != null &&
                    this.TtlInDays.Equals(input.TtlInDays))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.LogStreamName != null)
                    hashCode = hashCode * 59 + this.LogStreamName.GetHashCode();
                if (this.EnterpriseProjectName != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectName.GetHashCode();
                if (this.TtlInDays != null)
                    hashCode = hashCode * 59 + this.TtlInDays.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
