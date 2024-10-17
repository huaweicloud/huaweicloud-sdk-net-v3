using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// 双证书配置查询响应体。
    /// </summary>
    public class CertificatesGetBody 
    {

        /// <summary>
        /// 证书来源,0：自有证书。2：SCM证书。
        /// </summary>
        [JsonProperty("certificate_source", NullValueHandling = NullValueHandling.Ignore)]
        public int? CertificateSource { get; set; }

        /// <summary>
        /// SCM证书id
        /// </summary>
        [JsonProperty("scm_certificate_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScmCertificateId { get; set; }

        /// <summary>
        /// 证书类型，server：国际证书；server_sm：国密证书。
        /// </summary>
        [JsonProperty("certificate_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateType { get; set; }

        /// <summary>
        /// 证书名字。
        /// </summary>
        [JsonProperty("certificate_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateName { get; set; }

        /// <summary>
        /// HTTPS协议使用的证书内容，PEM编码格式。
        /// </summary>
        [JsonProperty("certificate_value", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateValue { get; set; }

        /// <summary>
        /// 国密证书加密证书内容，PEM编码格式。
        /// </summary>
        [JsonProperty("enc_certificate_value", NullValueHandling = NullValueHandling.Ignore)]
        public string EncCertificateValue { get; set; }

        /// <summary>
        /// 证书过期时间。  &gt; UTC时间。
        /// </summary>
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExpireTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CertificatesGetBody {\n");
            sb.Append("  certificateSource: ").Append(CertificateSource).Append("\n");
            sb.Append("  scmCertificateId: ").Append(ScmCertificateId).Append("\n");
            sb.Append("  certificateType: ").Append(CertificateType).Append("\n");
            sb.Append("  certificateName: ").Append(CertificateName).Append("\n");
            sb.Append("  certificateValue: ").Append(CertificateValue).Append("\n");
            sb.Append("  encCertificateValue: ").Append(EncCertificateValue).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CertificatesGetBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CertificatesGetBody input)
        {
            if (input == null) return false;
            if (this.CertificateSource != input.CertificateSource || (this.CertificateSource != null && !this.CertificateSource.Equals(input.CertificateSource))) return false;
            if (this.ScmCertificateId != input.ScmCertificateId || (this.ScmCertificateId != null && !this.ScmCertificateId.Equals(input.ScmCertificateId))) return false;
            if (this.CertificateType != input.CertificateType || (this.CertificateType != null && !this.CertificateType.Equals(input.CertificateType))) return false;
            if (this.CertificateName != input.CertificateName || (this.CertificateName != null && !this.CertificateName.Equals(input.CertificateName))) return false;
            if (this.CertificateValue != input.CertificateValue || (this.CertificateValue != null && !this.CertificateValue.Equals(input.CertificateValue))) return false;
            if (this.EncCertificateValue != input.EncCertificateValue || (this.EncCertificateValue != null && !this.EncCertificateValue.Equals(input.EncCertificateValue))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;

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
                if (this.CertificateSource != null) hashCode = hashCode * 59 + this.CertificateSource.GetHashCode();
                if (this.ScmCertificateId != null) hashCode = hashCode * 59 + this.ScmCertificateId.GetHashCode();
                if (this.CertificateType != null) hashCode = hashCode * 59 + this.CertificateType.GetHashCode();
                if (this.CertificateName != null) hashCode = hashCode * 59 + this.CertificateName.GetHashCode();
                if (this.CertificateValue != null) hashCode = hashCode * 59 + this.CertificateValue.GetHashCode();
                if (this.EncCertificateValue != null) hashCode = hashCode * 59 + this.EncCertificateValue.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
