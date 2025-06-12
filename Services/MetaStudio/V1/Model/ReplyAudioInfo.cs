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
    /// 回复音频信息
    /// </summary>
    public class ReplyAudioInfo 
    {

        /// <summary>
        /// 音频URL
        /// </summary>
        [JsonProperty("audio_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AudioUrl { get; set; }

        /// <summary>
        /// 音频名
        /// </summary>
        [JsonProperty("audio_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AudioName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReplyAudioInfo {\n");
            sb.Append("  audioUrl: ").Append(AudioUrl).Append("\n");
            sb.Append("  audioName: ").Append(AudioName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReplyAudioInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReplyAudioInfo input)
        {
            if (input == null) return false;
            if (this.AudioUrl != input.AudioUrl || (this.AudioUrl != null && !this.AudioUrl.Equals(input.AudioUrl))) return false;
            if (this.AudioName != input.AudioName || (this.AudioName != null && !this.AudioName.Equals(input.AudioName))) return false;

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
                if (this.AudioUrl != null) hashCode = hashCode * 59 + this.AudioUrl.GetHashCode();
                if (this.AudioName != null) hashCode = hashCode * 59 + this.AudioName.GetHashCode();
                return hashCode;
            }
        }
    }
}
