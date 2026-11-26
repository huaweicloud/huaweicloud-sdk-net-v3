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
    /// **参数解释：** 在CDN节点添加证书，支持客户端以HTTPS协议访问节点，实现HTTPS安全加速 **约束限制：** 不涉及
    /// </summary>
    public class HttpTemplateBody 
    {

        /// <summary>
        /// **参数解释：** 证书配置开关 **约束限制：** 不涉及 **取值范围：** - on: 开启 - off: 关闭 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("https_status", NullValueHandling = NullValueHandling.Ignore)]
        public string HttpsStatus { get; set; }

        /// <summary>
        /// **参数解释：** 证书类型 **约束限制：** 不涉及 **取值范围：** - server: 国际证书 - server_sm: 国密证书 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("certificate_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateType { get; set; }

        /// <summary>
        /// **参数解释：** 证书来源 **约束限制：** 证书开启时必传 **取值范围：** - 0: 自有证书 - 2: SCM证书 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("certificate_source", NullValueHandling = NullValueHandling.Ignore)]
        public int? CertificateSource { get; set; }

        /// <summary>
        /// **参数解释：** SCM证书ID，可使用云证书与管理服务（CCM）的查询证书列表接口获取 **约束限制：** 配置SCM证书时必传 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("scm_certificate_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScmCertificateId { get; set; }

        /// <summary>
        /// **参数解释：** 证书名称 **约束限制：** - 当证书开启时必传 - 3-64个字符 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("certificate_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateName { get; set; }

        /// <summary>
        /// **参数解释：** HTTPS协议使用的证书内容 **约束限制：** - 仅支持PEM编码格式 - 当证书开启时必传 -  需要传入完整证书链 **取值范围：** 证书链长度不超过20KB **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("certificate_value", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateValue { get; set; }

        /// <summary>
        /// **参数解释：** HTTPS协议使用的私钥 **约束限制：** - 当证书开启时必传 - 仅支持PEM编码格式 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("private_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// **参数解释：** 加密证书内容 **约束限制：** - 证书类型为国密证书时必传 - 仅支持PEM编码格式 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("enc_certificate_value", NullValueHandling = NullValueHandling.Ignore)]
        public string EncCertificateValue { get; set; }

        /// <summary>
        /// **参数解释：** 加密私钥内容 **约束限制：** - 证书类型为国密证书时必传 - 仅支持PEM编码格式 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("enc_private_key", NullValueHandling = NullValueHandling.Ignore)]
        public string EncPrivateKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("certificates", NullValueHandling = NullValueHandling.Ignore)]
        public List<CertificatesPutBody> Certificates { get; set; }

        /// <summary>
        /// **参数解释：** HTTP/2开关，支持客户端采用HTTP/2协议访问CDN节点 **约束限制：** https_status&#x3D;off时，该值不生效 **取值范围：** - on: 是 - off: 否 **默认取值：** off: 否
        /// </summary>
        [JsonProperty("http2_status", NullValueHandling = NullValueHandling.Ignore)]
        public string Http2Status { get; set; }

        /// <summary>
        /// **参数解释：** 是否开启ocsp stapling **约束限制：** 不涉及 **取值范围：** - on: 是 - off: 否 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("ocsp_stapling_status", NullValueHandling = NullValueHandling.Ignore)]
        public string OcspStaplingStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HttpTemplateBody {\n");
            sb.Append("  httpsStatus: ").Append(HttpsStatus).Append("\n");
            sb.Append("  certificateType: ").Append(CertificateType).Append("\n");
            sb.Append("  certificateSource: ").Append(CertificateSource).Append("\n");
            sb.Append("  scmCertificateId: ").Append(ScmCertificateId).Append("\n");
            sb.Append("  certificateName: ").Append(CertificateName).Append("\n");
            sb.Append("  certificateValue: ").Append(CertificateValue).Append("\n");
            sb.Append("  privateKey: ").Append(PrivateKey).Append("\n");
            sb.Append("  encCertificateValue: ").Append(EncCertificateValue).Append("\n");
            sb.Append("  encPrivateKey: ").Append(EncPrivateKey).Append("\n");
            sb.Append("  certificates: ").Append(Certificates).Append("\n");
            sb.Append("  http2Status: ").Append(Http2Status).Append("\n");
            sb.Append("  ocspStaplingStatus: ").Append(OcspStaplingStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HttpTemplateBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HttpTemplateBody input)
        {
            if (input == null) return false;
            if (this.HttpsStatus != input.HttpsStatus || (this.HttpsStatus != null && !this.HttpsStatus.Equals(input.HttpsStatus))) return false;
            if (this.CertificateType != input.CertificateType || (this.CertificateType != null && !this.CertificateType.Equals(input.CertificateType))) return false;
            if (this.CertificateSource != input.CertificateSource || (this.CertificateSource != null && !this.CertificateSource.Equals(input.CertificateSource))) return false;
            if (this.ScmCertificateId != input.ScmCertificateId || (this.ScmCertificateId != null && !this.ScmCertificateId.Equals(input.ScmCertificateId))) return false;
            if (this.CertificateName != input.CertificateName || (this.CertificateName != null && !this.CertificateName.Equals(input.CertificateName))) return false;
            if (this.CertificateValue != input.CertificateValue || (this.CertificateValue != null && !this.CertificateValue.Equals(input.CertificateValue))) return false;
            if (this.PrivateKey != input.PrivateKey || (this.PrivateKey != null && !this.PrivateKey.Equals(input.PrivateKey))) return false;
            if (this.EncCertificateValue != input.EncCertificateValue || (this.EncCertificateValue != null && !this.EncCertificateValue.Equals(input.EncCertificateValue))) return false;
            if (this.EncPrivateKey != input.EncPrivateKey || (this.EncPrivateKey != null && !this.EncPrivateKey.Equals(input.EncPrivateKey))) return false;
            if (this.Certificates != input.Certificates || (this.Certificates != null && input.Certificates != null && !this.Certificates.SequenceEqual(input.Certificates))) return false;
            if (this.Http2Status != input.Http2Status || (this.Http2Status != null && !this.Http2Status.Equals(input.Http2Status))) return false;
            if (this.OcspStaplingStatus != input.OcspStaplingStatus || (this.OcspStaplingStatus != null && !this.OcspStaplingStatus.Equals(input.OcspStaplingStatus))) return false;

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
                if (this.HttpsStatus != null) hashCode = hashCode * 59 + this.HttpsStatus.GetHashCode();
                if (this.CertificateType != null) hashCode = hashCode * 59 + this.CertificateType.GetHashCode();
                if (this.CertificateSource != null) hashCode = hashCode * 59 + this.CertificateSource.GetHashCode();
                if (this.ScmCertificateId != null) hashCode = hashCode * 59 + this.ScmCertificateId.GetHashCode();
                if (this.CertificateName != null) hashCode = hashCode * 59 + this.CertificateName.GetHashCode();
                if (this.CertificateValue != null) hashCode = hashCode * 59 + this.CertificateValue.GetHashCode();
                if (this.PrivateKey != null) hashCode = hashCode * 59 + this.PrivateKey.GetHashCode();
                if (this.EncCertificateValue != null) hashCode = hashCode * 59 + this.EncCertificateValue.GetHashCode();
                if (this.EncPrivateKey != null) hashCode = hashCode * 59 + this.EncPrivateKey.GetHashCode();
                if (this.Certificates != null) hashCode = hashCode * 59 + this.Certificates.GetHashCode();
                if (this.Http2Status != null) hashCode = hashCode * 59 + this.Http2Status.GetHashCode();
                if (this.OcspStaplingStatus != null) hashCode = hashCode * 59 + this.OcspStaplingStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
