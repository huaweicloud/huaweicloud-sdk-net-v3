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
    public class ListApplicationInstanceCertificatesResponse : SdkResponse
    {

        /// <summary>
        /// 应用程序证书列表
        /// </summary>
        [JsonProperty("application_instance_certificates", NullValueHandling = NullValueHandling.Ignore)]
        public List<CertificateDto> ApplicationInstanceCertificates { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page_info", NullValueHandling = NullValueHandling.Ignore)]
        public PageInfoDto PageInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListApplicationInstanceCertificatesResponse {\n");
            sb.Append("  applicationInstanceCertificates: ").Append(ApplicationInstanceCertificates).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListApplicationInstanceCertificatesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListApplicationInstanceCertificatesResponse input)
        {
            if (input == null) return false;
            if (this.ApplicationInstanceCertificates != input.ApplicationInstanceCertificates || (this.ApplicationInstanceCertificates != null && input.ApplicationInstanceCertificates != null && !this.ApplicationInstanceCertificates.SequenceEqual(input.ApplicationInstanceCertificates))) return false;
            if (this.PageInfo != input.PageInfo || (this.PageInfo != null && !this.PageInfo.Equals(input.PageInfo))) return false;

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
                if (this.ApplicationInstanceCertificates != null) hashCode = hashCode * 59 + this.ApplicationInstanceCertificates.GetHashCode();
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
