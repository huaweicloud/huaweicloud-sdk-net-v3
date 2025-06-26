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
    /// USB和设备智能卡共同控制的选项。
    /// </summary>
    public class PoliciesPeripheralsUsbDeviceCommonCommonOptions 
    {

        /// <summary>
        /// 是否移除智能卡断开用户会话。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("remove_smart_card_disconnect_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RemoveSmartCardDisconnectEnable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesPeripheralsUsbDeviceCommonCommonOptions {\n");
            sb.Append("  removeSmartCardDisconnectEnable: ").Append(RemoveSmartCardDisconnectEnable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesPeripheralsUsbDeviceCommonCommonOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesPeripheralsUsbDeviceCommonCommonOptions input)
        {
            if (input == null) return false;
            if (this.RemoveSmartCardDisconnectEnable != input.RemoveSmartCardDisconnectEnable || (this.RemoveSmartCardDisconnectEnable != null && !this.RemoveSmartCardDisconnectEnable.Equals(input.RemoveSmartCardDisconnectEnable))) return false;

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
                if (this.RemoveSmartCardDisconnectEnable != null) hashCode = hashCode * 59 + this.RemoveSmartCardDisconnectEnable.GetHashCode();
                return hashCode;
            }
        }
    }
}
