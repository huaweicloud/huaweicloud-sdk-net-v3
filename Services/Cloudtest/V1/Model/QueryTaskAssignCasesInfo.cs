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
    public class QueryTaskAssignCasesInfo 
    {

        /// <summary>
        /// 测试用例在任务中的阶段
        /// </summary>
        [JsonProperty("stage", NullValueHandling = NullValueHandling.Ignore)]
        public int? Stage { get; set; }

        /// <summary>
        /// 处理人过滤数组
        /// </summary>
        [JsonProperty("owners", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Owners { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("page_no", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageNo { get; set; }

        /// <summary>
        /// 页数量
        /// </summary>
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 结果过滤
        /// </summary>
        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Results { get; set; }

        /// <summary>
        /// 状态过滤
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Status { get; set; }

        /// <summary>
        /// 分支/迭代uri
        /// </summary>
        [JsonProperty("version_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionUri { get; set; }

        /// <summary>
        /// 任务版本过滤条件，影响关联任务的结果查询，查询当前任务版本下的用例最新结果
        /// </summary>
        [JsonProperty("release_dev", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleaseDev { get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        [JsonProperty("sort_field", NullValueHandling = NullValueHandling.Ignore)]
        public string SortField { get; set; }

        /// <summary>
        /// 排序方法
        /// </summary>
        [JsonProperty("sort_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SortType { get; set; }

        /// <summary>
        /// 特性目录URI
        /// </summary>
        [JsonProperty("feature_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string FeatureUri { get; set; }

        /// <summary>
        /// 测试套结果uri
        /// </summary>
        [JsonProperty("task_result_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskResultUri { get; set; }

        /// <summary>
        /// 用例等级ID集合
        /// </summary>
        [JsonProperty("rank_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> RankIds { get; set; }

        /// <summary>
        /// 关键字
        /// </summary>
        [JsonProperty("key_word", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyWord { get; set; }

        /// <summary>
        /// 需求id
        /// </summary>
        [JsonProperty("issue_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueId { get; set; }

        /// <summary>
        /// 是否关联需求（null：不限，false：未关联，true：已关联）
        /// </summary>
        [JsonProperty("associated_issue", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AssociatedIssue { get; set; }

        /// <summary>
        /// 是否全选所有页（null：不全选，false：不全选，true：全选），用于任务批量执行结果功能，只返回用例uri，不返回其他信息
        /// </summary>
        [JsonProperty("select_all_pages", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SelectAllPages { get; set; }

        /// <summary>
        /// 用例是否可用
        /// </summary>
        [JsonProperty("is_available", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAvailable { get; set; }

        /// <summary>
        /// 用例脚本字段是否有值
        /// </summary>
        [JsonProperty("is_script_exist", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsScriptExist { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryTaskAssignCasesInfo {\n");
            sb.Append("  stage: ").Append(Stage).Append("\n");
            sb.Append("  owners: ").Append(Owners).Append("\n");
            sb.Append("  pageNo: ").Append(PageNo).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("  results: ").Append(Results).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  versionUri: ").Append(VersionUri).Append("\n");
            sb.Append("  releaseDev: ").Append(ReleaseDev).Append("\n");
            sb.Append("  sortField: ").Append(SortField).Append("\n");
            sb.Append("  sortType: ").Append(SortType).Append("\n");
            sb.Append("  featureUri: ").Append(FeatureUri).Append("\n");
            sb.Append("  taskResultUri: ").Append(TaskResultUri).Append("\n");
            sb.Append("  rankIds: ").Append(RankIds).Append("\n");
            sb.Append("  keyWord: ").Append(KeyWord).Append("\n");
            sb.Append("  issueId: ").Append(IssueId).Append("\n");
            sb.Append("  associatedIssue: ").Append(AssociatedIssue).Append("\n");
            sb.Append("  selectAllPages: ").Append(SelectAllPages).Append("\n");
            sb.Append("  isAvailable: ").Append(IsAvailable).Append("\n");
            sb.Append("  isScriptExist: ").Append(IsScriptExist).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryTaskAssignCasesInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryTaskAssignCasesInfo input)
        {
            if (input == null) return false;
            if (this.Stage != input.Stage || (this.Stage != null && !this.Stage.Equals(input.Stage))) return false;
            if (this.Owners != input.Owners || (this.Owners != null && input.Owners != null && !this.Owners.SequenceEqual(input.Owners))) return false;
            if (this.PageNo != input.PageNo || (this.PageNo != null && !this.PageNo.Equals(input.PageNo))) return false;
            if (this.PageSize != input.PageSize || (this.PageSize != null && !this.PageSize.Equals(input.PageSize))) return false;
            if (this.Results != input.Results || (this.Results != null && input.Results != null && !this.Results.SequenceEqual(input.Results))) return false;
            if (this.Status != input.Status || (this.Status != null && input.Status != null && !this.Status.SequenceEqual(input.Status))) return false;
            if (this.VersionUri != input.VersionUri || (this.VersionUri != null && !this.VersionUri.Equals(input.VersionUri))) return false;
            if (this.ReleaseDev != input.ReleaseDev || (this.ReleaseDev != null && !this.ReleaseDev.Equals(input.ReleaseDev))) return false;
            if (this.SortField != input.SortField || (this.SortField != null && !this.SortField.Equals(input.SortField))) return false;
            if (this.SortType != input.SortType || (this.SortType != null && !this.SortType.Equals(input.SortType))) return false;
            if (this.FeatureUri != input.FeatureUri || (this.FeatureUri != null && !this.FeatureUri.Equals(input.FeatureUri))) return false;
            if (this.TaskResultUri != input.TaskResultUri || (this.TaskResultUri != null && !this.TaskResultUri.Equals(input.TaskResultUri))) return false;
            if (this.RankIds != input.RankIds || (this.RankIds != null && input.RankIds != null && !this.RankIds.SequenceEqual(input.RankIds))) return false;
            if (this.KeyWord != input.KeyWord || (this.KeyWord != null && !this.KeyWord.Equals(input.KeyWord))) return false;
            if (this.IssueId != input.IssueId || (this.IssueId != null && !this.IssueId.Equals(input.IssueId))) return false;
            if (this.AssociatedIssue != input.AssociatedIssue || (this.AssociatedIssue != null && !this.AssociatedIssue.Equals(input.AssociatedIssue))) return false;
            if (this.SelectAllPages != input.SelectAllPages || (this.SelectAllPages != null && !this.SelectAllPages.Equals(input.SelectAllPages))) return false;
            if (this.IsAvailable != input.IsAvailable || (this.IsAvailable != null && !this.IsAvailable.Equals(input.IsAvailable))) return false;
            if (this.IsScriptExist != input.IsScriptExist || (this.IsScriptExist != null && !this.IsScriptExist.Equals(input.IsScriptExist))) return false;

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
                if (this.Stage != null) hashCode = hashCode * 59 + this.Stage.GetHashCode();
                if (this.Owners != null) hashCode = hashCode * 59 + this.Owners.GetHashCode();
                if (this.PageNo != null) hashCode = hashCode * 59 + this.PageNo.GetHashCode();
                if (this.PageSize != null) hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.Results != null) hashCode = hashCode * 59 + this.Results.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.VersionUri != null) hashCode = hashCode * 59 + this.VersionUri.GetHashCode();
                if (this.ReleaseDev != null) hashCode = hashCode * 59 + this.ReleaseDev.GetHashCode();
                if (this.SortField != null) hashCode = hashCode * 59 + this.SortField.GetHashCode();
                if (this.SortType != null) hashCode = hashCode * 59 + this.SortType.GetHashCode();
                if (this.FeatureUri != null) hashCode = hashCode * 59 + this.FeatureUri.GetHashCode();
                if (this.TaskResultUri != null) hashCode = hashCode * 59 + this.TaskResultUri.GetHashCode();
                if (this.RankIds != null) hashCode = hashCode * 59 + this.RankIds.GetHashCode();
                if (this.KeyWord != null) hashCode = hashCode * 59 + this.KeyWord.GetHashCode();
                if (this.IssueId != null) hashCode = hashCode * 59 + this.IssueId.GetHashCode();
                if (this.AssociatedIssue != null) hashCode = hashCode * 59 + this.AssociatedIssue.GetHashCode();
                if (this.SelectAllPages != null) hashCode = hashCode * 59 + this.SelectAllPages.GetHashCode();
                if (this.IsAvailable != null) hashCode = hashCode * 59 + this.IsAvailable.GetHashCode();
                if (this.IsScriptExist != null) hashCode = hashCode * 59 + this.IsScriptExist.GetHashCode();
                return hashCode;
            }
        }
    }
}
