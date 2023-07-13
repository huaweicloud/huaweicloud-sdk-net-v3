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
    public class ListWorkTableIssueRequestV4RequestBody 
    {

        /// <summary>
        /// 偏移量,offset是limit的整数倍，limit&#x3D;10,offset&#x3D;0,10,20...
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每页显示数量
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 搜索关键词
        /// </summary>
        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public string Subject { get; set; }

        /// <summary>
        /// 工作项创建时间区间
        /// </summary>
        [JsonProperty("created_on", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedOn { get; set; }

        /// <summary>
        /// 工作项更新时间区间
        /// </summary>
        [JsonProperty("updated_on", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedOn { get; set; }

        /// <summary>
        /// 工作项结束时间区间
        /// </summary>
        [JsonProperty("closed_on", NullValueHandling = NullValueHandling.Ignore)]
        public string ClosedOn { get; set; }

        /// <summary>
        /// 工作项预计开始日期区间
        /// </summary>
        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }

        /// <summary>
        /// 工作项预计结束日期区间
        /// </summary>
        [JsonProperty("due_date", NullValueHandling = NullValueHandling.Ignore)]
        public string DueDate { get; set; }

        /// <summary>
        /// 工作项类型
        /// </summary>
        [JsonProperty("tracker_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TrackerId { get; set; }

        /// <summary>
        /// 工作项状态
        /// </summary>
        [JsonProperty("status_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusId { get; set; }

        /// <summary>
        /// 工作项创建人id
        /// </summary>
        [JsonProperty("author_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorId { get; set; }

        /// <summary>
        /// 工作项开发人员id
        /// </summary>
        [JsonProperty("developer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DeveloperId { get; set; }

        /// <summary>
        /// 工作项优先级id
        /// </summary>
        [JsonProperty("priority_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PriorityId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListWorkTableIssueRequestV4RequestBody {\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  subject: ").Append(Subject).Append("\n");
            sb.Append("  createdOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  updatedOn: ").Append(UpdatedOn).Append("\n");
            sb.Append("  closedOn: ").Append(ClosedOn).Append("\n");
            sb.Append("  startDate: ").Append(StartDate).Append("\n");
            sb.Append("  dueDate: ").Append(DueDate).Append("\n");
            sb.Append("  trackerId: ").Append(TrackerId).Append("\n");
            sb.Append("  statusId: ").Append(StatusId).Append("\n");
            sb.Append("  authorId: ").Append(AuthorId).Append("\n");
            sb.Append("  developerId: ").Append(DeveloperId).Append("\n");
            sb.Append("  priorityId: ").Append(PriorityId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListWorkTableIssueRequestV4RequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListWorkTableIssueRequestV4RequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && 
                (
                    this.UpdatedOn == input.UpdatedOn ||
                    (this.UpdatedOn != null &&
                    this.UpdatedOn.Equals(input.UpdatedOn))
                ) && 
                (
                    this.ClosedOn == input.ClosedOn ||
                    (this.ClosedOn != null &&
                    this.ClosedOn.Equals(input.ClosedOn))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.DueDate == input.DueDate ||
                    (this.DueDate != null &&
                    this.DueDate.Equals(input.DueDate))
                ) && 
                (
                    this.TrackerId == input.TrackerId ||
                    (this.TrackerId != null &&
                    this.TrackerId.Equals(input.TrackerId))
                ) && 
                (
                    this.StatusId == input.StatusId ||
                    (this.StatusId != null &&
                    this.StatusId.Equals(input.StatusId))
                ) && 
                (
                    this.AuthorId == input.AuthorId ||
                    (this.AuthorId != null &&
                    this.AuthorId.Equals(input.AuthorId))
                ) && 
                (
                    this.DeveloperId == input.DeveloperId ||
                    (this.DeveloperId != null &&
                    this.DeveloperId.Equals(input.DeveloperId))
                ) && 
                (
                    this.PriorityId == input.PriorityId ||
                    (this.PriorityId != null &&
                    this.PriorityId.Equals(input.PriorityId))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.UpdatedOn != null)
                    hashCode = hashCode * 59 + this.UpdatedOn.GetHashCode();
                if (this.ClosedOn != null)
                    hashCode = hashCode * 59 + this.ClosedOn.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.DueDate != null)
                    hashCode = hashCode * 59 + this.DueDate.GetHashCode();
                if (this.TrackerId != null)
                    hashCode = hashCode * 59 + this.TrackerId.GetHashCode();
                if (this.StatusId != null)
                    hashCode = hashCode * 59 + this.StatusId.GetHashCode();
                if (this.AuthorId != null)
                    hashCode = hashCode * 59 + this.AuthorId.GetHashCode();
                if (this.DeveloperId != null)
                    hashCode = hashCode * 59 + this.DeveloperId.GetHashCode();
                if (this.PriorityId != null)
                    hashCode = hashCode * 59 + this.PriorityId.GetHashCode();
                return hashCode;
            }
        }
    }
}
