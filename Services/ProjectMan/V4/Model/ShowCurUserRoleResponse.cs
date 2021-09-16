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
    /// Response Object
    /// </summary>
    public class ShowCurUserRoleResponse : SdkResponse
    {

        /// <summary>
        /// 用户角色id 成员角色, -1 项目创建者, 3 项目经理, 4 开发人员, 5 测试经理, 6 测试人员, 7 参与者, 8 浏览者, 9 运维经理
        /// </summary>
        [JsonProperty("user_role", NullValueHandling = NullValueHandling.Ignore)]
        public int? UserRole { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowCurUserRoleResponse {\n");
            sb.Append("  userRole: ").Append(UserRole).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowCurUserRoleResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowCurUserRoleResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserRole == input.UserRole ||
                    (this.UserRole != null &&
                    this.UserRole.Equals(input.UserRole))
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
                if (this.UserRole != null)
                    hashCode = hashCode * 59 + this.UserRole.GetHashCode();
                return hashCode;
            }
        }
    }
}
