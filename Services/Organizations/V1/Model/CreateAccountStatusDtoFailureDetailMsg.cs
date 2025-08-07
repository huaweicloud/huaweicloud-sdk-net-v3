using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Organizations.V1.Model
{
    /// <summary>
    /// 请求失败详细原因
    /// </summary>
    public class CreateAccountStatusDtoFailureDetailMsg 
    {

        /// <summary>
        /// 透传错误码
        /// </summary>
        [JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 透传鉴权失败信息
        /// </summary>
        [JsonProperty("encoded_authorization_message", NullValueHandling = NullValueHandling.Ignore)]
        public string EncodedAuthorizationMessage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAccountStatusDtoFailureDetailMsg {\n");
            sb.Append("  errorMsg: ").Append(ErrorMsg).Append("\n");
            sb.Append("  encodedAuthorizationMessage: ").Append(EncodedAuthorizationMessage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAccountStatusDtoFailureDetailMsg);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAccountStatusDtoFailureDetailMsg input)
        {
            if (input == null) return false;
            if (this.ErrorMsg != input.ErrorMsg || (this.ErrorMsg != null && !this.ErrorMsg.Equals(input.ErrorMsg))) return false;
            if (this.EncodedAuthorizationMessage != input.EncodedAuthorizationMessage || (this.EncodedAuthorizationMessage != null && !this.EncodedAuthorizationMessage.Equals(input.EncodedAuthorizationMessage))) return false;

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
                if (this.ErrorMsg != null) hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
                if (this.EncodedAuthorizationMessage != null) hashCode = hashCode * 59 + this.EncodedAuthorizationMessage.GetHashCode();
                return hashCode;
            }
        }
    }
}
