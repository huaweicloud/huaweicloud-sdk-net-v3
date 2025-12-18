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
    /// Response Object
    /// </summary>
    public class DecodeAuthorizationMessageResponse : SdkResponse
    {

        /// <summary>
        /// 鉴权失败原因的明文。
        /// </summary>
        [JsonProperty("decoded_message", NullValueHandling = NullValueHandling.Ignore)]
        public string DecodedMessage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DecodeAuthorizationMessageResponse {\n");
            sb.Append("  decodedMessage: ").Append(DecodedMessage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DecodeAuthorizationMessageResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DecodeAuthorizationMessageResponse input)
        {
            if (input == null) return false;
            if (this.DecodedMessage != input.DecodedMessage || (this.DecodedMessage != null && !this.DecodedMessage.Equals(input.DecodedMessage))) return false;

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
                if (this.DecodedMessage != null) hashCode = hashCode * 59 + this.DecodedMessage.GetHashCode();
                return hashCode;
            }
        }
    }
}
