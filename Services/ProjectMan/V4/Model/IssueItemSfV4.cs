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
    public class IssueItemSfV4 
    {

        /// <summary>
        /// 实际工时
        /// </summary>
        [JsonProperty("actual_work_hours", NullValueHandling = NullValueHandling.Ignore)]
        public double? ActualWorkHours { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("assigned_user", NullValueHandling = NullValueHandling.Ignore)]
        public IssueUser AssignedUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public IssueUser Author { get; set; }

        /// <summary>
        /// 工作项开始时间
        /// </summary>
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// 关闭工作项的时间
        /// </summary>
        [JsonProperty("closed_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ClosedTime { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("created_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreatedTime { get; set; }

        /// <summary>
        /// 自定义属性
        /// </summary>
        [JsonProperty("custom_feilds", NullValueHandling = NullValueHandling.Ignore)]
        public List<CustomFeildRecord> CustomFeilds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("developer", NullValueHandling = NullValueHandling.Ignore)]
        public IssueUser Developer { get; set; }

        /// <summary>
        /// 发现问题的版本
        /// </summary>
        [JsonProperty("discover_version", NullValueHandling = NullValueHandling.Ignore)]
        public string DiscoverVersion { get; set; }

        /// <summary>
        /// 工作项结束时间
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }

        /// <summary>
        /// 工作项进度值
        /// </summary>
        [JsonProperty("done_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public int? DoneRatio { get; set; }

        /// <summary>
        /// 预计工时
        /// </summary>
        [JsonProperty("expected_work_hours", NullValueHandling = NullValueHandling.Ignore)]
        public double? ExpectedWorkHours { get; set; }

        /// <summary>
        /// 顺序
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public int? Order { get; set; }

        /// <summary>
        /// 父工作项的id
        /// </summary>
        [JsonProperty("parent_issue_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ParentIssueId { get; set; }

        /// <summary>
        /// 发布的版本
        /// </summary>
        [JsonProperty("release_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleaseVersion { get; set; }

        /// <summary>
        /// 根工作项的id
        /// </summary>
        [JsonProperty("root_issue_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RootIssueId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("story_point", NullValueHandling = NullValueHandling.Ignore)]
        public IssueItemSfV4StoryPoint StoryPoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public IssueItemSfV4Domain Domain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("iteration", NullValueHandling = NullValueHandling.Ignore)]
        public IssueItemSfV4Iteration Iteration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("module", NullValueHandling = NullValueHandling.Ignore)]
        public IssueItemSfV4Module Module { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public IssueItemSfV4Priority Priority { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public IssueItemSfV4Severity Severity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public IssueItemSfV4Status Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tracker", NullValueHandling = NullValueHandling.Ignore)]
        public IssueItemSfV4Tracker Tracker { get; set; }

        /// <summary>
        /// 工作项标题
        /// </summary>
        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public string Subject { get; set; }

        /// <summary>
        /// 工作项更新时间
        /// </summary>
        [JsonProperty("updated_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdatedTime { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueItemSfV4 {\n");
            sb.Append("  actualWorkHours: ").Append(ActualWorkHours).Append("\n");
            sb.Append("  assignedUser: ").Append(AssignedUser).Append("\n");
            sb.Append("  author: ").Append(Author).Append("\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  closedTime: ").Append(ClosedTime).Append("\n");
            sb.Append("  createdTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  customFeilds: ").Append(CustomFeilds).Append("\n");
            sb.Append("  developer: ").Append(Developer).Append("\n");
            sb.Append("  discoverVersion: ").Append(DiscoverVersion).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  doneRatio: ").Append(DoneRatio).Append("\n");
            sb.Append("  expectedWorkHours: ").Append(ExpectedWorkHours).Append("\n");
            sb.Append("  order: ").Append(Order).Append("\n");
            sb.Append("  parentIssueId: ").Append(ParentIssueId).Append("\n");
            sb.Append("  releaseVersion: ").Append(ReleaseVersion).Append("\n");
            sb.Append("  rootIssueId: ").Append(RootIssueId).Append("\n");
            sb.Append("  storyPoint: ").Append(StoryPoint).Append("\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  iteration: ").Append(Iteration).Append("\n");
            sb.Append("  module: ").Append(Module).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  severity: ").Append(Severity).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  tracker: ").Append(Tracker).Append("\n");
            sb.Append("  subject: ").Append(Subject).Append("\n");
            sb.Append("  updatedTime: ").Append(UpdatedTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IssueItemSfV4);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IssueItemSfV4 input)
        {
            if (input == null)
                return false;

            return 
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
                    this.ClosedTime == input.ClosedTime ||
                    (this.ClosedTime != null &&
                    this.ClosedTime.Equals(input.ClosedTime))
                ) && 
                (
                    this.CreatedTime == input.CreatedTime ||
                    (this.CreatedTime != null &&
                    this.CreatedTime.Equals(input.CreatedTime))
                ) && 
                (
                    this.CustomFeilds == input.CustomFeilds ||
                    this.CustomFeilds != null &&
                    input.CustomFeilds != null &&
                    this.CustomFeilds.SequenceEqual(input.CustomFeilds)
                ) && 
                (
                    this.Developer == input.Developer ||
                    (this.Developer != null &&
                    this.Developer.Equals(input.Developer))
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
                    this.ParentIssueId == input.ParentIssueId ||
                    (this.ParentIssueId != null &&
                    this.ParentIssueId.Equals(input.ParentIssueId))
                ) && 
                (
                    this.ReleaseVersion == input.ReleaseVersion ||
                    (this.ReleaseVersion != null &&
                    this.ReleaseVersion.Equals(input.ReleaseVersion))
                ) && 
                (
                    this.RootIssueId == input.RootIssueId ||
                    (this.RootIssueId != null &&
                    this.RootIssueId.Equals(input.RootIssueId))
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
                    this.Tracker == input.Tracker ||
                    (this.Tracker != null &&
                    this.Tracker.Equals(input.Tracker))
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
                if (this.ActualWorkHours != null)
                    hashCode = hashCode * 59 + this.ActualWorkHours.GetHashCode();
                if (this.AssignedUser != null)
                    hashCode = hashCode * 59 + this.AssignedUser.GetHashCode();
                if (this.Author != null)
                    hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.BeginTime != null)
                    hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.ClosedTime != null)
                    hashCode = hashCode * 59 + this.ClosedTime.GetHashCode();
                if (this.CreatedTime != null)
                    hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.CustomFeilds != null)
                    hashCode = hashCode * 59 + this.CustomFeilds.GetHashCode();
                if (this.Developer != null)
                    hashCode = hashCode * 59 + this.Developer.GetHashCode();
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
                if (this.ParentIssueId != null)
                    hashCode = hashCode * 59 + this.ParentIssueId.GetHashCode();
                if (this.ReleaseVersion != null)
                    hashCode = hashCode * 59 + this.ReleaseVersion.GetHashCode();
                if (this.RootIssueId != null)
                    hashCode = hashCode * 59 + this.RootIssueId.GetHashCode();
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
                if (this.Tracker != null)
                    hashCode = hashCode * 59 + this.Tracker.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.UpdatedTime != null)
                    hashCode = hashCode * 59 + this.UpdatedTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
