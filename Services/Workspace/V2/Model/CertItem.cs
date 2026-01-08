using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 证书信息。
    /// </summary>
    public class CertItem 
    {

        /// <summary>
        /// 租户id。
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 证书id。
        /// </summary>
        [JsonProperty("cert_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CertId { get; set; }

        /// <summary>
        /// 证书名。
        /// </summary>
        [JsonProperty("common_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CommonName { get; set; }

        /// <summary>
        /// 证书类型ROOT, SUBORDINATE。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 证书状态 DISABLE,ENABLE,EXPIRED,DELETE。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 密钥生成算法 RSA-2048,RSA-3072。
        /// </summary>
        [JsonProperty("key_algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyAlgorithm { get; set; }

        /// <summary>
        /// 签名哈希算法。
        /// </summary>
        [JsonProperty("signature_algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public string SignatureAlgorithm { get; set; }

        /// <summary>
        /// 应用场景。
        /// </summary>
        [JsonProperty("apply", NullValueHandling = NullValueHandling.Ignore)]
        public string Apply { get; set; }

        /// <summary>
        /// 生效时间。
        /// </summary>
        [JsonProperty("not_before", NullValueHandling = NullValueHandling.Ignore)]
        public string NotBefore { get; set; }

        /// <summary>
        /// 过期时间。
        /// </summary>
        [JsonProperty("not_after", NullValueHandling = NullValueHandling.Ignore)]
        public string NotAfter { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CertItem {\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  certId: ").Append(CertId).Append("\n");
            sb.Append("  commonName: ").Append(CommonName).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  keyAlgorithm: ").Append(KeyAlgorithm).Append("\n");
            sb.Append("  signatureAlgorithm: ").Append(SignatureAlgorithm).Append("\n");
            sb.Append("  apply: ").Append(Apply).Append("\n");
            sb.Append("  notBefore: ").Append(NotBefore).Append("\n");
            sb.Append("  notAfter: ").Append(NotAfter).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CertItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CertItem input)
        {
            if (input == null) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;
            if (this.CertId != input.CertId || (this.CertId != null && !this.CertId.Equals(input.CertId))) return false;
            if (this.CommonName != input.CommonName || (this.CommonName != null && !this.CommonName.Equals(input.CommonName))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.KeyAlgorithm != input.KeyAlgorithm || (this.KeyAlgorithm != null && !this.KeyAlgorithm.Equals(input.KeyAlgorithm))) return false;
            if (this.SignatureAlgorithm != input.SignatureAlgorithm || (this.SignatureAlgorithm != null && !this.SignatureAlgorithm.Equals(input.SignatureAlgorithm))) return false;
            if (this.Apply != input.Apply || (this.Apply != null && !this.Apply.Equals(input.Apply))) return false;
            if (this.NotBefore != input.NotBefore || (this.NotBefore != null && !this.NotBefore.Equals(input.NotBefore))) return false;
            if (this.NotAfter != input.NotAfter || (this.NotAfter != null && !this.NotAfter.Equals(input.NotAfter))) return false;

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
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.CertId != null) hashCode = hashCode * 59 + this.CertId.GetHashCode();
                if (this.CommonName != null) hashCode = hashCode * 59 + this.CommonName.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.KeyAlgorithm != null) hashCode = hashCode * 59 + this.KeyAlgorithm.GetHashCode();
                if (this.SignatureAlgorithm != null) hashCode = hashCode * 59 + this.SignatureAlgorithm.GetHashCode();
                if (this.Apply != null) hashCode = hashCode * 59 + this.Apply.GetHashCode();
                if (this.NotBefore != null) hashCode = hashCode * 59 + this.NotBefore.GetHashCode();
                if (this.NotAfter != null) hashCode = hashCode * 59 + this.NotAfter.GetHashCode();
                return hashCode;
            }
        }
    }
}
