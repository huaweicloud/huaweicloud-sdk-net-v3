using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V1.Model
{
    /// <summary>
    /// 查询工作流列表。
    /// </summary>
    public class WorkflowQueryParam 
    {

        /// <summary>
        /// 搜索内容，可以针对工作流名称和描述内容进行搜索。
        /// </summary>
        [JsonProperty("search", NullValueHandling = NullValueHandling.Ignore)]
        public string Search { get; set; }

        /// <summary>
        /// 工作流分类，可以取值[\&quot;cron\&quot;,\&quot;event\&quot;,\&quot;manual\&quot;]。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 工作流标签，最多支持10个。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// 查询当前的页数，默认值为0。
        /// </summary>
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public int? Page { get; set; }

        /// <summary>
        /// 查询当前页的大小，默认值为10。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 企业项目id。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 工作流创建人。
        /// </summary>
        [JsonProperty("create_by", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateBy { get; set; }

        /// <summary>
        /// 排序字段，取值[\&quot;create_time\&quot;，\&quot;last_execution_start_time\&quot;，\&quot;update_time\&quot;]。
        /// </summary>
        [JsonProperty("sort_field", NullValueHandling = NullValueHandling.Ignore)]
        public string SortField { get; set; }

        /// <summary>
        /// 排序类型，取值[\&quot;ASC\&quot;，\&quot;DESC\&quot;]。
        /// </summary>
        [JsonProperty("sort_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SortType { get; set; }

        /// <summary>
        /// 时间范围查询的开始时间。
        /// </summary>
        [JsonProperty("search_time_start", NullValueHandling = NullValueHandling.Ignore)]
        public long? SearchTimeStart { get; set; }

        /// <summary>
        /// 时间范围查询的结束时间。
        /// </summary>
        [JsonProperty("search_time_end", NullValueHandling = NullValueHandling.Ignore)]
        public long? SearchTimeEnd { get; set; }

        /// <summary>
        /// 任务的状态 [\&quot;success\&quot;,\&quot;fail\&quot;,\&quot;executing\&quot;,\&quot;cancel\&quot;,\&quot;waitExecute\&quot;,\&quot;waitApproval\&quot;,\&quot;approvalFailed\&quot;,\&quot;pausing\&quot;,\&quot;canceling\&quot;]
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowQueryParam {\n");
            sb.Append("  search: ").Append(Search).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  page: ").Append(Page).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  createBy: ").Append(CreateBy).Append("\n");
            sb.Append("  sortField: ").Append(SortField).Append("\n");
            sb.Append("  sortType: ").Append(SortType).Append("\n");
            sb.Append("  searchTimeStart: ").Append(SearchTimeStart).Append("\n");
            sb.Append("  searchTimeEnd: ").Append(SearchTimeEnd).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkflowQueryParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkflowQueryParam input)
        {
            if (input == null) return false;
            if (this.Search != input.Search || (this.Search != null && !this.Search.Equals(input.Search))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.Page != input.Page || (this.Page != null && !this.Page.Equals(input.Page))) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.CreateBy != input.CreateBy || (this.CreateBy != null && !this.CreateBy.Equals(input.CreateBy))) return false;
            if (this.SortField != input.SortField || (this.SortField != null && !this.SortField.Equals(input.SortField))) return false;
            if (this.SortType != input.SortType || (this.SortType != null && !this.SortType.Equals(input.SortType))) return false;
            if (this.SearchTimeStart != input.SearchTimeStart || (this.SearchTimeStart != null && !this.SearchTimeStart.Equals(input.SearchTimeStart))) return false;
            if (this.SearchTimeEnd != input.SearchTimeEnd || (this.SearchTimeEnd != null && !this.SearchTimeEnd.Equals(input.SearchTimeEnd))) return false;
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
                if (this.Search != null) hashCode = hashCode * 59 + this.Search.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Page != null) hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.CreateBy != null) hashCode = hashCode * 59 + this.CreateBy.GetHashCode();
                if (this.SortField != null) hashCode = hashCode * 59 + this.SortField.GetHashCode();
                if (this.SortType != null) hashCode = hashCode * 59 + this.SortType.GetHashCode();
                if (this.SearchTimeStart != null) hashCode = hashCode * 59 + this.SearchTimeStart.GetHashCode();
                if (this.SearchTimeEnd != null) hashCode = hashCode * 59 + this.SearchTimeEnd.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
