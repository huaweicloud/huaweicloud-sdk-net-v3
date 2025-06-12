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
    public class PreviewInfo 
    {

        /// <summary>
        /// 文本内容hash值
        /// </summary>
        [JsonProperty("text_sha256", NullValueHandling = NullValueHandling.Ignore)]
        public string TextSha256 { get; set; }

        /// <summary>
        /// 文本对应音频文件下载链接
        /// </summary>
        [JsonProperty("audio_file_download_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AudioFileDownloadUrl { get; set; }

        /// <summary>
        /// 动作编排列表文件下载链接
        /// </summary>
        [JsonProperty("action_file_download_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionFileDownloadUrl { get; set; }

        /// <summary>
        /// 音频时长，单位秒。
        /// </summary>
        [JsonProperty("audio_duration", NullValueHandling = NullValueHandling.Ignore)]
        public float? AudioDuration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PreviewInfo {\n");
            sb.Append("  textSha256: ").Append(TextSha256).Append("\n");
            sb.Append("  audioFileDownloadUrl: ").Append(AudioFileDownloadUrl).Append("\n");
            sb.Append("  actionFileDownloadUrl: ").Append(ActionFileDownloadUrl).Append("\n");
            sb.Append("  audioDuration: ").Append(AudioDuration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PreviewInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PreviewInfo input)
        {
            if (input == null) return false;
            if (this.TextSha256 != input.TextSha256 || (this.TextSha256 != null && !this.TextSha256.Equals(input.TextSha256))) return false;
            if (this.AudioFileDownloadUrl != input.AudioFileDownloadUrl || (this.AudioFileDownloadUrl != null && !this.AudioFileDownloadUrl.Equals(input.AudioFileDownloadUrl))) return false;
            if (this.ActionFileDownloadUrl != input.ActionFileDownloadUrl || (this.ActionFileDownloadUrl != null && !this.ActionFileDownloadUrl.Equals(input.ActionFileDownloadUrl))) return false;
            if (this.AudioDuration != input.AudioDuration || (this.AudioDuration != null && !this.AudioDuration.Equals(input.AudioDuration))) return false;

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
                if (this.TextSha256 != null) hashCode = hashCode * 59 + this.TextSha256.GetHashCode();
                if (this.AudioFileDownloadUrl != null) hashCode = hashCode * 59 + this.AudioFileDownloadUrl.GetHashCode();
                if (this.ActionFileDownloadUrl != null) hashCode = hashCode * 59 + this.ActionFileDownloadUrl.GetHashCode();
                if (this.AudioDuration != null) hashCode = hashCode * 59 + this.AudioDuration.GetHashCode();
                return hashCode;
            }
        }
    }
}
