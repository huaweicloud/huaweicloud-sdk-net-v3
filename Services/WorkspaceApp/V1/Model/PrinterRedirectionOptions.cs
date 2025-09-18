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
    /// 打印机设备重定向控制的选项。
    /// </summary>
    public class PrinterRedirectionOptions 
    {
        /// <summary>
        /// 通用打印机驱动。取值为：- Default：linux客户端选择Universal Printing- PS，windows客户端选择HDP XPSDrv Driver。- HDP XPSDrv Driver。- Universal Printing PCL 5。- Universal Printing PCL 6。- Universal Printing PS。
        /// </summary>
        /// <value>通用打印机驱动。取值为：- Default：linux客户端选择Universal Printing- PS，windows客户端选择HDP XPSDrv Driver。- HDP XPSDrv Driver。- Universal Printing PCL 5。- Universal Printing PCL 6。- Universal Printing PS。</value>
        [JsonConverter(typeof(EnumClassConverter<UniversalPrinterDriverEnum>))]
        public class UniversalPrinterDriverEnum
        {
            /// <summary>
            /// Enum DEFAULT for value: Default
            /// </summary>
            public static readonly UniversalPrinterDriverEnum DEFAULT = new UniversalPrinterDriverEnum("Default");

            /// <summary>
            /// Enum HDP_XPSDRV_DRIVER for value: HDP XPSDrv Driver
            /// </summary>
            public static readonly UniversalPrinterDriverEnum HDP_XPSDRV_DRIVER = new UniversalPrinterDriverEnum("HDP XPSDrv Driver");

            /// <summary>
            /// Enum UNIVERSAL_PRINTING_PCL_5 for value: Universal Printing PCL 5
            /// </summary>
            public static readonly UniversalPrinterDriverEnum UNIVERSAL_PRINTING_PCL_5 = new UniversalPrinterDriverEnum("Universal Printing PCL 5");

            /// <summary>
            /// Enum UNIVERSAL_PRINTING_PCL_6 for value: Universal Printing PCL 6
            /// </summary>
            public static readonly UniversalPrinterDriverEnum UNIVERSAL_PRINTING_PCL_6 = new UniversalPrinterDriverEnum("Universal Printing PCL 6");

            /// <summary>
            /// Enum UNIVERSAL_PRINTING_PS for value: Universal Printing PS
            /// </summary>
            public static readonly UniversalPrinterDriverEnum UNIVERSAL_PRINTING_PS = new UniversalPrinterDriverEnum("Universal Printing PS");

            private static readonly Dictionary<string, UniversalPrinterDriverEnum> StaticFields =
            new Dictionary<string, UniversalPrinterDriverEnum>()
            {
                { "Default", DEFAULT },
                { "HDP XPSDrv Driver", HDP_XPSDRV_DRIVER },
                { "Universal Printing PCL 5", UNIVERSAL_PRINTING_PCL_5 },
                { "Universal Printing PCL 6", UNIVERSAL_PRINTING_PCL_6 },
                { "Universal Printing PS", UNIVERSAL_PRINTING_PS },
            };

            private string _value;

            public UniversalPrinterDriverEnum()
            {

            }

            public UniversalPrinterDriverEnum(string value)
            {
                _value = value;
            }

            public static UniversalPrinterDriverEnum FromValue(string value)
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

                if (this.Equals(obj as UniversalPrinterDriverEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(UniversalPrinterDriverEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(UniversalPrinterDriverEnum a, UniversalPrinterDriverEnum b)
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

            public static bool operator !=(UniversalPrinterDriverEnum a, UniversalPrinterDriverEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 是否开启同步客户端默认打印机。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("sync_client_default_printer_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncClientDefaultPrinterEnable { get; set; }

        /// <summary>
        /// 通用打印机驱动。取值为：- Default：linux客户端选择Universal Printing- PS，windows客户端选择HDP XPSDrv Driver。- HDP XPSDrv Driver。- Universal Printing PCL 5。- Universal Printing PCL 6。- Universal Printing PS。
        /// </summary>
        [JsonProperty("universal_printer_driver", NullValueHandling = NullValueHandling.Ignore)]
        public UniversalPrinterDriverEnum UniversalPrinterDriver { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrinterRedirectionOptions {\n");
            sb.Append("  syncClientDefaultPrinterEnable: ").Append(SyncClientDefaultPrinterEnable).Append("\n");
            sb.Append("  universalPrinterDriver: ").Append(UniversalPrinterDriver).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrinterRedirectionOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrinterRedirectionOptions input)
        {
            if (input == null) return false;
            if (this.SyncClientDefaultPrinterEnable != input.SyncClientDefaultPrinterEnable || (this.SyncClientDefaultPrinterEnable != null && !this.SyncClientDefaultPrinterEnable.Equals(input.SyncClientDefaultPrinterEnable))) return false;
            if (this.UniversalPrinterDriver != input.UniversalPrinterDriver) return false;

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
                if (this.SyncClientDefaultPrinterEnable != null) hashCode = hashCode * 59 + this.SyncClientDefaultPrinterEnable.GetHashCode();
                hashCode = hashCode * 59 + this.UniversalPrinterDriver.GetHashCode();
                return hashCode;
            }
        }
    }
}
