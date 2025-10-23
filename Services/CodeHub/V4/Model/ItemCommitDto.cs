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
    /// 工作项关联的提交信息
    /// </summary>
    public class ItemCommitDto 
    {

        /// <summary>
        /// **参数解释：** 关联Id。 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求标题。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// **参数解释：** 仓库状态。 **取值范围：** - 1，关联成功。 - 2，关联失败。 - 3，流转成功。
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public int? Result { get; set; }

        /// <summary>
        /// **参数解释：** 关联提交类型。 **取值范围：** - commit，提交。 - branch，分支。 - mergerequest，合并请求。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释：** 关联失败的失败原因。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// **参数解释：** 工作项Id。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("item_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemId { get; set; }

        /// <summary>
        /// **参数解释：** 仓库Id。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RepositoryId { get; set; }

        /// <summary>
        /// **参数解释：** 分支名。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("branch_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchName { get; set; }

        /// <summary>
        /// **参数解释：** 用户名。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// **参数解释：** 提交Id。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("commit_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitId { get; set; }

        /// <summary>
        /// **参数解释：** 提交短Id。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("commit_short_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitShortId { get; set; }

        /// <summary>
        /// **参数解释：** 提交信息。 **取值范围：** 不涉及。            
        /// </summary>
        [JsonProperty("commit_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitMsg { get; set; }

        /// <summary>
        /// **参数解释：** 提交访问地址。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("commit_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitUrl { get; set; }

        /// <summary>
        /// **参数解释：** iamId。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("iam_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IamId { get; set; }

        /// <summary>
        /// **参数解释：** 创建时间。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("create_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateAt { get; set; }

        /// <summary>
        /// **参数解释：** 更新时间。 **取值范围：** 不涉及。  
        /// </summary>
        [JsonProperty("update_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateAt { get; set; }

        /// <summary>
        /// **参数解释：** 工作项访问地址。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("item_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemCommitDto {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  itemId: ").Append(ItemId).Append("\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  branchName: ").Append(BranchName).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  commitId: ").Append(CommitId).Append("\n");
            sb.Append("  commitShortId: ").Append(CommitShortId).Append("\n");
            sb.Append("  commitMsg: ").Append(CommitMsg).Append("\n");
            sb.Append("  commitUrl: ").Append(CommitUrl).Append("\n");
            sb.Append("  iamId: ").Append(IamId).Append("\n");
            sb.Append("  createAt: ").Append(CreateAt).Append("\n");
            sb.Append("  updateAt: ").Append(UpdateAt).Append("\n");
            sb.Append("  itemUrl: ").Append(ItemUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ItemCommitDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ItemCommitDto input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.Result != input.Result || (this.Result != null && !this.Result.Equals(input.Result))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.ItemId != input.ItemId || (this.ItemId != null && !this.ItemId.Equals(input.ItemId))) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.BranchName != input.BranchName || (this.BranchName != null && !this.BranchName.Equals(input.BranchName))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.CommitId != input.CommitId || (this.CommitId != null && !this.CommitId.Equals(input.CommitId))) return false;
            if (this.CommitShortId != input.CommitShortId || (this.CommitShortId != null && !this.CommitShortId.Equals(input.CommitShortId))) return false;
            if (this.CommitMsg != input.CommitMsg || (this.CommitMsg != null && !this.CommitMsg.Equals(input.CommitMsg))) return false;
            if (this.CommitUrl != input.CommitUrl || (this.CommitUrl != null && !this.CommitUrl.Equals(input.CommitUrl))) return false;
            if (this.IamId != input.IamId || (this.IamId != null && !this.IamId.Equals(input.IamId))) return false;
            if (this.CreateAt != input.CreateAt || (this.CreateAt != null && !this.CreateAt.Equals(input.CreateAt))) return false;
            if (this.UpdateAt != input.UpdateAt || (this.UpdateAt != null && !this.UpdateAt.Equals(input.UpdateAt))) return false;
            if (this.ItemUrl != input.ItemUrl || (this.ItemUrl != null && !this.ItemUrl.Equals(input.ItemUrl))) return false;

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
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Result != null) hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.ItemId != null) hashCode = hashCode * 59 + this.ItemId.GetHashCode();
                if (this.RepositoryId != null) hashCode = hashCode * 59 + this.RepositoryId.GetHashCode();
                if (this.BranchName != null) hashCode = hashCode * 59 + this.BranchName.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.CommitId != null) hashCode = hashCode * 59 + this.CommitId.GetHashCode();
                if (this.CommitShortId != null) hashCode = hashCode * 59 + this.CommitShortId.GetHashCode();
                if (this.CommitMsg != null) hashCode = hashCode * 59 + this.CommitMsg.GetHashCode();
                if (this.CommitUrl != null) hashCode = hashCode * 59 + this.CommitUrl.GetHashCode();
                if (this.IamId != null) hashCode = hashCode * 59 + this.IamId.GetHashCode();
                if (this.CreateAt != null) hashCode = hashCode * 59 + this.CreateAt.GetHashCode();
                if (this.UpdateAt != null) hashCode = hashCode * 59 + this.UpdateAt.GetHashCode();
                if (this.ItemUrl != null) hashCode = hashCode * 59 + this.ItemUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
