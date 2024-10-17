using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListRangeQueryAomPromPostRequest 
    {

        /// <summary>
        /// PromQL表达式(参考https://prometheus.io/docs/prometheus/latest/querying/basics/)。
        /// </summary>
        [SDKProperty("query", IsQuery = true)]
        [JsonProperty("query", NullValueHandling = NullValueHandling.Ignore)]
        public string Query { get; set; }

        /// <summary>
        /// 起始时间戳(Unix时间戳格式，单位：秒）。
        /// </summary>
        [SDKProperty("start", IsQuery = true)]
        [JsonProperty("start", NullValueHandling = NullValueHandling.Ignore)]
        public string Start { get; set; }

        /// <summary>
        /// 结束时间戳(Unix时间戳格式，单位：秒）。
        /// </summary>
        [SDKProperty("end", IsQuery = true)]
        [JsonProperty("end", NullValueHandling = NullValueHandling.Ignore)]
        public string End { get; set; }

        /// <summary>
        /// 查询时间步长，时间区内每step秒执行一次。
        /// </summary>
        [SDKProperty("step", IsQuery = true)]
        [JsonProperty("step", NullValueHandling = NullValueHandling.Ignore)]
        public string Step { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRangeQueryAomPromPostRequest {\n");
            sb.Append("  query: ").Append(Query).Append("\n");
            sb.Append("  start: ").Append(Start).Append("\n");
            sb.Append("  end: ").Append(End).Append("\n");
            sb.Append("  step: ").Append(Step).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRangeQueryAomPromPostRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRangeQueryAomPromPostRequest input)
        {
            if (input == null) return false;
            if (this.Query != input.Query || (this.Query != null && !this.Query.Equals(input.Query))) return false;
            if (this.Start != input.Start || (this.Start != null && !this.Start.Equals(input.Start))) return false;
            if (this.End != input.End || (this.End != null && !this.End.Equals(input.End))) return false;
            if (this.Step != input.Step || (this.Step != null && !this.Step.Equals(input.Step))) return false;

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
                if (this.Query != null) hashCode = hashCode * 59 + this.Query.GetHashCode();
                if (this.Start != null) hashCode = hashCode * 59 + this.Start.GetHashCode();
                if (this.End != null) hashCode = hashCode * 59 + this.End.GetHashCode();
                if (this.Step != null) hashCode = hashCode * 59 + this.Step.GetHashCode();
                return hashCode;
            }
        }
    }
}
