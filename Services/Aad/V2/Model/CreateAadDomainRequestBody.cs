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
    public class CreateAadDomainRequestBody 
    {

        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// 企业项目id，与接入的高防实例所属企业项目保持一致。可在华为云EPS服务中查看企业项目id，default企业项目id为\&quot;0\&quot;。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 高防实例ip列表。多个高防实例ip必须属于同一企业项目。
        /// </summary>
        [JsonProperty("ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Ips { get; set; }

        /// <summary>
        /// 源站类型。 0 - 源站IP， 1 - 源站域名。
        /// </summary>
        [JsonProperty("real_server_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? RealServerType { get; set; }

        /// <summary>
        /// HTTP端口，与port_https不能同时为空。DDoS高防支持的HTTP端口可在控制台查看。
        /// </summary>
        [JsonProperty("port_http", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> PortHttp { get; set; }

        /// <summary>
        /// HTTPS端口，与port_http不能同时为空。DDoS高防支持的HTTPS端口可在控制台查看。
        /// </summary>
        [JsonProperty("port_https", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> PortHttps { get; set; }

        /// <summary>
        /// 源站（源站ip/源站域名）
        /// </summary>
        [JsonProperty("real_server", NullValueHandling = NullValueHandling.Ignore)]
        public string RealServer { get; set; }

        /// <summary>
        /// 防护区域，0-大陆，1-海外
        /// </summary>
        [JsonProperty("overseas_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OverseasType { get; set; }

        /// <summary>
        /// 证书名称（必须是已经存在的证书）
        /// </summary>
        [JsonProperty("cert_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CertName { get; set; }

        /// <summary>
        /// 开启0，关闭1
        /// </summary>
        [JsonProperty("waf_switch", NullValueHandling = NullValueHandling.Ignore)]
        public string WafSwitch { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAadDomainRequestBody {\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  ips: ").Append(Ips).Append("\n");
            sb.Append("  realServerType: ").Append(RealServerType).Append("\n");
            sb.Append("  portHttp: ").Append(PortHttp).Append("\n");
            sb.Append("  portHttps: ").Append(PortHttps).Append("\n");
            sb.Append("  realServer: ").Append(RealServer).Append("\n");
            sb.Append("  overseasType: ").Append(OverseasType).Append("\n");
            sb.Append("  certName: ").Append(CertName).Append("\n");
            sb.Append("  wafSwitch: ").Append(WafSwitch).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAadDomainRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAadDomainRequestBody input)
        {
            if (input == null) return false;
            if (this.DomainName != input.DomainName || (this.DomainName != null && !this.DomainName.Equals(input.DomainName))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.Ips != input.Ips || (this.Ips != null && input.Ips != null && !this.Ips.SequenceEqual(input.Ips))) return false;
            if (this.RealServerType != input.RealServerType || (this.RealServerType != null && !this.RealServerType.Equals(input.RealServerType))) return false;
            if (this.PortHttp != input.PortHttp || (this.PortHttp != null && input.PortHttp != null && !this.PortHttp.SequenceEqual(input.PortHttp))) return false;
            if (this.PortHttps != input.PortHttps || (this.PortHttps != null && input.PortHttps != null && !this.PortHttps.SequenceEqual(input.PortHttps))) return false;
            if (this.RealServer != input.RealServer || (this.RealServer != null && !this.RealServer.Equals(input.RealServer))) return false;
            if (this.OverseasType != input.OverseasType || (this.OverseasType != null && !this.OverseasType.Equals(input.OverseasType))) return false;
            if (this.CertName != input.CertName || (this.CertName != null && !this.CertName.Equals(input.CertName))) return false;
            if (this.WafSwitch != input.WafSwitch || (this.WafSwitch != null && !this.WafSwitch.Equals(input.WafSwitch))) return false;

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
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Ips != null) hashCode = hashCode * 59 + this.Ips.GetHashCode();
                if (this.RealServerType != null) hashCode = hashCode * 59 + this.RealServerType.GetHashCode();
                if (this.PortHttp != null) hashCode = hashCode * 59 + this.PortHttp.GetHashCode();
                if (this.PortHttps != null) hashCode = hashCode * 59 + this.PortHttps.GetHashCode();
                if (this.RealServer != null) hashCode = hashCode * 59 + this.RealServer.GetHashCode();
                if (this.OverseasType != null) hashCode = hashCode * 59 + this.OverseasType.GetHashCode();
                if (this.CertName != null) hashCode = hashCode * 59 + this.CertName.GetHashCode();
                if (this.WafSwitch != null) hashCode = hashCode * 59 + this.WafSwitch.GetHashCode();
                return hashCode;
            }
        }
    }
}
