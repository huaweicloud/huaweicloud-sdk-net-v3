using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateDownloadUrlResponse : SdkResponse
    {

        /// <summary>
        /// OBS 预签名下载地址。
        /// </summary>
        [JsonProperty("download_url", NullValueHandling = NullValueHandling.Ignore)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// OBS 桶名。
        /// </summary>
        [JsonProperty("obs_bucket", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsBucket { get; set; }

        /// <summary>
        /// OBS 对象键。
        /// </summary>
        [JsonProperty("obs_object_key", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsObjectKey { get; set; }

        /// <summary>
        /// 下载地址过期时间（ISO8601格式，UTC时区）。
        /// </summary>
        [JsonProperty("expires_at", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Request-Id", IsHeader = true)]
        [JsonProperty("X-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDownloadUrlResponse {\n");
            sb.Append("  downloadUrl: ").Append(DownloadUrl).Append("\n");
            sb.Append("  obsBucket: ").Append(ObsBucket).Append("\n");
            sb.Append("  obsObjectKey: ").Append(ObsObjectKey).Append("\n");
            sb.Append("  expiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDownloadUrlResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDownloadUrlResponse input)
        {
            if (input == null) return false;
            if (this.DownloadUrl != input.DownloadUrl || (this.DownloadUrl != null && !this.DownloadUrl.Equals(input.DownloadUrl))) return false;
            if (this.ObsBucket != input.ObsBucket || (this.ObsBucket != null && !this.ObsBucket.Equals(input.ObsBucket))) return false;
            if (this.ObsObjectKey != input.ObsObjectKey || (this.ObsObjectKey != null && !this.ObsObjectKey.Equals(input.ObsObjectKey))) return false;
            if (this.ExpiresAt != input.ExpiresAt || (this.ExpiresAt != null && !this.ExpiresAt.Equals(input.ExpiresAt))) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;

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
                if (this.DownloadUrl != null) hashCode = hashCode * 59 + this.DownloadUrl.GetHashCode();
                if (this.ObsBucket != null) hashCode = hashCode * 59 + this.ObsBucket.GetHashCode();
                if (this.ObsObjectKey != null) hashCode = hashCode * 59 + this.ObsObjectKey.GetHashCode();
                if (this.ExpiresAt != null) hashCode = hashCode * 59 + this.ExpiresAt.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
