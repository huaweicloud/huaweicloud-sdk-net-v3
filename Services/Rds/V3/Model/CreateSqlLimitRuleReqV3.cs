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
    public class CreateSqlLimitRuleReqV3 
    {

        /// <summary>
        /// 数据库名称。
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// 由SQL的语法解析树计算出的内部哈希码，默认为0，取值范围（-9223372036854775808~ 9223372036854775807）。
        /// </summary>
        [JsonProperty("query_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? QueryId { get; set; }

        /// <summary>
        /// SQL语句的文本形式。（注：query_id与query_string只可以存在一个）
        /// </summary>
        [JsonProperty("query_string", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryString { get; set; }

        /// <summary>
        /// 同时执行的SQL数量，小于等于0表示不限制，默认为0，取值范围（-1~50000）。
        /// </summary>
        [JsonProperty("max_concurrency", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxConcurrency { get; set; }

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
            sb.Append("class CreateSqlLimitRuleReqV3 {\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  queryId: ").Append(QueryId).Append("\n");
            sb.Append("  queryString: ").Append(QueryString).Append("\n");
            sb.Append("  maxConcurrency: ").Append(MaxConcurrency).Append("\n");
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
            return this.Equals(input as CreateSqlLimitRuleReqV3);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSqlLimitRuleReqV3 input)
        {
            if (input == null) return false;
            if (this.DbName != input.DbName || (this.DbName != null && !this.DbName.Equals(input.DbName))) return false;
            if (this.QueryId != input.QueryId || (this.QueryId != null && !this.QueryId.Equals(input.QueryId))) return false;
            if (this.QueryString != input.QueryString || (this.QueryString != null && !this.QueryString.Equals(input.QueryString))) return false;
            if (this.MaxConcurrency != input.MaxConcurrency || (this.MaxConcurrency != null && !this.MaxConcurrency.Equals(input.MaxConcurrency))) return false;
            if (this.MaxWaiting != input.MaxWaiting || (this.MaxWaiting != null && !this.MaxWaiting.Equals(input.MaxWaiting))) return false;
            if (this.SearchPath != input.SearchPath || (this.SearchPath != null && !this.SearchPath.Equals(input.SearchPath))) return false;

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
                if (this.DbName != null) hashCode = hashCode * 59 + this.DbName.GetHashCode();
                if (this.QueryId != null) hashCode = hashCode * 59 + this.QueryId.GetHashCode();
                if (this.QueryString != null) hashCode = hashCode * 59 + this.QueryString.GetHashCode();
                if (this.MaxConcurrency != null) hashCode = hashCode * 59 + this.MaxConcurrency.GetHashCode();
                if (this.MaxWaiting != null) hashCode = hashCode * 59 + this.MaxWaiting.GetHashCode();
                if (this.SearchPath != null) hashCode = hashCode * 59 + this.SearchPath.GetHashCode();
                return hashCode;
            }
        }
    }
}
