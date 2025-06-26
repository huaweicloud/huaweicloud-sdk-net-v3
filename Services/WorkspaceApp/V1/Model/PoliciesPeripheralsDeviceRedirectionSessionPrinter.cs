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
    /// 会话打印机。
    /// </summary>
    public class PoliciesPeripheralsDeviceRedirectionSessionPrinter 
    {

        /// <summary>
        /// 是否开启会话打印机。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("session_printer_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SessionPrinterEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public SessionPrinterOptions Options { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesPeripheralsDeviceRedirectionSessionPrinter {\n");
            sb.Append("  sessionPrinterEnable: ").Append(SessionPrinterEnable).Append("\n");
            sb.Append("  options: ").Append(Options).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesPeripheralsDeviceRedirectionSessionPrinter);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesPeripheralsDeviceRedirectionSessionPrinter input)
        {
            if (input == null) return false;
            if (this.SessionPrinterEnable != input.SessionPrinterEnable || (this.SessionPrinterEnable != null && !this.SessionPrinterEnable.Equals(input.SessionPrinterEnable))) return false;
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
                if (this.SessionPrinterEnable != null) hashCode = hashCode * 59 + this.SessionPrinterEnable.GetHashCode();
                if (this.Options != null) hashCode = hashCode * 59 + this.Options.GetHashCode();
                return hashCode;
            }
        }
    }
}
