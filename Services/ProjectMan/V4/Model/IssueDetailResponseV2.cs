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
    public class IssueDetailResponseV2 
    {

        /// <summary>
        /// **参数解释：** 工作项的实际工时（单位：人/时）。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("actual_work_hours", NullValueHandling = NullValueHandling.Ignore)]
        public double? ActualWorkHours { get; set; }

        /// <summary>
        /// **参数解释：** 当前工作项的抄送人。
        /// </summary>
        [JsonProperty("assigned_cc_user", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserVO> AssignedCcUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("assigned_to", NullValueHandling = NullValueHandling.Ignore)]
        public UserVO AssignedTo { get; set; }

        /// <summary>
        /// **参数解释：** 工作项的预计开始时间，时间戳格式（示例：1754323200000）。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }

        /// <summary>
        /// **参数解释：** 工作项创建时间，时间戳格式（示例：1754374102000）。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("created_on", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedOn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public UserVO Author { get; set; }

        /// <summary>
        /// **参数解释：** 工作项的自定义字段。
        /// </summary>
        [JsonProperty("custom_fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<CustomFieldV2> CustomFields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_value_new", NullValueHandling = NullValueHandling.Ignore)]
        public IssueDetailCustomFieldV2 CustomValueNew { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("developer", NullValueHandling = NullValueHandling.Ignore)]
        public UserVO Developer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public IssueDetailResponseV2Domain Domain { get; set; }

        /// <summary>
        /// **参数解释：** 工作项完成度。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("done_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public int? DoneRatio { get; set; }

        /// <summary>
        /// **参数解释：** 工作项的预计结束时间，时间戳格式（示例：1754323200000）。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// **参数解释：** 工作项的预计完成工时（单位：人/时）。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("expected_work_hours", NullValueHandling = NullValueHandling.Ignore)]
        public double? ExpectedWorkHours { get; set; }

        /// <summary>
        /// **参数解释：** 工作项id。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("project", NullValueHandling = NullValueHandling.Ignore)]
        public ProjectVO Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("iteration", NullValueHandling = NullValueHandling.Ignore)]
        public IssueDetailResponseV2Iteration Iteration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("story_point", NullValueHandling = NullValueHandling.Ignore)]
        public IssueDetailResponseV2StoryPoint StoryPoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("module", NullValueHandling = NullValueHandling.Ignore)]
        public IssueDetailResponseV2Module Module { get; set; }

        /// <summary>
        /// **参数解释：** 工作项的标题。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public string Subject { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("parent_issue", NullValueHandling = NullValueHandling.Ignore)]
        public IssueDetailResponseV2ParentIssue ParentIssue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public IssueDetailResponseV2Priority Priority { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public IssueDetailResponseV2Severity Severity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public IssueDetailResponseV2Status Status { get; set; }

        /// <summary>
        /// **参数解释：** 工作项发布版本号。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("release_dev", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleaseDev { get; set; }

        /// <summary>
        /// **参数解释：** 缺陷发现版本号（仅Bug类型工作项具备该字段）。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("find_release_dev", NullValueHandling = NullValueHandling.Ignore)]
        public string FindReleaseDev { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("env", NullValueHandling = NullValueHandling.Ignore)]
        public IssueDetailResponseV2Env Env { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tracker", NullValueHandling = NullValueHandling.Ignore)]
        public IssueDetailResponseV2Tracker Tracker { get; set; }

        /// <summary>
        /// **参数解释：** 工作项的最后更新时间，时间戳格式（示例：1754374102000）。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("updated_on", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedOn { get; set; }

        /// <summary>
        /// **参数解释：** 工作项的关闭时间，时间戳格式（示例：1754374102000）。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("closed_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ClosedTime { get; set; }

        /// <summary>
        /// **参数解释：** 工作项描述。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释：** 工作项的附件列表。
        /// </summary>
        [JsonProperty("accessories_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<IssueAccessoryV2> AccessoriesList { get; set; }

        /// <summary>
        /// **参数解释：** 工作项更新的评论内容。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("inner_text", NullValueHandling = NullValueHandling.Ignore)]
        public string InnerText { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueDetailResponseV2 {\n");
            sb.Append("  actualWorkHours: ").Append(ActualWorkHours).Append("\n");
            sb.Append("  assignedCcUser: ").Append(AssignedCcUser).Append("\n");
            sb.Append("  assignedTo: ").Append(AssignedTo).Append("\n");
            sb.Append("  startDate: ").Append(StartDate).Append("\n");
            sb.Append("  createdOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  author: ").Append(Author).Append("\n");
            sb.Append("  customFields: ").Append(CustomFields).Append("\n");
            sb.Append("  customValueNew: ").Append(CustomValueNew).Append("\n");
            sb.Append("  developer: ").Append(Developer).Append("\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  doneRatio: ").Append(DoneRatio).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  expectedWorkHours: ").Append(ExpectedWorkHours).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  project: ").Append(Project).Append("\n");
            sb.Append("  iteration: ").Append(Iteration).Append("\n");
            sb.Append("  storyPoint: ").Append(StoryPoint).Append("\n");
            sb.Append("  module: ").Append(Module).Append("\n");
            sb.Append("  subject: ").Append(Subject).Append("\n");
            sb.Append("  parentIssue: ").Append(ParentIssue).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  severity: ").Append(Severity).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  releaseDev: ").Append(ReleaseDev).Append("\n");
            sb.Append("  findReleaseDev: ").Append(FindReleaseDev).Append("\n");
            sb.Append("  env: ").Append(Env).Append("\n");
            sb.Append("  tracker: ").Append(Tracker).Append("\n");
            sb.Append("  updatedOn: ").Append(UpdatedOn).Append("\n");
            sb.Append("  closedTime: ").Append(ClosedTime).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  accessoriesList: ").Append(AccessoriesList).Append("\n");
            sb.Append("  innerText: ").Append(InnerText).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IssueDetailResponseV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IssueDetailResponseV2 input)
        {
            if (input == null) return false;
            if (this.ActualWorkHours != input.ActualWorkHours || (this.ActualWorkHours != null && !this.ActualWorkHours.Equals(input.ActualWorkHours))) return false;
            if (this.AssignedCcUser != input.AssignedCcUser || (this.AssignedCcUser != null && input.AssignedCcUser != null && !this.AssignedCcUser.SequenceEqual(input.AssignedCcUser))) return false;
            if (this.AssignedTo != input.AssignedTo || (this.AssignedTo != null && !this.AssignedTo.Equals(input.AssignedTo))) return false;
            if (this.StartDate != input.StartDate || (this.StartDate != null && !this.StartDate.Equals(input.StartDate))) return false;
            if (this.CreatedOn != input.CreatedOn || (this.CreatedOn != null && !this.CreatedOn.Equals(input.CreatedOn))) return false;
            if (this.Author != input.Author || (this.Author != null && !this.Author.Equals(input.Author))) return false;
            if (this.CustomFields != input.CustomFields || (this.CustomFields != null && input.CustomFields != null && !this.CustomFields.SequenceEqual(input.CustomFields))) return false;
            if (this.CustomValueNew != input.CustomValueNew || (this.CustomValueNew != null && !this.CustomValueNew.Equals(input.CustomValueNew))) return false;
            if (this.Developer != input.Developer || (this.Developer != null && !this.Developer.Equals(input.Developer))) return false;
            if (this.Domain != input.Domain || (this.Domain != null && !this.Domain.Equals(input.Domain))) return false;
            if (this.DoneRatio != input.DoneRatio || (this.DoneRatio != null && !this.DoneRatio.Equals(input.DoneRatio))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.ExpectedWorkHours != input.ExpectedWorkHours || (this.ExpectedWorkHours != null && !this.ExpectedWorkHours.Equals(input.ExpectedWorkHours))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Project != input.Project || (this.Project != null && !this.Project.Equals(input.Project))) return false;
            if (this.Iteration != input.Iteration || (this.Iteration != null && !this.Iteration.Equals(input.Iteration))) return false;
            if (this.StoryPoint != input.StoryPoint || (this.StoryPoint != null && !this.StoryPoint.Equals(input.StoryPoint))) return false;
            if (this.Module != input.Module || (this.Module != null && !this.Module.Equals(input.Module))) return false;
            if (this.Subject != input.Subject || (this.Subject != null && !this.Subject.Equals(input.Subject))) return false;
            if (this.ParentIssue != input.ParentIssue || (this.ParentIssue != null && !this.ParentIssue.Equals(input.ParentIssue))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.Severity != input.Severity || (this.Severity != null && !this.Severity.Equals(input.Severity))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.ReleaseDev != input.ReleaseDev || (this.ReleaseDev != null && !this.ReleaseDev.Equals(input.ReleaseDev))) return false;
            if (this.FindReleaseDev != input.FindReleaseDev || (this.FindReleaseDev != null && !this.FindReleaseDev.Equals(input.FindReleaseDev))) return false;
            if (this.Env != input.Env || (this.Env != null && !this.Env.Equals(input.Env))) return false;
            if (this.Tracker != input.Tracker || (this.Tracker != null && !this.Tracker.Equals(input.Tracker))) return false;
            if (this.UpdatedOn != input.UpdatedOn || (this.UpdatedOn != null && !this.UpdatedOn.Equals(input.UpdatedOn))) return false;
            if (this.ClosedTime != input.ClosedTime || (this.ClosedTime != null && !this.ClosedTime.Equals(input.ClosedTime))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.AccessoriesList != input.AccessoriesList || (this.AccessoriesList != null && input.AccessoriesList != null && !this.AccessoriesList.SequenceEqual(input.AccessoriesList))) return false;
            if (this.InnerText != input.InnerText || (this.InnerText != null && !this.InnerText.Equals(input.InnerText))) return false;

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
                if (this.ActualWorkHours != null) hashCode = hashCode * 59 + this.ActualWorkHours.GetHashCode();
                if (this.AssignedCcUser != null) hashCode = hashCode * 59 + this.AssignedCcUser.GetHashCode();
                if (this.AssignedTo != null) hashCode = hashCode * 59 + this.AssignedTo.GetHashCode();
                if (this.StartDate != null) hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.CreatedOn != null) hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.Author != null) hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.CustomFields != null) hashCode = hashCode * 59 + this.CustomFields.GetHashCode();
                if (this.CustomValueNew != null) hashCode = hashCode * 59 + this.CustomValueNew.GetHashCode();
                if (this.Developer != null) hashCode = hashCode * 59 + this.Developer.GetHashCode();
                if (this.Domain != null) hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.DoneRatio != null) hashCode = hashCode * 59 + this.DoneRatio.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.ExpectedWorkHours != null) hashCode = hashCode * 59 + this.ExpectedWorkHours.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Project != null) hashCode = hashCode * 59 + this.Project.GetHashCode();
                if (this.Iteration != null) hashCode = hashCode * 59 + this.Iteration.GetHashCode();
                if (this.StoryPoint != null) hashCode = hashCode * 59 + this.StoryPoint.GetHashCode();
                if (this.Module != null) hashCode = hashCode * 59 + this.Module.GetHashCode();
                if (this.Subject != null) hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.ParentIssue != null) hashCode = hashCode * 59 + this.ParentIssue.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.Severity != null) hashCode = hashCode * 59 + this.Severity.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ReleaseDev != null) hashCode = hashCode * 59 + this.ReleaseDev.GetHashCode();
                if (this.FindReleaseDev != null) hashCode = hashCode * 59 + this.FindReleaseDev.GetHashCode();
                if (this.Env != null) hashCode = hashCode * 59 + this.Env.GetHashCode();
                if (this.Tracker != null) hashCode = hashCode * 59 + this.Tracker.GetHashCode();
                if (this.UpdatedOn != null) hashCode = hashCode * 59 + this.UpdatedOn.GetHashCode();
                if (this.ClosedTime != null) hashCode = hashCode * 59 + this.ClosedTime.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.AccessoriesList != null) hashCode = hashCode * 59 + this.AccessoriesList.GetHashCode();
                if (this.InnerText != null) hashCode = hashCode * 59 + this.InnerText.GetHashCode();
                return hashCode;
            }
        }
    }
}
