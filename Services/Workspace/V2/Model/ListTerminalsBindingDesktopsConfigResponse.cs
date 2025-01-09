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
    /// Response Object
    /// </summary>
    public class ListTerminalsBindingDesktopsConfigResponse : SdkResponse
    {
        /// <summary>
        /// 绑定开关，只取值ON或OFF
        /// </summary>
        /// <value>绑定开关，只取值ON或OFF</value>
        [JsonConverter(typeof(EnumClassConverter<TcBindSwitchEnum>))]
        public class TcBindSwitchEnum
        {
            /// <summary>
            /// Enum ON for value: ON
            /// </summary>
            public static readonly TcBindSwitchEnum ON = new TcBindSwitchEnum("ON");

            /// <summary>
            /// Enum OFF for value: OFF
            /// </summary>
            public static readonly TcBindSwitchEnum OFF = new TcBindSwitchEnum("OFF");

            private static readonly Dictionary<string, TcBindSwitchEnum> StaticFields =
            new Dictionary<string, TcBindSwitchEnum>()
            {
                { "ON", ON },
                { "OFF", OFF },
            };

            private string _value;

            public TcBindSwitchEnum()
            {

            }

            public TcBindSwitchEnum(string value)
            {
                _value = value;
            }

            public static TcBindSwitchEnum FromValue(string value)
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

                if (this.Equals(obj as TcBindSwitchEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TcBindSwitchEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TcBindSwitchEnum a, TcBindSwitchEnum b)
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

            public static bool operator !=(TcBindSwitchEnum a, TcBindSwitchEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 自动绑定开关，只取值ON或OFF
        /// </summary>
        /// <value>自动绑定开关，只取值ON或OFF</value>
        [JsonConverter(typeof(EnumClassConverter<TcAutoBindSwitchEnum>))]
        public class TcAutoBindSwitchEnum
        {
            /// <summary>
            /// Enum ON for value: ON
            /// </summary>
            public static readonly TcAutoBindSwitchEnum ON = new TcAutoBindSwitchEnum("ON");

            /// <summary>
            /// Enum OFF for value: OFF
            /// </summary>
            public static readonly TcAutoBindSwitchEnum OFF = new TcAutoBindSwitchEnum("OFF");

            private static readonly Dictionary<string, TcAutoBindSwitchEnum> StaticFields =
            new Dictionary<string, TcAutoBindSwitchEnum>()
            {
                { "ON", ON },
                { "OFF", OFF },
            };

            private string _value;

            public TcAutoBindSwitchEnum()
            {

            }

            public TcAutoBindSwitchEnum(string value)
            {
                _value = value;
            }

            public static TcAutoBindSwitchEnum FromValue(string value)
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

                if (this.Equals(obj as TcAutoBindSwitchEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TcAutoBindSwitchEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TcAutoBindSwitchEnum a, TcAutoBindSwitchEnum b)
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

            public static bool operator !=(TcAutoBindSwitchEnum a, TcAutoBindSwitchEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 绑定开关，只取值ON或OFF
        /// </summary>
        [JsonProperty("tc_bind_switch", NullValueHandling = NullValueHandling.Ignore)]
        public TcBindSwitchEnum TcBindSwitch { get; set; }
        /// <summary>
        /// 自动绑定开关，只取值ON或OFF
        /// </summary>
        [JsonProperty("tc_auto_bind_switch", NullValueHandling = NullValueHandling.Ignore)]
        public TcAutoBindSwitchEnum TcAutoBindSwitch { get; set; }
        /// <summary>
        /// 最大绑定数量，默认值为1
        /// </summary>
        [JsonProperty("tc_auto_bind_max", NullValueHandling = NullValueHandling.Ignore)]
        public int? TcAutoBindMax { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTerminalsBindingDesktopsConfigResponse {\n");
            sb.Append("  tcBindSwitch: ").Append(TcBindSwitch).Append("\n");
            sb.Append("  tcAutoBindSwitch: ").Append(TcAutoBindSwitch).Append("\n");
            sb.Append("  tcAutoBindMax: ").Append(TcAutoBindMax).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTerminalsBindingDesktopsConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTerminalsBindingDesktopsConfigResponse input)
        {
            if (input == null) return false;
            if (this.TcBindSwitch != input.TcBindSwitch) return false;
            if (this.TcAutoBindSwitch != input.TcAutoBindSwitch) return false;
            if (this.TcAutoBindMax != input.TcAutoBindMax || (this.TcAutoBindMax != null && !this.TcAutoBindMax.Equals(input.TcAutoBindMax))) return false;

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
                hashCode = hashCode * 59 + this.TcBindSwitch.GetHashCode();
                hashCode = hashCode * 59 + this.TcAutoBindSwitch.GetHashCode();
                if (this.TcAutoBindMax != null) hashCode = hashCode * 59 + this.TcAutoBindMax.GetHashCode();
                return hashCode;
            }
        }
    }
}
