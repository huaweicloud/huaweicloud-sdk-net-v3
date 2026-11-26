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
    /// 双证书场景下的单个证书信息
    /// </summary>
    public class HttpsDetailCertificates 
    {

        /// <summary>
        /// **参数解释：** 证书类型 **约束限制：** 不涉及 **取值范围：** - server: 国际证书 - server_sm: 国密证书  **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("certificate_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateType { get; set; }

        /// <summary>
        /// **参数解释：** 证书来源 **约束限制：** 不涉及 **取值范围：** - 0: 自有证书 - 1: 云托管证书 - 2: SCM证书  **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("certificate_source", NullValueHandling = NullValueHandling.Ignore)]
        public int? CertificateSource { get; set; }

        /// <summary>
        /// **参数解释：** 证书名称 **约束限制：** 不涉及 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("certificate_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateName { get; set; }

        /// <summary>
        /// **参数解释：** 证书内容 **约束限制：** 不涉及 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("certificate_value", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateValue { get; set; }

        /// <summary>
        /// **参数解释：** 私钥内容 **约束限制：** 不涉及 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("private_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// **参数解释：** 国密证书加密证书内容 **约束限制：** 不涉及 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("enc_certificate_value", NullValueHandling = NullValueHandling.Ignore)]
        public string EncCertificateValue { get; set; }

        /// <summary>
        /// **参数解释：** 国密证书加密私钥内容 **约束限制：** 不涉及 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("enc_private_key", NullValueHandling = NullValueHandling.Ignore)]
        public string EncPrivateKey { get; set; }

        /// <summary>
        /// **参数解释：** 证书过期时间，Unix时间戳格式，单位为毫秒 **约束限制：** 不涉及 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// **参数解释：** SCM证书ID **约束限制：** 不涉及 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("scm_certificate_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScmCertificateId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HttpsDetailCertificates {\n");
            sb.Append("  certificateType: ").Append(CertificateType).Append("\n");
            sb.Append("  certificateSource: ").Append(CertificateSource).Append("\n");
            sb.Append("  certificateName: ").Append(CertificateName).Append("\n");
            sb.Append("  certificateValue: ").Append(CertificateValue).Append("\n");
            sb.Append("  privateKey: ").Append(PrivateKey).Append("\n");
            sb.Append("  encCertificateValue: ").Append(EncCertificateValue).Append("\n");
            sb.Append("  encPrivateKey: ").Append(EncPrivateKey).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  scmCertificateId: ").Append(ScmCertificateId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HttpsDetailCertificates);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HttpsDetailCertificates input)
        {
            if (input == null) return false;
            if (this.CertificateType != input.CertificateType || (this.CertificateType != null && !this.CertificateType.Equals(input.CertificateType))) return false;
            if (this.CertificateSource != input.CertificateSource || (this.CertificateSource != null && !this.CertificateSource.Equals(input.CertificateSource))) return false;
            if (this.CertificateName != input.CertificateName || (this.CertificateName != null && !this.CertificateName.Equals(input.CertificateName))) return false;
            if (this.CertificateValue != input.CertificateValue || (this.CertificateValue != null && !this.CertificateValue.Equals(input.CertificateValue))) return false;
            if (this.PrivateKey != input.PrivateKey || (this.PrivateKey != null && !this.PrivateKey.Equals(input.PrivateKey))) return false;
            if (this.EncCertificateValue != input.EncCertificateValue || (this.EncCertificateValue != null && !this.EncCertificateValue.Equals(input.EncCertificateValue))) return false;
            if (this.EncPrivateKey != input.EncPrivateKey || (this.EncPrivateKey != null && !this.EncPrivateKey.Equals(input.EncPrivateKey))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;
            if (this.ScmCertificateId != input.ScmCertificateId || (this.ScmCertificateId != null && !this.ScmCertificateId.Equals(input.ScmCertificateId))) return false;

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
                if (this.CertificateType != null) hashCode = hashCode * 59 + this.CertificateType.GetHashCode();
                if (this.CertificateSource != null) hashCode = hashCode * 59 + this.CertificateSource.GetHashCode();
                if (this.CertificateName != null) hashCode = hashCode * 59 + this.CertificateName.GetHashCode();
                if (this.CertificateValue != null) hashCode = hashCode * 59 + this.CertificateValue.GetHashCode();
                if (this.PrivateKey != null) hashCode = hashCode * 59 + this.PrivateKey.GetHashCode();
                if (this.EncCertificateValue != null) hashCode = hashCode * 59 + this.EncCertificateValue.GetHashCode();
                if (this.EncPrivateKey != null) hashCode = hashCode * 59 + this.EncPrivateKey.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                if (this.ScmCertificateId != null) hashCode = hashCode * 59 + this.ScmCertificateId.GetHashCode();
                return hashCode;
            }
        }
    }
}
