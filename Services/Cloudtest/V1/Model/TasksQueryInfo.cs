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
    public class TasksQueryInfo 
    {

        /// <summary>
        /// 测试任务URI集合
        /// </summary>
        [JsonProperty("uris", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Uris { get; set; }

        /// <summary>
        /// 关键字查询，任务名或编号
        /// </summary>
        [JsonProperty("keyword", NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// 标签集合
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 是否是我的
        /// </summary>
        [JsonProperty("own", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Own { get; set; }

        /// <summary>
        /// 服务类型
        /// </summary>
        [JsonProperty("service_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceType { get; set; }

        /// <summary>
        /// 发布版本号集合
        /// </summary>
        [JsonProperty("release_dev_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ReleaseDevList { get; set; }

        /// <summary>
        /// 结果Code集合
        /// </summary>
        [JsonProperty("result_codes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ResultCodes { get; set; }

        /// <summary>
        /// 状态Code集合
        /// </summary>
        [JsonProperty("status_codes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> StatusCodes { get; set; }

        /// <summary>
        /// 责任人ID集合
        /// </summary>
        [JsonProperty("owner_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> OwnerIds { get; set; }

        /// <summary>
        /// 执行者ID集合
        /// </summary>
        [JsonProperty("executor_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExecutorIds { get; set; }

        /// <summary>
        /// 创建者ID集合
        /// </summary>
        [JsonProperty("creator_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CreatorIds { get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        [JsonProperty("sort_field", NullValueHandling = NullValueHandling.Ignore)]
        public string SortField { get; set; }

        /// <summary>
        /// 排序方式
        /// </summary>
        [JsonProperty("sort_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SortType { get; set; }

        /// <summary>
        /// 当前页数
        /// </summary>
        [JsonProperty("page_no", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageNo { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 是否轮询查询
        /// </summary>
        [JsonProperty("is_polling_query", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPollingQuery { get; set; }

        /// <summary>
        /// 是否获取关联用例列表
        /// </summary>
        [JsonProperty("is_query_associated_case_list", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsQueryAssociatedCaseList { get; set; }

        /// <summary>
        /// 计划开始时间过滤起始时间戳
        /// </summary>
        [JsonProperty("plan_start_start_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? PlanStartStartTimestamp { get; set; }

        /// <summary>
        /// 计划开始时间过滤结束时间戳
        /// </summary>
        [JsonProperty("plan_start_end_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? PlanStartEndTimestamp { get; set; }

        /// <summary>
        /// 计划结束时间过滤起始时间戳
        /// </summary>
        [JsonProperty("plan_end_start_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? PlanEndStartTimestamp { get; set; }

        /// <summary>
        /// 计划结束时间过滤结束时间戳
        /// </summary>
        [JsonProperty("plan_end_end_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? PlanEndEndTimestamp { get; set; }

        /// <summary>
        /// 测试套超期状态过滤，超期状态值分别为：无状态(null)、未超期(0)、即将超期(1)、已超期(2)、延期完成(3)、按期完成(4)
        /// </summary>
        [JsonProperty("expiration_status_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> ExpirationStatusList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TasksQueryInfo {\n");
            sb.Append("  uris: ").Append(Uris).Append("\n");
            sb.Append("  keyword: ").Append(Keyword).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  own: ").Append(Own).Append("\n");
            sb.Append("  serviceType: ").Append(ServiceType).Append("\n");
            sb.Append("  releaseDevList: ").Append(ReleaseDevList).Append("\n");
            sb.Append("  resultCodes: ").Append(ResultCodes).Append("\n");
            sb.Append("  statusCodes: ").Append(StatusCodes).Append("\n");
            sb.Append("  ownerIds: ").Append(OwnerIds).Append("\n");
            sb.Append("  executorIds: ").Append(ExecutorIds).Append("\n");
            sb.Append("  creatorIds: ").Append(CreatorIds).Append("\n");
            sb.Append("  sortField: ").Append(SortField).Append("\n");
            sb.Append("  sortType: ").Append(SortType).Append("\n");
            sb.Append("  pageNo: ").Append(PageNo).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("  isPollingQuery: ").Append(IsPollingQuery).Append("\n");
            sb.Append("  isQueryAssociatedCaseList: ").Append(IsQueryAssociatedCaseList).Append("\n");
            sb.Append("  planStartStartTimestamp: ").Append(PlanStartStartTimestamp).Append("\n");
            sb.Append("  planStartEndTimestamp: ").Append(PlanStartEndTimestamp).Append("\n");
            sb.Append("  planEndStartTimestamp: ").Append(PlanEndStartTimestamp).Append("\n");
            sb.Append("  planEndEndTimestamp: ").Append(PlanEndEndTimestamp).Append("\n");
            sb.Append("  expirationStatusList: ").Append(ExpirationStatusList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TasksQueryInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TasksQueryInfo input)
        {
            if (input == null) return false;
            if (this.Uris != input.Uris || (this.Uris != null && input.Uris != null && !this.Uris.SequenceEqual(input.Uris))) return false;
            if (this.Keyword != input.Keyword || (this.Keyword != null && !this.Keyword.Equals(input.Keyword))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.Own != input.Own || (this.Own != null && !this.Own.Equals(input.Own))) return false;
            if (this.ServiceType != input.ServiceType || (this.ServiceType != null && !this.ServiceType.Equals(input.ServiceType))) return false;
            if (this.ReleaseDevList != input.ReleaseDevList || (this.ReleaseDevList != null && input.ReleaseDevList != null && !this.ReleaseDevList.SequenceEqual(input.ReleaseDevList))) return false;
            if (this.ResultCodes != input.ResultCodes || (this.ResultCodes != null && input.ResultCodes != null && !this.ResultCodes.SequenceEqual(input.ResultCodes))) return false;
            if (this.StatusCodes != input.StatusCodes || (this.StatusCodes != null && input.StatusCodes != null && !this.StatusCodes.SequenceEqual(input.StatusCodes))) return false;
            if (this.OwnerIds != input.OwnerIds || (this.OwnerIds != null && input.OwnerIds != null && !this.OwnerIds.SequenceEqual(input.OwnerIds))) return false;
            if (this.ExecutorIds != input.ExecutorIds || (this.ExecutorIds != null && input.ExecutorIds != null && !this.ExecutorIds.SequenceEqual(input.ExecutorIds))) return false;
            if (this.CreatorIds != input.CreatorIds || (this.CreatorIds != null && input.CreatorIds != null && !this.CreatorIds.SequenceEqual(input.CreatorIds))) return false;
            if (this.SortField != input.SortField || (this.SortField != null && !this.SortField.Equals(input.SortField))) return false;
            if (this.SortType != input.SortType || (this.SortType != null && !this.SortType.Equals(input.SortType))) return false;
            if (this.PageNo != input.PageNo || (this.PageNo != null && !this.PageNo.Equals(input.PageNo))) return false;
            if (this.PageSize != input.PageSize || (this.PageSize != null && !this.PageSize.Equals(input.PageSize))) return false;
            if (this.IsPollingQuery != input.IsPollingQuery || (this.IsPollingQuery != null && !this.IsPollingQuery.Equals(input.IsPollingQuery))) return false;
            if (this.IsQueryAssociatedCaseList != input.IsQueryAssociatedCaseList || (this.IsQueryAssociatedCaseList != null && !this.IsQueryAssociatedCaseList.Equals(input.IsQueryAssociatedCaseList))) return false;
            if (this.PlanStartStartTimestamp != input.PlanStartStartTimestamp || (this.PlanStartStartTimestamp != null && !this.PlanStartStartTimestamp.Equals(input.PlanStartStartTimestamp))) return false;
            if (this.PlanStartEndTimestamp != input.PlanStartEndTimestamp || (this.PlanStartEndTimestamp != null && !this.PlanStartEndTimestamp.Equals(input.PlanStartEndTimestamp))) return false;
            if (this.PlanEndStartTimestamp != input.PlanEndStartTimestamp || (this.PlanEndStartTimestamp != null && !this.PlanEndStartTimestamp.Equals(input.PlanEndStartTimestamp))) return false;
            if (this.PlanEndEndTimestamp != input.PlanEndEndTimestamp || (this.PlanEndEndTimestamp != null && !this.PlanEndEndTimestamp.Equals(input.PlanEndEndTimestamp))) return false;
            if (this.ExpirationStatusList != input.ExpirationStatusList || (this.ExpirationStatusList != null && input.ExpirationStatusList != null && !this.ExpirationStatusList.SequenceEqual(input.ExpirationStatusList))) return false;

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
                if (this.Uris != null) hashCode = hashCode * 59 + this.Uris.GetHashCode();
                if (this.Keyword != null) hashCode = hashCode * 59 + this.Keyword.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Own != null) hashCode = hashCode * 59 + this.Own.GetHashCode();
                if (this.ServiceType != null) hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.ReleaseDevList != null) hashCode = hashCode * 59 + this.ReleaseDevList.GetHashCode();
                if (this.ResultCodes != null) hashCode = hashCode * 59 + this.ResultCodes.GetHashCode();
                if (this.StatusCodes != null) hashCode = hashCode * 59 + this.StatusCodes.GetHashCode();
                if (this.OwnerIds != null) hashCode = hashCode * 59 + this.OwnerIds.GetHashCode();
                if (this.ExecutorIds != null) hashCode = hashCode * 59 + this.ExecutorIds.GetHashCode();
                if (this.CreatorIds != null) hashCode = hashCode * 59 + this.CreatorIds.GetHashCode();
                if (this.SortField != null) hashCode = hashCode * 59 + this.SortField.GetHashCode();
                if (this.SortType != null) hashCode = hashCode * 59 + this.SortType.GetHashCode();
                if (this.PageNo != null) hashCode = hashCode * 59 + this.PageNo.GetHashCode();
                if (this.PageSize != null) hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.IsPollingQuery != null) hashCode = hashCode * 59 + this.IsPollingQuery.GetHashCode();
                if (this.IsQueryAssociatedCaseList != null) hashCode = hashCode * 59 + this.IsQueryAssociatedCaseList.GetHashCode();
                if (this.PlanStartStartTimestamp != null) hashCode = hashCode * 59 + this.PlanStartStartTimestamp.GetHashCode();
                if (this.PlanStartEndTimestamp != null) hashCode = hashCode * 59 + this.PlanStartEndTimestamp.GetHashCode();
                if (this.PlanEndStartTimestamp != null) hashCode = hashCode * 59 + this.PlanEndStartTimestamp.GetHashCode();
                if (this.PlanEndEndTimestamp != null) hashCode = hashCode * 59 + this.PlanEndEndTimestamp.GetHashCode();
                if (this.ExpirationStatusList != null) hashCode = hashCode * 59 + this.ExpirationStatusList.GetHashCode();
                return hashCode;
            }
        }
    }
}
