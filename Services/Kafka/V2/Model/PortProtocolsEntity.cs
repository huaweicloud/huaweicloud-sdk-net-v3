using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// 实例支持的连接方式及其连接地址。
    /// </summary>
    public class PortProtocolsEntity 
    {

        /// <summary>
        /// 实例是否支持内网PLAINTEXT访问接入方式。  - true：实例支持内网PLAINTEXT访问方式接入方式。  - false：实例不支持内网PLAINTEXT访问接入方式。
        /// </summary>
        [JsonProperty("private_plain_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PrivatePlainEnable { get; set; }

        /// <summary>
        /// kafka内网PLAINTEXT接入方式连接地址。
        /// </summary>
        [JsonProperty("private_plain_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivatePlainAddress { get; set; }

        /// <summary>
        /// 内网明文连接域名
        /// </summary>
        [JsonProperty("private_plain_domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivatePlainDomainName { get; set; }

        /// <summary>
        /// 实例是否支持内网SASL_SSL访问接入方式。  - true：实例支持内网SASL_SSL访问方式接入方式。  - false：实例不支持内网SASL_SSL访问接入方式。
        /// </summary>
        [JsonProperty("private_sasl_ssl_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PrivateSaslSslEnable { get; set; }

        /// <summary>
        /// kafka内网SASL_SSL接入方式连接地址。
        /// </summary>
        [JsonProperty("private_sasl_ssl_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateSaslSslAddress { get; set; }

        /// <summary>
        /// 内网SASL_SSL连接域名
        /// </summary>
        [JsonProperty("private_sasl_ssl_domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateSaslSslDomainName { get; set; }

        /// <summary>
        /// 实例是否支持内网SASL_PLAINTEXT访问接入方式。  - true，实例支持内网SASL_PLAINTEXT访问方式接入方式。  - false，实例不支持内网SASL_PLAINTEXT访问接入方式。
        /// </summary>
        [JsonProperty("private_sasl_plaintext_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PrivateSaslPlaintextEnable { get; set; }

        /// <summary>
        /// kafka内网SASL_PLAINTEXT接入方式连接地址。
        /// </summary>
        [JsonProperty("private_sasl_plaintext_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateSaslPlaintextAddress { get; set; }

        /// <summary>
        /// 内网SASL_PLAINTEXT连接域名
        /// </summary>
        [JsonProperty("private_sasl_plaintext_domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateSaslPlaintextDomainName { get; set; }

        /// <summary>
        /// 实例是否支持公网PLAINTEXT访问接入方式。  - true，实例支持公网PLAINTEXT访问方式接入方式。  - false，实例不支持公网PLAINTEXT访问接入方式。
        /// </summary>
        [JsonProperty("public_plain_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PublicPlainEnable { get; set; }

        /// <summary>
        /// kafka公网PLAINTEXT接入方式连接地址。
        /// </summary>
        [JsonProperty("public_plain_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicPlainAddress { get; set; }

        /// <summary>
        /// 公网明文连接域名
        /// </summary>
        [JsonProperty("public_plain_domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicPlainDomainName { get; set; }

        /// <summary>
        /// 实例是否支持公网SASL_SSL访问接入方式。  - true，实例支持内网SASL_SSL访问方式接入方式。  - false，实例不支持公网SASL_SSL访问接入方式。
        /// </summary>
        [JsonProperty("public_sasl_ssl_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PublicSaslSslEnable { get; set; }

        /// <summary>
        /// kafka公网SASL_SSL接入方式连接地址。
        /// </summary>
        [JsonProperty("public_sasl_ssl_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicSaslSslAddress { get; set; }

        /// <summary>
        /// 公网SASL_SSL连接域名
        /// </summary>
        [JsonProperty("public_sasl_ssl_domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicSaslSslDomainName { get; set; }

        /// <summary>
        /// 实例是否支持公网SASL_PLAINTEXT访问接入方式。  - true，实例支持公网SASL_PLAINTEXT访问方式接入方式。  - false，实例不支持公网SASL_PLAINTEXT访问接入方式。
        /// </summary>
        [JsonProperty("public_sasl_plaintext_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PublicSaslPlaintextEnable { get; set; }

        /// <summary>
        /// kafka公网SASL_PLAINTEXT接入方式连接地址。
        /// </summary>
        [JsonProperty("public_sasl_plaintext_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicSaslPlaintextAddress { get; set; }

        /// <summary>
        /// 公网SASL_PLAINTEXT连接域名
        /// </summary>
        [JsonProperty("public_sasl_plaintext_domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicSaslPlaintextDomainName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PortProtocolsEntity {\n");
            sb.Append("  privatePlainEnable: ").Append(PrivatePlainEnable).Append("\n");
            sb.Append("  privatePlainAddress: ").Append(PrivatePlainAddress).Append("\n");
            sb.Append("  privatePlainDomainName: ").Append(PrivatePlainDomainName).Append("\n");
            sb.Append("  privateSaslSslEnable: ").Append(PrivateSaslSslEnable).Append("\n");
            sb.Append("  privateSaslSslAddress: ").Append(PrivateSaslSslAddress).Append("\n");
            sb.Append("  privateSaslSslDomainName: ").Append(PrivateSaslSslDomainName).Append("\n");
            sb.Append("  privateSaslPlaintextEnable: ").Append(PrivateSaslPlaintextEnable).Append("\n");
            sb.Append("  privateSaslPlaintextAddress: ").Append(PrivateSaslPlaintextAddress).Append("\n");
            sb.Append("  privateSaslPlaintextDomainName: ").Append(PrivateSaslPlaintextDomainName).Append("\n");
            sb.Append("  publicPlainEnable: ").Append(PublicPlainEnable).Append("\n");
            sb.Append("  publicPlainAddress: ").Append(PublicPlainAddress).Append("\n");
            sb.Append("  publicPlainDomainName: ").Append(PublicPlainDomainName).Append("\n");
            sb.Append("  publicSaslSslEnable: ").Append(PublicSaslSslEnable).Append("\n");
            sb.Append("  publicSaslSslAddress: ").Append(PublicSaslSslAddress).Append("\n");
            sb.Append("  publicSaslSslDomainName: ").Append(PublicSaslSslDomainName).Append("\n");
            sb.Append("  publicSaslPlaintextEnable: ").Append(PublicSaslPlaintextEnable).Append("\n");
            sb.Append("  publicSaslPlaintextAddress: ").Append(PublicSaslPlaintextAddress).Append("\n");
            sb.Append("  publicSaslPlaintextDomainName: ").Append(PublicSaslPlaintextDomainName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PortProtocolsEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PortProtocolsEntity input)
        {
            if (input == null) return false;
            if (this.PrivatePlainEnable != input.PrivatePlainEnable || (this.PrivatePlainEnable != null && !this.PrivatePlainEnable.Equals(input.PrivatePlainEnable))) return false;
            if (this.PrivatePlainAddress != input.PrivatePlainAddress || (this.PrivatePlainAddress != null && !this.PrivatePlainAddress.Equals(input.PrivatePlainAddress))) return false;
            if (this.PrivatePlainDomainName != input.PrivatePlainDomainName || (this.PrivatePlainDomainName != null && !this.PrivatePlainDomainName.Equals(input.PrivatePlainDomainName))) return false;
            if (this.PrivateSaslSslEnable != input.PrivateSaslSslEnable || (this.PrivateSaslSslEnable != null && !this.PrivateSaslSslEnable.Equals(input.PrivateSaslSslEnable))) return false;
            if (this.PrivateSaslSslAddress != input.PrivateSaslSslAddress || (this.PrivateSaslSslAddress != null && !this.PrivateSaslSslAddress.Equals(input.PrivateSaslSslAddress))) return false;
            if (this.PrivateSaslSslDomainName != input.PrivateSaslSslDomainName || (this.PrivateSaslSslDomainName != null && !this.PrivateSaslSslDomainName.Equals(input.PrivateSaslSslDomainName))) return false;
            if (this.PrivateSaslPlaintextEnable != input.PrivateSaslPlaintextEnable || (this.PrivateSaslPlaintextEnable != null && !this.PrivateSaslPlaintextEnable.Equals(input.PrivateSaslPlaintextEnable))) return false;
            if (this.PrivateSaslPlaintextAddress != input.PrivateSaslPlaintextAddress || (this.PrivateSaslPlaintextAddress != null && !this.PrivateSaslPlaintextAddress.Equals(input.PrivateSaslPlaintextAddress))) return false;
            if (this.PrivateSaslPlaintextDomainName != input.PrivateSaslPlaintextDomainName || (this.PrivateSaslPlaintextDomainName != null && !this.PrivateSaslPlaintextDomainName.Equals(input.PrivateSaslPlaintextDomainName))) return false;
            if (this.PublicPlainEnable != input.PublicPlainEnable || (this.PublicPlainEnable != null && !this.PublicPlainEnable.Equals(input.PublicPlainEnable))) return false;
            if (this.PublicPlainAddress != input.PublicPlainAddress || (this.PublicPlainAddress != null && !this.PublicPlainAddress.Equals(input.PublicPlainAddress))) return false;
            if (this.PublicPlainDomainName != input.PublicPlainDomainName || (this.PublicPlainDomainName != null && !this.PublicPlainDomainName.Equals(input.PublicPlainDomainName))) return false;
            if (this.PublicSaslSslEnable != input.PublicSaslSslEnable || (this.PublicSaslSslEnable != null && !this.PublicSaslSslEnable.Equals(input.PublicSaslSslEnable))) return false;
            if (this.PublicSaslSslAddress != input.PublicSaslSslAddress || (this.PublicSaslSslAddress != null && !this.PublicSaslSslAddress.Equals(input.PublicSaslSslAddress))) return false;
            if (this.PublicSaslSslDomainName != input.PublicSaslSslDomainName || (this.PublicSaslSslDomainName != null && !this.PublicSaslSslDomainName.Equals(input.PublicSaslSslDomainName))) return false;
            if (this.PublicSaslPlaintextEnable != input.PublicSaslPlaintextEnable || (this.PublicSaslPlaintextEnable != null && !this.PublicSaslPlaintextEnable.Equals(input.PublicSaslPlaintextEnable))) return false;
            if (this.PublicSaslPlaintextAddress != input.PublicSaslPlaintextAddress || (this.PublicSaslPlaintextAddress != null && !this.PublicSaslPlaintextAddress.Equals(input.PublicSaslPlaintextAddress))) return false;
            if (this.PublicSaslPlaintextDomainName != input.PublicSaslPlaintextDomainName || (this.PublicSaslPlaintextDomainName != null && !this.PublicSaslPlaintextDomainName.Equals(input.PublicSaslPlaintextDomainName))) return false;

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
                if (this.PrivatePlainEnable != null) hashCode = hashCode * 59 + this.PrivatePlainEnable.GetHashCode();
                if (this.PrivatePlainAddress != null) hashCode = hashCode * 59 + this.PrivatePlainAddress.GetHashCode();
                if (this.PrivatePlainDomainName != null) hashCode = hashCode * 59 + this.PrivatePlainDomainName.GetHashCode();
                if (this.PrivateSaslSslEnable != null) hashCode = hashCode * 59 + this.PrivateSaslSslEnable.GetHashCode();
                if (this.PrivateSaslSslAddress != null) hashCode = hashCode * 59 + this.PrivateSaslSslAddress.GetHashCode();
                if (this.PrivateSaslSslDomainName != null) hashCode = hashCode * 59 + this.PrivateSaslSslDomainName.GetHashCode();
                if (this.PrivateSaslPlaintextEnable != null) hashCode = hashCode * 59 + this.PrivateSaslPlaintextEnable.GetHashCode();
                if (this.PrivateSaslPlaintextAddress != null) hashCode = hashCode * 59 + this.PrivateSaslPlaintextAddress.GetHashCode();
                if (this.PrivateSaslPlaintextDomainName != null) hashCode = hashCode * 59 + this.PrivateSaslPlaintextDomainName.GetHashCode();
                if (this.PublicPlainEnable != null) hashCode = hashCode * 59 + this.PublicPlainEnable.GetHashCode();
                if (this.PublicPlainAddress != null) hashCode = hashCode * 59 + this.PublicPlainAddress.GetHashCode();
                if (this.PublicPlainDomainName != null) hashCode = hashCode * 59 + this.PublicPlainDomainName.GetHashCode();
                if (this.PublicSaslSslEnable != null) hashCode = hashCode * 59 + this.PublicSaslSslEnable.GetHashCode();
                if (this.PublicSaslSslAddress != null) hashCode = hashCode * 59 + this.PublicSaslSslAddress.GetHashCode();
                if (this.PublicSaslSslDomainName != null) hashCode = hashCode * 59 + this.PublicSaslSslDomainName.GetHashCode();
                if (this.PublicSaslPlaintextEnable != null) hashCode = hashCode * 59 + this.PublicSaslPlaintextEnable.GetHashCode();
                if (this.PublicSaslPlaintextAddress != null) hashCode = hashCode * 59 + this.PublicSaslPlaintextAddress.GetHashCode();
                if (this.PublicSaslPlaintextDomainName != null) hashCode = hashCode * 59 + this.PublicSaslPlaintextDomainName.GetHashCode();
                return hashCode;
            }
        }
    }
}
