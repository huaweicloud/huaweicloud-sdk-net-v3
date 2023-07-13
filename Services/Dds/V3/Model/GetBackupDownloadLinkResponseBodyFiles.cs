using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class GetBackupDownloadLinkResponseBodyFiles 
    {

        /// <summary>
        /// 文件名。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 文件大小，单位为KB。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public long? Size { get; set; }

        /// <summary>
        /// 文件下载链接。
        /// </summary>
        [JsonProperty("download_link", NullValueHandling = NullValueHandling.Ignore)]
        public string DownloadLink { get; set; }

        /// <summary>
        /// 下载链接过期时间，格式为“yyyy-mm-ddThh:mm:ssZ”。其中，T指某个时间的开始，Z指时区偏移量，例如UTC时间偏移显示为+0000。
        /// </summary>
        [JsonProperty("link_expired_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LinkExpiredTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetBackupDownloadLinkResponseBodyFiles {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  downloadLink: ").Append(DownloadLink).Append("\n");
            sb.Append("  linkExpiredTime: ").Append(LinkExpiredTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetBackupDownloadLinkResponseBodyFiles);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetBackupDownloadLinkResponseBodyFiles input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.DownloadLink == input.DownloadLink ||
                    (this.DownloadLink != null &&
                    this.DownloadLink.Equals(input.DownloadLink))
                ) && 
                (
                    this.LinkExpiredTime == input.LinkExpiredTime ||
                    (this.LinkExpiredTime != null &&
                    this.LinkExpiredTime.Equals(input.LinkExpiredTime))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.DownloadLink != null)
                    hashCode = hashCode * 59 + this.DownloadLink.GetHashCode();
                if (this.LinkExpiredTime != null)
                    hashCode = hashCode * 59 + this.LinkExpiredTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
