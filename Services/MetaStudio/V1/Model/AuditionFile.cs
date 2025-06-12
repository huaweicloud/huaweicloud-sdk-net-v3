using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AuditionFile 
    {

        /// <summary>
        /// 试听文件下载链接，有效期为1个小时。
        /// </summary>
        [JsonProperty("download_url", NullValueHandling = NullValueHandling.Ignore)]
        public string DownloadUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditionFile {\n");
            sb.Append("  downloadUrl: ").Append(DownloadUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuditionFile);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AuditionFile input)
        {
            if (input == null) return false;
            if (this.DownloadUrl != input.DownloadUrl || (this.DownloadUrl != null && !this.DownloadUrl.Equals(input.DownloadUrl))) return false;

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
                return hashCode;
            }
        }
    }
}
