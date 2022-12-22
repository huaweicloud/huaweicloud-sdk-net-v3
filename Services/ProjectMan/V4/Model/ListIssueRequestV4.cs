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
    public class ListIssueRequestV4 
    {

        /// <summary>
        /// 处理人id
        /// </summary>
        [JsonProperty("assigned_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> AssignedIds { get; set; }

        /// <summary>
        /// 创建者id
        /// </summary>
        [JsonProperty("creator_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> CreatorIds { get; set; }

        /// <summary>
        /// 开发人id,对应用户信息的数字id
        /// </summary>
        [JsonProperty("developer_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> DeveloperIds { get; set; }

        /// <summary>
        /// id, 领域, 14 &#39;性能&#39;, 15 &#39;功能&#39;, 16 &#39;可靠性&#39;, 17 &#39;网络安全&#39;, 18 &#39;可维护性&#39;, 19 &#39;其他DFX&#39;, 20 &#39;可用性&#39;,
        /// </summary>
        [JsonProperty("domain_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> DomainIds { get; set; }

        /// <summary>
        /// 完成度
        /// </summary>
        [JsonProperty("done_ratios", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> DoneRatios { get; set; }

        /// <summary>
        /// 迭代id
        /// </summary>
        [JsonProperty("iteration_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> IterationIds { get; set; }

        /// <summary>
        /// 每页显示数量
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 分页索引，偏移量，offset是limit的整数倍数，limit&#x3D;10,offset&#x3D;0,10,20...
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 模块id
        /// </summary>
        [JsonProperty("module_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> ModuleIds { get; set; }

        /// <summary>
        /// 优先级
        /// </summary>
        [JsonProperty("priority_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> PriorityIds { get; set; }

        /// <summary>
        /// 查询类型 backlog feature epic
        /// </summary>
        [JsonProperty("query_type", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryType { get; set; }

        /// <summary>
        /// 查询类型
        /// </summary>
        [JsonProperty("severity_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> SeverityIds { get; set; }

        /// <summary>
        /// 状态   id, 新建   1, 进行中 2, 已解决 3, 测试中 4, 已关闭 5, 已拒绝 6,
        /// </summary>
        [JsonProperty("status_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> StatusIds { get; set; }

        /// <summary>
        /// 故事点id
        /// </summary>
        [JsonProperty("story_point_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> StoryPointIds { get; set; }

        /// <summary>
        /// 工作项类型,2任务/Task,3缺陷/Bug,5Epic,6Feature,7Story
        /// </summary>
        [JsonProperty("tracker_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> TrackerIds { get; set; }

        /// <summary>
        /// true 查询的工作项包含已经逻辑删除的，false 查询的工作项不包含已经删除的
        /// </summary>
        [JsonProperty("include_deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeDeleted { get; set; }

        /// <summary>
        /// 根据工作项的更新时间查询工作项，(查询的起始时间,查询的结束时间)
        /// </summary>
        [JsonProperty("updated_time_interval", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedTimeInterval { get; set; }

        /// <summary>
        /// 自定义字段
        /// </summary>
        [JsonProperty("custom_fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListIssueRequestV4CustomFields> CustomFields { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListIssueRequestV4 {\n");
            sb.Append("  assignedIds: ").Append(AssignedIds).Append("\n");
            sb.Append("  creatorIds: ").Append(CreatorIds).Append("\n");
            sb.Append("  developerIds: ").Append(DeveloperIds).Append("\n");
            sb.Append("  domainIds: ").Append(DomainIds).Append("\n");
            sb.Append("  doneRatios: ").Append(DoneRatios).Append("\n");
            sb.Append("  iterationIds: ").Append(IterationIds).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  moduleIds: ").Append(ModuleIds).Append("\n");
            sb.Append("  priorityIds: ").Append(PriorityIds).Append("\n");
            sb.Append("  queryType: ").Append(QueryType).Append("\n");
            sb.Append("  severityIds: ").Append(SeverityIds).Append("\n");
            sb.Append("  statusIds: ").Append(StatusIds).Append("\n");
            sb.Append("  storyPointIds: ").Append(StoryPointIds).Append("\n");
            sb.Append("  trackerIds: ").Append(TrackerIds).Append("\n");
            sb.Append("  includeDeleted: ").Append(IncludeDeleted).Append("\n");
            sb.Append("  updatedTimeInterval: ").Append(UpdatedTimeInterval).Append("\n");
            sb.Append("  customFields: ").Append(CustomFields).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListIssueRequestV4);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListIssueRequestV4 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssignedIds == input.AssignedIds ||
                    this.AssignedIds != null &&
                    input.AssignedIds != null &&
                    this.AssignedIds.SequenceEqual(input.AssignedIds)
                ) && 
                (
                    this.CreatorIds == input.CreatorIds ||
                    this.CreatorIds != null &&
                    input.CreatorIds != null &&
                    this.CreatorIds.SequenceEqual(input.CreatorIds)
                ) && 
                (
                    this.DeveloperIds == input.DeveloperIds ||
                    this.DeveloperIds != null &&
                    input.DeveloperIds != null &&
                    this.DeveloperIds.SequenceEqual(input.DeveloperIds)
                ) && 
                (
                    this.DomainIds == input.DomainIds ||
                    this.DomainIds != null &&
                    input.DomainIds != null &&
                    this.DomainIds.SequenceEqual(input.DomainIds)
                ) && 
                (
                    this.DoneRatios == input.DoneRatios ||
                    this.DoneRatios != null &&
                    input.DoneRatios != null &&
                    this.DoneRatios.SequenceEqual(input.DoneRatios)
                ) && 
                (
                    this.IterationIds == input.IterationIds ||
                    this.IterationIds != null &&
                    input.IterationIds != null &&
                    this.IterationIds.SequenceEqual(input.IterationIds)
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.ModuleIds == input.ModuleIds ||
                    this.ModuleIds != null &&
                    input.ModuleIds != null &&
                    this.ModuleIds.SequenceEqual(input.ModuleIds)
                ) && 
                (
                    this.PriorityIds == input.PriorityIds ||
                    this.PriorityIds != null &&
                    input.PriorityIds != null &&
                    this.PriorityIds.SequenceEqual(input.PriorityIds)
                ) && 
                (
                    this.QueryType == input.QueryType ||
                    (this.QueryType != null &&
                    this.QueryType.Equals(input.QueryType))
                ) && 
                (
                    this.SeverityIds == input.SeverityIds ||
                    this.SeverityIds != null &&
                    input.SeverityIds != null &&
                    this.SeverityIds.SequenceEqual(input.SeverityIds)
                ) && 
                (
                    this.StatusIds == input.StatusIds ||
                    this.StatusIds != null &&
                    input.StatusIds != null &&
                    this.StatusIds.SequenceEqual(input.StatusIds)
                ) && 
                (
                    this.StoryPointIds == input.StoryPointIds ||
                    this.StoryPointIds != null &&
                    input.StoryPointIds != null &&
                    this.StoryPointIds.SequenceEqual(input.StoryPointIds)
                ) && 
                (
                    this.TrackerIds == input.TrackerIds ||
                    this.TrackerIds != null &&
                    input.TrackerIds != null &&
                    this.TrackerIds.SequenceEqual(input.TrackerIds)
                ) && 
                (
                    this.IncludeDeleted == input.IncludeDeleted ||
                    (this.IncludeDeleted != null &&
                    this.IncludeDeleted.Equals(input.IncludeDeleted))
                ) && 
                (
                    this.UpdatedTimeInterval == input.UpdatedTimeInterval ||
                    (this.UpdatedTimeInterval != null &&
                    this.UpdatedTimeInterval.Equals(input.UpdatedTimeInterval))
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
                if (this.AssignedIds != null)
                    hashCode = hashCode * 59 + this.AssignedIds.GetHashCode();
                if (this.CreatorIds != null)
                    hashCode = hashCode * 59 + this.CreatorIds.GetHashCode();
                if (this.DeveloperIds != null)
                    hashCode = hashCode * 59 + this.DeveloperIds.GetHashCode();
                if (this.DomainIds != null)
                    hashCode = hashCode * 59 + this.DomainIds.GetHashCode();
                if (this.DoneRatios != null)
                    hashCode = hashCode * 59 + this.DoneRatios.GetHashCode();
                if (this.IterationIds != null)
                    hashCode = hashCode * 59 + this.IterationIds.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.ModuleIds != null)
                    hashCode = hashCode * 59 + this.ModuleIds.GetHashCode();
                if (this.PriorityIds != null)
                    hashCode = hashCode * 59 + this.PriorityIds.GetHashCode();
                if (this.QueryType != null)
                    hashCode = hashCode * 59 + this.QueryType.GetHashCode();
                if (this.SeverityIds != null)
                    hashCode = hashCode * 59 + this.SeverityIds.GetHashCode();
                if (this.StatusIds != null)
                    hashCode = hashCode * 59 + this.StatusIds.GetHashCode();
                if (this.StoryPointIds != null)
                    hashCode = hashCode * 59 + this.StoryPointIds.GetHashCode();
                if (this.TrackerIds != null)
                    hashCode = hashCode * 59 + this.TrackerIds.GetHashCode();
                if (this.IncludeDeleted != null)
                    hashCode = hashCode * 59 + this.IncludeDeleted.GetHashCode();
                if (this.UpdatedTimeInterval != null)
                    hashCode = hashCode * 59 + this.UpdatedTimeInterval.GetHashCode();
                if (this.CustomFields != null)
                    hashCode = hashCode * 59 + this.CustomFields.GetHashCode();
                return hashCode;
            }
        }
    }
}
