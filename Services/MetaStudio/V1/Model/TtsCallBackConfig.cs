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
    public class TtsCallBackConfig 
    {

        /// <summary>
        /// 回调URL。 回调请求body为json格式，带参数如下： status: FINISHED或ERROR或者WAITING job_id: 任务id audio_file_download_url: 音频文件路径 subtitle_file_download_url: 字幕文件路径 audio_duration: 音频时长（秒）
        /// </summary>
        [JsonProperty("callback_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CallbackUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TtsCallBackConfig {\n");
            sb.Append("  callbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TtsCallBackConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TtsCallBackConfig input)
        {
            if (input == null) return false;
            if (this.CallbackUrl != input.CallbackUrl || (this.CallbackUrl != null && !this.CallbackUrl.Equals(input.CallbackUrl))) return false;

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
                if (this.CallbackUrl != null) hashCode = hashCode * 59 + this.CallbackUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
