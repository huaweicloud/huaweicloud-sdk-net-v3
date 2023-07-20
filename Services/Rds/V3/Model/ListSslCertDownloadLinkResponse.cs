using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListSslCertDownloadLinkResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cert_info_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<DownloadInfoRsp> CertInfoList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSslCertDownloadLinkResponse {\n");
            sb.Append("  certInfoList: ").Append(CertInfoList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSslCertDownloadLinkResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSslCertDownloadLinkResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CertInfoList == input.CertInfoList ||
                    this.CertInfoList != null &&
                    input.CertInfoList != null &&
                    this.CertInfoList.SequenceEqual(input.CertInfoList)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.CertInfoList != null)
                    hashCode = hashCode * 59 + this.CertInfoList.GetHashCode();
                return hashCode;
            }
        }
    }
}
