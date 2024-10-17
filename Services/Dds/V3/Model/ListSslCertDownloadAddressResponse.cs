using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListSslCertDownloadAddressResponse : SdkResponse
    {

        /// <summary>
        /// 证书列表
        /// </summary>
        [JsonProperty("certs", NullValueHandling = NullValueHandling.Ignore)]
        public List<CertInfo> Certs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSslCertDownloadAddressResponse {\n");
            sb.Append("  certs: ").Append(Certs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSslCertDownloadAddressResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSslCertDownloadAddressResponse input)
        {
            if (input == null) return false;
            if (this.Certs != input.Certs || (this.Certs != null && input.Certs != null && !this.Certs.SequenceEqual(input.Certs))) return false;

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
                if (this.Certs != null) hashCode = hashCode * 59 + this.Certs.GetHashCode();
                return hashCode;
            }
        }
    }
}
