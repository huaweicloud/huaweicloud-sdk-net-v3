using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateMembesRoleV4RequestBody 
    {

        /// <summary>
        /// 成员角色, -1 项目创建者, 3 项目经理, 4 开发人员, 5 测试经理, 6 测试人员, 7 参与者, 8 浏览者, 9 运维经理
        /// </summary>
        [JsonProperty("role_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RoleId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonProperty("user_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UserIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateMembesRoleV4RequestBody {\n");
            sb.Append("  roleId: ").Append(RoleId).Append("\n");
            sb.Append("  userIds: ").Append(UserIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateMembesRoleV4RequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateMembesRoleV4RequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RoleId == input.RoleId ||
                    (this.RoleId != null &&
                    this.RoleId.Equals(input.RoleId))
                ) && 
                (
                    this.UserIds == input.UserIds ||
                    this.UserIds != null &&
                    input.UserIds != null &&
                    this.UserIds.SequenceEqual(input.UserIds)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.RoleId != null)
                    hashCode = hashCode * 59 + this.RoleId.GetHashCode();
                if (this.UserIds != null)
                    hashCode = hashCode * 59 + this.UserIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
