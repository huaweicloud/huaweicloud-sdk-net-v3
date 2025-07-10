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
    /// Response Object
    /// </summary>
    public class ShowAsyncTtsJobResponse : SdkResponse
    {

        /// <summary>
        /// 音频文件是否已生成完成。该标记为PROCESSING时，应该每隔3秒再次调用本接口获取音频文件(WAITING 等待中,PROCESSING 处理中,SUCCEED 成功,FAILED 失败)。当存在该字段时，会返回以下文件的下载链接。
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// 音频文件下载链接，有效期为1个小时。
        /// </summary>
        [JsonProperty("audio_file_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AudioFileUrl { get; set; }

        /// <summary>
        /// 音频信息文件下载链接，有效期为1个小时。
        /// </summary>
        [JsonProperty("audio_info_file_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AudioInfoFileUrl { get; set; }

        /// <summary>
        /// 字幕文件下载链接，有效期为1个小时。
        /// </summary>
        [JsonProperty("audio_srt_file_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AudioSrtFileUrl { get; set; }

        /// <summary>
        /// 动作信息文件下载链接，有效期为1个小时。
        /// </summary>
        [JsonProperty("audio_action_file_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AudioActionFileUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAsyncTtsJobResponse {\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  audioFileUrl: ").Append(AudioFileUrl).Append("\n");
            sb.Append("  audioInfoFileUrl: ").Append(AudioInfoFileUrl).Append("\n");
            sb.Append("  audioSrtFileUrl: ").Append(AudioSrtFileUrl).Append("\n");
            sb.Append("  audioActionFileUrl: ").Append(AudioActionFileUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAsyncTtsJobResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAsyncTtsJobResponse input)
        {
            if (input == null) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.AudioFileUrl != input.AudioFileUrl || (this.AudioFileUrl != null && !this.AudioFileUrl.Equals(input.AudioFileUrl))) return false;
            if (this.AudioInfoFileUrl != input.AudioInfoFileUrl || (this.AudioInfoFileUrl != null && !this.AudioInfoFileUrl.Equals(input.AudioInfoFileUrl))) return false;
            if (this.AudioSrtFileUrl != input.AudioSrtFileUrl || (this.AudioSrtFileUrl != null && !this.AudioSrtFileUrl.Equals(input.AudioSrtFileUrl))) return false;
            if (this.AudioActionFileUrl != input.AudioActionFileUrl || (this.AudioActionFileUrl != null && !this.AudioActionFileUrl.Equals(input.AudioActionFileUrl))) return false;

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
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.AudioFileUrl != null) hashCode = hashCode * 59 + this.AudioFileUrl.GetHashCode();
                if (this.AudioInfoFileUrl != null) hashCode = hashCode * 59 + this.AudioInfoFileUrl.GetHashCode();
                if (this.AudioSrtFileUrl != null) hashCode = hashCode * 59 + this.AudioSrtFileUrl.GetHashCode();
                if (this.AudioActionFileUrl != null) hashCode = hashCode * 59 + this.AudioActionFileUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
