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
    public class CreateResetTracksReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("audio_file", NullValueHandling = NullValueHandling.Ignore)]
        public SubAudioFile AudioFile { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateResetTracksReq {\n");
            sb.Append("  audioFile: ").Append(AudioFile).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateResetTracksReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateResetTracksReq input)
        {
            if (input == null) return false;
            if (this.AudioFile != input.AudioFile || (this.AudioFile != null && !this.AudioFile.Equals(input.AudioFile))) return false;

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
                if (this.AudioFile != null) hashCode = hashCode * 59 + this.AudioFile.GetHashCode();
                return hashCode;
            }
        }
    }
}
