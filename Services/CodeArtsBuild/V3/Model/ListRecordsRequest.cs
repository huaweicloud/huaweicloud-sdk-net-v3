using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListRecordsRequest 
    {

        /// <summary>
        /// 构建工程项目ID，36位数字、小写字母组合。
        /// </summary>
        [SDKProperty("build_project_id", IsPath = true)]
        [JsonProperty("build_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildProjectId { get; set; }

        /// <summary>
        /// 分页页码，表示从此页开始查询，大于等于0
        /// </summary>
        [SDKProperty("page", IsQuery = true)]
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public int? Page { get; set; }

        /// <summary>
        /// 每页显示的条目数量，小于等于100
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 需要搜索的触发类型列表
        /// </summary>
        [SDKProperty("triggers", IsQuery = true)]
        [JsonProperty("triggers", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Triggers { get; set; }

        /// <summary>
        /// 需要搜索的分支列表
        /// </summary>
        [SDKProperty("branches", IsQuery = true)]
        [JsonProperty("branches", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Branches { get; set; }

        /// <summary>
        /// 需要搜索的标签列表
        /// </summary>
        [SDKProperty("tags", IsQuery = true)]
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 查询起止时间,格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [SDKProperty("from_date", IsQuery = true)]
        [JsonProperty("from_date", NullValueHandling = NullValueHandling.Ignore)]
        public string FromDate { get; set; }

        /// <summary>
        /// 查询结束时间,格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [SDKProperty("to_date", IsQuery = true)]
        [JsonProperty("to_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ToDate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRecordsRequest {\n");
            sb.Append("  buildProjectId: ").Append(BuildProjectId).Append("\n");
            sb.Append("  page: ").Append(Page).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  triggers: ").Append(Triggers).Append("\n");
            sb.Append("  branches: ").Append(Branches).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  fromDate: ").Append(FromDate).Append("\n");
            sb.Append("  toDate: ").Append(ToDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRecordsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRecordsRequest input)
        {
            if (input == null) return false;
            if (this.BuildProjectId != input.BuildProjectId || (this.BuildProjectId != null && !this.BuildProjectId.Equals(input.BuildProjectId))) return false;
            if (this.Page != input.Page || (this.Page != null && !this.Page.Equals(input.Page))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Triggers != input.Triggers || (this.Triggers != null && input.Triggers != null && !this.Triggers.SequenceEqual(input.Triggers))) return false;
            if (this.Branches != input.Branches || (this.Branches != null && input.Branches != null && !this.Branches.SequenceEqual(input.Branches))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.FromDate != input.FromDate || (this.FromDate != null && !this.FromDate.Equals(input.FromDate))) return false;
            if (this.ToDate != input.ToDate || (this.ToDate != null && !this.ToDate.Equals(input.ToDate))) return false;

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
                if (this.BuildProjectId != null) hashCode = hashCode * 59 + this.BuildProjectId.GetHashCode();
                if (this.Page != null) hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Triggers != null) hashCode = hashCode * 59 + this.Triggers.GetHashCode();
                if (this.Branches != null) hashCode = hashCode * 59 + this.Branches.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.FromDate != null) hashCode = hashCode * 59 + this.FromDate.GetHashCode();
                if (this.ToDate != null) hashCode = hashCode * 59 + this.ToDate.GetHashCode();
                return hashCode;
            }
        }
    }
}
