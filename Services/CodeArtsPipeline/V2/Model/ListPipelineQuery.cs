using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// 查询流水线列表请求体
    /// </summary>
    public class ListPipelineQuery 
    {

        /// <summary>
        /// **参数解释**： CodeArts项目ID。 **约束限制**： 不涉及。 **取值范围**： 每个项目ID为32位字符，由数字和字母组成。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释**： CodeArts项目ID列表。 **约束限制**： 不涉及。 **取值范围**： 每个项目ID为32位字符，由数字和字母组成。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("project_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ProjectIds { get; set; }

        /// <summary>
        /// **参数解释**： 微服务ID。可以通过[查询微服务列表](ListMicroservice.xml)接口获取，其中data.id即为微服务ID。 **约束限制**： 不涉及。 **取值范围**： 32位字符串。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("component_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentId { get; set; }

        /// <summary>
        /// **参数解释**： 流水线名称，支持模糊查询。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 流水线状态列表。 **约束限制**： 不涉及。 **取值范围**： - COMPLETED：已完成。 - RUNNING：运行中。 - FAILED：失败。 - CANCELED：取消。 - PAUSED：暂停。 - SUSPEND：挂起。 - IGNORED：忽略。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Status { get; set; }

        /// <summary>
        /// **参数解释**： 是否为变更流水线。 **约束限制**： 不涉及。 **取值范围**： - true：是变更流水线。 - false：非变更流水线。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("is_publish", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPublish { get; set; }

        /// <summary>
        /// **参数解释**： 创建人ID，用户的userId。 **约束限制**： 不涉及。 **取值范围**： 每个ID为32位字符串。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("creator_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorId { get; set; }

        /// <summary>
        /// **参数解释**： 创建人ID列表。 **约束限制**： 不涉及。 **取值范围**： 每个ID为32位字符串。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("creator_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CreatorIds { get; set; }

        /// <summary>
        /// **参数解释**： 执行人ID列表。 **约束限制**： 不涉及。 **取值范围**： 每个ID为32位字符串。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("executor_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExecutorIds { get; set; }

        /// <summary>
        /// **参数解释**： 流水线开始时间。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// **参数解释**： 流水线结束时间。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// **参数解释**： 起始偏移。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public long? Offset { get; set; }

        /// <summary>
        /// **参数解释**： 查询数量。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public long? Limit { get; set; }

        /// <summary>
        /// **参数解释**： 排序字段名称。 **约束限制**： 不涉及。 **取值范围**： - name：流水线名。 - create_time：创建时间。 - update_time：更新时间。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("sort_key", NullValueHandling = NullValueHandling.Ignore)]
        public string SortKey { get; set; }

        /// <summary>
        /// **参数解释**： 排序规则。 **约束限制**： 不涉及。 **取值范围**： - asc：按排序字段升序。 - desc：按排序字段降序。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("sort_dir", NullValueHandling = NullValueHandling.Ignore)]
        public string SortDir { get; set; }

        /// <summary>
        /// **参数解释**： 流水线分组ID。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("group_path_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupPathId { get; set; }

        /// <summary>
        /// **参数解释**： 是否分组查询。 **约束限制**： 不涉及。 **取值范围**： - true：是分组查询。 - false：不是分组查询。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("by_group", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ByGroup { get; set; }

        /// <summary>
        /// **参数解释**： 是否包含被禁用的流水线。 **约束限制**： 不涉及。 **取值范围**： - true：包含被禁用的流水线。 - false：不包含被禁用的流水线。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("is_banned", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBanned { get; set; }

        /// <summary>
        /// **参数解释**： 是否只查询新版流水线。 **约束限制**： 不涉及。 **取值范围**： - true：只查询新版流水线。 - false：不只查询新版流水线。 **默认取值**： true。 
        /// </summary>
        [JsonProperty("query_new", NullValueHandling = NullValueHandling.Ignore)]
        public bool? QueryNew { get; set; }

        /// <summary>
        /// **参数解释**： 流水线密集等级。 **约束限制**： 非涉密场景无该字段。 **取值范围**： 零及以上正整数。 0：未设置密级。 1：最低密级。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("security_level_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> SecurityLevelList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPipelineQuery {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  projectIds: ").Append(ProjectIds).Append("\n");
            sb.Append("  componentId: ").Append(ComponentId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  isPublish: ").Append(IsPublish).Append("\n");
            sb.Append("  creatorId: ").Append(CreatorId).Append("\n");
            sb.Append("  creatorIds: ").Append(CreatorIds).Append("\n");
            sb.Append("  executorIds: ").Append(ExecutorIds).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  sortKey: ").Append(SortKey).Append("\n");
            sb.Append("  sortDir: ").Append(SortDir).Append("\n");
            sb.Append("  groupPathId: ").Append(GroupPathId).Append("\n");
            sb.Append("  byGroup: ").Append(ByGroup).Append("\n");
            sb.Append("  isBanned: ").Append(IsBanned).Append("\n");
            sb.Append("  queryNew: ").Append(QueryNew).Append("\n");
            sb.Append("  securityLevelList: ").Append(SecurityLevelList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPipelineQuery);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPipelineQuery input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ProjectIds != input.ProjectIds || (this.ProjectIds != null && input.ProjectIds != null && !this.ProjectIds.SequenceEqual(input.ProjectIds))) return false;
            if (this.ComponentId != input.ComponentId || (this.ComponentId != null && !this.ComponentId.Equals(input.ComponentId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Status != input.Status || (this.Status != null && input.Status != null && !this.Status.SequenceEqual(input.Status))) return false;
            if (this.IsPublish != input.IsPublish || (this.IsPublish != null && !this.IsPublish.Equals(input.IsPublish))) return false;
            if (this.CreatorId != input.CreatorId || (this.CreatorId != null && !this.CreatorId.Equals(input.CreatorId))) return false;
            if (this.CreatorIds != input.CreatorIds || (this.CreatorIds != null && input.CreatorIds != null && !this.CreatorIds.SequenceEqual(input.CreatorIds))) return false;
            if (this.ExecutorIds != input.ExecutorIds || (this.ExecutorIds != null && input.ExecutorIds != null && !this.ExecutorIds.SequenceEqual(input.ExecutorIds))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.SortKey != input.SortKey || (this.SortKey != null && !this.SortKey.Equals(input.SortKey))) return false;
            if (this.SortDir != input.SortDir || (this.SortDir != null && !this.SortDir.Equals(input.SortDir))) return false;
            if (this.GroupPathId != input.GroupPathId || (this.GroupPathId != null && !this.GroupPathId.Equals(input.GroupPathId))) return false;
            if (this.ByGroup != input.ByGroup || (this.ByGroup != null && !this.ByGroup.Equals(input.ByGroup))) return false;
            if (this.IsBanned != input.IsBanned || (this.IsBanned != null && !this.IsBanned.Equals(input.IsBanned))) return false;
            if (this.QueryNew != input.QueryNew || (this.QueryNew != null && !this.QueryNew.Equals(input.QueryNew))) return false;
            if (this.SecurityLevelList != input.SecurityLevelList || (this.SecurityLevelList != null && input.SecurityLevelList != null && !this.SecurityLevelList.SequenceEqual(input.SecurityLevelList))) return false;

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
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProjectIds != null) hashCode = hashCode * 59 + this.ProjectIds.GetHashCode();
                if (this.ComponentId != null) hashCode = hashCode * 59 + this.ComponentId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.IsPublish != null) hashCode = hashCode * 59 + this.IsPublish.GetHashCode();
                if (this.CreatorId != null) hashCode = hashCode * 59 + this.CreatorId.GetHashCode();
                if (this.CreatorIds != null) hashCode = hashCode * 59 + this.CreatorIds.GetHashCode();
                if (this.ExecutorIds != null) hashCode = hashCode * 59 + this.ExecutorIds.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.SortKey != null) hashCode = hashCode * 59 + this.SortKey.GetHashCode();
                if (this.SortDir != null) hashCode = hashCode * 59 + this.SortDir.GetHashCode();
                if (this.GroupPathId != null) hashCode = hashCode * 59 + this.GroupPathId.GetHashCode();
                if (this.ByGroup != null) hashCode = hashCode * 59 + this.ByGroup.GetHashCode();
                if (this.IsBanned != null) hashCode = hashCode * 59 + this.IsBanned.GetHashCode();
                if (this.QueryNew != null) hashCode = hashCode * 59 + this.QueryNew.GetHashCode();
                if (this.SecurityLevelList != null) hashCode = hashCode * 59 + this.SecurityLevelList.GetHashCode();
                return hashCode;
            }
        }
    }
}
