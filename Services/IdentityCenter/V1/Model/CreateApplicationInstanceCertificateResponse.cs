using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenter.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateApplicationInstanceCertificateResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("application_instance_certificate", NullValueHandling = NullValueHandling.Ignore)]
        public CertificateDto ApplicationInstanceCertificate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateApplicationInstanceCertificateResponse {\n");
            sb.Append("  applicationInstanceCertificate: ").Append(ApplicationInstanceCertificate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateApplicationInstanceCertificateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateApplicationInstanceCertificateResponse input)
        {
            if (input == null) return false;
            if (this.ApplicationInstanceCertificate != input.ApplicationInstanceCertificate || (this.ApplicationInstanceCertificate != null && !this.ApplicationInstanceCertificate.Equals(input.ApplicationInstanceCertificate))) return false;

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
                if (this.ApplicationInstanceCertificate != null) hashCode = hashCode * 59 + this.ApplicationInstanceCertificate.GetHashCode();
                return hashCode;
            }
        }
    }
}
