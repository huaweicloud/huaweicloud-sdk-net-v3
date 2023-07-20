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
    /// Response Object
    /// </summary>
    public class ShowSslCertDownloadLinkResponse : SdkResponse
    {

        /// <summary>
        /// ssl下载链接。
        /// </summary>
        [JsonProperty("download_link", NullValueHandling = NullValueHandling.Ignore)]
        public string DownloadLink { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSslCertDownloadLinkResponse {\n");
            sb.Append("  downloadLink: ").Append(DownloadLink).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSslCertDownloadLinkResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSslCertDownloadLinkResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DownloadLink == input.DownloadLink ||
                    (this.DownloadLink != null &&
                    this.DownloadLink.Equals(input.DownloadLink))
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
                if (this.DownloadLink != null)
                    hashCode = hashCode * 59 + this.DownloadLink.GetHashCode();
                return hashCode;
            }
        }
    }
}
