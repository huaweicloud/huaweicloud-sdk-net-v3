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
    public class CreateIpdProjectIssueParam 
    {

        /// <summary>
        /// 工作项名称
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 状态[\&quot;Committed\&quot;, \&quot;Analyse\&quot;, \&quot;ToBeConfirmed\&quot;, \&quot;Plan\&quot;, \&quot;Doing\&quot;, \&quot;Delivered\&quot;, \&quot;Checking\&quot;]
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 提出项目domainId
        /// </summary>
        [JsonProperty("src_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcDomain { get; set; }

        /// <summary>
        /// 所属特性集，适用于SF类型工作项
        /// </summary>
        [JsonProperty("feature_set", NullValueHandling = NullValueHandling.Ignore)]
        public string FeatureSet { get; set; }

        /// <summary>
        /// 提交人Id
        /// </summary>
        [JsonProperty("submitted_by", NullValueHandling = NullValueHandling.Ignore)]
        public string SubmittedBy { get; set; }

        /// <summary>
        /// 归属项目domainId
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 承接人id
        /// </summary>
        [JsonProperty("recipient", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Recipient { get; set; }

        /// <summary>
        /// 期望完成时间
        /// </summary>
        [JsonProperty("expect_delivery_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExpectDeliveryTime { get; set; }

        /// <summary>
        /// 优先级
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public string Priority { get; set; }

        /// <summary>
        /// 抄送人id
        /// </summary>
        [JsonProperty("assigned_cc", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssignedCc { get; set; }

        /// <summary>
        /// 工作项分类：[Epic,FE,IR,RR,SR,US,AR,Bug,Task]
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// 责任人
        /// </summary>
        [JsonProperty("assignee", NullValueHandling = NullValueHandling.Ignore)]
        public string Assignee { get; set; }

        /// <summary>
        /// PI ID
        /// </summary>
        [JsonProperty("plan_pi", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanPi { get; set; }

        /// <summary>
        /// 迭代ID
        /// </summary>
        [JsonProperty("plan_iteration", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanIteration { get; set; }

        /// <summary>
        /// 计划开始时间
        /// </summary>
        [JsonProperty("plan_start_date", NullValueHandling = NullValueHandling.Ignore)]
        public long? PlanStartDate { get; set; }

        /// <summary>
        /// 计划结束时间
        /// </summary>
        [JsonProperty("plan_end_date", NullValueHandling = NullValueHandling.Ignore)]
        public long? PlanEndDate { get; set; }

        /// <summary>
        /// 计划工时
        /// </summary>
        [JsonProperty("workload_man_day", NullValueHandling = NullValueHandling.Ignore)]
        public int? WorkloadManDay { get; set; }

        /// <summary>
        /// 领域
        /// </summary>
        [JsonProperty("business_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessDomain { get; set; }

        /// <summary>
        /// 是否需要分解
        /// </summary>
        [JsonProperty("need_break", NullValueHandling = NullValueHandling.Ignore)]
        public string NeedBreak { get; set; }

        /// <summary>
        /// 工作项层级ID
        /// </summary>
        [JsonProperty("category_layer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryLayerId { get; set; }

        /// <summary>
        /// 父工作项ID
        /// </summary>
        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentId { get; set; }

        /// <summary>
        /// IR关联的RR的ID
        /// </summary>
        [JsonProperty("ir2rr", NullValueHandling = NullValueHandling.Ignore)]
        public string Ir2rr { get; set; }

        /// <summary>
        /// US关联的RR的ID
        /// </summary>
        [JsonProperty("us2rr", NullValueHandling = NullValueHandling.Ignore)]
        public string Us2rr { get; set; }

        /// <summary>
        /// 关联工作项ID，多值使用英文逗号分隔
        /// </summary>
        [JsonProperty("link", NullValueHandling = NullValueHandling.Ignore)]
        public string Link { get; set; }

        /// <summary>
        /// IR关联的SF的ID
        /// </summary>
        [JsonProperty("ir2feature", NullValueHandling = NullValueHandling.Ignore)]
        public string Ir2feature { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateIpdProjectIssueParam {\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  srcDomain: ").Append(SrcDomain).Append("\n");
            sb.Append("  featureSet: ").Append(FeatureSet).Append("\n");
            sb.Append("  submittedBy: ").Append(SubmittedBy).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  recipient: ").Append(Recipient).Append("\n");
            sb.Append("  expectDeliveryTime: ").Append(ExpectDeliveryTime).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  assignedCc: ").Append(AssignedCc).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  assignee: ").Append(Assignee).Append("\n");
            sb.Append("  planPi: ").Append(PlanPi).Append("\n");
            sb.Append("  planIteration: ").Append(PlanIteration).Append("\n");
            sb.Append("  planStartDate: ").Append(PlanStartDate).Append("\n");
            sb.Append("  planEndDate: ").Append(PlanEndDate).Append("\n");
            sb.Append("  workloadManDay: ").Append(WorkloadManDay).Append("\n");
            sb.Append("  businessDomain: ").Append(BusinessDomain).Append("\n");
            sb.Append("  needBreak: ").Append(NeedBreak).Append("\n");
            sb.Append("  categoryLayerId: ").Append(CategoryLayerId).Append("\n");
            sb.Append("  parentId: ").Append(ParentId).Append("\n");
            sb.Append("  ir2rr: ").Append(Ir2rr).Append("\n");
            sb.Append("  us2rr: ").Append(Us2rr).Append("\n");
            sb.Append("  link: ").Append(Link).Append("\n");
            sb.Append("  ir2feature: ").Append(Ir2feature).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateIpdProjectIssueParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateIpdProjectIssueParam input)
        {
            if (input == null) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.SrcDomain != input.SrcDomain || (this.SrcDomain != null && !this.SrcDomain.Equals(input.SrcDomain))) return false;
            if (this.FeatureSet != input.FeatureSet || (this.FeatureSet != null && !this.FeatureSet.Equals(input.FeatureSet))) return false;
            if (this.SubmittedBy != input.SubmittedBy || (this.SubmittedBy != null && !this.SubmittedBy.Equals(input.SubmittedBy))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.Recipient != input.Recipient || (this.Recipient != null && input.Recipient != null && !this.Recipient.SequenceEqual(input.Recipient))) return false;
            if (this.ExpectDeliveryTime != input.ExpectDeliveryTime || (this.ExpectDeliveryTime != null && !this.ExpectDeliveryTime.Equals(input.ExpectDeliveryTime))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.AssignedCc != input.AssignedCc || (this.AssignedCc != null && input.AssignedCc != null && !this.AssignedCc.SequenceEqual(input.AssignedCc))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.Assignee != input.Assignee || (this.Assignee != null && !this.Assignee.Equals(input.Assignee))) return false;
            if (this.PlanPi != input.PlanPi || (this.PlanPi != null && !this.PlanPi.Equals(input.PlanPi))) return false;
            if (this.PlanIteration != input.PlanIteration || (this.PlanIteration != null && !this.PlanIteration.Equals(input.PlanIteration))) return false;
            if (this.PlanStartDate != input.PlanStartDate || (this.PlanStartDate != null && !this.PlanStartDate.Equals(input.PlanStartDate))) return false;
            if (this.PlanEndDate != input.PlanEndDate || (this.PlanEndDate != null && !this.PlanEndDate.Equals(input.PlanEndDate))) return false;
            if (this.WorkloadManDay != input.WorkloadManDay || (this.WorkloadManDay != null && !this.WorkloadManDay.Equals(input.WorkloadManDay))) return false;
            if (this.BusinessDomain != input.BusinessDomain || (this.BusinessDomain != null && !this.BusinessDomain.Equals(input.BusinessDomain))) return false;
            if (this.NeedBreak != input.NeedBreak || (this.NeedBreak != null && !this.NeedBreak.Equals(input.NeedBreak))) return false;
            if (this.CategoryLayerId != input.CategoryLayerId || (this.CategoryLayerId != null && !this.CategoryLayerId.Equals(input.CategoryLayerId))) return false;
            if (this.ParentId != input.ParentId || (this.ParentId != null && !this.ParentId.Equals(input.ParentId))) return false;
            if (this.Ir2rr != input.Ir2rr || (this.Ir2rr != null && !this.Ir2rr.Equals(input.Ir2rr))) return false;
            if (this.Us2rr != input.Us2rr || (this.Us2rr != null && !this.Us2rr.Equals(input.Us2rr))) return false;
            if (this.Link != input.Link || (this.Link != null && !this.Link.Equals(input.Link))) return false;
            if (this.Ir2feature != input.Ir2feature || (this.Ir2feature != null && !this.Ir2feature.Equals(input.Ir2feature))) return false;

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
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SrcDomain != null) hashCode = hashCode * 59 + this.SrcDomain.GetHashCode();
                if (this.FeatureSet != null) hashCode = hashCode * 59 + this.FeatureSet.GetHashCode();
                if (this.SubmittedBy != null) hashCode = hashCode * 59 + this.SubmittedBy.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.Recipient != null) hashCode = hashCode * 59 + this.Recipient.GetHashCode();
                if (this.ExpectDeliveryTime != null) hashCode = hashCode * 59 + this.ExpectDeliveryTime.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.AssignedCc != null) hashCode = hashCode * 59 + this.AssignedCc.GetHashCode();
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Assignee != null) hashCode = hashCode * 59 + this.Assignee.GetHashCode();
                if (this.PlanPi != null) hashCode = hashCode * 59 + this.PlanPi.GetHashCode();
                if (this.PlanIteration != null) hashCode = hashCode * 59 + this.PlanIteration.GetHashCode();
                if (this.PlanStartDate != null) hashCode = hashCode * 59 + this.PlanStartDate.GetHashCode();
                if (this.PlanEndDate != null) hashCode = hashCode * 59 + this.PlanEndDate.GetHashCode();
                if (this.WorkloadManDay != null) hashCode = hashCode * 59 + this.WorkloadManDay.GetHashCode();
                if (this.BusinessDomain != null) hashCode = hashCode * 59 + this.BusinessDomain.GetHashCode();
                if (this.NeedBreak != null) hashCode = hashCode * 59 + this.NeedBreak.GetHashCode();
                if (this.CategoryLayerId != null) hashCode = hashCode * 59 + this.CategoryLayerId.GetHashCode();
                if (this.ParentId != null) hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.Ir2rr != null) hashCode = hashCode * 59 + this.Ir2rr.GetHashCode();
                if (this.Us2rr != null) hashCode = hashCode * 59 + this.Us2rr.GetHashCode();
                if (this.Link != null) hashCode = hashCode * 59 + this.Link.GetHashCode();
                if (this.Ir2feature != null) hashCode = hashCode * 59 + this.Ir2feature.GetHashCode();
                return hashCode;
            }
        }
    }
}
