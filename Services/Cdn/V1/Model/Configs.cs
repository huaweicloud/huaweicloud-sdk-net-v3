using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// 配置项。
    /// </summary>
    public class Configs 
    {

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
        public UrlAuth UrlAuth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("https", NullValueHandling = NullValueHandling.Ignore)]
        public HttpPutBody Https { get; set; }

        /// <summary>
        /// 源站配置。
        /// </summary>
        [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
        public List<SourcesConfig> Sources { get; set; }

        /// <summary>
        /// 回源协议（follow：协议跟随回源，http：HTTP回源(默认)，https：https回源）。
        /// </summary>
        [JsonProperty("origin_protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginProtocol { get; set; }

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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Configs {\n");
            sb.Append("  originRequestHeader: ").Append(OriginRequestHeader).Append("\n");
            sb.Append("  httpResponseHeader: ").Append(HttpResponseHeader).Append("\n");
            sb.Append("  urlAuth: ").Append(UrlAuth).Append("\n");
            sb.Append("  https: ").Append(Https).Append("\n");
            sb.Append("  sources: ").Append(Sources).Append("\n");
            sb.Append("  originProtocol: ").Append(OriginProtocol).Append("\n");
            sb.Append("  forceRedirect: ").Append(ForceRedirect).Append("\n");
            sb.Append("  compress: ").Append(Compress).Append("\n");
            sb.Append("  cacheUrlParameterFilter: ").Append(CacheUrlParameterFilter).Append("\n");
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
            if (input == null)
                return false;

            return 
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
                if (this.ForceRedirect != null)
                    hashCode = hashCode * 59 + this.ForceRedirect.GetHashCode();
                if (this.Compress != null)
                    hashCode = hashCode * 59 + this.Compress.GetHashCode();
                if (this.CacheUrlParameterFilter != null)
                    hashCode = hashCode * 59 + this.CacheUrlParameterFilter.GetHashCode();
                return hashCode;
            }
        }
    }
}
