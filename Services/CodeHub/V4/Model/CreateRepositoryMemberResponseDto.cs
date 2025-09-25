using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateRepositoryMemberResponseDto 
    {

        /// <summary>
        /// **参数解释：** 用户iamId **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("user_iam_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserIamId { get; set; }

        /// <summary>
        /// **参数解释：** 用户名称。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// **参数解释：** 租户名称。 **约束限制：** - 不涉及。
        /// </summary>
        [JsonProperty("tenant_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantName { get; set; }

        /// <summary>
        /// **参数解释：** 用户昵称。 **约束限制：** - 不涉及。    
        /// </summary>
        [JsonProperty("user_nick_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserNickName { get; set; }

        /// <summary>
        /// **参数解释：** 角色id。 **约束限制：** **约束限制：** - success，添加成功。 - error，添加失败。  
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释：** 成员添加结果信息。 **约束限制：** - 不涉及。    
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRepositoryMemberResponseDto {\n");
            sb.Append("  userIamId: ").Append(UserIamId).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  tenantName: ").Append(TenantName).Append("\n");
            sb.Append("  userNickName: ").Append(UserNickName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateRepositoryMemberResponseDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateRepositoryMemberResponseDto input)
        {
            if (input == null) return false;
            if (this.UserIamId != input.UserIamId || (this.UserIamId != null && !this.UserIamId.Equals(input.UserIamId))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.TenantName != input.TenantName || (this.TenantName != null && !this.TenantName.Equals(input.TenantName))) return false;
            if (this.UserNickName != input.UserNickName || (this.UserNickName != null && !this.UserNickName.Equals(input.UserNickName))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;

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
                if (this.UserIamId != null) hashCode = hashCode * 59 + this.UserIamId.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.TenantName != null) hashCode = hashCode * 59 + this.TenantName.GetHashCode();
                if (this.UserNickName != null) hashCode = hashCode * 59 + this.UserNickName.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }
    }
}
