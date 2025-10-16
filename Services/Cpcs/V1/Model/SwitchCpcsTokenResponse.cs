using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cpcs.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class SwitchCpcsTokenResponse : SdkResponse
    {

        /// <summary>
        /// 角色列表
        /// </summary>
        [JsonProperty("roles", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ak", NullValueHandling = NullValueHandling.Ignore)]
        public SwitchTokenResponseAk Ak { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonProperty("expired_at", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiredAt { get; set; }

        /// <summary>
        /// 签发时间
        /// </summary>
        [JsonProperty("issued_at", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public SwitchTokenResponseUser User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-CPCS-Token", IsHeader = true)]
        [JsonProperty("X-CPCS-Token", NullValueHandling = NullValueHandling.Ignore)]
        public string XCPCSToken { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SwitchCpcsTokenResponse {\n");
            sb.Append("  roles: ").Append(Roles).Append("\n");
            sb.Append("  ak: ").Append(Ak).Append("\n");
            sb.Append("  expiredAt: ").Append(ExpiredAt).Append("\n");
            sb.Append("  issuedAt: ").Append(IssuedAt).Append("\n");
            sb.Append("  user: ").Append(User).Append("\n");
            sb.Append("  xCPCSToken: ").Append(XCPCSToken).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SwitchCpcsTokenResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SwitchCpcsTokenResponse input)
        {
            if (input == null) return false;
            if (this.Roles != input.Roles || (this.Roles != null && input.Roles != null && !this.Roles.SequenceEqual(input.Roles))) return false;
            if (this.Ak != input.Ak || (this.Ak != null && !this.Ak.Equals(input.Ak))) return false;
            if (this.ExpiredAt != input.ExpiredAt || (this.ExpiredAt != null && !this.ExpiredAt.Equals(input.ExpiredAt))) return false;
            if (this.IssuedAt != input.IssuedAt || (this.IssuedAt != null && !this.IssuedAt.Equals(input.IssuedAt))) return false;
            if (this.User != input.User || (this.User != null && !this.User.Equals(input.User))) return false;
            if (this.XCPCSToken != input.XCPCSToken || (this.XCPCSToken != null && !this.XCPCSToken.Equals(input.XCPCSToken))) return false;

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
                if (this.Roles != null) hashCode = hashCode * 59 + this.Roles.GetHashCode();
                if (this.Ak != null) hashCode = hashCode * 59 + this.Ak.GetHashCode();
                if (this.ExpiredAt != null) hashCode = hashCode * 59 + this.ExpiredAt.GetHashCode();
                if (this.IssuedAt != null) hashCode = hashCode * 59 + this.IssuedAt.GetHashCode();
                if (this.User != null) hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.XCPCSToken != null) hashCode = hashCode * 59 + this.XCPCSToken.GetHashCode();
                return hashCode;
            }
        }
    }
}
