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
    public class RepoInfo 
    {

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("createAt", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateAt { get; set; }

        /// <summary>
        /// 仓库组名(克隆地址中域名后面仓库名前的一段 示例：git@repo.alpha.devcloud.inhuawei.com:Demo00228/testword.git  组名：Demo00228)
        /// </summary>
        [JsonProperty("groupName", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// https url
        /// </summary>
        [JsonProperty("httpUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string HttpUrl { get; set; }

        /// <summary>
        /// 仓库uuid(由CreateRepository接口返回)
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 仓库名
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 项目ID，获取方式请参见[获取项目ID](codehub_api_0014.xml)。
        /// </summary>
        [JsonProperty("projectId", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 项目是否被删除
        /// </summary>
        [JsonProperty("projectIsDelete", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectIsDelete { get; set; }

        /// <summary>
        /// 仓库主键id
        /// </summary>
        [JsonProperty("repoId", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoId { get; set; }

        /// <summary>
        /// ssh url
        /// </summary>
        [JsonProperty("sshUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string SshUrl { get; set; }

        /// <summary>
        /// 是否可见：0私有仓库，20公有仓库
        /// </summary>
        [JsonProperty("visibilityLevel", NullValueHandling = NullValueHandling.Ignore)]
        public int? VisibilityLevel { get; set; }

        /// <summary>
        /// web url 访问路径
        /// </summary>
        [JsonProperty("webUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string WebUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepoInfo {\n");
            sb.Append("  createAt: ").Append(CreateAt).Append("\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  httpUrl: ").Append(HttpUrl).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  projectIsDelete: ").Append(ProjectIsDelete).Append("\n");
            sb.Append("  repoId: ").Append(RepoId).Append("\n");
            sb.Append("  sshUrl: ").Append(SshUrl).Append("\n");
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
            return this.Equals(input as RepoInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RepoInfo input)
        {
            if (input == null) return false;
            if (this.CreateAt != input.CreateAt || (this.CreateAt != null && !this.CreateAt.Equals(input.CreateAt))) return false;
            if (this.GroupName != input.GroupName || (this.GroupName != null && !this.GroupName.Equals(input.GroupName))) return false;
            if (this.HttpUrl != input.HttpUrl || (this.HttpUrl != null && !this.HttpUrl.Equals(input.HttpUrl))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ProjectIsDelete != input.ProjectIsDelete || (this.ProjectIsDelete != null && !this.ProjectIsDelete.Equals(input.ProjectIsDelete))) return false;
            if (this.RepoId != input.RepoId || (this.RepoId != null && !this.RepoId.Equals(input.RepoId))) return false;
            if (this.SshUrl != input.SshUrl || (this.SshUrl != null && !this.SshUrl.Equals(input.SshUrl))) return false;
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
                if (this.CreateAt != null) hashCode = hashCode * 59 + this.CreateAt.GetHashCode();
                if (this.GroupName != null) hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.HttpUrl != null) hashCode = hashCode * 59 + this.HttpUrl.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProjectIsDelete != null) hashCode = hashCode * 59 + this.ProjectIsDelete.GetHashCode();
                if (this.RepoId != null) hashCode = hashCode * 59 + this.RepoId.GetHashCode();
                if (this.SshUrl != null) hashCode = hashCode * 59 + this.SshUrl.GetHashCode();
                if (this.VisibilityLevel != null) hashCode = hashCode * 59 + this.VisibilityLevel.GetHashCode();
                if (this.WebUrl != null) hashCode = hashCode * 59 + this.WebUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
