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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Configs {\n");
            sb.Append("  originRequestHeader: ").Append(OriginRequestHeader).Append("\n");
            sb.Append("  httpResponseHeader: ").Append(HttpResponseHeader).Append("\n");
            sb.Append("  urlAuth: ").Append(UrlAuth).Append("\n");
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
                return hashCode;
            }
        }
    }
}
