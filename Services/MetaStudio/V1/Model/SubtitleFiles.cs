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
    public class SubtitleFiles 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("text_subtitle_file", NullValueHandling = NullValueHandling.Ignore)]
        public SubtitleFileInfo TextSubtitleFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("audio_subtitle_file", NullValueHandling = NullValueHandling.Ignore)]
        public SubtitleFileInfo AudioSubtitleFile { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubtitleFiles {\n");
            sb.Append("  textSubtitleFile: ").Append(TextSubtitleFile).Append("\n");
            sb.Append("  audioSubtitleFile: ").Append(AudioSubtitleFile).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubtitleFiles);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubtitleFiles input)
        {
            if (input == null) return false;
            if (this.TextSubtitleFile != input.TextSubtitleFile || (this.TextSubtitleFile != null && !this.TextSubtitleFile.Equals(input.TextSubtitleFile))) return false;
            if (this.AudioSubtitleFile != input.AudioSubtitleFile || (this.AudioSubtitleFile != null && !this.AudioSubtitleFile.Equals(input.AudioSubtitleFile))) return false;

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
                if (this.TextSubtitleFile != null) hashCode = hashCode * 59 + this.TextSubtitleFile.GetHashCode();
                if (this.AudioSubtitleFile != null) hashCode = hashCode * 59 + this.AudioSubtitleFile.GetHashCode();
                return hashCode;
            }
        }
    }
}
