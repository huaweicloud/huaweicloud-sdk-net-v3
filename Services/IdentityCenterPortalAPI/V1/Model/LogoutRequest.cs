using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterPortalAPI.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class LogoutRequest 
    {

        /// <summary>
        /// 创建令牌接口调用签发的访问令牌
        /// </summary>
        [SDKProperty("access-token", IsHeader = true)]
        [JsonProperty("access-token", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessToken { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogoutRequest {\n");
            sb.Append("  accessToken: ").Append(AccessToken).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LogoutRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LogoutRequest input)
        {
            if (input == null) return false;
            if (this.AccessToken != input.AccessToken || (this.AccessToken != null && !this.AccessToken.Equals(input.AccessToken))) return false;

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
                if (this.AccessToken != null) hashCode = hashCode * 59 + this.AccessToken.GetHashCode();
                return hashCode;
            }
        }
    }
}
