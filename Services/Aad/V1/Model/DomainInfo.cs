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
    public class DomainInfo 
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
        /// 域名协议
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Protocol { get; set; }

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
        /// 企业项目ID
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainInfo {\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  cname: ").Append(Cname).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  realServerType: ").Append(RealServerType).Append("\n");
            sb.Append("  realServers: ").Append(RealServers).Append("\n");
            sb.Append("  wafStatus: ").Append(WafStatus).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DomainInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DomainInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DomainId == input.DomainId ||
                    (this.DomainId != null &&
                    this.DomainId.Equals(input.DomainId))
                ) && 
                (
                    this.DomainName == input.DomainName ||
                    (this.DomainName != null &&
                    this.DomainName.Equals(input.DomainName))
                ) && 
                (
                    this.Cname == input.Cname ||
                    (this.Cname != null &&
                    this.Cname.Equals(input.Cname))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    this.Protocol != null &&
                    input.Protocol != null &&
                    this.Protocol.SequenceEqual(input.Protocol)
                ) && 
                (
                    this.RealServerType == input.RealServerType ||
                    (this.RealServerType != null &&
                    this.RealServerType.Equals(input.RealServerType))
                ) && 
                (
                    this.RealServers == input.RealServers ||
                    (this.RealServers != null &&
                    this.RealServers.Equals(input.RealServers))
                ) && 
                (
                    this.WafStatus == input.WafStatus ||
                    (this.WafStatus != null &&
                    this.WafStatus.Equals(input.WafStatus))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
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
                if (this.DomainId != null)
                    hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.Cname != null)
                    hashCode = hashCode * 59 + this.Cname.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.RealServerType != null)
                    hashCode = hashCode * 59 + this.RealServerType.GetHashCode();
                if (this.RealServers != null)
                    hashCode = hashCode * 59 + this.RealServers.GetHashCode();
                if (this.WafStatus != null)
                    hashCode = hashCode * 59 + this.WafStatus.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
