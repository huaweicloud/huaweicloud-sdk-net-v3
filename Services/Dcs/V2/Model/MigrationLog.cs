using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 数据迁移进度日志信息
    /// </summary>
    public class MigrationLog 
    {
        /// <summary>
        /// 日志级别
        /// </summary>
        /// <value>日志级别</value>
        [JsonConverter(typeof(EnumClassConverter<LogLevelEnum>))]
        public class LogLevelEnum
        {
            /// <summary>
            /// Enum INFO for value: INFO
            /// </summary>
            public static readonly LogLevelEnum INFO = new LogLevelEnum("INFO");

            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            public static readonly LogLevelEnum ERROR = new LogLevelEnum("ERROR");

            private static readonly Dictionary<string, LogLevelEnum> StaticFields =
            new Dictionary<string, LogLevelEnum>()
            {
                { "INFO", INFO },
                { "ERROR", ERROR },
            };

            private string _value;

            public LogLevelEnum()
            {

            }

            public LogLevelEnum(string value)
            {
                _value = value;
            }

            public static LogLevelEnum FromValue(string value)
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

                if (this.Equals(obj as LogLevelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LogLevelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LogLevelEnum a, LogLevelEnum b)
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

            public static bool operator !=(LogLevelEnum a, LogLevelEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 迁移日志生成时间，形如：2023-05-15T09:11:25.449Z
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 日志级别
        /// </summary>
        [JsonProperty("log_level", NullValueHandling = NullValueHandling.Ignore)]
        public LogLevelEnum LogLevel { get; set; }
        /// <summary>
        /// 日志信息
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// 日志的编码
        /// </summary>
        [JsonProperty("log_code", NullValueHandling = NullValueHandling.Ignore)]
        public string LogCode { get; set; }

        /// <summary>
        /// 日志中的关键字
        /// </summary>
        [JsonProperty("keyword", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Keyword { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigrationLog {\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  logLevel: ").Append(LogLevel).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  logCode: ").Append(LogCode).Append("\n");
            sb.Append("  keyword: ").Append(Keyword).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MigrationLog);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MigrationLog input)
        {
            if (input == null) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.LogLevel != input.LogLevel) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.LogCode != input.LogCode || (this.LogCode != null && !this.LogCode.Equals(input.LogCode))) return false;
            if (this.Keyword != input.Keyword || (this.Keyword != null && input.Keyword != null && !this.Keyword.SequenceEqual(input.Keyword))) return false;

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
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                hashCode = hashCode * 59 + this.LogLevel.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.LogCode != null) hashCode = hashCode * 59 + this.LogCode.GetHashCode();
                if (this.Keyword != null) hashCode = hashCode * 59 + this.Keyword.GetHashCode();
                return hashCode;
            }
        }
    }
}
