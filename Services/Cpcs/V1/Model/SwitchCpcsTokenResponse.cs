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
        /// 
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public SwitchTokenResponseToken Token { get; set; }

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
            sb.Append("  token: ").Append(Token).Append("\n");
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
            if (this.Token != input.Token || (this.Token != null && !this.Token.Equals(input.Token))) return false;
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
                if (this.Token != null) hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.XCPCSToken != null) hashCode = hashCode * 59 + this.XCPCSToken.GetHashCode();
                return hashCode;
            }
        }
    }
}
