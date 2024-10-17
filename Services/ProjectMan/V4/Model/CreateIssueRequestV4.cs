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
    /// 工作项属性
    /// </summary>
    public class CreateIssueRequestV4 
    {

        /// <summary>
        /// 实际工时
        /// </summary>
        [JsonProperty("actual_work_hours", NullValueHandling = NullValueHandling.Ignore)]
        public double? ActualWorkHours { get; set; }

        /// <summary>
        /// 处理人id,对应用户信息的数字id
        /// </summary>
        [JsonProperty("assigned_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? AssignedId { get; set; }

        /// <summary>
        /// 开始时间，年-月-日
        /// </summary>
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string BeginTime { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 开发者id,对应用户信息的数字id
        /// </summary>
        [JsonProperty("developer_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? DeveloperId { get; set; }

        /// <summary>
        /// id 领域, 14 &#39;性能&#39;, 15 &#39;功能&#39;, 16 &#39;可靠性&#39; 17 &#39;网络安全&#39; 18 &#39;可维护性&#39; 19 &#39;其他DFX&#39; 20 &#39;可用性&#39;
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? DomainId { get; set; }

        /// <summary>
        /// 工作项进度值
        /// </summary>
        [JsonProperty("done_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public int? DoneRatio { get; set; }

        /// <summary>
        /// 结束时间，年-月-日
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 预计工时
        /// </summary>
        [JsonProperty("expected_work_hours", NullValueHandling = NullValueHandling.Ignore)]
        public double? ExpectedWorkHours { get; set; }

        /// <summary>
        /// 迭代id
        /// </summary>
        [JsonProperty("iteration_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? IterationId { get; set; }

        /// <summary>
        /// 模块id
        /// </summary>
        [JsonProperty("module_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ModuleId { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 父工作项的id,创建子工作项时必填，父工作项的类型tracker_id不能为2,3
        /// </summary>
        [JsonProperty("parent_issue_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ParentIssueId { get; set; }

        /// <summary>
        /// 优先级,   1 低,   2 中,   3 高,
        /// </summary>
        [JsonProperty("priority_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PriorityId { get; set; }

        /// <summary>
        /// 重要程度,   10 关键,   11 重要,   12 一般,   13 提示,
        /// </summary>
        [JsonProperty("severity_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SeverityId { get; set; }

        /// <summary>
        /// 状态   id, 新建   1, 进行中 2, 已解决 3, 测试中 4, 已关闭 5, 已拒绝 6,
        /// </summary>
        [JsonProperty("status_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? StatusId { get; set; }

        /// <summary>
        /// 工作项类型, 2任务/Task,3缺陷/Bug,5Epic,6Feature,7Story;     5 只能为 6 的父工作项类型;     6 只能为 7 的父工作项类型;     7 只能为 2,3的父;
        /// </summary>
        [JsonProperty("tracker_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? TrackerId { get; set; }

        /// <summary>
        /// 用户自定义字段
        /// </summary>
        [JsonProperty("new_custom_fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<NewCustomField> NewCustomFields { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateIssueRequestV4 {\n");
            sb.Append("  actualWorkHours: ").Append(ActualWorkHours).Append("\n");
            sb.Append("  assignedId: ").Append(AssignedId).Append("\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  developerId: ").Append(DeveloperId).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  doneRatio: ").Append(DoneRatio).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  expectedWorkHours: ").Append(ExpectedWorkHours).Append("\n");
            sb.Append("  iterationId: ").Append(IterationId).Append("\n");
            sb.Append("  moduleId: ").Append(ModuleId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  parentIssueId: ").Append(ParentIssueId).Append("\n");
            sb.Append("  priorityId: ").Append(PriorityId).Append("\n");
            sb.Append("  severityId: ").Append(SeverityId).Append("\n");
            sb.Append("  statusId: ").Append(StatusId).Append("\n");
            sb.Append("  trackerId: ").Append(TrackerId).Append("\n");
            sb.Append("  newCustomFields: ").Append(NewCustomFields).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateIssueRequestV4);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateIssueRequestV4 input)
        {
            if (input == null) return false;
            if (this.ActualWorkHours != input.ActualWorkHours || (this.ActualWorkHours != null && !this.ActualWorkHours.Equals(input.ActualWorkHours))) return false;
            if (this.AssignedId != input.AssignedId || (this.AssignedId != null && !this.AssignedId.Equals(input.AssignedId))) return false;
            if (this.BeginTime != input.BeginTime || (this.BeginTime != null && !this.BeginTime.Equals(input.BeginTime))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.DeveloperId != input.DeveloperId || (this.DeveloperId != null && !this.DeveloperId.Equals(input.DeveloperId))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.DoneRatio != input.DoneRatio || (this.DoneRatio != null && !this.DoneRatio.Equals(input.DoneRatio))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.ExpectedWorkHours != input.ExpectedWorkHours || (this.ExpectedWorkHours != null && !this.ExpectedWorkHours.Equals(input.ExpectedWorkHours))) return false;
            if (this.IterationId != input.IterationId || (this.IterationId != null && !this.IterationId.Equals(input.IterationId))) return false;
            if (this.ModuleId != input.ModuleId || (this.ModuleId != null && !this.ModuleId.Equals(input.ModuleId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ParentIssueId != input.ParentIssueId || (this.ParentIssueId != null && !this.ParentIssueId.Equals(input.ParentIssueId))) return false;
            if (this.PriorityId != input.PriorityId || (this.PriorityId != null && !this.PriorityId.Equals(input.PriorityId))) return false;
            if (this.SeverityId != input.SeverityId || (this.SeverityId != null && !this.SeverityId.Equals(input.SeverityId))) return false;
            if (this.StatusId != input.StatusId || (this.StatusId != null && !this.StatusId.Equals(input.StatusId))) return false;
            if (this.TrackerId != input.TrackerId || (this.TrackerId != null && !this.TrackerId.Equals(input.TrackerId))) return false;
            if (this.NewCustomFields != input.NewCustomFields || (this.NewCustomFields != null && input.NewCustomFields != null && !this.NewCustomFields.SequenceEqual(input.NewCustomFields))) return false;

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
                if (this.AssignedId != null) hashCode = hashCode * 59 + this.AssignedId.GetHashCode();
                if (this.BeginTime != null) hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DeveloperId != null) hashCode = hashCode * 59 + this.DeveloperId.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.DoneRatio != null) hashCode = hashCode * 59 + this.DoneRatio.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.ExpectedWorkHours != null) hashCode = hashCode * 59 + this.ExpectedWorkHours.GetHashCode();
                if (this.IterationId != null) hashCode = hashCode * 59 + this.IterationId.GetHashCode();
                if (this.ModuleId != null) hashCode = hashCode * 59 + this.ModuleId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ParentIssueId != null) hashCode = hashCode * 59 + this.ParentIssueId.GetHashCode();
                if (this.PriorityId != null) hashCode = hashCode * 59 + this.PriorityId.GetHashCode();
                if (this.SeverityId != null) hashCode = hashCode * 59 + this.SeverityId.GetHashCode();
                if (this.StatusId != null) hashCode = hashCode * 59 + this.StatusId.GetHashCode();
                if (this.TrackerId != null) hashCode = hashCode * 59 + this.TrackerId.GetHashCode();
                if (this.NewCustomFields != null) hashCode = hashCode * 59 + this.NewCustomFields.GetHashCode();
                return hashCode;
            }
        }
    }
}
