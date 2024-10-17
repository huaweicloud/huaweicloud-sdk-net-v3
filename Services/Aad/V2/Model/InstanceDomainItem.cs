using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class InstanceDomainItem 
    {

        /// <summary>
        /// 域名ID
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// 域名cname
        /// </summary>
        [JsonProperty("cname", NullValueHandling = NullValueHandling.Ignore)]
        public string Cname { get; set; }

        /// <summary>
        /// 域名状态 NORMAL &#x3D; &#39;0&#39;, FREEZE &#x3D; &#39;1&#39;
        /// </summary>
        [JsonProperty("domain_status", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainStatus { get; set; }

        /// <summary>
        /// cc防护状态
        /// </summary>
        [JsonProperty("cc_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? CcStatus { get; set; }

        /// <summary>
        /// 证书状态：1- --已上传  2- --未上传
        /// </summary>
        [JsonProperty("https_cert_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? HttpsCertStatus { get; set; }

        /// <summary>
        /// 证书名称
        /// </summary>
        [JsonProperty("cert_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CertName { get; set; }

        /// <summary>
        /// 域名协议
        /// </summary>
        [JsonProperty("protocol_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ProtocolType { get; set; }

        /// <summary>
        /// 源站类型
        /// </summary>
        [JsonProperty("real_server_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? RealServerType { get; set; }

        /// <summary>
        /// 源站
        /// </summary>
        [JsonProperty("real_servers", NullValueHandling = NullValueHandling.Ignore)]
        public string RealServers { get; set; }

        /// <summary>
        /// waf防护状态
        /// </summary>
        [JsonProperty("waf_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? WafStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceDomainItem {\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  cname: ").Append(Cname).Append("\n");
            sb.Append("  domainStatus: ").Append(DomainStatus).Append("\n");
            sb.Append("  ccStatus: ").Append(CcStatus).Append("\n");
            sb.Append("  httpsCertStatus: ").Append(HttpsCertStatus).Append("\n");
            sb.Append("  certName: ").Append(CertName).Append("\n");
            sb.Append("  protocolType: ").Append(ProtocolType).Append("\n");
            sb.Append("  realServerType: ").Append(RealServerType).Append("\n");
            sb.Append("  realServers: ").Append(RealServers).Append("\n");
            sb.Append("  wafStatus: ").Append(WafStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstanceDomainItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstanceDomainItem input)
        {
            if (input == null) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.DomainName != input.DomainName || (this.DomainName != null && !this.DomainName.Equals(input.DomainName))) return false;
            if (this.Cname != input.Cname || (this.Cname != null && !this.Cname.Equals(input.Cname))) return false;
            if (this.DomainStatus != input.DomainStatus || (this.DomainStatus != null && !this.DomainStatus.Equals(input.DomainStatus))) return false;
            if (this.CcStatus != input.CcStatus || (this.CcStatus != null && !this.CcStatus.Equals(input.CcStatus))) return false;
            if (this.HttpsCertStatus != input.HttpsCertStatus || (this.HttpsCertStatus != null && !this.HttpsCertStatus.Equals(input.HttpsCertStatus))) return false;
            if (this.CertName != input.CertName || (this.CertName != null && !this.CertName.Equals(input.CertName))) return false;
            if (this.ProtocolType != input.ProtocolType || (this.ProtocolType != null && input.ProtocolType != null && !this.ProtocolType.SequenceEqual(input.ProtocolType))) return false;
            if (this.RealServerType != input.RealServerType || (this.RealServerType != null && !this.RealServerType.Equals(input.RealServerType))) return false;
            if (this.RealServers != input.RealServers || (this.RealServers != null && !this.RealServers.Equals(input.RealServers))) return false;
            if (this.WafStatus != input.WafStatus || (this.WafStatus != null && !this.WafStatus.Equals(input.WafStatus))) return false;

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
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.DomainName != null) hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.Cname != null) hashCode = hashCode * 59 + this.Cname.GetHashCode();
                if (this.DomainStatus != null) hashCode = hashCode * 59 + this.DomainStatus.GetHashCode();
                if (this.CcStatus != null) hashCode = hashCode * 59 + this.CcStatus.GetHashCode();
                if (this.HttpsCertStatus != null) hashCode = hashCode * 59 + this.HttpsCertStatus.GetHashCode();
                if (this.CertName != null) hashCode = hashCode * 59 + this.CertName.GetHashCode();
                if (this.ProtocolType != null) hashCode = hashCode * 59 + this.ProtocolType.GetHashCode();
                if (this.RealServerType != null) hashCode = hashCode * 59 + this.RealServerType.GetHashCode();
                if (this.RealServers != null) hashCode = hashCode * 59 + this.RealServers.GetHashCode();
                if (this.WafStatus != null) hashCode = hashCode * 59 + this.WafStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
