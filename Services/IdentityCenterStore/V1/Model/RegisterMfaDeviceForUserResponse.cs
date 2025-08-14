using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterStore.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class RegisterMfaDeviceForUserResponse : SdkResponse
    {

        /// <summary>
        /// 身份源的全局唯一标识符（ID）
        /// </summary>
        [JsonProperty("identity_store_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IdentityStoreId { get; set; }

        /// <summary>
        /// 身份源中用户唯一标识符（ID）
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 注册MFA需要的一次性随机字符
        /// </summary>
        [JsonProperty("work_flow", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkFlow { get; set; }

        /// <summary>
        /// MFA注册重定向地址
        /// </summary>
        [JsonProperty("redirect_url", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirectUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegisterMfaDeviceForUserResponse {\n");
            sb.Append("  identityStoreId: ").Append(IdentityStoreId).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  workFlow: ").Append(WorkFlow).Append("\n");
            sb.Append("  redirectUrl: ").Append(RedirectUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RegisterMfaDeviceForUserResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RegisterMfaDeviceForUserResponse input)
        {
            if (input == null) return false;
            if (this.IdentityStoreId != input.IdentityStoreId || (this.IdentityStoreId != null && !this.IdentityStoreId.Equals(input.IdentityStoreId))) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.WorkFlow != input.WorkFlow || (this.WorkFlow != null && !this.WorkFlow.Equals(input.WorkFlow))) return false;
            if (this.RedirectUrl != input.RedirectUrl || (this.RedirectUrl != null && !this.RedirectUrl.Equals(input.RedirectUrl))) return false;

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
                if (this.IdentityStoreId != null) hashCode = hashCode * 59 + this.IdentityStoreId.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.WorkFlow != null) hashCode = hashCode * 59 + this.WorkFlow.GetHashCode();
                if (this.RedirectUrl != null) hashCode = hashCode * 59 + this.RedirectUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
