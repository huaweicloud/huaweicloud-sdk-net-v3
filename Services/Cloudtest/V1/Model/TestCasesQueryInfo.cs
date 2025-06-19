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
    public class TestCasesQueryInfo 
    {

        /// <summary>
        /// 关键字查询，用例名或编号
        /// </summary>
        [JsonProperty("keyword", NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// 执行平台
        /// </summary>
        [JsonProperty("exeplatforms", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Exeplatforms { get; set; }

        /// <summary>
        /// 是否是我的
        /// </summary>
        [JsonProperty("own", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Own { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("useOffset", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseOffset { get; set; }

        /// <summary>
        /// 版本URI
        /// </summary>
        [JsonProperty("version_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionUri { get; set; }

        /// <summary>
        /// 用例URI集合
        /// </summary>
        [JsonProperty("case_uris", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CaseUris { get; set; }

        /// <summary>
        /// 处理者ID集合
        /// </summary>
        [JsonProperty("owner_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> OwnerIds { get; set; }

        /// <summary>
        /// 状态Code集合
        /// </summary>
        [JsonProperty("status_codes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> StatusCodes { get; set; }

        /// <summary>
        /// 用例等级ID集合
        /// </summary>
        [JsonProperty("rank_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RankIds { get; set; }

        /// <summary>
        /// 模块ID集合
        /// </summary>
        [JsonProperty("module_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ModuleIds { get; set; }

        /// <summary>
        /// 需求编号
        /// </summary>
        [JsonProperty("issue_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueId { get; set; }

        /// <summary>
        /// 创建者ID集合
        /// </summary>
        [JsonProperty("creator_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CreatorIds { get; set; }

        /// <summary>
        /// 结果Code集合
        /// </summary>
        [JsonProperty("result_codes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ResultCodes { get; set; }

        /// <summary>
        /// 归属迭代ID集合
        /// </summary>
        [JsonProperty("iteration_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IterationIds { get; set; }

        /// <summary>
        /// 创建开始时间
        /// </summary>
        [JsonProperty("create_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateStartTime { get; set; }

        /// <summary>
        /// 创建结束时间
        /// </summary>
        [JsonProperty("create_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateEndTime { get; set; }

        /// <summary>
        /// 是否关联需求（null：不限，false：未关联，true：已关联）
        /// </summary>
        [JsonProperty("associated_issue", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AssociatedIssue { get; set; }

        /// <summary>
        /// 是否关联缺陷（null：不限，false：未关联，true：已关联）
        /// </summary>
        [JsonProperty("associated_defects", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AssociatedDefects { get; set; }

        /// <summary>
        /// 是否查询子需求关联的用例，默认true
        /// </summary>
        [JsonProperty("include_sub_issue", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeSubIssue { get; set; }

        /// <summary>
        /// 是否查询子目录的用例，默认true
        /// </summary>
        [JsonProperty("include_sub_feature", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeSubFeature { get; set; }

        /// <summary>
        /// 标签ID集合
        /// </summary>
        [JsonProperty("label_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LabelIds { get; set; }

        /// <summary>
        /// 执行开始时间
        /// </summary>
        [JsonProperty("execute_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecuteStartTime { get; set; }

        /// <summary>
        /// 执行结束时间
        /// </summary>
        [JsonProperty("execute_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecuteEndTime { get; set; }

        /// <summary>
        /// 执行者ID集合
        /// </summary>
        [JsonProperty("executor_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExecutorIds { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonProperty("test_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TestTypes { get; set; }

        /// <summary>
        /// 是否组合关键字
        /// </summary>
        [JsonProperty("is_keyword", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsKeyword { get; set; }

        /// <summary>
        /// 是否是需求树点击的查询关联用例
        /// </summary>
        [JsonProperty("issue_tree_search", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IssueTreeSearch { get; set; }

        /// <summary>
        /// 服务类型
        /// </summary>
        [JsonProperty("service_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceType { get; set; }

        /// <summary>
        /// 服务类型集合
        /// </summary>
        [JsonProperty("service_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> ServiceTypes { get; set; }

        /// <summary>
        /// 阶段过程（2：测试设计，3：测试执行，4：质量报告）
        /// </summary>
        [JsonProperty("stage_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? StageType { get; set; }

        /// <summary>
        /// 目录URI
        /// </summary>
        [JsonProperty("feature_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string FeatureUri { get; set; }

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
        /// 用例类型
        /// </summary>
        [JsonProperty("case_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? CaseType { get; set; }

        /// <summary>
        /// 用例自定义字段信息
        /// </summary>
        [JsonProperty("custom_field_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<QueryCustomFieldsInfo> CustomFieldInfo { get; set; }

        /// <summary>
        /// 测试套uri
        /// </summary>
        [JsonProperty("task_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskUri { get; set; }

        /// <summary>
        /// 是否返回需求具体信息（返回需求名称，需求id）
        /// </summary>
        [JsonProperty("associate_issue_detail", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AssociateIssueDetail { get; set; }

        /// <summary>
        /// 该字段为false,则查询全量用例，为true表示查询未分配测试套的用例
        /// </summary>
        [JsonProperty("not_assign_task", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NotAssignTask { get; set; }

        /// <summary>
        /// 是否来自测试设计（null或者[true, false]：不限，[true]：来自测试设计，[false]：否来自测试设计）
        /// </summary>
        [JsonProperty("test_designs", NullValueHandling = NullValueHandling.Ignore)]
        public List<bool?> TestDesigns { get; set; }

        /// <summary>
        /// 用例评审状态
        /// </summary>
        [JsonProperty("review_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReviewStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestCasesQueryInfo {\n");
            sb.Append("  keyword: ").Append(Keyword).Append("\n");
            sb.Append("  exeplatforms: ").Append(Exeplatforms).Append("\n");
            sb.Append("  own: ").Append(Own).Append("\n");
            sb.Append("  useOffset: ").Append(UseOffset).Append("\n");
            sb.Append("  versionUri: ").Append(VersionUri).Append("\n");
            sb.Append("  caseUris: ").Append(CaseUris).Append("\n");
            sb.Append("  ownerIds: ").Append(OwnerIds).Append("\n");
            sb.Append("  statusCodes: ").Append(StatusCodes).Append("\n");
            sb.Append("  rankIds: ").Append(RankIds).Append("\n");
            sb.Append("  moduleIds: ").Append(ModuleIds).Append("\n");
            sb.Append("  issueId: ").Append(IssueId).Append("\n");
            sb.Append("  creatorIds: ").Append(CreatorIds).Append("\n");
            sb.Append("  resultCodes: ").Append(ResultCodes).Append("\n");
            sb.Append("  iterationIds: ").Append(IterationIds).Append("\n");
            sb.Append("  createStartTime: ").Append(CreateStartTime).Append("\n");
            sb.Append("  createEndTime: ").Append(CreateEndTime).Append("\n");
            sb.Append("  associatedIssue: ").Append(AssociatedIssue).Append("\n");
            sb.Append("  associatedDefects: ").Append(AssociatedDefects).Append("\n");
            sb.Append("  includeSubIssue: ").Append(IncludeSubIssue).Append("\n");
            sb.Append("  includeSubFeature: ").Append(IncludeSubFeature).Append("\n");
            sb.Append("  labelIds: ").Append(LabelIds).Append("\n");
            sb.Append("  executeStartTime: ").Append(ExecuteStartTime).Append("\n");
            sb.Append("  executeEndTime: ").Append(ExecuteEndTime).Append("\n");
            sb.Append("  executorIds: ").Append(ExecutorIds).Append("\n");
            sb.Append("  testTypes: ").Append(TestTypes).Append("\n");
            sb.Append("  isKeyword: ").Append(IsKeyword).Append("\n");
            sb.Append("  issueTreeSearch: ").Append(IssueTreeSearch).Append("\n");
            sb.Append("  serviceType: ").Append(ServiceType).Append("\n");
            sb.Append("  serviceTypes: ").Append(ServiceTypes).Append("\n");
            sb.Append("  stageType: ").Append(StageType).Append("\n");
            sb.Append("  featureUri: ").Append(FeatureUri).Append("\n");
            sb.Append("  sortField: ").Append(SortField).Append("\n");
            sb.Append("  sortType: ").Append(SortType).Append("\n");
            sb.Append("  pageNo: ").Append(PageNo).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("  caseType: ").Append(CaseType).Append("\n");
            sb.Append("  customFieldInfo: ").Append(CustomFieldInfo).Append("\n");
            sb.Append("  taskUri: ").Append(TaskUri).Append("\n");
            sb.Append("  associateIssueDetail: ").Append(AssociateIssueDetail).Append("\n");
            sb.Append("  notAssignTask: ").Append(NotAssignTask).Append("\n");
            sb.Append("  testDesigns: ").Append(TestDesigns).Append("\n");
            sb.Append("  reviewStatus: ").Append(ReviewStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TestCasesQueryInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TestCasesQueryInfo input)
        {
            if (input == null) return false;
            if (this.Keyword != input.Keyword || (this.Keyword != null && !this.Keyword.Equals(input.Keyword))) return false;
            if (this.Exeplatforms != input.Exeplatforms || (this.Exeplatforms != null && input.Exeplatforms != null && !this.Exeplatforms.SequenceEqual(input.Exeplatforms))) return false;
            if (this.Own != input.Own || (this.Own != null && !this.Own.Equals(input.Own))) return false;
            if (this.UseOffset != input.UseOffset || (this.UseOffset != null && !this.UseOffset.Equals(input.UseOffset))) return false;
            if (this.VersionUri != input.VersionUri || (this.VersionUri != null && !this.VersionUri.Equals(input.VersionUri))) return false;
            if (this.CaseUris != input.CaseUris || (this.CaseUris != null && input.CaseUris != null && !this.CaseUris.SequenceEqual(input.CaseUris))) return false;
            if (this.OwnerIds != input.OwnerIds || (this.OwnerIds != null && input.OwnerIds != null && !this.OwnerIds.SequenceEqual(input.OwnerIds))) return false;
            if (this.StatusCodes != input.StatusCodes || (this.StatusCodes != null && input.StatusCodes != null && !this.StatusCodes.SequenceEqual(input.StatusCodes))) return false;
            if (this.RankIds != input.RankIds || (this.RankIds != null && input.RankIds != null && !this.RankIds.SequenceEqual(input.RankIds))) return false;
            if (this.ModuleIds != input.ModuleIds || (this.ModuleIds != null && input.ModuleIds != null && !this.ModuleIds.SequenceEqual(input.ModuleIds))) return false;
            if (this.IssueId != input.IssueId || (this.IssueId != null && !this.IssueId.Equals(input.IssueId))) return false;
            if (this.CreatorIds != input.CreatorIds || (this.CreatorIds != null && input.CreatorIds != null && !this.CreatorIds.SequenceEqual(input.CreatorIds))) return false;
            if (this.ResultCodes != input.ResultCodes || (this.ResultCodes != null && input.ResultCodes != null && !this.ResultCodes.SequenceEqual(input.ResultCodes))) return false;
            if (this.IterationIds != input.IterationIds || (this.IterationIds != null && input.IterationIds != null && !this.IterationIds.SequenceEqual(input.IterationIds))) return false;
            if (this.CreateStartTime != input.CreateStartTime || (this.CreateStartTime != null && !this.CreateStartTime.Equals(input.CreateStartTime))) return false;
            if (this.CreateEndTime != input.CreateEndTime || (this.CreateEndTime != null && !this.CreateEndTime.Equals(input.CreateEndTime))) return false;
            if (this.AssociatedIssue != input.AssociatedIssue || (this.AssociatedIssue != null && !this.AssociatedIssue.Equals(input.AssociatedIssue))) return false;
            if (this.AssociatedDefects != input.AssociatedDefects || (this.AssociatedDefects != null && !this.AssociatedDefects.Equals(input.AssociatedDefects))) return false;
            if (this.IncludeSubIssue != input.IncludeSubIssue || (this.IncludeSubIssue != null && !this.IncludeSubIssue.Equals(input.IncludeSubIssue))) return false;
            if (this.IncludeSubFeature != input.IncludeSubFeature || (this.IncludeSubFeature != null && !this.IncludeSubFeature.Equals(input.IncludeSubFeature))) return false;
            if (this.LabelIds != input.LabelIds || (this.LabelIds != null && input.LabelIds != null && !this.LabelIds.SequenceEqual(input.LabelIds))) return false;
            if (this.ExecuteStartTime != input.ExecuteStartTime || (this.ExecuteStartTime != null && !this.ExecuteStartTime.Equals(input.ExecuteStartTime))) return false;
            if (this.ExecuteEndTime != input.ExecuteEndTime || (this.ExecuteEndTime != null && !this.ExecuteEndTime.Equals(input.ExecuteEndTime))) return false;
            if (this.ExecutorIds != input.ExecutorIds || (this.ExecutorIds != null && input.ExecutorIds != null && !this.ExecutorIds.SequenceEqual(input.ExecutorIds))) return false;
            if (this.TestTypes != input.TestTypes || (this.TestTypes != null && input.TestTypes != null && !this.TestTypes.SequenceEqual(input.TestTypes))) return false;
            if (this.IsKeyword != input.IsKeyword || (this.IsKeyword != null && !this.IsKeyword.Equals(input.IsKeyword))) return false;
            if (this.IssueTreeSearch != input.IssueTreeSearch || (this.IssueTreeSearch != null && !this.IssueTreeSearch.Equals(input.IssueTreeSearch))) return false;
            if (this.ServiceType != input.ServiceType || (this.ServiceType != null && !this.ServiceType.Equals(input.ServiceType))) return false;
            if (this.ServiceTypes != input.ServiceTypes || (this.ServiceTypes != null && input.ServiceTypes != null && !this.ServiceTypes.SequenceEqual(input.ServiceTypes))) return false;
            if (this.StageType != input.StageType || (this.StageType != null && !this.StageType.Equals(input.StageType))) return false;
            if (this.FeatureUri != input.FeatureUri || (this.FeatureUri != null && !this.FeatureUri.Equals(input.FeatureUri))) return false;
            if (this.SortField != input.SortField || (this.SortField != null && !this.SortField.Equals(input.SortField))) return false;
            if (this.SortType != input.SortType || (this.SortType != null && !this.SortType.Equals(input.SortType))) return false;
            if (this.PageNo != input.PageNo || (this.PageNo != null && !this.PageNo.Equals(input.PageNo))) return false;
            if (this.PageSize != input.PageSize || (this.PageSize != null && !this.PageSize.Equals(input.PageSize))) return false;
            if (this.CaseType != input.CaseType || (this.CaseType != null && !this.CaseType.Equals(input.CaseType))) return false;
            if (this.CustomFieldInfo != input.CustomFieldInfo || (this.CustomFieldInfo != null && input.CustomFieldInfo != null && !this.CustomFieldInfo.SequenceEqual(input.CustomFieldInfo))) return false;
            if (this.TaskUri != input.TaskUri || (this.TaskUri != null && !this.TaskUri.Equals(input.TaskUri))) return false;
            if (this.AssociateIssueDetail != input.AssociateIssueDetail || (this.AssociateIssueDetail != null && !this.AssociateIssueDetail.Equals(input.AssociateIssueDetail))) return false;
            if (this.NotAssignTask != input.NotAssignTask || (this.NotAssignTask != null && !this.NotAssignTask.Equals(input.NotAssignTask))) return false;
            if (this.TestDesigns != input.TestDesigns || (this.TestDesigns != null && input.TestDesigns != null && !this.TestDesigns.SequenceEqual(input.TestDesigns))) return false;
            if (this.ReviewStatus != input.ReviewStatus || (this.ReviewStatus != null && !this.ReviewStatus.Equals(input.ReviewStatus))) return false;

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
                if (this.Keyword != null) hashCode = hashCode * 59 + this.Keyword.GetHashCode();
                if (this.Exeplatforms != null) hashCode = hashCode * 59 + this.Exeplatforms.GetHashCode();
                if (this.Own != null) hashCode = hashCode * 59 + this.Own.GetHashCode();
                if (this.UseOffset != null) hashCode = hashCode * 59 + this.UseOffset.GetHashCode();
                if (this.VersionUri != null) hashCode = hashCode * 59 + this.VersionUri.GetHashCode();
                if (this.CaseUris != null) hashCode = hashCode * 59 + this.CaseUris.GetHashCode();
                if (this.OwnerIds != null) hashCode = hashCode * 59 + this.OwnerIds.GetHashCode();
                if (this.StatusCodes != null) hashCode = hashCode * 59 + this.StatusCodes.GetHashCode();
                if (this.RankIds != null) hashCode = hashCode * 59 + this.RankIds.GetHashCode();
                if (this.ModuleIds != null) hashCode = hashCode * 59 + this.ModuleIds.GetHashCode();
                if (this.IssueId != null) hashCode = hashCode * 59 + this.IssueId.GetHashCode();
                if (this.CreatorIds != null) hashCode = hashCode * 59 + this.CreatorIds.GetHashCode();
                if (this.ResultCodes != null) hashCode = hashCode * 59 + this.ResultCodes.GetHashCode();
                if (this.IterationIds != null) hashCode = hashCode * 59 + this.IterationIds.GetHashCode();
                if (this.CreateStartTime != null) hashCode = hashCode * 59 + this.CreateStartTime.GetHashCode();
                if (this.CreateEndTime != null) hashCode = hashCode * 59 + this.CreateEndTime.GetHashCode();
                if (this.AssociatedIssue != null) hashCode = hashCode * 59 + this.AssociatedIssue.GetHashCode();
                if (this.AssociatedDefects != null) hashCode = hashCode * 59 + this.AssociatedDefects.GetHashCode();
                if (this.IncludeSubIssue != null) hashCode = hashCode * 59 + this.IncludeSubIssue.GetHashCode();
                if (this.IncludeSubFeature != null) hashCode = hashCode * 59 + this.IncludeSubFeature.GetHashCode();
                if (this.LabelIds != null) hashCode = hashCode * 59 + this.LabelIds.GetHashCode();
                if (this.ExecuteStartTime != null) hashCode = hashCode * 59 + this.ExecuteStartTime.GetHashCode();
                if (this.ExecuteEndTime != null) hashCode = hashCode * 59 + this.ExecuteEndTime.GetHashCode();
                if (this.ExecutorIds != null) hashCode = hashCode * 59 + this.ExecutorIds.GetHashCode();
                if (this.TestTypes != null) hashCode = hashCode * 59 + this.TestTypes.GetHashCode();
                if (this.IsKeyword != null) hashCode = hashCode * 59 + this.IsKeyword.GetHashCode();
                if (this.IssueTreeSearch != null) hashCode = hashCode * 59 + this.IssueTreeSearch.GetHashCode();
                if (this.ServiceType != null) hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.ServiceTypes != null) hashCode = hashCode * 59 + this.ServiceTypes.GetHashCode();
                if (this.StageType != null) hashCode = hashCode * 59 + this.StageType.GetHashCode();
                if (this.FeatureUri != null) hashCode = hashCode * 59 + this.FeatureUri.GetHashCode();
                if (this.SortField != null) hashCode = hashCode * 59 + this.SortField.GetHashCode();
                if (this.SortType != null) hashCode = hashCode * 59 + this.SortType.GetHashCode();
                if (this.PageNo != null) hashCode = hashCode * 59 + this.PageNo.GetHashCode();
                if (this.PageSize != null) hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.CaseType != null) hashCode = hashCode * 59 + this.CaseType.GetHashCode();
                if (this.CustomFieldInfo != null) hashCode = hashCode * 59 + this.CustomFieldInfo.GetHashCode();
                if (this.TaskUri != null) hashCode = hashCode * 59 + this.TaskUri.GetHashCode();
                if (this.AssociateIssueDetail != null) hashCode = hashCode * 59 + this.AssociateIssueDetail.GetHashCode();
                if (this.NotAssignTask != null) hashCode = hashCode * 59 + this.NotAssignTask.GetHashCode();
                if (this.TestDesigns != null) hashCode = hashCode * 59 + this.TestDesigns.GetHashCode();
                if (this.ReviewStatus != null) hashCode = hashCode * 59 + this.ReviewStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
