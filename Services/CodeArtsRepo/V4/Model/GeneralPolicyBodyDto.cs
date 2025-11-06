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
    /// 
    /// </summary>
    public class GeneralPolicyBodyDto 
    {

        /// <summary>
        /// **参数解释：** 是否禁止fork该仓库。 **约束限制：** 不涉及。 **取值范围：** - true，禁止fork。 - false，允许fork。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("disable_fork", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisableFork { get; set; }

        /// <summary>
        /// **参数解释：** 是否预合并MR。 **约束限制：** 不涉及。 **取值范围：** - true，禁止预合并MR。 - false，允许预合并MR。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("generate_pre_merge_ref", NullValueHandling = NullValueHandling.Ignore)]
        public bool? GeneratePreMergeRef { get; set; }

        /// <summary>
        /// **参数解释：** 分支名规则。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("branch_name_regex", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchNameRegex { get; set; }

        /// <summary>
        /// **参数解释：** Tag名规则。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("tag_name_regex", NullValueHandling = NullValueHandling.Ignore)]
        public string TagNameRegex { get; set; }

        /// <summary>
        /// **参数解释：** 是否禁止开发者创建分支。 **约束限制：** 不涉及。 **取值范围：** - true，禁止开发者创建分支。 - false，允许开发者创建分支。
        /// </summary>
        [JsonProperty("forbidden_developer_create_branch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForbiddenDeveloperCreateBranch { get; set; }

        /// <summary>
        /// **参数解释：** 开发人员创建分支权限例外白名单。多个用户ID使用逗号分隔。
        /// </summary>
        [JsonProperty("create_branch_whitelist_user_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateBranchWhitelistUserIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeneralPolicyBodyDto {\n");
            sb.Append("  disableFork: ").Append(DisableFork).Append("\n");
            sb.Append("  generatePreMergeRef: ").Append(GeneratePreMergeRef).Append("\n");
            sb.Append("  branchNameRegex: ").Append(BranchNameRegex).Append("\n");
            sb.Append("  tagNameRegex: ").Append(TagNameRegex).Append("\n");
            sb.Append("  forbiddenDeveloperCreateBranch: ").Append(ForbiddenDeveloperCreateBranch).Append("\n");
            sb.Append("  createBranchWhitelistUserIds: ").Append(CreateBranchWhitelistUserIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GeneralPolicyBodyDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GeneralPolicyBodyDto input)
        {
            if (input == null) return false;
            if (this.DisableFork != input.DisableFork || (this.DisableFork != null && !this.DisableFork.Equals(input.DisableFork))) return false;
            if (this.GeneratePreMergeRef != input.GeneratePreMergeRef || (this.GeneratePreMergeRef != null && !this.GeneratePreMergeRef.Equals(input.GeneratePreMergeRef))) return false;
            if (this.BranchNameRegex != input.BranchNameRegex || (this.BranchNameRegex != null && !this.BranchNameRegex.Equals(input.BranchNameRegex))) return false;
            if (this.TagNameRegex != input.TagNameRegex || (this.TagNameRegex != null && !this.TagNameRegex.Equals(input.TagNameRegex))) return false;
            if (this.ForbiddenDeveloperCreateBranch != input.ForbiddenDeveloperCreateBranch || (this.ForbiddenDeveloperCreateBranch != null && !this.ForbiddenDeveloperCreateBranch.Equals(input.ForbiddenDeveloperCreateBranch))) return false;
            if (this.CreateBranchWhitelistUserIds != input.CreateBranchWhitelistUserIds || (this.CreateBranchWhitelistUserIds != null && !this.CreateBranchWhitelistUserIds.Equals(input.CreateBranchWhitelistUserIds))) return false;

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
                if (this.GeneratePreMergeRef != null) hashCode = hashCode * 59 + this.GeneratePreMergeRef.GetHashCode();
                if (this.BranchNameRegex != null) hashCode = hashCode * 59 + this.BranchNameRegex.GetHashCode();
                if (this.TagNameRegex != null) hashCode = hashCode * 59 + this.TagNameRegex.GetHashCode();
                if (this.ForbiddenDeveloperCreateBranch != null) hashCode = hashCode * 59 + this.ForbiddenDeveloperCreateBranch.GetHashCode();
                if (this.CreateBranchWhitelistUserIds != null) hashCode = hashCode * 59 + this.CreateBranchWhitelistUserIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
