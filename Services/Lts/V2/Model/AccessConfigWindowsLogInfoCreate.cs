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
    /// 日志接入采集Windows事件日志
    /// </summary>
    public class AccessConfigWindowsLogInfoCreate 
    {
        /// <summary>
        /// Defines categorys
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<CategorysEnum>))]
        public class CategorysEnum
        {
            /// <summary>
            /// Enum APPLICATION for value: Application
            /// </summary>
            public static readonly CategorysEnum APPLICATION = new CategorysEnum("Application");

            /// <summary>
            /// Enum SYSTEM for value: System
            /// </summary>
            public static readonly CategorysEnum SYSTEM = new CategorysEnum("System");

            /// <summary>
            /// Enum SECURITY for value: Security
            /// </summary>
            public static readonly CategorysEnum SECURITY = new CategorysEnum("Security");

            /// <summary>
            /// Enum SETUP for value: Setup
            /// </summary>
            public static readonly CategorysEnum SETUP = new CategorysEnum("Setup");

            private static readonly Dictionary<string, CategorysEnum> StaticFields =
            new Dictionary<string, CategorysEnum>()
            {
                { "Application", APPLICATION },
                { "System", SYSTEM },
                { "Security", SECURITY },
                { "Setup", SETUP },
            };

            private string _value;

            public CategorysEnum()
            {

            }

            public CategorysEnum(string value)
            {
                _value = value;
            }

            public static CategorysEnum FromValue(string value)
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

                if (this.Equals(obj as CategorysEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CategorysEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CategorysEnum a, CategorysEnum b)
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

            public static bool operator !=(CategorysEnum a, CategorysEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// Defines eventLevel
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<EventLevelEnum>))]
        public class EventLevelEnum
        {
            /// <summary>
            /// Enum INFORMATION for value: information
            /// </summary>
            public static readonly EventLevelEnum INFORMATION = new EventLevelEnum("information");

            /// <summary>
            /// Enum WARNING for value: warning
            /// </summary>
            public static readonly EventLevelEnum WARNING = new EventLevelEnum("warning");

            /// <summary>
            /// Enum ERROR for value: error
            /// </summary>
            public static readonly EventLevelEnum ERROR = new EventLevelEnum("error");

            /// <summary>
            /// Enum CRITICAL for value: critical
            /// </summary>
            public static readonly EventLevelEnum CRITICAL = new EventLevelEnum("critical");

            /// <summary>
            /// Enum VERBOSE for value: verbose
            /// </summary>
            public static readonly EventLevelEnum VERBOSE = new EventLevelEnum("verbose");

            private static readonly Dictionary<string, EventLevelEnum> StaticFields =
            new Dictionary<string, EventLevelEnum>()
            {
                { "information", INFORMATION },
                { "warning", WARNING },
                { "error", ERROR },
                { "critical", CRITICAL },
                { "verbose", VERBOSE },
            };

            private string _value;

            public EventLevelEnum()
            {

            }

            public EventLevelEnum(string value)
            {
                _value = value;
            }

            public static EventLevelEnum FromValue(string value)
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

                if (this.Equals(obj as EventLevelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EventLevelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EventLevelEnum a, EventLevelEnum b)
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

            public static bool operator !=(EventLevelEnum a, EventLevelEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// 采集Windows事件日志类型。Application：应用系统，System：系统，Security：安全，Setup：启动
        /// </summary>
        [JsonProperty("categorys", NullValueHandling = NullValueHandling.Ignore)]
        public List<CategorysEnum> Categorys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("time_offset", NullValueHandling = NullValueHandling.Ignore)]
        public AccessConfigTimeOffset TimeOffset { get; set; }

        /// <summary>
        /// 事件等级。information：info，warning：告警，error：错误，critical：关键，verbose：冗长
        /// </summary>
        [JsonProperty("event_level", NullValueHandling = NullValueHandling.Ignore)]
        public List<EventLevelEnum> EventLevel { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessConfigWindowsLogInfoCreate {\n");
            sb.Append("  categorys: ").Append(Categorys).Append("\n");
            sb.Append("  timeOffset: ").Append(TimeOffset).Append("\n");
            sb.Append("  eventLevel: ").Append(EventLevel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccessConfigWindowsLogInfoCreate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AccessConfigWindowsLogInfoCreate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Categorys == input.Categorys ||
                    this.Categorys != null &&
                    input.Categorys != null &&
                    this.Categorys.SequenceEqual(input.Categorys)
                ) && 
                (
                    this.TimeOffset == input.TimeOffset ||
                    (this.TimeOffset != null &&
                    this.TimeOffset.Equals(input.TimeOffset))
                ) && 
                (
                    this.EventLevel == input.EventLevel ||
                    this.EventLevel != null &&
                    input.EventLevel != null &&
                    this.EventLevel.SequenceEqual(input.EventLevel)
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
                if (this.Categorys != null)
                    hashCode = hashCode * 59 + this.Categorys.GetHashCode();
                if (this.TimeOffset != null)
                    hashCode = hashCode * 59 + this.TimeOffset.GetHashCode();
                if (this.EventLevel != null)
                    hashCode = hashCode * 59 + this.EventLevel.GetHashCode();
                return hashCode;
            }
        }
    }
}
