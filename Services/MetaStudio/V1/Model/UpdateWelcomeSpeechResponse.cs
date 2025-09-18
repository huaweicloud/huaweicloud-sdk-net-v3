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
    /// Response Object
    /// </summary>
    public class UpdateWelcomeSpeechResponse : SdkResponse
    {

        /// <summary>
        /// 欢迎词ID。
        /// </summary>
        [JsonProperty("welcome_speech_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WelcomeSpeechId { get; set; }

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
        /// 
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public LanguageEnum? Language { get; set; }

        /// <summary>
        /// 应用ID。
        /// </summary>
        [JsonProperty("robot_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RobotId { get; set; }

        /// <summary>
        /// 创建时间，格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 更新时间，格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Request-Id", IsHeader = true)]
        [JsonProperty("X-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateWelcomeSpeechResponse {\n");
            sb.Append("  welcomeSpeechId: ").Append(WelcomeSpeechId).Append("\n");
            sb.Append("  welcomeSpeech: ").Append(WelcomeSpeech).Append("\n");
            sb.Append("  enableWelcomeSpeech: ").Append(EnableWelcomeSpeech).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  robotId: ").Append(RobotId).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateWelcomeSpeechResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateWelcomeSpeechResponse input)
        {
            if (input == null) return false;
            if (this.WelcomeSpeechId != input.WelcomeSpeechId || (this.WelcomeSpeechId != null && !this.WelcomeSpeechId.Equals(input.WelcomeSpeechId))) return false;
            if (this.WelcomeSpeech != input.WelcomeSpeech || (this.WelcomeSpeech != null && !this.WelcomeSpeech.Equals(input.WelcomeSpeech))) return false;
            if (this.EnableWelcomeSpeech != input.EnableWelcomeSpeech || (this.EnableWelcomeSpeech != null && !this.EnableWelcomeSpeech.Equals(input.EnableWelcomeSpeech))) return false;
            if (this.Language != input.Language || (this.Language != null && !this.Language.Equals(input.Language))) return false;
            if (this.RobotId != input.RobotId || (this.RobotId != null && !this.RobotId.Equals(input.RobotId))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;

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
                if (this.WelcomeSpeechId != null) hashCode = hashCode * 59 + this.WelcomeSpeechId.GetHashCode();
                if (this.WelcomeSpeech != null) hashCode = hashCode * 59 + this.WelcomeSpeech.GetHashCode();
                if (this.EnableWelcomeSpeech != null) hashCode = hashCode * 59 + this.EnableWelcomeSpeech.GetHashCode();
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.RobotId != null) hashCode = hashCode * 59 + this.RobotId.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
