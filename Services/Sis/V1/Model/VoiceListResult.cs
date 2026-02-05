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
    /// 注册成功的声音列表，调用失败时无此字段。
    /// </summary>
    public class VoiceListResult 
    {

        /// <summary>
        /// 声色列表
        /// </summary>
        [JsonProperty("voices", NullValueHandling = NullValueHandling.Ignore)]
        public List<VoiceListResultVoices> Voices { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VoiceListResult {\n");
            sb.Append("  voices: ").Append(Voices).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VoiceListResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VoiceListResult input)
        {
            if (input == null) return false;
            if (this.Voices != input.Voices || (this.Voices != null && input.Voices != null && !this.Voices.SequenceEqual(input.Voices))) return false;

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
                if (this.Voices != null) hashCode = hashCode * 59 + this.Voices.GetHashCode();
                return hashCode;
            }
        }
    }
}
