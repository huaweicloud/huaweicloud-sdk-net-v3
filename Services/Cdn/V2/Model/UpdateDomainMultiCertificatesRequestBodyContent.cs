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
    /// **参数解释：** HTTPS证书配置，配置证书后，允许客户端采用HTTPS协议访问CDN节点 **约束限制：** 不涉及
    /// </summary>
    public class UpdateDomainMultiCertificatesRequestBodyContent 
    {

        /// <summary>
        /// **参数解释：** 需要配置HTTPS证书的域名 **约束限制：** - 域名间以“,”分隔 - 最多配置50个域名  **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// **参数解释：** 证书配置开关 **约束限制：** https_switch为1时，证书参数不能为空 **取值范围：** - 0: 关闭 - 1: 开启  **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("https_switch", NullValueHandling = NullValueHandling.Ignore)]
        public int? HttpsSwitch { get; set; }

        /// <summary>
        /// **参数解释：** 回源协议 **约束限制：** 不涉及 **取值范围：** - 1: 协议跟随 - 2: http协议 - 3: https协议  **默认取值：** 2: http协议
        /// </summary>
        [JsonProperty("access_origin_way", NullValueHandling = NullValueHandling.Ignore)]
        public int? AccessOriginWay { get; set; }

        /// <summary>
        /// **参数解释：** 是否开启HTTPS强制跳转，强制客户端使用HTTPS协议访问CDN节点 &gt; 此参数即将下线，建议使用force_redirect_config修改配置  **约束限制：** 不涉及 **取值范围：** - 0: 关闭 - 1: 开启  **默认取值：** 0: 关闭
        /// </summary>
        [JsonProperty("force_redirect_https", NullValueHandling = NullValueHandling.Ignore)]
        public int? ForceRedirectHttps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("force_redirect_config", NullValueHandling = NullValueHandling.Ignore)]
        public ForceRedirect ForceRedirectConfig { get; set; }

        /// <summary>
        /// **参数解释：** HTTP/2开关，支持客户端采用HTTP/2协议访问CDN节点 **约束限制：** 不涉及 **取值范围：** - 0: 关闭 - 1: 开启  **默认取值：** 0: 关闭
        /// </summary>
        [JsonProperty("http2", NullValueHandling = NullValueHandling.Ignore)]
        public int? Http2 { get; set; }

        /// <summary>
        /// **参数解释：** 证书名称 **约束限制：** https_switch为1时，该参数必填 **取值范围：** 3-64个字符，由英文字母、数字及“-”、“_”、空格组成 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("cert_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CertName { get; set; }

        /// <summary>
        /// **参数解释：** SSL证书内容 **约束限制：** - 仅支持PEM编码格式 - 不启用证书则无需输入 - 初次配置证书时必传 - 需要传入完整证书链  **取值范围：** 证书链长度不超过20KB **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("certificate", NullValueHandling = NullValueHandling.Ignore)]
        public string Certificate { get; set; }

        /// <summary>
        /// **参数解释：** SSL证书私钥内容 **约束限制：** - 仅支持PEM编码格式 - 不启用证书则无需输入 - 初次配置证书时必传  **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("private_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// **参数解释：** 证书类型 **约束限制：** 不涉及 **取值范围：** - 0: 自有证书 - 2: SCM证书  **默认取值：** 0: 自有证书
        /// </summary>
        [JsonProperty("certificate_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? CertificateType { get; set; }

        /// <summary>
        /// **参数解释：** SCM证书ID，可使用云证书与管理服务（CCM）的查询证书列表接口获取 **约束限制：** 配置SCM证书时必传 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("scm_certificate_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScmCertificateId { get; set; }

        /// <summary>
        /// **参数解释：** 配置国际证书和国密证书双证书场景下的证书列表 **约束限制：** - 配置双证书时最多传2个证书，只能包含1个国际证书和1个国密证书 - 使用双证书配置时，cert_name/certificate/private_key等单证书参数不可再使用  **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("certificates", NullValueHandling = NullValueHandling.Ignore)]
        public List<MultiCertificateBatchVo> Certificates { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDomainMultiCertificatesRequestBodyContent {\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  httpsSwitch: ").Append(HttpsSwitch).Append("\n");
            sb.Append("  accessOriginWay: ").Append(AccessOriginWay).Append("\n");
            sb.Append("  forceRedirectHttps: ").Append(ForceRedirectHttps).Append("\n");
            sb.Append("  forceRedirectConfig: ").Append(ForceRedirectConfig).Append("\n");
            sb.Append("  http2: ").Append(Http2).Append("\n");
            sb.Append("  certName: ").Append(CertName).Append("\n");
            sb.Append("  certificate: ").Append(Certificate).Append("\n");
            sb.Append("  privateKey: ").Append(PrivateKey).Append("\n");
            sb.Append("  certificateType: ").Append(CertificateType).Append("\n");
            sb.Append("  scmCertificateId: ").Append(ScmCertificateId).Append("\n");
            sb.Append("  certificates: ").Append(Certificates).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateDomainMultiCertificatesRequestBodyContent);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateDomainMultiCertificatesRequestBodyContent input)
        {
            if (input == null) return false;
            if (this.DomainName != input.DomainName || (this.DomainName != null && !this.DomainName.Equals(input.DomainName))) return false;
            if (this.HttpsSwitch != input.HttpsSwitch || (this.HttpsSwitch != null && !this.HttpsSwitch.Equals(input.HttpsSwitch))) return false;
            if (this.AccessOriginWay != input.AccessOriginWay || (this.AccessOriginWay != null && !this.AccessOriginWay.Equals(input.AccessOriginWay))) return false;
            if (this.ForceRedirectHttps != input.ForceRedirectHttps || (this.ForceRedirectHttps != null && !this.ForceRedirectHttps.Equals(input.ForceRedirectHttps))) return false;
            if (this.ForceRedirectConfig != input.ForceRedirectConfig || (this.ForceRedirectConfig != null && !this.ForceRedirectConfig.Equals(input.ForceRedirectConfig))) return false;
            if (this.Http2 != input.Http2 || (this.Http2 != null && !this.Http2.Equals(input.Http2))) return false;
            if (this.CertName != input.CertName || (this.CertName != null && !this.CertName.Equals(input.CertName))) return false;
            if (this.Certificate != input.Certificate || (this.Certificate != null && !this.Certificate.Equals(input.Certificate))) return false;
            if (this.PrivateKey != input.PrivateKey || (this.PrivateKey != null && !this.PrivateKey.Equals(input.PrivateKey))) return false;
            if (this.CertificateType != input.CertificateType || (this.CertificateType != null && !this.CertificateType.Equals(input.CertificateType))) return false;
            if (this.ScmCertificateId != input.ScmCertificateId || (this.ScmCertificateId != null && !this.ScmCertificateId.Equals(input.ScmCertificateId))) return false;
            if (this.Certificates != input.Certificates || (this.Certificates != null && input.Certificates != null && !this.Certificates.SequenceEqual(input.Certificates))) return false;

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
                if (this.DomainName != null) hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.HttpsSwitch != null) hashCode = hashCode * 59 + this.HttpsSwitch.GetHashCode();
                if (this.AccessOriginWay != null) hashCode = hashCode * 59 + this.AccessOriginWay.GetHashCode();
                if (this.ForceRedirectHttps != null) hashCode = hashCode * 59 + this.ForceRedirectHttps.GetHashCode();
                if (this.ForceRedirectConfig != null) hashCode = hashCode * 59 + this.ForceRedirectConfig.GetHashCode();
                if (this.Http2 != null) hashCode = hashCode * 59 + this.Http2.GetHashCode();
                if (this.CertName != null) hashCode = hashCode * 59 + this.CertName.GetHashCode();
                if (this.Certificate != null) hashCode = hashCode * 59 + this.Certificate.GetHashCode();
                if (this.PrivateKey != null) hashCode = hashCode * 59 + this.PrivateKey.GetHashCode();
                if (this.CertificateType != null) hashCode = hashCode * 59 + this.CertificateType.GetHashCode();
                if (this.ScmCertificateId != null) hashCode = hashCode * 59 + this.ScmCertificateId.GetHashCode();
                if (this.Certificates != null) hashCode = hashCode * 59 + this.Certificates.GetHashCode();
                return hashCode;
            }
        }
    }
}
