using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// 设置音频选择器
    /// </summary>
    public class AudioSelectorSettings 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("audio_language_selection", NullValueHandling = NullValueHandling.Ignore)]
        public AudioSelectorLangSelection AudioLanguageSelection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("audio_pid_selection", NullValueHandling = NullValueHandling.Ignore)]
        public AudioSelectorPidSelection AudioPidSelection { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AudioSelectorSettings {\n");
            sb.Append("  audioLanguageSelection: ").Append(AudioLanguageSelection).Append("\n");
            sb.Append("  audioPidSelection: ").Append(AudioPidSelection).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AudioSelectorSettings);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AudioSelectorSettings input)
        {
            if (input == null) return false;
            if (this.AudioLanguageSelection != input.AudioLanguageSelection || (this.AudioLanguageSelection != null && !this.AudioLanguageSelection.Equals(input.AudioLanguageSelection))) return false;
            if (this.AudioPidSelection != input.AudioPidSelection || (this.AudioPidSelection != null && !this.AudioPidSelection.Equals(input.AudioPidSelection))) return false;

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
                if (this.AudioLanguageSelection != null) hashCode = hashCode * 59 + this.AudioLanguageSelection.GetHashCode();
                if (this.AudioPidSelection != null) hashCode = hashCode * 59 + this.AudioPidSelection.GetHashCode();
                return hashCode;
            }
        }
    }
}
