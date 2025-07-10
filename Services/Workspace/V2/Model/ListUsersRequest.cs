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
    /// Request Object
    /// </summary>
    public class ListUsersRequest 
    {

        /// <summary>
        /// 桌面用户名，长度范围为1-20，不能包含特殊字符，不能以数字开头。
        /// </summary>
        [SDKProperty("user_name", IsQuery = true)]
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 用于分页查询，返回用户数量限制。如果不指定，则返回所有符合条件的用户。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }

        /// <summary>
        /// 分页查询起始条数。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public string Offset { get; set; }

        /// <summary>
        /// 用户描述查询，模糊匹配。
        /// </summary>
        [SDKProperty("description", IsQuery = true)]
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 激活类型，默认为用户激活。 * USER_ACTIVATE： 用户激活 * ADMIN_ACTIVATE： 管理员激活
        /// </summary>
        [SDKProperty("active_type", IsQuery = true)]
        [JsonProperty("active_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ActiveType { get; set; }

        /// <summary>
        /// 桌面用户组名，精确匹配。
        /// </summary>
        [SDKProperty("group_name", IsQuery = true)]
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// 用户是否已订阅协同，true/false。
        /// </summary>
        [SDKProperty("share_space_subscription", IsQuery = true)]
        [JsonProperty("share_space_subscription", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShareSpaceSubscription { get; set; }

        /// <summary>
        /// 用户是否已绑定协同桌面,true/false。
        /// </summary>
        [SDKProperty("share_space_desktops", IsQuery = true)]
        [JsonProperty("share_space_desktops", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShareSpaceDesktops { get; set; }

        /// <summary>
        /// 是否查询用户绑定的桌面数,true/false,默认true。
        /// </summary>
        [SDKProperty("is_query_total_desktops", IsQuery = true)]
        [JsonProperty("is_query_total_desktops", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsQueryTotalDesktops { get; set; }

        /// <summary>
        /// 企业项目ID
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListUsersRequest {\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  activeType: ").Append(ActiveType).Append("\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  shareSpaceSubscription: ").Append(ShareSpaceSubscription).Append("\n");
            sb.Append("  shareSpaceDesktops: ").Append(ShareSpaceDesktops).Append("\n");
            sb.Append("  isQueryTotalDesktops: ").Append(IsQueryTotalDesktops).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListUsersRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListUsersRequest input)
        {
            if (input == null) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.ActiveType != input.ActiveType || (this.ActiveType != null && !this.ActiveType.Equals(input.ActiveType))) return false;
            if (this.GroupName != input.GroupName || (this.GroupName != null && !this.GroupName.Equals(input.GroupName))) return false;
            if (this.ShareSpaceSubscription != input.ShareSpaceSubscription || (this.ShareSpaceSubscription != null && !this.ShareSpaceSubscription.Equals(input.ShareSpaceSubscription))) return false;
            if (this.ShareSpaceDesktops != input.ShareSpaceDesktops || (this.ShareSpaceDesktops != null && !this.ShareSpaceDesktops.Equals(input.ShareSpaceDesktops))) return false;
            if (this.IsQueryTotalDesktops != input.IsQueryTotalDesktops || (this.IsQueryTotalDesktops != null && !this.IsQueryTotalDesktops.Equals(input.IsQueryTotalDesktops))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;

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
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ActiveType != null) hashCode = hashCode * 59 + this.ActiveType.GetHashCode();
                if (this.GroupName != null) hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.ShareSpaceSubscription != null) hashCode = hashCode * 59 + this.ShareSpaceSubscription.GetHashCode();
                if (this.ShareSpaceDesktops != null) hashCode = hashCode * 59 + this.ShareSpaceDesktops.GetHashCode();
                if (this.IsQueryTotalDesktops != null) hashCode = hashCode * 59 + this.IsQueryTotalDesktops.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
