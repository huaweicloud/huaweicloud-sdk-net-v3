using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 单个录制文件下载链接信息。
    /// </summary>
    public class RecordDownloadUrlDO 
    {

        /// <summary>
        /// 下载鉴权token，下载文件时，使用该token鉴权。（一小时内有效，使用后立即失效）。
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        /// <summary>
        /// 文件类型。 * Aux：辅流（会议中的共享画面；分辨率为720p） * Hd：高清（会议中的视频画面；分辨率和会议中视频画面的分辨率一致，1080p或者720p） * Sd：标清（会议中视频画面和共享画面的合成画面，视频画面是大画面，共享画面是小画面，共享画面布局在右下方；分辨率为4CIF） &gt; 单个MP4文件大小不超过1GB。 
        /// </summary>
        [JsonProperty("fileType", NullValueHandling = NullValueHandling.Ignore)]
        public string FileType { get; set; }

        /// <summary>
        /// 文件下载url，最大1000个字符。
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordDownloadUrlDO {\n");
            sb.Append("  token: ").Append(Token).Append("\n");
            sb.Append("  fileType: ").Append(FileType).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecordDownloadUrlDO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RecordDownloadUrlDO input)
        {
            if (input == null) return false;
            if (this.Token != input.Token || (this.Token != null && !this.Token.Equals(input.Token))) return false;
            if (this.FileType != input.FileType || (this.FileType != null && !this.FileType.Equals(input.FileType))) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;

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
                if (this.Token != null) hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.FileType != null) hashCode = hashCode * 59 + this.FileType.GetHashCode();
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                return hashCode;
            }
        }
    }
}
