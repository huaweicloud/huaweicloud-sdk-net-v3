using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 发布表详情。
    /// </summary>
    public class PublicationTableInfoResponse 
    {

        /// <summary>
        /// 表名。
        /// </summary>
        [JsonProperty("table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TableName { get; set; }

        /// <summary>
        /// 命名空间。
        /// </summary>
        [JsonProperty("schema", NullValueHandling = NullValueHandling.Ignore)]
        public string Schema { get; set; }

        /// <summary>
        /// 发布的字段（未传或为空说明选择所有字段）。
        /// </summary>
        [JsonProperty("columns", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Columns { get; set; }

        /// <summary>
        /// 主键。
        /// </summary>
        [JsonProperty("primary_key", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PrimaryKey { get; set; }

        /// <summary>
        /// 筛选语句。
        /// </summary>
        [JsonProperty("filter_statement", NullValueHandling = NullValueHandling.Ignore)]
        public string FilterStatement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public PublicationTableFilterInfoResponse Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("article_properties", NullValueHandling = NullValueHandling.Ignore)]
        public ArticlePropertiesResponse ArticleProperties { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublicationTableInfoResponse {\n");
            sb.Append("  tableName: ").Append(TableName).Append("\n");
            sb.Append("  schema: ").Append(Schema).Append("\n");
            sb.Append("  columns: ").Append(Columns).Append("\n");
            sb.Append("  primaryKey: ").Append(PrimaryKey).Append("\n");
            sb.Append("  filterStatement: ").Append(FilterStatement).Append("\n");
            sb.Append("  filter: ").Append(Filter).Append("\n");
            sb.Append("  articleProperties: ").Append(ArticleProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PublicationTableInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PublicationTableInfoResponse input)
        {
            if (input == null) return false;
            if (this.TableName != input.TableName || (this.TableName != null && !this.TableName.Equals(input.TableName))) return false;
            if (this.Schema != input.Schema || (this.Schema != null && !this.Schema.Equals(input.Schema))) return false;
            if (this.Columns != input.Columns || (this.Columns != null && input.Columns != null && !this.Columns.SequenceEqual(input.Columns))) return false;
            if (this.PrimaryKey != input.PrimaryKey || (this.PrimaryKey != null && input.PrimaryKey != null && !this.PrimaryKey.SequenceEqual(input.PrimaryKey))) return false;
            if (this.FilterStatement != input.FilterStatement || (this.FilterStatement != null && !this.FilterStatement.Equals(input.FilterStatement))) return false;
            if (this.Filter != input.Filter || (this.Filter != null && !this.Filter.Equals(input.Filter))) return false;
            if (this.ArticleProperties != input.ArticleProperties || (this.ArticleProperties != null && !this.ArticleProperties.Equals(input.ArticleProperties))) return false;

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
                if (this.TableName != null) hashCode = hashCode * 59 + this.TableName.GetHashCode();
                if (this.Schema != null) hashCode = hashCode * 59 + this.Schema.GetHashCode();
                if (this.Columns != null) hashCode = hashCode * 59 + this.Columns.GetHashCode();
                if (this.PrimaryKey != null) hashCode = hashCode * 59 + this.PrimaryKey.GetHashCode();
                if (this.FilterStatement != null) hashCode = hashCode * 59 + this.FilterStatement.GetHashCode();
                if (this.Filter != null) hashCode = hashCode * 59 + this.Filter.GetHashCode();
                if (this.ArticleProperties != null) hashCode = hashCode * 59 + this.ArticleProperties.GetHashCode();
                return hashCode;
            }
        }
    }
}
