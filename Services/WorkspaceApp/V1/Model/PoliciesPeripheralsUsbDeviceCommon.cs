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
    /// USB和设备智能卡控制选项。
    /// </summary>
    public class PoliciesPeripheralsUsbDeviceCommon 
    {
        /// <summary>
        /// 是否开启PC/SC智能卡重定向。取值为： Enable：表示已启动。 Closed：表示已关闭。 Disable：表示已禁用。
        /// </summary>
        /// <value>是否开启PC/SC智能卡重定向。取值为： Enable：表示已启动。 Closed：表示已关闭。 Disable：表示已禁用。</value>
        [JsonConverter(typeof(EnumClassConverter<PcscSmartCardEnableEnum>))]
        public class PcscSmartCardEnableEnum
        {
            /// <summary>
            /// Enum ENABLE for value: Enable
            /// </summary>
            public static readonly PcscSmartCardEnableEnum ENABLE = new PcscSmartCardEnableEnum("Enable");

            /// <summary>
            /// Enum CLOSED for value: Closed
            /// </summary>
            public static readonly PcscSmartCardEnableEnum CLOSED = new PcscSmartCardEnableEnum("Closed");

            /// <summary>
            /// Enum DISABLE for value: Disable
            /// </summary>
            public static readonly PcscSmartCardEnableEnum DISABLE = new PcscSmartCardEnableEnum("Disable");

            private static readonly Dictionary<string, PcscSmartCardEnableEnum> StaticFields =
            new Dictionary<string, PcscSmartCardEnableEnum>()
            {
                { "Enable", ENABLE },
                { "Closed", CLOSED },
                { "Disable", DISABLE },
            };

            private string _value;

            public PcscSmartCardEnableEnum()
            {

            }

            public PcscSmartCardEnableEnum(string value)
            {
                _value = value;
            }

            public static PcscSmartCardEnableEnum FromValue(string value)
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

                if (this.Equals(obj as PcscSmartCardEnableEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PcscSmartCardEnableEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PcscSmartCardEnableEnum a, PcscSmartCardEnableEnum b)
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

            public static bool operator !=(PcscSmartCardEnableEnum a, PcscSmartCardEnableEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 是否开启PC/SC智能卡重定向。取值为： Enable：表示已启动。 Closed：表示已关闭。 Disable：表示已禁用。
        /// </summary>
        [JsonProperty("pcsc_smart_card_enable", NullValueHandling = NullValueHandling.Ignore)]
        public PcscSmartCardEnableEnum PcscSmartCardEnable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("common_options", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesPeripheralsUsbDeviceCommonCommonOptions CommonOptions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesPeripheralsUsbDeviceCommon {\n");
            sb.Append("  pcscSmartCardEnable: ").Append(PcscSmartCardEnable).Append("\n");
            sb.Append("  commonOptions: ").Append(CommonOptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesPeripheralsUsbDeviceCommon);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesPeripheralsUsbDeviceCommon input)
        {
            if (input == null) return false;
            if (this.PcscSmartCardEnable != input.PcscSmartCardEnable) return false;
            if (this.CommonOptions != input.CommonOptions || (this.CommonOptions != null && !this.CommonOptions.Equals(input.CommonOptions))) return false;

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
                hashCode = hashCode * 59 + this.PcscSmartCardEnable.GetHashCode();
                if (this.CommonOptions != null) hashCode = hashCode * 59 + this.CommonOptions.GetHashCode();
                return hashCode;
            }
        }
    }
}
