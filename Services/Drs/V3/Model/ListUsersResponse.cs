using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListUsersResponse : SdkResponse
    {

        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 是否使用全局密码
        /// </summary>
        [JsonProperty("is_global_password", NullValueHandling = NullValueHandling.Ignore)]
        public string IsGlobalPassword { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// 用户列表数据
        /// </summary>
        [JsonProperty("user_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<QueryUserDetailResp> UserList { get; set; }

        /// <summary>
        /// 角色列表数据
        /// </summary>
        [JsonProperty("roles_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<QueryRoleDetailResp> RolesList { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonProperty("is_success", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSuccess { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListUsersResponse {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  isGlobalPassword: ").Append(IsGlobalPassword).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  userList: ").Append(UserList).Append("\n");
            sb.Append("  rolesList: ").Append(RolesList).Append("\n");
            sb.Append("  isSuccess: ").Append(IsSuccess).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListUsersResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListUsersResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.IsGlobalPassword == input.IsGlobalPassword ||
                    (this.IsGlobalPassword != null &&
                    this.IsGlobalPassword.Equals(input.IsGlobalPassword))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.UserList == input.UserList ||
                    this.UserList != null &&
                    input.UserList != null &&
                    this.UserList.SequenceEqual(input.UserList)
                ) && 
                (
                    this.RolesList == input.RolesList ||
                    this.RolesList != null &&
                    input.RolesList != null &&
                    this.RolesList.SequenceEqual(input.RolesList)
                ) && 
                (
                    this.IsSuccess == input.IsSuccess ||
                    (this.IsSuccess != null &&
                    this.IsSuccess.Equals(input.IsSuccess))
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
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.IsGlobalPassword != null)
                    hashCode = hashCode * 59 + this.IsGlobalPassword.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.UserList != null)
                    hashCode = hashCode * 59 + this.UserList.GetHashCode();
                if (this.RolesList != null)
                    hashCode = hashCode * 59 + this.RolesList.GetHashCode();
                if (this.IsSuccess != null)
                    hashCode = hashCode * 59 + this.IsSuccess.GetHashCode();
                return hashCode;
            }
        }
    }
}
