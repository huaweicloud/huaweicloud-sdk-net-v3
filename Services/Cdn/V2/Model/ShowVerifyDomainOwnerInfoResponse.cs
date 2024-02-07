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
    /// Response Object
    /// </summary>
    public class ShowVerifyDomainOwnerInfoResponse : SdkResponse
    {

        /// <summary>
        /// DNS探测类型
        /// </summary>
        [JsonProperty("dns_verify_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DnsVerifyType { get; set; }

        /// <summary>
        /// DNS记录名称
        /// </summary>
        [JsonProperty("dns_verify_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DnsVerifyName { get; set; }

        /// <summary>
        /// 文件探测地址
        /// </summary>
        [JsonProperty("file_verify_url", NullValueHandling = NullValueHandling.Ignore)]
        public string FileVerifyUrl { get; set; }

        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// 探测域名
        /// </summary>
        [JsonProperty("verify_domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VerifyDomainName { get; set; }

        /// <summary>
        /// 探测文件名
        /// </summary>
        [JsonProperty("file_verify_filename", NullValueHandling = NullValueHandling.Ignore)]
        public string FileVerifyFilename { get; set; }

        /// <summary>
        /// 探测内容，DNS值或者文件内容，时间加uuid
        /// </summary>
        [JsonProperty("verify_content", NullValueHandling = NullValueHandling.Ignore)]
        public string VerifyContent { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowVerifyDomainOwnerInfoResponse {\n");
            sb.Append("  dnsVerifyType: ").Append(DnsVerifyType).Append("\n");
            sb.Append("  dnsVerifyName: ").Append(DnsVerifyName).Append("\n");
            sb.Append("  fileVerifyUrl: ").Append(FileVerifyUrl).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  verifyDomainName: ").Append(VerifyDomainName).Append("\n");
            sb.Append("  fileVerifyFilename: ").Append(FileVerifyFilename).Append("\n");
            sb.Append("  verifyContent: ").Append(VerifyContent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowVerifyDomainOwnerInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowVerifyDomainOwnerInfoResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DnsVerifyType == input.DnsVerifyType ||
                    (this.DnsVerifyType != null &&
                    this.DnsVerifyType.Equals(input.DnsVerifyType))
                ) && 
                (
                    this.DnsVerifyName == input.DnsVerifyName ||
                    (this.DnsVerifyName != null &&
                    this.DnsVerifyName.Equals(input.DnsVerifyName))
                ) && 
                (
                    this.FileVerifyUrl == input.FileVerifyUrl ||
                    (this.FileVerifyUrl != null &&
                    this.FileVerifyUrl.Equals(input.FileVerifyUrl))
                ) && 
                (
                    this.DomainName == input.DomainName ||
                    (this.DomainName != null &&
                    this.DomainName.Equals(input.DomainName))
                ) && 
                (
                    this.VerifyDomainName == input.VerifyDomainName ||
                    (this.VerifyDomainName != null &&
                    this.VerifyDomainName.Equals(input.VerifyDomainName))
                ) && 
                (
                    this.FileVerifyFilename == input.FileVerifyFilename ||
                    (this.FileVerifyFilename != null &&
                    this.FileVerifyFilename.Equals(input.FileVerifyFilename))
                ) && 
                (
                    this.VerifyContent == input.VerifyContent ||
                    (this.VerifyContent != null &&
                    this.VerifyContent.Equals(input.VerifyContent))
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
                if (this.DnsVerifyType != null)
                    hashCode = hashCode * 59 + this.DnsVerifyType.GetHashCode();
                if (this.DnsVerifyName != null)
                    hashCode = hashCode * 59 + this.DnsVerifyName.GetHashCode();
                if (this.FileVerifyUrl != null)
                    hashCode = hashCode * 59 + this.FileVerifyUrl.GetHashCode();
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.VerifyDomainName != null)
                    hashCode = hashCode * 59 + this.VerifyDomainName.GetHashCode();
                if (this.FileVerifyFilename != null)
                    hashCode = hashCode * 59 + this.FileVerifyFilename.GetHashCode();
                if (this.VerifyContent != null)
                    hashCode = hashCode * 59 + this.VerifyContent.GetHashCode();
                return hashCode;
            }
        }
    }
}
