using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListDesktopsStatusResponse : SdkResponse
    {

        /// <summary>
        /// 错误码。
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误描述。
        /// </summary>
        [JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 加密后的详细拒绝原因，用户可以自行调用STS服务的decode-authorization-message接口进行解密。
        /// </summary>
        [JsonProperty("encoded_authorization_message", NullValueHandling = NullValueHandling.Ignore)]
        public string EncodedAuthorizationMessage { get; set; }

        /// <summary>
        /// 统计信息。
        /// </summary>
        [JsonProperty("statics", NullValueHandling = NullValueHandling.Ignore)]
        public List<InstanceStatusStatistics> Statics { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDesktopsStatusResponse {\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  errorMsg: ").Append(ErrorMsg).Append("\n");
            sb.Append("  encodedAuthorizationMessage: ").Append(EncodedAuthorizationMessage).Append("\n");
            sb.Append("  statics: ").Append(Statics).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDesktopsStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDesktopsStatusResponse input)
        {
            if (input == null) return false;
            if (this.ErrorCode != input.ErrorCode || (this.ErrorCode != null && !this.ErrorCode.Equals(input.ErrorCode))) return false;
            if (this.ErrorMsg != input.ErrorMsg || (this.ErrorMsg != null && !this.ErrorMsg.Equals(input.ErrorMsg))) return false;
            if (this.EncodedAuthorizationMessage != input.EncodedAuthorizationMessage || (this.EncodedAuthorizationMessage != null && !this.EncodedAuthorizationMessage.Equals(input.EncodedAuthorizationMessage))) return false;
            if (this.Statics != input.Statics || (this.Statics != null && input.Statics != null && !this.Statics.SequenceEqual(input.Statics))) return false;

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
                if (this.ErrorCode != null) hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMsg != null) hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
                if (this.EncodedAuthorizationMessage != null) hashCode = hashCode * 59 + this.EncodedAuthorizationMessage.GetHashCode();
                if (this.Statics != null) hashCode = hashCode * 59 + this.Statics.GetHashCode();
                return hashCode;
            }
        }
    }
}
