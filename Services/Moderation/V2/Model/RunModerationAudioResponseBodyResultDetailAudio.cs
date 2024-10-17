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
    /// 返回的音频审核结果列表，porn为涉黄场景审核结果； 当前仅支持porn场景。 
    /// </summary>
    public class RunModerationAudioResponseBodyResultDetailAudio 
    {

        /// <summary>
        /// 涉黄场景审核结果
        /// </summary>
        [JsonProperty("porn", NullValueHandling = NullValueHandling.Ignore)]
        public List<PornModerationResultDetail> Porn { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RunModerationAudioResponseBodyResultDetailAudio {\n");
            sb.Append("  porn: ").Append(Porn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RunModerationAudioResponseBodyResultDetailAudio);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RunModerationAudioResponseBodyResultDetailAudio input)
        {
            if (input == null) return false;
            if (this.Porn != input.Porn || (this.Porn != null && input.Porn != null && !this.Porn.SequenceEqual(input.Porn))) return false;

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
                if (this.Porn != null) hashCode = hashCode * 59 + this.Porn.GetHashCode();
                return hashCode;
            }
        }
    }
}
