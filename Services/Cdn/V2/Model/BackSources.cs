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
    /// **参数解释：** 高级回源信息源站配置 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
    /// </summary>
    public class BackSources 
    {

        /// <summary>
        /// **参数解释：** 源站类型 **约束限制：** 不涉及 **取值范围：** - ipaddr: 源站IP - domain: 源站域名 - obs_bucket: OBS桶域名  **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("sources_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SourcesType { get; set; }

        /// <summary>
        /// **参数解释：** 源站IP或者域名 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("ip_or_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string IpOrDomain { get; set; }

        /// <summary>
        /// **参数解释：** OBS桶类型 **约束限制：** 不涉及 **取值范围：** - private: 私有桶 - public: 公有桶  **默认取值：** public: 公有桶
        /// </summary>
        [JsonProperty("obs_bucket_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsBucketType { get; set; }

        /// <summary>
        /// **参数解释：** HTTP端口 **约束限制：** 不涉及 **取值范围：** 1-65535 **默认取值：** 80
        /// </summary>
        [JsonProperty("http_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? HttpPort { get; set; }

        /// <summary>
        /// **参数解释：** HTTPS端口 **约束限制：** 不涉及 **取值范围：** 1-65535 **默认取值：** 443
        /// </summary>
        [JsonProperty("https_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? HttpsPort { get; set; }

        /// <summary>
        /// **参数解释：** 指定CDN回源时的请求协议 **约束限制：** 不涉及 **取值范围：** - follow: 协议跟随 - http: http协议 - https: https协议  **默认取值：** http: http协议
        /// </summary>
        [JsonProperty("origin_protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginProtocol { get; set; }

        /// <summary>
        /// **参数解释：** 回源HOST **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 加速域名
        /// </summary>
        [JsonProperty("host_name", NullValueHandling = NullValueHandling.Ignore)]
        public string HostName { get; set; }



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
            sb.Append("  originProtocol: ").Append(OriginProtocol).Append("\n");
            sb.Append("  hostName: ").Append(HostName).Append("\n");
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
            if (input == null) return false;
            if (this.SourcesType != input.SourcesType || (this.SourcesType != null && !this.SourcesType.Equals(input.SourcesType))) return false;
            if (this.IpOrDomain != input.IpOrDomain || (this.IpOrDomain != null && !this.IpOrDomain.Equals(input.IpOrDomain))) return false;
            if (this.ObsBucketType != input.ObsBucketType || (this.ObsBucketType != null && !this.ObsBucketType.Equals(input.ObsBucketType))) return false;
            if (this.HttpPort != input.HttpPort || (this.HttpPort != null && !this.HttpPort.Equals(input.HttpPort))) return false;
            if (this.HttpsPort != input.HttpsPort || (this.HttpsPort != null && !this.HttpsPort.Equals(input.HttpsPort))) return false;
            if (this.OriginProtocol != input.OriginProtocol || (this.OriginProtocol != null && !this.OriginProtocol.Equals(input.OriginProtocol))) return false;
            if (this.HostName != input.HostName || (this.HostName != null && !this.HostName.Equals(input.HostName))) return false;

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
                if (this.SourcesType != null) hashCode = hashCode * 59 + this.SourcesType.GetHashCode();
                if (this.IpOrDomain != null) hashCode = hashCode * 59 + this.IpOrDomain.GetHashCode();
                if (this.ObsBucketType != null) hashCode = hashCode * 59 + this.ObsBucketType.GetHashCode();
                if (this.HttpPort != null) hashCode = hashCode * 59 + this.HttpPort.GetHashCode();
                if (this.HttpsPort != null) hashCode = hashCode * 59 + this.HttpsPort.GetHashCode();
                if (this.OriginProtocol != null) hashCode = hashCode * 59 + this.OriginProtocol.GetHashCode();
                if (this.HostName != null) hashCode = hashCode * 59 + this.HostName.GetHashCode();
                return hashCode;
            }
        }
    }
}
