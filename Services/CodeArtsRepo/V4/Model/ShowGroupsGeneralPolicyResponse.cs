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
    public class ShowGroupsGeneralPolicyResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 是否禁用fork。
        /// </summary>
        [JsonProperty("disable_fork", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisableFork { get; set; }

        /// <summary>
        /// **参数解释：** 是否禁止开发者创建分支。
        /// </summary>
        [JsonProperty("forbidden_developer_create_branch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForbiddenDeveloperCreateBranch { get; set; }

        /// <summary>
        /// **参数解释：** 是否禁用开发者创建tag。
        /// </summary>
        [JsonProperty("forbidden_developer_create_tag", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForbiddenDeveloperCreateTag { get; set; }

        /// <summary>
        /// **参数解释：** 禁止开发者创建标签。
        /// </summary>
        [JsonProperty("forbidden_committer_create_branch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForbiddenCommitterCreateBranch { get; set; }

        /// <summary>
        /// **参数解释：** 分支名称正则表达式。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("branch_name_regex", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchNameRegex { get; set; }

        /// <summary>
        /// **参数解释：** 标签名正则表达式。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("tag_name_regex", NullValueHandling = NullValueHandling.Ignore)]
        public string TagNameRegex { get; set; }

        /// <summary>
        /// **参数解释：** 生成合并请求预合并。
        /// </summary>
        [JsonProperty("generate_pre_merge_ref", NullValueHandling = NullValueHandling.Ignore)]
        public bool? GeneratePreMergeRef { get; set; }

        /// <summary>
        /// **参数解释：** 是否禁止repo访问。
        /// </summary>
        [JsonProperty("forbidden_gitlab_access", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForbiddenGitlabAccess { get; set; }

        /// <summary>
        /// **参数解释：** MR rebase是否禁止触发webhook事件。
        /// </summary>
        [JsonProperty("rebase_disable_trigger_webhook", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RebaseDisableTriggerWebhook { get; set; }

        /// <summary>
        /// **参数解释：** 是否开启gpg公钥验证。
        /// </summary>
        [JsonProperty("open_gpg_verified", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OpenGpgVerified { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowGroupsGeneralPolicyResponse {\n");
            sb.Append("  disableFork: ").Append(DisableFork).Append("\n");
            sb.Append("  forbiddenDeveloperCreateBranch: ").Append(ForbiddenDeveloperCreateBranch).Append("\n");
            sb.Append("  forbiddenDeveloperCreateTag: ").Append(ForbiddenDeveloperCreateTag).Append("\n");
            sb.Append("  forbiddenCommitterCreateBranch: ").Append(ForbiddenCommitterCreateBranch).Append("\n");
            sb.Append("  branchNameRegex: ").Append(BranchNameRegex).Append("\n");
            sb.Append("  tagNameRegex: ").Append(TagNameRegex).Append("\n");
            sb.Append("  generatePreMergeRef: ").Append(GeneratePreMergeRef).Append("\n");
            sb.Append("  forbiddenGitlabAccess: ").Append(ForbiddenGitlabAccess).Append("\n");
            sb.Append("  rebaseDisableTriggerWebhook: ").Append(RebaseDisableTriggerWebhook).Append("\n");
            sb.Append("  openGpgVerified: ").Append(OpenGpgVerified).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowGroupsGeneralPolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowGroupsGeneralPolicyResponse input)
        {
            if (input == null) return false;
            if (this.DisableFork != input.DisableFork || (this.DisableFork != null && !this.DisableFork.Equals(input.DisableFork))) return false;
            if (this.ForbiddenDeveloperCreateBranch != input.ForbiddenDeveloperCreateBranch || (this.ForbiddenDeveloperCreateBranch != null && !this.ForbiddenDeveloperCreateBranch.Equals(input.ForbiddenDeveloperCreateBranch))) return false;
            if (this.ForbiddenDeveloperCreateTag != input.ForbiddenDeveloperCreateTag || (this.ForbiddenDeveloperCreateTag != null && !this.ForbiddenDeveloperCreateTag.Equals(input.ForbiddenDeveloperCreateTag))) return false;
            if (this.ForbiddenCommitterCreateBranch != input.ForbiddenCommitterCreateBranch || (this.ForbiddenCommitterCreateBranch != null && !this.ForbiddenCommitterCreateBranch.Equals(input.ForbiddenCommitterCreateBranch))) return false;
            if (this.BranchNameRegex != input.BranchNameRegex || (this.BranchNameRegex != null && !this.BranchNameRegex.Equals(input.BranchNameRegex))) return false;
            if (this.TagNameRegex != input.TagNameRegex || (this.TagNameRegex != null && !this.TagNameRegex.Equals(input.TagNameRegex))) return false;
            if (this.GeneratePreMergeRef != input.GeneratePreMergeRef || (this.GeneratePreMergeRef != null && !this.GeneratePreMergeRef.Equals(input.GeneratePreMergeRef))) return false;
            if (this.ForbiddenGitlabAccess != input.ForbiddenGitlabAccess || (this.ForbiddenGitlabAccess != null && !this.ForbiddenGitlabAccess.Equals(input.ForbiddenGitlabAccess))) return false;
            if (this.RebaseDisableTriggerWebhook != input.RebaseDisableTriggerWebhook || (this.RebaseDisableTriggerWebhook != null && !this.RebaseDisableTriggerWebhook.Equals(input.RebaseDisableTriggerWebhook))) return false;
            if (this.OpenGpgVerified != input.OpenGpgVerified || (this.OpenGpgVerified != null && !this.OpenGpgVerified.Equals(input.OpenGpgVerified))) return false;

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
                if (this.DisableFork != null) hashCode = hashCode * 59 + this.DisableFork.GetHashCode();
                if (this.ForbiddenDeveloperCreateBranch != null) hashCode = hashCode * 59 + this.ForbiddenDeveloperCreateBranch.GetHashCode();
                if (this.ForbiddenDeveloperCreateTag != null) hashCode = hashCode * 59 + this.ForbiddenDeveloperCreateTag.GetHashCode();
                if (this.ForbiddenCommitterCreateBranch != null) hashCode = hashCode * 59 + this.ForbiddenCommitterCreateBranch.GetHashCode();
                if (this.BranchNameRegex != null) hashCode = hashCode * 59 + this.BranchNameRegex.GetHashCode();
                if (this.TagNameRegex != null) hashCode = hashCode * 59 + this.TagNameRegex.GetHashCode();
                if (this.GeneratePreMergeRef != null) hashCode = hashCode * 59 + this.GeneratePreMergeRef.GetHashCode();
                if (this.ForbiddenGitlabAccess != null) hashCode = hashCode * 59 + this.ForbiddenGitlabAccess.GetHashCode();
                if (this.RebaseDisableTriggerWebhook != null) hashCode = hashCode * 59 + this.RebaseDisableTriggerWebhook.GetHashCode();
                if (this.OpenGpgVerified != null) hashCode = hashCode * 59 + this.OpenGpgVerified.GetHashCode();
                return hashCode;
            }
        }
    }
}
