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
    /// **参数解释：** 域名模板配置 **约束限制：** 不涉及
    /// </summary>
    public class TemplateConfigs 
    {

        /// <summary>
        /// **参数解释：** HTTP响应头，CDN节点响应客户端时，根据HTTP响应头配置操作响应的HTTP头部信息 **约束限制：** - 调用接口修改响应头时，将覆盖原先已配置的响应头，因此，在使用此接口时，请上传全量头部信息
        /// </summary>
        [JsonProperty("http_response_header", NullValueHandling = NullValueHandling.Ignore)]
        public List<HttpResponseHeader> HttpResponseHeader { get; set; }

        /// <summary>
        /// **参数解释：** 设置源站资源在CDN节点的缓存时长 **约束限制：** 必须存在一条所有文件类型的规则
        /// </summary>
        [JsonProperty("cache_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<CacheRules> CacheRules { get; set; }

        /// <summary>
        /// **参数解释：** 开启回源跟随，当源站地址因业务需求做了301/302 重定向，CDN节点会先跳转到301/302对应地址获取资源，缓存后再返回给用户 **约束限制：** 不涉及 **取值范围：** - on: 开启 - off: 关闭  **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("origin_follow302_status", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginFollow302Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("compress", NullValueHandling = NullValueHandling.Ignore)]
        public Compress Compress { get; set; }

        /// <summary>
        /// **参数解释：** Range回源，开启后，源站在收到CDN节点回源请求时，根据HTTP请求头中的Range信息返回指定范围的数据给CDN节点 **约束限制：** 开启Range回源的前提是您的源站支持Range请求，即HTTP请求头中包含Range字段，否则可能导致回源失败 **取值范围：** - on: 开启 - off: 关闭  **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("origin_range_status", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginRangeStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ip_filter", NullValueHandling = NullValueHandling.Ignore)]
        public IpFilter IpFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("referer", NullValueHandling = NullValueHandling.Ignore)]
        public RefererConfig Referer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("user_agent_filter", NullValueHandling = NullValueHandling.Ignore)]
        public UserAgentFilter UserAgentFilter { get; set; }

        /// <summary>
        /// **参数解释：** 设置用量封顶阈值，当实际用量大于阈值时停用域名，有效预防流量盗刷或恶意攻击带来的高额账单。  &gt; 由于监控数据存在时延，域名将在用量达到阈值后的10分钟左右被停用  **约束限制：** 不涉及
        /// </summary>
        [JsonProperty("flow_limit_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public List<FlowLimitStrategy> FlowLimitStrategy { get; set; }

        /// <summary>
        /// **参数解释：** 回源请求头，CDN节点回源时，在请求源站时添加指定的HTTP请求头信息 **约束限制：** - 调用接口修改回源请求头时，将覆盖原先已配置的回源请求头
        /// </summary>
        [JsonProperty("origin_request_header", NullValueHandling = NullValueHandling.Ignore)]
        public List<OriginRequestHeader> OriginRequestHeader { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("https", NullValueHandling = NullValueHandling.Ignore)]
        public HttpTemplateBody Https { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("quic", NullValueHandling = NullValueHandling.Ignore)]
        public Quic Quic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("force_redirect", NullValueHandling = NullValueHandling.Ignore)]
        public ForceRedirectConfig ForceRedirect { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("https_tls_version", NullValueHandling = NullValueHandling.Ignore)]
        public HttpsTlsVersion HttpsTlsVersion { get; set; }

        /// <summary>
        /// **参数解释：** 区域访问控制，通过配置访问控制规则限制客户端所在地区，实现只允许或只禁止特定地区的用户访问资源 **约束限制：** - 不涉及
        /// </summary>
        [JsonProperty("access_area_filter", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccessAreaFilter> AccessAreaFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("url_auth", NullValueHandling = NullValueHandling.Ignore)]
        public UrlAuth UrlAuth { get; set; }

        /// <summary>
        /// **参数解释：** 规则引擎，通过配置规则来对请求和响应进行自定义控制 **约束限制：** 不涉及
        /// </summary>
        [JsonProperty("rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<RuleResponse> Rules { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateConfigs {\n");
            sb.Append("  httpResponseHeader: ").Append(HttpResponseHeader).Append("\n");
            sb.Append("  cacheRules: ").Append(CacheRules).Append("\n");
            sb.Append("  originFollow302Status: ").Append(OriginFollow302Status).Append("\n");
            sb.Append("  compress: ").Append(Compress).Append("\n");
            sb.Append("  originRangeStatus: ").Append(OriginRangeStatus).Append("\n");
            sb.Append("  ipFilter: ").Append(IpFilter).Append("\n");
            sb.Append("  referer: ").Append(Referer).Append("\n");
            sb.Append("  userAgentFilter: ").Append(UserAgentFilter).Append("\n");
            sb.Append("  flowLimitStrategy: ").Append(FlowLimitStrategy).Append("\n");
            sb.Append("  originRequestHeader: ").Append(OriginRequestHeader).Append("\n");
            sb.Append("  https: ").Append(Https).Append("\n");
            sb.Append("  quic: ").Append(Quic).Append("\n");
            sb.Append("  forceRedirect: ").Append(ForceRedirect).Append("\n");
            sb.Append("  httpsTlsVersion: ").Append(HttpsTlsVersion).Append("\n");
            sb.Append("  accessAreaFilter: ").Append(AccessAreaFilter).Append("\n");
            sb.Append("  urlAuth: ").Append(UrlAuth).Append("\n");
            sb.Append("  rules: ").Append(Rules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TemplateConfigs);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TemplateConfigs input)
        {
            if (input == null) return false;
            if (this.HttpResponseHeader != input.HttpResponseHeader || (this.HttpResponseHeader != null && input.HttpResponseHeader != null && !this.HttpResponseHeader.SequenceEqual(input.HttpResponseHeader))) return false;
            if (this.CacheRules != input.CacheRules || (this.CacheRules != null && input.CacheRules != null && !this.CacheRules.SequenceEqual(input.CacheRules))) return false;
            if (this.OriginFollow302Status != input.OriginFollow302Status || (this.OriginFollow302Status != null && !this.OriginFollow302Status.Equals(input.OriginFollow302Status))) return false;
            if (this.Compress != input.Compress || (this.Compress != null && !this.Compress.Equals(input.Compress))) return false;
            if (this.OriginRangeStatus != input.OriginRangeStatus || (this.OriginRangeStatus != null && !this.OriginRangeStatus.Equals(input.OriginRangeStatus))) return false;
            if (this.IpFilter != input.IpFilter || (this.IpFilter != null && !this.IpFilter.Equals(input.IpFilter))) return false;
            if (this.Referer != input.Referer || (this.Referer != null && !this.Referer.Equals(input.Referer))) return false;
            if (this.UserAgentFilter != input.UserAgentFilter || (this.UserAgentFilter != null && !this.UserAgentFilter.Equals(input.UserAgentFilter))) return false;
            if (this.FlowLimitStrategy != input.FlowLimitStrategy || (this.FlowLimitStrategy != null && input.FlowLimitStrategy != null && !this.FlowLimitStrategy.SequenceEqual(input.FlowLimitStrategy))) return false;
            if (this.OriginRequestHeader != input.OriginRequestHeader || (this.OriginRequestHeader != null && input.OriginRequestHeader != null && !this.OriginRequestHeader.SequenceEqual(input.OriginRequestHeader))) return false;
            if (this.Https != input.Https || (this.Https != null && !this.Https.Equals(input.Https))) return false;
            if (this.Quic != input.Quic || (this.Quic != null && !this.Quic.Equals(input.Quic))) return false;
            if (this.ForceRedirect != input.ForceRedirect || (this.ForceRedirect != null && !this.ForceRedirect.Equals(input.ForceRedirect))) return false;
            if (this.HttpsTlsVersion != input.HttpsTlsVersion || (this.HttpsTlsVersion != null && !this.HttpsTlsVersion.Equals(input.HttpsTlsVersion))) return false;
            if (this.AccessAreaFilter != input.AccessAreaFilter || (this.AccessAreaFilter != null && input.AccessAreaFilter != null && !this.AccessAreaFilter.SequenceEqual(input.AccessAreaFilter))) return false;
            if (this.UrlAuth != input.UrlAuth || (this.UrlAuth != null && !this.UrlAuth.Equals(input.UrlAuth))) return false;
            if (this.Rules != input.Rules || (this.Rules != null && input.Rules != null && !this.Rules.SequenceEqual(input.Rules))) return false;

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
                if (this.HttpResponseHeader != null) hashCode = hashCode * 59 + this.HttpResponseHeader.GetHashCode();
                if (this.CacheRules != null) hashCode = hashCode * 59 + this.CacheRules.GetHashCode();
                if (this.OriginFollow302Status != null) hashCode = hashCode * 59 + this.OriginFollow302Status.GetHashCode();
                if (this.Compress != null) hashCode = hashCode * 59 + this.Compress.GetHashCode();
                if (this.OriginRangeStatus != null) hashCode = hashCode * 59 + this.OriginRangeStatus.GetHashCode();
                if (this.IpFilter != null) hashCode = hashCode * 59 + this.IpFilter.GetHashCode();
                if (this.Referer != null) hashCode = hashCode * 59 + this.Referer.GetHashCode();
                if (this.UserAgentFilter != null) hashCode = hashCode * 59 + this.UserAgentFilter.GetHashCode();
                if (this.FlowLimitStrategy != null) hashCode = hashCode * 59 + this.FlowLimitStrategy.GetHashCode();
                if (this.OriginRequestHeader != null) hashCode = hashCode * 59 + this.OriginRequestHeader.GetHashCode();
                if (this.Https != null) hashCode = hashCode * 59 + this.Https.GetHashCode();
                if (this.Quic != null) hashCode = hashCode * 59 + this.Quic.GetHashCode();
                if (this.ForceRedirect != null) hashCode = hashCode * 59 + this.ForceRedirect.GetHashCode();
                if (this.HttpsTlsVersion != null) hashCode = hashCode * 59 + this.HttpsTlsVersion.GetHashCode();
                if (this.AccessAreaFilter != null) hashCode = hashCode * 59 + this.AccessAreaFilter.GetHashCode();
                if (this.UrlAuth != null) hashCode = hashCode * 59 + this.UrlAuth.GetHashCode();
                if (this.Rules != null) hashCode = hashCode * 59 + this.Rules.GetHashCode();
                return hashCode;
            }
        }
    }
}
