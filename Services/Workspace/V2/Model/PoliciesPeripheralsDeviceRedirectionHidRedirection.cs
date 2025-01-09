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
    /// HID（人体学设备）重定向。
    /// </summary>
    public class PoliciesPeripheralsDeviceRedirectionHidRedirection 
    {

        /// <summary>
        /// 是否开启HID（人体学设备）重定向。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("hid_redirection_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HidRedirectionEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesPeripheralsDeviceRedirectionHidRedirectionOptions Options { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesPeripheralsDeviceRedirectionHidRedirection {\n");
            sb.Append("  hidRedirectionEnable: ").Append(HidRedirectionEnable).Append("\n");
            sb.Append("  options: ").Append(Options).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesPeripheralsDeviceRedirectionHidRedirection);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesPeripheralsDeviceRedirectionHidRedirection input)
        {
            if (input == null) return false;
            if (this.HidRedirectionEnable != input.HidRedirectionEnable || (this.HidRedirectionEnable != null && !this.HidRedirectionEnable.Equals(input.HidRedirectionEnable))) return false;
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
                if (this.HidRedirectionEnable != null) hashCode = hashCode * 59 + this.HidRedirectionEnable.GetHashCode();
                if (this.Options != null) hashCode = hashCode * 59 + this.Options.GetHashCode();
                return hashCode;
            }
        }
    }
}
