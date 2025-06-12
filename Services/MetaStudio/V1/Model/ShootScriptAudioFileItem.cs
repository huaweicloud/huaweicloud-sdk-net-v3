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
    public class ShootScriptAudioFileItem 
    {

        /// <summary>
        /// 剧本序号。
        /// </summary>
        [JsonProperty("sequence_no", NullValueHandling = NullValueHandling.Ignore)]
        public int? SequenceNo { get; set; }

        /// <summary>
        /// 语音驱动音频文件上传URL。创建和更新脚本时返回。单个文件最大100M。支持上传MP3/WAV/M4A文件。
        /// </summary>
        [JsonProperty("audio_file_upload_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AudioFileUploadUrl { get; set; }

        /// <summary>
        /// 语音驱动音频文件下载URL。查询脚本详情时返回。
        /// </summary>
        [JsonProperty("audio_file_download_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AudioFileDownloadUrl { get; set; }

        /// <summary>
        /// audio id
        /// </summary>
        [JsonProperty("audio_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? AudioId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShootScriptAudioFileItem {\n");
            sb.Append("  sequenceNo: ").Append(SequenceNo).Append("\n");
            sb.Append("  audioFileUploadUrl: ").Append(AudioFileUploadUrl).Append("\n");
            sb.Append("  audioFileDownloadUrl: ").Append(AudioFileDownloadUrl).Append("\n");
            sb.Append("  audioId: ").Append(AudioId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShootScriptAudioFileItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShootScriptAudioFileItem input)
        {
            if (input == null) return false;
            if (this.SequenceNo != input.SequenceNo || (this.SequenceNo != null && !this.SequenceNo.Equals(input.SequenceNo))) return false;
            if (this.AudioFileUploadUrl != input.AudioFileUploadUrl || (this.AudioFileUploadUrl != null && !this.AudioFileUploadUrl.Equals(input.AudioFileUploadUrl))) return false;
            if (this.AudioFileDownloadUrl != input.AudioFileDownloadUrl || (this.AudioFileDownloadUrl != null && !this.AudioFileDownloadUrl.Equals(input.AudioFileDownloadUrl))) return false;
            if (this.AudioId != input.AudioId || (this.AudioId != null && !this.AudioId.Equals(input.AudioId))) return false;

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
                if (this.SequenceNo != null) hashCode = hashCode * 59 + this.SequenceNo.GetHashCode();
                if (this.AudioFileUploadUrl != null) hashCode = hashCode * 59 + this.AudioFileUploadUrl.GetHashCode();
                if (this.AudioFileDownloadUrl != null) hashCode = hashCode * 59 + this.AudioFileDownloadUrl.GetHashCode();
                if (this.AudioId != null) hashCode = hashCode * 59 + this.AudioId.GetHashCode();
                return hashCode;
            }
        }
    }
}
