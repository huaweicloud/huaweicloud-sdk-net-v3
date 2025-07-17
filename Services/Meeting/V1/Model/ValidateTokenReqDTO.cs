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
    public class ValidateTokenReqDTO 
    {

        /// <summary>
        /// Access Token。
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        /// <summary>
        /// 是否生成新的Token。 * true：生成新的token值 * false：不生成新的token值 
        /// </summary>
        [JsonProperty("needGenNewToken", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NeedGenNewToken { get; set; }

        /// <summary>
        /// 是否需要返回用户帐号信息（帐号、用户名称等信息）。
        /// </summary>
        [JsonProperty("needAccountInfo", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NeedAccountInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidateTokenReqDTO {\n");
            sb.Append("  token: ").Append(Token).Append("\n");
            sb.Append("  needGenNewToken: ").Append(NeedGenNewToken).Append("\n");
            sb.Append("  needAccountInfo: ").Append(NeedAccountInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ValidateTokenReqDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ValidateTokenReqDTO input)
        {
            if (input == null) return false;
            if (this.Token != input.Token || (this.Token != null && !this.Token.Equals(input.Token))) return false;
            if (this.NeedGenNewToken != input.NeedGenNewToken || (this.NeedGenNewToken != null && !this.NeedGenNewToken.Equals(input.NeedGenNewToken))) return false;
            if (this.NeedAccountInfo != input.NeedAccountInfo || (this.NeedAccountInfo != null && !this.NeedAccountInfo.Equals(input.NeedAccountInfo))) return false;

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
                if (this.NeedGenNewToken != null) hashCode = hashCode * 59 + this.NeedGenNewToken.GetHashCode();
                if (this.NeedAccountInfo != null) hashCode = hashCode * 59 + this.NeedAccountInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
