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
    /// Request Object
    /// </summary>
    public class ShowCreateAccountStatusRequest 
    {

        /// <summary>
        /// 如果正在使用临时安全凭据，则此header是必需的，该值是临时安全凭据的安全令牌（会话令牌）。
        /// </summary>
        [SDKProperty("X-Security-Token", IsHeader = true)]
        [JsonProperty("X-Security-Token", NullValueHandling = NullValueHandling.Ignore)]
        public string XSecurityToken { get; set; }

        /// <summary>
        /// 指定唯一标识CreateAccount请求的ID值。
        /// </summary>
        [SDKProperty("create_account_status_id", IsPath = true)]
        [JsonProperty("create_account_status_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateAccountStatusId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowCreateAccountStatusRequest {\n");
            sb.Append("  xSecurityToken: ").Append(XSecurityToken).Append("\n");
            sb.Append("  createAccountStatusId: ").Append(CreateAccountStatusId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowCreateAccountStatusRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowCreateAccountStatusRequest input)
        {
            if (input == null) return false;
            if (this.XSecurityToken != input.XSecurityToken || (this.XSecurityToken != null && !this.XSecurityToken.Equals(input.XSecurityToken))) return false;
            if (this.CreateAccountStatusId != input.CreateAccountStatusId || (this.CreateAccountStatusId != null && !this.CreateAccountStatusId.Equals(input.CreateAccountStatusId))) return false;

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
                if (this.XSecurityToken != null) hashCode = hashCode * 59 + this.XSecurityToken.GetHashCode();
                if (this.CreateAccountStatusId != null) hashCode = hashCode * 59 + this.CreateAccountStatusId.GetHashCode();
                return hashCode;
            }
        }
    }
}
