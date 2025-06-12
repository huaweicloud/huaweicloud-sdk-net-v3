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
    public class AuditResultSystemAuditResultErrors 
    {

        /// <summary>
        /// 音频文件名。
        /// </summary>
        [JsonProperty("audio_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AudioName { get; set; }

        /// <summary>
        /// 文本文件名。
        /// </summary>
        [JsonProperty("text_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TextName { get; set; }

        /// <summary>
        /// 异常错误码。
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 异常错误信息。
        /// </summary>
        [JsonProperty("error_message", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditResultSystemAuditResultErrors {\n");
            sb.Append("  audioName: ").Append(AudioName).Append("\n");
            sb.Append("  textName: ").Append(TextName).Append("\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  errorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuditResultSystemAuditResultErrors);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AuditResultSystemAuditResultErrors input)
        {
            if (input == null) return false;
            if (this.AudioName != input.AudioName || (this.AudioName != null && !this.AudioName.Equals(input.AudioName))) return false;
            if (this.TextName != input.TextName || (this.TextName != null && !this.TextName.Equals(input.TextName))) return false;
            if (this.ErrorCode != input.ErrorCode || (this.ErrorCode != null && !this.ErrorCode.Equals(input.ErrorCode))) return false;
            if (this.ErrorMessage != input.ErrorMessage || (this.ErrorMessage != null && !this.ErrorMessage.Equals(input.ErrorMessage))) return false;

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
                if (this.AudioName != null) hashCode = hashCode * 59 + this.AudioName.GetHashCode();
                if (this.TextName != null) hashCode = hashCode * 59 + this.TextName.GetHashCode();
                if (this.ErrorCode != null) hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMessage != null) hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                return hashCode;
            }
        }
    }
}
