using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListProjectJobsRequest 
    {

        /// <summary>
        /// CodeArts项目ID，32位数字、小写字母组合。
        /// </summary>
        [SDKProperty("project_id", IsPath = true)]
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释**： 分页页码， 表示从此页开始查询。 **约束限制**： 不涉及。 **取值范围**： 只能使用数字，大于等于0。
        /// </summary>
        [SDKProperty("page_index", IsQuery = true)]
        [JsonProperty("page_index", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// **参数解释**： 每页显示的条目数量。 **约束限制**： 不涉及。 **取值范围**： 只能使用数字，小于等于100。
        /// </summary>
        [SDKProperty("page_size", IsQuery = true)]
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 查询条件
        /// </summary>
        [SDKProperty("search", IsQuery = true)]
        [JsonProperty("search", NullValueHandling = NullValueHandling.Ignore)]
        public string Search { get; set; }

        /// <summary>
        /// 排序的字段
        /// </summary>
        [SDKProperty("sort_field", IsQuery = true)]
        [JsonProperty("sort_field", NullValueHandling = NullValueHandling.Ignore)]
        public string SortField { get; set; }

        /// <summary>
        /// 排序顺序
        /// </summary>
        [SDKProperty("sort_order", IsQuery = true)]
        [JsonProperty("sort_order", NullValueHandling = NullValueHandling.Ignore)]
        public string SortOrder { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        [SDKProperty("creator_id", IsQuery = true)]
        [JsonProperty("creator_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorId { get; set; }

        /// <summary>
        /// 构建状态过滤条件
        /// </summary>
        [SDKProperty("build_status", IsQuery = true)]
        [JsonProperty("build_status", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildStatus { get; set; }

        /// <summary>
        /// 是否分组
        /// </summary>
        [SDKProperty("by_group", IsQuery = true)]
        [JsonProperty("by_group", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ByGroup { get; set; }

        /// <summary>
        /// 分组ID
        /// </summary>
        [SDKProperty("group_path_id", IsQuery = true)]
        [JsonProperty("group_path_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupPathId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListProjectJobsRequest {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  pageIndex: ").Append(PageIndex).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("  search: ").Append(Search).Append("\n");
            sb.Append("  sortField: ").Append(SortField).Append("\n");
            sb.Append("  sortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  creatorId: ").Append(CreatorId).Append("\n");
            sb.Append("  buildStatus: ").Append(BuildStatus).Append("\n");
            sb.Append("  byGroup: ").Append(ByGroup).Append("\n");
            sb.Append("  groupPathId: ").Append(GroupPathId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListProjectJobsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListProjectJobsRequest input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.PageIndex != input.PageIndex || (this.PageIndex != null && !this.PageIndex.Equals(input.PageIndex))) return false;
            if (this.PageSize != input.PageSize || (this.PageSize != null && !this.PageSize.Equals(input.PageSize))) return false;
            if (this.Search != input.Search || (this.Search != null && !this.Search.Equals(input.Search))) return false;
            if (this.SortField != input.SortField || (this.SortField != null && !this.SortField.Equals(input.SortField))) return false;
            if (this.SortOrder != input.SortOrder || (this.SortOrder != null && !this.SortOrder.Equals(input.SortOrder))) return false;
            if (this.CreatorId != input.CreatorId || (this.CreatorId != null && !this.CreatorId.Equals(input.CreatorId))) return false;
            if (this.BuildStatus != input.BuildStatus || (this.BuildStatus != null && !this.BuildStatus.Equals(input.BuildStatus))) return false;
            if (this.ByGroup != input.ByGroup || (this.ByGroup != null && !this.ByGroup.Equals(input.ByGroup))) return false;
            if (this.GroupPathId != input.GroupPathId || (this.GroupPathId != null && !this.GroupPathId.Equals(input.GroupPathId))) return false;

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
                if (this.PageIndex != null) hashCode = hashCode * 59 + this.PageIndex.GetHashCode();
                if (this.PageSize != null) hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.Search != null) hashCode = hashCode * 59 + this.Search.GetHashCode();
                if (this.SortField != null) hashCode = hashCode * 59 + this.SortField.GetHashCode();
                if (this.SortOrder != null) hashCode = hashCode * 59 + this.SortOrder.GetHashCode();
                if (this.CreatorId != null) hashCode = hashCode * 59 + this.CreatorId.GetHashCode();
                if (this.BuildStatus != null) hashCode = hashCode * 59 + this.BuildStatus.GetHashCode();
                if (this.ByGroup != null) hashCode = hashCode * 59 + this.ByGroup.GetHashCode();
                if (this.GroupPathId != null) hashCode = hashCode * 59 + this.GroupPathId.GetHashCode();
                return hashCode;
            }
        }
    }
}
