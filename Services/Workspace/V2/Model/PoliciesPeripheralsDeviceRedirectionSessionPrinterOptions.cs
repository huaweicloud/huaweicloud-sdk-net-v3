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
    /// 会话打印机控制选项。
    /// </summary>
    public class PoliciesPeripheralsDeviceRedirectionSessionPrinterOptions 
    {

        /// <summary>
        /// 会话打印机自定义策略。
        /// </summary>
        [JsonProperty("session_printer_customization_policy", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionPrinterCustomizationPolicy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesPeripheralsDeviceRedirectionSessionPrinterOptions {\n");
            sb.Append("  sessionPrinterCustomizationPolicy: ").Append(SessionPrinterCustomizationPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesPeripheralsDeviceRedirectionSessionPrinterOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesPeripheralsDeviceRedirectionSessionPrinterOptions input)
        {
            if (input == null) return false;
            if (this.SessionPrinterCustomizationPolicy != input.SessionPrinterCustomizationPolicy || (this.SessionPrinterCustomizationPolicy != null && !this.SessionPrinterCustomizationPolicy.Equals(input.SessionPrinterCustomizationPolicy))) return false;

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
                if (this.SessionPrinterCustomizationPolicy != null) hashCode = hashCode * 59 + this.SessionPrinterCustomizationPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
