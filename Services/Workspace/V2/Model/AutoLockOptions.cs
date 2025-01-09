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
    /// 
    /// </summary>
    public class AutoLockOptions 
    {
        /// <summary>
        /// 自动断开或注销。取值为：AUTO_DISCONNECT：自动断开。AUTO_LOGOUT：自动注销。DISABLED：已禁用。（默认）AUTO_RESTART：自动重启。AUTO_STOP：自动停止。HIBERNATE:休眠。
        /// </summary>
        /// <value>自动断开或注销。取值为：AUTO_DISCONNECT：自动断开。AUTO_LOGOUT：自动注销。DISABLED：已禁用。（默认）AUTO_RESTART：自动重启。AUTO_STOP：自动停止。HIBERNATE:休眠。</value>
        [JsonConverter(typeof(EnumClassConverter<AutoDisconnectEnum>))]
        public class AutoDisconnectEnum
        {
            /// <summary>
            /// Enum AUTO_DISCONNECT for value: AUTO_DISCONNECT
            /// </summary>
            public static readonly AutoDisconnectEnum AUTO_DISCONNECT = new AutoDisconnectEnum("AUTO_DISCONNECT");

            /// <summary>
            /// Enum AUTO_LOGOUT for value: AUTO_LOGOUT
            /// </summary>
            public static readonly AutoDisconnectEnum AUTO_LOGOUT = new AutoDisconnectEnum("AUTO_LOGOUT");

            /// <summary>
            /// Enum DISABLED for value: DISABLED
            /// </summary>
            public static readonly AutoDisconnectEnum DISABLED = new AutoDisconnectEnum("DISABLED");

            /// <summary>
            /// Enum AUTO_RESTART for value: AUTO_RESTART
            /// </summary>
            public static readonly AutoDisconnectEnum AUTO_RESTART = new AutoDisconnectEnum("AUTO_RESTART");

            /// <summary>
            /// Enum AUTO_STOP for value: AUTO_STOP
            /// </summary>
            public static readonly AutoDisconnectEnum AUTO_STOP = new AutoDisconnectEnum("AUTO_STOP");

            /// <summary>
            /// Enum HIBERNATE for value: HIBERNATE
            /// </summary>
            public static readonly AutoDisconnectEnum HIBERNATE = new AutoDisconnectEnum("HIBERNATE");

            private static readonly Dictionary<string, AutoDisconnectEnum> StaticFields =
            new Dictionary<string, AutoDisconnectEnum>()
            {
                { "AUTO_DISCONNECT", AUTO_DISCONNECT },
                { "AUTO_LOGOUT", AUTO_LOGOUT },
                { "DISABLED", DISABLED },
                { "AUTO_RESTART", AUTO_RESTART },
                { "AUTO_STOP", AUTO_STOP },
                { "HIBERNATE", HIBERNATE },
            };

            private string _value;

            public AutoDisconnectEnum()
            {

            }

            public AutoDisconnectEnum(string value)
            {
                _value = value;
            }

            public static AutoDisconnectEnum FromValue(string value)
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

                if (this.Equals(obj as AutoDisconnectEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AutoDisconnectEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AutoDisconnectEnum a, AutoDisconnectEnum b)
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

            public static bool operator !=(AutoDisconnectEnum a, AutoDisconnectEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 锁屏等待时间（分钟）。取值范围为[3-86400]。默认：10。
        /// </summary>
        [JsonProperty("auto_lock_minutes", NullValueHandling = NullValueHandling.Ignore)]
        public int? AutoLockMinutes { get; set; }

        /// <summary>
        /// 自动断开或注销。取值为：AUTO_DISCONNECT：自动断开。AUTO_LOGOUT：自动注销。DISABLED：已禁用。（默认）AUTO_RESTART：自动重启。AUTO_STOP：自动停止。HIBERNATE:休眠。
        /// </summary>
        [JsonProperty("auto_disconnect", NullValueHandling = NullValueHandling.Ignore)]
        public AutoDisconnectEnum AutoDisconnect { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public AutoDisconnectOrLogoutControlOptions Options { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutoLockOptions {\n");
            sb.Append("  autoLockMinutes: ").Append(AutoLockMinutes).Append("\n");
            sb.Append("  autoDisconnect: ").Append(AutoDisconnect).Append("\n");
            sb.Append("  options: ").Append(Options).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AutoLockOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AutoLockOptions input)
        {
            if (input == null) return false;
            if (this.AutoLockMinutes != input.AutoLockMinutes || (this.AutoLockMinutes != null && !this.AutoLockMinutes.Equals(input.AutoLockMinutes))) return false;
            if (this.AutoDisconnect != input.AutoDisconnect) return false;
            if (this.Options != input.Options || (this.Options != null && !this.Options.Equals(input.Options))) return false;

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
                if (this.AutoLockMinutes != null) hashCode = hashCode * 59 + this.AutoLockMinutes.GetHashCode();
                hashCode = hashCode * 59 + this.AutoDisconnect.GetHashCode();
                if (this.Options != null) hashCode = hashCode * 59 + this.Options.GetHashCode();
                return hashCode;
            }
        }
    }
}
