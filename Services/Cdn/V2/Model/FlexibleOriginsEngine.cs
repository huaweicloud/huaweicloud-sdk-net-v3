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
    /// **参数解释：** 高级回源，实现根据不同的资源类型或路径回源到不同源站 **约束限制：** 最多配置20条
    /// </summary>
    public class FlexibleOriginsEngine 
    {

        /// <summary>
        /// **参数解释：** 源站类型 **约束限制：** 不涉及 **取值范围：** - ipaddr: 源站IP - domain: 源站域名 - obs_bucket: OBS桶域名 - third_bucket: 第三方桶域名 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("sources_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SourcesType { get; set; }

        /// <summary>
        /// **参数解释：** 源站IP或者域名 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("ip_or_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string IpOrDomain { get; set; }

        /// <summary>
        /// **参数解释：** OBS桶类型 **约束限制：** 源站类型是“OBS桶域名”时需要传该参数 **取值范围：** - private: 私有桶 - public: 公有桶 **默认取值：** public: 公有桶
        /// </summary>
        [JsonProperty("obs_bucket_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsBucketType { get; set; }

        /// <summary>
        /// **参数解释：** 第三方对象存储访问密钥 **约束限制：** 源站类型为第三方桶时必填 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("bucket_access_key", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketAccessKey { get; set; }

        /// <summary>
        /// **参数解释：** 第三方对象存储密钥 **约束限制：** 源站类型为第三方桶时必填 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("bucket_secret_key", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketSecretKey { get; set; }

        /// <summary>
        /// **参数解释：** 第三方对象存储区域 **约束限制：** 源站类型为第三方桶时必填 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("bucket_region", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketRegion { get; set; }

        /// <summary>
        /// **参数解释：** 第三方对象存储名称 **约束限制：** 源站类型为第三方桶时必填 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("bucket_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketName { get; set; }

        /// <summary>
        /// **参数解释：** 回源HOST **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 加速域名
        /// </summary>
        [JsonProperty("host_name", NullValueHandling = NullValueHandling.Ignore)]
        public string HostName { get; set; }

        /// <summary>
        /// **参数解释：** 指定CDN回源时的请求协议 **约束限制：** 不涉及 **取值范围：** - follow: 协议跟随 - http: http协议 - https: https协议 **默认取值：** http: http协议
        /// </summary>
        [JsonProperty("origin_protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginProtocol { get; set; }

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
        /// **参数解释：** 优先级，值越大优先级越高 **约束限制：** 不涉及 **取值范围：** 1-100 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// **参数解释：** 权重，值越大回源到该源站的次数越多。多个优先级相同的源站，由权重决定回源到各个源站的比例 **约束限制：** 不涉及 **取值范围：** 1-100 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public int? Weight { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlexibleOriginsEngine {\n");
            sb.Append("  sourcesType: ").Append(SourcesType).Append("\n");
            sb.Append("  ipOrDomain: ").Append(IpOrDomain).Append("\n");
            sb.Append("  obsBucketType: ").Append(ObsBucketType).Append("\n");
            sb.Append("  bucketAccessKey: ").Append(BucketAccessKey).Append("\n");
            sb.Append("  bucketSecretKey: ").Append(BucketSecretKey).Append("\n");
            sb.Append("  bucketRegion: ").Append(BucketRegion).Append("\n");
            sb.Append("  bucketName: ").Append(BucketName).Append("\n");
            sb.Append("  hostName: ").Append(HostName).Append("\n");
            sb.Append("  originProtocol: ").Append(OriginProtocol).Append("\n");
            sb.Append("  httpPort: ").Append(HttpPort).Append("\n");
            sb.Append("  httpsPort: ").Append(HttpsPort).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  weight: ").Append(Weight).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FlexibleOriginsEngine);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FlexibleOriginsEngine input)
        {
            if (input == null) return false;
            if (this.SourcesType != input.SourcesType || (this.SourcesType != null && !this.SourcesType.Equals(input.SourcesType))) return false;
            if (this.IpOrDomain != input.IpOrDomain || (this.IpOrDomain != null && !this.IpOrDomain.Equals(input.IpOrDomain))) return false;
            if (this.ObsBucketType != input.ObsBucketType || (this.ObsBucketType != null && !this.ObsBucketType.Equals(input.ObsBucketType))) return false;
            if (this.BucketAccessKey != input.BucketAccessKey || (this.BucketAccessKey != null && !this.BucketAccessKey.Equals(input.BucketAccessKey))) return false;
            if (this.BucketSecretKey != input.BucketSecretKey || (this.BucketSecretKey != null && !this.BucketSecretKey.Equals(input.BucketSecretKey))) return false;
            if (this.BucketRegion != input.BucketRegion || (this.BucketRegion != null && !this.BucketRegion.Equals(input.BucketRegion))) return false;
            if (this.BucketName != input.BucketName || (this.BucketName != null && !this.BucketName.Equals(input.BucketName))) return false;
            if (this.HostName != input.HostName || (this.HostName != null && !this.HostName.Equals(input.HostName))) return false;
            if (this.OriginProtocol != input.OriginProtocol || (this.OriginProtocol != null && !this.OriginProtocol.Equals(input.OriginProtocol))) return false;
            if (this.HttpPort != input.HttpPort || (this.HttpPort != null && !this.HttpPort.Equals(input.HttpPort))) return false;
            if (this.HttpsPort != input.HttpsPort || (this.HttpsPort != null && !this.HttpsPort.Equals(input.HttpsPort))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.Weight != input.Weight || (this.Weight != null && !this.Weight.Equals(input.Weight))) return false;

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
                if (this.BucketAccessKey != null) hashCode = hashCode * 59 + this.BucketAccessKey.GetHashCode();
                if (this.BucketSecretKey != null) hashCode = hashCode * 59 + this.BucketSecretKey.GetHashCode();
                if (this.BucketRegion != null) hashCode = hashCode * 59 + this.BucketRegion.GetHashCode();
                if (this.BucketName != null) hashCode = hashCode * 59 + this.BucketName.GetHashCode();
                if (this.HostName != null) hashCode = hashCode * 59 + this.HostName.GetHashCode();
                if (this.OriginProtocol != null) hashCode = hashCode * 59 + this.OriginProtocol.GetHashCode();
                if (this.HttpPort != null) hashCode = hashCode * 59 + this.HttpPort.GetHashCode();
                if (this.HttpsPort != null) hashCode = hashCode * 59 + this.HttpsPort.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.Weight != null) hashCode = hashCode * 59 + this.Weight.GetHashCode();
                return hashCode;
            }
        }
    }
}
