using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Sbc 
    {
        /// <summary>
        /// 连接策略： - DISABLED：已禁用 - AUTO_DISCONNECT：自动断开 - AUTO_LOCK：自动锁屏
        /// </summary>
        /// <value>连接策略： - DISABLED：已禁用 - AUTO_DISCONNECT：自动断开 - AUTO_LOCK：自动锁屏</value>
        [JsonConverter(typeof(EnumClassConverter<SbcAutomaticDisconnectionEnum>))]
        public class SbcAutomaticDisconnectionEnum
        {
            /// <summary>
            /// Enum DISABLED for value: DISABLED
            /// </summary>
            public static readonly SbcAutomaticDisconnectionEnum DISABLED = new SbcAutomaticDisconnectionEnum("DISABLED");

            /// <summary>
            /// Enum AUTO_DISCONNECT for value: AUTO_DISCONNECT
            /// </summary>
            public static readonly SbcAutomaticDisconnectionEnum AUTO_DISCONNECT = new SbcAutomaticDisconnectionEnum("AUTO_DISCONNECT");

            /// <summary>
            /// Enum AUTO_LOCK for value: AUTO_LOCK
            /// </summary>
            public static readonly SbcAutomaticDisconnectionEnum AUTO_LOCK = new SbcAutomaticDisconnectionEnum("AUTO_LOCK");

            private static readonly Dictionary<string, SbcAutomaticDisconnectionEnum> StaticFields =
            new Dictionary<string, SbcAutomaticDisconnectionEnum>()
            {
                { "DISABLED", DISABLED },
                { "AUTO_DISCONNECT", AUTO_DISCONNECT },
                { "AUTO_LOCK", AUTO_LOCK },
            };

            private string _value;

            public SbcAutomaticDisconnectionEnum()
            {

            }

            public SbcAutomaticDisconnectionEnum(string value)
            {
                _value = value;
            }

            public static SbcAutomaticDisconnectionEnum FromValue(string value)
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

                if (this.Equals(obj as SbcAutomaticDisconnectionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SbcAutomaticDisconnectionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SbcAutomaticDisconnectionEnum a, SbcAutomaticDisconnectionEnum b)
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

            public static bool operator !=(SbcAutomaticDisconnectionEnum a, SbcAutomaticDisconnectionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 连接策略： - DISABLED：已禁用 - AUTO_DISCONNECT：自动断开 - AUTO_LOCK：自动锁屏
        /// </summary>
        [JsonProperty("sbc_automatic_disconnection", NullValueHandling = NullValueHandling.Ignore)]
        public SbcAutomaticDisconnectionEnum SbcAutomaticDisconnection { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sbc_automatic_disconnection_options", NullValueHandling = NullValueHandling.Ignore)]
        public SbcAutomaticDisconnectionOptions SbcAutomaticDisconnectionOptions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Sbc {\n");
            sb.Append("  sbcAutomaticDisconnection: ").Append(SbcAutomaticDisconnection).Append("\n");
            sb.Append("  sbcAutomaticDisconnectionOptions: ").Append(SbcAutomaticDisconnectionOptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Sbc);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Sbc input)
        {
            if (input == null) return false;
            if (this.SbcAutomaticDisconnection != input.SbcAutomaticDisconnection) return false;
            if (this.SbcAutomaticDisconnectionOptions != input.SbcAutomaticDisconnectionOptions || (this.SbcAutomaticDisconnectionOptions != null && !this.SbcAutomaticDisconnectionOptions.Equals(input.SbcAutomaticDisconnectionOptions))) return false;

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
                hashCode = hashCode * 59 + this.SbcAutomaticDisconnection.GetHashCode();
                if (this.SbcAutomaticDisconnectionOptions != null) hashCode = hashCode * 59 + this.SbcAutomaticDisconnectionOptions.GetHashCode();
                return hashCode;
            }
        }
    }
}
