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
    /// 
    /// </summary>
    public class VerifyCodeCheckDTO 
    {

        /// <summary>
        /// 必须和发送验证码时带的用户身份信息相同。 
        /// </summary>
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public string User { get; set; }

        /// <summary>
        /// 验证码。 
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VerifyCodeCheckDTO {\n");
            sb.Append("  user: ").Append(User).Append("\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VerifyCodeCheckDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VerifyCodeCheckDTO input)
        {
            if (input == null) return false;
            if (this.User != input.User || (this.User != null && !this.User.Equals(input.User))) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;

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
                if (this.User != null) hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                return hashCode;
            }
        }
    }
}
