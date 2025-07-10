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
    /// **参数解释：** 规则行为 **约束限制：** 不涉及
    /// </summary>
    public class Actions 
    {

        /// <summary>
        /// **参数解释：** 高级回源，实现根据不同的资源类型或路径回源到不同源站 **约束限制：** 最多配置20条
        /// </summary>
        [JsonProperty("flexible_origin", NullValueHandling = NullValueHandling.Ignore)]
        public List<FlexibleOriginsEngine> FlexibleOrigin { get; set; }

        /// <summary>
        /// **参数解释：** CDN节点回源时，改写用户回源请求URL的HTTP头部信息 **约束限制：** - 该功能将覆盖原有配置（清空之前的配置），在使用此接口时，请上传全量头部信息 - 如果域名在后台配置了特殊请求头，需要将对应的请求头一并传入
        /// </summary>
        [JsonProperty("origin_request_header", NullValueHandling = NullValueHandling.Ignore)]
        public List<OriginRequestHeader> OriginRequestHeader { get; set; }

        /// <summary>
        /// **参数解释：** 配置节点响应给客户端的头部信息，配置响应消息后，用户请求加速域名下的资源时，CDN返回给用户的消息中将包含该域名配置的响应头信息 **约束限制：** - 该功能将覆盖原有配置（清空之前的配置），在使用此接口时，请上传全量头部信息 - 如果域名在后台配置了特殊请求头，需要将对应的请求头一并传入
        /// </summary>
        [JsonProperty("http_response_header", NullValueHandling = NullValueHandling.Ignore)]
        public List<HttpResponseHeader> HttpResponseHeader { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("access_control", NullValueHandling = NullValueHandling.Ignore)]
        public AccessControl AccessControl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("request_limit_rules", NullValueHandling = NullValueHandling.Ignore)]
        public RequestLimitRulesEngine RequestLimitRules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("origin_request_url_rewrite", NullValueHandling = NullValueHandling.Ignore)]
        public OriginRequestUrlRewriteEngine OriginRequestUrlRewrite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cache_rule", NullValueHandling = NullValueHandling.Ignore)]
        public CacheRulesEngine CacheRule { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("request_url_rewrite", NullValueHandling = NullValueHandling.Ignore)]
        public RequestUrlRewriteEngine RequestUrlRewrite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("browser_cache_rule", NullValueHandling = NullValueHandling.Ignore)]
        public BrowserCacheRulesEngine BrowserCacheRule { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("error_code_cache", NullValueHandling = NullValueHandling.Ignore)]
        public ErrorCodeCacheEngine ErrorCodeCache { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Actions {\n");
            sb.Append("  flexibleOrigin: ").Append(FlexibleOrigin).Append("\n");
            sb.Append("  originRequestHeader: ").Append(OriginRequestHeader).Append("\n");
            sb.Append("  httpResponseHeader: ").Append(HttpResponseHeader).Append("\n");
            sb.Append("  accessControl: ").Append(AccessControl).Append("\n");
            sb.Append("  requestLimitRules: ").Append(RequestLimitRules).Append("\n");
            sb.Append("  originRequestUrlRewrite: ").Append(OriginRequestUrlRewrite).Append("\n");
            sb.Append("  cacheRule: ").Append(CacheRule).Append("\n");
            sb.Append("  requestUrlRewrite: ").Append(RequestUrlRewrite).Append("\n");
            sb.Append("  browserCacheRule: ").Append(BrowserCacheRule).Append("\n");
            sb.Append("  errorCodeCache: ").Append(ErrorCodeCache).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Actions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Actions input)
        {
            if (input == null) return false;
            if (this.FlexibleOrigin != input.FlexibleOrigin || (this.FlexibleOrigin != null && input.FlexibleOrigin != null && !this.FlexibleOrigin.SequenceEqual(input.FlexibleOrigin))) return false;
            if (this.OriginRequestHeader != input.OriginRequestHeader || (this.OriginRequestHeader != null && input.OriginRequestHeader != null && !this.OriginRequestHeader.SequenceEqual(input.OriginRequestHeader))) return false;
            if (this.HttpResponseHeader != input.HttpResponseHeader || (this.HttpResponseHeader != null && input.HttpResponseHeader != null && !this.HttpResponseHeader.SequenceEqual(input.HttpResponseHeader))) return false;
            if (this.AccessControl != input.AccessControl || (this.AccessControl != null && !this.AccessControl.Equals(input.AccessControl))) return false;
            if (this.RequestLimitRules != input.RequestLimitRules || (this.RequestLimitRules != null && !this.RequestLimitRules.Equals(input.RequestLimitRules))) return false;
            if (this.OriginRequestUrlRewrite != input.OriginRequestUrlRewrite || (this.OriginRequestUrlRewrite != null && !this.OriginRequestUrlRewrite.Equals(input.OriginRequestUrlRewrite))) return false;
            if (this.CacheRule != input.CacheRule || (this.CacheRule != null && !this.CacheRule.Equals(input.CacheRule))) return false;
            if (this.RequestUrlRewrite != input.RequestUrlRewrite || (this.RequestUrlRewrite != null && !this.RequestUrlRewrite.Equals(input.RequestUrlRewrite))) return false;
            if (this.BrowserCacheRule != input.BrowserCacheRule || (this.BrowserCacheRule != null && !this.BrowserCacheRule.Equals(input.BrowserCacheRule))) return false;
            if (this.ErrorCodeCache != input.ErrorCodeCache || (this.ErrorCodeCache != null && !this.ErrorCodeCache.Equals(input.ErrorCodeCache))) return false;

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
                if (this.FlexibleOrigin != null) hashCode = hashCode * 59 + this.FlexibleOrigin.GetHashCode();
                if (this.OriginRequestHeader != null) hashCode = hashCode * 59 + this.OriginRequestHeader.GetHashCode();
                if (this.HttpResponseHeader != null) hashCode = hashCode * 59 + this.HttpResponseHeader.GetHashCode();
                if (this.AccessControl != null) hashCode = hashCode * 59 + this.AccessControl.GetHashCode();
                if (this.RequestLimitRules != null) hashCode = hashCode * 59 + this.RequestLimitRules.GetHashCode();
                if (this.OriginRequestUrlRewrite != null) hashCode = hashCode * 59 + this.OriginRequestUrlRewrite.GetHashCode();
                if (this.CacheRule != null) hashCode = hashCode * 59 + this.CacheRule.GetHashCode();
                if (this.RequestUrlRewrite != null) hashCode = hashCode * 59 + this.RequestUrlRewrite.GetHashCode();
                if (this.BrowserCacheRule != null) hashCode = hashCode * 59 + this.BrowserCacheRule.GetHashCode();
                if (this.ErrorCodeCache != null) hashCode = hashCode * 59 + this.ErrorCodeCache.GetHashCode();
                return hashCode;
            }
        }
    }
}
