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
    public class SaveTaskSettingRequestBody 
    {
        /// <summary>
        /// 是否长期运行
        /// </summary>
        /// <value>是否长期运行</value>
        [JsonConverter(typeof(EnumClassConverter<IsLongRunEnum>))]
        public class IsLongRunEnum
        {
            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            public static readonly IsLongRunEnum _1 = new IsLongRunEnum("1");

            /// <summary>
            /// Enum _0 for value: 0
            /// </summary>
            public static readonly IsLongRunEnum _0 = new IsLongRunEnum("0");

            private static readonly Dictionary<string, IsLongRunEnum> StaticFields =
            new Dictionary<string, IsLongRunEnum>()
            {
                { "1", _1 },
                { "0", _0 },
            };

            private string _value;

            public IsLongRunEnum()
            {

            }

            public IsLongRunEnum(string value)
            {
                _value = value;
            }

            public static IsLongRunEnum FromValue(string value)
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

                if (this.Equals(obj as IsLongRunEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IsLongRunEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(IsLongRunEnum a, IsLongRunEnum b)
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

            public static bool operator !=(IsLongRunEnum a, IsLongRunEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 自定义时长
        /// </summary>
        [JsonProperty("max_running_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxRunningTime { get; set; }

        /// <summary>
        /// 是否长期运行
        /// </summary>
        [JsonProperty("is_long_run", NullValueHandling = NullValueHandling.Ignore)]
        public IsLongRunEnum IsLongRun { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SaveTaskSettingRequestBody {\n");
            sb.Append("  maxRunningTime: ").Append(MaxRunningTime).Append("\n");
            sb.Append("  isLongRun: ").Append(IsLongRun).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SaveTaskSettingRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SaveTaskSettingRequestBody input)
        {
            if (input == null) return false;
            if (this.MaxRunningTime != input.MaxRunningTime || (this.MaxRunningTime != null && !this.MaxRunningTime.Equals(input.MaxRunningTime))) return false;
            if (this.IsLongRun != input.IsLongRun) return false;

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
                if (this.MaxRunningTime != null) hashCode = hashCode * 59 + this.MaxRunningTime.GetHashCode();
                hashCode = hashCode * 59 + this.IsLongRun.GetHashCode();
                return hashCode;
            }
        }
    }
}
