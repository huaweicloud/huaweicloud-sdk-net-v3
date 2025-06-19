using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class WorkItemVo 
    {

        /// <summary>
        /// 工作项名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 处理人
        /// </summary>
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public string Owner { get; set; }

        /// <summary>
        /// 工作项路径
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// 预计开始日期
        /// </summary>
        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }

        /// <summary>
        /// 预计结束日期
        /// </summary>
        [JsonProperty("due_date", NullValueHandling = NullValueHandling.Ignore)]
        public string DueDate { get; set; }

        /// <summary>
        /// 逻辑region，外部使用公有云实际区域，内部使用默认值
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public string Creator { get; set; }

        /// <summary>
        /// 更新人
        /// </summary>
        [JsonProperty("updator", NullValueHandling = NullValueHandling.Ignore)]
        public string Updator { get; set; }

        /// <summary>
        /// 项目ID，外部使用项目ID，内部使用默认值
        /// </summary>
        [JsonProperty("project_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectUuid { get; set; }

        /// <summary>
        /// 工作项编号
        /// </summary>
        [JsonProperty("work_item_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkItemId { get; set; }

        /// <summary>
        /// 状态ID
        /// </summary>
        [JsonProperty("status_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusId { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("status_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusName { get; set; }

        /// <summary>
        /// 类型ID
        /// </summary>
        [JsonProperty("tracker_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TrackerId { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonProperty("tracker_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TrackerName { get; set; }

        /// <summary>
        /// 迭代ID
        /// </summary>
        [JsonProperty("iteration_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IterationId { get; set; }

        /// <summary>
        /// 模块ID
        /// </summary>
        [JsonProperty("module_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ModuleId { get; set; }

        /// <summary>
        /// 重要程度ID
        /// </summary>
        [JsonProperty("severity_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SeverityId { get; set; }

        /// <summary>
        /// 重要程度
        /// </summary>
        [JsonProperty("severity_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SeverityName { get; set; }

        /// <summary>
        /// 父工作项编号
        /// </summary>
        [JsonProperty("parent_workitem_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentWorkitemId { get; set; }

        /// <summary>
        /// 看板ID
        /// </summary>
        [JsonProperty("board_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BoardId { get; set; }

        /// <summary>
        /// 看板
        /// </summary>
        [JsonProperty("board_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BoardName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// 迭代名
        /// </summary>
        [JsonProperty("iteration_name", NullValueHandling = NullValueHandling.Ignore)]
        public string IterationName { get; set; }

        /// <summary>
        /// 模块名
        /// </summary>
        [JsonProperty("module_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ModuleName { get; set; }

        /// <summary>
        /// 模块path
        /// </summary>
        [JsonProperty("module_path", NullValueHandling = NullValueHandling.Ignore)]
        public string ModulePath { get; set; }

        /// <summary>
        /// 模块路径名称
        /// </summary>
        [JsonProperty("module_path_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ModulePathName { get; set; }

        /// <summary>
        /// 处理人
        /// </summary>
        [JsonProperty("owner_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerName { get; set; }

        /// <summary>
        /// 父工作项下是否有子工作项包含动态
        /// </summary>
        [JsonProperty("have_child_dynamic", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaveChildDynamic { get; set; }

        /// <summary>
        /// 父工作项下是否有子工作项
        /// </summary>
        [JsonProperty("has_child", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasChild { get; set; }

        /// <summary>
        /// 需求动态数量
        /// </summary>
        [JsonProperty("issue_dynamic_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? IssueDynamicCount { get; set; }

        /// <summary>
        /// 用例数量
        /// </summary>
        [JsonProperty("case_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? CaseCount { get; set; }

        /// <summary>
        /// xBoard项目工作项序列号
        /// </summary>
        [JsonProperty("sequence_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SequenceId { get; set; }

        /// <summary>
        /// pi的id，层级关系：pi -&gt; 迭代 -&gt; 需求
        /// </summary>
        [JsonProperty("pi_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PiId { get; set; }

        /// <summary>
        /// 迭代ID
        /// </summary>
        [JsonProperty("pi_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PiName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkItemVo {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  startDate: ").Append(StartDate).Append("\n");
            sb.Append("  dueDate: ").Append(DueDate).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  creator: ").Append(Creator).Append("\n");
            sb.Append("  updator: ").Append(Updator).Append("\n");
            sb.Append("  projectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("  workItemId: ").Append(WorkItemId).Append("\n");
            sb.Append("  statusId: ").Append(StatusId).Append("\n");
            sb.Append("  statusName: ").Append(StatusName).Append("\n");
            sb.Append("  trackerId: ").Append(TrackerId).Append("\n");
            sb.Append("  trackerName: ").Append(TrackerName).Append("\n");
            sb.Append("  iterationId: ").Append(IterationId).Append("\n");
            sb.Append("  moduleId: ").Append(ModuleId).Append("\n");
            sb.Append("  severityId: ").Append(SeverityId).Append("\n");
            sb.Append("  severityName: ").Append(SeverityName).Append("\n");
            sb.Append("  parentWorkitemId: ").Append(ParentWorkitemId).Append("\n");
            sb.Append("  boardId: ").Append(BoardId).Append("\n");
            sb.Append("  boardName: ").Append(BoardName).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  iterationName: ").Append(IterationName).Append("\n");
            sb.Append("  moduleName: ").Append(ModuleName).Append("\n");
            sb.Append("  modulePath: ").Append(ModulePath).Append("\n");
            sb.Append("  modulePathName: ").Append(ModulePathName).Append("\n");
            sb.Append("  ownerName: ").Append(OwnerName).Append("\n");
            sb.Append("  haveChildDynamic: ").Append(HaveChildDynamic).Append("\n");
            sb.Append("  hasChild: ").Append(HasChild).Append("\n");
            sb.Append("  issueDynamicCount: ").Append(IssueDynamicCount).Append("\n");
            sb.Append("  caseCount: ").Append(CaseCount).Append("\n");
            sb.Append("  sequenceId: ").Append(SequenceId).Append("\n");
            sb.Append("  piId: ").Append(PiId).Append("\n");
            sb.Append("  piName: ").Append(PiName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkItemVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkItemVo input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Owner != input.Owner || (this.Owner != null && !this.Owner.Equals(input.Owner))) return false;
            if (this.Path != input.Path || (this.Path != null && !this.Path.Equals(input.Path))) return false;
            if (this.StartDate != input.StartDate || (this.StartDate != null && !this.StartDate.Equals(input.StartDate))) return false;
            if (this.DueDate != input.DueDate || (this.DueDate != null && !this.DueDate.Equals(input.DueDate))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.Creator != input.Creator || (this.Creator != null && !this.Creator.Equals(input.Creator))) return false;
            if (this.Updator != input.Updator || (this.Updator != null && !this.Updator.Equals(input.Updator))) return false;
            if (this.ProjectUuid != input.ProjectUuid || (this.ProjectUuid != null && !this.ProjectUuid.Equals(input.ProjectUuid))) return false;
            if (this.WorkItemId != input.WorkItemId || (this.WorkItemId != null && !this.WorkItemId.Equals(input.WorkItemId))) return false;
            if (this.StatusId != input.StatusId || (this.StatusId != null && !this.StatusId.Equals(input.StatusId))) return false;
            if (this.StatusName != input.StatusName || (this.StatusName != null && !this.StatusName.Equals(input.StatusName))) return false;
            if (this.TrackerId != input.TrackerId || (this.TrackerId != null && !this.TrackerId.Equals(input.TrackerId))) return false;
            if (this.TrackerName != input.TrackerName || (this.TrackerName != null && !this.TrackerName.Equals(input.TrackerName))) return false;
            if (this.IterationId != input.IterationId || (this.IterationId != null && !this.IterationId.Equals(input.IterationId))) return false;
            if (this.ModuleId != input.ModuleId || (this.ModuleId != null && !this.ModuleId.Equals(input.ModuleId))) return false;
            if (this.SeverityId != input.SeverityId || (this.SeverityId != null && !this.SeverityId.Equals(input.SeverityId))) return false;
            if (this.SeverityName != input.SeverityName || (this.SeverityName != null && !this.SeverityName.Equals(input.SeverityName))) return false;
            if (this.ParentWorkitemId != input.ParentWorkitemId || (this.ParentWorkitemId != null && !this.ParentWorkitemId.Equals(input.ParentWorkitemId))) return false;
            if (this.BoardId != input.BoardId || (this.BoardId != null && !this.BoardId.Equals(input.BoardId))) return false;
            if (this.BoardName != input.BoardName || (this.BoardName != null && !this.BoardName.Equals(input.BoardName))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.IterationName != input.IterationName || (this.IterationName != null && !this.IterationName.Equals(input.IterationName))) return false;
            if (this.ModuleName != input.ModuleName || (this.ModuleName != null && !this.ModuleName.Equals(input.ModuleName))) return false;
            if (this.ModulePath != input.ModulePath || (this.ModulePath != null && !this.ModulePath.Equals(input.ModulePath))) return false;
            if (this.ModulePathName != input.ModulePathName || (this.ModulePathName != null && !this.ModulePathName.Equals(input.ModulePathName))) return false;
            if (this.OwnerName != input.OwnerName || (this.OwnerName != null && !this.OwnerName.Equals(input.OwnerName))) return false;
            if (this.HaveChildDynamic != input.HaveChildDynamic || (this.HaveChildDynamic != null && !this.HaveChildDynamic.Equals(input.HaveChildDynamic))) return false;
            if (this.HasChild != input.HasChild || (this.HasChild != null && !this.HasChild.Equals(input.HasChild))) return false;
            if (this.IssueDynamicCount != input.IssueDynamicCount || (this.IssueDynamicCount != null && !this.IssueDynamicCount.Equals(input.IssueDynamicCount))) return false;
            if (this.CaseCount != input.CaseCount || (this.CaseCount != null && !this.CaseCount.Equals(input.CaseCount))) return false;
            if (this.SequenceId != input.SequenceId || (this.SequenceId != null && !this.SequenceId.Equals(input.SequenceId))) return false;
            if (this.PiId != input.PiId || (this.PiId != null && !this.PiId.Equals(input.PiId))) return false;
            if (this.PiName != input.PiName || (this.PiName != null && !this.PiName.Equals(input.PiName))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Owner != null) hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Path != null) hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.StartDate != null) hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.DueDate != null) hashCode = hashCode * 59 + this.DueDate.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.Creator != null) hashCode = hashCode * 59 + this.Creator.GetHashCode();
                if (this.Updator != null) hashCode = hashCode * 59 + this.Updator.GetHashCode();
                if (this.ProjectUuid != null) hashCode = hashCode * 59 + this.ProjectUuid.GetHashCode();
                if (this.WorkItemId != null) hashCode = hashCode * 59 + this.WorkItemId.GetHashCode();
                if (this.StatusId != null) hashCode = hashCode * 59 + this.StatusId.GetHashCode();
                if (this.StatusName != null) hashCode = hashCode * 59 + this.StatusName.GetHashCode();
                if (this.TrackerId != null) hashCode = hashCode * 59 + this.TrackerId.GetHashCode();
                if (this.TrackerName != null) hashCode = hashCode * 59 + this.TrackerName.GetHashCode();
                if (this.IterationId != null) hashCode = hashCode * 59 + this.IterationId.GetHashCode();
                if (this.ModuleId != null) hashCode = hashCode * 59 + this.ModuleId.GetHashCode();
                if (this.SeverityId != null) hashCode = hashCode * 59 + this.SeverityId.GetHashCode();
                if (this.SeverityName != null) hashCode = hashCode * 59 + this.SeverityName.GetHashCode();
                if (this.ParentWorkitemId != null) hashCode = hashCode * 59 + this.ParentWorkitemId.GetHashCode();
                if (this.BoardId != null) hashCode = hashCode * 59 + this.BoardId.GetHashCode();
                if (this.BoardName != null) hashCode = hashCode * 59 + this.BoardName.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.IterationName != null) hashCode = hashCode * 59 + this.IterationName.GetHashCode();
                if (this.ModuleName != null) hashCode = hashCode * 59 + this.ModuleName.GetHashCode();
                if (this.ModulePath != null) hashCode = hashCode * 59 + this.ModulePath.GetHashCode();
                if (this.ModulePathName != null) hashCode = hashCode * 59 + this.ModulePathName.GetHashCode();
                if (this.OwnerName != null) hashCode = hashCode * 59 + this.OwnerName.GetHashCode();
                if (this.HaveChildDynamic != null) hashCode = hashCode * 59 + this.HaveChildDynamic.GetHashCode();
                if (this.HasChild != null) hashCode = hashCode * 59 + this.HasChild.GetHashCode();
                if (this.IssueDynamicCount != null) hashCode = hashCode * 59 + this.IssueDynamicCount.GetHashCode();
                if (this.CaseCount != null) hashCode = hashCode * 59 + this.CaseCount.GetHashCode();
                if (this.SequenceId != null) hashCode = hashCode * 59 + this.SequenceId.GetHashCode();
                if (this.PiId != null) hashCode = hashCode * 59 + this.PiId.GetHashCode();
                if (this.PiName != null) hashCode = hashCode * 59 + this.PiName.GetHashCode();
                return hashCode;
            }
        }
    }
}
