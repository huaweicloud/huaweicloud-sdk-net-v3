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
    public class QueryLtsStructLogParamsNew 
    {

        /// <summary>
        /// sql语句字符串。
        /// </summary>
        [JsonProperty("query", NullValueHandling = NullValueHandling.Ignore)]
        public string Query { get; set; }

        /// <summary>
        /// 查询结果格式。当前仅支持：\&quot;k-v\&quot;。
        /// </summary>
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public string Format { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("time_range", NullValueHandling = NullValueHandling.Ignore)]
        public TimeRange TimeRange { get; set; }

        /// <summary>
        /// 返回数据格式，是否为行数据，默认为false。
        /// </summary>
        [JsonProperty("whether_to_rows", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WhetherToRows { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryLtsStructLogParamsNew {\n");
            sb.Append("  query: ").Append(Query).Append("\n");
            sb.Append("  format: ").Append(Format).Append("\n");
            sb.Append("  timeRange: ").Append(TimeRange).Append("\n");
            sb.Append("  whetherToRows: ").Append(WhetherToRows).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryLtsStructLogParamsNew);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryLtsStructLogParamsNew input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Query == input.Query ||
                    (this.Query != null &&
                    this.Query.Equals(input.Query))
                ) && 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
                ) && 
                (
                    this.TimeRange == input.TimeRange ||
                    (this.TimeRange != null &&
                    this.TimeRange.Equals(input.TimeRange))
                ) && 
                (
                    this.WhetherToRows == input.WhetherToRows ||
                    (this.WhetherToRows != null &&
                    this.WhetherToRows.Equals(input.WhetherToRows))
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
                if (this.Query != null)
                    hashCode = hashCode * 59 + this.Query.GetHashCode();
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.TimeRange != null)
                    hashCode = hashCode * 59 + this.TimeRange.GetHashCode();
                if (this.WhetherToRows != null)
                    hashCode = hashCode * 59 + this.WhetherToRows.GetHashCode();
                return hashCode;
            }
        }
    }
}
