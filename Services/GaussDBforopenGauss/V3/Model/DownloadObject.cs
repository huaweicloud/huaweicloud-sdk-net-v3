using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DownloadObject 
    {

        /// <summary>
        /// 文件名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 文件大小。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Size { get; set; }

        /// <summary>
        /// 下载链接。
        /// </summary>
        [JsonProperty("download_link", NullValueHandling = NullValueHandling.Ignore)]
        public string DownloadLink { get; set; }

        /// <summary>
        /// 链接过期时间，格式为“yyyy-mm-ddThh:mm:ssZ”。 其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。
        /// </summary>
        [JsonProperty("link_expired_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LinkExpiredTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DownloadObject {\n");
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
            return this.Equals(input as DownloadObject);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DownloadObject input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.DownloadLink != input.DownloadLink || (this.DownloadLink != null && !this.DownloadLink.Equals(input.DownloadLink))) return false;
            if (this.LinkExpiredTime != input.LinkExpiredTime || (this.LinkExpiredTime != null && !this.LinkExpiredTime.Equals(input.LinkExpiredTime))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.DownloadLink != null) hashCode = hashCode * 59 + this.DownloadLink.GetHashCode();
                if (this.LinkExpiredTime != null) hashCode = hashCode * 59 + this.LinkExpiredTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
