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
    /// **参数解释：** 配置项 **约束限制：** 不涉及
    /// </summary>
    public class Configs 
    {

        /// <summary>
        /// **参数解释：** 业务类型 **约束限制：** 暂不支持“全站加速”变更为其它业务类型 **取值范围：** - web: 网站加速 - download: 文件下载加速 - video: 点播加速  **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("business_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessType { get; set; }

        /// <summary>
        /// **参数解释：** 加速域名的服务范围，客户端访问将会调度到服务范围内的CDN节点，可根据用户聚集区域选择合适的范围 **约束限制：** - 暂不支持“中国大陆”与“中国大陆境外”互相直接切换 - 服务范围修改为中国大陆或全球时，加速域名需要到工信部备案  **取值范围：** - mainland_china：中国大陆 - global：全球 - outside_mainland_china：中国大陆境外  **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("service_area", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceArea { get; set; }

        /// <summary>
        /// **参数解释：** 域名备注信息 **约束限制：** 不涉及 **取值范围：** 0-10000个字符 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("remark", NullValueHandling = NullValueHandling.Ignore)]
        public string Remark { get; set; }

        /// <summary>
        /// **参数解释：** 回源请求头，CDN节点回源时，根据回源请求头配置操作请求的HTTP头部信息 **约束限制：** - 修改时该功能将覆盖原有配置（清空之前的配置），在使用此接口时，请上传全量头部信息 - 如果域名在后台配置了特殊请求头，需要将对应的请求头一并传入
        /// </summary>
        [JsonProperty("origin_request_header", NullValueHandling = NullValueHandling.Ignore)]
        public List<OriginRequestHeader> OriginRequestHeader { get; set; }

        /// <summary>
        /// **参数解释：** HTTP响应头，CDN节点响应客户端时，根据HTTP响应头配置操作响应的HTTP头部信息 **约束限制：** - 修改时该功能将覆盖原有配置（清空之前的配置），在使用此接口时，请上传全量头部信息 - 如果域名在后台配置了特殊响应头，需要将对应的响应头一并传入
        /// </summary>
        [JsonProperty("http_response_header", NullValueHandling = NullValueHandling.Ignore)]
        public List<HttpResponseHeader> HttpResponseHeader { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("url_auth", NullValueHandling = NullValueHandling.Ignore)]
        public UrlAuth UrlAuth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("https", NullValueHandling = NullValueHandling.Ignore)]
        public HttpPutBody Https { get; set; }

        /// <summary>
        /// **参数解释：** 配置加速域名的源站，CDN通过加速域名将源站上需要加速的内容缓存到CDN节点，达到加速访问资源的效果 **约束限制：** 不涉及
        /// </summary>
        [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
        public List<SourcesConfig> Sources { get; set; }

        /// <summary>
        /// **参数解释：** 指定CDN回源时的请求协议 **约束限制：** 不涉及 **取值范围：** - follow: 协议跟随 - http: http协议 - https: https协议  **默认取值：** http: http协议
        /// </summary>
        [JsonProperty("origin_protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginProtocol { get; set; }

        /// <summary>
        /// **参数解释：** 开启回源跟随，当源站地址因业务需求做了301/302 重定向，CDN节点会先跳转到301/302对应地址获取资源，缓存后再返回给用户 **约束限制：** 不涉及 **取值范围：** - on: 开启 - off: 关闭  **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("origin_follow302_status", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginFollow302Status { get; set; }

        /// <summary>
        /// **参数解释：** 通过不同参数控制源站资源在CDN节点的缓存时长 **约束限制：** 必须存在一条所有文件类型的规则
        /// </summary>
        [JsonProperty("cache_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<CacheRules> CacheRules { get; set; }

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
        [JsonProperty("force_redirect", NullValueHandling = NullValueHandling.Ignore)]
        public ForceRedirectConfig ForceRedirect { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("compress", NullValueHandling = NullValueHandling.Ignore)]
        public Compress Compress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cache_url_parameter_filter", NullValueHandling = NullValueHandling.Ignore)]
        public CacheUrlParameterFilter CacheUrlParameterFilter { get; set; }

        /// <summary>
        /// **参数解释：** 配置客户端用IPv6协议访问CDN节点 **约束限制：** 不涉及 **取值范围：** - 1: 开启 - 0: 关闭  **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("ipv6_accelerate", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ipv6Accelerate { get; set; }

        /// <summary>
        /// **参数解释：** 将源站返回的错误状态码缓存到CDN节点，用户再次请求时由CDN直接响应给用户错误码 **约束限制：** 不涉及
        /// </summary>
        [JsonProperty("error_code_cache", NullValueHandling = NullValueHandling.Ignore)]
        public List<ErrorCodeCache> ErrorCodeCache { get; set; }

        /// <summary>
        /// **参数解释：** Range回源，开启后，源站在收到CDN节点回源请求时，根据HTTP请求头中的Range信息返回指定范围的数据给CDN节点 **约束限制：** 开启Range回源的前提是您的源站支持Range请求，即HTTP请求头中包含Range字段，否则可能导致回源失败 **取值范围：** - on: 开启 - off: 关闭  **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("origin_range_status", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginRangeStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("user_agent_filter", NullValueHandling = NullValueHandling.Ignore)]
        public UserAgentFilter UserAgentFilter { get; set; }

        /// <summary>
        /// **参数解释：** 回源URL改写，解决回源请求URL与源站URL不匹配的问题 **约束限制：** 最多配置20条
        /// </summary>
        [JsonProperty("origin_request_url_rewrite", NullValueHandling = NullValueHandling.Ignore)]
        public List<OriginRequestUrlRewrite> OriginRequestUrlRewrite { get; set; }

        /// <summary>
        /// **参数解释：** 高级回源，实现根据不同的资源类型或路径回源到不同源站 **约束限制：** 最多配置20条
        /// </summary>
        [JsonProperty("flexible_origin", NullValueHandling = NullValueHandling.Ignore)]
        public List<FlexibleOrigins> FlexibleOrigin { get; set; }

        /// <summary>
        /// **参数解释：** 回源是否校验ETag，开启此项配置后，当用户再次请求节点已缓存资源时，会将ETag的值加入到判断资源是否过期的逻辑 **约束限制：** 不涉及 **取值范围：** - on: 开启 - off: 关闭  **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("slice_etag_status", NullValueHandling = NullValueHandling.Ignore)]
        public string SliceEtagStatus { get; set; }

        /// <summary>
        /// **参数解释：** 自定义设置CDN节点回源时的超时时间，请求超时即表示此次回源失败 **约束限制：** 不涉及 **取值范围：** 5-300，单位：秒 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("origin_receive_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? OriginReceiveTimeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("remote_auth", NullValueHandling = NullValueHandling.Ignore)]
        public CommonRemoteAuth RemoteAuth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("websocket", NullValueHandling = NullValueHandling.Ignore)]
        public WebSocketSeek Websocket { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("video_seek", NullValueHandling = NullValueHandling.Ignore)]
        public VideoSeek VideoSeek { get; set; }

        /// <summary>
        /// **参数解释：** 请求限速，将用户请求速度限制在指定范围内，一定程度上减少突发高带宽风险，节省成本 **约束限制：** 不涉及
        /// </summary>
        [JsonProperty("request_limit_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<RequestLimitRules> RequestLimitRules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ip_frequency_limit", NullValueHandling = NullValueHandling.Ignore)]
        public IpFrequencyLimit IpFrequencyLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hsts", NullValueHandling = NullValueHandling.Ignore)]
        public Hsts Hsts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("quic", NullValueHandling = NullValueHandling.Ignore)]
        public Quic Quic { get; set; }

        /// <summary>
        /// **参数解释：** 自定义错误页面，当访问页面出错时，会给客户端返回指定的页面，优化用户体验 **约束限制：** 不涉及
        /// </summary>
        [JsonProperty("error_code_redirect_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<ErrorCodeRedirectRules> ErrorCodeRedirectRules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sni", NullValueHandling = NullValueHandling.Ignore)]
        public Sni Sni { get; set; }

        /// <summary>
        /// **参数解释：** 访问URL重写，当用户请求URL与CDN节点缓存资源的URL不一致时，可以通过访问URL重写功能重定向到目标URL **约束限制：** 不涉及
        /// </summary>
        [JsonProperty("request_url_rewrite", NullValueHandling = NullValueHandling.Ignore)]
        public List<RequestUrlRewrite> RequestUrlRewrite { get; set; }

        /// <summary>
        /// **参数解释：** 浏览器缓存过期时间，当终端用户请求资源时，如果浏览器有缓存，直接返回给用户 **约束限制：** 不涉及
        /// </summary>
        [JsonProperty("browser_cache_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<BrowserCacheRules> BrowserCacheRules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("access_area_filter", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccessAreaFilter> AccessAreaFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("client_cert", NullValueHandling = NullValueHandling.Ignore)]
        public ClientCert ClientCert { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("https_tls_version", NullValueHandling = NullValueHandling.Ignore)]
        public HttpsTlsVersion HttpsTlsVersion { get; set; }

        /// <summary>
        /// **参数解释：** 设置用量封顶阈值，当实际用量大于阈值时停用域名，有效预防流量盗刷或恶意攻击带来的高额账单。  &gt; 由于监控数据存在时延，域名将在用量达到阈值后的10分钟左右被停用  **约束限制：** 不涉及
        /// </summary>
        [JsonProperty("flow_limit_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public List<FlowLimitStrategy> FlowLimitStrategy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bandwidth_alarm_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public BandwidthAlarmStrategy BandwidthAlarmStrategy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Configs {\n");
            sb.Append("  businessType: ").Append(BusinessType).Append("\n");
            sb.Append("  serviceArea: ").Append(ServiceArea).Append("\n");
            sb.Append("  remark: ").Append(Remark).Append("\n");
            sb.Append("  originRequestHeader: ").Append(OriginRequestHeader).Append("\n");
            sb.Append("  httpResponseHeader: ").Append(HttpResponseHeader).Append("\n");
            sb.Append("  urlAuth: ").Append(UrlAuth).Append("\n");
            sb.Append("  https: ").Append(Https).Append("\n");
            sb.Append("  sources: ").Append(Sources).Append("\n");
            sb.Append("  originProtocol: ").Append(OriginProtocol).Append("\n");
            sb.Append("  originFollow302Status: ").Append(OriginFollow302Status).Append("\n");
            sb.Append("  cacheRules: ").Append(CacheRules).Append("\n");
            sb.Append("  ipFilter: ").Append(IpFilter).Append("\n");
            sb.Append("  referer: ").Append(Referer).Append("\n");
            sb.Append("  forceRedirect: ").Append(ForceRedirect).Append("\n");
            sb.Append("  compress: ").Append(Compress).Append("\n");
            sb.Append("  cacheUrlParameterFilter: ").Append(CacheUrlParameterFilter).Append("\n");
            sb.Append("  ipv6Accelerate: ").Append(Ipv6Accelerate).Append("\n");
            sb.Append("  errorCodeCache: ").Append(ErrorCodeCache).Append("\n");
            sb.Append("  originRangeStatus: ").Append(OriginRangeStatus).Append("\n");
            sb.Append("  userAgentFilter: ").Append(UserAgentFilter).Append("\n");
            sb.Append("  originRequestUrlRewrite: ").Append(OriginRequestUrlRewrite).Append("\n");
            sb.Append("  flexibleOrigin: ").Append(FlexibleOrigin).Append("\n");
            sb.Append("  sliceEtagStatus: ").Append(SliceEtagStatus).Append("\n");
            sb.Append("  originReceiveTimeout: ").Append(OriginReceiveTimeout).Append("\n");
            sb.Append("  remoteAuth: ").Append(RemoteAuth).Append("\n");
            sb.Append("  websocket: ").Append(Websocket).Append("\n");
            sb.Append("  videoSeek: ").Append(VideoSeek).Append("\n");
            sb.Append("  requestLimitRules: ").Append(RequestLimitRules).Append("\n");
            sb.Append("  ipFrequencyLimit: ").Append(IpFrequencyLimit).Append("\n");
            sb.Append("  hsts: ").Append(Hsts).Append("\n");
            sb.Append("  quic: ").Append(Quic).Append("\n");
            sb.Append("  errorCodeRedirectRules: ").Append(ErrorCodeRedirectRules).Append("\n");
            sb.Append("  sni: ").Append(Sni).Append("\n");
            sb.Append("  requestUrlRewrite: ").Append(RequestUrlRewrite).Append("\n");
            sb.Append("  browserCacheRules: ").Append(BrowserCacheRules).Append("\n");
            sb.Append("  accessAreaFilter: ").Append(AccessAreaFilter).Append("\n");
            sb.Append("  clientCert: ").Append(ClientCert).Append("\n");
            sb.Append("  httpsTlsVersion: ").Append(HttpsTlsVersion).Append("\n");
            sb.Append("  flowLimitStrategy: ").Append(FlowLimitStrategy).Append("\n");
            sb.Append("  bandwidthAlarmStrategy: ").Append(BandwidthAlarmStrategy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Configs);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Configs input)
        {
            if (input == null) return false;
            if (this.BusinessType != input.BusinessType || (this.BusinessType != null && !this.BusinessType.Equals(input.BusinessType))) return false;
            if (this.ServiceArea != input.ServiceArea || (this.ServiceArea != null && !this.ServiceArea.Equals(input.ServiceArea))) return false;
            if (this.Remark != input.Remark || (this.Remark != null && !this.Remark.Equals(input.Remark))) return false;
            if (this.OriginRequestHeader != input.OriginRequestHeader || (this.OriginRequestHeader != null && input.OriginRequestHeader != null && !this.OriginRequestHeader.SequenceEqual(input.OriginRequestHeader))) return false;
            if (this.HttpResponseHeader != input.HttpResponseHeader || (this.HttpResponseHeader != null && input.HttpResponseHeader != null && !this.HttpResponseHeader.SequenceEqual(input.HttpResponseHeader))) return false;
            if (this.UrlAuth != input.UrlAuth || (this.UrlAuth != null && !this.UrlAuth.Equals(input.UrlAuth))) return false;
            if (this.Https != input.Https || (this.Https != null && !this.Https.Equals(input.Https))) return false;
            if (this.Sources != input.Sources || (this.Sources != null && input.Sources != null && !this.Sources.SequenceEqual(input.Sources))) return false;
            if (this.OriginProtocol != input.OriginProtocol || (this.OriginProtocol != null && !this.OriginProtocol.Equals(input.OriginProtocol))) return false;
            if (this.OriginFollow302Status != input.OriginFollow302Status || (this.OriginFollow302Status != null && !this.OriginFollow302Status.Equals(input.OriginFollow302Status))) return false;
            if (this.CacheRules != input.CacheRules || (this.CacheRules != null && input.CacheRules != null && !this.CacheRules.SequenceEqual(input.CacheRules))) return false;
            if (this.IpFilter != input.IpFilter || (this.IpFilter != null && !this.IpFilter.Equals(input.IpFilter))) return false;
            if (this.Referer != input.Referer || (this.Referer != null && !this.Referer.Equals(input.Referer))) return false;
            if (this.ForceRedirect != input.ForceRedirect || (this.ForceRedirect != null && !this.ForceRedirect.Equals(input.ForceRedirect))) return false;
            if (this.Compress != input.Compress || (this.Compress != null && !this.Compress.Equals(input.Compress))) return false;
            if (this.CacheUrlParameterFilter != input.CacheUrlParameterFilter || (this.CacheUrlParameterFilter != null && !this.CacheUrlParameterFilter.Equals(input.CacheUrlParameterFilter))) return false;
            if (this.Ipv6Accelerate != input.Ipv6Accelerate || (this.Ipv6Accelerate != null && !this.Ipv6Accelerate.Equals(input.Ipv6Accelerate))) return false;
            if (this.ErrorCodeCache != input.ErrorCodeCache || (this.ErrorCodeCache != null && input.ErrorCodeCache != null && !this.ErrorCodeCache.SequenceEqual(input.ErrorCodeCache))) return false;
            if (this.OriginRangeStatus != input.OriginRangeStatus || (this.OriginRangeStatus != null && !this.OriginRangeStatus.Equals(input.OriginRangeStatus))) return false;
            if (this.UserAgentFilter != input.UserAgentFilter || (this.UserAgentFilter != null && !this.UserAgentFilter.Equals(input.UserAgentFilter))) return false;
            if (this.OriginRequestUrlRewrite != input.OriginRequestUrlRewrite || (this.OriginRequestUrlRewrite != null && input.OriginRequestUrlRewrite != null && !this.OriginRequestUrlRewrite.SequenceEqual(input.OriginRequestUrlRewrite))) return false;
            if (this.FlexibleOrigin != input.FlexibleOrigin || (this.FlexibleOrigin != null && input.FlexibleOrigin != null && !this.FlexibleOrigin.SequenceEqual(input.FlexibleOrigin))) return false;
            if (this.SliceEtagStatus != input.SliceEtagStatus || (this.SliceEtagStatus != null && !this.SliceEtagStatus.Equals(input.SliceEtagStatus))) return false;
            if (this.OriginReceiveTimeout != input.OriginReceiveTimeout || (this.OriginReceiveTimeout != null && !this.OriginReceiveTimeout.Equals(input.OriginReceiveTimeout))) return false;
            if (this.RemoteAuth != input.RemoteAuth || (this.RemoteAuth != null && !this.RemoteAuth.Equals(input.RemoteAuth))) return false;
            if (this.Websocket != input.Websocket || (this.Websocket != null && !this.Websocket.Equals(input.Websocket))) return false;
            if (this.VideoSeek != input.VideoSeek || (this.VideoSeek != null && !this.VideoSeek.Equals(input.VideoSeek))) return false;
            if (this.RequestLimitRules != input.RequestLimitRules || (this.RequestLimitRules != null && input.RequestLimitRules != null && !this.RequestLimitRules.SequenceEqual(input.RequestLimitRules))) return false;
            if (this.IpFrequencyLimit != input.IpFrequencyLimit || (this.IpFrequencyLimit != null && !this.IpFrequencyLimit.Equals(input.IpFrequencyLimit))) return false;
            if (this.Hsts != input.Hsts || (this.Hsts != null && !this.Hsts.Equals(input.Hsts))) return false;
            if (this.Quic != input.Quic || (this.Quic != null && !this.Quic.Equals(input.Quic))) return false;
            if (this.ErrorCodeRedirectRules != input.ErrorCodeRedirectRules || (this.ErrorCodeRedirectRules != null && input.ErrorCodeRedirectRules != null && !this.ErrorCodeRedirectRules.SequenceEqual(input.ErrorCodeRedirectRules))) return false;
            if (this.Sni != input.Sni || (this.Sni != null && !this.Sni.Equals(input.Sni))) return false;
            if (this.RequestUrlRewrite != input.RequestUrlRewrite || (this.RequestUrlRewrite != null && input.RequestUrlRewrite != null && !this.RequestUrlRewrite.SequenceEqual(input.RequestUrlRewrite))) return false;
            if (this.BrowserCacheRules != input.BrowserCacheRules || (this.BrowserCacheRules != null && input.BrowserCacheRules != null && !this.BrowserCacheRules.SequenceEqual(input.BrowserCacheRules))) return false;
            if (this.AccessAreaFilter != input.AccessAreaFilter || (this.AccessAreaFilter != null && input.AccessAreaFilter != null && !this.AccessAreaFilter.SequenceEqual(input.AccessAreaFilter))) return false;
            if (this.ClientCert != input.ClientCert || (this.ClientCert != null && !this.ClientCert.Equals(input.ClientCert))) return false;
            if (this.HttpsTlsVersion != input.HttpsTlsVersion || (this.HttpsTlsVersion != null && !this.HttpsTlsVersion.Equals(input.HttpsTlsVersion))) return false;
            if (this.FlowLimitStrategy != input.FlowLimitStrategy || (this.FlowLimitStrategy != null && input.FlowLimitStrategy != null && !this.FlowLimitStrategy.SequenceEqual(input.FlowLimitStrategy))) return false;
            if (this.BandwidthAlarmStrategy != input.BandwidthAlarmStrategy || (this.BandwidthAlarmStrategy != null && !this.BandwidthAlarmStrategy.Equals(input.BandwidthAlarmStrategy))) return false;

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
                if (this.BusinessType != null) hashCode = hashCode * 59 + this.BusinessType.GetHashCode();
                if (this.ServiceArea != null) hashCode = hashCode * 59 + this.ServiceArea.GetHashCode();
                if (this.Remark != null) hashCode = hashCode * 59 + this.Remark.GetHashCode();
                if (this.OriginRequestHeader != null) hashCode = hashCode * 59 + this.OriginRequestHeader.GetHashCode();
                if (this.HttpResponseHeader != null) hashCode = hashCode * 59 + this.HttpResponseHeader.GetHashCode();
                if (this.UrlAuth != null) hashCode = hashCode * 59 + this.UrlAuth.GetHashCode();
                if (this.Https != null) hashCode = hashCode * 59 + this.Https.GetHashCode();
                if (this.Sources != null) hashCode = hashCode * 59 + this.Sources.GetHashCode();
                if (this.OriginProtocol != null) hashCode = hashCode * 59 + this.OriginProtocol.GetHashCode();
                if (this.OriginFollow302Status != null) hashCode = hashCode * 59 + this.OriginFollow302Status.GetHashCode();
                if (this.CacheRules != null) hashCode = hashCode * 59 + this.CacheRules.GetHashCode();
                if (this.IpFilter != null) hashCode = hashCode * 59 + this.IpFilter.GetHashCode();
                if (this.Referer != null) hashCode = hashCode * 59 + this.Referer.GetHashCode();
                if (this.ForceRedirect != null) hashCode = hashCode * 59 + this.ForceRedirect.GetHashCode();
                if (this.Compress != null) hashCode = hashCode * 59 + this.Compress.GetHashCode();
                if (this.CacheUrlParameterFilter != null) hashCode = hashCode * 59 + this.CacheUrlParameterFilter.GetHashCode();
                if (this.Ipv6Accelerate != null) hashCode = hashCode * 59 + this.Ipv6Accelerate.GetHashCode();
                if (this.ErrorCodeCache != null) hashCode = hashCode * 59 + this.ErrorCodeCache.GetHashCode();
                if (this.OriginRangeStatus != null) hashCode = hashCode * 59 + this.OriginRangeStatus.GetHashCode();
                if (this.UserAgentFilter != null) hashCode = hashCode * 59 + this.UserAgentFilter.GetHashCode();
                if (this.OriginRequestUrlRewrite != null) hashCode = hashCode * 59 + this.OriginRequestUrlRewrite.GetHashCode();
                if (this.FlexibleOrigin != null) hashCode = hashCode * 59 + this.FlexibleOrigin.GetHashCode();
                if (this.SliceEtagStatus != null) hashCode = hashCode * 59 + this.SliceEtagStatus.GetHashCode();
                if (this.OriginReceiveTimeout != null) hashCode = hashCode * 59 + this.OriginReceiveTimeout.GetHashCode();
                if (this.RemoteAuth != null) hashCode = hashCode * 59 + this.RemoteAuth.GetHashCode();
                if (this.Websocket != null) hashCode = hashCode * 59 + this.Websocket.GetHashCode();
                if (this.VideoSeek != null) hashCode = hashCode * 59 + this.VideoSeek.GetHashCode();
                if (this.RequestLimitRules != null) hashCode = hashCode * 59 + this.RequestLimitRules.GetHashCode();
                if (this.IpFrequencyLimit != null) hashCode = hashCode * 59 + this.IpFrequencyLimit.GetHashCode();
                if (this.Hsts != null) hashCode = hashCode * 59 + this.Hsts.GetHashCode();
                if (this.Quic != null) hashCode = hashCode * 59 + this.Quic.GetHashCode();
                if (this.ErrorCodeRedirectRules != null) hashCode = hashCode * 59 + this.ErrorCodeRedirectRules.GetHashCode();
                if (this.Sni != null) hashCode = hashCode * 59 + this.Sni.GetHashCode();
                if (this.RequestUrlRewrite != null) hashCode = hashCode * 59 + this.RequestUrlRewrite.GetHashCode();
                if (this.BrowserCacheRules != null) hashCode = hashCode * 59 + this.BrowserCacheRules.GetHashCode();
                if (this.AccessAreaFilter != null) hashCode = hashCode * 59 + this.AccessAreaFilter.GetHashCode();
                if (this.ClientCert != null) hashCode = hashCode * 59 + this.ClientCert.GetHashCode();
                if (this.HttpsTlsVersion != null) hashCode = hashCode * 59 + this.HttpsTlsVersion.GetHashCode();
                if (this.FlowLimitStrategy != null) hashCode = hashCode * 59 + this.FlowLimitStrategy.GetHashCode();
                if (this.BandwidthAlarmStrategy != null) hashCode = hashCode * 59 + this.BandwidthAlarmStrategy.GetHashCode();
                return hashCode;
            }
        }
    }
}
