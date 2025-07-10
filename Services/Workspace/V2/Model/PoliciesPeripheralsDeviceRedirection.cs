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
    /// 设备重定向。
    /// </summary>
    public class PoliciesPeripheralsDeviceRedirection 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("printer_redirection", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesPeripheralsDeviceRedirectionPrinterRedirection PrinterRedirection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("session_printer", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesPeripheralsDeviceRedirectionSessionPrinter SessionPrinter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("camera_redirection", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesPeripheralsDeviceRedirectionCameraRedirection CameraRedirection { get; set; }

        /// <summary>
        /// 是否开启TWAIN设备重定向。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("twain_redirection_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TwainRedirectionEnable { get; set; }

        /// <summary>
        /// 图形压缩级别。取值为： 不压缩：none。 低（速度最快）：low。 中（速度适中）：medium。 高（速度最慢）：high。 无损（无损压缩）：lossless。 低损（低损压缩）：low-loss。 中损（中损压缩）：medium-loss。 高损（高损压缩）：high-loss。
        /// </summary>
        [JsonProperty("image_compression_level", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageCompressionLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hid_redirection", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesPeripheralsDeviceRedirectionHidRedirection HidRedirection { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesPeripheralsDeviceRedirection {\n");
            sb.Append("  printerRedirection: ").Append(PrinterRedirection).Append("\n");
            sb.Append("  sessionPrinter: ").Append(SessionPrinter).Append("\n");
            sb.Append("  cameraRedirection: ").Append(CameraRedirection).Append("\n");
            sb.Append("  twainRedirectionEnable: ").Append(TwainRedirectionEnable).Append("\n");
            sb.Append("  imageCompressionLevel: ").Append(ImageCompressionLevel).Append("\n");
            sb.Append("  hidRedirection: ").Append(HidRedirection).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesPeripheralsDeviceRedirection);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesPeripheralsDeviceRedirection input)
        {
            if (input == null) return false;
            if (this.PrinterRedirection != input.PrinterRedirection || (this.PrinterRedirection != null && !this.PrinterRedirection.Equals(input.PrinterRedirection))) return false;
            if (this.SessionPrinter != input.SessionPrinter || (this.SessionPrinter != null && !this.SessionPrinter.Equals(input.SessionPrinter))) return false;
            if (this.CameraRedirection != input.CameraRedirection || (this.CameraRedirection != null && !this.CameraRedirection.Equals(input.CameraRedirection))) return false;
            if (this.TwainRedirectionEnable != input.TwainRedirectionEnable || (this.TwainRedirectionEnable != null && !this.TwainRedirectionEnable.Equals(input.TwainRedirectionEnable))) return false;
            if (this.ImageCompressionLevel != input.ImageCompressionLevel || (this.ImageCompressionLevel != null && !this.ImageCompressionLevel.Equals(input.ImageCompressionLevel))) return false;
            if (this.HidRedirection != input.HidRedirection || (this.HidRedirection != null && !this.HidRedirection.Equals(input.HidRedirection))) return false;

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
                if (this.PrinterRedirection != null) hashCode = hashCode * 59 + this.PrinterRedirection.GetHashCode();
                if (this.SessionPrinter != null) hashCode = hashCode * 59 + this.SessionPrinter.GetHashCode();
                if (this.CameraRedirection != null) hashCode = hashCode * 59 + this.CameraRedirection.GetHashCode();
                if (this.TwainRedirectionEnable != null) hashCode = hashCode * 59 + this.TwainRedirectionEnable.GetHashCode();
                if (this.ImageCompressionLevel != null) hashCode = hashCode * 59 + this.ImageCompressionLevel.GetHashCode();
                if (this.HidRedirection != null) hashCode = hashCode * 59 + this.HidRedirection.GetHashCode();
                return hashCode;
            }
        }
    }
}
