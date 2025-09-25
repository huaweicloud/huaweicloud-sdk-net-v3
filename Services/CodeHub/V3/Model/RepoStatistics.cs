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
    public class RepoStatistics 
    {

        /// <summary>
        /// 添加代码行
        /// </summary>
        [JsonProperty("add_lines", NullValueHandling = NullValueHandling.Ignore)]
        public int? AddLines { get; set; }

        /// <summary>
        /// 分支名
        /// </summary>
        [JsonProperty("branch", NullValueHandling = NullValueHandling.Ignore)]
        public string Branch { get; set; }

        /// <summary>
        /// 提交次数
        /// </summary>
        [JsonProperty("commit_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? CommitCount { get; set; }

        /// <summary>
        /// 仓库统计创建的时间
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 删除代码行
        /// </summary>
        [JsonProperty("delete_lines", NullValueHandling = NullValueHandling.Ignore)]
        public int? DeleteLines { get; set; }

        /// <summary>
        /// 仓库统计记录id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 仓库id
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProjectId { get; set; }

        /// <summary>
        /// 仓库统计更新的时间
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepoStatistics {\n");
            sb.Append("  addLines: ").Append(AddLines).Append("\n");
            sb.Append("  branch: ").Append(Branch).Append("\n");
            sb.Append("  commitCount: ").Append(CommitCount).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  deleteLines: ").Append(DeleteLines).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RepoStatistics);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RepoStatistics input)
        {
            if (input == null) return false;
            if (this.AddLines != input.AddLines || (this.AddLines != null && !this.AddLines.Equals(input.AddLines))) return false;
            if (this.Branch != input.Branch || (this.Branch != null && !this.Branch.Equals(input.Branch))) return false;
            if (this.CommitCount != input.CommitCount || (this.CommitCount != null && !this.CommitCount.Equals(input.CommitCount))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.DeleteLines != input.DeleteLines || (this.DeleteLines != null && !this.DeleteLines.Equals(input.DeleteLines))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;

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
                if (this.AddLines != null) hashCode = hashCode * 59 + this.AddLines.GetHashCode();
                if (this.Branch != null) hashCode = hashCode * 59 + this.Branch.GetHashCode();
                if (this.CommitCount != null) hashCode = hashCode * 59 + this.CommitCount.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.DeleteLines != null) hashCode = hashCode * 59 + this.DeleteLines.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                return hashCode;
            }
        }
    }
}
