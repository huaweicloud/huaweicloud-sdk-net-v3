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
    /// 批量设置应用授权。
    /// </summary>
    public class BatchAssignAppAuthorizationsReq 
    {

        /// <summary>
        /// 批量唯一标识请求列表，一次请求数量区间 [1, 20]。
        /// </summary>
        [JsonProperty("app_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AppIds { get; set; }

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
            sb.Append("class BatchAssignAppAuthorizationsReq {\n");
            sb.Append("  appIds: ").Append(AppIds).Append("\n");
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
            return this.Equals(input as BatchAssignAppAuthorizationsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchAssignAppAuthorizationsReq input)
        {
            if (input == null) return false;
            if (this.AppIds != input.AppIds || (this.AppIds != null && input.AppIds != null && !this.AppIds.SequenceEqual(input.AppIds))) return false;
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
                if (this.AppIds != null) hashCode = hashCode * 59 + this.AppIds.GetHashCode();
                hashCode = hashCode * 59 + this.AuthorizationType.GetHashCode();
                if (this.Users != null) hashCode = hashCode * 59 + this.Users.GetHashCode();
                if (this.DelUsers != null) hashCode = hashCode * 59 + this.DelUsers.GetHashCode();
                return hashCode;
            }
        }
    }
}
