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
    /// 自动安装应用请求。 assign_scope&#x3D;ASSIGN_USER: users必须非空，如果用户不满足对应应用的访问权限，会自动添加对应的权限。 assign_scope&#x3D;ALL_USER: 会同时修改所有应用授权为全部用户。
    /// </summary>
    public class BatchAutoInstallAppsReq 
    {

        /// <summary>
        /// 批量唯一标识请求列表，一次请求数量区间 [1, 50]。
        /// </summary>
        [JsonProperty("app_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AppIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("assign_scope", NullValueHandling = NullValueHandling.Ignore)]
        public AssignType AssignScope { get; set; }
        /// <summary>
        /// 用户列表，一次请求数量区间 [1, 50]。
        /// </summary>
        [JsonProperty("users", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccountInfo> Users { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchAutoInstallAppsReq {\n");
            sb.Append("  appIds: ").Append(AppIds).Append("\n");
            sb.Append("  assignScope: ").Append(AssignScope).Append("\n");
            sb.Append("  users: ").Append(Users).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchAutoInstallAppsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchAutoInstallAppsReq input)
        {
            if (input == null) return false;
            if (this.AppIds != input.AppIds || (this.AppIds != null && input.AppIds != null && !this.AppIds.SequenceEqual(input.AppIds))) return false;
            if (this.AssignScope != input.AssignScope) return false;
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
                if (this.AppIds != null) hashCode = hashCode * 59 + this.AppIds.GetHashCode();
                hashCode = hashCode * 59 + this.AssignScope.GetHashCode();
                if (this.Users != null) hashCode = hashCode * 59 + this.Users.GetHashCode();
                return hashCode;
            }
        }
    }
}
