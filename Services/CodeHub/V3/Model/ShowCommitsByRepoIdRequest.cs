using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowCommitsByRepoIdRequest 
    {

        /// <summary>
        /// 提交作者
        /// </summary>
        [SDKProperty("author", IsQuery = true)]
        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public string Author { get; set; }

        /// <summary>
        /// 起始提交日期，格式为yyyy-MM-dd
        /// </summary>
        [SDKProperty("begin_date", IsQuery = true)]
        [JsonProperty("begin_date", NullValueHandling = NullValueHandling.Ignore)]
        public string BeginDate { get; set; }

        /// <summary>
        /// 终止提交日期，格式为yyyy-MM-dd
        /// </summary>
        [SDKProperty("end_date", IsQuery = true)]
        [JsonProperty("end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string EndDate { get; set; }

        /// <summary>
        /// 提交信息
        /// </summary>
        [SDKProperty("message", IsQuery = true)]
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// 分页索引
        /// </summary>
        [SDKProperty("page_index", IsQuery = true)]
        [JsonProperty("page_index", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// 每页数据量
        /// </summary>
        [SDKProperty("page_size", IsQuery = true)]
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        [SDKProperty("path", IsQuery = true)]
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// 分支或标签名，支持SHA格式
        /// </summary>
        [SDKProperty("ref_name", IsQuery = true)]
        [JsonProperty("ref_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RefName { get; set; }

        /// <summary>
        /// 仓库主键id
        /// </summary>
        [SDKProperty("repository_id", IsPath = true)]
        [JsonProperty("repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepositoryId { get; set; }

        /// <summary>
        /// 提交的文件变更详情信息（不包含diff）
        /// </summary>
        [SDKProperty("stat_format", IsQuery = true)]
        [JsonProperty("stat_format", NullValueHandling = NullValueHandling.Ignore)]
        public string StatFormat { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowCommitsByRepoIdRequest {\n");
            sb.Append("  author: ").Append(Author).Append("\n");
            sb.Append("  beginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  endDate: ").Append(EndDate).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  pageIndex: ").Append(PageIndex).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  refName: ").Append(RefName).Append("\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  statFormat: ").Append(StatFormat).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowCommitsByRepoIdRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowCommitsByRepoIdRequest input)
        {
            if (input == null) return false;
            if (this.Author != input.Author || (this.Author != null && !this.Author.Equals(input.Author))) return false;
            if (this.BeginDate != input.BeginDate || (this.BeginDate != null && !this.BeginDate.Equals(input.BeginDate))) return false;
            if (this.EndDate != input.EndDate || (this.EndDate != null && !this.EndDate.Equals(input.EndDate))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.PageIndex != input.PageIndex || (this.PageIndex != null && !this.PageIndex.Equals(input.PageIndex))) return false;
            if (this.PageSize != input.PageSize || (this.PageSize != null && !this.PageSize.Equals(input.PageSize))) return false;
            if (this.Path != input.Path || (this.Path != null && !this.Path.Equals(input.Path))) return false;
            if (this.RefName != input.RefName || (this.RefName != null && !this.RefName.Equals(input.RefName))) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.StatFormat != input.StatFormat || (this.StatFormat != null && !this.StatFormat.Equals(input.StatFormat))) return false;

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
                if (this.Author != null) hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.BeginDate != null) hashCode = hashCode * 59 + this.BeginDate.GetHashCode();
                if (this.EndDate != null) hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.PageIndex != null) hashCode = hashCode * 59 + this.PageIndex.GetHashCode();
                if (this.PageSize != null) hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.Path != null) hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.RefName != null) hashCode = hashCode * 59 + this.RefName.GetHashCode();
                if (this.RepositoryId != null) hashCode = hashCode * 59 + this.RepositoryId.GetHashCode();
                if (this.StatFormat != null) hashCode = hashCode * 59 + this.StatFormat.GetHashCode();
                return hashCode;
            }
        }
    }
}
