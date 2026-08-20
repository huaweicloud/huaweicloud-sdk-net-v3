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
    public class ReviewEntity 
    {

        /// <summary>
        /// 评审单ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 评审单编号。
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 评审单的生命周期。
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// 评审单标题。
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 评审单类别。
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("created_by", NullValueHandling = NullValueHandling.Ignore)]
        public UserEntity CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("modified_by", NullValueHandling = NullValueHandling.Ignore)]
        public UserEntity ModifiedBy { get; set; }

        /// <summary>
        /// 评审单抄送人。
        /// </summary>
        [JsonProperty("assigned_cc", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserEntity> AssignedCc { get; set; }

        /// <summary>
        /// 评审单创建时间戳。
        /// </summary>
        [JsonProperty("created_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// 评审单最后修改时间戳。
        /// </summary>
        [JsonProperty("modified_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// 计划完成日期时间戳。
        /// </summary>
        [JsonProperty("plan_end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanEndDate { get; set; }

        /// <summary>
        /// 计划开始日期时间戳。
        /// </summary>
        [JsonProperty("plan_start_date", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanStartDate { get; set; }

        /// <summary>
        /// 评审单完成时间。
        /// </summary>
        [JsonProperty("close_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CloseTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEntity Status { get; set; }

        /// <summary>
        /// 评审单描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 评审单完成时间。
        /// </summary>
        [JsonProperty("closed_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ClosedTime { get; set; }

        /// <summary>
        /// 决策人ID。
        /// </summary>
        [JsonProperty("approver", NullValueHandling = NullValueHandling.Ignore)]
        public string Approver { get; set; }

        /// <summary>
        /// 评审专家ID。
        /// </summary>
        [JsonProperty("reviewer", NullValueHandling = NullValueHandling.Ignore)]
        public string Reviewer { get; set; }

        /// <summary>
        /// 评审对象列表。
        /// </summary>
        [JsonProperty("cos", NullValueHandling = NullValueHandling.Ignore)]
        public List<COEntity> Cos { get; set; }

        /// <summary>
        /// 审批信息列表。
        /// </summary>
        [JsonProperty("ccbs", NullValueHandling = NullValueHandling.Ignore)]
        public List<CcbEntity> Ccbs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("old_status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEntity OldStatus { get; set; }

        /// <summary>
        /// 抄送人列表。
        /// </summary>
        [JsonProperty("cc", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserEntity> Cc { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReviewEntity {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  createdBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  modifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  assignedCc: ").Append(AssignedCc).Append("\n");
            sb.Append("  createdTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  modifiedTime: ").Append(ModifiedTime).Append("\n");
            sb.Append("  planEndDate: ").Append(PlanEndDate).Append("\n");
            sb.Append("  planStartDate: ").Append(PlanStartDate).Append("\n");
            sb.Append("  closeTime: ").Append(CloseTime).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  closedTime: ").Append(ClosedTime).Append("\n");
            sb.Append("  approver: ").Append(Approver).Append("\n");
            sb.Append("  reviewer: ").Append(Reviewer).Append("\n");
            sb.Append("  cos: ").Append(Cos).Append("\n");
            sb.Append("  ccbs: ").Append(Ccbs).Append("\n");
            sb.Append("  oldStatus: ").Append(OldStatus).Append("\n");
            sb.Append("  cc: ").Append(Cc).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReviewEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReviewEntity input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.CreatedBy != input.CreatedBy || (this.CreatedBy != null && !this.CreatedBy.Equals(input.CreatedBy))) return false;
            if (this.ModifiedBy != input.ModifiedBy || (this.ModifiedBy != null && !this.ModifiedBy.Equals(input.ModifiedBy))) return false;
            if (this.AssignedCc != input.AssignedCc || (this.AssignedCc != null && input.AssignedCc != null && !this.AssignedCc.SequenceEqual(input.AssignedCc))) return false;
            if (this.CreatedTime != input.CreatedTime || (this.CreatedTime != null && !this.CreatedTime.Equals(input.CreatedTime))) return false;
            if (this.ModifiedTime != input.ModifiedTime || (this.ModifiedTime != null && !this.ModifiedTime.Equals(input.ModifiedTime))) return false;
            if (this.PlanEndDate != input.PlanEndDate || (this.PlanEndDate != null && !this.PlanEndDate.Equals(input.PlanEndDate))) return false;
            if (this.PlanStartDate != input.PlanStartDate || (this.PlanStartDate != null && !this.PlanStartDate.Equals(input.PlanStartDate))) return false;
            if (this.CloseTime != input.CloseTime || (this.CloseTime != null && !this.CloseTime.Equals(input.CloseTime))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.ClosedTime != input.ClosedTime || (this.ClosedTime != null && !this.ClosedTime.Equals(input.ClosedTime))) return false;
            if (this.Approver != input.Approver || (this.Approver != null && !this.Approver.Equals(input.Approver))) return false;
            if (this.Reviewer != input.Reviewer || (this.Reviewer != null && !this.Reviewer.Equals(input.Reviewer))) return false;
            if (this.Cos != input.Cos || (this.Cos != null && input.Cos != null && !this.Cos.SequenceEqual(input.Cos))) return false;
            if (this.Ccbs != input.Ccbs || (this.Ccbs != null && input.Ccbs != null && !this.Ccbs.SequenceEqual(input.Ccbs))) return false;
            if (this.OldStatus != input.OldStatus || (this.OldStatus != null && !this.OldStatus.Equals(input.OldStatus))) return false;
            if (this.Cc != input.Cc || (this.Cc != null && input.Cc != null && !this.Cc.SequenceEqual(input.Cc))) return false;

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
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.CreatedBy != null) hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.ModifiedBy != null) hashCode = hashCode * 59 + this.ModifiedBy.GetHashCode();
                if (this.AssignedCc != null) hashCode = hashCode * 59 + this.AssignedCc.GetHashCode();
                if (this.CreatedTime != null) hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.ModifiedTime != null) hashCode = hashCode * 59 + this.ModifiedTime.GetHashCode();
                if (this.PlanEndDate != null) hashCode = hashCode * 59 + this.PlanEndDate.GetHashCode();
                if (this.PlanStartDate != null) hashCode = hashCode * 59 + this.PlanStartDate.GetHashCode();
                if (this.CloseTime != null) hashCode = hashCode * 59 + this.CloseTime.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ClosedTime != null) hashCode = hashCode * 59 + this.ClosedTime.GetHashCode();
                if (this.Approver != null) hashCode = hashCode * 59 + this.Approver.GetHashCode();
                if (this.Reviewer != null) hashCode = hashCode * 59 + this.Reviewer.GetHashCode();
                if (this.Cos != null) hashCode = hashCode * 59 + this.Cos.GetHashCode();
                if (this.Ccbs != null) hashCode = hashCode * 59 + this.Ccbs.GetHashCode();
                if (this.OldStatus != null) hashCode = hashCode * 59 + this.OldStatus.GetHashCode();
                if (this.Cc != null) hashCode = hashCode * 59 + this.Cc.GetHashCode();
                return hashCode;
            }
        }
    }
}
