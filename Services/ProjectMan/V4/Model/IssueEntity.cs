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
    /// 工作项的公共父类，即所有工作项类型都有这些字段 其子类有 IssueAREntity IssueBugEntity IssueEntity IssueEpicEntity IssueFEEntity IssueIREntity IssueRREntity IssueSFEntity IssueSREntity IssueTaskEntity IssueUSEntity
    /// </summary>
    public class IssueEntity 
    {

        /// <summary>
        /// 工作项id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 工作项标题
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 工作项描述字段
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 工作项大分类定义 requirement(研发需求)、bug(缺陷)、task(任务)、feature(特性)、raw_requirement(原始需求)
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 工作项编号
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 工作项类型，编辑工作项时，此字段必填、值为当前工作项正确的工作项类型，但不会更新此字段
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// 父工作项id
        /// </summary>
        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentId { get; set; }

        /// <summary>
        /// 工作项所属的项目id
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 工作项状态code
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 工作项的生命周期，可选值为\&quot;正在工作\&quot;,\&quot;作废\&quot;
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("assignee", NullValueHandling = NullValueHandling.Ignore)]
        public UserEntity Assignee { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("created_by", NullValueHandling = NullValueHandling.Ignore)]
        public UserEntity CreatedBy { get; set; }

        /// <summary>
        /// 工作项创建时间
        /// </summary>
        [JsonProperty("created_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("modified_by", NullValueHandling = NullValueHandling.Ignore)]
        public UserEntity ModifiedBy { get; set; }

        /// <summary>
        /// 工作项最近更新时间
        /// </summary>
        [JsonProperty("modified_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// 工作项计划结束日期，时间戳
        /// </summary>
        [JsonProperty("plan_end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanEndDate { get; set; }

        /// <summary>
        /// 工作项关闭时间
        /// </summary>
        [JsonProperty("close_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CloseTime { get; set; }

        /// <summary>
        /// 工作项计划工时，保留一位小数，取值范围为0~999999999.9
        /// </summary>
        [JsonProperty("workload", NullValueHandling = NullValueHandling.Ignore)]
        public string Workload { get; set; }

        /// <summary>
        /// 工作项计划工时，保留一位小数，取值范围为0~999999999.9，不可编辑
        /// </summary>
        [JsonProperty("workload_sum", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkloadSum { get; set; }

        /// <summary>
        /// 工作项所属租户id
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 工作项关联项id，多个关联项用英文逗号分隔，同一工作项最多支持50个关联项
        /// </summary>
        [JsonProperty("link", NullValueHandling = NullValueHandling.Ignore)]
        public string Link { get; set; }

        /// <summary>
        /// 工作项是否已挂起
        /// </summary>
        [JsonProperty("suspended", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Suspended { get; set; }

        /// <summary>
        /// 工作项状态改变时间，可用于计算工作项在当前状态停留天数
        /// </summary>
        [JsonProperty("status_modified_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusModifiedTime { get; set; }

        /// <summary>
        /// 工作项标签
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public List<LabelEntity> Labels { get; set; }

        /// <summary>
        /// 工作项自定义字段映射，用户添加的系统字段也在此列 { \&quot;code\&quot;:\&quot;字段code\&quot;, \&quot;value\&quot;:\&quot;字段值\&quot; }
        /// </summary>
        [JsonProperty("custom_fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<FieldCodeValuePair> CustomFields { get; set; }

        /// <summary>
        /// 工作项的子工作项集合
        /// </summary>
        [JsonProperty("children", NullValueHandling = NullValueHandling.Ignore)]
        public List<IssueEntity> Children { get; set; }

        /// <summary>
        /// 子工作项的路径
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// IR和FE的关联字段，工作项类型为IR时，有此字段
        /// </summary>
        [JsonProperty("ir2feature", NullValueHandling = NullValueHandling.Ignore)]
        public string Ir2feature { get; set; }

        /// <summary>
        /// 工作项是否需要分解,仅可以分解的工作项类型有此字段
        /// </summary>
        [JsonProperty("need_break", NullValueHandling = NullValueHandling.Ignore)]
        public string NeedBreak { get; set; }

        /// <summary>
        /// 分解状态 已分解—decomposed 未分解—undecomposed 不涉及— - -
        /// </summary>
        [JsonProperty("break_status", NullValueHandling = NullValueHandling.Ignore)]
        public string BreakStatus { get; set; }

        /// <summary>
        /// 工作项基线状态 未基线 —— null 已基线 —— baselined 基线评审中——baseline-reviewing
        /// </summary>
        [JsonProperty("baseline", NullValueHandling = NullValueHandling.Ignore)]
        public string Baseline { get; set; }

        /// <summary>
        /// 工作项优先级，部分工作项有此字段
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public string Priority { get; set; }

        /// <summary>
        /// 是否涉及网络安全。预设字段中，仅研发需求有此字段
        /// </summary>
        [JsonProperty("related_network_security", NullValueHandling = NullValueHandling.Ignore)]
        public string RelatedNetworkSecurity { get; set; }

        /// <summary>
        /// 研发需求协同信息，协同任务id
        /// </summary>
        [JsonProperty("collaboratives", NullValueHandling = NullValueHandling.Ignore)]
        public string Collaboratives { get; set; }

        /// <summary>
        /// 领域字段
        /// </summary>
        [JsonProperty("business_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessDomain { get; set; }

        /// <summary>
        /// 工作项发布(老版本名为PI) id
        /// </summary>
        [JsonProperty("plan_pi", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanPi { get; set; }

        /// <summary>
        /// 工作项变更状态 变更评审中——change-reviewing 已变更——changed 未变更-unchange或null
        /// </summary>
        [JsonProperty("change_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ChangeStatus { get; set; }

        /// <summary>
        /// 无需分解原因，need_break&#x3D;no时有此字段
        /// </summary>
        [JsonProperty("no_break_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string NoBreakReason { get; set; }

        /// <summary>
        /// 提出人，部分工作项有此字段，多人时用英文逗号分隔
        /// </summary>
        [JsonProperty("submitted_by", NullValueHandling = NullValueHandling.Ignore)]
        public string SubmittedBy { get; set; }

        /// <summary>
        /// IR关联的RR id，多选时用英文逗号分隔
        /// </summary>
        [JsonProperty("ir2rr", NullValueHandling = NullValueHandling.Ignore)]
        public string Ir2rr { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueEntity {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  parentId: ").Append(ParentId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  assignee: ").Append(Assignee).Append("\n");
            sb.Append("  createdBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  createdTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  modifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  modifiedTime: ").Append(ModifiedTime).Append("\n");
            sb.Append("  planEndDate: ").Append(PlanEndDate).Append("\n");
            sb.Append("  closeTime: ").Append(CloseTime).Append("\n");
            sb.Append("  workload: ").Append(Workload).Append("\n");
            sb.Append("  workloadSum: ").Append(WorkloadSum).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  link: ").Append(Link).Append("\n");
            sb.Append("  suspended: ").Append(Suspended).Append("\n");
            sb.Append("  statusModifiedTime: ").Append(StatusModifiedTime).Append("\n");
            sb.Append("  labels: ").Append(Labels).Append("\n");
            sb.Append("  customFields: ").Append(CustomFields).Append("\n");
            sb.Append("  children: ").Append(Children).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  ir2feature: ").Append(Ir2feature).Append("\n");
            sb.Append("  needBreak: ").Append(NeedBreak).Append("\n");
            sb.Append("  breakStatus: ").Append(BreakStatus).Append("\n");
            sb.Append("  baseline: ").Append(Baseline).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  relatedNetworkSecurity: ").Append(RelatedNetworkSecurity).Append("\n");
            sb.Append("  collaboratives: ").Append(Collaboratives).Append("\n");
            sb.Append("  businessDomain: ").Append(BusinessDomain).Append("\n");
            sb.Append("  planPi: ").Append(PlanPi).Append("\n");
            sb.Append("  changeStatus: ").Append(ChangeStatus).Append("\n");
            sb.Append("  noBreakReason: ").Append(NoBreakReason).Append("\n");
            sb.Append("  submittedBy: ").Append(SubmittedBy).Append("\n");
            sb.Append("  ir2rr: ").Append(Ir2rr).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IssueEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IssueEntity input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.ParentId != input.ParentId || (this.ParentId != null && !this.ParentId.Equals(input.ParentId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.Assignee != input.Assignee || (this.Assignee != null && !this.Assignee.Equals(input.Assignee))) return false;
            if (this.CreatedBy != input.CreatedBy || (this.CreatedBy != null && !this.CreatedBy.Equals(input.CreatedBy))) return false;
            if (this.CreatedTime != input.CreatedTime || (this.CreatedTime != null && !this.CreatedTime.Equals(input.CreatedTime))) return false;
            if (this.ModifiedBy != input.ModifiedBy || (this.ModifiedBy != null && !this.ModifiedBy.Equals(input.ModifiedBy))) return false;
            if (this.ModifiedTime != input.ModifiedTime || (this.ModifiedTime != null && !this.ModifiedTime.Equals(input.ModifiedTime))) return false;
            if (this.PlanEndDate != input.PlanEndDate || (this.PlanEndDate != null && !this.PlanEndDate.Equals(input.PlanEndDate))) return false;
            if (this.CloseTime != input.CloseTime || (this.CloseTime != null && !this.CloseTime.Equals(input.CloseTime))) return false;
            if (this.Workload != input.Workload || (this.Workload != null && !this.Workload.Equals(input.Workload))) return false;
            if (this.WorkloadSum != input.WorkloadSum || (this.WorkloadSum != null && !this.WorkloadSum.Equals(input.WorkloadSum))) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;
            if (this.Link != input.Link || (this.Link != null && !this.Link.Equals(input.Link))) return false;
            if (this.Suspended != input.Suspended || (this.Suspended != null && !this.Suspended.Equals(input.Suspended))) return false;
            if (this.StatusModifiedTime != input.StatusModifiedTime || (this.StatusModifiedTime != null && !this.StatusModifiedTime.Equals(input.StatusModifiedTime))) return false;
            if (this.Labels != input.Labels || (this.Labels != null && input.Labels != null && !this.Labels.SequenceEqual(input.Labels))) return false;
            if (this.CustomFields != input.CustomFields || (this.CustomFields != null && input.CustomFields != null && !this.CustomFields.SequenceEqual(input.CustomFields))) return false;
            if (this.Children != input.Children || (this.Children != null && input.Children != null && !this.Children.SequenceEqual(input.Children))) return false;
            if (this.Path != input.Path || (this.Path != null && !this.Path.Equals(input.Path))) return false;
            if (this.Ir2feature != input.Ir2feature || (this.Ir2feature != null && !this.Ir2feature.Equals(input.Ir2feature))) return false;
            if (this.NeedBreak != input.NeedBreak || (this.NeedBreak != null && !this.NeedBreak.Equals(input.NeedBreak))) return false;
            if (this.BreakStatus != input.BreakStatus || (this.BreakStatus != null && !this.BreakStatus.Equals(input.BreakStatus))) return false;
            if (this.Baseline != input.Baseline || (this.Baseline != null && !this.Baseline.Equals(input.Baseline))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.RelatedNetworkSecurity != input.RelatedNetworkSecurity || (this.RelatedNetworkSecurity != null && !this.RelatedNetworkSecurity.Equals(input.RelatedNetworkSecurity))) return false;
            if (this.Collaboratives != input.Collaboratives || (this.Collaboratives != null && !this.Collaboratives.Equals(input.Collaboratives))) return false;
            if (this.BusinessDomain != input.BusinessDomain || (this.BusinessDomain != null && !this.BusinessDomain.Equals(input.BusinessDomain))) return false;
            if (this.PlanPi != input.PlanPi || (this.PlanPi != null && !this.PlanPi.Equals(input.PlanPi))) return false;
            if (this.ChangeStatus != input.ChangeStatus || (this.ChangeStatus != null && !this.ChangeStatus.Equals(input.ChangeStatus))) return false;
            if (this.NoBreakReason != input.NoBreakReason || (this.NoBreakReason != null && !this.NoBreakReason.Equals(input.NoBreakReason))) return false;
            if (this.SubmittedBy != input.SubmittedBy || (this.SubmittedBy != null && !this.SubmittedBy.Equals(input.SubmittedBy))) return false;
            if (this.Ir2rr != input.Ir2rr || (this.Ir2rr != null && !this.Ir2rr.Equals(input.Ir2rr))) return false;

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
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.ParentId != null) hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Assignee != null) hashCode = hashCode * 59 + this.Assignee.GetHashCode();
                if (this.CreatedBy != null) hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedTime != null) hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.ModifiedBy != null) hashCode = hashCode * 59 + this.ModifiedBy.GetHashCode();
                if (this.ModifiedTime != null) hashCode = hashCode * 59 + this.ModifiedTime.GetHashCode();
                if (this.PlanEndDate != null) hashCode = hashCode * 59 + this.PlanEndDate.GetHashCode();
                if (this.CloseTime != null) hashCode = hashCode * 59 + this.CloseTime.GetHashCode();
                if (this.Workload != null) hashCode = hashCode * 59 + this.Workload.GetHashCode();
                if (this.WorkloadSum != null) hashCode = hashCode * 59 + this.WorkloadSum.GetHashCode();
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.Link != null) hashCode = hashCode * 59 + this.Link.GetHashCode();
                if (this.Suspended != null) hashCode = hashCode * 59 + this.Suspended.GetHashCode();
                if (this.StatusModifiedTime != null) hashCode = hashCode * 59 + this.StatusModifiedTime.GetHashCode();
                if (this.Labels != null) hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.CustomFields != null) hashCode = hashCode * 59 + this.CustomFields.GetHashCode();
                if (this.Children != null) hashCode = hashCode * 59 + this.Children.GetHashCode();
                if (this.Path != null) hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Ir2feature != null) hashCode = hashCode * 59 + this.Ir2feature.GetHashCode();
                if (this.NeedBreak != null) hashCode = hashCode * 59 + this.NeedBreak.GetHashCode();
                if (this.BreakStatus != null) hashCode = hashCode * 59 + this.BreakStatus.GetHashCode();
                if (this.Baseline != null) hashCode = hashCode * 59 + this.Baseline.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.RelatedNetworkSecurity != null) hashCode = hashCode * 59 + this.RelatedNetworkSecurity.GetHashCode();
                if (this.Collaboratives != null) hashCode = hashCode * 59 + this.Collaboratives.GetHashCode();
                if (this.BusinessDomain != null) hashCode = hashCode * 59 + this.BusinessDomain.GetHashCode();
                if (this.PlanPi != null) hashCode = hashCode * 59 + this.PlanPi.GetHashCode();
                if (this.ChangeStatus != null) hashCode = hashCode * 59 + this.ChangeStatus.GetHashCode();
                if (this.NoBreakReason != null) hashCode = hashCode * 59 + this.NoBreakReason.GetHashCode();
                if (this.SubmittedBy != null) hashCode = hashCode * 59 + this.SubmittedBy.GetHashCode();
                if (this.Ir2rr != null) hashCode = hashCode * 59 + this.Ir2rr.GetHashCode();
                return hashCode;
            }
        }
    }
}
