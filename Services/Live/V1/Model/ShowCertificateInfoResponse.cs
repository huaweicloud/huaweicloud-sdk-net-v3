using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowCertificateInfoResponse : SdkResponse
    {

        /// <summary>
        /// 查询结果的总数量
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Total { get; set; }

        /// <summary>
        /// 证书信息列表
        /// </summary>
        [JsonProperty("certificates_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<CertInfoResp> CertificatesInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowCertificateInfoResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  certificatesInfo: ").Append(CertificatesInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowCertificateInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowCertificateInfoResponse input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.CertificatesInfo != input.CertificatesInfo || (this.CertificatesInfo != null && input.CertificatesInfo != null && !this.CertificatesInfo.SequenceEqual(input.CertificatesInfo))) return false;

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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.CertificatesInfo != null) hashCode = hashCode * 59 + this.CertificatesInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
