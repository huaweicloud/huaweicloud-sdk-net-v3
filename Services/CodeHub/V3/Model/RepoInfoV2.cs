using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RepoInfoV2 
    {

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 创建者的用户名，在用户是租户的情况下，用户名和租户名相等
        /// </summary>
        [JsonProperty("creator_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorName { get; set; }

        /// <summary>
        /// 创建者的租户名
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// 仓库组名(克隆地址中域名后面仓库名前的一段 示例：git@repo.alpha.devcloud.inhuawei.com:Demo00228/testword.git  组名：Demo00228 )
        /// </summary>
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// 使用 https 克隆仓库时所使用的 url
        /// </summary>
        [JsonProperty("https_url", NullValueHandling = NullValueHandling.Ignore)]
        public string HttpsUrl { get; set; }

        /// <summary>
        /// 用户的 iam user uuid
        /// </summary>
        [JsonProperty("iam_user_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string IamUserUuid { get; set; }

        /// <summary>
        /// 当前用户是否是仓库的创建者，1：是，0：不是
        /// </summary>
        [JsonProperty("is_owner", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsOwner { get; set; }

        /// <summary>
        /// 仓库 LFS 容量，单位为M，大于 1024M 则单位为 G
        /// </summary>
        [JsonProperty("lfs_size", NullValueHandling = NullValueHandling.Ignore)]
        public string LfsSize { get; set; }

        /// <summary>
        /// 项目是否被删除
        /// </summary>
        [JsonProperty("project_is_deleted", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectIsDeleted { get; set; }

        /// <summary>
        /// 项目ID，获取方式请参见[获取项目ID](codehub_api_0014.xml)。
        /// </summary>
        [JsonProperty("project_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectUuid { get; set; }

        /// <summary>
        /// 仓库主键id
        /// </summary>
        [JsonProperty("repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepositoryId { get; set; }

        /// <summary>
        /// 仓库名
        /// </summary>
        [JsonProperty("repository_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// 仓库总容量 &#x3D; 仓库 LFS 容量 + git 库容量，单位为M，大于 1024M 则单位为 G
        /// </summary>
        [JsonProperty("repository_size", NullValueHandling = NullValueHandling.Ignore)]
        public string RepositorySize { get; set; }

        /// <summary>
        /// 仓库uuid(由CreateRepository接口返回)
        /// </summary>
        [JsonProperty("repository_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string RepositoryUuid { get; set; }

        /// <summary>
        /// 使用 ssh 方式克隆仓库时所使用的 url
        /// </summary>
        [JsonProperty("ssh_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SshUrl { get; set; }

        /// <summary>
        /// 当前用户是否收藏该仓库
        /// </summary>
        [JsonProperty("star", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Star { get; set; }

        /// <summary>
        /// 仓库状态， 0：仓库正常创建成功 1：仓库创建中 2：创建失败 3：仓库冻结 4：仓库已经关闭 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 用户在仓库中的权限:20：只读成员 30：普通成员 40：管理员 
        /// </summary>
        [JsonProperty("userRole", NullValueHandling = NullValueHandling.Ignore)]
        public int? UserRole { get; set; }

        /// <summary>
        /// 是否可见：0私有仓库，20公有仓库
        /// </summary>
        [JsonProperty("visibility_level", NullValueHandling = NullValueHandling.Ignore)]
        public int? VisibilityLevel { get; set; }

        /// <summary>
        /// web url 路径，访问它将跳转至仓库详情页
        /// </summary>
        [JsonProperty("web_url", NullValueHandling = NullValueHandling.Ignore)]
        public string WebUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepoInfoV2 {\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  creatorName: ").Append(CreatorName).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  httpsUrl: ").Append(HttpsUrl).Append("\n");
            sb.Append("  iamUserUuid: ").Append(IamUserUuid).Append("\n");
            sb.Append("  isOwner: ").Append(IsOwner).Append("\n");
            sb.Append("  lfsSize: ").Append(LfsSize).Append("\n");
            sb.Append("  projectIsDeleted: ").Append(ProjectIsDeleted).Append("\n");
            sb.Append("  projectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  repositoryName: ").Append(RepositoryName).Append("\n");
            sb.Append("  repositorySize: ").Append(RepositorySize).Append("\n");
            sb.Append("  repositoryUuid: ").Append(RepositoryUuid).Append("\n");
            sb.Append("  sshUrl: ").Append(SshUrl).Append("\n");
            sb.Append("  star: ").Append(Star).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  userRole: ").Append(UserRole).Append("\n");
            sb.Append("  visibilityLevel: ").Append(VisibilityLevel).Append("\n");
            sb.Append("  webUrl: ").Append(WebUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RepoInfoV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RepoInfoV2 input)
        {
            if (input == null) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.CreatorName != input.CreatorName || (this.CreatorName != null && !this.CreatorName.Equals(input.CreatorName))) return false;
            if (this.DomainName != input.DomainName || (this.DomainName != null && !this.DomainName.Equals(input.DomainName))) return false;
            if (this.GroupName != input.GroupName || (this.GroupName != null && !this.GroupName.Equals(input.GroupName))) return false;
            if (this.HttpsUrl != input.HttpsUrl || (this.HttpsUrl != null && !this.HttpsUrl.Equals(input.HttpsUrl))) return false;
            if (this.IamUserUuid != input.IamUserUuid || (this.IamUserUuid != null && !this.IamUserUuid.Equals(input.IamUserUuid))) return false;
            if (this.IsOwner != input.IsOwner || (this.IsOwner != null && !this.IsOwner.Equals(input.IsOwner))) return false;
            if (this.LfsSize != input.LfsSize || (this.LfsSize != null && !this.LfsSize.Equals(input.LfsSize))) return false;
            if (this.ProjectIsDeleted != input.ProjectIsDeleted || (this.ProjectIsDeleted != null && !this.ProjectIsDeleted.Equals(input.ProjectIsDeleted))) return false;
            if (this.ProjectUuid != input.ProjectUuid || (this.ProjectUuid != null && !this.ProjectUuid.Equals(input.ProjectUuid))) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.RepositoryName != input.RepositoryName || (this.RepositoryName != null && !this.RepositoryName.Equals(input.RepositoryName))) return false;
            if (this.RepositorySize != input.RepositorySize || (this.RepositorySize != null && !this.RepositorySize.Equals(input.RepositorySize))) return false;
            if (this.RepositoryUuid != input.RepositoryUuid || (this.RepositoryUuid != null && !this.RepositoryUuid.Equals(input.RepositoryUuid))) return false;
            if (this.SshUrl != input.SshUrl || (this.SshUrl != null && !this.SshUrl.Equals(input.SshUrl))) return false;
            if (this.Star != input.Star || (this.Star != null && !this.Star.Equals(input.Star))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.UserRole != input.UserRole || (this.UserRole != null && !this.UserRole.Equals(input.UserRole))) return false;
            if (this.VisibilityLevel != input.VisibilityLevel || (this.VisibilityLevel != null && !this.VisibilityLevel.Equals(input.VisibilityLevel))) return false;
            if (this.WebUrl != input.WebUrl || (this.WebUrl != null && !this.WebUrl.Equals(input.WebUrl))) return false;

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
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.CreatorName != null) hashCode = hashCode * 59 + this.CreatorName.GetHashCode();
                if (this.DomainName != null) hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.GroupName != null) hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.HttpsUrl != null) hashCode = hashCode * 59 + this.HttpsUrl.GetHashCode();
                if (this.IamUserUuid != null) hashCode = hashCode * 59 + this.IamUserUuid.GetHashCode();
                if (this.IsOwner != null) hashCode = hashCode * 59 + this.IsOwner.GetHashCode();
                if (this.LfsSize != null) hashCode = hashCode * 59 + this.LfsSize.GetHashCode();
                if (this.ProjectIsDeleted != null) hashCode = hashCode * 59 + this.ProjectIsDeleted.GetHashCode();
                if (this.ProjectUuid != null) hashCode = hashCode * 59 + this.ProjectUuid.GetHashCode();
                if (this.RepositoryId != null) hashCode = hashCode * 59 + this.RepositoryId.GetHashCode();
                if (this.RepositoryName != null) hashCode = hashCode * 59 + this.RepositoryName.GetHashCode();
                if (this.RepositorySize != null) hashCode = hashCode * 59 + this.RepositorySize.GetHashCode();
                if (this.RepositoryUuid != null) hashCode = hashCode * 59 + this.RepositoryUuid.GetHashCode();
                if (this.SshUrl != null) hashCode = hashCode * 59 + this.SshUrl.GetHashCode();
                if (this.Star != null) hashCode = hashCode * 59 + this.Star.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.UserRole != null) hashCode = hashCode * 59 + this.UserRole.GetHashCode();
                if (this.VisibilityLevel != null) hashCode = hashCode * 59 + this.VisibilityLevel.GetHashCode();
                if (this.WebUrl != null) hashCode = hashCode * 59 + this.WebUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
