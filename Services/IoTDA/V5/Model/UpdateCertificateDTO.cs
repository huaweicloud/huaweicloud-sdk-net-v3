using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 更新CA证书结构体。
    /// </summary>
    public class UpdateCertificateDTO 
    {

        /// <summary>
        /// 是否开启自注册能力，当为true时该功能必须配合预调配功能使用，true：是，false：否。
        /// </summary>
        [JsonProperty("provision_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ProvisionEnable { get; set; }

        /// <summary>
        /// 预调配模板ID，该CA证书绑定的预调配模板id，当该字段传null时表示解除绑定关系。
        /// </summary>
        [JsonProperty("template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 是否开启该CA证书下的设备证书OCSP校验，当为true且设备证书信息中包含OCSP url时则平台会校验证书的状态，当证书状态为revoked时平台会拒绝设备连接，true：开启，false：关闭。
        /// </summary>
        [JsonProperty("ocsp_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OcspEnable { get; set; }

        /// <summary>
        /// 访问ocsp服务器是否开启SSL，开启后必须配置服务器CA证书校验。
        /// </summary>
        [JsonProperty("ocsp_ssl_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OcspSslEnable { get; set; }

        /// <summary>
        /// ocsp服务器端CA证书id，当ocsp服务器为https协议时需要配置，否则认证失败。
        /// </summary>
        [JsonProperty("ocsp_server_ca_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OcspServerCaId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCertificateDTO {\n");
            sb.Append("  provisionEnable: ").Append(ProvisionEnable).Append("\n");
            sb.Append("  templateId: ").Append(TemplateId).Append("\n");
            sb.Append("  ocspEnable: ").Append(OcspEnable).Append("\n");
            sb.Append("  ocspSslEnable: ").Append(OcspSslEnable).Append("\n");
            sb.Append("  ocspServerCaId: ").Append(OcspServerCaId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateCertificateDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateCertificateDTO input)
        {
            if (input == null) return false;
            if (this.ProvisionEnable != input.ProvisionEnable || (this.ProvisionEnable != null && !this.ProvisionEnable.Equals(input.ProvisionEnable))) return false;
            if (this.TemplateId != input.TemplateId || (this.TemplateId != null && !this.TemplateId.Equals(input.TemplateId))) return false;
            if (this.OcspEnable != input.OcspEnable || (this.OcspEnable != null && !this.OcspEnable.Equals(input.OcspEnable))) return false;
            if (this.OcspSslEnable != input.OcspSslEnable || (this.OcspSslEnable != null && !this.OcspSslEnable.Equals(input.OcspSslEnable))) return false;
            if (this.OcspServerCaId != input.OcspServerCaId || (this.OcspServerCaId != null && !this.OcspServerCaId.Equals(input.OcspServerCaId))) return false;

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
                if (this.ProvisionEnable != null) hashCode = hashCode * 59 + this.ProvisionEnable.GetHashCode();
                if (this.TemplateId != null) hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.OcspEnable != null) hashCode = hashCode * 59 + this.OcspEnable.GetHashCode();
                if (this.OcspSslEnable != null) hashCode = hashCode * 59 + this.OcspSslEnable.GetHashCode();
                if (this.OcspServerCaId != null) hashCode = hashCode * 59 + this.OcspServerCaId.GetHashCode();
                return hashCode;
            }
        }
    }
}
