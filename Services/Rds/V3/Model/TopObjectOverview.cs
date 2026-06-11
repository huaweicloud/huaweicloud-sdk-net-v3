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
    /// top对象总览
    /// </summary>
    public class TopObjectOverview 
    {

        /// <summary>
        /// 平均cpu耗时(单位为毫秒)
        /// </summary>
        [JsonProperty("avg_cpu_time", NullValueHandling = NullValueHandling.Ignore)]
        public double? AvgCpuTime { get; set; }

        /// <summary>
        /// 平均cpu耗时百分比
        /// </summary>
        [JsonProperty("avg_cpu_time_percentage", NullValueHandling = NullValueHandling.Ignore)]
        public double? AvgCpuTimePercentage { get; set; }

        /// <summary>
        /// 平均执行耗时(单位为毫秒)
        /// </summary>
        [JsonProperty("avg_execution_time", NullValueHandling = NullValueHandling.Ignore)]
        public double? AvgExecutionTime { get; set; }

        /// <summary>
        /// 平均执行耗时百分比
        /// </summary>
        [JsonProperty("avg_execution_time_percentage", NullValueHandling = NullValueHandling.Ignore)]
        public double? AvgExecutionTimePercentage { get; set; }

        /// <summary>
        /// 平均逻辑io
        /// </summary>
        [JsonProperty("avg_logical_io", NullValueHandling = NullValueHandling.Ignore)]
        public double? AvgLogicalIo { get; set; }

        /// <summary>
        /// 平均逻辑io百分比
        /// </summary>
        [JsonProperty("avg_logical_io_percentage", NullValueHandling = NullValueHandling.Ignore)]
        public double? AvgLogicalIoPercentage { get; set; }

        /// <summary>
        /// 平均逻辑读
        /// </summary>
        [JsonProperty("avg_logical_reads", NullValueHandling = NullValueHandling.Ignore)]
        public double? AvgLogicalReads { get; set; }

        /// <summary>
        /// 平均逻辑读百分比
        /// </summary>
        [JsonProperty("avg_logical_reads_percentage", NullValueHandling = NullValueHandling.Ignore)]
        public double? AvgLogicalReadsPercentage { get; set; }

        /// <summary>
        /// 平均逻辑写
        /// </summary>
        [JsonProperty("avg_logical_writes", NullValueHandling = NullValueHandling.Ignore)]
        public double? AvgLogicalWrites { get; set; }

        /// <summary>
        /// 平均逻辑写百分比
        /// </summary>
        [JsonProperty("avg_logical_writes_percentage", NullValueHandling = NullValueHandling.Ignore)]
        public double? AvgLogicalWritesPercentage { get; set; }

        /// <summary>
        /// 平均物理读
        /// </summary>
        [JsonProperty("avg_physical_reads", NullValueHandling = NullValueHandling.Ignore)]
        public double? AvgPhysicalReads { get; set; }

        /// <summary>
        /// 平均物理读百分比
        /// </summary>
        [JsonProperty("avg_physical_reads_percentage", NullValueHandling = NullValueHandling.Ignore)]
        public double? AvgPhysicalReadsPercentage { get; set; }

        /// <summary>
        /// 平均返回行
        /// </summary>
        [JsonProperty("avg_rows", NullValueHandling = NullValueHandling.Ignore)]
        public double? AvgRows { get; set; }

        /// <summary>
        /// 平均返回行百分比
        /// </summary>
        [JsonProperty("avg_rows_percentage", NullValueHandling = NullValueHandling.Ignore)]
        public double? AvgRowsPercentage { get; set; }

        /// <summary>
        /// 数据库名
        /// </summary>
        [JsonProperty("database_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// 对象id
        /// </summary>
        [JsonProperty("object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }

        /// <summary>
        /// 对象名称
        /// </summary>
        [JsonProperty("object_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectName { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [JsonProperty("row_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RowId { get; set; }

        /// <summary>
        /// 对象类型
        /// </summary>
        [JsonProperty("object_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectType { get; set; }

        /// <summary>
        /// 模式
        /// </summary>
        [JsonProperty("schema_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemaName { get; set; }

        /// <summary>
        /// 总cpu耗时(单位为毫秒)
        /// </summary>
        [JsonProperty("total_cpu_time", NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalCpuTime { get; set; }

        /// <summary>
        /// 总cpu耗时百分比
        /// </summary>
        [JsonProperty("total_cpu_time_percentage", NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalCpuTimePercentage { get; set; }

        /// <summary>
        /// 总执行耗时(单位为毫秒)
        /// </summary>
        [JsonProperty("total_execution_time", NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalExecutionTime { get; set; }

        /// <summary>
        /// 总执行耗时百分比
        /// </summary>
        [JsonProperty("total_execution_time_percentage", NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalExecutionTimePercentage { get; set; }

        /// <summary>
        /// 总执行次数
        /// </summary>
        [JsonProperty("total_execution_count", NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalExecutionCount { get; set; }

        /// <summary>
        /// 总逻辑io
        /// </summary>
        [JsonProperty("total_logical_io", NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalLogicalIo { get; set; }

        /// <summary>
        /// 总逻辑io百分比
        /// </summary>
        [JsonProperty("total_logical_io_percentage", NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalLogicalIoPercentage { get; set; }

        /// <summary>
        /// 总逻辑读
        /// </summary>
        [JsonProperty("total_logical_reads", NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalLogicalReads { get; set; }

        /// <summary>
        /// 总逻辑读百分比
        /// </summary>
        [JsonProperty("total_logical_reads_percentage", NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalLogicalReadsPercentage { get; set; }

        /// <summary>
        /// 总逻辑写
        /// </summary>
        [JsonProperty("total_logical_writes", NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalLogicalWrites { get; set; }

        /// <summary>
        /// 总逻辑写百分比
        /// </summary>
        [JsonProperty("total_logical_writes_percentage", NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalLogicalWritesPercentage { get; set; }

        /// <summary>
        /// 总物理读
        /// </summary>
        [JsonProperty("total_physical_reads", NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalPhysicalReads { get; set; }

        /// <summary>
        /// 总物理读百分比
        /// </summary>
        [JsonProperty("total_physical_reads_percentage", NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalPhysicalReadsPercentage { get; set; }

        /// <summary>
        /// 总返回行
        /// </summary>
        [JsonProperty("total_rows", NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalRows { get; set; }

        /// <summary>
        /// 总返回行百分比
        /// </summary>
        [JsonProperty("total_rows_percentage", NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalRowsPercentage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TopObjectOverview {\n");
            sb.Append("  avgCpuTime: ").Append(AvgCpuTime).Append("\n");
            sb.Append("  avgCpuTimePercentage: ").Append(AvgCpuTimePercentage).Append("\n");
            sb.Append("  avgExecutionTime: ").Append(AvgExecutionTime).Append("\n");
            sb.Append("  avgExecutionTimePercentage: ").Append(AvgExecutionTimePercentage).Append("\n");
            sb.Append("  avgLogicalIo: ").Append(AvgLogicalIo).Append("\n");
            sb.Append("  avgLogicalIoPercentage: ").Append(AvgLogicalIoPercentage).Append("\n");
            sb.Append("  avgLogicalReads: ").Append(AvgLogicalReads).Append("\n");
            sb.Append("  avgLogicalReadsPercentage: ").Append(AvgLogicalReadsPercentage).Append("\n");
            sb.Append("  avgLogicalWrites: ").Append(AvgLogicalWrites).Append("\n");
            sb.Append("  avgLogicalWritesPercentage: ").Append(AvgLogicalWritesPercentage).Append("\n");
            sb.Append("  avgPhysicalReads: ").Append(AvgPhysicalReads).Append("\n");
            sb.Append("  avgPhysicalReadsPercentage: ").Append(AvgPhysicalReadsPercentage).Append("\n");
            sb.Append("  avgRows: ").Append(AvgRows).Append("\n");
            sb.Append("  avgRowsPercentage: ").Append(AvgRowsPercentage).Append("\n");
            sb.Append("  databaseName: ").Append(DatabaseName).Append("\n");
            sb.Append("  objectId: ").Append(ObjectId).Append("\n");
            sb.Append("  objectName: ").Append(ObjectName).Append("\n");
            sb.Append("  rowId: ").Append(RowId).Append("\n");
            sb.Append("  objectType: ").Append(ObjectType).Append("\n");
            sb.Append("  schemaName: ").Append(SchemaName).Append("\n");
            sb.Append("  totalCpuTime: ").Append(TotalCpuTime).Append("\n");
            sb.Append("  totalCpuTimePercentage: ").Append(TotalCpuTimePercentage).Append("\n");
            sb.Append("  totalExecutionTime: ").Append(TotalExecutionTime).Append("\n");
            sb.Append("  totalExecutionTimePercentage: ").Append(TotalExecutionTimePercentage).Append("\n");
            sb.Append("  totalExecutionCount: ").Append(TotalExecutionCount).Append("\n");
            sb.Append("  totalLogicalIo: ").Append(TotalLogicalIo).Append("\n");
            sb.Append("  totalLogicalIoPercentage: ").Append(TotalLogicalIoPercentage).Append("\n");
            sb.Append("  totalLogicalReads: ").Append(TotalLogicalReads).Append("\n");
            sb.Append("  totalLogicalReadsPercentage: ").Append(TotalLogicalReadsPercentage).Append("\n");
            sb.Append("  totalLogicalWrites: ").Append(TotalLogicalWrites).Append("\n");
            sb.Append("  totalLogicalWritesPercentage: ").Append(TotalLogicalWritesPercentage).Append("\n");
            sb.Append("  totalPhysicalReads: ").Append(TotalPhysicalReads).Append("\n");
            sb.Append("  totalPhysicalReadsPercentage: ").Append(TotalPhysicalReadsPercentage).Append("\n");
            sb.Append("  totalRows: ").Append(TotalRows).Append("\n");
            sb.Append("  totalRowsPercentage: ").Append(TotalRowsPercentage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TopObjectOverview);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TopObjectOverview input)
        {
            if (input == null) return false;
            if (this.AvgCpuTime != input.AvgCpuTime || (this.AvgCpuTime != null && !this.AvgCpuTime.Equals(input.AvgCpuTime))) return false;
            if (this.AvgCpuTimePercentage != input.AvgCpuTimePercentage || (this.AvgCpuTimePercentage != null && !this.AvgCpuTimePercentage.Equals(input.AvgCpuTimePercentage))) return false;
            if (this.AvgExecutionTime != input.AvgExecutionTime || (this.AvgExecutionTime != null && !this.AvgExecutionTime.Equals(input.AvgExecutionTime))) return false;
            if (this.AvgExecutionTimePercentage != input.AvgExecutionTimePercentage || (this.AvgExecutionTimePercentage != null && !this.AvgExecutionTimePercentage.Equals(input.AvgExecutionTimePercentage))) return false;
            if (this.AvgLogicalIo != input.AvgLogicalIo || (this.AvgLogicalIo != null && !this.AvgLogicalIo.Equals(input.AvgLogicalIo))) return false;
            if (this.AvgLogicalIoPercentage != input.AvgLogicalIoPercentage || (this.AvgLogicalIoPercentage != null && !this.AvgLogicalIoPercentage.Equals(input.AvgLogicalIoPercentage))) return false;
            if (this.AvgLogicalReads != input.AvgLogicalReads || (this.AvgLogicalReads != null && !this.AvgLogicalReads.Equals(input.AvgLogicalReads))) return false;
            if (this.AvgLogicalReadsPercentage != input.AvgLogicalReadsPercentage || (this.AvgLogicalReadsPercentage != null && !this.AvgLogicalReadsPercentage.Equals(input.AvgLogicalReadsPercentage))) return false;
            if (this.AvgLogicalWrites != input.AvgLogicalWrites || (this.AvgLogicalWrites != null && !this.AvgLogicalWrites.Equals(input.AvgLogicalWrites))) return false;
            if (this.AvgLogicalWritesPercentage != input.AvgLogicalWritesPercentage || (this.AvgLogicalWritesPercentage != null && !this.AvgLogicalWritesPercentage.Equals(input.AvgLogicalWritesPercentage))) return false;
            if (this.AvgPhysicalReads != input.AvgPhysicalReads || (this.AvgPhysicalReads != null && !this.AvgPhysicalReads.Equals(input.AvgPhysicalReads))) return false;
            if (this.AvgPhysicalReadsPercentage != input.AvgPhysicalReadsPercentage || (this.AvgPhysicalReadsPercentage != null && !this.AvgPhysicalReadsPercentage.Equals(input.AvgPhysicalReadsPercentage))) return false;
            if (this.AvgRows != input.AvgRows || (this.AvgRows != null && !this.AvgRows.Equals(input.AvgRows))) return false;
            if (this.AvgRowsPercentage != input.AvgRowsPercentage || (this.AvgRowsPercentage != null && !this.AvgRowsPercentage.Equals(input.AvgRowsPercentage))) return false;
            if (this.DatabaseName != input.DatabaseName || (this.DatabaseName != null && !this.DatabaseName.Equals(input.DatabaseName))) return false;
            if (this.ObjectId != input.ObjectId || (this.ObjectId != null && !this.ObjectId.Equals(input.ObjectId))) return false;
            if (this.ObjectName != input.ObjectName || (this.ObjectName != null && !this.ObjectName.Equals(input.ObjectName))) return false;
            if (this.RowId != input.RowId || (this.RowId != null && !this.RowId.Equals(input.RowId))) return false;
            if (this.ObjectType != input.ObjectType || (this.ObjectType != null && !this.ObjectType.Equals(input.ObjectType))) return false;
            if (this.SchemaName != input.SchemaName || (this.SchemaName != null && !this.SchemaName.Equals(input.SchemaName))) return false;
            if (this.TotalCpuTime != input.TotalCpuTime || (this.TotalCpuTime != null && !this.TotalCpuTime.Equals(input.TotalCpuTime))) return false;
            if (this.TotalCpuTimePercentage != input.TotalCpuTimePercentage || (this.TotalCpuTimePercentage != null && !this.TotalCpuTimePercentage.Equals(input.TotalCpuTimePercentage))) return false;
            if (this.TotalExecutionTime != input.TotalExecutionTime || (this.TotalExecutionTime != null && !this.TotalExecutionTime.Equals(input.TotalExecutionTime))) return false;
            if (this.TotalExecutionTimePercentage != input.TotalExecutionTimePercentage || (this.TotalExecutionTimePercentage != null && !this.TotalExecutionTimePercentage.Equals(input.TotalExecutionTimePercentage))) return false;
            if (this.TotalExecutionCount != input.TotalExecutionCount || (this.TotalExecutionCount != null && !this.TotalExecutionCount.Equals(input.TotalExecutionCount))) return false;
            if (this.TotalLogicalIo != input.TotalLogicalIo || (this.TotalLogicalIo != null && !this.TotalLogicalIo.Equals(input.TotalLogicalIo))) return false;
            if (this.TotalLogicalIoPercentage != input.TotalLogicalIoPercentage || (this.TotalLogicalIoPercentage != null && !this.TotalLogicalIoPercentage.Equals(input.TotalLogicalIoPercentage))) return false;
            if (this.TotalLogicalReads != input.TotalLogicalReads || (this.TotalLogicalReads != null && !this.TotalLogicalReads.Equals(input.TotalLogicalReads))) return false;
            if (this.TotalLogicalReadsPercentage != input.TotalLogicalReadsPercentage || (this.TotalLogicalReadsPercentage != null && !this.TotalLogicalReadsPercentage.Equals(input.TotalLogicalReadsPercentage))) return false;
            if (this.TotalLogicalWrites != input.TotalLogicalWrites || (this.TotalLogicalWrites != null && !this.TotalLogicalWrites.Equals(input.TotalLogicalWrites))) return false;
            if (this.TotalLogicalWritesPercentage != input.TotalLogicalWritesPercentage || (this.TotalLogicalWritesPercentage != null && !this.TotalLogicalWritesPercentage.Equals(input.TotalLogicalWritesPercentage))) return false;
            if (this.TotalPhysicalReads != input.TotalPhysicalReads || (this.TotalPhysicalReads != null && !this.TotalPhysicalReads.Equals(input.TotalPhysicalReads))) return false;
            if (this.TotalPhysicalReadsPercentage != input.TotalPhysicalReadsPercentage || (this.TotalPhysicalReadsPercentage != null && !this.TotalPhysicalReadsPercentage.Equals(input.TotalPhysicalReadsPercentage))) return false;
            if (this.TotalRows != input.TotalRows || (this.TotalRows != null && !this.TotalRows.Equals(input.TotalRows))) return false;
            if (this.TotalRowsPercentage != input.TotalRowsPercentage || (this.TotalRowsPercentage != null && !this.TotalRowsPercentage.Equals(input.TotalRowsPercentage))) return false;

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
                if (this.AvgCpuTime != null) hashCode = hashCode * 59 + this.AvgCpuTime.GetHashCode();
                if (this.AvgCpuTimePercentage != null) hashCode = hashCode * 59 + this.AvgCpuTimePercentage.GetHashCode();
                if (this.AvgExecutionTime != null) hashCode = hashCode * 59 + this.AvgExecutionTime.GetHashCode();
                if (this.AvgExecutionTimePercentage != null) hashCode = hashCode * 59 + this.AvgExecutionTimePercentage.GetHashCode();
                if (this.AvgLogicalIo != null) hashCode = hashCode * 59 + this.AvgLogicalIo.GetHashCode();
                if (this.AvgLogicalIoPercentage != null) hashCode = hashCode * 59 + this.AvgLogicalIoPercentage.GetHashCode();
                if (this.AvgLogicalReads != null) hashCode = hashCode * 59 + this.AvgLogicalReads.GetHashCode();
                if (this.AvgLogicalReadsPercentage != null) hashCode = hashCode * 59 + this.AvgLogicalReadsPercentage.GetHashCode();
                if (this.AvgLogicalWrites != null) hashCode = hashCode * 59 + this.AvgLogicalWrites.GetHashCode();
                if (this.AvgLogicalWritesPercentage != null) hashCode = hashCode * 59 + this.AvgLogicalWritesPercentage.GetHashCode();
                if (this.AvgPhysicalReads != null) hashCode = hashCode * 59 + this.AvgPhysicalReads.GetHashCode();
                if (this.AvgPhysicalReadsPercentage != null) hashCode = hashCode * 59 + this.AvgPhysicalReadsPercentage.GetHashCode();
                if (this.AvgRows != null) hashCode = hashCode * 59 + this.AvgRows.GetHashCode();
                if (this.AvgRowsPercentage != null) hashCode = hashCode * 59 + this.AvgRowsPercentage.GetHashCode();
                if (this.DatabaseName != null) hashCode = hashCode * 59 + this.DatabaseName.GetHashCode();
                if (this.ObjectId != null) hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.ObjectName != null) hashCode = hashCode * 59 + this.ObjectName.GetHashCode();
                if (this.RowId != null) hashCode = hashCode * 59 + this.RowId.GetHashCode();
                if (this.ObjectType != null) hashCode = hashCode * 59 + this.ObjectType.GetHashCode();
                if (this.SchemaName != null) hashCode = hashCode * 59 + this.SchemaName.GetHashCode();
                if (this.TotalCpuTime != null) hashCode = hashCode * 59 + this.TotalCpuTime.GetHashCode();
                if (this.TotalCpuTimePercentage != null) hashCode = hashCode * 59 + this.TotalCpuTimePercentage.GetHashCode();
                if (this.TotalExecutionTime != null) hashCode = hashCode * 59 + this.TotalExecutionTime.GetHashCode();
                if (this.TotalExecutionTimePercentage != null) hashCode = hashCode * 59 + this.TotalExecutionTimePercentage.GetHashCode();
                if (this.TotalExecutionCount != null) hashCode = hashCode * 59 + this.TotalExecutionCount.GetHashCode();
                if (this.TotalLogicalIo != null) hashCode = hashCode * 59 + this.TotalLogicalIo.GetHashCode();
                if (this.TotalLogicalIoPercentage != null) hashCode = hashCode * 59 + this.TotalLogicalIoPercentage.GetHashCode();
                if (this.TotalLogicalReads != null) hashCode = hashCode * 59 + this.TotalLogicalReads.GetHashCode();
                if (this.TotalLogicalReadsPercentage != null) hashCode = hashCode * 59 + this.TotalLogicalReadsPercentage.GetHashCode();
                if (this.TotalLogicalWrites != null) hashCode = hashCode * 59 + this.TotalLogicalWrites.GetHashCode();
                if (this.TotalLogicalWritesPercentage != null) hashCode = hashCode * 59 + this.TotalLogicalWritesPercentage.GetHashCode();
                if (this.TotalPhysicalReads != null) hashCode = hashCode * 59 + this.TotalPhysicalReads.GetHashCode();
                if (this.TotalPhysicalReadsPercentage != null) hashCode = hashCode * 59 + this.TotalPhysicalReadsPercentage.GetHashCode();
                if (this.TotalRows != null) hashCode = hashCode * 59 + this.TotalRows.GetHashCode();
                if (this.TotalRowsPercentage != null) hashCode = hashCode * 59 + this.TotalRowsPercentage.GetHashCode();
                return hashCode;
            }
        }
    }
}
