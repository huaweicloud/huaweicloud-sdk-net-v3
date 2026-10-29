using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowTasksListRequest 
    {

        /// <summary>
        /// **参数解释：** 分页页码。 **约束限制：** 分页页码≥1。 **取值范围:** 1-2147483647 **默认取值：**  不涉及。
        /// </summary>
        [SDKProperty("page", IsQuery = true)]
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public int? Page { get; set; }

        /// <summary>
        /// **参数解释：** 分页大小。 **约束限制：** 数字1-200之间。 **取值范围:** 1-200 **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("page_size", IsQuery = true)]
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        /// **参数解释：** 需要搜索的任务名。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("search", IsQuery = true)]
        [JsonProperty("search", NullValueHandling = NullValueHandling.Ignore)]
        public string Search { get; set; }

        /// <summary>
        /// **参数解释：** 项目的32位UUID，项目唯一标识，通过[[查询项目列表](https://support.huaweicloud.com/api-projectman/ListProjectsV4.html)](tag:hws)[[查询项目列表](https://support.huaweicloud.com/intl/zh-cn/api-projectman/ListProjectsV4.html)](tag:hws_hk)[查询项目列表](tag:hcs,hcs_sm,hcs_site,hcs_sitesm,fcs)接口获取。 **约束条件：** 不涉及。 **取值范围：** 长度为[1~32]个字符。 **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("project_id", IsQuery = true)]
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释：** 门禁结果。 **约束限制：** 不涉及。 **取值范围：** - success：门禁通过。 - error：门禁不通过。 **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("review_result_types", IsQuery = true)]
        [JsonProperty("review_result_types", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewResultTypes { get; set; }

        /// <summary>
        /// **参数解释：** 检查状态。 **约束限制：** 不涉及。 **取值范围：** - success：检查成功。 - failed：检查失败。 - aborted：检查终止。 - executing：检查中。 - never_execute：未检查。 **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("job_status_types", IsQuery = true)]
        [JsonProperty("job_status_types", NullValueHandling = NullValueHandling.Ignore)]
        public string JobStatusTypes { get; set; }

        /// <summary>
        /// **参数解释：** 是否按照执行时间排序。 **约束限制：** 不涉及。 **取值范围：** - up：按照执行时间升序排序。 - down：按照执行时间降序排序。 **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("order_by_execute_time", IsQuery = true)]
        [JsonProperty("order_by_execute_time", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderByExecuteTime { get; set; }

        /// <summary>
        /// **参数解释：** 任务的分组ID，可通过列出项目下的分组信息接口获取任务的分组ID。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("task_classification_id", IsQuery = true)]
        [JsonProperty("task_classification_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskClassificationId { get; set; }

        /// <summary>
        /// 列表类接口参数
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 列表类接口参数
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// **参数解释：** 排序字段,任务列表每次只能根据一个字段进行排序。 **约束限制：** 不涉及。
        /// </summary>
        [SDKProperty("sort_field", IsQuery = true)]
        [JsonProperty("sort_field", NullValueHandling = NullValueHandling.Ignore)]
        public string SortField { get; set; }

        /// <summary>
        /// **参数解释：** 排序顺序，取值范围：\&quot;up\&quot;（升序）、\&quot;down\&quot;（降序） **约束限制：** 不涉及。
        /// </summary>
        [SDKProperty("sort_order", IsQuery = true)]
        [JsonProperty("sort_order", NullValueHandling = NullValueHandling.Ignore)]
        public string SortOrder { get; set; }

        /// <summary>
        /// **参数解释：** 操作人，填写账号用户名。 **约束限制：** 不涉及。 **取值范围：** 长度为[1~128]个字符。 **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("operator", IsHeader = true)]
        [JsonProperty("operator", NullValueHandling = NullValueHandling.Ignore)]
        public string Operator { get; set; }

        /// <summary>
        /// **参数解释：** 代码仓地址。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("repo_url", IsQuery = true)]
        [JsonProperty("repo_url", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoUrl { get; set; }

        /// <summary>
        /// **参数解释：** 分支。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("branch", IsQuery = true)]
        [JsonProperty("branch", NullValueHandling = NullValueHandling.Ignore)]
        public string Branch { get; set; }

        /// <summary>
        /// **参数解释：** 和repo_url配合使用，查询任务时是否完全匹配repo_url。 **约束限制：** 不涉及。 **取值范围：** - true：只查询代码仓地址为repo_url的任务。 - false：查询ssh协议的代码仓地址或http协议的代码仓地址和repo_url匹配的任务。 **默认取值：** false。
        /// </summary>
        [SDKProperty("repo_url_full_match", IsQuery = true)]
        [JsonProperty("repo_url_full_match", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoUrlFullMatch { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTasksListRequest {\n");
            sb.Append("  page: ").Append(Page).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("  search: ").Append(Search).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  reviewResultTypes: ").Append(ReviewResultTypes).Append("\n");
            sb.Append("  jobStatusTypes: ").Append(JobStatusTypes).Append("\n");
            sb.Append("  orderByExecuteTime: ").Append(OrderByExecuteTime).Append("\n");
            sb.Append("  taskClassificationId: ").Append(TaskClassificationId).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  sortField: ").Append(SortField).Append("\n");
            sb.Append("  sortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  repoUrl: ").Append(RepoUrl).Append("\n");
            sb.Append("  branch: ").Append(Branch).Append("\n");
            sb.Append("  repoUrlFullMatch: ").Append(RepoUrlFullMatch).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTasksListRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTasksListRequest input)
        {
            if (input == null) return false;
            if (this.Page != input.Page || (this.Page != null && !this.Page.Equals(input.Page))) return false;
            if (this.PageSize != input.PageSize || (this.PageSize != null && !this.PageSize.Equals(input.PageSize))) return false;
            if (this.Search != input.Search || (this.Search != null && !this.Search.Equals(input.Search))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ReviewResultTypes != input.ReviewResultTypes || (this.ReviewResultTypes != null && !this.ReviewResultTypes.Equals(input.ReviewResultTypes))) return false;
            if (this.JobStatusTypes != input.JobStatusTypes || (this.JobStatusTypes != null && !this.JobStatusTypes.Equals(input.JobStatusTypes))) return false;
            if (this.OrderByExecuteTime != input.OrderByExecuteTime || (this.OrderByExecuteTime != null && !this.OrderByExecuteTime.Equals(input.OrderByExecuteTime))) return false;
            if (this.TaskClassificationId != input.TaskClassificationId || (this.TaskClassificationId != null && !this.TaskClassificationId.Equals(input.TaskClassificationId))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.SortField != input.SortField || (this.SortField != null && !this.SortField.Equals(input.SortField))) return false;
            if (this.SortOrder != input.SortOrder || (this.SortOrder != null && !this.SortOrder.Equals(input.SortOrder))) return false;
            if (this.Operator != input.Operator || (this.Operator != null && !this.Operator.Equals(input.Operator))) return false;
            if (this.RepoUrl != input.RepoUrl || (this.RepoUrl != null && !this.RepoUrl.Equals(input.RepoUrl))) return false;
            if (this.Branch != input.Branch || (this.Branch != null && !this.Branch.Equals(input.Branch))) return false;
            if (this.RepoUrlFullMatch != input.RepoUrlFullMatch || (this.RepoUrlFullMatch != null && !this.RepoUrlFullMatch.Equals(input.RepoUrlFullMatch))) return false;

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
                if (this.Page != null) hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.PageSize != null) hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.Search != null) hashCode = hashCode * 59 + this.Search.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ReviewResultTypes != null) hashCode = hashCode * 59 + this.ReviewResultTypes.GetHashCode();
                if (this.JobStatusTypes != null) hashCode = hashCode * 59 + this.JobStatusTypes.GetHashCode();
                if (this.OrderByExecuteTime != null) hashCode = hashCode * 59 + this.OrderByExecuteTime.GetHashCode();
                if (this.TaskClassificationId != null) hashCode = hashCode * 59 + this.TaskClassificationId.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.SortField != null) hashCode = hashCode * 59 + this.SortField.GetHashCode();
                if (this.SortOrder != null) hashCode = hashCode * 59 + this.SortOrder.GetHashCode();
                if (this.Operator != null) hashCode = hashCode * 59 + this.Operator.GetHashCode();
                if (this.RepoUrl != null) hashCode = hashCode * 59 + this.RepoUrl.GetHashCode();
                if (this.Branch != null) hashCode = hashCode * 59 + this.Branch.GetHashCode();
                if (this.RepoUrlFullMatch != null) hashCode = hashCode * 59 + this.RepoUrlFullMatch.GetHashCode();
                return hashCode;
            }
        }
    }
}
