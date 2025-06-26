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
    public class TotalBandwidthControlOptions 
    {

        /// <summary>
        /// 总带宽控制量（Kbps）。取值范围为[10000-1000000]。默认：30000。
        /// </summary>
        [JsonProperty("total_bandwidth_control_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalBandwidthControlValue { get; set; }

        /// <summary>
        /// 显示带宽百分比控制。取值为：false：表示关闭。true：表示开启。
        /// </summary>
        [JsonProperty("display_bandwidth_percentage_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisplayBandwidthPercentageEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("display_bandwidth_percentage_options", NullValueHandling = NullValueHandling.Ignore)]
        public DisplayBandwidthPercentageOptions DisplayBandwidthPercentageOptions { get; set; }

        /// <summary>
        /// 多媒体带宽百分比控制。取值为：false：表示关闭。true：表示开启。
        /// </summary>
        [JsonProperty("multimedia_bandwidth_percentage_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MultimediaBandwidthPercentageEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("multimedia_bandwidth_percentage_options", NullValueHandling = NullValueHandling.Ignore)]
        public MultimediaBandwidthPercentageOptions MultimediaBandwidthPercentageOptions { get; set; }

        /// <summary>
        /// USB带宽百分比控制。取值为：false：表示关闭。true：表示开启。
        /// </summary>
        [JsonProperty("usb_bandwidth_percentage_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UsbBandwidthPercentageEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("usb_bandwidth_percentage_options", NullValueHandling = NullValueHandling.Ignore)]
        public UsbBandwidthPercentageOptions UsbBandwidthPercentageOptions { get; set; }

        /// <summary>
        /// PCSC带宽百分比控制。取值为：false：表示关闭。true：表示开启。
        /// </summary>
        [JsonProperty("pcsc_bandwidth_percentage_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PcscBandwidthPercentageEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pcsc_bandwidth_percentage_options", NullValueHandling = NullValueHandling.Ignore)]
        public PcscBandwidthPercentageOptions PcscBandwidthPercentageOptions { get; set; }

        /// <summary>
        /// TWAIN带宽百分比控制。取值为：false：表示关闭。true：表示开启。
        /// </summary>
        [JsonProperty("twain_bandwidth_percentage_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TwainBandwidthPercentageEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("twain_bandwidth_percentage_options", NullValueHandling = NullValueHandling.Ignore)]
        public TwainBandwidthPercentageOptions TwainBandwidthPercentageOptions { get; set; }

        /// <summary>
        /// 打印机带宽百分比控制。取值为：false：表示关闭。true：表示开启。
        /// </summary>
        [JsonProperty("printer_bandwidth_percentage_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PrinterBandwidthPercentageEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("printer_bandwidth_percentage_options", NullValueHandling = NullValueHandling.Ignore)]
        public PrinterBandwidthPercentageOptions PrinterBandwidthPercentageOptions { get; set; }

        /// <summary>
        /// 串口带宽百分比控制。取值为：false：表示关闭。true：表示开启。
        /// </summary>
        [JsonProperty("com_bandwidth_percentage_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ComBandwidthPercentageEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("com_bandwidth_percentage_options", NullValueHandling = NullValueHandling.Ignore)]
        public ComBandwidthPercentageOptions ComBandwidthPercentageOptions { get; set; }

        /// <summary>
        /// 文件重定向带宽百分比控制。取值为：false：表示关闭。true：表示开启。
        /// </summary>
        [JsonProperty("file_redirection_bandwidth_percentage_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FileRedirectionBandwidthPercentageEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("file_redirection_bandwidth_percentage_options", NullValueHandling = NullValueHandling.Ignore)]
        public FileRedirectionBandwidthPercentageOptions FileRedirectionBandwidthPercentageOptions { get; set; }

        /// <summary>
        /// 剪切板带宽百分比控制。取值为：false：表示关闭。true：表示开启。
        /// </summary>
        [JsonProperty("clipboard_bandwidth_percentage_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ClipboardBandwidthPercentageEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("clipboard_bandwidth_percentage_options", NullValueHandling = NullValueHandling.Ignore)]
        public ClipboardBandwidthPercentageOptions ClipboardBandwidthPercentageOptions { get; set; }

        /// <summary>
        /// 安全通道带宽百分比控制。取值为：false：表示关闭。true：表示开启。
        /// </summary>
        [JsonProperty("secure_channel_bandwidth_percentage_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SecureChannelBandwidthPercentageEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("secure_channel_bandwidth_percentage_options", NullValueHandling = NullValueHandling.Ignore)]
        public SecureChannelBandwidthPercentageOptions SecureChannelBandwidthPercentageOptions { get; set; }

        /// <summary>
        /// 摄像头带宽百分比控制。取值为：false：表示关闭。true：表示开启。
        /// </summary>
        [JsonProperty("camera_bandwidth_percentage_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CameraBandwidthPercentageEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("camera_bandwidth_percentage_options", NullValueHandling = NullValueHandling.Ignore)]
        public CameraBandwidthPercentageOptions CameraBandwidthPercentageOptions { get; set; }

        /// <summary>
        /// 虚拟通道带宽百分比控制。取值为：false：表示关闭。true：表示开启。
        /// </summary>
        [JsonProperty("virtual_channel_bandwidth_percentage_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? VirtualChannelBandwidthPercentageEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("virtual_channel_bandwidth_percentage_options", NullValueHandling = NullValueHandling.Ignore)]
        public VirtualChannelBandwidthPercentageOptions VirtualChannelBandwidthPercentageOptions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TotalBandwidthControlOptions {\n");
            sb.Append("  totalBandwidthControlValue: ").Append(TotalBandwidthControlValue).Append("\n");
            sb.Append("  displayBandwidthPercentageEnable: ").Append(DisplayBandwidthPercentageEnable).Append("\n");
            sb.Append("  displayBandwidthPercentageOptions: ").Append(DisplayBandwidthPercentageOptions).Append("\n");
            sb.Append("  multimediaBandwidthPercentageEnable: ").Append(MultimediaBandwidthPercentageEnable).Append("\n");
            sb.Append("  multimediaBandwidthPercentageOptions: ").Append(MultimediaBandwidthPercentageOptions).Append("\n");
            sb.Append("  usbBandwidthPercentageEnable: ").Append(UsbBandwidthPercentageEnable).Append("\n");
            sb.Append("  usbBandwidthPercentageOptions: ").Append(UsbBandwidthPercentageOptions).Append("\n");
            sb.Append("  pcscBandwidthPercentageEnable: ").Append(PcscBandwidthPercentageEnable).Append("\n");
            sb.Append("  pcscBandwidthPercentageOptions: ").Append(PcscBandwidthPercentageOptions).Append("\n");
            sb.Append("  twainBandwidthPercentageEnable: ").Append(TwainBandwidthPercentageEnable).Append("\n");
            sb.Append("  twainBandwidthPercentageOptions: ").Append(TwainBandwidthPercentageOptions).Append("\n");
            sb.Append("  printerBandwidthPercentageEnable: ").Append(PrinterBandwidthPercentageEnable).Append("\n");
            sb.Append("  printerBandwidthPercentageOptions: ").Append(PrinterBandwidthPercentageOptions).Append("\n");
            sb.Append("  comBandwidthPercentageEnable: ").Append(ComBandwidthPercentageEnable).Append("\n");
            sb.Append("  comBandwidthPercentageOptions: ").Append(ComBandwidthPercentageOptions).Append("\n");
            sb.Append("  fileRedirectionBandwidthPercentageEnable: ").Append(FileRedirectionBandwidthPercentageEnable).Append("\n");
            sb.Append("  fileRedirectionBandwidthPercentageOptions: ").Append(FileRedirectionBandwidthPercentageOptions).Append("\n");
            sb.Append("  clipboardBandwidthPercentageEnable: ").Append(ClipboardBandwidthPercentageEnable).Append("\n");
            sb.Append("  clipboardBandwidthPercentageOptions: ").Append(ClipboardBandwidthPercentageOptions).Append("\n");
            sb.Append("  secureChannelBandwidthPercentageEnable: ").Append(SecureChannelBandwidthPercentageEnable).Append("\n");
            sb.Append("  secureChannelBandwidthPercentageOptions: ").Append(SecureChannelBandwidthPercentageOptions).Append("\n");
            sb.Append("  cameraBandwidthPercentageEnable: ").Append(CameraBandwidthPercentageEnable).Append("\n");
            sb.Append("  cameraBandwidthPercentageOptions: ").Append(CameraBandwidthPercentageOptions).Append("\n");
            sb.Append("  virtualChannelBandwidthPercentageEnable: ").Append(VirtualChannelBandwidthPercentageEnable).Append("\n");
            sb.Append("  virtualChannelBandwidthPercentageOptions: ").Append(VirtualChannelBandwidthPercentageOptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TotalBandwidthControlOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TotalBandwidthControlOptions input)
        {
            if (input == null) return false;
            if (this.TotalBandwidthControlValue != input.TotalBandwidthControlValue || (this.TotalBandwidthControlValue != null && !this.TotalBandwidthControlValue.Equals(input.TotalBandwidthControlValue))) return false;
            if (this.DisplayBandwidthPercentageEnable != input.DisplayBandwidthPercentageEnable || (this.DisplayBandwidthPercentageEnable != null && !this.DisplayBandwidthPercentageEnable.Equals(input.DisplayBandwidthPercentageEnable))) return false;
            if (this.DisplayBandwidthPercentageOptions != input.DisplayBandwidthPercentageOptions || (this.DisplayBandwidthPercentageOptions != null && !this.DisplayBandwidthPercentageOptions.Equals(input.DisplayBandwidthPercentageOptions))) return false;
            if (this.MultimediaBandwidthPercentageEnable != input.MultimediaBandwidthPercentageEnable || (this.MultimediaBandwidthPercentageEnable != null && !this.MultimediaBandwidthPercentageEnable.Equals(input.MultimediaBandwidthPercentageEnable))) return false;
            if (this.MultimediaBandwidthPercentageOptions != input.MultimediaBandwidthPercentageOptions || (this.MultimediaBandwidthPercentageOptions != null && !this.MultimediaBandwidthPercentageOptions.Equals(input.MultimediaBandwidthPercentageOptions))) return false;
            if (this.UsbBandwidthPercentageEnable != input.UsbBandwidthPercentageEnable || (this.UsbBandwidthPercentageEnable != null && !this.UsbBandwidthPercentageEnable.Equals(input.UsbBandwidthPercentageEnable))) return false;
            if (this.UsbBandwidthPercentageOptions != input.UsbBandwidthPercentageOptions || (this.UsbBandwidthPercentageOptions != null && !this.UsbBandwidthPercentageOptions.Equals(input.UsbBandwidthPercentageOptions))) return false;
            if (this.PcscBandwidthPercentageEnable != input.PcscBandwidthPercentageEnable || (this.PcscBandwidthPercentageEnable != null && !this.PcscBandwidthPercentageEnable.Equals(input.PcscBandwidthPercentageEnable))) return false;
            if (this.PcscBandwidthPercentageOptions != input.PcscBandwidthPercentageOptions || (this.PcscBandwidthPercentageOptions != null && !this.PcscBandwidthPercentageOptions.Equals(input.PcscBandwidthPercentageOptions))) return false;
            if (this.TwainBandwidthPercentageEnable != input.TwainBandwidthPercentageEnable || (this.TwainBandwidthPercentageEnable != null && !this.TwainBandwidthPercentageEnable.Equals(input.TwainBandwidthPercentageEnable))) return false;
            if (this.TwainBandwidthPercentageOptions != input.TwainBandwidthPercentageOptions || (this.TwainBandwidthPercentageOptions != null && !this.TwainBandwidthPercentageOptions.Equals(input.TwainBandwidthPercentageOptions))) return false;
            if (this.PrinterBandwidthPercentageEnable != input.PrinterBandwidthPercentageEnable || (this.PrinterBandwidthPercentageEnable != null && !this.PrinterBandwidthPercentageEnable.Equals(input.PrinterBandwidthPercentageEnable))) return false;
            if (this.PrinterBandwidthPercentageOptions != input.PrinterBandwidthPercentageOptions || (this.PrinterBandwidthPercentageOptions != null && !this.PrinterBandwidthPercentageOptions.Equals(input.PrinterBandwidthPercentageOptions))) return false;
            if (this.ComBandwidthPercentageEnable != input.ComBandwidthPercentageEnable || (this.ComBandwidthPercentageEnable != null && !this.ComBandwidthPercentageEnable.Equals(input.ComBandwidthPercentageEnable))) return false;
            if (this.ComBandwidthPercentageOptions != input.ComBandwidthPercentageOptions || (this.ComBandwidthPercentageOptions != null && !this.ComBandwidthPercentageOptions.Equals(input.ComBandwidthPercentageOptions))) return false;
            if (this.FileRedirectionBandwidthPercentageEnable != input.FileRedirectionBandwidthPercentageEnable || (this.FileRedirectionBandwidthPercentageEnable != null && !this.FileRedirectionBandwidthPercentageEnable.Equals(input.FileRedirectionBandwidthPercentageEnable))) return false;
            if (this.FileRedirectionBandwidthPercentageOptions != input.FileRedirectionBandwidthPercentageOptions || (this.FileRedirectionBandwidthPercentageOptions != null && !this.FileRedirectionBandwidthPercentageOptions.Equals(input.FileRedirectionBandwidthPercentageOptions))) return false;
            if (this.ClipboardBandwidthPercentageEnable != input.ClipboardBandwidthPercentageEnable || (this.ClipboardBandwidthPercentageEnable != null && !this.ClipboardBandwidthPercentageEnable.Equals(input.ClipboardBandwidthPercentageEnable))) return false;
            if (this.ClipboardBandwidthPercentageOptions != input.ClipboardBandwidthPercentageOptions || (this.ClipboardBandwidthPercentageOptions != null && !this.ClipboardBandwidthPercentageOptions.Equals(input.ClipboardBandwidthPercentageOptions))) return false;
            if (this.SecureChannelBandwidthPercentageEnable != input.SecureChannelBandwidthPercentageEnable || (this.SecureChannelBandwidthPercentageEnable != null && !this.SecureChannelBandwidthPercentageEnable.Equals(input.SecureChannelBandwidthPercentageEnable))) return false;
            if (this.SecureChannelBandwidthPercentageOptions != input.SecureChannelBandwidthPercentageOptions || (this.SecureChannelBandwidthPercentageOptions != null && !this.SecureChannelBandwidthPercentageOptions.Equals(input.SecureChannelBandwidthPercentageOptions))) return false;
            if (this.CameraBandwidthPercentageEnable != input.CameraBandwidthPercentageEnable || (this.CameraBandwidthPercentageEnable != null && !this.CameraBandwidthPercentageEnable.Equals(input.CameraBandwidthPercentageEnable))) return false;
            if (this.CameraBandwidthPercentageOptions != input.CameraBandwidthPercentageOptions || (this.CameraBandwidthPercentageOptions != null && !this.CameraBandwidthPercentageOptions.Equals(input.CameraBandwidthPercentageOptions))) return false;
            if (this.VirtualChannelBandwidthPercentageEnable != input.VirtualChannelBandwidthPercentageEnable || (this.VirtualChannelBandwidthPercentageEnable != null && !this.VirtualChannelBandwidthPercentageEnable.Equals(input.VirtualChannelBandwidthPercentageEnable))) return false;
            if (this.VirtualChannelBandwidthPercentageOptions != input.VirtualChannelBandwidthPercentageOptions || (this.VirtualChannelBandwidthPercentageOptions != null && !this.VirtualChannelBandwidthPercentageOptions.Equals(input.VirtualChannelBandwidthPercentageOptions))) return false;

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
                if (this.TotalBandwidthControlValue != null) hashCode = hashCode * 59 + this.TotalBandwidthControlValue.GetHashCode();
                if (this.DisplayBandwidthPercentageEnable != null) hashCode = hashCode * 59 + this.DisplayBandwidthPercentageEnable.GetHashCode();
                if (this.DisplayBandwidthPercentageOptions != null) hashCode = hashCode * 59 + this.DisplayBandwidthPercentageOptions.GetHashCode();
                if (this.MultimediaBandwidthPercentageEnable != null) hashCode = hashCode * 59 + this.MultimediaBandwidthPercentageEnable.GetHashCode();
                if (this.MultimediaBandwidthPercentageOptions != null) hashCode = hashCode * 59 + this.MultimediaBandwidthPercentageOptions.GetHashCode();
                if (this.UsbBandwidthPercentageEnable != null) hashCode = hashCode * 59 + this.UsbBandwidthPercentageEnable.GetHashCode();
                if (this.UsbBandwidthPercentageOptions != null) hashCode = hashCode * 59 + this.UsbBandwidthPercentageOptions.GetHashCode();
                if (this.PcscBandwidthPercentageEnable != null) hashCode = hashCode * 59 + this.PcscBandwidthPercentageEnable.GetHashCode();
                if (this.PcscBandwidthPercentageOptions != null) hashCode = hashCode * 59 + this.PcscBandwidthPercentageOptions.GetHashCode();
                if (this.TwainBandwidthPercentageEnable != null) hashCode = hashCode * 59 + this.TwainBandwidthPercentageEnable.GetHashCode();
                if (this.TwainBandwidthPercentageOptions != null) hashCode = hashCode * 59 + this.TwainBandwidthPercentageOptions.GetHashCode();
                if (this.PrinterBandwidthPercentageEnable != null) hashCode = hashCode * 59 + this.PrinterBandwidthPercentageEnable.GetHashCode();
                if (this.PrinterBandwidthPercentageOptions != null) hashCode = hashCode * 59 + this.PrinterBandwidthPercentageOptions.GetHashCode();
                if (this.ComBandwidthPercentageEnable != null) hashCode = hashCode * 59 + this.ComBandwidthPercentageEnable.GetHashCode();
                if (this.ComBandwidthPercentageOptions != null) hashCode = hashCode * 59 + this.ComBandwidthPercentageOptions.GetHashCode();
                if (this.FileRedirectionBandwidthPercentageEnable != null) hashCode = hashCode * 59 + this.FileRedirectionBandwidthPercentageEnable.GetHashCode();
                if (this.FileRedirectionBandwidthPercentageOptions != null) hashCode = hashCode * 59 + this.FileRedirectionBandwidthPercentageOptions.GetHashCode();
                if (this.ClipboardBandwidthPercentageEnable != null) hashCode = hashCode * 59 + this.ClipboardBandwidthPercentageEnable.GetHashCode();
                if (this.ClipboardBandwidthPercentageOptions != null) hashCode = hashCode * 59 + this.ClipboardBandwidthPercentageOptions.GetHashCode();
                if (this.SecureChannelBandwidthPercentageEnable != null) hashCode = hashCode * 59 + this.SecureChannelBandwidthPercentageEnable.GetHashCode();
                if (this.SecureChannelBandwidthPercentageOptions != null) hashCode = hashCode * 59 + this.SecureChannelBandwidthPercentageOptions.GetHashCode();
                if (this.CameraBandwidthPercentageEnable != null) hashCode = hashCode * 59 + this.CameraBandwidthPercentageEnable.GetHashCode();
                if (this.CameraBandwidthPercentageOptions != null) hashCode = hashCode * 59 + this.CameraBandwidthPercentageOptions.GetHashCode();
                if (this.VirtualChannelBandwidthPercentageEnable != null) hashCode = hashCode * 59 + this.VirtualChannelBandwidthPercentageEnable.GetHashCode();
                if (this.VirtualChannelBandwidthPercentageOptions != null) hashCode = hashCode * 59 + this.VirtualChannelBandwidthPercentageOptions.GetHashCode();
                return hashCode;
            }
        }
    }
}
