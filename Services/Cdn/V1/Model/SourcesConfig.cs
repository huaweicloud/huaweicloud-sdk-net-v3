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
        /// 源站IP或者域名。
        /// </summary>
        [JsonProperty("origin_addr", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginAddr { get; set; }

        /// <summary>
        /// 源站类型（\&quot;ipaddr\&quot;：\&quot;IP源站\&quot;，\&quot;domain\&quot;：\&quot;域名源站\&quot;，\&quot;obs_bucket\&quot;：\&quot;OBS Bucket源站\&quot;）。
        /// </summary>
        [JsonProperty("origin_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginType { get; set; }

        /// <summary>
        /// 源站优先级（70：主，30：备）。
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// 是否开启Obs静态网站托管，源站类型为obs_bucket时传递(off：关闭，on：开启)。
        /// </summary>
        [JsonProperty("obs_web_hosting_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsWebHostingStatus { get; set; }

        /// <summary>
        /// HTTP端口，默认80。
        /// </summary>
        [JsonProperty("http_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? HttpPort { get; set; }

        /// <summary>
        /// HTTPS端口，默认443。
        /// </summary>
        [JsonProperty("https_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? HttpsPort { get; set; }

        /// <summary>
        /// 回源HOST，默认加速域名。
        /// </summary>
        [JsonProperty("host_name", NullValueHandling = NullValueHandling.Ignore)]
        public string HostName { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SourcesConfig {\n");
            sb.Append("  originAddr: ").Append(OriginAddr).Append("\n");
            sb.Append("  originType: ").Append(OriginType).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  obsWebHostingStatus: ").Append(ObsWebHostingStatus).Append("\n");
            sb.Append("  httpPort: ").Append(HttpPort).Append("\n");
            sb.Append("  httpsPort: ").Append(HttpsPort).Append("\n");
            sb.Append("  hostName: ").Append(HostName).Append("\n");
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
            if (input == null)
                return false;

            return 
                (
                    this.OriginAddr == input.OriginAddr ||
                    (this.OriginAddr != null &&
                    this.OriginAddr.Equals(input.OriginAddr))
                ) && 
                (
                    this.OriginType == input.OriginType ||
                    (this.OriginType != null &&
                    this.OriginType.Equals(input.OriginType))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.ObsWebHostingStatus == input.ObsWebHostingStatus ||
                    (this.ObsWebHostingStatus != null &&
                    this.ObsWebHostingStatus.Equals(input.ObsWebHostingStatus))
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
                ) && 
                (
                    this.HostName == input.HostName ||
                    (this.HostName != null &&
                    this.HostName.Equals(input.HostName))
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
                if (this.OriginAddr != null)
                    hashCode = hashCode * 59 + this.OriginAddr.GetHashCode();
                if (this.OriginType != null)
                    hashCode = hashCode * 59 + this.OriginType.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.ObsWebHostingStatus != null)
                    hashCode = hashCode * 59 + this.ObsWebHostingStatus.GetHashCode();
                if (this.HttpPort != null)
                    hashCode = hashCode * 59 + this.HttpPort.GetHashCode();
                if (this.HttpsPort != null)
                    hashCode = hashCode * 59 + this.HttpsPort.GetHashCode();
                if (this.HostName != null)
                    hashCode = hashCode * 59 + this.HostName.GetHashCode();
                return hashCode;
            }
        }
    }
}
