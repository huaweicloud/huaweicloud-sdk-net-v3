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
    /// 创建服务器证书请求体。
    /// </summary>
    public class CreateServerCertificateDTO 
    {

        /// <summary>
        /// **参数说明**：证书内容，PEM格式
        /// </summary>
        [JsonProperty("certificate_pem", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificatePem { get; set; }

        /// <summary>
        /// **参数说明**：证书私钥
        /// </summary>
        [JsonProperty("private_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// **参数说明**：私钥密码
        /// </summary>
        [JsonProperty("private_key_password", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateKeyPassword { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateServerCertificateDTO {\n");
            sb.Append("  certificatePem: ").Append(CertificatePem).Append("\n");
            sb.Append("  privateKey: ").Append(PrivateKey).Append("\n");
            sb.Append("  privateKeyPassword: ").Append(PrivateKeyPassword).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateServerCertificateDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateServerCertificateDTO input)
        {
            if (input == null) return false;
            if (this.CertificatePem != input.CertificatePem || (this.CertificatePem != null && !this.CertificatePem.Equals(input.CertificatePem))) return false;
            if (this.PrivateKey != input.PrivateKey || (this.PrivateKey != null && !this.PrivateKey.Equals(input.PrivateKey))) return false;
            if (this.PrivateKeyPassword != input.PrivateKeyPassword || (this.PrivateKeyPassword != null && !this.PrivateKeyPassword.Equals(input.PrivateKeyPassword))) return false;

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
                if (this.CertificatePem != null) hashCode = hashCode * 59 + this.CertificatePem.GetHashCode();
                if (this.PrivateKey != null) hashCode = hashCode * 59 + this.PrivateKey.GetHashCode();
                if (this.PrivateKeyPassword != null) hashCode = hashCode * 59 + this.PrivateKeyPassword.GetHashCode();
                return hashCode;
            }
        }
    }
}
