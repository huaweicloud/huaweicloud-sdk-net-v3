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
    /// 订阅操作请求，支持项目、用户、用户组的添加或删除订阅,项目、用户、用户组至少存在一个。
    /// </summary>
    public class SubscribeOperationReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("project", NullValueHandling = NullValueHandling.Ignore)]
        public SubscribeOperationReqProject Project { get; set; }

        /// <summary>
        /// 用户信息列表
        /// </summary>
        [JsonProperty("users", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateSubscribeUserInfo> Users { get; set; }

        /// <summary>
        /// 用户组信息列表
        /// </summary>
        [JsonProperty("usergroups", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateSubscribeUserGroupInfo> Usergroups { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscribeOperationReq {\n");
            sb.Append("  project: ").Append(Project).Append("\n");
            sb.Append("  users: ").Append(Users).Append("\n");
            sb.Append("  usergroups: ").Append(Usergroups).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubscribeOperationReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubscribeOperationReq input)
        {
            if (input == null) return false;
            if (this.Project != input.Project || (this.Project != null && !this.Project.Equals(input.Project))) return false;
            if (this.Users != input.Users || (this.Users != null && input.Users != null && !this.Users.SequenceEqual(input.Users))) return false;
            if (this.Usergroups != input.Usergroups || (this.Usergroups != null && input.Usergroups != null && !this.Usergroups.SequenceEqual(input.Usergroups))) return false;

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
                if (this.Project != null) hashCode = hashCode * 59 + this.Project.GetHashCode();
                if (this.Users != null) hashCode = hashCode * 59 + this.Users.GetHashCode();
                if (this.Usergroups != null) hashCode = hashCode * 59 + this.Usergroups.GetHashCode();
                return hashCode;
            }
        }
    }
}
