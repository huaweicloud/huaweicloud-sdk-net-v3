using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Sts.V1.Model
{
    /// <summary>
    /// 接口/v5/decode-authorization-message的Http请求体。
    /// </summary>
    public class DecodeAuthorizationMessageReq 
    {

        /// <summary>
        /// 加密的鉴权失败原因，字符串长度范围[1,10240]。
        /// </summary>
        [JsonProperty("encoded_message", NullValueHandling = NullValueHandling.Ignore)]
        public string EncodedMessage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DecodeAuthorizationMessageReq {\n");
            sb.Append("  encodedMessage: ").Append(EncodedMessage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DecodeAuthorizationMessageReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DecodeAuthorizationMessageReq input)
        {
            if (input == null) return false;
            if (this.EncodedMessage != input.EncodedMessage || (this.EncodedMessage != null && !this.EncodedMessage.Equals(input.EncodedMessage))) return false;

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
                if (this.EncodedMessage != null) hashCode = hashCode * 59 + this.EncodedMessage.GetHashCode();
                return hashCode;
            }
        }
    }
}
