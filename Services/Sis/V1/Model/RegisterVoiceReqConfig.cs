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
    /// 配置信息
    /// </summary>
    public class RegisterVoiceReqConfig 
    {

        /// <summary>
        /// 注册声音的名称，不能以数字、下划线开头。仅包含大、小写英文字母、数字和下划线，且长度不超过20个字符。一个project id下的声音名称不能重复。
        /// </summary>
        [JsonProperty("voice_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VoiceName { get; set; }

        /// <summary>
        /// data中语音数据的语种，取值chinese、english。 默认是chinese。
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegisterVoiceReqConfig {\n");
            sb.Append("  voiceName: ").Append(VoiceName).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RegisterVoiceReqConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RegisterVoiceReqConfig input)
        {
            if (input == null) return false;
            if (this.VoiceName != input.VoiceName || (this.VoiceName != null && !this.VoiceName.Equals(input.VoiceName))) return false;
            if (this.Language != input.Language || (this.Language != null && !this.Language.Equals(input.Language))) return false;

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
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
                return hashCode;
            }
        }
    }
}
