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
    /// 源站配置。
    /// </summary>
    public class SourcesConfig 
    {

        /// <summary>
        /// 源站类型， - ipaddr：源站IP； - domain：源站域名； - obs_bucket：OBS桶域名； - third_bucket：第三方桶。
        /// </summary>
        [JsonProperty("origin_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginType { get; set; }

        /// <summary>
        /// 源站IP或者域名。
        /// </summary>
        [JsonProperty("origin_addr", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginAddr { get; set; }

        /// <summary>
        /// 源站优先级，70：主，30：备。
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// 权重，取值范围1-100。
        /// </summary>
        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public int? Weight { get; set; }

        /// <summary>
        /// 是否开启OBS静态网站托管，源站类型为obs_bucket时传递，off：关闭，on：开启。
        /// </summary>
        [JsonProperty("obs_web_hosting_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsWebHostingStatus { get; set; }

        /// <summary>
        /// HTTP端口，默认80,端口取值取值范围1-65535。
        /// </summary>
        [JsonProperty("http_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? HttpPort { get; set; }

        /// <summary>
        /// HTTPS端口，默认443,端口取值取值范围1-65535。
        /// </summary>
        [JsonProperty("https_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? HttpsPort { get; set; }

        /// <summary>
        /// 回源HOST，默认加速域名。
        /// </summary>
        [JsonProperty("host_name", NullValueHandling = NullValueHandling.Ignore)]
        public string HostName { get; set; }

        /// <summary>
        /// OBS桶源站类型： - “private” 私有桶； - “public” 公有桶，默认为公有桶。
        /// </summary>
        [JsonProperty("obs_bucket_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsBucketType { get; set; }

        /// <summary>
        /// 第三方对象存储访问密钥。  &gt; 源站类型为第三方桶时必填
        /// </summary>
        [JsonProperty("bucket_access_key", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketAccessKey { get; set; }

        /// <summary>
        /// 第三方对象存储密钥。  &gt; 源站类型为第三方桶时必填
        /// </summary>
        [JsonProperty("bucket_secret_key", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketSecretKey { get; set; }

        /// <summary>
        /// 第三方对象存储区域。  &gt; 源站类型为第三方桶时必填
        /// </summary>
        [JsonProperty("bucket_region", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketRegion { get; set; }

        /// <summary>
        /// 第三方对象存储名称。  &gt; 源站类型为第三方桶时必填
        /// </summary>
        [JsonProperty("bucket_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SourcesConfig {\n");
            sb.Append("  originType: ").Append(OriginType).Append("\n");
            sb.Append("  originAddr: ").Append(OriginAddr).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  weight: ").Append(Weight).Append("\n");
            sb.Append("  obsWebHostingStatus: ").Append(ObsWebHostingStatus).Append("\n");
            sb.Append("  httpPort: ").Append(HttpPort).Append("\n");
            sb.Append("  httpsPort: ").Append(HttpsPort).Append("\n");
            sb.Append("  hostName: ").Append(HostName).Append("\n");
            sb.Append("  obsBucketType: ").Append(ObsBucketType).Append("\n");
            sb.Append("  bucketAccessKey: ").Append(BucketAccessKey).Append("\n");
            sb.Append("  bucketSecretKey: ").Append(BucketSecretKey).Append("\n");
            sb.Append("  bucketRegion: ").Append(BucketRegion).Append("\n");
            sb.Append("  bucketName: ").Append(BucketName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SourcesConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SourcesConfig input)
        {
            if (input == null) return false;
            if (this.OriginType != input.OriginType || (this.OriginType != null && !this.OriginType.Equals(input.OriginType))) return false;
            if (this.OriginAddr != input.OriginAddr || (this.OriginAddr != null && !this.OriginAddr.Equals(input.OriginAddr))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.Weight != input.Weight || (this.Weight != null && !this.Weight.Equals(input.Weight))) return false;
            if (this.ObsWebHostingStatus != input.ObsWebHostingStatus || (this.ObsWebHostingStatus != null && !this.ObsWebHostingStatus.Equals(input.ObsWebHostingStatus))) return false;
            if (this.HttpPort != input.HttpPort || (this.HttpPort != null && !this.HttpPort.Equals(input.HttpPort))) return false;
            if (this.HttpsPort != input.HttpsPort || (this.HttpsPort != null && !this.HttpsPort.Equals(input.HttpsPort))) return false;
            if (this.HostName != input.HostName || (this.HostName != null && !this.HostName.Equals(input.HostName))) return false;
            if (this.ObsBucketType != input.ObsBucketType || (this.ObsBucketType != null && !this.ObsBucketType.Equals(input.ObsBucketType))) return false;
            if (this.BucketAccessKey != input.BucketAccessKey || (this.BucketAccessKey != null && !this.BucketAccessKey.Equals(input.BucketAccessKey))) return false;
            if (this.BucketSecretKey != input.BucketSecretKey || (this.BucketSecretKey != null && !this.BucketSecretKey.Equals(input.BucketSecretKey))) return false;
            if (this.BucketRegion != input.BucketRegion || (this.BucketRegion != null && !this.BucketRegion.Equals(input.BucketRegion))) return false;
            if (this.BucketName != input.BucketName || (this.BucketName != null && !this.BucketName.Equals(input.BucketName))) return false;

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
                if (this.OriginType != null) hashCode = hashCode * 59 + this.OriginType.GetHashCode();
                if (this.OriginAddr != null) hashCode = hashCode * 59 + this.OriginAddr.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.Weight != null) hashCode = hashCode * 59 + this.Weight.GetHashCode();
                if (this.ObsWebHostingStatus != null) hashCode = hashCode * 59 + this.ObsWebHostingStatus.GetHashCode();
                if (this.HttpPort != null) hashCode = hashCode * 59 + this.HttpPort.GetHashCode();
                if (this.HttpsPort != null) hashCode = hashCode * 59 + this.HttpsPort.GetHashCode();
                if (this.HostName != null) hashCode = hashCode * 59 + this.HostName.GetHashCode();
                if (this.ObsBucketType != null) hashCode = hashCode * 59 + this.ObsBucketType.GetHashCode();
                if (this.BucketAccessKey != null) hashCode = hashCode * 59 + this.BucketAccessKey.GetHashCode();
                if (this.BucketSecretKey != null) hashCode = hashCode * 59 + this.BucketSecretKey.GetHashCode();
                if (this.BucketRegion != null) hashCode = hashCode * 59 + this.BucketRegion.GetHashCode();
                if (this.BucketName != null) hashCode = hashCode * 59 + this.BucketName.GetHashCode();
                return hashCode;
            }
        }
    }
}
