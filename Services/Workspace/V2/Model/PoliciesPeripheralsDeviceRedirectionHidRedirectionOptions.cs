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
    /// HID控制选项。
    /// </summary>
    public class PoliciesPeripheralsDeviceRedirectionHidRedirectionOptions 
    {

        /// <summary>
        /// HID重定向自定义策略。
        /// </summary>
        [JsonProperty("hid_redirection_customization_policy", NullValueHandling = NullValueHandling.Ignore)]
        public string HidRedirectionCustomizationPolicy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesPeripheralsDeviceRedirectionHidRedirectionOptions {\n");
            sb.Append("  hidRedirectionCustomizationPolicy: ").Append(HidRedirectionCustomizationPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesPeripheralsDeviceRedirectionHidRedirectionOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesPeripheralsDeviceRedirectionHidRedirectionOptions input)
        {
            if (input == null) return false;
            if (this.HidRedirectionCustomizationPolicy != input.HidRedirectionCustomizationPolicy || (this.HidRedirectionCustomizationPolicy != null && !this.HidRedirectionCustomizationPolicy.Equals(input.HidRedirectionCustomizationPolicy))) return false;

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
                if (this.HidRedirectionCustomizationPolicy != null) hashCode = hashCode * 59 + this.HidRedirectionCustomizationPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
