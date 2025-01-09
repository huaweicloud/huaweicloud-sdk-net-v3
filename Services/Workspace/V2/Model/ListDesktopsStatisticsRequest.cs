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
    public class ListDesktopsStatisticsRequest 
    {
        /// <summary>
        /// Defines statisticsType
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<StatisticsTypeEnum>))]
        public class StatisticsTypeEnum
        {
            /// <summary>
            /// Enum ATTACH_STATE for value: attach-state
            /// </summary>
            public static readonly StatisticsTypeEnum ATTACH_STATE = new StatisticsTypeEnum("attach-state");

            /// <summary>
            /// Enum LOGIN_STATE for value: login-state
            /// </summary>
            public static readonly StatisticsTypeEnum LOGIN_STATE = new StatisticsTypeEnum("login-state");

            /// <summary>
            /// Enum RUN_STATE for value: run-state
            /// </summary>
            public static readonly StatisticsTypeEnum RUN_STATE = new StatisticsTypeEnum("run-state");

            private static readonly Dictionary<string, StatisticsTypeEnum> StaticFields =
            new Dictionary<string, StatisticsTypeEnum>()
            {
                { "attach-state", ATTACH_STATE },
                { "login-state", LOGIN_STATE },
                { "run-state", RUN_STATE },
            };

            private string _value;

            public StatisticsTypeEnum()
            {

            }

            public StatisticsTypeEnum(string value)
            {
                _value = value;
            }

            public static StatisticsTypeEnum FromValue(string value)
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

                if (this.Equals(obj as StatisticsTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatisticsTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatisticsTypeEnum a, StatisticsTypeEnum b)
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

            public static bool operator !=(StatisticsTypeEnum a, StatisticsTypeEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// 桌面类型
        /// </summary>
        [SDKProperty("desktop_type", IsQuery = true)]
        [JsonProperty("desktop_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DesktopType { get; set; }

        /// <summary>
        /// 统计类型，为空时仅统计桌面总数 |- - attach-state 按照分配状态统计 - login-state 按照登录状态统计 - run-state 按照运行状态统计
        /// </summary>
        [SDKProperty("statistics_type", IsQuery = true)]
        [JsonProperty("statistics_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<StatisticsTypeEnum> StatisticsType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDesktopsStatisticsRequest {\n");
            sb.Append("  desktopType: ").Append(DesktopType).Append("\n");
            sb.Append("  statisticsType: ").Append(StatisticsType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDesktopsStatisticsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDesktopsStatisticsRequest input)
        {
            if (input == null) return false;
            if (this.DesktopType != input.DesktopType || (this.DesktopType != null && input.DesktopType != null && !this.DesktopType.SequenceEqual(input.DesktopType))) return false;
            if (this.StatisticsType != input.StatisticsType || (this.StatisticsType != null && input.StatisticsType != null && !this.StatisticsType.SequenceEqual(input.StatisticsType))) return false;

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
                if (this.DesktopType != null) hashCode = hashCode * 59 + this.DesktopType.GetHashCode();
                hashCode = hashCode * 59 + this.StatisticsType.GetHashCode();
                return hashCode;
            }
        }
    }
}
