using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Sis.V1.Model
{
    /// <summary>
    /// 注册声音响应。
    /// </summary>
    public class RegisterVoiceResponseBodyResult 
    {

        /// <summary>
        /// 注册声音的名称。
        /// </summary>
        [JsonProperty("voice_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VoiceName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegisterVoiceResponseBodyResult {\n");
            sb.Append("  voiceName: ").Append(VoiceName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RegisterVoiceResponseBodyResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RegisterVoiceResponseBodyResult input)
        {
            if (input == null) return false;
            if (this.VoiceName != input.VoiceName || (this.VoiceName != null && !this.VoiceName.Equals(input.VoiceName))) return false;

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
                if (this.VoiceName != null) hashCode = hashCode * 59 + this.VoiceName.GetHashCode();
                return hashCode;
            }
        }
    }
}
