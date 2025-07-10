using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 用户订阅协同请求体。
    /// </summary>
    public class SubscribeUserSharerReq 
    {

        /// <summary>
        /// 用户协同资源SKU码。
        /// </summary>
        [JsonProperty("user_sharer_sku", NullValueHandling = NullValueHandling.Ignore)]
        public string UserSharerSku { get; set; }

        /// <summary>
        /// 开通协同的的用户列表。
        /// </summary>
        [JsonProperty("users", NullValueHandling = NullValueHandling.Ignore)]
        public List<User> Users { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscribeUserSharerReq {\n");
            sb.Append("  userSharerSku: ").Append(UserSharerSku).Append("\n");
            sb.Append("  users: ").Append(Users).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubscribeUserSharerReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubscribeUserSharerReq input)
        {
            if (input == null) return false;
            if (this.UserSharerSku != input.UserSharerSku || (this.UserSharerSku != null && !this.UserSharerSku.Equals(input.UserSharerSku))) return false;
            if (this.Users != input.Users || (this.Users != null && input.Users != null && !this.Users.SequenceEqual(input.Users))) return false;

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
                if (this.UserSharerSku != null) hashCode = hashCode * 59 + this.UserSharerSku.GetHashCode();
                if (this.Users != null) hashCode = hashCode * 59 + this.Users.GetHashCode();
                return hashCode;
            }
        }
    }
}
