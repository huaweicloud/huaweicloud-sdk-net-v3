using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Moderation.V2.Model
{
    /// <summary>
    /// 审核结果列表，text为语音转文本后审核结果，audio为音频审核结果。 
    /// </summary>
    public class RunModerationAudioResponseBodyResultDetail 
    {

        /// <summary>
        /// 返回的语音转文本后审核结果详细信息： ● politics：涉政敏感词列表。 ● porn：涉黄敏感词列表。 ● ad：广告敏感词列表。 ● abuse：辱骂敏感词列表。 ● contraband：违禁品敏感词列表 
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public Object Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("audio", NullValueHandling = NullValueHandling.Ignore)]
        public RunModerationAudioResponseBodyResultDetailAudio Audio { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RunModerationAudioResponseBodyResultDetail {\n");
            sb.Append("  text: ").Append(Text).Append("\n");
            sb.Append("  audio: ").Append(Audio).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RunModerationAudioResponseBodyResultDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RunModerationAudioResponseBodyResultDetail input)
        {
            if (input == null) return false;
            if (this.Text != input.Text || (this.Text != null && !this.Text.Equals(input.Text))) return false;
            if (this.Audio != input.Audio || (this.Audio != null && !this.Audio.Equals(input.Audio))) return false;

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
                if (this.Text != null) hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.Audio != null) hashCode = hashCode * 59 + this.Audio.GetHashCode();
                return hashCode;
            }
        }
    }
}
