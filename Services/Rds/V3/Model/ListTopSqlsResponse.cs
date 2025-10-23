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
    /// Response Object
    /// </summary>
    public class ListTopSqlsResponse : SdkResponse
    {

        /// <summary>
        /// 总数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// TOP SQL 信息列表。
        /// </summary>
        [JsonProperty("list", NullValueHandling = NullValueHandling.Ignore)]
        public List<QueryTopSqlsResult> List { get; set; }

        /// <summary>
        /// 平均CPU开销表TOP SQL列表。
        /// </summary>
        [JsonProperty("avg_cpu_time_top_values", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopSqlsTimeResult> AvgCpuTimeTopValues { get; set; }

        /// <summary>
        /// 平均执行耗时TOP SQL列表。
        /// </summary>
        [JsonProperty("avg_duration_time_top_values", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopSqlsTimeResult> AvgDurationTimeTopValues { get; set; }

        /// <summary>
        /// 平均返回行TOP SQL列表。
        /// </summary>
        [JsonProperty("avg_rows_top_values", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopSqlsRowResult> AvgRowsTopValues { get; set; }

        /// <summary>
        /// 平均逻辑读TOP SQL列表。
        /// </summary>
        [JsonProperty("avg_logical_top_values", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopSqlsLogicalReadResult> AvgLogicalTopValues { get; set; }

        /// <summary>
        /// 总CPU开销表TOP SQL列表。
        /// </summary>
        [JsonProperty("total_cpu_time_top_values", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopSqlsTimeResult> TotalCpuTimeTopValues { get; set; }

        /// <summary>
        /// 总执行耗时TOP SQL列表。
        /// </summary>
        [JsonProperty("total_duration_time_top_values", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopSqlsTimeResult> TotalDurationTimeTopValues { get; set; }

        /// <summary>
        /// 总返回行TOP SQL列表。
        /// </summary>
        [JsonProperty("total_rows_top_values", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopSqlsRowResult> TotalRowsTopValues { get; set; }

        /// <summary>
        /// 总逻辑读TOP SQL列表。
        /// </summary>
        [JsonProperty("total_logical_reads_top_values", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopSqlsLogicalReadResult> TotalLogicalReadsTopValues { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTopSqlsResponse {\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  list: ").Append(List).Append("\n");
            sb.Append("  avgCpuTimeTopValues: ").Append(AvgCpuTimeTopValues).Append("\n");
            sb.Append("  avgDurationTimeTopValues: ").Append(AvgDurationTimeTopValues).Append("\n");
            sb.Append("  avgRowsTopValues: ").Append(AvgRowsTopValues).Append("\n");
            sb.Append("  avgLogicalTopValues: ").Append(AvgLogicalTopValues).Append("\n");
            sb.Append("  totalCpuTimeTopValues: ").Append(TotalCpuTimeTopValues).Append("\n");
            sb.Append("  totalDurationTimeTopValues: ").Append(TotalDurationTimeTopValues).Append("\n");
            sb.Append("  totalRowsTopValues: ").Append(TotalRowsTopValues).Append("\n");
            sb.Append("  totalLogicalReadsTopValues: ").Append(TotalLogicalReadsTopValues).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTopSqlsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTopSqlsResponse input)
        {
            if (input == null) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.List != input.List || (this.List != null && input.List != null && !this.List.SequenceEqual(input.List))) return false;
            if (this.AvgCpuTimeTopValues != input.AvgCpuTimeTopValues || (this.AvgCpuTimeTopValues != null && input.AvgCpuTimeTopValues != null && !this.AvgCpuTimeTopValues.SequenceEqual(input.AvgCpuTimeTopValues))) return false;
            if (this.AvgDurationTimeTopValues != input.AvgDurationTimeTopValues || (this.AvgDurationTimeTopValues != null && input.AvgDurationTimeTopValues != null && !this.AvgDurationTimeTopValues.SequenceEqual(input.AvgDurationTimeTopValues))) return false;
            if (this.AvgRowsTopValues != input.AvgRowsTopValues || (this.AvgRowsTopValues != null && input.AvgRowsTopValues != null && !this.AvgRowsTopValues.SequenceEqual(input.AvgRowsTopValues))) return false;
            if (this.AvgLogicalTopValues != input.AvgLogicalTopValues || (this.AvgLogicalTopValues != null && input.AvgLogicalTopValues != null && !this.AvgLogicalTopValues.SequenceEqual(input.AvgLogicalTopValues))) return false;
            if (this.TotalCpuTimeTopValues != input.TotalCpuTimeTopValues || (this.TotalCpuTimeTopValues != null && input.TotalCpuTimeTopValues != null && !this.TotalCpuTimeTopValues.SequenceEqual(input.TotalCpuTimeTopValues))) return false;
            if (this.TotalDurationTimeTopValues != input.TotalDurationTimeTopValues || (this.TotalDurationTimeTopValues != null && input.TotalDurationTimeTopValues != null && !this.TotalDurationTimeTopValues.SequenceEqual(input.TotalDurationTimeTopValues))) return false;
            if (this.TotalRowsTopValues != input.TotalRowsTopValues || (this.TotalRowsTopValues != null && input.TotalRowsTopValues != null && !this.TotalRowsTopValues.SequenceEqual(input.TotalRowsTopValues))) return false;
            if (this.TotalLogicalReadsTopValues != input.TotalLogicalReadsTopValues || (this.TotalLogicalReadsTopValues != null && input.TotalLogicalReadsTopValues != null && !this.TotalLogicalReadsTopValues.SequenceEqual(input.TotalLogicalReadsTopValues))) return false;

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
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.List != null) hashCode = hashCode * 59 + this.List.GetHashCode();
                if (this.AvgCpuTimeTopValues != null) hashCode = hashCode * 59 + this.AvgCpuTimeTopValues.GetHashCode();
                if (this.AvgDurationTimeTopValues != null) hashCode = hashCode * 59 + this.AvgDurationTimeTopValues.GetHashCode();
                if (this.AvgRowsTopValues != null) hashCode = hashCode * 59 + this.AvgRowsTopValues.GetHashCode();
                if (this.AvgLogicalTopValues != null) hashCode = hashCode * 59 + this.AvgLogicalTopValues.GetHashCode();
                if (this.TotalCpuTimeTopValues != null) hashCode = hashCode * 59 + this.TotalCpuTimeTopValues.GetHashCode();
                if (this.TotalDurationTimeTopValues != null) hashCode = hashCode * 59 + this.TotalDurationTimeTopValues.GetHashCode();
                if (this.TotalRowsTopValues != null) hashCode = hashCode * 59 + this.TotalRowsTopValues.GetHashCode();
                if (this.TotalLogicalReadsTopValues != null) hashCode = hashCode * 59 + this.TotalLogicalReadsTopValues.GetHashCode();
                return hashCode;
            }
        }
    }
}
