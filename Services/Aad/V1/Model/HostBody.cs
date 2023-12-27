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
    public class HostBody 
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
        [JsonProperty("vips", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Vips { get; set; }

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
        /// 源站ip/源站域名
        /// </summary>
        [JsonProperty("real_server", NullValueHandling = NullValueHandling.Ignore)]
        public string RealServer { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HostBody {\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  vips: ").Append(Vips).Append("\n");
            sb.Append("  realServerType: ").Append(RealServerType).Append("\n");
            sb.Append("  portHttp: ").Append(PortHttp).Append("\n");
            sb.Append("  portHttps: ").Append(PortHttps).Append("\n");
            sb.Append("  realServer: ").Append(RealServer).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HostBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HostBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DomainName == input.DomainName ||
                    (this.DomainName != null &&
                    this.DomainName.Equals(input.DomainName))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.Vips == input.Vips ||
                    this.Vips != null &&
                    input.Vips != null &&
                    this.Vips.SequenceEqual(input.Vips)
                ) && 
                (
                    this.RealServerType == input.RealServerType ||
                    (this.RealServerType != null &&
                    this.RealServerType.Equals(input.RealServerType))
                ) && 
                (
                    this.PortHttp == input.PortHttp ||
                    this.PortHttp != null &&
                    input.PortHttp != null &&
                    this.PortHttp.SequenceEqual(input.PortHttp)
                ) && 
                (
                    this.PortHttps == input.PortHttps ||
                    this.PortHttps != null &&
                    input.PortHttps != null &&
                    this.PortHttps.SequenceEqual(input.PortHttps)
                ) && 
                (
                    this.RealServer == input.RealServer ||
                    (this.RealServer != null &&
                    this.RealServer.Equals(input.RealServer))
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
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Vips != null)
                    hashCode = hashCode * 59 + this.Vips.GetHashCode();
                if (this.RealServerType != null)
                    hashCode = hashCode * 59 + this.RealServerType.GetHashCode();
                if (this.PortHttp != null)
                    hashCode = hashCode * 59 + this.PortHttp.GetHashCode();
                if (this.PortHttps != null)
                    hashCode = hashCode * 59 + this.PortHttps.GetHashCode();
                if (this.RealServer != null)
                    hashCode = hashCode * 59 + this.RealServer.GetHashCode();
                return hashCode;
            }
        }
    }
}
