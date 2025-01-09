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
    /// USB端口重定向控制的选项。
    /// </summary>
    public class PoliciesPeripheralsUsbPortRedirectionOptions 
    {
        /// <summary>
        /// USB 重定向模式。取值为： 经典模式：Classical mode。 通用模式：Common mode。
        /// </summary>
        /// <value>USB 重定向模式。取值为： 经典模式：Classical mode。 通用模式：Common mode。</value>
        [JsonConverter(typeof(EnumClassConverter<UsbRedirectionModeEnum>))]
        public class UsbRedirectionModeEnum
        {
            /// <summary>
            /// Enum CLASSICAL_MODE for value: Classical mode
            /// </summary>
            public static readonly UsbRedirectionModeEnum CLASSICAL_MODE = new UsbRedirectionModeEnum("Classical mode");

            /// <summary>
            /// Enum COMMON_MODE for value: Common mode
            /// </summary>
            public static readonly UsbRedirectionModeEnum COMMON_MODE = new UsbRedirectionModeEnum("Common mode");

            private static readonly Dictionary<string, UsbRedirectionModeEnum> StaticFields =
            new Dictionary<string, UsbRedirectionModeEnum>()
            {
                { "Classical mode", CLASSICAL_MODE },
                { "Common mode", COMMON_MODE },
            };

            private string _value;

            public UsbRedirectionModeEnum()
            {

            }

            public UsbRedirectionModeEnum(string value)
            {
                _value = value;
            }

            public static UsbRedirectionModeEnum FromValue(string value)
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

                if (this.Equals(obj as UsbRedirectionModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(UsbRedirectionModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(UsbRedirectionModeEnum a, UsbRedirectionModeEnum b)
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

            public static bool operator !=(UsbRedirectionModeEnum a, UsbRedirectionModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 是否开启图像设备（如: 扫描仪）。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("usb_image_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UsbImageEnable { get; set; }

        /// <summary>
        /// 是否开启视频设备（如: 摄像头）。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("usb_video_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UsbVideoEnable { get; set; }

        /// <summary>
        /// 是否开启打印设备（如: 打印机）。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("usb_printer_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UsbPrinterEnable { get; set; }

        /// <summary>
        /// 是否开启存储设备（如: U盘）。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("usb_storage_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UsbStorageEnable { get; set; }

        /// <summary>
        /// 是否开启无线设备（如：蓝牙）。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("wireless_devices_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WirelessDevicesEnable { get; set; }

        /// <summary>
        /// 是否开启网路设备（如：无线网卡）。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("network_devices_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NetworkDevicesEnable { get; set; }

        /// <summary>
        /// 是否开启智能卡设备（如：Ukey）。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("usb_smart_card_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UsbSmartCardEnable { get; set; }

        /// <summary>
        /// 是否开启其他USB设备重定向。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("other_usb_devices_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OtherUsbDevicesEnable { get; set; }

        /// <summary>
        /// USB端口重定向自定义策略。
        /// </summary>
        [JsonProperty("usb_redirection_customization_policy", NullValueHandling = NullValueHandling.Ignore)]
        public string UsbRedirectionCustomizationPolicy { get; set; }

        /// <summary>
        /// USB 重定向模式。取值为： 经典模式：Classical mode。 通用模式：Common mode。
        /// </summary>
        [JsonProperty("usb_redirection_mode", NullValueHandling = NullValueHandling.Ignore)]
        public UsbRedirectionModeEnum UsbRedirectionMode { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesPeripheralsUsbPortRedirectionOptions {\n");
            sb.Append("  usbImageEnable: ").Append(UsbImageEnable).Append("\n");
            sb.Append("  usbVideoEnable: ").Append(UsbVideoEnable).Append("\n");
            sb.Append("  usbPrinterEnable: ").Append(UsbPrinterEnable).Append("\n");
            sb.Append("  usbStorageEnable: ").Append(UsbStorageEnable).Append("\n");
            sb.Append("  wirelessDevicesEnable: ").Append(WirelessDevicesEnable).Append("\n");
            sb.Append("  networkDevicesEnable: ").Append(NetworkDevicesEnable).Append("\n");
            sb.Append("  usbSmartCardEnable: ").Append(UsbSmartCardEnable).Append("\n");
            sb.Append("  otherUsbDevicesEnable: ").Append(OtherUsbDevicesEnable).Append("\n");
            sb.Append("  usbRedirectionCustomizationPolicy: ").Append(UsbRedirectionCustomizationPolicy).Append("\n");
            sb.Append("  usbRedirectionMode: ").Append(UsbRedirectionMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesPeripheralsUsbPortRedirectionOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesPeripheralsUsbPortRedirectionOptions input)
        {
            if (input == null) return false;
            if (this.UsbImageEnable != input.UsbImageEnable || (this.UsbImageEnable != null && !this.UsbImageEnable.Equals(input.UsbImageEnable))) return false;
            if (this.UsbVideoEnable != input.UsbVideoEnable || (this.UsbVideoEnable != null && !this.UsbVideoEnable.Equals(input.UsbVideoEnable))) return false;
            if (this.UsbPrinterEnable != input.UsbPrinterEnable || (this.UsbPrinterEnable != null && !this.UsbPrinterEnable.Equals(input.UsbPrinterEnable))) return false;
            if (this.UsbStorageEnable != input.UsbStorageEnable || (this.UsbStorageEnable != null && !this.UsbStorageEnable.Equals(input.UsbStorageEnable))) return false;
            if (this.WirelessDevicesEnable != input.WirelessDevicesEnable || (this.WirelessDevicesEnable != null && !this.WirelessDevicesEnable.Equals(input.WirelessDevicesEnable))) return false;
            if (this.NetworkDevicesEnable != input.NetworkDevicesEnable || (this.NetworkDevicesEnable != null && !this.NetworkDevicesEnable.Equals(input.NetworkDevicesEnable))) return false;
            if (this.UsbSmartCardEnable != input.UsbSmartCardEnable || (this.UsbSmartCardEnable != null && !this.UsbSmartCardEnable.Equals(input.UsbSmartCardEnable))) return false;
            if (this.OtherUsbDevicesEnable != input.OtherUsbDevicesEnable || (this.OtherUsbDevicesEnable != null && !this.OtherUsbDevicesEnable.Equals(input.OtherUsbDevicesEnable))) return false;
            if (this.UsbRedirectionCustomizationPolicy != input.UsbRedirectionCustomizationPolicy || (this.UsbRedirectionCustomizationPolicy != null && !this.UsbRedirectionCustomizationPolicy.Equals(input.UsbRedirectionCustomizationPolicy))) return false;
            if (this.UsbRedirectionMode != input.UsbRedirectionMode) return false;

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
                if (this.UsbImageEnable != null) hashCode = hashCode * 59 + this.UsbImageEnable.GetHashCode();
                if (this.UsbVideoEnable != null) hashCode = hashCode * 59 + this.UsbVideoEnable.GetHashCode();
                if (this.UsbPrinterEnable != null) hashCode = hashCode * 59 + this.UsbPrinterEnable.GetHashCode();
                if (this.UsbStorageEnable != null) hashCode = hashCode * 59 + this.UsbStorageEnable.GetHashCode();
                if (this.WirelessDevicesEnable != null) hashCode = hashCode * 59 + this.WirelessDevicesEnable.GetHashCode();
                if (this.NetworkDevicesEnable != null) hashCode = hashCode * 59 + this.NetworkDevicesEnable.GetHashCode();
                if (this.UsbSmartCardEnable != null) hashCode = hashCode * 59 + this.UsbSmartCardEnable.GetHashCode();
                if (this.OtherUsbDevicesEnable != null) hashCode = hashCode * 59 + this.OtherUsbDevicesEnable.GetHashCode();
                if (this.UsbRedirectionCustomizationPolicy != null) hashCode = hashCode * 59 + this.UsbRedirectionCustomizationPolicy.GetHashCode();
                hashCode = hashCode * 59 + this.UsbRedirectionMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
