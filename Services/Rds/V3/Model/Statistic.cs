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
    public class Statistic 
    {

        /// <summary>
        /// 用户名称
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        [JsonProperty("database", NullValueHandling = NullValueHandling.Ignore)]
        public string Database { get; set; }

        /// <summary>
        /// 由SQL的语法解析树计算出的内部哈希码。
        /// </summary>
        [JsonProperty("query_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? QueryId { get; set; }

        /// <summary>
        /// 调用次数
        /// </summary>
        [JsonProperty("calls", NullValueHandling = NullValueHandling.Ignore)]
        public long? Calls { get; set; }

        /// <summary>
        /// SQL语句的文本形式。
        /// </summary>
        [JsonProperty("query", NullValueHandling = NullValueHandling.Ignore)]
        public string Query { get; set; }

        /// <summary>
        /// 扫描行数
        /// </summary>
        [JsonProperty("rows", NullValueHandling = NullValueHandling.Ignore)]
        public long? Rows { get; set; }

        /// <summary>
        /// 是否可以执行sql限流
        /// </summary>
        [JsonProperty("can_use", NullValueHandling = NullValueHandling.Ignore)]
        public double? CanUse { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Statistic {\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  database: ").Append(Database).Append("\n");
            sb.Append("  queryId: ").Append(QueryId).Append("\n");
            sb.Append("  calls: ").Append(Calls).Append("\n");
            sb.Append("  query: ").Append(Query).Append("\n");
            sb.Append("  rows: ").Append(Rows).Append("\n");
            sb.Append("  canUse: ").Append(CanUse).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Statistic);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Statistic input)
        {
            if (input == null) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.Database != input.Database || (this.Database != null && !this.Database.Equals(input.Database))) return false;
            if (this.QueryId != input.QueryId || (this.QueryId != null && !this.QueryId.Equals(input.QueryId))) return false;
            if (this.Calls != input.Calls || (this.Calls != null && !this.Calls.Equals(input.Calls))) return false;
            if (this.Query != input.Query || (this.Query != null && !this.Query.Equals(input.Query))) return false;
            if (this.Rows != input.Rows || (this.Rows != null && !this.Rows.Equals(input.Rows))) return false;
            if (this.CanUse != input.CanUse || (this.CanUse != null && !this.CanUse.Equals(input.CanUse))) return false;

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
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.Database != null) hashCode = hashCode * 59 + this.Database.GetHashCode();
                if (this.QueryId != null) hashCode = hashCode * 59 + this.QueryId.GetHashCode();
                if (this.Calls != null) hashCode = hashCode * 59 + this.Calls.GetHashCode();
                if (this.Query != null) hashCode = hashCode * 59 + this.Query.GetHashCode();
                if (this.Rows != null) hashCode = hashCode * 59 + this.Rows.GetHashCode();
                if (this.CanUse != null) hashCode = hashCode * 59 + this.CanUse.GetHashCode();
                return hashCode;
            }
        }
    }
}
