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
    public class IteratorVersionsQueryInfo 
    {

        /// <summary>
        /// 迭代计划名称（支持模糊搜索）
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public IteratorListFilterInfo Filter { get; set; }

        /// <summary>
        /// 是否是我的
        /// </summary>
        [JsonProperty("own", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Own { get; set; }

        /// <summary>
        /// 分支URI
        /// </summary>
        [JsonProperty("branch_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchUri { get; set; }

        /// <summary>
        /// 迭代计划URI
        /// </summary>
        [JsonProperty("iterator_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string IteratorUri { get; set; }

        /// <summary>
        /// 迭代计划责任人集合
        /// </summary>
        [JsonProperty("owner_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> OwnerIds { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectUuid { get; set; }

        /// <summary>
        /// 迭代计划所处节点
        /// </summary>
        [JsonProperty("current_stage", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentStage { get; set; }

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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IteratorVersionsQueryInfo {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  filter: ").Append(Filter).Append("\n");
            sb.Append("  own: ").Append(Own).Append("\n");
            sb.Append("  branchUri: ").Append(BranchUri).Append("\n");
            sb.Append("  iteratorUri: ").Append(IteratorUri).Append("\n");
            sb.Append("  ownerIds: ").Append(OwnerIds).Append("\n");
            sb.Append("  projectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("  currentStage: ").Append(CurrentStage).Append("\n");
            sb.Append("  pageNo: ").Append(PageNo).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IteratorVersionsQueryInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IteratorVersionsQueryInfo input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Filter != input.Filter || (this.Filter != null && !this.Filter.Equals(input.Filter))) return false;
            if (this.Own != input.Own || (this.Own != null && !this.Own.Equals(input.Own))) return false;
            if (this.BranchUri != input.BranchUri || (this.BranchUri != null && !this.BranchUri.Equals(input.BranchUri))) return false;
            if (this.IteratorUri != input.IteratorUri || (this.IteratorUri != null && !this.IteratorUri.Equals(input.IteratorUri))) return false;
            if (this.OwnerIds != input.OwnerIds || (this.OwnerIds != null && input.OwnerIds != null && !this.OwnerIds.SequenceEqual(input.OwnerIds))) return false;
            if (this.ProjectUuid != input.ProjectUuid || (this.ProjectUuid != null && !this.ProjectUuid.Equals(input.ProjectUuid))) return false;
            if (this.CurrentStage != input.CurrentStage || (this.CurrentStage != null && !this.CurrentStage.Equals(input.CurrentStage))) return false;
            if (this.PageNo != input.PageNo || (this.PageNo != null && !this.PageNo.Equals(input.PageNo))) return false;
            if (this.PageSize != input.PageSize || (this.PageSize != null && !this.PageSize.Equals(input.PageSize))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Filter != null) hashCode = hashCode * 59 + this.Filter.GetHashCode();
                if (this.Own != null) hashCode = hashCode * 59 + this.Own.GetHashCode();
                if (this.BranchUri != null) hashCode = hashCode * 59 + this.BranchUri.GetHashCode();
                if (this.IteratorUri != null) hashCode = hashCode * 59 + this.IteratorUri.GetHashCode();
                if (this.OwnerIds != null) hashCode = hashCode * 59 + this.OwnerIds.GetHashCode();
                if (this.ProjectUuid != null) hashCode = hashCode * 59 + this.ProjectUuid.GetHashCode();
                if (this.CurrentStage != null) hashCode = hashCode * 59 + this.CurrentStage.GetHashCode();
                if (this.PageNo != null) hashCode = hashCode * 59 + this.PageNo.GetHashCode();
                if (this.PageSize != null) hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
