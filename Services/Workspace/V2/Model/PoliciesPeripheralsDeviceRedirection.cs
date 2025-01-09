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
        /// 图形压缩级别。取值为： 不压缩：none。 低（速度最快）：low。 中（速度适中）：medium。 高（速度最慢）：high。 无损（无损压缩）：lossless。 低损（低损压缩）：low-loss。 中损（中损压缩）：medium-loss。 高损（高损压缩）：high-loss。
        /// </summary>
        /// <value>图形压缩级别。取值为： 不压缩：none。 低（速度最快）：low。 中（速度适中）：medium。 高（速度最慢）：high。 无损（无损压缩）：lossless。 低损（低损压缩）：low-loss。 中损（中损压缩）：medium-loss。 高损（高损压缩）：high-loss。</value>
        [JsonConverter(typeof(EnumClassConverter<ImageCompressionLevelEnum>))]
        public class ImageCompressionLevelEnum
        {
            /// <summary>
            /// Enum NONE for value: none
            /// </summary>
            public static readonly ImageCompressionLevelEnum NONE = new ImageCompressionLevelEnum("none");

            /// <summary>
            /// Enum LOW for value: low
            /// </summary>
            public static readonly ImageCompressionLevelEnum LOW = new ImageCompressionLevelEnum("low");

            /// <summary>
            /// Enum MEDIUM for value: medium
            /// </summary>
            public static readonly ImageCompressionLevelEnum MEDIUM = new ImageCompressionLevelEnum("medium");

            /// <summary>
            /// Enum HIGH for value: high
            /// </summary>
            public static readonly ImageCompressionLevelEnum HIGH = new ImageCompressionLevelEnum("high");

            /// <summary>
            /// Enum LOSSLESS for value: lossless
            /// </summary>
            public static readonly ImageCompressionLevelEnum LOSSLESS = new ImageCompressionLevelEnum("lossless");

            /// <summary>
            /// Enum LOW_LOSS for value: low-loss
            /// </summary>
            public static readonly ImageCompressionLevelEnum LOW_LOSS = new ImageCompressionLevelEnum("low-loss");

            /// <summary>
            /// Enum MEDIUM_LOSS for value: medium-loss
            /// </summary>
            public static readonly ImageCompressionLevelEnum MEDIUM_LOSS = new ImageCompressionLevelEnum("medium-loss");

            /// <summary>
            /// Enum HIGH_LOSS for value: high-loss
            /// </summary>
            public static readonly ImageCompressionLevelEnum HIGH_LOSS = new ImageCompressionLevelEnum("high-loss");

            private static readonly Dictionary<string, ImageCompressionLevelEnum> StaticFields =
            new Dictionary<string, ImageCompressionLevelEnum>()
            {
                { "none", NONE },
                { "low", LOW },
                { "medium", MEDIUM },
                { "high", HIGH },
                { "lossless", LOSSLESS },
                { "low-loss", LOW_LOSS },
                { "medium-loss", MEDIUM_LOSS },
                { "high-loss", HIGH_LOSS },
            };

            private string _value;

            public ImageCompressionLevelEnum()
            {

            }

            public ImageCompressionLevelEnum(string value)
            {
                _value = value;
            }

            public static ImageCompressionLevelEnum FromValue(string value)
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

                if (this.Equals(obj as ImageCompressionLevelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ImageCompressionLevelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ImageCompressionLevelEnum a, ImageCompressionLevelEnum b)
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

            public static bool operator !=(ImageCompressionLevelEnum a, ImageCompressionLevelEnum b)
            {
                return !(a == b);
            }
        }


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
        public ImageCompressionLevelEnum ImageCompressionLevel { get; set; }
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
            if (this.ImageCompressionLevel != input.ImageCompressionLevel) return false;
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
                hashCode = hashCode * 59 + this.ImageCompressionLevel.GetHashCode();
                if (this.HidRedirection != null) hashCode = hashCode * 59 + this.HidRedirection.GetHashCode();
                return hashCode;
            }
        }
    }
}
