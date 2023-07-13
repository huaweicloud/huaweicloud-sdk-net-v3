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
    /// 配置项。
    /// </summary>
    public class ConfigsGetBody 
    {

        /// <summary>
        /// 业务类型，web：网站加速，download：文件下载加速，video：点播加速，wholesit：全站加速。
        /// </summary>
        [JsonProperty("business_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessType { get; set; }

        /// <summary>
        /// 服务区域，mainland_china：中国大陆，global：全球，outside_mainland_china：中国大陆境外。
        /// </summary>
        [JsonProperty("service_area", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceArea { get; set; }

        /// <summary>
        /// 回源请求头配置
        /// </summary>
        [JsonProperty("origin_request_header", NullValueHandling = NullValueHandling.Ignore)]
        public List<OriginRequestHeader> OriginRequestHeader { get; set; }

        /// <summary>
        /// http header配置
        /// </summary>
        [JsonProperty("http_response_header", NullValueHandling = NullValueHandling.Ignore)]
        public List<HttpResponseHeader> HttpResponseHeader { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("url_auth", NullValueHandling = NullValueHandling.Ignore)]
        public UrlAuthGetBody UrlAuth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("https", NullValueHandling = NullValueHandling.Ignore)]
        public HttpGetBody Https { get; set; }

        /// <summary>
        /// 源站配置。
        /// </summary>
        [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
        public List<SourcesConfig> Sources { get; set; }

        /// <summary>
        /// 回源协议，follow：协议跟随回源，http：HTTP回源(默认)，https：https回源。
        /// </summary>
        [JsonProperty("origin_protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginProtocol { get; set; }

        /// <summary>
        /// 回源跟随，on：开启，off：关闭。
        /// </summary>
        [JsonProperty("origin_follow302_status", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginFollow302Status { get; set; }

        /// <summary>
        /// 缓存规则。
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
        /// ipv6设置，1：打开；0：关闭。
        /// </summary>
        [JsonProperty("ipv6_accelerate", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ipv6Accelerate { get; set; }

        /// <summary>
        /// 状态码缓存时间。
        /// </summary>
        [JsonProperty("error_code_cache", NullValueHandling = NullValueHandling.Ignore)]
        public List<ErrorCodeCache> ErrorCodeCache { get; set; }

        /// <summary>
        /// Range回源，开启: on，off:关闭。
        /// </summary>
        [JsonProperty("origin_range_status", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginRangeStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("user_agent_filter", NullValueHandling = NullValueHandling.Ignore)]
        public UserAgentFilter UserAgentFilter { get; set; }

        /// <summary>
        /// 改写回源URL。
        /// </summary>
        [JsonProperty("origin_request_url_rewrite", NullValueHandling = NullValueHandling.Ignore)]
        public List<OriginRequestUrlRewrite> OriginRequestUrlRewrite { get; set; }

        /// <summary>
        /// 高级回源。
        /// </summary>
        [JsonProperty("flexible_origin", NullValueHandling = NullValueHandling.Ignore)]
        public List<FlexibleOrigins> FlexibleOrigin { get; set; }

        /// <summary>
        /// 回源是否校验ETag，on：开启，off：关闭。
        /// </summary>
        [JsonProperty("slice_etag_status", NullValueHandling = NullValueHandling.Ignore)]
        public string SliceEtagStatus { get; set; }

        /// <summary>
        /// 回源超时时间，单位：秒。
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
        /// 请求限速。
        /// </summary>
        [JsonProperty("request_limit_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<RequestLimitRules> RequestLimitRules { get; set; }

        /// <summary>
        /// 自定义错误页面
        /// </summary>
        [JsonProperty("error_code_redirect_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<ErrorCodeRedirectRules> ErrorCodeRedirectRules { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigsGetBody {\n");
            sb.Append("  businessType: ").Append(BusinessType).Append("\n");
            sb.Append("  serviceArea: ").Append(ServiceArea).Append("\n");
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
            sb.Append("  errorCodeRedirectRules: ").Append(ErrorCodeRedirectRules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConfigsGetBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConfigsGetBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BusinessType == input.BusinessType ||
                    (this.BusinessType != null &&
                    this.BusinessType.Equals(input.BusinessType))
                ) && 
                (
                    this.ServiceArea == input.ServiceArea ||
                    (this.ServiceArea != null &&
                    this.ServiceArea.Equals(input.ServiceArea))
                ) && 
                (
                    this.OriginRequestHeader == input.OriginRequestHeader ||
                    this.OriginRequestHeader != null &&
                    input.OriginRequestHeader != null &&
                    this.OriginRequestHeader.SequenceEqual(input.OriginRequestHeader)
                ) && 
                (
                    this.HttpResponseHeader == input.HttpResponseHeader ||
                    this.HttpResponseHeader != null &&
                    input.HttpResponseHeader != null &&
                    this.HttpResponseHeader.SequenceEqual(input.HttpResponseHeader)
                ) && 
                (
                    this.UrlAuth == input.UrlAuth ||
                    (this.UrlAuth != null &&
                    this.UrlAuth.Equals(input.UrlAuth))
                ) && 
                (
                    this.Https == input.Https ||
                    (this.Https != null &&
                    this.Https.Equals(input.Https))
                ) && 
                (
                    this.Sources == input.Sources ||
                    this.Sources != null &&
                    input.Sources != null &&
                    this.Sources.SequenceEqual(input.Sources)
                ) && 
                (
                    this.OriginProtocol == input.OriginProtocol ||
                    (this.OriginProtocol != null &&
                    this.OriginProtocol.Equals(input.OriginProtocol))
                ) && 
                (
                    this.OriginFollow302Status == input.OriginFollow302Status ||
                    (this.OriginFollow302Status != null &&
                    this.OriginFollow302Status.Equals(input.OriginFollow302Status))
                ) && 
                (
                    this.CacheRules == input.CacheRules ||
                    this.CacheRules != null &&
                    input.CacheRules != null &&
                    this.CacheRules.SequenceEqual(input.CacheRules)
                ) && 
                (
                    this.IpFilter == input.IpFilter ||
                    (this.IpFilter != null &&
                    this.IpFilter.Equals(input.IpFilter))
                ) && 
                (
                    this.Referer == input.Referer ||
                    (this.Referer != null &&
                    this.Referer.Equals(input.Referer))
                ) && 
                (
                    this.ForceRedirect == input.ForceRedirect ||
                    (this.ForceRedirect != null &&
                    this.ForceRedirect.Equals(input.ForceRedirect))
                ) && 
                (
                    this.Compress == input.Compress ||
                    (this.Compress != null &&
                    this.Compress.Equals(input.Compress))
                ) && 
                (
                    this.CacheUrlParameterFilter == input.CacheUrlParameterFilter ||
                    (this.CacheUrlParameterFilter != null &&
                    this.CacheUrlParameterFilter.Equals(input.CacheUrlParameterFilter))
                ) && 
                (
                    this.Ipv6Accelerate == input.Ipv6Accelerate ||
                    (this.Ipv6Accelerate != null &&
                    this.Ipv6Accelerate.Equals(input.Ipv6Accelerate))
                ) && 
                (
                    this.ErrorCodeCache == input.ErrorCodeCache ||
                    this.ErrorCodeCache != null &&
                    input.ErrorCodeCache != null &&
                    this.ErrorCodeCache.SequenceEqual(input.ErrorCodeCache)
                ) && 
                (
                    this.OriginRangeStatus == input.OriginRangeStatus ||
                    (this.OriginRangeStatus != null &&
                    this.OriginRangeStatus.Equals(input.OriginRangeStatus))
                ) && 
                (
                    this.UserAgentFilter == input.UserAgentFilter ||
                    (this.UserAgentFilter != null &&
                    this.UserAgentFilter.Equals(input.UserAgentFilter))
                ) && 
                (
                    this.OriginRequestUrlRewrite == input.OriginRequestUrlRewrite ||
                    this.OriginRequestUrlRewrite != null &&
                    input.OriginRequestUrlRewrite != null &&
                    this.OriginRequestUrlRewrite.SequenceEqual(input.OriginRequestUrlRewrite)
                ) && 
                (
                    this.FlexibleOrigin == input.FlexibleOrigin ||
                    this.FlexibleOrigin != null &&
                    input.FlexibleOrigin != null &&
                    this.FlexibleOrigin.SequenceEqual(input.FlexibleOrigin)
                ) && 
                (
                    this.SliceEtagStatus == input.SliceEtagStatus ||
                    (this.SliceEtagStatus != null &&
                    this.SliceEtagStatus.Equals(input.SliceEtagStatus))
                ) && 
                (
                    this.OriginReceiveTimeout == input.OriginReceiveTimeout ||
                    (this.OriginReceiveTimeout != null &&
                    this.OriginReceiveTimeout.Equals(input.OriginReceiveTimeout))
                ) && 
                (
                    this.RemoteAuth == input.RemoteAuth ||
                    (this.RemoteAuth != null &&
                    this.RemoteAuth.Equals(input.RemoteAuth))
                ) && 
                (
                    this.Websocket == input.Websocket ||
                    (this.Websocket != null &&
                    this.Websocket.Equals(input.Websocket))
                ) && 
                (
                    this.VideoSeek == input.VideoSeek ||
                    (this.VideoSeek != null &&
                    this.VideoSeek.Equals(input.VideoSeek))
                ) && 
                (
                    this.RequestLimitRules == input.RequestLimitRules ||
                    this.RequestLimitRules != null &&
                    input.RequestLimitRules != null &&
                    this.RequestLimitRules.SequenceEqual(input.RequestLimitRules)
                ) && 
                (
                    this.ErrorCodeRedirectRules == input.ErrorCodeRedirectRules ||
                    this.ErrorCodeRedirectRules != null &&
                    input.ErrorCodeRedirectRules != null &&
                    this.ErrorCodeRedirectRules.SequenceEqual(input.ErrorCodeRedirectRules)
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
                if (this.BusinessType != null)
                    hashCode = hashCode * 59 + this.BusinessType.GetHashCode();
                if (this.ServiceArea != null)
                    hashCode = hashCode * 59 + this.ServiceArea.GetHashCode();
                if (this.OriginRequestHeader != null)
                    hashCode = hashCode * 59 + this.OriginRequestHeader.GetHashCode();
                if (this.HttpResponseHeader != null)
                    hashCode = hashCode * 59 + this.HttpResponseHeader.GetHashCode();
                if (this.UrlAuth != null)
                    hashCode = hashCode * 59 + this.UrlAuth.GetHashCode();
                if (this.Https != null)
                    hashCode = hashCode * 59 + this.Https.GetHashCode();
                if (this.Sources != null)
                    hashCode = hashCode * 59 + this.Sources.GetHashCode();
                if (this.OriginProtocol != null)
                    hashCode = hashCode * 59 + this.OriginProtocol.GetHashCode();
                if (this.OriginFollow302Status != null)
                    hashCode = hashCode * 59 + this.OriginFollow302Status.GetHashCode();
                if (this.CacheRules != null)
                    hashCode = hashCode * 59 + this.CacheRules.GetHashCode();
                if (this.IpFilter != null)
                    hashCode = hashCode * 59 + this.IpFilter.GetHashCode();
                if (this.Referer != null)
                    hashCode = hashCode * 59 + this.Referer.GetHashCode();
                if (this.ForceRedirect != null)
                    hashCode = hashCode * 59 + this.ForceRedirect.GetHashCode();
                if (this.Compress != null)
                    hashCode = hashCode * 59 + this.Compress.GetHashCode();
                if (this.CacheUrlParameterFilter != null)
                    hashCode = hashCode * 59 + this.CacheUrlParameterFilter.GetHashCode();
                if (this.Ipv6Accelerate != null)
                    hashCode = hashCode * 59 + this.Ipv6Accelerate.GetHashCode();
                if (this.ErrorCodeCache != null)
                    hashCode = hashCode * 59 + this.ErrorCodeCache.GetHashCode();
                if (this.OriginRangeStatus != null)
                    hashCode = hashCode * 59 + this.OriginRangeStatus.GetHashCode();
                if (this.UserAgentFilter != null)
                    hashCode = hashCode * 59 + this.UserAgentFilter.GetHashCode();
                if (this.OriginRequestUrlRewrite != null)
                    hashCode = hashCode * 59 + this.OriginRequestUrlRewrite.GetHashCode();
                if (this.FlexibleOrigin != null)
                    hashCode = hashCode * 59 + this.FlexibleOrigin.GetHashCode();
                if (this.SliceEtagStatus != null)
                    hashCode = hashCode * 59 + this.SliceEtagStatus.GetHashCode();
                if (this.OriginReceiveTimeout != null)
                    hashCode = hashCode * 59 + this.OriginReceiveTimeout.GetHashCode();
                if (this.RemoteAuth != null)
                    hashCode = hashCode * 59 + this.RemoteAuth.GetHashCode();
                if (this.Websocket != null)
                    hashCode = hashCode * 59 + this.Websocket.GetHashCode();
                if (this.VideoSeek != null)
                    hashCode = hashCode * 59 + this.VideoSeek.GetHashCode();
                if (this.RequestLimitRules != null)
                    hashCode = hashCode * 59 + this.RequestLimitRules.GetHashCode();
                if (this.ErrorCodeRedirectRules != null)
                    hashCode = hashCode * 59 + this.ErrorCodeRedirectRules.GetHashCode();
                return hashCode;
            }
        }
    }
}
