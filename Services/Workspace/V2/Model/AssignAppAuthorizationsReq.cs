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
    /// 设置应用授权。
    /// </summary>
    public class AssignAppAuthorizationsReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("authorization_type", NullValueHandling = NullValueHandling.Ignore)]
        public AssignType AuthorizationType { get; set; }
        /// <summary>
        /// 新增授权用户列表，一次请求数量区间 [0, 100]。
        /// </summary>
        [JsonProperty("users", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccountInfo> Users { get; set; }

        /// <summary>
        /// 取消授权用户列表，一次请求数量区间 [0, 100]。
        /// </summary>
        [JsonProperty("del_users", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccountInfo> DelUsers { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssignAppAuthorizationsReq {\n");
            sb.Append("  authorizationType: ").Append(AuthorizationType).Append("\n");
            sb.Append("  users: ").Append(Users).Append("\n");
            sb.Append("  delUsers: ").Append(DelUsers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssignAppAuthorizationsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssignAppAuthorizationsReq input)
        {
            if (input == null) return false;
            if (this.AuthorizationType != input.AuthorizationType) return false;
            if (this.Users != input.Users || (this.Users != null && input.Users != null && !this.Users.SequenceEqual(input.Users))) return false;
            if (this.DelUsers != input.DelUsers || (this.DelUsers != null && input.DelUsers != null && !this.DelUsers.SequenceEqual(input.DelUsers))) return false;

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
                hashCode = hashCode * 59 + this.AuthorizationType.GetHashCode();
                if (this.Users != null) hashCode = hashCode * 59 + this.Users.GetHashCode();
                if (this.DelUsers != null) hashCode = hashCode * 59 + this.DelUsers.GetHashCode();
                return hashCode;
            }
        }
    }
}
