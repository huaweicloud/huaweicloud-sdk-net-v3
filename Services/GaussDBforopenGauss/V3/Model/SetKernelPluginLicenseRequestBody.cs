using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SetKernelPluginLicenseRequestBody 
    {

        /// <summary>
        /// license
        /// </summary>
        [JsonProperty("license_str", NullValueHandling = NullValueHandling.Ignore)]
        public string LicenseStr { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetKernelPluginLicenseRequestBody {\n");
            sb.Append("  licenseStr: ").Append(LicenseStr).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetKernelPluginLicenseRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetKernelPluginLicenseRequestBody input)
        {
            if (input == null) return false;
            if (this.LicenseStr != input.LicenseStr || (this.LicenseStr != null && !this.LicenseStr.Equals(input.LicenseStr))) return false;

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
                if (this.LicenseStr != null) hashCode = hashCode * 59 + this.LicenseStr.GetHashCode();
                return hashCode;
            }
        }
    }
}
