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
    /// USB和设备智能卡控制选项。
    /// </summary>
    public class PoliciesPeripheralsUsbDeviceCommon 
    {

        /// <summary>
        /// 是否开启PC/SC智能卡重定向。取值为： Enable：表示已启动。 Closed：表示已关闭。 Disable：表示已禁用。
        /// </summary>
        [JsonProperty("pcsc_smart_card_enable", NullValueHandling = NullValueHandling.Ignore)]
        public string PcscSmartCardEnable { get; set; }

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
            if (this.PcscSmartCardEnable != input.PcscSmartCardEnable || (this.PcscSmartCardEnable != null && !this.PcscSmartCardEnable.Equals(input.PcscSmartCardEnable))) return false;
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
                if (this.PcscSmartCardEnable != null) hashCode = hashCode * 59 + this.PcscSmartCardEnable.GetHashCode();
                if (this.CommonOptions != null) hashCode = hashCode * 59 + this.CommonOptions.GetHashCode();
                return hashCode;
            }
        }
    }
}
