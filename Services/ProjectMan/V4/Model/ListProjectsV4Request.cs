using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListProjectsV4Request 
    {

        /// <summary>
        /// 偏移量 从0开始
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 条数 最小1条,最大1000
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 模糊查询项目名称或描述,不支持通配符等高级查询
        /// </summary>
        [SDKProperty("search", IsQuery = true)]
        [JsonProperty("search", NullValueHandling = NullValueHandling.Ignore)]
        public string Search { get; set; }

        /// <summary>
        /// 项目类型 scrum|xboard
        /// </summary>
        [SDKProperty("project_type", IsQuery = true)]
        [JsonProperty("project_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectType { get; set; }

        /// <summary>
        /// 排序条件 默认创建时间降序(name|created_on)(asc|desc)
        /// </summary>
        [SDKProperty("sort", IsQuery = true)]
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public string Sort { get; set; }

        /// <summary>
        /// 是否归档 true已归档|false未归档
        /// </summary>
        [SDKProperty("archive", IsQuery = true)]
        [JsonProperty("archive", NullValueHandling = NullValueHandling.Ignore)]
        public string Archive { get; set; }

        /// <summary>
        /// 默认返回当前用户参与的项目列表,domain_projects租户下的所有项目列表,absent返回当前用户未参与的租户项目列表
        /// </summary>
        [SDKProperty("query_type", IsQuery = true)]
        [JsonProperty("query_type", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListProjectsV4Request {\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  search: ").Append(Search).Append("\n");
            sb.Append("  projectType: ").Append(ProjectType).Append("\n");
            sb.Append("  sort: ").Append(Sort).Append("\n");
            sb.Append("  archive: ").Append(Archive).Append("\n");
            sb.Append("  queryType: ").Append(QueryType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListProjectsV4Request);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListProjectsV4Request input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Search == input.Search ||
                    (this.Search != null &&
                    this.Search.Equals(input.Search))
                ) && 
                (
                    this.ProjectType == input.ProjectType ||
                    (this.ProjectType != null &&
                    this.ProjectType.Equals(input.ProjectType))
                ) && 
                (
                    this.Sort == input.Sort ||
                    (this.Sort != null &&
                    this.Sort.Equals(input.Sort))
                ) && 
                (
                    this.Archive == input.Archive ||
                    (this.Archive != null &&
                    this.Archive.Equals(input.Archive))
                ) && 
                (
                    this.QueryType == input.QueryType ||
                    (this.QueryType != null &&
                    this.QueryType.Equals(input.QueryType))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Search != null)
                    hashCode = hashCode * 59 + this.Search.GetHashCode();
                if (this.ProjectType != null)
                    hashCode = hashCode * 59 + this.ProjectType.GetHashCode();
                if (this.Sort != null)
                    hashCode = hashCode * 59 + this.Sort.GetHashCode();
                if (this.Archive != null)
                    hashCode = hashCode * 59 + this.Archive.GetHashCode();
                if (this.QueryType != null)
                    hashCode = hashCode * 59 + this.QueryType.GetHashCode();
                return hashCode;
            }
        }
    }
}
