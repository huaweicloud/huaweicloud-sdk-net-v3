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
    /// 用例列表查询Body参数
    /// </summary>
    public class TestCasesListQueryInfo 
    {

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
        /// 关键字查询，用例名或编号
        /// </summary>
        [JsonProperty("keyword", NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// 用例名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 用例编号
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

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
        /// 服务类型
        /// </summary>
        [JsonProperty("service_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceType { get; set; }

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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestCasesListQueryInfo {\n");
            sb.Append("  versionUri: ").Append(VersionUri).Append("\n");
            sb.Append("  caseUris: ").Append(CaseUris).Append("\n");
            sb.Append("  ownerIds: ").Append(OwnerIds).Append("\n");
            sb.Append("  statusCodes: ").Append(StatusCodes).Append("\n");
            sb.Append("  rankIds: ").Append(RankIds).Append("\n");
            sb.Append("  moduleIds: ").Append(ModuleIds).Append("\n");
            sb.Append("  keyword: ").Append(Keyword).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  sortField: ").Append(SortField).Append("\n");
            sb.Append("  sortType: ").Append(SortType).Append("\n");
            sb.Append("  pageNo: ").Append(PageNo).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("  serviceType: ").Append(ServiceType).Append("\n");
            sb.Append("  stageType: ").Append(StageType).Append("\n");
            sb.Append("  featureUri: ").Append(FeatureUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TestCasesListQueryInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TestCasesListQueryInfo input)
        {
            if (input == null) return false;
            if (this.VersionUri != input.VersionUri || (this.VersionUri != null && !this.VersionUri.Equals(input.VersionUri))) return false;
            if (this.CaseUris != input.CaseUris || (this.CaseUris != null && input.CaseUris != null && !this.CaseUris.SequenceEqual(input.CaseUris))) return false;
            if (this.OwnerIds != input.OwnerIds || (this.OwnerIds != null && input.OwnerIds != null && !this.OwnerIds.SequenceEqual(input.OwnerIds))) return false;
            if (this.StatusCodes != input.StatusCodes || (this.StatusCodes != null && input.StatusCodes != null && !this.StatusCodes.SequenceEqual(input.StatusCodes))) return false;
            if (this.RankIds != input.RankIds || (this.RankIds != null && input.RankIds != null && !this.RankIds.SequenceEqual(input.RankIds))) return false;
            if (this.ModuleIds != input.ModuleIds || (this.ModuleIds != null && input.ModuleIds != null && !this.ModuleIds.SequenceEqual(input.ModuleIds))) return false;
            if (this.Keyword != input.Keyword || (this.Keyword != null && !this.Keyword.Equals(input.Keyword))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.SortField != input.SortField || (this.SortField != null && !this.SortField.Equals(input.SortField))) return false;
            if (this.SortType != input.SortType || (this.SortType != null && !this.SortType.Equals(input.SortType))) return false;
            if (this.PageNo != input.PageNo || (this.PageNo != null && !this.PageNo.Equals(input.PageNo))) return false;
            if (this.PageSize != input.PageSize || (this.PageSize != null && !this.PageSize.Equals(input.PageSize))) return false;
            if (this.ServiceType != input.ServiceType || (this.ServiceType != null && !this.ServiceType.Equals(input.ServiceType))) return false;
            if (this.StageType != input.StageType || (this.StageType != null && !this.StageType.Equals(input.StageType))) return false;
            if (this.FeatureUri != input.FeatureUri || (this.FeatureUri != null && !this.FeatureUri.Equals(input.FeatureUri))) return false;

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
                if (this.VersionUri != null) hashCode = hashCode * 59 + this.VersionUri.GetHashCode();
                if (this.CaseUris != null) hashCode = hashCode * 59 + this.CaseUris.GetHashCode();
                if (this.OwnerIds != null) hashCode = hashCode * 59 + this.OwnerIds.GetHashCode();
                if (this.StatusCodes != null) hashCode = hashCode * 59 + this.StatusCodes.GetHashCode();
                if (this.RankIds != null) hashCode = hashCode * 59 + this.RankIds.GetHashCode();
                if (this.ModuleIds != null) hashCode = hashCode * 59 + this.ModuleIds.GetHashCode();
                if (this.Keyword != null) hashCode = hashCode * 59 + this.Keyword.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.SortField != null) hashCode = hashCode * 59 + this.SortField.GetHashCode();
                if (this.SortType != null) hashCode = hashCode * 59 + this.SortType.GetHashCode();
                if (this.PageNo != null) hashCode = hashCode * 59 + this.PageNo.GetHashCode();
                if (this.PageSize != null) hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.ServiceType != null) hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.StageType != null) hashCode = hashCode * 59 + this.StageType.GetHashCode();
                if (this.FeatureUri != null) hashCode = hashCode * 59 + this.FeatureUri.GetHashCode();
                return hashCode;
            }
        }
    }
}
