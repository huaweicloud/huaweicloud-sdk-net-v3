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
    /// Response Object
    /// </summary>
    public class ShowGroupSettingsInheritCfgResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 是否可用。
        /// </summary>
        [JsonProperty("can_update", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanUpdate { get; set; }

        /// <summary>
        /// **参数解释：** 记录id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** 项目id。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// **参数解释：** 代码组id。
        /// </summary>
        [JsonProperty("namespace_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? NamespaceId { get; set; }

        /// <summary>
        /// **参数解释：** 父id。
        /// </summary>
        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ParentId { get; set; }

        /// <summary>
        /// **参数解释：** 排序id。
        /// </summary>
        [JsonProperty("ownership", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ownership { get; set; }

        /// <summary>
        /// **参数解释：** 排序id。
        /// </summary>
        [JsonProperty("pbi", NullValueHandling = NullValueHandling.Ignore)]
        public int? Pbi { get; set; }

        /// <summary>
        /// **参数解释：** 保护分支策略。
        /// </summary>
        [JsonProperty("protected_branches", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProtectedBranches { get; set; }

        /// <summary>
        /// **参数解释：** 保护tag策略。
        /// </summary>
        [JsonProperty("protected_tags", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProtectedTags { get; set; }

        /// <summary>
        /// **参数解释：** 推送规则策略。
        /// </summary>
        [JsonProperty("push_rules", NullValueHandling = NullValueHandling.Ignore)]
        public int? PushRules { get; set; }

        /// <summary>
        /// **参数解释：** cr策略。
        /// </summary>
        [JsonProperty("change_requests", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChangeRequests { get; set; }

        /// <summary>
        /// **参数解释：** 排序id。
        /// </summary>
        [JsonProperty("custom_ctrl_items", NullValueHandling = NullValueHandling.Ignore)]
        public int? CustomCtrlItems { get; set; }

        /// <summary>
        /// **参数解释：** 排序id。
        /// </summary>
        [JsonProperty("reviews", NullValueHandling = NullValueHandling.Ignore)]
        public int? Reviews { get; set; }

        /// <summary>
        /// **参数解释：** issue继承模式。
        /// </summary>
        [JsonProperty("issues", NullValueHandling = NullValueHandling.Ignore)]
        public int? Issues { get; set; }

        /// <summary>
        /// **参数解释：** 排序id。
        /// </summary>
        [JsonProperty("cr_evaluation", NullValueHandling = NullValueHandling.Ignore)]
        public int? CrEvaluation { get; set; }

        /// <summary>
        /// **参数解释：** e2e策略。
        /// </summary>
        [JsonProperty("e2e_settings", NullValueHandling = NullValueHandling.Ignore)]
        public int? E2eSettings { get; set; }

        /// <summary>
        /// **参数解释：** 提交策略。
        /// </summary>
        [JsonProperty("committer_settings", NullValueHandling = NullValueHandling.Ignore)]
        public int? CommitterSettings { get; set; }

        /// <summary>
        /// **参数解释：** webhook策略。
        /// </summary>
        [JsonProperty("webhook_settings", NullValueHandling = NullValueHandling.Ignore)]
        public int? WebhookSettings { get; set; }

        /// <summary>
        /// **参数解释：** 排序id。
        /// </summary>
        [JsonProperty("stream_event_settings", NullValueHandling = NullValueHandling.Ignore)]
        public int? StreamEventSettings { get; set; }

        /// <summary>
        /// **参数解释：** 排序id。
        /// </summary>
        [JsonProperty("pipeline_settings", NullValueHandling = NullValueHandling.Ignore)]
        public int? PipelineSettings { get; set; }

        /// <summary>
        /// **参数解释：** issue模板继承模式。
        /// </summary>
        [JsonProperty("issue_templates", NullValueHandling = NullValueHandling.Ignore)]
        public int? IssueTemplates { get; set; }

        /// <summary>
        /// **参数解释：** 排序id。
        /// </summary>
        [JsonProperty("cr_comment_emplates", NullValueHandling = NullValueHandling.Ignore)]
        public int? CrCommentEmplates { get; set; }

        /// <summary>
        /// **参数解释：** 排序id。
        /// </summary>
        [JsonProperty("merge_requests", NullValueHandling = NullValueHandling.Ignore)]
        public int? MergeRequests { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求策略。
        /// </summary>
        [JsonProperty("mr_branch_policies", NullValueHandling = NullValueHandling.Ignore)]
        public int? MrBranchPolicies { get; set; }

        /// <summary>
        /// **参数解释：** 仓库策略。
        /// </summary>
        [JsonProperty("repository_settings", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepositorySettings { get; set; }

        /// <summary>
        /// **参数解释：** 部署秘钥策略。
        /// </summary>
        [JsonProperty("deploy_keys", NullValueHandling = NullValueHandling.Ignore)]
        public int? DeployKeys { get; set; }

        /// <summary>
        /// **参数解释：** 水印策略。
        /// </summary>
        [JsonProperty("watermark", NullValueHandling = NullValueHandling.Ignore)]
        public int? Watermark { get; set; }

        /// <summary>
        /// **参数解释：** 创建时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// **参数解释：** 更新时间。
        /// </summary>
        [JsonProperty("update_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowGroupSettingsInheritCfgResponse {\n");
            sb.Append("  canUpdate: ").Append(CanUpdate).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  namespaceId: ").Append(NamespaceId).Append("\n");
            sb.Append("  parentId: ").Append(ParentId).Append("\n");
            sb.Append("  ownership: ").Append(Ownership).Append("\n");
            sb.Append("  pbi: ").Append(Pbi).Append("\n");
            sb.Append("  protectedBranches: ").Append(ProtectedBranches).Append("\n");
            sb.Append("  protectedTags: ").Append(ProtectedTags).Append("\n");
            sb.Append("  pushRules: ").Append(PushRules).Append("\n");
            sb.Append("  changeRequests: ").Append(ChangeRequests).Append("\n");
            sb.Append("  customCtrlItems: ").Append(CustomCtrlItems).Append("\n");
            sb.Append("  reviews: ").Append(Reviews).Append("\n");
            sb.Append("  issues: ").Append(Issues).Append("\n");
            sb.Append("  crEvaluation: ").Append(CrEvaluation).Append("\n");
            sb.Append("  e2eSettings: ").Append(E2eSettings).Append("\n");
            sb.Append("  committerSettings: ").Append(CommitterSettings).Append("\n");
            sb.Append("  webhookSettings: ").Append(WebhookSettings).Append("\n");
            sb.Append("  streamEventSettings: ").Append(StreamEventSettings).Append("\n");
            sb.Append("  pipelineSettings: ").Append(PipelineSettings).Append("\n");
            sb.Append("  issueTemplates: ").Append(IssueTemplates).Append("\n");
            sb.Append("  crCommentEmplates: ").Append(CrCommentEmplates).Append("\n");
            sb.Append("  mergeRequests: ").Append(MergeRequests).Append("\n");
            sb.Append("  mrBranchPolicies: ").Append(MrBranchPolicies).Append("\n");
            sb.Append("  repositorySettings: ").Append(RepositorySettings).Append("\n");
            sb.Append("  deployKeys: ").Append(DeployKeys).Append("\n");
            sb.Append("  watermark: ").Append(Watermark).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updateAt: ").Append(UpdateAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowGroupSettingsInheritCfgResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowGroupSettingsInheritCfgResponse input)
        {
            if (input == null) return false;
            if (this.CanUpdate != input.CanUpdate || (this.CanUpdate != null && !this.CanUpdate.Equals(input.CanUpdate))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.NamespaceId != input.NamespaceId || (this.NamespaceId != null && !this.NamespaceId.Equals(input.NamespaceId))) return false;
            if (this.ParentId != input.ParentId || (this.ParentId != null && !this.ParentId.Equals(input.ParentId))) return false;
            if (this.Ownership != input.Ownership || (this.Ownership != null && !this.Ownership.Equals(input.Ownership))) return false;
            if (this.Pbi != input.Pbi || (this.Pbi != null && !this.Pbi.Equals(input.Pbi))) return false;
            if (this.ProtectedBranches != input.ProtectedBranches || (this.ProtectedBranches != null && !this.ProtectedBranches.Equals(input.ProtectedBranches))) return false;
            if (this.ProtectedTags != input.ProtectedTags || (this.ProtectedTags != null && !this.ProtectedTags.Equals(input.ProtectedTags))) return false;
            if (this.PushRules != input.PushRules || (this.PushRules != null && !this.PushRules.Equals(input.PushRules))) return false;
            if (this.ChangeRequests != input.ChangeRequests || (this.ChangeRequests != null && !this.ChangeRequests.Equals(input.ChangeRequests))) return false;
            if (this.CustomCtrlItems != input.CustomCtrlItems || (this.CustomCtrlItems != null && !this.CustomCtrlItems.Equals(input.CustomCtrlItems))) return false;
            if (this.Reviews != input.Reviews || (this.Reviews != null && !this.Reviews.Equals(input.Reviews))) return false;
            if (this.Issues != input.Issues || (this.Issues != null && !this.Issues.Equals(input.Issues))) return false;
            if (this.CrEvaluation != input.CrEvaluation || (this.CrEvaluation != null && !this.CrEvaluation.Equals(input.CrEvaluation))) return false;
            if (this.E2eSettings != input.E2eSettings || (this.E2eSettings != null && !this.E2eSettings.Equals(input.E2eSettings))) return false;
            if (this.CommitterSettings != input.CommitterSettings || (this.CommitterSettings != null && !this.CommitterSettings.Equals(input.CommitterSettings))) return false;
            if (this.WebhookSettings != input.WebhookSettings || (this.WebhookSettings != null && !this.WebhookSettings.Equals(input.WebhookSettings))) return false;
            if (this.StreamEventSettings != input.StreamEventSettings || (this.StreamEventSettings != null && !this.StreamEventSettings.Equals(input.StreamEventSettings))) return false;
            if (this.PipelineSettings != input.PipelineSettings || (this.PipelineSettings != null && !this.PipelineSettings.Equals(input.PipelineSettings))) return false;
            if (this.IssueTemplates != input.IssueTemplates || (this.IssueTemplates != null && !this.IssueTemplates.Equals(input.IssueTemplates))) return false;
            if (this.CrCommentEmplates != input.CrCommentEmplates || (this.CrCommentEmplates != null && !this.CrCommentEmplates.Equals(input.CrCommentEmplates))) return false;
            if (this.MergeRequests != input.MergeRequests || (this.MergeRequests != null && !this.MergeRequests.Equals(input.MergeRequests))) return false;
            if (this.MrBranchPolicies != input.MrBranchPolicies || (this.MrBranchPolicies != null && !this.MrBranchPolicies.Equals(input.MrBranchPolicies))) return false;
            if (this.RepositorySettings != input.RepositorySettings || (this.RepositorySettings != null && !this.RepositorySettings.Equals(input.RepositorySettings))) return false;
            if (this.DeployKeys != input.DeployKeys || (this.DeployKeys != null && !this.DeployKeys.Equals(input.DeployKeys))) return false;
            if (this.Watermark != input.Watermark || (this.Watermark != null && !this.Watermark.Equals(input.Watermark))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdateAt != input.UpdateAt || (this.UpdateAt != null && !this.UpdateAt.Equals(input.UpdateAt))) return false;

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
                if (this.CanUpdate != null) hashCode = hashCode * 59 + this.CanUpdate.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.NamespaceId != null) hashCode = hashCode * 59 + this.NamespaceId.GetHashCode();
                if (this.ParentId != null) hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.Ownership != null) hashCode = hashCode * 59 + this.Ownership.GetHashCode();
                if (this.Pbi != null) hashCode = hashCode * 59 + this.Pbi.GetHashCode();
                if (this.ProtectedBranches != null) hashCode = hashCode * 59 + this.ProtectedBranches.GetHashCode();
                if (this.ProtectedTags != null) hashCode = hashCode * 59 + this.ProtectedTags.GetHashCode();
                if (this.PushRules != null) hashCode = hashCode * 59 + this.PushRules.GetHashCode();
                if (this.ChangeRequests != null) hashCode = hashCode * 59 + this.ChangeRequests.GetHashCode();
                if (this.CustomCtrlItems != null) hashCode = hashCode * 59 + this.CustomCtrlItems.GetHashCode();
                if (this.Reviews != null) hashCode = hashCode * 59 + this.Reviews.GetHashCode();
                if (this.Issues != null) hashCode = hashCode * 59 + this.Issues.GetHashCode();
                if (this.CrEvaluation != null) hashCode = hashCode * 59 + this.CrEvaluation.GetHashCode();
                if (this.E2eSettings != null) hashCode = hashCode * 59 + this.E2eSettings.GetHashCode();
                if (this.CommitterSettings != null) hashCode = hashCode * 59 + this.CommitterSettings.GetHashCode();
                if (this.WebhookSettings != null) hashCode = hashCode * 59 + this.WebhookSettings.GetHashCode();
                if (this.StreamEventSettings != null) hashCode = hashCode * 59 + this.StreamEventSettings.GetHashCode();
                if (this.PipelineSettings != null) hashCode = hashCode * 59 + this.PipelineSettings.GetHashCode();
                if (this.IssueTemplates != null) hashCode = hashCode * 59 + this.IssueTemplates.GetHashCode();
                if (this.CrCommentEmplates != null) hashCode = hashCode * 59 + this.CrCommentEmplates.GetHashCode();
                if (this.MergeRequests != null) hashCode = hashCode * 59 + this.MergeRequests.GetHashCode();
                if (this.MrBranchPolicies != null) hashCode = hashCode * 59 + this.MrBranchPolicies.GetHashCode();
                if (this.RepositorySettings != null) hashCode = hashCode * 59 + this.RepositorySettings.GetHashCode();
                if (this.DeployKeys != null) hashCode = hashCode * 59 + this.DeployKeys.GetHashCode();
                if (this.Watermark != null) hashCode = hashCode * 59 + this.Watermark.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdateAt != null) hashCode = hashCode * 59 + this.UpdateAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
