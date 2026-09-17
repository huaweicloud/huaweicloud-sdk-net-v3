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
    /// **参数解释：** 工作项。 **取值范围：** 不涉及。
    /// </summary>
    public class IssueNew 
    {

        /// <summary>
        /// **参数解释：** 工作项的更新日期。时间戳格式（示例：1839340800000） 。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("updated_on", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedOn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("story_point", NullValueHandling = NullValueHandling.Ignore)]
        public StoryPoint StoryPoint { get; set; }

        /// <summary>
        /// **参数解释：** 工作项的负责者。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public string Subject { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("project", NullValueHandling = NullValueHandling.Ignore)]
        public Project Project { get; set; }

        /// <summary>
        /// **参数解释：** 是否有子工作项。 **取值范围：** true（有子工作项） false（没有子工作项）
        /// </summary>
        [JsonProperty("isParent", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsParent { get; set; }

        /// <summary>
        /// **参数解释：** 工作项完成度。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("done_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public int? DoneRatio { get; set; }

        /// <summary>
        /// **参数解释：** 发布人 。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("findReleaseDev", NullValueHandling = NullValueHandling.Ignore)]
        public string FindReleaseDev { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tracker", NullValueHandling = NullValueHandling.Ignore)]
        public Tracker Tracker { get; set; }

        /// <summary>
        /// **参数解释：** 工作项列表id。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** 工作项的开始日期。时间戳格式（示例：1839340800000）。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("assigned_to", NullValueHandling = NullValueHandling.Ignore)]
        public IssueNewAssignedTo AssignedTo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status_attribute", NullValueHandling = NullValueHandling.Ignore)]
        public StatusAttributeVO StatusAttribute { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public Severity Severity { get; set; }

        /// <summary>
        /// **参数解释：** 工作项发布版本号。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("releaseDev", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleaseDev { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public IssueNewAuthor Author { get; set; }

        /// <summary>
        /// **参数解释：** 工作项的模块。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("module", NullValueHandling = NullValueHandling.Ignore)]
        public Object Module { get; set; }

        /// <summary>
        /// **参数解释：** 工作项的截止日期，时间戳格式（示例：1839340800000）。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("due_date", NullValueHandling = NullValueHandling.Ignore)]
        public string DueDate { get; set; }

        /// <summary>
        /// **参数解释：** 工作项的预计工时(单位：人时)。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("expected_work_hours", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpectedWorkHours { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public Priority Priority { get; set; }

        /// <summary>
        /// **参数解释：** 工作项的实际工时（单位：人/时）。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("actual_work_hours", NullValueHandling = NullValueHandling.Ignore)]
        public int? ActualWorkHours { get; set; }

        /// <summary>
        /// **参数解释：** 是否关注 。 **取值范围：** true（是） false（不是）
        /// </summary>
        [JsonProperty("is_watcher", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsWatcher { get; set; }

        /// <summary>
        /// **参数解释：** 是否删除 。 **取值范围：** true（是） false（不是）
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// **参数解释：** 问题解决版本。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("fixed_version", NullValueHandling = NullValueHandling.Ignore)]
        public Object FixedVersion { get; set; }

        /// <summary>
        /// **参数解释：** 是否归档。 **取值范围：** true（是） false（不是）
        /// </summary>
        [JsonProperty("is_archived", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsArchived { get; set; }

        /// <summary>
        /// **参数解释：** 工作项的创建时间，时间戳格式（示例：1839340800000）。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("created_on", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedOn { get; set; }

        /// <summary>
        /// **参数解释：** 工作项的领域 。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public Object Domain { get; set; }

        /// <summary>
        /// **参数解释：** 工作项的开发人员。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("developer", NullValueHandling = NullValueHandling.Ignore)]
        public Object Developer { get; set; }

        /// <summary>
        /// **参数解释：** 关闭人员。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("closeder", NullValueHandling = NullValueHandling.Ignore)]
        public Object Closeder { get; set; }

        /// <summary>
        /// **参数解释：** 工作项在列表的展示位置 。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public string Position { get; set; }

        /// <summary>
        /// **参数解释：** 关闭标志 。 **取值范围：** 0（打开） 1（关闭）
        /// </summary>
        [JsonProperty("closed_flag", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClosedFlag { get; set; }

        /// <summary>
        /// **参数解释：** 工作项的抄送人。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("assigned_cc_user", NullValueHandling = NullValueHandling.Ignore)]
        public string AssignedCcUser { get; set; }

        /// <summary>
        /// **参数解释：** 自定义字段。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("custom_value_new", NullValueHandling = NullValueHandling.Ignore)]
        public Object CustomValueNew { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Status Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueNew {\n");
            sb.Append("  updatedOn: ").Append(UpdatedOn).Append("\n");
            sb.Append("  storyPoint: ").Append(StoryPoint).Append("\n");
            sb.Append("  subject: ").Append(Subject).Append("\n");
            sb.Append("  project: ").Append(Project).Append("\n");
            sb.Append("  isParent: ").Append(IsParent).Append("\n");
            sb.Append("  doneRatio: ").Append(DoneRatio).Append("\n");
            sb.Append("  findReleaseDev: ").Append(FindReleaseDev).Append("\n");
            sb.Append("  tracker: ").Append(Tracker).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  startDate: ").Append(StartDate).Append("\n");
            sb.Append("  assignedTo: ").Append(AssignedTo).Append("\n");
            sb.Append("  statusAttribute: ").Append(StatusAttribute).Append("\n");
            sb.Append("  severity: ").Append(Severity).Append("\n");
            sb.Append("  releaseDev: ").Append(ReleaseDev).Append("\n");
            sb.Append("  author: ").Append(Author).Append("\n");
            sb.Append("  module: ").Append(Module).Append("\n");
            sb.Append("  dueDate: ").Append(DueDate).Append("\n");
            sb.Append("  expectedWorkHours: ").Append(ExpectedWorkHours).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  actualWorkHours: ").Append(ActualWorkHours).Append("\n");
            sb.Append("  isWatcher: ").Append(IsWatcher).Append("\n");
            sb.Append("  deleted: ").Append(Deleted).Append("\n");
            sb.Append("  fixedVersion: ").Append(FixedVersion).Append("\n");
            sb.Append("  isArchived: ").Append(IsArchived).Append("\n");
            sb.Append("  createdOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  developer: ").Append(Developer).Append("\n");
            sb.Append("  closeder: ").Append(Closeder).Append("\n");
            sb.Append("  position: ").Append(Position).Append("\n");
            sb.Append("  closedFlag: ").Append(ClosedFlag).Append("\n");
            sb.Append("  assignedCcUser: ").Append(AssignedCcUser).Append("\n");
            sb.Append("  customValueNew: ").Append(CustomValueNew).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IssueNew);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IssueNew input)
        {
            if (input == null) return false;
            if (this.UpdatedOn != input.UpdatedOn || (this.UpdatedOn != null && !this.UpdatedOn.Equals(input.UpdatedOn))) return false;
            if (this.StoryPoint != input.StoryPoint || (this.StoryPoint != null && !this.StoryPoint.Equals(input.StoryPoint))) return false;
            if (this.Subject != input.Subject || (this.Subject != null && !this.Subject.Equals(input.Subject))) return false;
            if (this.Project != input.Project || (this.Project != null && !this.Project.Equals(input.Project))) return false;
            if (this.IsParent != input.IsParent || (this.IsParent != null && !this.IsParent.Equals(input.IsParent))) return false;
            if (this.DoneRatio != input.DoneRatio || (this.DoneRatio != null && !this.DoneRatio.Equals(input.DoneRatio))) return false;
            if (this.FindReleaseDev != input.FindReleaseDev || (this.FindReleaseDev != null && !this.FindReleaseDev.Equals(input.FindReleaseDev))) return false;
            if (this.Tracker != input.Tracker || (this.Tracker != null && !this.Tracker.Equals(input.Tracker))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.StartDate != input.StartDate || (this.StartDate != null && !this.StartDate.Equals(input.StartDate))) return false;
            if (this.AssignedTo != input.AssignedTo || (this.AssignedTo != null && !this.AssignedTo.Equals(input.AssignedTo))) return false;
            if (this.StatusAttribute != input.StatusAttribute || (this.StatusAttribute != null && !this.StatusAttribute.Equals(input.StatusAttribute))) return false;
            if (this.Severity != input.Severity || (this.Severity != null && !this.Severity.Equals(input.Severity))) return false;
            if (this.ReleaseDev != input.ReleaseDev || (this.ReleaseDev != null && !this.ReleaseDev.Equals(input.ReleaseDev))) return false;
            if (this.Author != input.Author || (this.Author != null && !this.Author.Equals(input.Author))) return false;
            if (this.Module != input.Module || (this.Module != null && !this.Module.Equals(input.Module))) return false;
            if (this.DueDate != input.DueDate || (this.DueDate != null && !this.DueDate.Equals(input.DueDate))) return false;
            if (this.ExpectedWorkHours != input.ExpectedWorkHours || (this.ExpectedWorkHours != null && !this.ExpectedWorkHours.Equals(input.ExpectedWorkHours))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.ActualWorkHours != input.ActualWorkHours || (this.ActualWorkHours != null && !this.ActualWorkHours.Equals(input.ActualWorkHours))) return false;
            if (this.IsWatcher != input.IsWatcher || (this.IsWatcher != null && !this.IsWatcher.Equals(input.IsWatcher))) return false;
            if (this.Deleted != input.Deleted || (this.Deleted != null && !this.Deleted.Equals(input.Deleted))) return false;
            if (this.FixedVersion != input.FixedVersion || (this.FixedVersion != null && !this.FixedVersion.Equals(input.FixedVersion))) return false;
            if (this.IsArchived != input.IsArchived || (this.IsArchived != null && !this.IsArchived.Equals(input.IsArchived))) return false;
            if (this.CreatedOn != input.CreatedOn || (this.CreatedOn != null && !this.CreatedOn.Equals(input.CreatedOn))) return false;
            if (this.Domain != input.Domain || (this.Domain != null && !this.Domain.Equals(input.Domain))) return false;
            if (this.Developer != input.Developer || (this.Developer != null && !this.Developer.Equals(input.Developer))) return false;
            if (this.Closeder != input.Closeder || (this.Closeder != null && !this.Closeder.Equals(input.Closeder))) return false;
            if (this.Position != input.Position || (this.Position != null && !this.Position.Equals(input.Position))) return false;
            if (this.ClosedFlag != input.ClosedFlag || (this.ClosedFlag != null && !this.ClosedFlag.Equals(input.ClosedFlag))) return false;
            if (this.AssignedCcUser != input.AssignedCcUser || (this.AssignedCcUser != null && !this.AssignedCcUser.Equals(input.AssignedCcUser))) return false;
            if (this.CustomValueNew != input.CustomValueNew || (this.CustomValueNew != null && !this.CustomValueNew.Equals(input.CustomValueNew))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                if (this.UpdatedOn != null) hashCode = hashCode * 59 + this.UpdatedOn.GetHashCode();
                if (this.StoryPoint != null) hashCode = hashCode * 59 + this.StoryPoint.GetHashCode();
                if (this.Subject != null) hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Project != null) hashCode = hashCode * 59 + this.Project.GetHashCode();
                if (this.IsParent != null) hashCode = hashCode * 59 + this.IsParent.GetHashCode();
                if (this.DoneRatio != null) hashCode = hashCode * 59 + this.DoneRatio.GetHashCode();
                if (this.FindReleaseDev != null) hashCode = hashCode * 59 + this.FindReleaseDev.GetHashCode();
                if (this.Tracker != null) hashCode = hashCode * 59 + this.Tracker.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.StartDate != null) hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.AssignedTo != null) hashCode = hashCode * 59 + this.AssignedTo.GetHashCode();
                if (this.StatusAttribute != null) hashCode = hashCode * 59 + this.StatusAttribute.GetHashCode();
                if (this.Severity != null) hashCode = hashCode * 59 + this.Severity.GetHashCode();
                if (this.ReleaseDev != null) hashCode = hashCode * 59 + this.ReleaseDev.GetHashCode();
                if (this.Author != null) hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.Module != null) hashCode = hashCode * 59 + this.Module.GetHashCode();
                if (this.DueDate != null) hashCode = hashCode * 59 + this.DueDate.GetHashCode();
                if (this.ExpectedWorkHours != null) hashCode = hashCode * 59 + this.ExpectedWorkHours.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.ActualWorkHours != null) hashCode = hashCode * 59 + this.ActualWorkHours.GetHashCode();
                if (this.IsWatcher != null) hashCode = hashCode * 59 + this.IsWatcher.GetHashCode();
                if (this.Deleted != null) hashCode = hashCode * 59 + this.Deleted.GetHashCode();
                if (this.FixedVersion != null) hashCode = hashCode * 59 + this.FixedVersion.GetHashCode();
                if (this.IsArchived != null) hashCode = hashCode * 59 + this.IsArchived.GetHashCode();
                if (this.CreatedOn != null) hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.Domain != null) hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.Developer != null) hashCode = hashCode * 59 + this.Developer.GetHashCode();
                if (this.Closeder != null) hashCode = hashCode * 59 + this.Closeder.GetHashCode();
                if (this.Position != null) hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.ClosedFlag != null) hashCode = hashCode * 59 + this.ClosedFlag.GetHashCode();
                if (this.AssignedCcUser != null) hashCode = hashCode * 59 + this.AssignedCcUser.GetHashCode();
                if (this.CustomValueNew != null) hashCode = hashCode * 59 + this.CustomValueNew.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
