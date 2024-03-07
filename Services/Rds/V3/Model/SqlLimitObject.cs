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
    /// 
    /// </summary>
    public class SqlLimitObject 
    {

        /// <summary>
        /// SQL限流ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 由SQL的语法解析树计算出的内部哈希码，默认为0，取值范围（-9223372036854775808~ 9223372036854775807）。
        /// </summary>
        [JsonProperty("query_id", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryId { get; set; }

        /// <summary>
        /// SQL语句的文本形式。
        /// </summary>
        [JsonProperty("query_string", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryString { get; set; }

        /// <summary>
        /// 同时执行的SQL数量，小于等于0表示不限制，默认为0，取值范围（-1~50000）。
        /// </summary>
        [JsonProperty("max_concurrency", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxConcurrency { get; set; }

        /// <summary>
        /// 是否生效
        /// </summary>
        [JsonProperty("is_effective", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsEffective { get; set; }

        /// <summary>
        /// 最大等待时间，单位为秒。
        /// </summary>
        [JsonProperty("max_waiting", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxWaiting { get; set; }

        /// <summary>
        /// 为不是模式限定的名称设置模式搜索顺序，默认为public。
        /// </summary>
        [JsonProperty("search_path", NullValueHandling = NullValueHandling.Ignore)]
        public string SearchPath { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SqlLimitObject {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  queryId: ").Append(QueryId).Append("\n");
            sb.Append("  queryString: ").Append(QueryString).Append("\n");
            sb.Append("  maxConcurrency: ").Append(MaxConcurrency).Append("\n");
            sb.Append("  isEffective: ").Append(IsEffective).Append("\n");
            sb.Append("  maxWaiting: ").Append(MaxWaiting).Append("\n");
            sb.Append("  searchPath: ").Append(SearchPath).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SqlLimitObject);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SqlLimitObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.QueryId == input.QueryId ||
                    (this.QueryId != null &&
                    this.QueryId.Equals(input.QueryId))
                ) && 
                (
                    this.QueryString == input.QueryString ||
                    (this.QueryString != null &&
                    this.QueryString.Equals(input.QueryString))
                ) && 
                (
                    this.MaxConcurrency == input.MaxConcurrency ||
                    (this.MaxConcurrency != null &&
                    this.MaxConcurrency.Equals(input.MaxConcurrency))
                ) && 
                (
                    this.IsEffective == input.IsEffective ||
                    (this.IsEffective != null &&
                    this.IsEffective.Equals(input.IsEffective))
                ) && 
                (
                    this.MaxWaiting == input.MaxWaiting ||
                    (this.MaxWaiting != null &&
                    this.MaxWaiting.Equals(input.MaxWaiting))
                ) && 
                (
                    this.SearchPath == input.SearchPath ||
                    (this.SearchPath != null &&
                    this.SearchPath.Equals(input.SearchPath))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.QueryId != null)
                    hashCode = hashCode * 59 + this.QueryId.GetHashCode();
                if (this.QueryString != null)
                    hashCode = hashCode * 59 + this.QueryString.GetHashCode();
                if (this.MaxConcurrency != null)
                    hashCode = hashCode * 59 + this.MaxConcurrency.GetHashCode();
                if (this.IsEffective != null)
                    hashCode = hashCode * 59 + this.IsEffective.GetHashCode();
                if (this.MaxWaiting != null)
                    hashCode = hashCode * 59 + this.MaxWaiting.GetHashCode();
                if (this.SearchPath != null)
                    hashCode = hashCode * 59 + this.SearchPath.GetHashCode();
                return hashCode;
            }
        }
    }
}
