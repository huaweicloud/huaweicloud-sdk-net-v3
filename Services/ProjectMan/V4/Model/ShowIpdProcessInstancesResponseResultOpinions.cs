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
    public class ShowIpdProcessInstancesResponseResultOpinions 
    {

        /// <summary>
        /// opinion主键。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 类型分类。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 数据状态。
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// opinion状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 区域。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 类型。
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// 标题。
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 评审轮次。
        /// </summary>
        [JsonProperty("rounds", NullValueHandling = NullValueHandling.Ignore)]
        public string Rounds { get; set; }

        /// <summary>
        /// 评审意见。
        /// </summary>
        [JsonProperty("opinion", NullValueHandling = NullValueHandling.Ignore)]
        public string Opinion { get; set; }

        /// <summary>
        /// 描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 修改人。
        /// </summary>
        [JsonProperty("modified_by", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedBy { get; set; }

        /// <summary>
        /// 修改时间。
        /// </summary>
        [JsonProperty("modified_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("created_by", NullValueHandling = NullValueHandling.Ignore)]
        public UserObject CreatedBy { get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("created_date", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedDate { get; set; }

        /// <summary>
        /// 租户ID。
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 项目空间ID。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 对象类型。
        /// </summary>
        [JsonProperty("issue_category", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueCategory { get; set; }

        /// <summary>
        /// 对象ID。
        /// </summary>
        [JsonProperty("issue_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("curr_owner", NullValueHandling = NullValueHandling.Ignore)]
        public UserObject CurrOwner { get; set; }

        /// <summary>
        /// 变更对象ID。
        /// </summary>
        [JsonProperty("co_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CoId { get; set; }

        /// <summary>
        /// 用户ID。
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 评审工作项ID。
        /// </summary>
        [JsonProperty("opinion_issue_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OpinionIssueId { get; set; }

        /// <summary>
        /// 评审工作项类型。
        /// </summary>
        [JsonProperty("opinion_issue_category", NullValueHandling = NullValueHandling.Ignore)]
        public string OpinionIssueCategory { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowIpdProcessInstancesResponseResultOpinions {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  rounds: ").Append(Rounds).Append("\n");
            sb.Append("  opinion: ").Append(Opinion).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  modifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  modifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  createdBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  createdDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  issueCategory: ").Append(IssueCategory).Append("\n");
            sb.Append("  issueId: ").Append(IssueId).Append("\n");
            sb.Append("  currOwner: ").Append(CurrOwner).Append("\n");
            sb.Append("  coId: ").Append(CoId).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  opinionIssueId: ").Append(OpinionIssueId).Append("\n");
            sb.Append("  opinionIssueCategory: ").Append(OpinionIssueCategory).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowIpdProcessInstancesResponseResultOpinions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowIpdProcessInstancesResponseResultOpinions input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.Rounds != input.Rounds || (this.Rounds != null && !this.Rounds.Equals(input.Rounds))) return false;
            if (this.Opinion != input.Opinion || (this.Opinion != null && !this.Opinion.Equals(input.Opinion))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.ModifiedBy != input.ModifiedBy || (this.ModifiedBy != null && !this.ModifiedBy.Equals(input.ModifiedBy))) return false;
            if (this.ModifiedDate != input.ModifiedDate || (this.ModifiedDate != null && !this.ModifiedDate.Equals(input.ModifiedDate))) return false;
            if (this.CreatedBy != input.CreatedBy || (this.CreatedBy != null && !this.CreatedBy.Equals(input.CreatedBy))) return false;
            if (this.CreatedDate != input.CreatedDate || (this.CreatedDate != null && !this.CreatedDate.Equals(input.CreatedDate))) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.IssueCategory != input.IssueCategory || (this.IssueCategory != null && !this.IssueCategory.Equals(input.IssueCategory))) return false;
            if (this.IssueId != input.IssueId || (this.IssueId != null && !this.IssueId.Equals(input.IssueId))) return false;
            if (this.CurrOwner != input.CurrOwner || (this.CurrOwner != null && !this.CurrOwner.Equals(input.CurrOwner))) return false;
            if (this.CoId != input.CoId || (this.CoId != null && !this.CoId.Equals(input.CoId))) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.OpinionIssueId != input.OpinionIssueId || (this.OpinionIssueId != null && !this.OpinionIssueId.Equals(input.OpinionIssueId))) return false;
            if (this.OpinionIssueCategory != input.OpinionIssueCategory || (this.OpinionIssueCategory != null && !this.OpinionIssueCategory.Equals(input.OpinionIssueCategory))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Rounds != null) hashCode = hashCode * 59 + this.Rounds.GetHashCode();
                if (this.Opinion != null) hashCode = hashCode * 59 + this.Opinion.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ModifiedBy != null) hashCode = hashCode * 59 + this.ModifiedBy.GetHashCode();
                if (this.ModifiedDate != null) hashCode = hashCode * 59 + this.ModifiedDate.GetHashCode();
                if (this.CreatedBy != null) hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedDate != null) hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.IssueCategory != null) hashCode = hashCode * 59 + this.IssueCategory.GetHashCode();
                if (this.IssueId != null) hashCode = hashCode * 59 + this.IssueId.GetHashCode();
                if (this.CurrOwner != null) hashCode = hashCode * 59 + this.CurrOwner.GetHashCode();
                if (this.CoId != null) hashCode = hashCode * 59 + this.CoId.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.OpinionIssueId != null) hashCode = hashCode * 59 + this.OpinionIssueId.GetHashCode();
                if (this.OpinionIssueCategory != null) hashCode = hashCode * 59 + this.OpinionIssueCategory.GetHashCode();
                return hashCode;
            }
        }
    }
}
