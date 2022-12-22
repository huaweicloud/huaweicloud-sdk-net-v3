using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// 快速模式配置项
    /// </summary>
    public class ExpressConfig 
    {
        /// <summary>
        /// 快速模式相关配置，仅在mode配置为EXPRESS时生效 快速模式下流程的执行日志级别，当前支持： ALL: 记录所有节点的执行日志 ERROR：仅记录异常节点执行日志 NONE：不记录日志 注意：当配置为ALL和ERROR级别时租户需要开启LTS相关权限
        /// </summary>
        /// <value>快速模式相关配置，仅在mode配置为EXPRESS时生效 快速模式下流程的执行日志级别，当前支持： ALL: 记录所有节点的执行日志 ERROR：仅记录异常节点执行日志 NONE：不记录日志 注意：当配置为ALL和ERROR级别时租户需要开启LTS相关权限</value>
        [JsonConverter(typeof(EnumClassConverter<LogLevelEnum>))]
        public class LogLevelEnum
        {
            /// <summary>
            /// Enum ALL for value: ALL
            /// </summary>
            public static readonly LogLevelEnum ALL = new LogLevelEnum("ALL");

            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            public static readonly LogLevelEnum ERROR = new LogLevelEnum("ERROR");

            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            public static readonly LogLevelEnum NONE = new LogLevelEnum("NONE");

            private static readonly Dictionary<string, LogLevelEnum> StaticFields =
            new Dictionary<string, LogLevelEnum>()
            {
                { "ALL", ALL },
                { "ERROR", ERROR },
                { "NONE", NONE },
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
        /// 快速模式相关配置，仅在mode配置为EXPRESS时生效 快速模式下流程的执行日志级别，当前支持： ALL: 记录所有节点的执行日志 ERROR：仅记录异常节点执行日志 NONE：不记录日志 注意：当配置为ALL和ERROR级别时租户需要开启LTS相关权限
        /// </summary>
        [JsonProperty("log_level", NullValueHandling = NullValueHandling.Ignore)]
        public LogLevelEnum LogLevel { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExpressConfig {\n");
            sb.Append("  logLevel: ").Append(LogLevel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExpressConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExpressConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LogLevel == input.LogLevel ||
                    (this.LogLevel != null &&
                    this.LogLevel.Equals(input.LogLevel))
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
                if (this.LogLevel != null)
                    hashCode = hashCode * 59 + this.LogLevel.GetHashCode();
                return hashCode;
            }
        }
    }
}
