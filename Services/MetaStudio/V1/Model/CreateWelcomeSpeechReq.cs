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
    /// 创建欢迎词请求。
    /// </summary>
    public class CreateWelcomeSpeechReq 
    {

        /// <summary>
        /// 应用ID。
        /// </summary>
        [JsonProperty("robot_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RobotId { get; set; }

        /// <summary>
        /// 欢迎词。
        /// </summary>
        [JsonProperty("welcome_speech", NullValueHandling = NullValueHandling.Ignore)]
        public string WelcomeSpeech { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public LanguageEnum Language { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateWelcomeSpeechReq {\n");
            sb.Append("  robotId: ").Append(RobotId).Append("\n");
            sb.Append("  welcomeSpeech: ").Append(WelcomeSpeech).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateWelcomeSpeechReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateWelcomeSpeechReq input)
        {
            if (input == null) return false;
            if (this.RobotId != input.RobotId || (this.RobotId != null && !this.RobotId.Equals(input.RobotId))) return false;
            if (this.WelcomeSpeech != input.WelcomeSpeech || (this.WelcomeSpeech != null && !this.WelcomeSpeech.Equals(input.WelcomeSpeech))) return false;
            if (this.Language != input.Language) return false;

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
                if (this.RobotId != null) hashCode = hashCode * 59 + this.RobotId.GetHashCode();
                if (this.WelcomeSpeech != null) hashCode = hashCode * 59 + this.WelcomeSpeech.GetHashCode();
                hashCode = hashCode * 59 + this.Language.GetHashCode();
                return hashCode;
            }
        }
    }
}
