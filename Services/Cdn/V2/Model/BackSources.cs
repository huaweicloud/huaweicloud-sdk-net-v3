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
    /// 高级回源信息源站配置。
    /// </summary>
    public class BackSources 
    {

        /// <summary>
        /// 源站类型, ipaddr：源站IP，domain：源站域名，obs_bucket：OBS桶域名。
        /// </summary>
        [JsonProperty("sources_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SourcesType { get; set; }

        /// <summary>
        /// 源站IP或者域名。
        /// </summary>
        [JsonProperty("ip_or_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string IpOrDomain { get; set; }

        /// <summary>
        /// OBS桶类型： - “private”， 私有桶： - “public”，公有桶。
        /// </summary>
        [JsonProperty("obs_bucket_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsBucketType { get; set; }

        /// <summary>
        /// HTTP端口，取值范围：1-65535。
        /// </summary>
        [JsonProperty("http_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? HttpPort { get; set; }

        /// <summary>
        /// HTTPS端口，取值范围：1-65535。
        /// </summary>
        [JsonProperty("https_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? HttpsPort { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackSources {\n");
            sb.Append("  sourcesType: ").Append(SourcesType).Append("\n");
            sb.Append("  ipOrDomain: ").Append(IpOrDomain).Append("\n");
            sb.Append("  obsBucketType: ").Append(ObsBucketType).Append("\n");
            sb.Append("  httpPort: ").Append(HttpPort).Append("\n");
            sb.Append("  httpsPort: ").Append(HttpsPort).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackSources);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackSources input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourcesType == input.SourcesType ||
                    (this.SourcesType != null &&
                    this.SourcesType.Equals(input.SourcesType))
                ) && 
                (
                    this.IpOrDomain == input.IpOrDomain ||
                    (this.IpOrDomain != null &&
                    this.IpOrDomain.Equals(input.IpOrDomain))
                ) && 
                (
                    this.ObsBucketType == input.ObsBucketType ||
                    (this.ObsBucketType != null &&
                    this.ObsBucketType.Equals(input.ObsBucketType))
                ) && 
                (
                    this.HttpPort == input.HttpPort ||
                    (this.HttpPort != null &&
                    this.HttpPort.Equals(input.HttpPort))
                ) && 
                (
                    this.HttpsPort == input.HttpsPort ||
                    (this.HttpsPort != null &&
                    this.HttpsPort.Equals(input.HttpsPort))
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
                if (this.SourcesType != null)
                    hashCode = hashCode * 59 + this.SourcesType.GetHashCode();
                if (this.IpOrDomain != null)
                    hashCode = hashCode * 59 + this.IpOrDomain.GetHashCode();
                if (this.ObsBucketType != null)
                    hashCode = hashCode * 59 + this.ObsBucketType.GetHashCode();
                if (this.HttpPort != null)
                    hashCode = hashCode * 59 + this.HttpPort.GetHashCode();
                if (this.HttpsPort != null)
                    hashCode = hashCode * 59 + this.HttpsPort.GetHashCode();
                return hashCode;
            }
        }
    }
}
