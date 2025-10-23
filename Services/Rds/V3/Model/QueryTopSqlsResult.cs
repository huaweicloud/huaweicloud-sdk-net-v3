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
    public class QueryTopSqlsResult 
    {

        /// <summary>
        /// 对查询计算的二进制哈希值，用于标识具有类似逻辑的查询。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 当前执行的SQL语句。
        /// </summary>
        [JsonProperty("statement", NullValueHandling = NullValueHandling.Ignore)]
        public string Statement { get; set; }

        /// <summary>
        /// SQL全文。
        /// </summary>
        [JsonProperty("query", NullValueHandling = NullValueHandling.Ignore)]
        public string Query { get; set; }

        /// <summary>
        /// 数据库名称。
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// 执行总次数。
        /// </summary>
        [JsonProperty("execution_count", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionCount { get; set; }

        /// <summary>
        /// 执行总次数百分比，范围0.0000-1.0000。
        /// </summary>
        [JsonProperty("execution_count_percent", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionCountPercent { get; set; }

        /// <summary>
        /// 总CPU耗时，单位ms。
        /// </summary>
        [JsonProperty("total_cpu_time", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalCpuTime { get; set; }

        /// <summary>
        /// 总CPU耗时百分比，范围0.0000-1.0000。
        /// </summary>
        [JsonProperty("total_cpu_time_percent", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalCpuTimePercent { get; set; }

        /// <summary>
        /// 平均CPU耗时，单位ms。
        /// </summary>
        [JsonProperty("avg_cpu_time", NullValueHandling = NullValueHandling.Ignore)]
        public string AvgCpuTime { get; set; }

        /// <summary>
        /// 平均CPU耗时百分比，范围0.0000-1.0000。
        /// </summary>
        [JsonProperty("avg_cpu_time_percent", NullValueHandling = NullValueHandling.Ignore)]
        public string AvgCpuTimePercent { get; set; }

        /// <summary>
        /// 总执行耗时。
        /// </summary>
        [JsonProperty("total_duration_time", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalDurationTime { get; set; }

        /// <summary>
        /// 总执行耗时百分比，范围0.0000-1.0000。
        /// </summary>
        [JsonProperty("total_duration_time_percent", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalDurationTimePercent { get; set; }

        /// <summary>
        /// 平均执行耗时。
        /// </summary>
        [JsonProperty("avg_duration_time", NullValueHandling = NullValueHandling.Ignore)]
        public string AvgDurationTime { get; set; }

        /// <summary>
        /// 平均执行耗时百分比，范围0.0000-1.0000。
        /// </summary>
        [JsonProperty("avg_duration_time_percent", NullValueHandling = NullValueHandling.Ignore)]
        public string AvgDurationTimePercent { get; set; }

        /// <summary>
        /// 总返回行。
        /// </summary>
        [JsonProperty("total_rows", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalRows { get; set; }

        /// <summary>
        /// 总返回行百分比，范围0.0000-1.0000。
        /// </summary>
        [JsonProperty("total_rows_percent", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalRowsPercent { get; set; }

        /// <summary>
        /// 平均返回行。
        /// </summary>
        [JsonProperty("avg_rows", NullValueHandling = NullValueHandling.Ignore)]
        public string AvgRows { get; set; }

        /// <summary>
        /// 平均返回行百分比，范围0.0000-1.0000。
        /// </summary>
        [JsonProperty("avg_rows_percent", NullValueHandling = NullValueHandling.Ignore)]
        public string AvgRowsPercent { get; set; }

        /// <summary>
        /// 总逻辑读消耗。
        /// </summary>
        [JsonProperty("total_logical_reads", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalLogicalReads { get; set; }

        /// <summary>
        /// 总逻辑读百分比，范围0.0000-1.0000。
        /// </summary>
        [JsonProperty("total_logical_reads_percent", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalLogicalReadsPercent { get; set; }

        /// <summary>
        /// 平均逻辑读消耗。
        /// </summary>
        [JsonProperty("avg_logical_reads", NullValueHandling = NullValueHandling.Ignore)]
        public string AvgLogicalReads { get; set; }

        /// <summary>
        /// 平均逻辑读百分比，范围0.0000-1.0000。
        /// </summary>
        [JsonProperty("avg_logical_reads_percent", NullValueHandling = NullValueHandling.Ignore)]
        public string AvgLogicalReadsPercent { get; set; }

        /// <summary>
        /// 平均逻辑写消耗。
        /// </summary>
        [JsonProperty("avg_logical_write", NullValueHandling = NullValueHandling.Ignore)]
        public string AvgLogicalWrite { get; set; }

        /// <summary>
        /// 平均逻辑写百分比，范围0.0000-1.0000。
        /// </summary>
        [JsonProperty("avg_logical_write_percent", NullValueHandling = NullValueHandling.Ignore)]
        public string AvgLogicalWritePercent { get; set; }

        /// <summary>
        /// 总逻辑写消耗。
        /// </summary>
        [JsonProperty("total_logical_write", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalLogicalWrite { get; set; }

        /// <summary>
        /// 总逻辑写百分比，范围0.0000-1.0000。
        /// </summary>
        [JsonProperty("total_logical_write_percent", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalLogicalWritePercent { get; set; }

        /// <summary>
        /// 平均物理读消耗。
        /// </summary>
        [JsonProperty("avg_physical_reads", NullValueHandling = NullValueHandling.Ignore)]
        public string AvgPhysicalReads { get; set; }

        /// <summary>
        /// 平均物理读百分比，范围0.0000-1.0000。
        /// </summary>
        [JsonProperty("avg_physical_reads_percent", NullValueHandling = NullValueHandling.Ignore)]
        public string AvgPhysicalReadsPercent { get; set; }

        /// <summary>
        /// 总物理读消耗。
        /// </summary>
        [JsonProperty("total_physical_reads", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalPhysicalReads { get; set; }

        /// <summary>
        /// 总物理读百分比，范围0.0000-1.0000。
        /// </summary>
        [JsonProperty("total_physical_reads_percent", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalPhysicalReadsPercent { get; set; }

        /// <summary>
        /// 上次执行时间。
        /// </summary>
        [JsonProperty("last_execution_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastExecutionTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryTopSqlsResult {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  statement: ").Append(Statement).Append("\n");
            sb.Append("  query: ").Append(Query).Append("\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  executionCount: ").Append(ExecutionCount).Append("\n");
            sb.Append("  executionCountPercent: ").Append(ExecutionCountPercent).Append("\n");
            sb.Append("  totalCpuTime: ").Append(TotalCpuTime).Append("\n");
            sb.Append("  totalCpuTimePercent: ").Append(TotalCpuTimePercent).Append("\n");
            sb.Append("  avgCpuTime: ").Append(AvgCpuTime).Append("\n");
            sb.Append("  avgCpuTimePercent: ").Append(AvgCpuTimePercent).Append("\n");
            sb.Append("  totalDurationTime: ").Append(TotalDurationTime).Append("\n");
            sb.Append("  totalDurationTimePercent: ").Append(TotalDurationTimePercent).Append("\n");
            sb.Append("  avgDurationTime: ").Append(AvgDurationTime).Append("\n");
            sb.Append("  avgDurationTimePercent: ").Append(AvgDurationTimePercent).Append("\n");
            sb.Append("  totalRows: ").Append(TotalRows).Append("\n");
            sb.Append("  totalRowsPercent: ").Append(TotalRowsPercent).Append("\n");
            sb.Append("  avgRows: ").Append(AvgRows).Append("\n");
            sb.Append("  avgRowsPercent: ").Append(AvgRowsPercent).Append("\n");
            sb.Append("  totalLogicalReads: ").Append(TotalLogicalReads).Append("\n");
            sb.Append("  totalLogicalReadsPercent: ").Append(TotalLogicalReadsPercent).Append("\n");
            sb.Append("  avgLogicalReads: ").Append(AvgLogicalReads).Append("\n");
            sb.Append("  avgLogicalReadsPercent: ").Append(AvgLogicalReadsPercent).Append("\n");
            sb.Append("  avgLogicalWrite: ").Append(AvgLogicalWrite).Append("\n");
            sb.Append("  avgLogicalWritePercent: ").Append(AvgLogicalWritePercent).Append("\n");
            sb.Append("  totalLogicalWrite: ").Append(TotalLogicalWrite).Append("\n");
            sb.Append("  totalLogicalWritePercent: ").Append(TotalLogicalWritePercent).Append("\n");
            sb.Append("  avgPhysicalReads: ").Append(AvgPhysicalReads).Append("\n");
            sb.Append("  avgPhysicalReadsPercent: ").Append(AvgPhysicalReadsPercent).Append("\n");
            sb.Append("  totalPhysicalReads: ").Append(TotalPhysicalReads).Append("\n");
            sb.Append("  totalPhysicalReadsPercent: ").Append(TotalPhysicalReadsPercent).Append("\n");
            sb.Append("  lastExecutionTime: ").Append(LastExecutionTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryTopSqlsResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryTopSqlsResult input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Statement != input.Statement || (this.Statement != null && !this.Statement.Equals(input.Statement))) return false;
            if (this.Query != input.Query || (this.Query != null && !this.Query.Equals(input.Query))) return false;
            if (this.DbName != input.DbName || (this.DbName != null && !this.DbName.Equals(input.DbName))) return false;
            if (this.ExecutionCount != input.ExecutionCount || (this.ExecutionCount != null && !this.ExecutionCount.Equals(input.ExecutionCount))) return false;
            if (this.ExecutionCountPercent != input.ExecutionCountPercent || (this.ExecutionCountPercent != null && !this.ExecutionCountPercent.Equals(input.ExecutionCountPercent))) return false;
            if (this.TotalCpuTime != input.TotalCpuTime || (this.TotalCpuTime != null && !this.TotalCpuTime.Equals(input.TotalCpuTime))) return false;
            if (this.TotalCpuTimePercent != input.TotalCpuTimePercent || (this.TotalCpuTimePercent != null && !this.TotalCpuTimePercent.Equals(input.TotalCpuTimePercent))) return false;
            if (this.AvgCpuTime != input.AvgCpuTime || (this.AvgCpuTime != null && !this.AvgCpuTime.Equals(input.AvgCpuTime))) return false;
            if (this.AvgCpuTimePercent != input.AvgCpuTimePercent || (this.AvgCpuTimePercent != null && !this.AvgCpuTimePercent.Equals(input.AvgCpuTimePercent))) return false;
            if (this.TotalDurationTime != input.TotalDurationTime || (this.TotalDurationTime != null && !this.TotalDurationTime.Equals(input.TotalDurationTime))) return false;
            if (this.TotalDurationTimePercent != input.TotalDurationTimePercent || (this.TotalDurationTimePercent != null && !this.TotalDurationTimePercent.Equals(input.TotalDurationTimePercent))) return false;
            if (this.AvgDurationTime != input.AvgDurationTime || (this.AvgDurationTime != null && !this.AvgDurationTime.Equals(input.AvgDurationTime))) return false;
            if (this.AvgDurationTimePercent != input.AvgDurationTimePercent || (this.AvgDurationTimePercent != null && !this.AvgDurationTimePercent.Equals(input.AvgDurationTimePercent))) return false;
            if (this.TotalRows != input.TotalRows || (this.TotalRows != null && !this.TotalRows.Equals(input.TotalRows))) return false;
            if (this.TotalRowsPercent != input.TotalRowsPercent || (this.TotalRowsPercent != null && !this.TotalRowsPercent.Equals(input.TotalRowsPercent))) return false;
            if (this.AvgRows != input.AvgRows || (this.AvgRows != null && !this.AvgRows.Equals(input.AvgRows))) return false;
            if (this.AvgRowsPercent != input.AvgRowsPercent || (this.AvgRowsPercent != null && !this.AvgRowsPercent.Equals(input.AvgRowsPercent))) return false;
            if (this.TotalLogicalReads != input.TotalLogicalReads || (this.TotalLogicalReads != null && !this.TotalLogicalReads.Equals(input.TotalLogicalReads))) return false;
            if (this.TotalLogicalReadsPercent != input.TotalLogicalReadsPercent || (this.TotalLogicalReadsPercent != null && !this.TotalLogicalReadsPercent.Equals(input.TotalLogicalReadsPercent))) return false;
            if (this.AvgLogicalReads != input.AvgLogicalReads || (this.AvgLogicalReads != null && !this.AvgLogicalReads.Equals(input.AvgLogicalReads))) return false;
            if (this.AvgLogicalReadsPercent != input.AvgLogicalReadsPercent || (this.AvgLogicalReadsPercent != null && !this.AvgLogicalReadsPercent.Equals(input.AvgLogicalReadsPercent))) return false;
            if (this.AvgLogicalWrite != input.AvgLogicalWrite || (this.AvgLogicalWrite != null && !this.AvgLogicalWrite.Equals(input.AvgLogicalWrite))) return false;
            if (this.AvgLogicalWritePercent != input.AvgLogicalWritePercent || (this.AvgLogicalWritePercent != null && !this.AvgLogicalWritePercent.Equals(input.AvgLogicalWritePercent))) return false;
            if (this.TotalLogicalWrite != input.TotalLogicalWrite || (this.TotalLogicalWrite != null && !this.TotalLogicalWrite.Equals(input.TotalLogicalWrite))) return false;
            if (this.TotalLogicalWritePercent != input.TotalLogicalWritePercent || (this.TotalLogicalWritePercent != null && !this.TotalLogicalWritePercent.Equals(input.TotalLogicalWritePercent))) return false;
            if (this.AvgPhysicalReads != input.AvgPhysicalReads || (this.AvgPhysicalReads != null && !this.AvgPhysicalReads.Equals(input.AvgPhysicalReads))) return false;
            if (this.AvgPhysicalReadsPercent != input.AvgPhysicalReadsPercent || (this.AvgPhysicalReadsPercent != null && !this.AvgPhysicalReadsPercent.Equals(input.AvgPhysicalReadsPercent))) return false;
            if (this.TotalPhysicalReads != input.TotalPhysicalReads || (this.TotalPhysicalReads != null && !this.TotalPhysicalReads.Equals(input.TotalPhysicalReads))) return false;
            if (this.TotalPhysicalReadsPercent != input.TotalPhysicalReadsPercent || (this.TotalPhysicalReadsPercent != null && !this.TotalPhysicalReadsPercent.Equals(input.TotalPhysicalReadsPercent))) return false;
            if (this.LastExecutionTime != input.LastExecutionTime || (this.LastExecutionTime != null && !this.LastExecutionTime.Equals(input.LastExecutionTime))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Statement != null) hashCode = hashCode * 59 + this.Statement.GetHashCode();
                if (this.Query != null) hashCode = hashCode * 59 + this.Query.GetHashCode();
                if (this.DbName != null) hashCode = hashCode * 59 + this.DbName.GetHashCode();
                if (this.ExecutionCount != null) hashCode = hashCode * 59 + this.ExecutionCount.GetHashCode();
                if (this.ExecutionCountPercent != null) hashCode = hashCode * 59 + this.ExecutionCountPercent.GetHashCode();
                if (this.TotalCpuTime != null) hashCode = hashCode * 59 + this.TotalCpuTime.GetHashCode();
                if (this.TotalCpuTimePercent != null) hashCode = hashCode * 59 + this.TotalCpuTimePercent.GetHashCode();
                if (this.AvgCpuTime != null) hashCode = hashCode * 59 + this.AvgCpuTime.GetHashCode();
                if (this.AvgCpuTimePercent != null) hashCode = hashCode * 59 + this.AvgCpuTimePercent.GetHashCode();
                if (this.TotalDurationTime != null) hashCode = hashCode * 59 + this.TotalDurationTime.GetHashCode();
                if (this.TotalDurationTimePercent != null) hashCode = hashCode * 59 + this.TotalDurationTimePercent.GetHashCode();
                if (this.AvgDurationTime != null) hashCode = hashCode * 59 + this.AvgDurationTime.GetHashCode();
                if (this.AvgDurationTimePercent != null) hashCode = hashCode * 59 + this.AvgDurationTimePercent.GetHashCode();
                if (this.TotalRows != null) hashCode = hashCode * 59 + this.TotalRows.GetHashCode();
                if (this.TotalRowsPercent != null) hashCode = hashCode * 59 + this.TotalRowsPercent.GetHashCode();
                if (this.AvgRows != null) hashCode = hashCode * 59 + this.AvgRows.GetHashCode();
                if (this.AvgRowsPercent != null) hashCode = hashCode * 59 + this.AvgRowsPercent.GetHashCode();
                if (this.TotalLogicalReads != null) hashCode = hashCode * 59 + this.TotalLogicalReads.GetHashCode();
                if (this.TotalLogicalReadsPercent != null) hashCode = hashCode * 59 + this.TotalLogicalReadsPercent.GetHashCode();
                if (this.AvgLogicalReads != null) hashCode = hashCode * 59 + this.AvgLogicalReads.GetHashCode();
                if (this.AvgLogicalReadsPercent != null) hashCode = hashCode * 59 + this.AvgLogicalReadsPercent.GetHashCode();
                if (this.AvgLogicalWrite != null) hashCode = hashCode * 59 + this.AvgLogicalWrite.GetHashCode();
                if (this.AvgLogicalWritePercent != null) hashCode = hashCode * 59 + this.AvgLogicalWritePercent.GetHashCode();
                if (this.TotalLogicalWrite != null) hashCode = hashCode * 59 + this.TotalLogicalWrite.GetHashCode();
                if (this.TotalLogicalWritePercent != null) hashCode = hashCode * 59 + this.TotalLogicalWritePercent.GetHashCode();
                if (this.AvgPhysicalReads != null) hashCode = hashCode * 59 + this.AvgPhysicalReads.GetHashCode();
                if (this.AvgPhysicalReadsPercent != null) hashCode = hashCode * 59 + this.AvgPhysicalReadsPercent.GetHashCode();
                if (this.TotalPhysicalReads != null) hashCode = hashCode * 59 + this.TotalPhysicalReads.GetHashCode();
                if (this.TotalPhysicalReadsPercent != null) hashCode = hashCode * 59 + this.TotalPhysicalReadsPercent.GetHashCode();
                if (this.LastExecutionTime != null) hashCode = hashCode * 59 + this.LastExecutionTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
