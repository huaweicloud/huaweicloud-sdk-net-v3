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
    /// 源站配置。
    /// </summary>
    public class SourcesDomainConfig 
    {

        /// <summary>
        /// 源站类型。 - ipaddr：源站IP； - domain：源站域名； - obs_bucket：OBS桶域名； - third_bucket：第三方桶。
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
        /// OBS桶类型。   - private: 私有桶（除桶ACL授权外的其他用户无桶的访问权限）。   - public: 公有桶（任何用户都可以对桶内对象进行读操作）。
        /// </summary>
        [JsonProperty("obs_bucket_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsBucketType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SourcesDomainConfig {\n");
            sb.Append("  originType: ").Append(OriginType).Append("\n");
            sb.Append("  originAddr: ").Append(OriginAddr).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  obsWebHostingStatus: ").Append(ObsWebHostingStatus).Append("\n");
            sb.Append("  httpPort: ").Append(HttpPort).Append("\n");
            sb.Append("  httpsPort: ").Append(HttpsPort).Append("\n");
            sb.Append("  hostName: ").Append(HostName).Append("\n");
            sb.Append("  obsBucketType: ").Append(ObsBucketType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SourcesDomainConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SourcesDomainConfig input)
        {
            if (input == null) return false;
            if (this.OriginType != input.OriginType || (this.OriginType != null && !this.OriginType.Equals(input.OriginType))) return false;
            if (this.OriginAddr != input.OriginAddr || (this.OriginAddr != null && !this.OriginAddr.Equals(input.OriginAddr))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.ObsWebHostingStatus != input.ObsWebHostingStatus || (this.ObsWebHostingStatus != null && !this.ObsWebHostingStatus.Equals(input.ObsWebHostingStatus))) return false;
            if (this.HttpPort != input.HttpPort || (this.HttpPort != null && !this.HttpPort.Equals(input.HttpPort))) return false;
            if (this.HttpsPort != input.HttpsPort || (this.HttpsPort != null && !this.HttpsPort.Equals(input.HttpsPort))) return false;
            if (this.HostName != input.HostName || (this.HostName != null && !this.HostName.Equals(input.HostName))) return false;
            if (this.ObsBucketType != input.ObsBucketType || (this.ObsBucketType != null && !this.ObsBucketType.Equals(input.ObsBucketType))) return false;

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
                if (this.ObsWebHostingStatus != null) hashCode = hashCode * 59 + this.ObsWebHostingStatus.GetHashCode();
                if (this.HttpPort != null) hashCode = hashCode * 59 + this.HttpPort.GetHashCode();
                if (this.HttpsPort != null) hashCode = hashCode * 59 + this.HttpsPort.GetHashCode();
                if (this.HostName != null) hashCode = hashCode * 59 + this.HostName.GetHashCode();
                if (this.ObsBucketType != null) hashCode = hashCode * 59 + this.ObsBucketType.GetHashCode();
                return hashCode;
            }
        }
    }
}
