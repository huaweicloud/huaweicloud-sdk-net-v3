using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MultiAudio 
    {

        /// <summary>
        /// 音轨信息
        /// </summary>
        [JsonProperty("tracks_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<TracksInfo> TracksInfo { get; set; }

        /// <summary>
        /// 音频文件
        /// </summary>
        [JsonProperty("audio_files", NullValueHandling = NullValueHandling.Ignore)]
        public List<AudioFile> AudioFiles { get; set; }

        /// <summary>
        /// 默认语言
        /// </summary>
        [JsonProperty("default_language", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultLanguage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MultiAudio {\n");
            sb.Append("  tracksInfo: ").Append(TracksInfo).Append("\n");
            sb.Append("  audioFiles: ").Append(AudioFiles).Append("\n");
            sb.Append("  defaultLanguage: ").Append(DefaultLanguage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MultiAudio);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MultiAudio input)
        {
            if (input == null) return false;
            if (this.TracksInfo != input.TracksInfo || (this.TracksInfo != null && input.TracksInfo != null && !this.TracksInfo.SequenceEqual(input.TracksInfo))) return false;
            if (this.AudioFiles != input.AudioFiles || (this.AudioFiles != null && input.AudioFiles != null && !this.AudioFiles.SequenceEqual(input.AudioFiles))) return false;
            if (this.DefaultLanguage != input.DefaultLanguage || (this.DefaultLanguage != null && !this.DefaultLanguage.Equals(input.DefaultLanguage))) return false;

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
                if (this.TracksInfo != null) hashCode = hashCode * 59 + this.TracksInfo.GetHashCode();
                if (this.AudioFiles != null) hashCode = hashCode * 59 + this.AudioFiles.GetHashCode();
                if (this.DefaultLanguage != null) hashCode = hashCode * 59 + this.DefaultLanguage.GetHashCode();
                return hashCode;
            }
        }
    }
}
