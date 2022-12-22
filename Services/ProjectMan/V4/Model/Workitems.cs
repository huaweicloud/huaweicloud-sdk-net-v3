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
    public class Workitems 
    {

        /// <summary>
        /// 工作项id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 工作项描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 实际工时
        /// </summary>
        [JsonProperty("actual_work_hours", NullValueHandling = NullValueHandling.Ignore)]
        public double? ActualWorkHours { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("assigned_user", NullValueHandling = NullValueHandling.Ignore)]
        public WorkitemUser AssignedUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public WorkitemUser Author { get; set; }

        /// <summary>
        /// 工作项开始时间
        /// </summary>
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string BeginTime { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("created_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<WorkitemsTags> Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("developer", NullValueHandling = NullValueHandling.Ignore)]
        public WorkitemUser Developer { get; set; }

        /// <summary>
        /// 抄送人
        /// </summary>
        [JsonProperty("assigned_cc_user", NullValueHandling = NullValueHandling.Ignore)]
        public List<WorkitemUser> AssignedCcUser { get; set; }

        /// <summary>
        /// 发现问题的版本
        /// </summary>
        [JsonProperty("discover_version", NullValueHandling = NullValueHandling.Ignore)]
        public string DiscoverVersion { get; set; }

        /// <summary>
        /// 工作项结束时间
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 工作项进度值
        /// </summary>
        [JsonProperty("done_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public string DoneRatio { get; set; }

        /// <summary>
        /// 预计工时
        /// </summary>
        [JsonProperty("expected_work_hours", NullValueHandling = NullValueHandling.Ignore)]
        public double? ExpectedWorkHours { get; set; }

        /// <summary>
        /// 顺序
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public string Order { get; set; }

        /// <summary>
        /// 父工作项的id
        /// </summary>
        [JsonProperty("parent_work_item_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentWorkItemId { get; set; }

        /// <summary>
        /// 发布的版本
        /// </summary>
        [JsonProperty("release_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleaseVersion { get; set; }

        /// <summary>
        /// 故事点
        /// </summary>
        [JsonProperty("story_point", NullValueHandling = NullValueHandling.Ignore)]
        public string StoryPoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public WorkitemsDomain Domain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("iteration", NullValueHandling = NullValueHandling.Ignore)]
        public WorkitemsIteration Iteration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("module", NullValueHandling = NullValueHandling.Ignore)]
        public WorkitemsModule Module { get; set; }

        /// <summary>
        /// 工作项优先级
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public string Priority { get; set; }

        /// <summary>
        /// 严重的程度 \&quot;提示\&quot;, \&quot;一般\&quot;, \&quot;严重\&quot;, \&quot;致命\&quot;
        /// </summary>
        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public string Severity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public WorkitemsStatus Status { get; set; }

        /// <summary>
        /// 工作项标题
        /// </summary>
        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public string Subject { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("updated_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedTime { get; set; }

        /// <summary>
        /// 工作项编号
        /// </summary>
        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        public string Sequence { get; set; }

        /// <summary>
        /// 重要程度 \&quot;关键\&quot;, \&quot;重要\&quot;, \&quot;一般\&quot;, \&quot;提示\&quot;
        /// </summary>
        [JsonProperty("important", NullValueHandling = NullValueHandling.Ignore)]
        public string Important { get; set; }

        /// <summary>
        /// 用户自定义字段
        /// </summary>
        [JsonProperty("custom_fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<WorkitemCustomField> CustomFields { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Workitems {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  actualWorkHours: ").Append(ActualWorkHours).Append("\n");
            sb.Append("  assignedUser: ").Append(AssignedUser).Append("\n");
            sb.Append("  author: ").Append(Author).Append("\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  createdTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  developer: ").Append(Developer).Append("\n");
            sb.Append("  assignedCcUser: ").Append(AssignedCcUser).Append("\n");
            sb.Append("  discoverVersion: ").Append(DiscoverVersion).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  doneRatio: ").Append(DoneRatio).Append("\n");
            sb.Append("  expectedWorkHours: ").Append(ExpectedWorkHours).Append("\n");
            sb.Append("  order: ").Append(Order).Append("\n");
            sb.Append("  parentWorkItemId: ").Append(ParentWorkItemId).Append("\n");
            sb.Append("  releaseVersion: ").Append(ReleaseVersion).Append("\n");
            sb.Append("  storyPoint: ").Append(StoryPoint).Append("\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  iteration: ").Append(Iteration).Append("\n");
            sb.Append("  module: ").Append(Module).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  severity: ").Append(Severity).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  subject: ").Append(Subject).Append("\n");
            sb.Append("  updatedTime: ").Append(UpdatedTime).Append("\n");
            sb.Append("  sequence: ").Append(Sequence).Append("\n");
            sb.Append("  important: ").Append(Important).Append("\n");
            sb.Append("  customFields: ").Append(CustomFields).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Workitems);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Workitems input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ActualWorkHours == input.ActualWorkHours ||
                    (this.ActualWorkHours != null &&
                    this.ActualWorkHours.Equals(input.ActualWorkHours))
                ) && 
                (
                    this.AssignedUser == input.AssignedUser ||
                    (this.AssignedUser != null &&
                    this.AssignedUser.Equals(input.AssignedUser))
                ) && 
                (
                    this.Author == input.Author ||
                    (this.Author != null &&
                    this.Author.Equals(input.Author))
                ) && 
                (
                    this.BeginTime == input.BeginTime ||
                    (this.BeginTime != null &&
                    this.BeginTime.Equals(input.BeginTime))
                ) && 
                (
                    this.CreatedTime == input.CreatedTime ||
                    (this.CreatedTime != null &&
                    this.CreatedTime.Equals(input.CreatedTime))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Developer == input.Developer ||
                    (this.Developer != null &&
                    this.Developer.Equals(input.Developer))
                ) && 
                (
                    this.AssignedCcUser == input.AssignedCcUser ||
                    this.AssignedCcUser != null &&
                    input.AssignedCcUser != null &&
                    this.AssignedCcUser.SequenceEqual(input.AssignedCcUser)
                ) && 
                (
                    this.DiscoverVersion == input.DiscoverVersion ||
                    (this.DiscoverVersion != null &&
                    this.DiscoverVersion.Equals(input.DiscoverVersion))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.DoneRatio == input.DoneRatio ||
                    (this.DoneRatio != null &&
                    this.DoneRatio.Equals(input.DoneRatio))
                ) && 
                (
                    this.ExpectedWorkHours == input.ExpectedWorkHours ||
                    (this.ExpectedWorkHours != null &&
                    this.ExpectedWorkHours.Equals(input.ExpectedWorkHours))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.ParentWorkItemId == input.ParentWorkItemId ||
                    (this.ParentWorkItemId != null &&
                    this.ParentWorkItemId.Equals(input.ParentWorkItemId))
                ) && 
                (
                    this.ReleaseVersion == input.ReleaseVersion ||
                    (this.ReleaseVersion != null &&
                    this.ReleaseVersion.Equals(input.ReleaseVersion))
                ) && 
                (
                    this.StoryPoint == input.StoryPoint ||
                    (this.StoryPoint != null &&
                    this.StoryPoint.Equals(input.StoryPoint))
                ) && 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.Iteration == input.Iteration ||
                    (this.Iteration != null &&
                    this.Iteration.Equals(input.Iteration))
                ) && 
                (
                    this.Module == input.Module ||
                    (this.Module != null &&
                    this.Module.Equals(input.Module))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.Severity == input.Severity ||
                    (this.Severity != null &&
                    this.Severity.Equals(input.Severity))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.UpdatedTime == input.UpdatedTime ||
                    (this.UpdatedTime != null &&
                    this.UpdatedTime.Equals(input.UpdatedTime))
                ) && 
                (
                    this.Sequence == input.Sequence ||
                    (this.Sequence != null &&
                    this.Sequence.Equals(input.Sequence))
                ) && 
                (
                    this.Important == input.Important ||
                    (this.Important != null &&
                    this.Important.Equals(input.Important))
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    this.CustomFields != null &&
                    input.CustomFields != null &&
                    this.CustomFields.SequenceEqual(input.CustomFields)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ActualWorkHours != null)
                    hashCode = hashCode * 59 + this.ActualWorkHours.GetHashCode();
                if (this.AssignedUser != null)
                    hashCode = hashCode * 59 + this.AssignedUser.GetHashCode();
                if (this.Author != null)
                    hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.BeginTime != null)
                    hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.CreatedTime != null)
                    hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Developer != null)
                    hashCode = hashCode * 59 + this.Developer.GetHashCode();
                if (this.AssignedCcUser != null)
                    hashCode = hashCode * 59 + this.AssignedCcUser.GetHashCode();
                if (this.DiscoverVersion != null)
                    hashCode = hashCode * 59 + this.DiscoverVersion.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.DoneRatio != null)
                    hashCode = hashCode * 59 + this.DoneRatio.GetHashCode();
                if (this.ExpectedWorkHours != null)
                    hashCode = hashCode * 59 + this.ExpectedWorkHours.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.ParentWorkItemId != null)
                    hashCode = hashCode * 59 + this.ParentWorkItemId.GetHashCode();
                if (this.ReleaseVersion != null)
                    hashCode = hashCode * 59 + this.ReleaseVersion.GetHashCode();
                if (this.StoryPoint != null)
                    hashCode = hashCode * 59 + this.StoryPoint.GetHashCode();
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.Iteration != null)
                    hashCode = hashCode * 59 + this.Iteration.GetHashCode();
                if (this.Module != null)
                    hashCode = hashCode * 59 + this.Module.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.Severity != null)
                    hashCode = hashCode * 59 + this.Severity.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.UpdatedTime != null)
                    hashCode = hashCode * 59 + this.UpdatedTime.GetHashCode();
                if (this.Sequence != null)
                    hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                if (this.Important != null)
                    hashCode = hashCode * 59 + this.Important.GetHashCode();
                if (this.CustomFields != null)
                    hashCode = hashCode * 59 + this.CustomFields.GetHashCode();
                return hashCode;
            }
        }
    }
}
