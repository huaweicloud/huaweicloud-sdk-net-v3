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
    public class ShowIpdProcessInstancesResponseResultProcessInstances 
    {

        /// <summary>
        /// 抄送人，多值使用英文逗号分隔。
        /// </summary>
        [JsonProperty("cc", NullValueHandling = NullValueHandling.Ignore)]
        public string Cc { get; set; }

        /// <summary>
        /// 评审单决策人。
        /// </summary>
        [JsonProperty("approver", NullValueHandling = NullValueHandling.Ignore)]
        public string Approver { get; set; }

        /// <summary>
        /// 评审单完成时间。
        /// </summary>
        [JsonProperty("closed_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ClosedTime { get; set; }

        /// <summary>
        /// 评审专家。
        /// </summary>
        [JsonProperty("reviewer", NullValueHandling = NullValueHandling.Ignore)]
        public string Reviewer { get; set; }

        /// <summary>
        /// 评审分类。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 标题。
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 修改时间。
        /// </summary>
        [JsonProperty("modified_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("created_by", NullValueHandling = NullValueHandling.Ignore)]
        public UserVO CreatedBy { get; set; }

        /// <summary>
        /// 项目空间ID。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 评审编号。
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 是否需要决策人审批。
        /// </summary>
        [JsonProperty("need_approval", NullValueHandling = NullValueHandling.Ignore)]
        public string NeedApproval { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("modified_by", NullValueHandling = NullValueHandling.Ignore)]
        public UserVO ModifiedBy { get; set; }

        /// <summary>
        /// 审批时间。
        /// </summary>
        [JsonProperty("approval_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ApprovalTime { get; set; }

        /// <summary>
        /// 计划结束时间。
        /// </summary>
        [JsonProperty("plan_end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanEndDate { get; set; }

        /// <summary>
        /// 评审单ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 评审单数据状态。
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("created_date", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedDate { get; set; }

        /// <summary>
        /// 评审单类型。
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// 计划开始时间。
        /// </summary>
        [JsonProperty("plan_start_date", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanStartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public ShowIpdProcessInstancesResponseResultStatus Status { get; set; }

        /// <summary>
        /// 决策人对象列表。
        /// </summary>
        [JsonProperty("ccbs", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserObject> Ccbs { get; set; }

        /// <summary>
        /// opinion对象列表。
        /// </summary>
        [JsonProperty("opinions", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowIpdProcessInstancesResponseResultOpinions> Opinions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowIpdProcessInstancesResponseResultProcessInstances {\n");
            sb.Append("  cc: ").Append(Cc).Append("\n");
            sb.Append("  approver: ").Append(Approver).Append("\n");
            sb.Append("  closedTime: ").Append(ClosedTime).Append("\n");
            sb.Append("  reviewer: ").Append(Reviewer).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  modifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  createdBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  needApproval: ").Append(NeedApproval).Append("\n");
            sb.Append("  modifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  approvalTime: ").Append(ApprovalTime).Append("\n");
            sb.Append("  planEndDate: ").Append(PlanEndDate).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  createdDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  planStartDate: ").Append(PlanStartDate).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  ccbs: ").Append(Ccbs).Append("\n");
            sb.Append("  opinions: ").Append(Opinions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowIpdProcessInstancesResponseResultProcessInstances);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowIpdProcessInstancesResponseResultProcessInstances input)
        {
            if (input == null) return false;
            if (this.Cc != input.Cc || (this.Cc != null && !this.Cc.Equals(input.Cc))) return false;
            if (this.Approver != input.Approver || (this.Approver != null && !this.Approver.Equals(input.Approver))) return false;
            if (this.ClosedTime != input.ClosedTime || (this.ClosedTime != null && !this.ClosedTime.Equals(input.ClosedTime))) return false;
            if (this.Reviewer != input.Reviewer || (this.Reviewer != null && !this.Reviewer.Equals(input.Reviewer))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.ModifiedDate != input.ModifiedDate || (this.ModifiedDate != null && !this.ModifiedDate.Equals(input.ModifiedDate))) return false;
            if (this.CreatedBy != input.CreatedBy || (this.CreatedBy != null && !this.CreatedBy.Equals(input.CreatedBy))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.NeedApproval != input.NeedApproval || (this.NeedApproval != null && !this.NeedApproval.Equals(input.NeedApproval))) return false;
            if (this.ModifiedBy != input.ModifiedBy || (this.ModifiedBy != null && !this.ModifiedBy.Equals(input.ModifiedBy))) return false;
            if (this.ApprovalTime != input.ApprovalTime || (this.ApprovalTime != null && !this.ApprovalTime.Equals(input.ApprovalTime))) return false;
            if (this.PlanEndDate != input.PlanEndDate || (this.PlanEndDate != null && !this.PlanEndDate.Equals(input.PlanEndDate))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.CreatedDate != input.CreatedDate || (this.CreatedDate != null && !this.CreatedDate.Equals(input.CreatedDate))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.PlanStartDate != input.PlanStartDate || (this.PlanStartDate != null && !this.PlanStartDate.Equals(input.PlanStartDate))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Ccbs != input.Ccbs || (this.Ccbs != null && input.Ccbs != null && !this.Ccbs.SequenceEqual(input.Ccbs))) return false;
            if (this.Opinions != input.Opinions || (this.Opinions != null && input.Opinions != null && !this.Opinions.SequenceEqual(input.Opinions))) return false;

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
                if (this.Cc != null) hashCode = hashCode * 59 + this.Cc.GetHashCode();
                if (this.Approver != null) hashCode = hashCode * 59 + this.Approver.GetHashCode();
                if (this.ClosedTime != null) hashCode = hashCode * 59 + this.ClosedTime.GetHashCode();
                if (this.Reviewer != null) hashCode = hashCode * 59 + this.Reviewer.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.ModifiedDate != null) hashCode = hashCode * 59 + this.ModifiedDate.GetHashCode();
                if (this.CreatedBy != null) hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.NeedApproval != null) hashCode = hashCode * 59 + this.NeedApproval.GetHashCode();
                if (this.ModifiedBy != null) hashCode = hashCode * 59 + this.ModifiedBy.GetHashCode();
                if (this.ApprovalTime != null) hashCode = hashCode * 59 + this.ApprovalTime.GetHashCode();
                if (this.PlanEndDate != null) hashCode = hashCode * 59 + this.PlanEndDate.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.CreatedDate != null) hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.PlanStartDate != null) hashCode = hashCode * 59 + this.PlanStartDate.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Ccbs != null) hashCode = hashCode * 59 + this.Ccbs.GetHashCode();
                if (this.Opinions != null) hashCode = hashCode * 59 + this.Opinions.GetHashCode();
                return hashCode;
            }
        }
    }
}
