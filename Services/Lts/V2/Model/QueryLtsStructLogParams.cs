using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 此参数在请求实体中，采用json字符串格式
    /// </summary>
    public class QueryLtsStructLogParams 
    {

        /// <summary>
        /// 搜索起始时间（UTC时间，毫秒级）。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 搜索结束时间（UTC时间，毫秒级）。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 支持SQL语句搜索， 目前支持\&quot;GROUP BY\&quot;, \&quot;LIKE\&quot;和\&quot;WHERE\&quot;。
        /// </summary>
        [JsonProperty("sql_expression", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlExpression { get; set; }

        /// <summary>
        /// 返回内容中是否包含原始日志， 默认为false。
        /// </summary>
        [JsonProperty("original_content", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OriginalContent { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryLtsStructLogParams {\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  sqlExpression: ").Append(SqlExpression).Append("\n");
            sb.Append("  originalContent: ").Append(OriginalContent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryLtsStructLogParams);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryLtsStructLogParams input)
        {
            if (input == null) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.SqlExpression != input.SqlExpression || (this.SqlExpression != null && !this.SqlExpression.Equals(input.SqlExpression))) return false;
            if (this.OriginalContent != input.OriginalContent || (this.OriginalContent != null && !this.OriginalContent.Equals(input.OriginalContent))) return false;

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
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.SqlExpression != null) hashCode = hashCode * 59 + this.SqlExpression.GetHashCode();
                if (this.OriginalContent != null) hashCode = hashCode * 59 + this.OriginalContent.GetHashCode();
                return hashCode;
            }
        }
    }
}
