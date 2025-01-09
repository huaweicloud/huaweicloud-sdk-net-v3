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
    public class Bandwidth 
    {
        /// <summary>
        /// 智能显示传输。取值为：DISABLE：表示关闭。ENABLE：表示开启。DIAGNOSTIC：诊断模式
        /// </summary>
        /// <value>智能显示传输。取值为：DISABLE：表示关闭。ENABLE：表示开启。DIAGNOSTIC：诊断模式</value>
        [JsonConverter(typeof(EnumClassConverter<IntelligentDataTransportFlagEnum>))]
        public class IntelligentDataTransportFlagEnum
        {
            /// <summary>
            /// Enum DISABLE for value: DISABLE
            /// </summary>
            public static readonly IntelligentDataTransportFlagEnum DISABLE = new IntelligentDataTransportFlagEnum("DISABLE");

            /// <summary>
            /// Enum ENABLE for value: ENABLE
            /// </summary>
            public static readonly IntelligentDataTransportFlagEnum ENABLE = new IntelligentDataTransportFlagEnum("ENABLE");

            /// <summary>
            /// Enum DIAGNOSTIC for value: DIAGNOSTIC
            /// </summary>
            public static readonly IntelligentDataTransportFlagEnum DIAGNOSTIC = new IntelligentDataTransportFlagEnum("DIAGNOSTIC");

            private static readonly Dictionary<string, IntelligentDataTransportFlagEnum> StaticFields =
            new Dictionary<string, IntelligentDataTransportFlagEnum>()
            {
                { "DISABLE", DISABLE },
                { "ENABLE", ENABLE },
                { "DIAGNOSTIC", DIAGNOSTIC },
            };

            private string _value;

            public IntelligentDataTransportFlagEnum()
            {

            }

            public IntelligentDataTransportFlagEnum(string value)
            {
                _value = value;
            }

            public static IntelligentDataTransportFlagEnum FromValue(string value)
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

                if (this.Equals(obj as IntelligentDataTransportFlagEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IntelligentDataTransportFlagEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(IntelligentDataTransportFlagEnum a, IntelligentDataTransportFlagEnum b)
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

            public static bool operator !=(IntelligentDataTransportFlagEnum a, IntelligentDataTransportFlagEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 智能显示传输。取值为：DISABLE：表示关闭。ENABLE：表示开启。DIAGNOSTIC：诊断模式
        /// </summary>
        [JsonProperty("intelligent_data_transport_flag", NullValueHandling = NullValueHandling.Ignore)]
        public IntelligentDataTransportFlagEnum IntelligentDataTransportFlag { get; set; }
        /// <summary>
        /// 是否开启总带宽控制。取值为：false：表示关闭。true：表示开启。
        /// </summary>
        [JsonProperty("total_bandwidth_control_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TotalBandwidthControlEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public TotalBandwidthControlOptions Options { get; set; }

        /// <summary>
        /// 是否开启显示带宽控制。取值为：false：表示关闭。true：表示开启。
        /// </summary>
        [JsonProperty("display_bandwidth_control_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisplayBandwidthControlEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("display_bandwidth_control_options", NullValueHandling = NullValueHandling.Ignore)]
        public DisplayBandwidthControlOptions DisplayBandwidthControlOptions { get; set; }

        /// <summary>
        /// 是否开启多媒体带宽控制。取值为：false：表示关闭。true：表示开启。
        /// </summary>
        [JsonProperty("multimedia_bandwidth_control_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MultimediaBandwidthControlEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("multimedia_bandwidth_control_options", NullValueHandling = NullValueHandling.Ignore)]
        public MultimediaBandwidthControlOptions MultimediaBandwidthControlOptions { get; set; }

        /// <summary>
        /// 是否开启USB带宽控制。取值为：false：表示关闭。true：表示开启。
        /// </summary>
        [JsonProperty("usb_bandwidth_control_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UsbBandwidthControlEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("usb_bandwidth_control_options", NullValueHandling = NullValueHandling.Ignore)]
        public UsbBandwidthControlOptions UsbBandwidthControlOptions { get; set; }

        /// <summary>
        /// 是否开启PCSC控制。取值为：false：表示关闭。true：表示开启。
        /// </summary>
        [JsonProperty("pcsc_bandwidth_control_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PcscBandwidthControlEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pcsc_bandwidth_control_options", NullValueHandling = NullValueHandling.Ignore)]
        public PcscBandwidthControlOptions PcscBandwidthControlOptions { get; set; }

        /// <summary>
        /// 是否开启TWAIN带宽控制。取值为：false：表示关闭。true：表示开启。
        /// </summary>
        [JsonProperty("twain_bandwidth_control_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TwainBandwidthControlEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("twain_bandwidth_control_options", NullValueHandling = NullValueHandling.Ignore)]
        public TwainBandwidthControlOptions TwainBandwidthControlOptions { get; set; }

        /// <summary>
        /// 是否开启打印机带宽控制。取值为：false：表示关闭。true：表示开启。
        /// </summary>
        [JsonProperty("printer_bandwidth_control_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PrinterBandwidthControlEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("printer_bandwidth_control_options", NullValueHandling = NullValueHandling.Ignore)]
        public PrinterBandwidthControlOptions PrinterBandwidthControlOptions { get; set; }

        /// <summary>
        /// 是否开启串口带宽控制。取值为：false：表示关闭。true：表示开启。
        /// </summary>
        [JsonProperty("com_bandwidth_control_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ComBandwidthControlEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("com_bandwidth_control_options", NullValueHandling = NullValueHandling.Ignore)]
        public ComBandwidthControlOptions ComBandwidthControlOptions { get; set; }

        /// <summary>
        /// 是否开启文件重定向带宽控制。取值为：false：表示关闭。true：表示开启
        /// </summary>
        [JsonProperty("file_redirection_bandwidth_control_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FileRedirectionBandwidthControlEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("file_redirection_bandwidth_control_options", NullValueHandling = NullValueHandling.Ignore)]
        public FileRedirectionBandwidthControlOptions FileRedirectionBandwidthControlOptions { get; set; }

        /// <summary>
        /// 是否开启剪切板带宽控制。取值为：false：表示关闭。true：表示开启。
        /// </summary>
        [JsonProperty("clipboard_bandwidth_control_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ClipboardBandwidthControlEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("clipboard_bandwidth_control_options", NullValueHandling = NullValueHandling.Ignore)]
        public ClipboardBandwidthControlOptions ClipboardBandwidthControlOptions { get; set; }

        /// <summary>
        /// 是否开启安全通道带宽控制。取值为：false：表示关闭。true：表示开启。
        /// </summary>
        [JsonProperty("secure_channel_bandwidth_control_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SecureChannelBandwidthControlEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("secure_channel_bandwidth_control_options", NullValueHandling = NullValueHandling.Ignore)]
        public SecureChannelBandwidthControlOptions SecureChannelBandwidthControlOptions { get; set; }

        /// <summary>
        /// 是否开启摄像头带宽控制。取值为：false：表示关闭。true：表示开启。
        /// </summary>
        [JsonProperty("camera_bandwidth_control_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CameraBandwidthControlEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("camera_bandwidth_control_options", NullValueHandling = NullValueHandling.Ignore)]
        public CameraBandwidthControlOptions CameraBandwidthControlOptions { get; set; }

        /// <summary>
        /// 是否开启虚拟通道带宽控制。取值为：false：表示关闭。true：表示开启。
        /// </summary>
        [JsonProperty("virtual_channel_bandwidth_control_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? VirtualChannelBandwidthControlEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("virtual_channel_bandwidth_control_options", NullValueHandling = NullValueHandling.Ignore)]
        public VirtualChannelBandwidthControlOptions VirtualChannelBandwidthControlOptions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Bandwidth {\n");
            sb.Append("  intelligentDataTransportFlag: ").Append(IntelligentDataTransportFlag).Append("\n");
            sb.Append("  totalBandwidthControlEnable: ").Append(TotalBandwidthControlEnable).Append("\n");
            sb.Append("  options: ").Append(Options).Append("\n");
            sb.Append("  displayBandwidthControlEnable: ").Append(DisplayBandwidthControlEnable).Append("\n");
            sb.Append("  displayBandwidthControlOptions: ").Append(DisplayBandwidthControlOptions).Append("\n");
            sb.Append("  multimediaBandwidthControlEnable: ").Append(MultimediaBandwidthControlEnable).Append("\n");
            sb.Append("  multimediaBandwidthControlOptions: ").Append(MultimediaBandwidthControlOptions).Append("\n");
            sb.Append("  usbBandwidthControlEnable: ").Append(UsbBandwidthControlEnable).Append("\n");
            sb.Append("  usbBandwidthControlOptions: ").Append(UsbBandwidthControlOptions).Append("\n");
            sb.Append("  pcscBandwidthControlEnable: ").Append(PcscBandwidthControlEnable).Append("\n");
            sb.Append("  pcscBandwidthControlOptions: ").Append(PcscBandwidthControlOptions).Append("\n");
            sb.Append("  twainBandwidthControlEnable: ").Append(TwainBandwidthControlEnable).Append("\n");
            sb.Append("  twainBandwidthControlOptions: ").Append(TwainBandwidthControlOptions).Append("\n");
            sb.Append("  printerBandwidthControlEnable: ").Append(PrinterBandwidthControlEnable).Append("\n");
            sb.Append("  printerBandwidthControlOptions: ").Append(PrinterBandwidthControlOptions).Append("\n");
            sb.Append("  comBandwidthControlEnable: ").Append(ComBandwidthControlEnable).Append("\n");
            sb.Append("  comBandwidthControlOptions: ").Append(ComBandwidthControlOptions).Append("\n");
            sb.Append("  fileRedirectionBandwidthControlEnable: ").Append(FileRedirectionBandwidthControlEnable).Append("\n");
            sb.Append("  fileRedirectionBandwidthControlOptions: ").Append(FileRedirectionBandwidthControlOptions).Append("\n");
            sb.Append("  clipboardBandwidthControlEnable: ").Append(ClipboardBandwidthControlEnable).Append("\n");
            sb.Append("  clipboardBandwidthControlOptions: ").Append(ClipboardBandwidthControlOptions).Append("\n");
            sb.Append("  secureChannelBandwidthControlEnable: ").Append(SecureChannelBandwidthControlEnable).Append("\n");
            sb.Append("  secureChannelBandwidthControlOptions: ").Append(SecureChannelBandwidthControlOptions).Append("\n");
            sb.Append("  cameraBandwidthControlEnable: ").Append(CameraBandwidthControlEnable).Append("\n");
            sb.Append("  cameraBandwidthControlOptions: ").Append(CameraBandwidthControlOptions).Append("\n");
            sb.Append("  virtualChannelBandwidthControlEnable: ").Append(VirtualChannelBandwidthControlEnable).Append("\n");
            sb.Append("  virtualChannelBandwidthControlOptions: ").Append(VirtualChannelBandwidthControlOptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Bandwidth);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Bandwidth input)
        {
            if (input == null) return false;
            if (this.IntelligentDataTransportFlag != input.IntelligentDataTransportFlag) return false;
            if (this.TotalBandwidthControlEnable != input.TotalBandwidthControlEnable || (this.TotalBandwidthControlEnable != null && !this.TotalBandwidthControlEnable.Equals(input.TotalBandwidthControlEnable))) return false;
            if (this.Options != input.Options || (this.Options != null && !this.Options.Equals(input.Options))) return false;
            if (this.DisplayBandwidthControlEnable != input.DisplayBandwidthControlEnable || (this.DisplayBandwidthControlEnable != null && !this.DisplayBandwidthControlEnable.Equals(input.DisplayBandwidthControlEnable))) return false;
            if (this.DisplayBandwidthControlOptions != input.DisplayBandwidthControlOptions || (this.DisplayBandwidthControlOptions != null && !this.DisplayBandwidthControlOptions.Equals(input.DisplayBandwidthControlOptions))) return false;
            if (this.MultimediaBandwidthControlEnable != input.MultimediaBandwidthControlEnable || (this.MultimediaBandwidthControlEnable != null && !this.MultimediaBandwidthControlEnable.Equals(input.MultimediaBandwidthControlEnable))) return false;
            if (this.MultimediaBandwidthControlOptions != input.MultimediaBandwidthControlOptions || (this.MultimediaBandwidthControlOptions != null && !this.MultimediaBandwidthControlOptions.Equals(input.MultimediaBandwidthControlOptions))) return false;
            if (this.UsbBandwidthControlEnable != input.UsbBandwidthControlEnable || (this.UsbBandwidthControlEnable != null && !this.UsbBandwidthControlEnable.Equals(input.UsbBandwidthControlEnable))) return false;
            if (this.UsbBandwidthControlOptions != input.UsbBandwidthControlOptions || (this.UsbBandwidthControlOptions != null && !this.UsbBandwidthControlOptions.Equals(input.UsbBandwidthControlOptions))) return false;
            if (this.PcscBandwidthControlEnable != input.PcscBandwidthControlEnable || (this.PcscBandwidthControlEnable != null && !this.PcscBandwidthControlEnable.Equals(input.PcscBandwidthControlEnable))) return false;
            if (this.PcscBandwidthControlOptions != input.PcscBandwidthControlOptions || (this.PcscBandwidthControlOptions != null && !this.PcscBandwidthControlOptions.Equals(input.PcscBandwidthControlOptions))) return false;
            if (this.TwainBandwidthControlEnable != input.TwainBandwidthControlEnable || (this.TwainBandwidthControlEnable != null && !this.TwainBandwidthControlEnable.Equals(input.TwainBandwidthControlEnable))) return false;
            if (this.TwainBandwidthControlOptions != input.TwainBandwidthControlOptions || (this.TwainBandwidthControlOptions != null && !this.TwainBandwidthControlOptions.Equals(input.TwainBandwidthControlOptions))) return false;
            if (this.PrinterBandwidthControlEnable != input.PrinterBandwidthControlEnable || (this.PrinterBandwidthControlEnable != null && !this.PrinterBandwidthControlEnable.Equals(input.PrinterBandwidthControlEnable))) return false;
            if (this.PrinterBandwidthControlOptions != input.PrinterBandwidthControlOptions || (this.PrinterBandwidthControlOptions != null && !this.PrinterBandwidthControlOptions.Equals(input.PrinterBandwidthControlOptions))) return false;
            if (this.ComBandwidthControlEnable != input.ComBandwidthControlEnable || (this.ComBandwidthControlEnable != null && !this.ComBandwidthControlEnable.Equals(input.ComBandwidthControlEnable))) return false;
            if (this.ComBandwidthControlOptions != input.ComBandwidthControlOptions || (this.ComBandwidthControlOptions != null && !this.ComBandwidthControlOptions.Equals(input.ComBandwidthControlOptions))) return false;
            if (this.FileRedirectionBandwidthControlEnable != input.FileRedirectionBandwidthControlEnable || (this.FileRedirectionBandwidthControlEnable != null && !this.FileRedirectionBandwidthControlEnable.Equals(input.FileRedirectionBandwidthControlEnable))) return false;
            if (this.FileRedirectionBandwidthControlOptions != input.FileRedirectionBandwidthControlOptions || (this.FileRedirectionBandwidthControlOptions != null && !this.FileRedirectionBandwidthControlOptions.Equals(input.FileRedirectionBandwidthControlOptions))) return false;
            if (this.ClipboardBandwidthControlEnable != input.ClipboardBandwidthControlEnable || (this.ClipboardBandwidthControlEnable != null && !this.ClipboardBandwidthControlEnable.Equals(input.ClipboardBandwidthControlEnable))) return false;
            if (this.ClipboardBandwidthControlOptions != input.ClipboardBandwidthControlOptions || (this.ClipboardBandwidthControlOptions != null && !this.ClipboardBandwidthControlOptions.Equals(input.ClipboardBandwidthControlOptions))) return false;
            if (this.SecureChannelBandwidthControlEnable != input.SecureChannelBandwidthControlEnable || (this.SecureChannelBandwidthControlEnable != null && !this.SecureChannelBandwidthControlEnable.Equals(input.SecureChannelBandwidthControlEnable))) return false;
            if (this.SecureChannelBandwidthControlOptions != input.SecureChannelBandwidthControlOptions || (this.SecureChannelBandwidthControlOptions != null && !this.SecureChannelBandwidthControlOptions.Equals(input.SecureChannelBandwidthControlOptions))) return false;
            if (this.CameraBandwidthControlEnable != input.CameraBandwidthControlEnable || (this.CameraBandwidthControlEnable != null && !this.CameraBandwidthControlEnable.Equals(input.CameraBandwidthControlEnable))) return false;
            if (this.CameraBandwidthControlOptions != input.CameraBandwidthControlOptions || (this.CameraBandwidthControlOptions != null && !this.CameraBandwidthControlOptions.Equals(input.CameraBandwidthControlOptions))) return false;
            if (this.VirtualChannelBandwidthControlEnable != input.VirtualChannelBandwidthControlEnable || (this.VirtualChannelBandwidthControlEnable != null && !this.VirtualChannelBandwidthControlEnable.Equals(input.VirtualChannelBandwidthControlEnable))) return false;
            if (this.VirtualChannelBandwidthControlOptions != input.VirtualChannelBandwidthControlOptions || (this.VirtualChannelBandwidthControlOptions != null && !this.VirtualChannelBandwidthControlOptions.Equals(input.VirtualChannelBandwidthControlOptions))) return false;

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
                hashCode = hashCode * 59 + this.IntelligentDataTransportFlag.GetHashCode();
                if (this.TotalBandwidthControlEnable != null) hashCode = hashCode * 59 + this.TotalBandwidthControlEnable.GetHashCode();
                if (this.Options != null) hashCode = hashCode * 59 + this.Options.GetHashCode();
                if (this.DisplayBandwidthControlEnable != null) hashCode = hashCode * 59 + this.DisplayBandwidthControlEnable.GetHashCode();
                if (this.DisplayBandwidthControlOptions != null) hashCode = hashCode * 59 + this.DisplayBandwidthControlOptions.GetHashCode();
                if (this.MultimediaBandwidthControlEnable != null) hashCode = hashCode * 59 + this.MultimediaBandwidthControlEnable.GetHashCode();
                if (this.MultimediaBandwidthControlOptions != null) hashCode = hashCode * 59 + this.MultimediaBandwidthControlOptions.GetHashCode();
                if (this.UsbBandwidthControlEnable != null) hashCode = hashCode * 59 + this.UsbBandwidthControlEnable.GetHashCode();
                if (this.UsbBandwidthControlOptions != null) hashCode = hashCode * 59 + this.UsbBandwidthControlOptions.GetHashCode();
                if (this.PcscBandwidthControlEnable != null) hashCode = hashCode * 59 + this.PcscBandwidthControlEnable.GetHashCode();
                if (this.PcscBandwidthControlOptions != null) hashCode = hashCode * 59 + this.PcscBandwidthControlOptions.GetHashCode();
                if (this.TwainBandwidthControlEnable != null) hashCode = hashCode * 59 + this.TwainBandwidthControlEnable.GetHashCode();
                if (this.TwainBandwidthControlOptions != null) hashCode = hashCode * 59 + this.TwainBandwidthControlOptions.GetHashCode();
                if (this.PrinterBandwidthControlEnable != null) hashCode = hashCode * 59 + this.PrinterBandwidthControlEnable.GetHashCode();
                if (this.PrinterBandwidthControlOptions != null) hashCode = hashCode * 59 + this.PrinterBandwidthControlOptions.GetHashCode();
                if (this.ComBandwidthControlEnable != null) hashCode = hashCode * 59 + this.ComBandwidthControlEnable.GetHashCode();
                if (this.ComBandwidthControlOptions != null) hashCode = hashCode * 59 + this.ComBandwidthControlOptions.GetHashCode();
                if (this.FileRedirectionBandwidthControlEnable != null) hashCode = hashCode * 59 + this.FileRedirectionBandwidthControlEnable.GetHashCode();
                if (this.FileRedirectionBandwidthControlOptions != null) hashCode = hashCode * 59 + this.FileRedirectionBandwidthControlOptions.GetHashCode();
                if (this.ClipboardBandwidthControlEnable != null) hashCode = hashCode * 59 + this.ClipboardBandwidthControlEnable.GetHashCode();
                if (this.ClipboardBandwidthControlOptions != null) hashCode = hashCode * 59 + this.ClipboardBandwidthControlOptions.GetHashCode();
                if (this.SecureChannelBandwidthControlEnable != null) hashCode = hashCode * 59 + this.SecureChannelBandwidthControlEnable.GetHashCode();
                if (this.SecureChannelBandwidthControlOptions != null) hashCode = hashCode * 59 + this.SecureChannelBandwidthControlOptions.GetHashCode();
                if (this.CameraBandwidthControlEnable != null) hashCode = hashCode * 59 + this.CameraBandwidthControlEnable.GetHashCode();
                if (this.CameraBandwidthControlOptions != null) hashCode = hashCode * 59 + this.CameraBandwidthControlOptions.GetHashCode();
                if (this.VirtualChannelBandwidthControlEnable != null) hashCode = hashCode * 59 + this.VirtualChannelBandwidthControlEnable.GetHashCode();
                if (this.VirtualChannelBandwidthControlOptions != null) hashCode = hashCode * 59 + this.VirtualChannelBandwidthControlOptions.GetHashCode();
                return hashCode;
            }
        }
    }
}
