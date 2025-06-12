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
    /// 修改欢迎词请求。
    /// </summary>
    public class UpdateWelcomeSpeechReq 
    {

        /// <summary>
        /// 欢迎词。
        /// </summary>
        [JsonProperty("welcome_speech", NullValueHandling = NullValueHandling.Ignore)]
        public string WelcomeSpeech { get; set; }

        /// <summary>
        /// 欢迎词功能开关。
        /// </summary>
        [JsonProperty("enable_welcome_speech", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableWelcomeSpeech { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateWelcomeSpeechReq {\n");
            sb.Append("  welcomeSpeech: ").Append(WelcomeSpeech).Append("\n");
            sb.Append("  enableWelcomeSpeech: ").Append(EnableWelcomeSpeech).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateWelcomeSpeechReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateWelcomeSpeechReq input)
        {
            if (input == null) return false;
            if (this.WelcomeSpeech != input.WelcomeSpeech || (this.WelcomeSpeech != null && !this.WelcomeSpeech.Equals(input.WelcomeSpeech))) return false;
            if (this.EnableWelcomeSpeech != input.EnableWelcomeSpeech || (this.EnableWelcomeSpeech != null && !this.EnableWelcomeSpeech.Equals(input.EnableWelcomeSpeech))) return false;

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
                if (this.WelcomeSpeech != null) hashCode = hashCode * 59 + this.WelcomeSpeech.GetHashCode();
                if (this.EnableWelcomeSpeech != null) hashCode = hashCode * 59 + this.EnableWelcomeSpeech.GetHashCode();
                return hashCode;
            }
        }
    }
}
