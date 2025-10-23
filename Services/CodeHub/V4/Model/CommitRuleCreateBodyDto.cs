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
    public class CommitRuleCreateBodyDto 
    {

        /// <summary>
        /// **参数解释：** 规则名称。 **约束限制：** 必填。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 分支规则。 **约束限制：** 必填。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("branch_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchName { get; set; }

        /// <summary>
        /// **参数解释：** 提交信息匹配规则。 所有提交消息都必须进行正则表达式匹配， 例如: \\d+\\..*。 若符合正则匹配，则允许提交。若此字段为空，则允许任何提交消息。 您也可以设置在提交信息中必须包含工作项单号，实现代码的E2E追溯。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("commit_message_regex", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitMessageRegex { get; set; }

        /// <summary>
        /// **参数解释：** 提交信息负面匹配规则。 所有提交消息都必须进行正则表达式匹配，例如: \\d+\\..*。 符合正则匹配，则不允许提交。若此字段为空，则允许任何提交消息。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("commit_message_negative_regex", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitMessageNegativeRegex { get; set; }

        /// <summary>
        /// **参数解释：** 提交人的正则表达式。 提交人必须进行正则表达式匹配， 例如: /([a-zA-Z]\\d){7}/。如果此字段为空，则允许任何提交人。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("author_regex", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorRegex { get; set; }

        /// <summary>
        /// **参数解释：** 提交人邮箱地址的正则表达式。 所有提交者邮箱地址都必须进行正则表达式匹配， 例如: @my-company.com$。如果此字段为空，则允许任何提交邮箱地址。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("author_email_regex", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorEmailRegex { get; set; }

        /// <summary>
        /// **参数解释：** 禁止提交的文件名称的正则表达式。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("prohibited_file_name_regex", NullValueHandling = NullValueHandling.Ignore)]
        public string ProhibitedFileNameRegex { get; set; }

        /// <summary>
        /// **参数解释：** 单文件大小限制（MB）。 单文件大小超过上述规格的添加或更新推送将被拒绝，Repo建议的最佳上限值为50MB。 系统支持单文件提交的最大值为300MB。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 50
        /// </summary>
        [JsonProperty("max_file_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxFileSize { get; set; }

        /// <summary>
        /// **参数解释：** 禁止新增二进制文件（对特权用户无效）。 **约束限制：** 不涉及。 **取值范围：** - true，禁止新增二进制文件。 - false，允许新增二进制文件。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("binary_gate_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BinaryGateEnabled { get; set; }

        /// <summary>
        /// **参数解释：** 允许修改二进制文件（对特权用户无效）。 **约束限制：** 不涉及。 **取值范围：** - true，允许修改二进制文件。 - false，禁止修改二进制文件。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("allowed_modify_binary", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowedModifyBinary { get; set; }

        /// <summary>
        /// **参数解释：** 二进制文件白名单（可直接入库的文件）。 所有被推送的二进制文件名必须进行正则表达式匹配， 例如: (\\.png|\\.xls|\\.xlsx|\\.docx|\\.doc)$ 。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("allowed_binary_file_name_regex", NullValueHandling = NullValueHandling.Ignore)]
        public string AllowedBinaryFileNameRegex { get; set; }

        /// <summary>
        /// **参数解释：** 特权用户ID列表（特权用户可直接推送所有二进制文件入库。 只有特权用户能推送二进制文件。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("privileged_user_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> PrivilegedUserIds { get; set; }

        /// <summary>
        /// **参数解释：** 规则生效时间， 例如: 2025-8-19。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("effective_date", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectiveDate { get; set; }

        /// <summary>
        /// **参数解释：** 跳过规则检测。 **约束限制：** 仅CR仓库支持此参数。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("skip_rule_check", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SkipRuleCheck { get; set; }

        /// <summary>
        /// **参数解释：** 跳过规则检测失效时间， 例如: 2025-8-19 10:00:00。 **约束限制：** 仅CR仓库支持此参数。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("skip_rule_end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string SkipRuleEndDate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommitRuleCreateBodyDto {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  branchName: ").Append(BranchName).Append("\n");
            sb.Append("  commitMessageRegex: ").Append(CommitMessageRegex).Append("\n");
            sb.Append("  commitMessageNegativeRegex: ").Append(CommitMessageNegativeRegex).Append("\n");
            sb.Append("  authorRegex: ").Append(AuthorRegex).Append("\n");
            sb.Append("  authorEmailRegex: ").Append(AuthorEmailRegex).Append("\n");
            sb.Append("  prohibitedFileNameRegex: ").Append(ProhibitedFileNameRegex).Append("\n");
            sb.Append("  maxFileSize: ").Append(MaxFileSize).Append("\n");
            sb.Append("  binaryGateEnabled: ").Append(BinaryGateEnabled).Append("\n");
            sb.Append("  allowedModifyBinary: ").Append(AllowedModifyBinary).Append("\n");
            sb.Append("  allowedBinaryFileNameRegex: ").Append(AllowedBinaryFileNameRegex).Append("\n");
            sb.Append("  privilegedUserIds: ").Append(PrivilegedUserIds).Append("\n");
            sb.Append("  effectiveDate: ").Append(EffectiveDate).Append("\n");
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
            return this.Equals(input as CommitRuleCreateBodyDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CommitRuleCreateBodyDto input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.BranchName != input.BranchName || (this.BranchName != null && !this.BranchName.Equals(input.BranchName))) return false;
            if (this.CommitMessageRegex != input.CommitMessageRegex || (this.CommitMessageRegex != null && !this.CommitMessageRegex.Equals(input.CommitMessageRegex))) return false;
            if (this.CommitMessageNegativeRegex != input.CommitMessageNegativeRegex || (this.CommitMessageNegativeRegex != null && !this.CommitMessageNegativeRegex.Equals(input.CommitMessageNegativeRegex))) return false;
            if (this.AuthorRegex != input.AuthorRegex || (this.AuthorRegex != null && !this.AuthorRegex.Equals(input.AuthorRegex))) return false;
            if (this.AuthorEmailRegex != input.AuthorEmailRegex || (this.AuthorEmailRegex != null && !this.AuthorEmailRegex.Equals(input.AuthorEmailRegex))) return false;
            if (this.ProhibitedFileNameRegex != input.ProhibitedFileNameRegex || (this.ProhibitedFileNameRegex != null && !this.ProhibitedFileNameRegex.Equals(input.ProhibitedFileNameRegex))) return false;
            if (this.MaxFileSize != input.MaxFileSize || (this.MaxFileSize != null && !this.MaxFileSize.Equals(input.MaxFileSize))) return false;
            if (this.BinaryGateEnabled != input.BinaryGateEnabled || (this.BinaryGateEnabled != null && !this.BinaryGateEnabled.Equals(input.BinaryGateEnabled))) return false;
            if (this.AllowedModifyBinary != input.AllowedModifyBinary || (this.AllowedModifyBinary != null && !this.AllowedModifyBinary.Equals(input.AllowedModifyBinary))) return false;
            if (this.AllowedBinaryFileNameRegex != input.AllowedBinaryFileNameRegex || (this.AllowedBinaryFileNameRegex != null && !this.AllowedBinaryFileNameRegex.Equals(input.AllowedBinaryFileNameRegex))) return false;
            if (this.PrivilegedUserIds != input.PrivilegedUserIds || (this.PrivilegedUserIds != null && input.PrivilegedUserIds != null && !this.PrivilegedUserIds.SequenceEqual(input.PrivilegedUserIds))) return false;
            if (this.EffectiveDate != input.EffectiveDate || (this.EffectiveDate != null && !this.EffectiveDate.Equals(input.EffectiveDate))) return false;
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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.BranchName != null) hashCode = hashCode * 59 + this.BranchName.GetHashCode();
                if (this.CommitMessageRegex != null) hashCode = hashCode * 59 + this.CommitMessageRegex.GetHashCode();
                if (this.CommitMessageNegativeRegex != null) hashCode = hashCode * 59 + this.CommitMessageNegativeRegex.GetHashCode();
                if (this.AuthorRegex != null) hashCode = hashCode * 59 + this.AuthorRegex.GetHashCode();
                if (this.AuthorEmailRegex != null) hashCode = hashCode * 59 + this.AuthorEmailRegex.GetHashCode();
                if (this.ProhibitedFileNameRegex != null) hashCode = hashCode * 59 + this.ProhibitedFileNameRegex.GetHashCode();
                if (this.MaxFileSize != null) hashCode = hashCode * 59 + this.MaxFileSize.GetHashCode();
                if (this.BinaryGateEnabled != null) hashCode = hashCode * 59 + this.BinaryGateEnabled.GetHashCode();
                if (this.AllowedModifyBinary != null) hashCode = hashCode * 59 + this.AllowedModifyBinary.GetHashCode();
                if (this.AllowedBinaryFileNameRegex != null) hashCode = hashCode * 59 + this.AllowedBinaryFileNameRegex.GetHashCode();
                if (this.PrivilegedUserIds != null) hashCode = hashCode * 59 + this.PrivilegedUserIds.GetHashCode();
                if (this.EffectiveDate != null) hashCode = hashCode * 59 + this.EffectiveDate.GetHashCode();
                if (this.SkipRuleCheck != null) hashCode = hashCode * 59 + this.SkipRuleCheck.GetHashCode();
                if (this.SkipRuleEndDate != null) hashCode = hashCode * 59 + this.SkipRuleEndDate.GetHashCode();
                return hashCode;
            }
        }
    }
}
