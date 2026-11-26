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
    /// **参数解释：** 双证书场景下的单个证书配置项 **约束限制：** 不涉及
    /// </summary>
    public class MultiCertificateBatchVo 
    {

        /// <summary>
        /// **参数解释：** 证书名称 **约束限制：** 不涉及 **取值范围：** - 3-64个字符 - 由英文字母、数字及“-”、“_”、空格组成  **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("cert_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CertName { get; set; }

        /// <summary>
        /// **参数解释：** 证书类型 **约束限制：** 不涉及 **取值范围：** - 0: 国际证书 - 1: 国密证书  **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("certificate_category", NullValueHandling = NullValueHandling.Ignore)]
        public int? CertificateCategory { get; set; }

        /// <summary>
        /// **参数解释：** 证书类型 **约束限制：** 不涉及 **取值范围：** - 0: 自有证书 - 1: 云托管证书 - 2: SCM证书  **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("certificate_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? CertificateType { get; set; }

        /// <summary>
        /// **参数解释：** SSL证书内容 **约束限制：** - 仅支持PEM编码格式 - 需要传入完整证书链  **取值范围：** 证书链长度不超过20KB **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("certificate", NullValueHandling = NullValueHandling.Ignore)]
        public string Certificate { get; set; }

        /// <summary>
        /// **参数解释：** SSL证书私钥内容 **约束限制：** - 仅支持PEM编码格式  **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("private_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// **参数解释：** 国密证书加密证书内容 **约束限制：** certificate_category 为 1 且 certificate_type 为 0 时必传，须与 enc_private_key 同时传入 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("enc_certificate", NullValueHandling = NullValueHandling.Ignore)]
        public string EncCertificate { get; set; }

        /// <summary>
        /// **参数解释：** 国密证书加密私钥内容 **约束限制：** certificate_category 为 1 且 certificate_type 为 0 时必传，须与 enc_certificate 同时传入 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("enc_private_key", NullValueHandling = NullValueHandling.Ignore)]
        public string EncPrivateKey { get; set; }

        /// <summary>
        /// **参数解释：** SCM证书ID，配置SCM证书时必传 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("scm_certificate_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScmCertificateId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MultiCertificateBatchVo {\n");
            sb.Append("  certName: ").Append(CertName).Append("\n");
            sb.Append("  certificateCategory: ").Append(CertificateCategory).Append("\n");
            sb.Append("  certificateType: ").Append(CertificateType).Append("\n");
            sb.Append("  certificate: ").Append(Certificate).Append("\n");
            sb.Append("  privateKey: ").Append(PrivateKey).Append("\n");
            sb.Append("  encCertificate: ").Append(EncCertificate).Append("\n");
            sb.Append("  encPrivateKey: ").Append(EncPrivateKey).Append("\n");
            sb.Append("  scmCertificateId: ").Append(ScmCertificateId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MultiCertificateBatchVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MultiCertificateBatchVo input)
        {
            if (input == null) return false;
            if (this.CertName != input.CertName || (this.CertName != null && !this.CertName.Equals(input.CertName))) return false;
            if (this.CertificateCategory != input.CertificateCategory || (this.CertificateCategory != null && !this.CertificateCategory.Equals(input.CertificateCategory))) return false;
            if (this.CertificateType != input.CertificateType || (this.CertificateType != null && !this.CertificateType.Equals(input.CertificateType))) return false;
            if (this.Certificate != input.Certificate || (this.Certificate != null && !this.Certificate.Equals(input.Certificate))) return false;
            if (this.PrivateKey != input.PrivateKey || (this.PrivateKey != null && !this.PrivateKey.Equals(input.PrivateKey))) return false;
            if (this.EncCertificate != input.EncCertificate || (this.EncCertificate != null && !this.EncCertificate.Equals(input.EncCertificate))) return false;
            if (this.EncPrivateKey != input.EncPrivateKey || (this.EncPrivateKey != null && !this.EncPrivateKey.Equals(input.EncPrivateKey))) return false;
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
                if (this.CertName != null) hashCode = hashCode * 59 + this.CertName.GetHashCode();
                if (this.CertificateCategory != null) hashCode = hashCode * 59 + this.CertificateCategory.GetHashCode();
                if (this.CertificateType != null) hashCode = hashCode * 59 + this.CertificateType.GetHashCode();
                if (this.Certificate != null) hashCode = hashCode * 59 + this.Certificate.GetHashCode();
                if (this.PrivateKey != null) hashCode = hashCode * 59 + this.PrivateKey.GetHashCode();
                if (this.EncCertificate != null) hashCode = hashCode * 59 + this.EncCertificate.GetHashCode();
                if (this.EncPrivateKey != null) hashCode = hashCode * 59 + this.EncPrivateKey.GetHashCode();
                if (this.ScmCertificateId != null) hashCode = hashCode * 59 + this.ScmCertificateId.GetHashCode();
                return hashCode;
            }
        }
    }
}
