using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 数字人直播任务运行配置
    /// </summary>
    public class LiveJobRunConfig 
    {
        /// <summary>
        /// 允许使用资源类型。 * PERIOD：使用包周期资源 * ONDEMAND：使用按需资源 * UNLIMITED：不限制资源类型 * ONE_TIME：一次性资源
        /// </summary>
        /// <value>允许使用资源类型。 * PERIOD：使用包周期资源 * ONDEMAND：使用按需资源 * UNLIMITED：不限制资源类型 * ONE_TIME：一次性资源</value>
        [JsonConverter(typeof(EnumClassConverter<AllowResourceTypeEnum>))]
        public class AllowResourceTypeEnum
        {
            /// <summary>
            /// Enum PERIOD for value: PERIOD
            /// </summary>
            public static readonly AllowResourceTypeEnum PERIOD = new AllowResourceTypeEnum("PERIOD");

            /// <summary>
            /// Enum ONDEMAND for value: ONDEMAND
            /// </summary>
            public static readonly AllowResourceTypeEnum ONDEMAND = new AllowResourceTypeEnum("ONDEMAND");

            /// <summary>
            /// Enum UNLIMITED for value: UNLIMITED
            /// </summary>
            public static readonly AllowResourceTypeEnum UNLIMITED = new AllowResourceTypeEnum("UNLIMITED");

            /// <summary>
            /// Enum ONE_TIME for value: ONE_TIME
            /// </summary>
            public static readonly AllowResourceTypeEnum ONE_TIME = new AllowResourceTypeEnum("ONE_TIME");

            private static readonly Dictionary<string, AllowResourceTypeEnum> StaticFields =
            new Dictionary<string, AllowResourceTypeEnum>()
            {
                { "PERIOD", PERIOD },
                { "ONDEMAND", ONDEMAND },
                { "UNLIMITED", UNLIMITED },
                { "ONE_TIME", ONE_TIME },
            };

            private string _value;

            public AllowResourceTypeEnum()
            {

            }

            public AllowResourceTypeEnum(string value)
            {
                _value = value;
            }

            public static AllowResourceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as AllowResourceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AllowResourceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AllowResourceTypeEnum a, AllowResourceTypeEnum b)
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

            public static bool operator !=(AllowResourceTypeEnum a, AllowResourceTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 允许使用资源类型。 * PERIOD：使用包周期资源 * ONDEMAND：使用按需资源 * UNLIMITED：不限制资源类型 * ONE_TIME：一次性资源
        /// </summary>
        [JsonProperty("allow_resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public AllowResourceTypeEnum AllowResourceType { get; set; }
        /// <summary>
        /// 一个直播间是否仅允许一个正在直播的任务。 * true: 限制直播间仅允许一个任务运行。 * false: 不限制直播间任务运行数量。
        /// </summary>
        [JsonProperty("single_job_in_room", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SingleJobInRoom { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LiveJobRunConfig {\n");
            sb.Append("  allowResourceType: ").Append(AllowResourceType).Append("\n");
            sb.Append("  singleJobInRoom: ").Append(SingleJobInRoom).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LiveJobRunConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LiveJobRunConfig input)
        {
            if (input == null) return false;
            if (this.AllowResourceType != input.AllowResourceType) return false;
            if (this.SingleJobInRoom != input.SingleJobInRoom || (this.SingleJobInRoom != null && !this.SingleJobInRoom.Equals(input.SingleJobInRoom))) return false;

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
                hashCode = hashCode * 59 + this.AllowResourceType.GetHashCode();
                if (this.SingleJobInRoom != null) hashCode = hashCode * 59 + this.SingleJobInRoom.GetHashCode();
                return hashCode;
            }
        }
    }
}
