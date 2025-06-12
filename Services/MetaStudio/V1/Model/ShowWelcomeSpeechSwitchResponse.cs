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
    public class ShowWelcomeSpeechSwitchResponse : SdkResponse
    {

        /// <summary>
        /// 欢迎词功能开关。
        /// </summary>
        [JsonProperty("enable_welcome_speech", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableWelcomeSpeech { get; set; }

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
            sb.Append("class ShowWelcomeSpeechSwitchResponse {\n");
            sb.Append("  enableWelcomeSpeech: ").Append(EnableWelcomeSpeech).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowWelcomeSpeechSwitchResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowWelcomeSpeechSwitchResponse input)
        {
            if (input == null) return false;
            if (this.EnableWelcomeSpeech != input.EnableWelcomeSpeech || (this.EnableWelcomeSpeech != null && !this.EnableWelcomeSpeech.Equals(input.EnableWelcomeSpeech))) return false;
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
                if (this.EnableWelcomeSpeech != null) hashCode = hashCode * 59 + this.EnableWelcomeSpeech.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
