using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DeleteLogConfigs 
    {
        /// <summary>
        /// 日志类型。
        /// </summary>
        /// <value>日志类型。</value>
        [JsonConverter(typeof(EnumClassConverter<LogTypeEnum>))]
        public class LogTypeEnum
        {
            /// <summary>
            /// Enum ERROR_LOG for value: error_log
            /// </summary>
            public static readonly LogTypeEnum ERROR_LOG = new LogTypeEnum("error_log");

            /// <summary>
            /// Enum SLOW_LOG for value: slow_log
            /// </summary>
            public static readonly LogTypeEnum SLOW_LOG = new LogTypeEnum("slow_log");

            /// <summary>
            /// Enum AUDIT_LOG for value: audit_log
            /// </summary>
            public static readonly LogTypeEnum AUDIT_LOG = new LogTypeEnum("audit_log");

            private static readonly Dictionary<string, LogTypeEnum> StaticFields =
            new Dictionary<string, LogTypeEnum>()
            {
                { "error_log", ERROR_LOG },
                { "slow_log", SLOW_LOG },
                { "audit_log", AUDIT_LOG },
            };

            private string _value;

            public LogTypeEnum()
            {

            }

            public LogTypeEnum(string value)
            {
                _value = value;
            }

            public static LogTypeEnum FromValue(string value)
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

                if (this.Equals(obj as LogTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LogTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LogTypeEnum a, LogTypeEnum b)
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

            public static bool operator !=(LogTypeEnum a, LogTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 日志类型。
        /// </summary>
        [JsonProperty("log_type", NullValueHandling = NullValueHandling.Ignore)]
        public LogTypeEnum LogType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteLogConfigs {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  logType: ").Append(LogType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteLogConfigs);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteLogConfigs input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.LogType != input.LogType) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                hashCode = hashCode * 59 + this.LogType.GetHashCode();
                return hashCode;
            }
        }
    }
}
