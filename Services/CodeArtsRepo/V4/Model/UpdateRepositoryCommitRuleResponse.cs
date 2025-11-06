using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UpdateRepositoryCommitRuleResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 主键ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** 仓库ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepositoryId { get; set; }

        /// <summary>
        /// **参数解释：** 提交信息匹配规则。
        /// </summary>
        [JsonProperty("commit_message_regex", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitMessageRegex { get; set; }

        /// <summary>
        /// **参数解释：** 提交信息负面匹配规则。
        /// </summary>
        [JsonProperty("commit_message_negative_regex", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitMessageNegativeRegex { get; set; }

        /// <summary>
        /// **参数解释：** 禁止提交的文件名称。
        /// </summary>
        [JsonProperty("prohibited_file_name_regex", NullValueHandling = NullValueHandling.Ignore)]
        public string ProhibitedFileNameRegex { get; set; }

        /// <summary>
        /// **参数解释：** 提交人邮箱地址。
        /// </summary>
        [JsonProperty("author_email_regex", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorEmailRegex { get; set; }

        /// <summary>
        /// **参数解释：** 单文件大小限制（MB）。
        /// </summary>
        [JsonProperty("max_file_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxFileSize { get; set; }

        /// <summary>
        /// **参数解释：** 允许的最大单文件大小（MB）。
        /// </summary>
        [JsonProperty("allowed_max_file_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? AllowedMaxFileSize { get; set; }

        /// <summary>
        /// **参数解释：** 规则生效时间。
        /// </summary>
        [JsonProperty("effective_date", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectiveDate { get; set; }

        /// <summary>
        /// **参数解释：** 是否禁止新增二进制文件（对特权用户无效）。 **约束限制：** 不涉及。 **取值范围：** - true，禁止新增二进制文件。 - false，允许新增二进制文件。
        /// </summary>
        [JsonProperty("binary_gate_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BinaryGateEnabled { get; set; }

        /// <summary>
        /// **参数解释：** 特权用户（特权用户可直接推送所有二进制文件入库）。
        /// </summary>
        [JsonProperty("privileged_users", NullValueHandling = NullValueHandling.Ignore)]
        public List<RepositoryUserBasicDto> PrivilegedUsers { get; set; }

        /// <summary>
        /// **参数解释：** 是否允许修改二进制文件（对特权用户无效）。 **约束限制：** 不涉及。 **取值范围：** - true，允许修改二进制文件。 - false，禁止修改二进制文件。
        /// </summary>
        [JsonProperty("allowed_modify_binary", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowedModifyBinary { get; set; }

        /// <summary>
        /// **参数解释：** 二进制文件白名单（可直接入库的文件）。
        /// </summary>
        [JsonProperty("allowed_binary_file_name_regex", NullValueHandling = NullValueHandling.Ignore)]
        public string AllowedBinaryFileNameRegex { get; set; }

        /// <summary>
        /// **参数解释：** 提交人。
        /// </summary>
        [JsonProperty("author_regex", NullValueHandling = NullValueHandling.Ignore)]
        public Object AuthorRegex { get; set; }

        /// <summary>
        /// **参数解释：** 更新时间。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// **参数解释：** 规则名称。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 分支规则。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("branch_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchName { get; set; }

        /// <summary>
        /// **参数解释：** 创建时间。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// **参数解释：** 跳过规则检测。 **约束限制：** 仅CR仓库支持此参数。
        /// </summary>
        [JsonProperty("skip_rule_check", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SkipRuleCheck { get; set; }

        /// <summary>
        /// **参数解释：** 跳过规则检测失效时间， 例如: 2025-8-19。 **约束限制：** 仅CR仓库支持此参数。
        /// </summary>
        [JsonProperty("skip_rule_end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string SkipRuleEndDate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateRepositoryCommitRuleResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  commitMessageRegex: ").Append(CommitMessageRegex).Append("\n");
            sb.Append("  commitMessageNegativeRegex: ").Append(CommitMessageNegativeRegex).Append("\n");
            sb.Append("  prohibitedFileNameRegex: ").Append(ProhibitedFileNameRegex).Append("\n");
            sb.Append("  authorEmailRegex: ").Append(AuthorEmailRegex).Append("\n");
            sb.Append("  maxFileSize: ").Append(MaxFileSize).Append("\n");
            sb.Append("  allowedMaxFileSize: ").Append(AllowedMaxFileSize).Append("\n");
            sb.Append("  effectiveDate: ").Append(EffectiveDate).Append("\n");
            sb.Append("  binaryGateEnabled: ").Append(BinaryGateEnabled).Append("\n");
            sb.Append("  privilegedUsers: ").Append(PrivilegedUsers).Append("\n");
            sb.Append("  allowedModifyBinary: ").Append(AllowedModifyBinary).Append("\n");
            sb.Append("  allowedBinaryFileNameRegex: ").Append(AllowedBinaryFileNameRegex).Append("\n");
            sb.Append("  authorRegex: ").Append(AuthorRegex).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  branchName: ").Append(BranchName).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  skipRuleCheck: ").Append(SkipRuleCheck).Append("\n");
            sb.Append("  skipRuleEndDate: ").Append(SkipRuleEndDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateRepositoryCommitRuleResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateRepositoryCommitRuleResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.CommitMessageRegex != input.CommitMessageRegex || (this.CommitMessageRegex != null && !this.CommitMessageRegex.Equals(input.CommitMessageRegex))) return false;
            if (this.CommitMessageNegativeRegex != input.CommitMessageNegativeRegex || (this.CommitMessageNegativeRegex != null && !this.CommitMessageNegativeRegex.Equals(input.CommitMessageNegativeRegex))) return false;
            if (this.ProhibitedFileNameRegex != input.ProhibitedFileNameRegex || (this.ProhibitedFileNameRegex != null && !this.ProhibitedFileNameRegex.Equals(input.ProhibitedFileNameRegex))) return false;
            if (this.AuthorEmailRegex != input.AuthorEmailRegex || (this.AuthorEmailRegex != null && !this.AuthorEmailRegex.Equals(input.AuthorEmailRegex))) return false;
            if (this.MaxFileSize != input.MaxFileSize || (this.MaxFileSize != null && !this.MaxFileSize.Equals(input.MaxFileSize))) return false;
            if (this.AllowedMaxFileSize != input.AllowedMaxFileSize || (this.AllowedMaxFileSize != null && !this.AllowedMaxFileSize.Equals(input.AllowedMaxFileSize))) return false;
            if (this.EffectiveDate != input.EffectiveDate || (this.EffectiveDate != null && !this.EffectiveDate.Equals(input.EffectiveDate))) return false;
            if (this.BinaryGateEnabled != input.BinaryGateEnabled || (this.BinaryGateEnabled != null && !this.BinaryGateEnabled.Equals(input.BinaryGateEnabled))) return false;
            if (this.PrivilegedUsers != input.PrivilegedUsers || (this.PrivilegedUsers != null && input.PrivilegedUsers != null && !this.PrivilegedUsers.SequenceEqual(input.PrivilegedUsers))) return false;
            if (this.AllowedModifyBinary != input.AllowedModifyBinary || (this.AllowedModifyBinary != null && !this.AllowedModifyBinary.Equals(input.AllowedModifyBinary))) return false;
            if (this.AllowedBinaryFileNameRegex != input.AllowedBinaryFileNameRegex || (this.AllowedBinaryFileNameRegex != null && !this.AllowedBinaryFileNameRegex.Equals(input.AllowedBinaryFileNameRegex))) return false;
            if (this.AuthorRegex != input.AuthorRegex || (this.AuthorRegex != null && !this.AuthorRegex.Equals(input.AuthorRegex))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.BranchName != input.BranchName || (this.BranchName != null && !this.BranchName.Equals(input.BranchName))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.SkipRuleCheck != input.SkipRuleCheck || (this.SkipRuleCheck != null && !this.SkipRuleCheck.Equals(input.SkipRuleCheck))) return false;
            if (this.SkipRuleEndDate != input.SkipRuleEndDate || (this.SkipRuleEndDate != null && !this.SkipRuleEndDate.Equals(input.SkipRuleEndDate))) return false;

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
                if (this.RepositoryId != null) hashCode = hashCode * 59 + this.RepositoryId.GetHashCode();
                if (this.CommitMessageRegex != null) hashCode = hashCode * 59 + this.CommitMessageRegex.GetHashCode();
                if (this.CommitMessageNegativeRegex != null) hashCode = hashCode * 59 + this.CommitMessageNegativeRegex.GetHashCode();
                if (this.ProhibitedFileNameRegex != null) hashCode = hashCode * 59 + this.ProhibitedFileNameRegex.GetHashCode();
                if (this.AuthorEmailRegex != null) hashCode = hashCode * 59 + this.AuthorEmailRegex.GetHashCode();
                if (this.MaxFileSize != null) hashCode = hashCode * 59 + this.MaxFileSize.GetHashCode();
                if (this.AllowedMaxFileSize != null) hashCode = hashCode * 59 + this.AllowedMaxFileSize.GetHashCode();
                if (this.EffectiveDate != null) hashCode = hashCode * 59 + this.EffectiveDate.GetHashCode();
                if (this.BinaryGateEnabled != null) hashCode = hashCode * 59 + this.BinaryGateEnabled.GetHashCode();
                if (this.PrivilegedUsers != null) hashCode = hashCode * 59 + this.PrivilegedUsers.GetHashCode();
                if (this.AllowedModifyBinary != null) hashCode = hashCode * 59 + this.AllowedModifyBinary.GetHashCode();
                if (this.AllowedBinaryFileNameRegex != null) hashCode = hashCode * 59 + this.AllowedBinaryFileNameRegex.GetHashCode();
                if (this.AuthorRegex != null) hashCode = hashCode * 59 + this.AuthorRegex.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.BranchName != null) hashCode = hashCode * 59 + this.BranchName.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.SkipRuleCheck != null) hashCode = hashCode * 59 + this.SkipRuleCheck.GetHashCode();
                if (this.SkipRuleEndDate != null) hashCode = hashCode * 59 + this.SkipRuleEndDate.GetHashCode();
                return hashCode;
            }
        }
    }
}
