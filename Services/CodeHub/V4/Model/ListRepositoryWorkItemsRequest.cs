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
    /// Request Object
    /// </summary>
    public class ListRepositoryWorkItemsRequest 
    {

        /// <summary>
        /// **参数解释：** 仓库的ID，通过[[查询用户所有仓库](https://support.huaweicloud.com/api-codeartsrepo/ListUserAllRepositories.html)](tag:hws)[[查询用户所有仓库](https://support.huaweicloud.com/intl/en-us/api-codeartsrepo/ListUserAllRepositories.html)](tag:hws_hk)[查询项目列表](tag:hcs,hcs_sm)接口查询项目列表获取。 **约束限制：** 不涉及。
        /// </summary>
        [SDKProperty("repository_id", IsPath = true)]
        [JsonProperty("repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepositoryId { get; set; }

        /// <summary>
        /// **参数解释：** 偏移量，从0开始。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// **参数解释：** 返回数量。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// **参数解释：** 项目的32位uuid，项目唯一标识，通过[[查询项目列表](https://support.huaweicloud.com/api-projectman/ListProjectsV4.html)](tag:hws)[[查询项目列表](https://support.huaweicloud.com/intl/en-us/api-projectman/ListProjectsV4.html)](tag:hws_hk)[查询项目列表](tag:hcs,hcs_sm)接口查询项目列表获取。 **取值范围：** 字符串长度32。
        /// </summary>
        [SDKProperty("project_id", IsQuery = true)]
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释：** 是否为IPD类型项目的工作项。 **取值范围：** true/false
        /// </summary>
        [SDKProperty("is_ipd", IsQuery = true)]
        [JsonProperty("is_ipd", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsIpd { get; set; }

        /// <summary>
        /// **参数解释：** 工作项标题搜索关键字。 **取值范围：** 字符串长度不少于1，不超过200。
        /// </summary>
        [SDKProperty("subject", IsQuery = true)]
        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public string Subject { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求的目标分支，如果要获取合并请求可关联的工作项列表，则需要传递该字段。  **约束限制：** 不支持以 - . refs/heads/ refs/remotes/ 开头，不支持空格 [ \\ &lt; ~ ^ : ? * ! ( ) &#39; \&quot; | 等特殊字符，不支持以. / .lock结尾。  **取值范围：** 字符串长度不少于1，不超过200。 **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("target_branch", IsQuery = true)]
        [JsonProperty("target_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetBranch { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRepositoryWorkItemsRequest {\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  isIpd: ").Append(IsIpd).Append("\n");
            sb.Append("  subject: ").Append(Subject).Append("\n");
            sb.Append("  targetBranch: ").Append(TargetBranch).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRepositoryWorkItemsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRepositoryWorkItemsRequest input)
        {
            if (input == null) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.IsIpd != input.IsIpd || (this.IsIpd != null && !this.IsIpd.Equals(input.IsIpd))) return false;
            if (this.Subject != input.Subject || (this.Subject != null && !this.Subject.Equals(input.Subject))) return false;
            if (this.TargetBranch != input.TargetBranch || (this.TargetBranch != null && !this.TargetBranch.Equals(input.TargetBranch))) return false;

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
                if (this.RepositoryId != null) hashCode = hashCode * 59 + this.RepositoryId.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.IsIpd != null) hashCode = hashCode * 59 + this.IsIpd.GetHashCode();
                if (this.Subject != null) hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.TargetBranch != null) hashCode = hashCode * 59 + this.TargetBranch.GetHashCode();
                return hashCode;
            }
        }
    }
}
