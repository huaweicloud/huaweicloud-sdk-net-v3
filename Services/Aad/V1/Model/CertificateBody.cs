using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CertificateBody 
    {

        /// <summary>
        /// 操作类型。0 - 上传， 1 - 更换
        /// </summary>
        [JsonProperty("op_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? OpType { get; set; }

        /// <summary>
        /// 证书名称
        /// </summary>
        [JsonProperty("cert_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CertName { get; set; }

        /// <summary>
        /// 证书文件。上传新证书(op_type为0)时必填，更换为已有证书(op_type为1)时置空
        /// </summary>
        [JsonProperty("cert_file", NullValueHandling = NullValueHandling.Ignore)]
        public string CertFile { get; set; }

        /// <summary>
        /// 私钥文件。上传新证书(op_type为0)时必填，更换为已有证书(op_type为1)时置空
        /// </summary>
        [JsonProperty("cert_key_file", NullValueHandling = NullValueHandling.Ignore)]
        public string CertKeyFile { get; set; }

        /// <summary>
        /// 域名id
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CertificateBody {\n");
            sb.Append("  opType: ").Append(OpType).Append("\n");
            sb.Append("  certName: ").Append(CertName).Append("\n");
            sb.Append("  certFile: ").Append(CertFile).Append("\n");
            sb.Append("  certKeyFile: ").Append(CertKeyFile).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CertificateBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CertificateBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OpType == input.OpType ||
                    (this.OpType != null &&
                    this.OpType.Equals(input.OpType))
                ) && 
                (
                    this.CertName == input.CertName ||
                    (this.CertName != null &&
                    this.CertName.Equals(input.CertName))
                ) && 
                (
                    this.CertFile == input.CertFile ||
                    (this.CertFile != null &&
                    this.CertFile.Equals(input.CertFile))
                ) && 
                (
                    this.CertKeyFile == input.CertKeyFile ||
                    (this.CertKeyFile != null &&
                    this.CertKeyFile.Equals(input.CertKeyFile))
                ) && 
                (
                    this.DomainId == input.DomainId ||
                    (this.DomainId != null &&
                    this.DomainId.Equals(input.DomainId))
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
                if (this.OpType != null)
                    hashCode = hashCode * 59 + this.OpType.GetHashCode();
                if (this.CertName != null)
                    hashCode = hashCode * 59 + this.CertName.GetHashCode();
                if (this.CertFile != null)
                    hashCode = hashCode * 59 + this.CertFile.GetHashCode();
                if (this.CertKeyFile != null)
                    hashCode = hashCode * 59 + this.CertKeyFile.GetHashCode();
                if (this.DomainId != null)
                    hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                return hashCode;
            }
        }
    }
}
