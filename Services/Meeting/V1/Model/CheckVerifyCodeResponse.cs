using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CheckVerifyCodeResponse : SdkResponse
    {

        /// <summary>
        /// 访问token字符串。
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        /// <summary>
        /// 过期时间，单位：秒。
        /// </summary>
        [JsonProperty("expire", NullValueHandling = NullValueHandling.Ignore)]
        public int? Expire { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckVerifyCodeResponse {\n");
            sb.Append("  token: ").Append(Token).Append("\n");
            sb.Append("  expire: ").Append(Expire).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckVerifyCodeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckVerifyCodeResponse input)
        {
            if (input == null) return false;
            if (this.Token != input.Token || (this.Token != null && !this.Token.Equals(input.Token))) return false;
            if (this.Expire != input.Expire || (this.Expire != null && !this.Expire.Equals(input.Expire))) return false;

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
                if (this.Token != null) hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.Expire != null) hashCode = hashCode * 59 + this.Expire.GetHashCode();
                return hashCode;
            }
        }
    }
}
