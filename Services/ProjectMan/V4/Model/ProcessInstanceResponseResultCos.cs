using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ProcessInstanceResponseResultCos 
    {

        /// <summary>
        /// 区域
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 变更对象工作项类型，此处固定为CO
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// 评审单标题
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 变更对象状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("assignee", NullValueHandling = NullValueHandling.Ignore)]
        public ProcessInstanceResponseResultAssignee Assignee { get; set; }

        /// <summary>
        /// 评审单描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 变更对象关联的工作项编号
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public string Order { get; set; }

        /// <summary>
        /// 关联的变更评审标识
        /// </summary>
        [JsonProperty("co2cr", NullValueHandling = NullValueHandling.Ignore)]
        public string Co2cr { get; set; }

        /// <summary>
        /// 关联的基线评审标识
        /// </summary>
        [JsonProperty("co2br", NullValueHandling = NullValueHandling.Ignore)]
        public string Co2br { get; set; }

        /// <summary>
        /// 关联的通用评审标识
        /// </summary>
        [JsonProperty("co2gr", NullValueHandling = NullValueHandling.Ignore)]
        public string Co2gr { get; set; }

        /// <summary>
        /// 审批对象Id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 评审单类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 评审单工作状态，取值为\&quot;正在工作\&quot;,\&quot;作废\&quot;
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// 变更对象工作项修改前内容
        /// </summary>
        [JsonProperty("before_change", NullValueHandling = NullValueHandling.Ignore)]
        public string BeforeChange { get; set; }

        /// <summary>
        /// 变更对象修改后内容
        /// </summary>
        [JsonProperty("after_change", NullValueHandling = NullValueHandling.Ignore)]
        public string AfterChange { get; set; }

        /// <summary>
        /// 评审单最后修改人
        /// </summary>
        [JsonProperty("modified_by", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedBy { get; set; }

        /// <summary>
        /// 评审单最后修改时间
        /// </summary>
        [JsonProperty("modified_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedDate { get; set; }

        /// <summary>
        /// 评审单创建人
        /// </summary>
        [JsonProperty("created_by", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// 评审单创建时间
        /// </summary>
        [JsonProperty("created_date", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedDate { get; set; }

        /// <summary>
        /// 工作项所属租户ID，可通过[查询树状工作项](ShowIpdIssueTree.xml)接口获取，响应消息体中的**tenant_id**字段的值就是工作项所属租户id
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 工作项状态
        /// </summary>
        [JsonProperty("status_map", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusMap { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 源系统
        /// </summary>
        [JsonProperty("source_system", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceSystem { get; set; }

        /// <summary>
        /// 源系统链接
        /// </summary>
        [JsonProperty("source_system_link", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceSystemLink { get; set; }

        /// <summary>
        /// 变更对象关联的工作项类型
        /// </summary>
        [JsonProperty("issue_category", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueCategory { get; set; }

        /// <summary>
        /// 工作项ID
        /// </summary>
        [JsonProperty("issue_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("issue_status", NullValueHandling = NullValueHandling.Ignore)]
        public ProcessInstanceResponseResultIssueStatus IssueStatus { get; set; }

        /// <summary>
        /// 工作项严重程度
        /// </summary>
        [JsonProperty("issue_severity", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueSeverity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("issue_priority", NullValueHandling = NullValueHandling.Ignore)]
        public ProcessInstanceResponseResultIssuePriority IssuePriority { get; set; }

        /// <summary>
        /// 归属项目名称
        /// </summary>
        [JsonProperty("domain_title", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainTitle { get; set; }

        /// <summary>
        /// 提出项目名称
        /// </summary>
        [JsonProperty("src_domain_title", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcDomainTitle { get; set; }

        /// <summary>
        /// 责任人昵称
        /// </summary>
        [JsonProperty("issue_assignee_name", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueAssigneeName { get; set; }

        /// <summary>
        /// 评审原因
        /// </summary>
        [JsonProperty("change_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string ChangeReason { get; set; }

        /// <summary>
        /// 评审类型
        /// </summary>
        [JsonProperty("change_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ChangeType { get; set; }

        /// <summary>
        /// 源系统id
        /// </summary>
        [JsonProperty("source_system_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceSystemId { get; set; }

        /// <summary>
        /// 评审描述
        /// </summary>
        [JsonProperty("change_description", NullValueHandling = NullValueHandling.Ignore)]
        public string ChangeDescription { get; set; }

        /// <summary>
        /// 是否已删除
        /// </summary>
        [JsonProperty("has_deleted", NullValueHandling = NullValueHandling.Ignore)]
        public string HasDeleted { get; set; }

        /// <summary>
        /// 评审结果
        /// </summary>
        [JsonProperty("approval_phase_result", NullValueHandling = NullValueHandling.Ignore)]
        public string ApprovalPhaseResult { get; set; }

        /// <summary>
        /// 评审完成时间
        /// </summary>
        [JsonProperty("approval_complete_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ApprovalCompleteTime { get; set; }

        /// <summary>
        /// 评审描述
        /// </summary>
        [JsonProperty("ccb_description", NullValueHandling = NullValueHandling.Ignore)]
        public string CcbDescription { get; set; }

        /// <summary>
        /// 评审专家
        /// </summary>
        [JsonProperty("actual_ccb", NullValueHandling = NullValueHandling.Ignore)]
        public string ActualCcb { get; set; }

        /// <summary>
        /// 审批信息列表
        /// </summary>
        [JsonProperty("ccbs", NullValueHandling = NullValueHandling.Ignore)]
        public string Ccbs { get; set; }

        /// <summary>
        /// 评审信息
        /// </summary>
        [JsonProperty("ccb_info", NullValueHandling = NullValueHandling.Ignore)]
        public string CcbInfo { get; set; }

        /// <summary>
        /// 变更对象评审专家Id列表（创建变更评审时使用）
        /// </summary>
        [JsonProperty("opinions", NullValueHandling = NullValueHandling.Ignore)]
        public string Opinions { get; set; }

        /// <summary>
        /// 评审意见
        /// </summary>
        [JsonProperty("opinion_comments", NullValueHandling = NullValueHandling.Ignore)]
        public string OpinionComments { get; set; }

        /// <summary>
        /// 审批时间
        /// </summary>
        [JsonProperty("approval_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ApprovalTime { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [JsonProperty("src_domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcDomainId { get; set; }

        /// <summary>
        /// 是否跨租户
        /// </summary>
        [JsonProperty("cross_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string CrossDomain { get; set; }

        /// <summary>
        /// 归属项目是否迁移
        /// </summary>
        [JsonProperty("domain_moved", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainMoved { get; set; }

        /// <summary>
        /// 评审专家
        /// </summary>
        [JsonProperty("reviewer", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Reviewer { get; set; }

        /// <summary>
        /// 决策人
        /// </summary>
        [JsonProperty("approver", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Approver { get; set; }

        /// <summary>
        /// 评审轮次
        /// </summary>
        [JsonProperty("rounds", NullValueHandling = NullValueHandling.Ignore)]
        public string Rounds { get; set; }

        /// <summary>
        /// 最近一轮决策结果
        /// </summary>
        [JsonProperty("last_round_result", NullValueHandling = NullValueHandling.Ignore)]
        public string LastRoundResult { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessInstanceResponseResultCos {\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  assignee: ").Append(Assignee).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  order: ").Append(Order).Append("\n");
            sb.Append("  co2cr: ").Append(Co2cr).Append("\n");
            sb.Append("  co2br: ").Append(Co2br).Append("\n");
            sb.Append("  co2gr: ").Append(Co2gr).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  beforeChange: ").Append(BeforeChange).Append("\n");
            sb.Append("  afterChange: ").Append(AfterChange).Append("\n");
            sb.Append("  modifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  modifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  createdBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  createdDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  statusMap: ").Append(StatusMap).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  sourceSystem: ").Append(SourceSystem).Append("\n");
            sb.Append("  sourceSystemLink: ").Append(SourceSystemLink).Append("\n");
            sb.Append("  issueCategory: ").Append(IssueCategory).Append("\n");
            sb.Append("  issueId: ").Append(IssueId).Append("\n");
            sb.Append("  issueStatus: ").Append(IssueStatus).Append("\n");
            sb.Append("  issueSeverity: ").Append(IssueSeverity).Append("\n");
            sb.Append("  issuePriority: ").Append(IssuePriority).Append("\n");
            sb.Append("  domainTitle: ").Append(DomainTitle).Append("\n");
            sb.Append("  srcDomainTitle: ").Append(SrcDomainTitle).Append("\n");
            sb.Append("  issueAssigneeName: ").Append(IssueAssigneeName).Append("\n");
            sb.Append("  changeReason: ").Append(ChangeReason).Append("\n");
            sb.Append("  changeType: ").Append(ChangeType).Append("\n");
            sb.Append("  sourceSystemId: ").Append(SourceSystemId).Append("\n");
            sb.Append("  changeDescription: ").Append(ChangeDescription).Append("\n");
            sb.Append("  hasDeleted: ").Append(HasDeleted).Append("\n");
            sb.Append("  approvalPhaseResult: ").Append(ApprovalPhaseResult).Append("\n");
            sb.Append("  approvalCompleteTime: ").Append(ApprovalCompleteTime).Append("\n");
            sb.Append("  ccbDescription: ").Append(CcbDescription).Append("\n");
            sb.Append("  actualCcb: ").Append(ActualCcb).Append("\n");
            sb.Append("  ccbs: ").Append(Ccbs).Append("\n");
            sb.Append("  ccbInfo: ").Append(CcbInfo).Append("\n");
            sb.Append("  opinions: ").Append(Opinions).Append("\n");
            sb.Append("  opinionComments: ").Append(OpinionComments).Append("\n");
            sb.Append("  approvalTime: ").Append(ApprovalTime).Append("\n");
            sb.Append("  srcDomainId: ").Append(SrcDomainId).Append("\n");
            sb.Append("  crossDomain: ").Append(CrossDomain).Append("\n");
            sb.Append("  domainMoved: ").Append(DomainMoved).Append("\n");
            sb.Append("  reviewer: ").Append(Reviewer).Append("\n");
            sb.Append("  approver: ").Append(Approver).Append("\n");
            sb.Append("  rounds: ").Append(Rounds).Append("\n");
            sb.Append("  lastRoundResult: ").Append(LastRoundResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProcessInstanceResponseResultCos);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProcessInstanceResponseResultCos input)
        {
            if (input == null) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Assignee != input.Assignee || (this.Assignee != null && !this.Assignee.Equals(input.Assignee))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.Order != input.Order || (this.Order != null && !this.Order.Equals(input.Order))) return false;
            if (this.Co2cr != input.Co2cr || (this.Co2cr != null && !this.Co2cr.Equals(input.Co2cr))) return false;
            if (this.Co2br != input.Co2br || (this.Co2br != null && !this.Co2br.Equals(input.Co2br))) return false;
            if (this.Co2gr != input.Co2gr || (this.Co2gr != null && !this.Co2gr.Equals(input.Co2gr))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.BeforeChange != input.BeforeChange || (this.BeforeChange != null && !this.BeforeChange.Equals(input.BeforeChange))) return false;
            if (this.AfterChange != input.AfterChange || (this.AfterChange != null && !this.AfterChange.Equals(input.AfterChange))) return false;
            if (this.ModifiedBy != input.ModifiedBy || (this.ModifiedBy != null && !this.ModifiedBy.Equals(input.ModifiedBy))) return false;
            if (this.ModifiedDate != input.ModifiedDate || (this.ModifiedDate != null && !this.ModifiedDate.Equals(input.ModifiedDate))) return false;
            if (this.CreatedBy != input.CreatedBy || (this.CreatedBy != null && !this.CreatedBy.Equals(input.CreatedBy))) return false;
            if (this.CreatedDate != input.CreatedDate || (this.CreatedDate != null && !this.CreatedDate.Equals(input.CreatedDate))) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;
            if (this.StatusMap != input.StatusMap || (this.StatusMap != null && !this.StatusMap.Equals(input.StatusMap))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.SourceSystem != input.SourceSystem || (this.SourceSystem != null && !this.SourceSystem.Equals(input.SourceSystem))) return false;
            if (this.SourceSystemLink != input.SourceSystemLink || (this.SourceSystemLink != null && !this.SourceSystemLink.Equals(input.SourceSystemLink))) return false;
            if (this.IssueCategory != input.IssueCategory || (this.IssueCategory != null && !this.IssueCategory.Equals(input.IssueCategory))) return false;
            if (this.IssueId != input.IssueId || (this.IssueId != null && !this.IssueId.Equals(input.IssueId))) return false;
            if (this.IssueStatus != input.IssueStatus || (this.IssueStatus != null && !this.IssueStatus.Equals(input.IssueStatus))) return false;
            if (this.IssueSeverity != input.IssueSeverity || (this.IssueSeverity != null && !this.IssueSeverity.Equals(input.IssueSeverity))) return false;
            if (this.IssuePriority != input.IssuePriority || (this.IssuePriority != null && !this.IssuePriority.Equals(input.IssuePriority))) return false;
            if (this.DomainTitle != input.DomainTitle || (this.DomainTitle != null && !this.DomainTitle.Equals(input.DomainTitle))) return false;
            if (this.SrcDomainTitle != input.SrcDomainTitle || (this.SrcDomainTitle != null && !this.SrcDomainTitle.Equals(input.SrcDomainTitle))) return false;
            if (this.IssueAssigneeName != input.IssueAssigneeName || (this.IssueAssigneeName != null && !this.IssueAssigneeName.Equals(input.IssueAssigneeName))) return false;
            if (this.ChangeReason != input.ChangeReason || (this.ChangeReason != null && !this.ChangeReason.Equals(input.ChangeReason))) return false;
            if (this.ChangeType != input.ChangeType || (this.ChangeType != null && !this.ChangeType.Equals(input.ChangeType))) return false;
            if (this.SourceSystemId != input.SourceSystemId || (this.SourceSystemId != null && !this.SourceSystemId.Equals(input.SourceSystemId))) return false;
            if (this.ChangeDescription != input.ChangeDescription || (this.ChangeDescription != null && !this.ChangeDescription.Equals(input.ChangeDescription))) return false;
            if (this.HasDeleted != input.HasDeleted || (this.HasDeleted != null && !this.HasDeleted.Equals(input.HasDeleted))) return false;
            if (this.ApprovalPhaseResult != input.ApprovalPhaseResult || (this.ApprovalPhaseResult != null && !this.ApprovalPhaseResult.Equals(input.ApprovalPhaseResult))) return false;
            if (this.ApprovalCompleteTime != input.ApprovalCompleteTime || (this.ApprovalCompleteTime != null && !this.ApprovalCompleteTime.Equals(input.ApprovalCompleteTime))) return false;
            if (this.CcbDescription != input.CcbDescription || (this.CcbDescription != null && !this.CcbDescription.Equals(input.CcbDescription))) return false;
            if (this.ActualCcb != input.ActualCcb || (this.ActualCcb != null && !this.ActualCcb.Equals(input.ActualCcb))) return false;
            if (this.Ccbs != input.Ccbs || (this.Ccbs != null && !this.Ccbs.Equals(input.Ccbs))) return false;
            if (this.CcbInfo != input.CcbInfo || (this.CcbInfo != null && !this.CcbInfo.Equals(input.CcbInfo))) return false;
            if (this.Opinions != input.Opinions || (this.Opinions != null && !this.Opinions.Equals(input.Opinions))) return false;
            if (this.OpinionComments != input.OpinionComments || (this.OpinionComments != null && !this.OpinionComments.Equals(input.OpinionComments))) return false;
            if (this.ApprovalTime != input.ApprovalTime || (this.ApprovalTime != null && !this.ApprovalTime.Equals(input.ApprovalTime))) return false;
            if (this.SrcDomainId != input.SrcDomainId || (this.SrcDomainId != null && !this.SrcDomainId.Equals(input.SrcDomainId))) return false;
            if (this.CrossDomain != input.CrossDomain || (this.CrossDomain != null && !this.CrossDomain.Equals(input.CrossDomain))) return false;
            if (this.DomainMoved != input.DomainMoved || (this.DomainMoved != null && !this.DomainMoved.Equals(input.DomainMoved))) return false;
            if (this.Reviewer != input.Reviewer || (this.Reviewer != null && input.Reviewer != null && !this.Reviewer.SequenceEqual(input.Reviewer))) return false;
            if (this.Approver != input.Approver || (this.Approver != null && input.Approver != null && !this.Approver.SequenceEqual(input.Approver))) return false;
            if (this.Rounds != input.Rounds || (this.Rounds != null && !this.Rounds.Equals(input.Rounds))) return false;
            if (this.LastRoundResult != input.LastRoundResult || (this.LastRoundResult != null && !this.LastRoundResult.Equals(input.LastRoundResult))) return false;

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
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Assignee != null) hashCode = hashCode * 59 + this.Assignee.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.Order != null) hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.Co2cr != null) hashCode = hashCode * 59 + this.Co2cr.GetHashCode();
                if (this.Co2br != null) hashCode = hashCode * 59 + this.Co2br.GetHashCode();
                if (this.Co2gr != null) hashCode = hashCode * 59 + this.Co2gr.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.BeforeChange != null) hashCode = hashCode * 59 + this.BeforeChange.GetHashCode();
                if (this.AfterChange != null) hashCode = hashCode * 59 + this.AfterChange.GetHashCode();
                if (this.ModifiedBy != null) hashCode = hashCode * 59 + this.ModifiedBy.GetHashCode();
                if (this.ModifiedDate != null) hashCode = hashCode * 59 + this.ModifiedDate.GetHashCode();
                if (this.CreatedBy != null) hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedDate != null) hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.StatusMap != null) hashCode = hashCode * 59 + this.StatusMap.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.SourceSystem != null) hashCode = hashCode * 59 + this.SourceSystem.GetHashCode();
                if (this.SourceSystemLink != null) hashCode = hashCode * 59 + this.SourceSystemLink.GetHashCode();
                if (this.IssueCategory != null) hashCode = hashCode * 59 + this.IssueCategory.GetHashCode();
                if (this.IssueId != null) hashCode = hashCode * 59 + this.IssueId.GetHashCode();
                if (this.IssueStatus != null) hashCode = hashCode * 59 + this.IssueStatus.GetHashCode();
                if (this.IssueSeverity != null) hashCode = hashCode * 59 + this.IssueSeverity.GetHashCode();
                if (this.IssuePriority != null) hashCode = hashCode * 59 + this.IssuePriority.GetHashCode();
                if (this.DomainTitle != null) hashCode = hashCode * 59 + this.DomainTitle.GetHashCode();
                if (this.SrcDomainTitle != null) hashCode = hashCode * 59 + this.SrcDomainTitle.GetHashCode();
                if (this.IssueAssigneeName != null) hashCode = hashCode * 59 + this.IssueAssigneeName.GetHashCode();
                if (this.ChangeReason != null) hashCode = hashCode * 59 + this.ChangeReason.GetHashCode();
                if (this.ChangeType != null) hashCode = hashCode * 59 + this.ChangeType.GetHashCode();
                if (this.SourceSystemId != null) hashCode = hashCode * 59 + this.SourceSystemId.GetHashCode();
                if (this.ChangeDescription != null) hashCode = hashCode * 59 + this.ChangeDescription.GetHashCode();
                if (this.HasDeleted != null) hashCode = hashCode * 59 + this.HasDeleted.GetHashCode();
                if (this.ApprovalPhaseResult != null) hashCode = hashCode * 59 + this.ApprovalPhaseResult.GetHashCode();
                if (this.ApprovalCompleteTime != null) hashCode = hashCode * 59 + this.ApprovalCompleteTime.GetHashCode();
                if (this.CcbDescription != null) hashCode = hashCode * 59 + this.CcbDescription.GetHashCode();
                if (this.ActualCcb != null) hashCode = hashCode * 59 + this.ActualCcb.GetHashCode();
                if (this.Ccbs != null) hashCode = hashCode * 59 + this.Ccbs.GetHashCode();
                if (this.CcbInfo != null) hashCode = hashCode * 59 + this.CcbInfo.GetHashCode();
                if (this.Opinions != null) hashCode = hashCode * 59 + this.Opinions.GetHashCode();
                if (this.OpinionComments != null) hashCode = hashCode * 59 + this.OpinionComments.GetHashCode();
                if (this.ApprovalTime != null) hashCode = hashCode * 59 + this.ApprovalTime.GetHashCode();
                if (this.SrcDomainId != null) hashCode = hashCode * 59 + this.SrcDomainId.GetHashCode();
                if (this.CrossDomain != null) hashCode = hashCode * 59 + this.CrossDomain.GetHashCode();
                if (this.DomainMoved != null) hashCode = hashCode * 59 + this.DomainMoved.GetHashCode();
                if (this.Reviewer != null) hashCode = hashCode * 59 + this.Reviewer.GetHashCode();
                if (this.Approver != null) hashCode = hashCode * 59 + this.Approver.GetHashCode();
                if (this.Rounds != null) hashCode = hashCode * 59 + this.Rounds.GetHashCode();
                if (this.LastRoundResult != null) hashCode = hashCode * 59 + this.LastRoundResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
