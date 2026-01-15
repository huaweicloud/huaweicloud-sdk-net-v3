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
    /// 打印机设备重定向控制的选项。
    /// </summary>
    public class PoliciesPeripheralsDeviceRedirectionPrinterRedirectionOptions 
    {

        /// <summary>
        /// 移动客户端打印机重定向。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("mobile_printer_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MobilePrinterEnable { get; set; }

        /// <summary>
        /// 是否开启打印数据压缩模式。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("print_data_compression_mode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PrintDataCompressionMode { get; set; }

        /// <summary>
        /// 是否开启同步客户端默认打印机。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("sync_client_default_printer_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncClientDefaultPrinterEnable { get; set; }

        /// <summary>
        /// 通用打印机驱动。取值为：Default：linux客户端选择Universal Printing PS，windows客户端选择HDP XPSDrv Driver。HDP XPSDrv Driver。Universal Printing PCL 5。Universal Printing PCL 6。Universal Printing PS。
        /// </summary>
        [JsonProperty("universal_printer_driver", NullValueHandling = NullValueHandling.Ignore)]
        public string UniversalPrinterDriver { get; set; }

        /// <summary>
        /// 是否开启使用端侧网络连接网络打印机开关。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("network_redirect_printer_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NetworkRedirectPrinterEnable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesPeripheralsDeviceRedirectionPrinterRedirectionOptions {\n");
            sb.Append("  mobilePrinterEnable: ").Append(MobilePrinterEnable).Append("\n");
            sb.Append("  printDataCompressionMode: ").Append(PrintDataCompressionMode).Append("\n");
            sb.Append("  syncClientDefaultPrinterEnable: ").Append(SyncClientDefaultPrinterEnable).Append("\n");
            sb.Append("  universalPrinterDriver: ").Append(UniversalPrinterDriver).Append("\n");
            sb.Append("  networkRedirectPrinterEnable: ").Append(NetworkRedirectPrinterEnable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesPeripheralsDeviceRedirectionPrinterRedirectionOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesPeripheralsDeviceRedirectionPrinterRedirectionOptions input)
        {
            if (input == null) return false;
            if (this.MobilePrinterEnable != input.MobilePrinterEnable || (this.MobilePrinterEnable != null && !this.MobilePrinterEnable.Equals(input.MobilePrinterEnable))) return false;
            if (this.PrintDataCompressionMode != input.PrintDataCompressionMode || (this.PrintDataCompressionMode != null && !this.PrintDataCompressionMode.Equals(input.PrintDataCompressionMode))) return false;
            if (this.SyncClientDefaultPrinterEnable != input.SyncClientDefaultPrinterEnable || (this.SyncClientDefaultPrinterEnable != null && !this.SyncClientDefaultPrinterEnable.Equals(input.SyncClientDefaultPrinterEnable))) return false;
            if (this.UniversalPrinterDriver != input.UniversalPrinterDriver || (this.UniversalPrinterDriver != null && !this.UniversalPrinterDriver.Equals(input.UniversalPrinterDriver))) return false;
            if (this.NetworkRedirectPrinterEnable != input.NetworkRedirectPrinterEnable || (this.NetworkRedirectPrinterEnable != null && !this.NetworkRedirectPrinterEnable.Equals(input.NetworkRedirectPrinterEnable))) return false;

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
                if (this.MobilePrinterEnable != null) hashCode = hashCode * 59 + this.MobilePrinterEnable.GetHashCode();
                if (this.PrintDataCompressionMode != null) hashCode = hashCode * 59 + this.PrintDataCompressionMode.GetHashCode();
                if (this.SyncClientDefaultPrinterEnable != null) hashCode = hashCode * 59 + this.SyncClientDefaultPrinterEnable.GetHashCode();
                if (this.UniversalPrinterDriver != null) hashCode = hashCode * 59 + this.UniversalPrinterDriver.GetHashCode();
                if (this.NetworkRedirectPrinterEnable != null) hashCode = hashCode * 59 + this.NetworkRedirectPrinterEnable.GetHashCode();
                return hashCode;
            }
        }
    }
}
