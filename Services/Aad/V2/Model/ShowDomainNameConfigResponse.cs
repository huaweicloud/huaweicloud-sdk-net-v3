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
    /// Response Object
    /// </summary>
    public class ShowDomainNameConfigResponse : SdkResponse
    {

        /// <summary>
        /// 域名id
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// 源站类型，0 - 源站IP， 1 - 源站域名
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
        /// pp是否开启, 1-开启，0-关闭
        /// </summary>
        [JsonProperty("pp_enable", NullValueHandling = NullValueHandling.Ignore)]
        public int? PpEnable { get; set; }

        /// <summary>
        /// 防护区域,0-大陆,1-海外
        /// </summary>
        [JsonProperty("overseas_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? OverseasType { get; set; }

        /// <summary>
        /// tls(请求参数type&#x3D;waf时)
        /// </summary>
        [JsonProperty("tls", NullValueHandling = NullValueHandling.Ignore)]
        public string Tls { get; set; }

        /// <summary>
        /// 加密套件(请求参数type&#x3D;waf时)
        /// </summary>
        [JsonProperty("cipher", NullValueHandling = NullValueHandling.Ignore)]
        public string Cipher { get; set; }

        /// <summary>
        /// 是否允许http2(请求参数type&#x3D;waf时)
        /// </summary>
        [JsonProperty("http2_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Http2Enable { get; set; }

        /// <summary>
        /// 字段转发(请求参数type&#x3D;waf时)
        /// </summary>
        [JsonProperty("header_map", NullValueHandling = NullValueHandling.Ignore)]
        public Object HeaderMap { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDomainNameConfigResponse {\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  realServerType: ").Append(RealServerType).Append("\n");
            sb.Append("  portHttp: ").Append(PortHttp).Append("\n");
            sb.Append("  portHttps: ").Append(PortHttps).Append("\n");
            sb.Append("  realServer: ").Append(RealServer).Append("\n");
            sb.Append("  ppEnable: ").Append(PpEnable).Append("\n");
            sb.Append("  overseasType: ").Append(OverseasType).Append("\n");
            sb.Append("  tls: ").Append(Tls).Append("\n");
            sb.Append("  cipher: ").Append(Cipher).Append("\n");
            sb.Append("  http2Enable: ").Append(Http2Enable).Append("\n");
            sb.Append("  headerMap: ").Append(HeaderMap).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDomainNameConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDomainNameConfigResponse input)
        {
            if (input == null) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.DomainName != input.DomainName || (this.DomainName != null && !this.DomainName.Equals(input.DomainName))) return false;
            if (this.RealServerType != input.RealServerType || (this.RealServerType != null && !this.RealServerType.Equals(input.RealServerType))) return false;
            if (this.PortHttp != input.PortHttp || (this.PortHttp != null && input.PortHttp != null && !this.PortHttp.SequenceEqual(input.PortHttp))) return false;
            if (this.PortHttps != input.PortHttps || (this.PortHttps != null && input.PortHttps != null && !this.PortHttps.SequenceEqual(input.PortHttps))) return false;
            if (this.RealServer != input.RealServer || (this.RealServer != null && !this.RealServer.Equals(input.RealServer))) return false;
            if (this.PpEnable != input.PpEnable || (this.PpEnable != null && !this.PpEnable.Equals(input.PpEnable))) return false;
            if (this.OverseasType != input.OverseasType || (this.OverseasType != null && !this.OverseasType.Equals(input.OverseasType))) return false;
            if (this.Tls != input.Tls || (this.Tls != null && !this.Tls.Equals(input.Tls))) return false;
            if (this.Cipher != input.Cipher || (this.Cipher != null && !this.Cipher.Equals(input.Cipher))) return false;
            if (this.Http2Enable != input.Http2Enable || (this.Http2Enable != null && !this.Http2Enable.Equals(input.Http2Enable))) return false;
            if (this.HeaderMap != input.HeaderMap || (this.HeaderMap != null && !this.HeaderMap.Equals(input.HeaderMap))) return false;

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
                if (this.RealServerType != null) hashCode = hashCode * 59 + this.RealServerType.GetHashCode();
                if (this.PortHttp != null) hashCode = hashCode * 59 + this.PortHttp.GetHashCode();
                if (this.PortHttps != null) hashCode = hashCode * 59 + this.PortHttps.GetHashCode();
                if (this.RealServer != null) hashCode = hashCode * 59 + this.RealServer.GetHashCode();
                if (this.PpEnable != null) hashCode = hashCode * 59 + this.PpEnable.GetHashCode();
                if (this.OverseasType != null) hashCode = hashCode * 59 + this.OverseasType.GetHashCode();
                if (this.Tls != null) hashCode = hashCode * 59 + this.Tls.GetHashCode();
                if (this.Cipher != null) hashCode = hashCode * 59 + this.Cipher.GetHashCode();
                if (this.Http2Enable != null) hashCode = hashCode * 59 + this.Http2Enable.GetHashCode();
                if (this.HeaderMap != null) hashCode = hashCode * 59 + this.HeaderMap.GetHashCode();
                return hashCode;
            }
        }
    }
}
