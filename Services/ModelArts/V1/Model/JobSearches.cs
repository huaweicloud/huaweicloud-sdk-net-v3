using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class JobSearches 
    {

        /// <summary>
        /// 查询作业的页数，最小为0。例如设置为0，则表示从第一页开始查询。
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询作业的每页条目数。最小为1，最大为50。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 查询作业排列顺序的指标。默认使用create_time排序。
        /// </summary>
        [JsonProperty("sort_by", NullValueHandling = NullValueHandling.Ignore)]
        public string SortBy { get; set; }

        /// <summary>
        /// 查询作业排列顺序，默认为“desc”，降序排序。也可以选择对应的“asc”，升序排序。
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public string Order { get; set; }

        /// <summary>
        /// 查询作业要搜索的分组条件。
        /// </summary>
        [JsonProperty("group_by", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupBy { get; set; }

        /// <summary>
        /// 参数解释：工作空间ID。 约束限制：不涉及。 取值范围：0或长度为32的字符串。 默认取值：0。
        /// </summary>
        [JsonProperty("workspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// **参数解释**：在开启自定义作业和精调作业联合查询时，只显示自定义或精调作业。 **约束限制**：不涉及。 **取值范围**：   - job: 只查自定义作业   - ftjob : 只查精调作业 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("train_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TrainType { get; set; }

        /// <summary>
        /// **参数解释**：按 TMS 标签筛选训练作业列表。 **约束限制**：   - 最多 10 个标签条件；   - 同一 &#x60;key&#x60; 不可重复；   - 同一 &#x60;key&#x60; 下 &#x60;values&#x60; 不可重复；   - 传入本参数时须同时满足 &#x60;filters&#x60; 中 &#x60;create_time&#x60; 条件：未传则默认最近 31 天，时间跨度不得超过 31 天。 **匹配规则**：   - 同一 &#x60;key&#x60; 下多个 &#x60;values&#x60; 为 **OR**；   - 不同 &#x60;key&#x60; 之间为 **AND**；   - &#x60;values&#x60; 为空或仅含空字符串时，按 **仅匹配该 key**（不限 value）处理。 **取值范围**：不涉及。 **默认取值**：不传则不按标签筛选。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListTagFilter> Tags { get; set; }

        /// <summary>
        /// **参数解释**：按训练实例所在节点宿主机 IP 筛选训练作业列表。 **约束限制**：   - 最多 10 个 IP；   - 每个元素须为合法 IPv4/IPv6 地址；   - 传入本参数时须同时满足 &#x60;filters&#x60; 中 &#x60;create_time&#x60; 条件：未传则默认最近 31 天，时间跨度不得超过 31 天。 **匹配规则**：   - 多个 IP 之间为 **OR**（命中任一 IP 即匹配） **取值范围**：不涉及。 **默认取值**：不传则不按 IP 筛选。
        /// </summary>
        [JsonProperty("host_ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> HostIps { get; set; }

        /// <summary>
        /// 查询作业要过滤的一系列条件。
        /// </summary>
        [JsonProperty("filters", NullValueHandling = NullValueHandling.Ignore)]
        public List<Filter> Filters { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobSearches {\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  sortBy: ").Append(SortBy).Append("\n");
            sb.Append("  order: ").Append(Order).Append("\n");
            sb.Append("  groupBy: ").Append(GroupBy).Append("\n");
            sb.Append("  workspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  trainType: ").Append(TrainType).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  hostIps: ").Append(HostIps).Append("\n");
            sb.Append("  filters: ").Append(Filters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobSearches);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobSearches input)
        {
            if (input == null) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.SortBy != input.SortBy || (this.SortBy != null && !this.SortBy.Equals(input.SortBy))) return false;
            if (this.Order != input.Order || (this.Order != null && !this.Order.Equals(input.Order))) return false;
            if (this.GroupBy != input.GroupBy || (this.GroupBy != null && !this.GroupBy.Equals(input.GroupBy))) return false;
            if (this.WorkspaceId != input.WorkspaceId || (this.WorkspaceId != null && !this.WorkspaceId.Equals(input.WorkspaceId))) return false;
            if (this.TrainType != input.TrainType || (this.TrainType != null && !this.TrainType.Equals(input.TrainType))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.HostIps != input.HostIps || (this.HostIps != null && input.HostIps != null && !this.HostIps.SequenceEqual(input.HostIps))) return false;
            if (this.Filters != input.Filters || (this.Filters != null && input.Filters != null && !this.Filters.SequenceEqual(input.Filters))) return false;

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
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.SortBy != null) hashCode = hashCode * 59 + this.SortBy.GetHashCode();
                if (this.Order != null) hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.GroupBy != null) hashCode = hashCode * 59 + this.GroupBy.GetHashCode();
                if (this.WorkspaceId != null) hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
                if (this.TrainType != null) hashCode = hashCode * 59 + this.TrainType.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.HostIps != null) hashCode = hashCode * 59 + this.HostIps.GetHashCode();
                if (this.Filters != null) hashCode = hashCode * 59 + this.Filters.GetHashCode();
                return hashCode;
            }
        }
    }
}
