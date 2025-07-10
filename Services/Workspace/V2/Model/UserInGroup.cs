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
    /// 查询桌面用户组中的桌面用户响应的用户信息。
    /// </summary>
    public class UserInGroup 
    {

        /// <summary>
        /// 用户ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 桌面用户名。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 用户邮箱。
        /// </summary>
        [JsonProperty("user_email", NullValueHandling = NullValueHandling.Ignore)]
        public string UserEmail { get; set; }

        /// <summary>
        /// 用户手机号。
        /// </summary>
        [JsonProperty("user_phone", NullValueHandling = NullValueHandling.Ignore)]
        public string UserPhone { get; set; }

        /// <summary>
        /// 用户桌面数。
        /// </summary>
        [JsonProperty("total_desktops", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalDesktops { get; set; }

        /// <summary>
        /// 企业项ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 用户描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserInGroup {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  userEmail: ").Append(UserEmail).Append("\n");
            sb.Append("  userPhone: ").Append(UserPhone).Append("\n");
            sb.Append("  totalDesktops: ").Append(TotalDesktops).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserInGroup);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UserInGroup input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.UserEmail != input.UserEmail || (this.UserEmail != null && !this.UserEmail.Equals(input.UserEmail))) return false;
            if (this.UserPhone != input.UserPhone || (this.UserPhone != null && !this.UserPhone.Equals(input.UserPhone))) return false;
            if (this.TotalDesktops != input.TotalDesktops || (this.TotalDesktops != null && !this.TotalDesktops.Equals(input.TotalDesktops))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.UserEmail != null) hashCode = hashCode * 59 + this.UserEmail.GetHashCode();
                if (this.UserPhone != null) hashCode = hashCode * 59 + this.UserPhone.GetHashCode();
                if (this.TotalDesktops != null) hashCode = hashCode * 59 + this.TotalDesktops.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
