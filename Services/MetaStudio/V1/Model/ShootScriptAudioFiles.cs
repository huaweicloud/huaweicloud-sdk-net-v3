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
    /// 用于语音驱动的音频文件上传URL列表。
    /// </summary>
    public class ShootScriptAudioFiles 
    {

        /// <summary>
        /// 用于语音驱动的音频文件上传URL。
        /// </summary>
        [JsonProperty("audio_file_url", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShootScriptAudioFileItem> AudioFileUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShootScriptAudioFiles {\n");
            sb.Append("  audioFileUrl: ").Append(AudioFileUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShootScriptAudioFiles);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShootScriptAudioFiles input)
        {
            if (input == null) return false;
            if (this.AudioFileUrl != input.AudioFileUrl || (this.AudioFileUrl != null && input.AudioFileUrl != null && !this.AudioFileUrl.SequenceEqual(input.AudioFileUrl))) return false;

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
                if (this.AudioFileUrl != null) hashCode = hashCode * 59 + this.AudioFileUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
