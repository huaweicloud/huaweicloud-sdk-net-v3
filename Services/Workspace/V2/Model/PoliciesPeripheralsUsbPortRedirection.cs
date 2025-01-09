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
    /// USB端口重定向。
    /// </summary>
    public class PoliciesPeripheralsUsbPortRedirection 
    {

        /// <summary>
        /// 是否开启USB端口重定向。 false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("usb_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UsbEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesPeripheralsUsbPortRedirectionOptions Options { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesPeripheralsUsbPortRedirection {\n");
            sb.Append("  usbEnable: ").Append(UsbEnable).Append("\n");
            sb.Append("  options: ").Append(Options).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesPeripheralsUsbPortRedirection);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesPeripheralsUsbPortRedirection input)
        {
            if (input == null) return false;
            if (this.UsbEnable != input.UsbEnable || (this.UsbEnable != null && !this.UsbEnable.Equals(input.UsbEnable))) return false;
            if (this.Options != input.Options || (this.Options != null && !this.Options.Equals(input.Options))) return false;

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
                if (this.UsbEnable != null) hashCode = hashCode * 59 + this.UsbEnable.GetHashCode();
                if (this.Options != null) hashCode = hashCode * 59 + this.Options.GetHashCode();
                return hashCode;
            }
        }
    }
}
