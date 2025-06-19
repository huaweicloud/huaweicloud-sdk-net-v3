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
    /// 查询迭代的需求树Body
    /// </summary>
    public class IssueTreeInfo 
    {

        /// <summary>
        /// 过滤条件：处理人
        /// </summary>
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public string Owner { get; set; }

        /// <summary>
        /// 需求ID
        /// </summary>
        [JsonProperty("issue_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("page_no", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageNo { get; set; }

        /// <summary>
        /// 每页展示条数
        /// </summary>
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 关键字
        /// </summary>
        [JsonProperty("key_word", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyWord { get; set; }

        /// <summary>
        /// 过滤条件：迭代ID
        /// </summary>
        [JsonProperty("iteration_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IterationId { get; set; }

        /// <summary>
        /// 过滤条件：重要程度ID
        /// </summary>
        [JsonProperty("severity_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SeverityId { get; set; }

        /// <summary>
        /// 过滤条件：状态ID
        /// </summary>
        [JsonProperty("status_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusId { get; set; }

        /// <summary>
        /// 过滤条件：模块ID
        /// </summary>
        [JsonProperty("module_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ModuleId { get; set; }

        /// <summary>
        /// 过滤条件：状态ID多个条件，每个条件取或，-2代表搜索未设置
        /// </summary>
        [JsonProperty("status_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusIds { get; set; }

        /// <summary>
        /// 过滤条件：模块ID多个，每个条件取或，-2代表搜索未设置
        /// </summary>
        [JsonProperty("module_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string ModuleIds { get; set; }

        /// <summary>
        /// 迭代、pi过滤条件
        /// </summary>
        [JsonProperty("pi_filter", NullValueHandling = NullValueHandling.Ignore)]
        public List<IssueListPiFilterInfo> PiFilter { get; set; }

        /// <summary>
        /// 状态名称列表
        /// </summary>
        [JsonProperty("status_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> StatusNames { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueTreeInfo {\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("  issueId: ").Append(IssueId).Append("\n");
            sb.Append("  pageNo: ").Append(PageNo).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("  keyWord: ").Append(KeyWord).Append("\n");
            sb.Append("  iterationId: ").Append(IterationId).Append("\n");
            sb.Append("  severityId: ").Append(SeverityId).Append("\n");
            sb.Append("  statusId: ").Append(StatusId).Append("\n");
            sb.Append("  moduleId: ").Append(ModuleId).Append("\n");
            sb.Append("  statusIds: ").Append(StatusIds).Append("\n");
            sb.Append("  moduleIds: ").Append(ModuleIds).Append("\n");
            sb.Append("  piFilter: ").Append(PiFilter).Append("\n");
            sb.Append("  statusNames: ").Append(StatusNames).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IssueTreeInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IssueTreeInfo input)
        {
            if (input == null) return false;
            if (this.Owner != input.Owner || (this.Owner != null && !this.Owner.Equals(input.Owner))) return false;
            if (this.IssueId != input.IssueId || (this.IssueId != null && !this.IssueId.Equals(input.IssueId))) return false;
            if (this.PageNo != input.PageNo || (this.PageNo != null && !this.PageNo.Equals(input.PageNo))) return false;
            if (this.PageSize != input.PageSize || (this.PageSize != null && !this.PageSize.Equals(input.PageSize))) return false;
            if (this.KeyWord != input.KeyWord || (this.KeyWord != null && !this.KeyWord.Equals(input.KeyWord))) return false;
            if (this.IterationId != input.IterationId || (this.IterationId != null && !this.IterationId.Equals(input.IterationId))) return false;
            if (this.SeverityId != input.SeverityId || (this.SeverityId != null && !this.SeverityId.Equals(input.SeverityId))) return false;
            if (this.StatusId != input.StatusId || (this.StatusId != null && !this.StatusId.Equals(input.StatusId))) return false;
            if (this.ModuleId != input.ModuleId || (this.ModuleId != null && !this.ModuleId.Equals(input.ModuleId))) return false;
            if (this.StatusIds != input.StatusIds || (this.StatusIds != null && !this.StatusIds.Equals(input.StatusIds))) return false;
            if (this.ModuleIds != input.ModuleIds || (this.ModuleIds != null && !this.ModuleIds.Equals(input.ModuleIds))) return false;
            if (this.PiFilter != input.PiFilter || (this.PiFilter != null && input.PiFilter != null && !this.PiFilter.SequenceEqual(input.PiFilter))) return false;
            if (this.StatusNames != input.StatusNames || (this.StatusNames != null && input.StatusNames != null && !this.StatusNames.SequenceEqual(input.StatusNames))) return false;

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
                if (this.Owner != null) hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.IssueId != null) hashCode = hashCode * 59 + this.IssueId.GetHashCode();
                if (this.PageNo != null) hashCode = hashCode * 59 + this.PageNo.GetHashCode();
                if (this.PageSize != null) hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.KeyWord != null) hashCode = hashCode * 59 + this.KeyWord.GetHashCode();
                if (this.IterationId != null) hashCode = hashCode * 59 + this.IterationId.GetHashCode();
                if (this.SeverityId != null) hashCode = hashCode * 59 + this.SeverityId.GetHashCode();
                if (this.StatusId != null) hashCode = hashCode * 59 + this.StatusId.GetHashCode();
                if (this.ModuleId != null) hashCode = hashCode * 59 + this.ModuleId.GetHashCode();
                if (this.StatusIds != null) hashCode = hashCode * 59 + this.StatusIds.GetHashCode();
                if (this.ModuleIds != null) hashCode = hashCode * 59 + this.ModuleIds.GetHashCode();
                if (this.PiFilter != null) hashCode = hashCode * 59 + this.PiFilter.GetHashCode();
                if (this.StatusNames != null) hashCode = hashCode * 59 + this.StatusNames.GetHashCode();
                return hashCode;
            }
        }
    }
}
