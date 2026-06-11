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
    /// top对象详情
    /// </summary>
    public class TopObject 
    {

        /// <summary>
        /// id
        /// </summary>
        [JsonProperty("row_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RowId { get; set; }

        /// <summary>
        /// 数据库名
        /// </summary>
        [JsonProperty("database_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// 模式
        /// </summary>
        [JsonProperty("schema_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemaName { get; set; }

        /// <summary>
        /// 对象名
        /// </summary>
        [JsonProperty("object_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectName { get; set; }

        /// <summary>
        /// 对象id
        /// </summary>
        [JsonProperty("object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }

        /// <summary>
        /// 对象类型
        /// </summary>
        [JsonProperty("object_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectType { get; set; }

        /// <summary>
        /// sql文本
        /// </summary>
        [JsonProperty("sql_statement", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlStatement { get; set; }

        /// <summary>
        /// 执行次数
        /// </summary>
        [JsonProperty("execution_count", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionCount { get; set; }

        /// <summary>
        /// 获取执行计划次数
        /// </summary>
        [JsonProperty("plan_generation_num", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanGenerationNum { get; set; }

        /// <summary>
        /// 最近执行时间
        /// </summary>
        [JsonProperty("last_execution_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastExecutionTime { get; set; }

        /// <summary>
        /// 平均cpu耗时(单位为毫秒)
        /// </summary>
        [JsonProperty("avg_worker_time", NullValueHandling = NullValueHandling.Ignore)]
        public string AvgWorkerTime { get; set; }

        /// <summary>
        /// 总cpu耗时(单位为毫秒)
        /// </summary>
        [JsonProperty("total_worker_time", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalWorkerTime { get; set; }

        /// <summary>
        /// 最近cpu耗时(单位为毫秒)
        /// </summary>
        [JsonProperty("last_worker_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastWorkerTime { get; set; }

        /// <summary>
        /// 最小cpu耗时(单位为毫秒)
        /// </summary>
        [JsonProperty("min_worker_time", NullValueHandling = NullValueHandling.Ignore)]
        public string MinWorkerTime { get; set; }

        /// <summary>
        /// 最大cpu耗时(单位为毫秒)
        /// </summary>
        [JsonProperty("max_worker_time", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxWorkerTime { get; set; }

        /// <summary>
        /// 平均逻辑读
        /// </summary>
        [JsonProperty("avg_logical_reads", NullValueHandling = NullValueHandling.Ignore)]
        public string AvgLogicalReads { get; set; }

        /// <summary>
        /// 总共逻辑读
        /// </summary>
        [JsonProperty("total_logical_reads", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalLogicalReads { get; set; }

        /// <summary>
        /// 最近逻辑读
        /// </summary>
        [JsonProperty("last_logical_reads", NullValueHandling = NullValueHandling.Ignore)]
        public string LastLogicalReads { get; set; }

        /// <summary>
        /// 最小逻辑读
        /// </summary>
        [JsonProperty("min_logical_reads", NullValueHandling = NullValueHandling.Ignore)]
        public string MinLogicalReads { get; set; }

        /// <summary>
        /// 最大逻辑读
        /// </summary>
        [JsonProperty("max_logical_reads", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxLogicalReads { get; set; }

        /// <summary>
        /// 平均逻辑写
        /// </summary>
        [JsonProperty("avg_logical_writes", NullValueHandling = NullValueHandling.Ignore)]
        public string AvgLogicalWrites { get; set; }

        /// <summary>
        /// 总共逻辑写
        /// </summary>
        [JsonProperty("total_logical_writes", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalLogicalWrites { get; set; }

        /// <summary>
        /// 最近逻辑写
        /// </summary>
        [JsonProperty("last_logical_writes", NullValueHandling = NullValueHandling.Ignore)]
        public string LastLogicalWrites { get; set; }

        /// <summary>
        /// 最小逻辑写
        /// </summary>
        [JsonProperty("min_logical_writes", NullValueHandling = NullValueHandling.Ignore)]
        public string MinLogicalWrites { get; set; }

        /// <summary>
        /// 最大逻辑写
        /// </summary>
        [JsonProperty("max_logical_writes", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxLogicalWrites { get; set; }

        /// <summary>
        /// 平均逻辑io
        /// </summary>
        [JsonProperty("avg_logical_io", NullValueHandling = NullValueHandling.Ignore)]
        public string AvgLogicalIo { get; set; }

        /// <summary>
        /// 总共逻辑io
        /// </summary>
        [JsonProperty("total_logical_io", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalLogicalIo { get; set; }

        /// <summary>
        /// 最近逻辑io
        /// </summary>
        [JsonProperty("last_logical_io", NullValueHandling = NullValueHandling.Ignore)]
        public string LastLogicalIo { get; set; }

        /// <summary>
        /// 最小逻辑io
        /// </summary>
        [JsonProperty("min_logical_io", NullValueHandling = NullValueHandling.Ignore)]
        public string MinLogicalIo { get; set; }

        /// <summary>
        /// 最大逻辑io
        /// </summary>
        [JsonProperty("max_logical_io", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxLogicalIo { get; set; }

        /// <summary>
        /// 平均物理读
        /// </summary>
        [JsonProperty("avg_physical_reads", NullValueHandling = NullValueHandling.Ignore)]
        public string AvgPhysicalReads { get; set; }

        /// <summary>
        /// 总共物理读
        /// </summary>
        [JsonProperty("total_physical_reads", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalPhysicalReads { get; set; }

        /// <summary>
        /// 最近物理读
        /// </summary>
        [JsonProperty("last_physical_reads", NullValueHandling = NullValueHandling.Ignore)]
        public string LastPhysicalReads { get; set; }

        /// <summary>
        /// 最小物理读
        /// </summary>
        [JsonProperty("min_physical_reads", NullValueHandling = NullValueHandling.Ignore)]
        public string MinPhysicalReads { get; set; }

        /// <summary>
        /// 最大物理读
        /// </summary>
        [JsonProperty("max_physical_reads", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxPhysicalReads { get; set; }

        /// <summary>
        /// 平均执行耗时
        /// </summary>
        [JsonProperty("avg_elapsed_time", NullValueHandling = NullValueHandling.Ignore)]
        public string AvgElapsedTime { get; set; }

        /// <summary>
        /// 总共执行耗时
        /// </summary>
        [JsonProperty("total_elapsed_time", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalElapsedTime { get; set; }

        /// <summary>
        /// 最近执行耗时
        /// </summary>
        [JsonProperty("last_elapsed_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastElapsedTime { get; set; }

        /// <summary>
        /// 最小执行耗时
        /// </summary>
        [JsonProperty("min_elapsed_time", NullValueHandling = NullValueHandling.Ignore)]
        public string MinElapsedTime { get; set; }

        /// <summary>
        /// 最大执行耗时
        /// </summary>
        [JsonProperty("max_elapsed_time", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxElapsedTime { get; set; }

        /// <summary>
        /// 平均返回行
        /// </summary>
        [JsonProperty("avg_rows", NullValueHandling = NullValueHandling.Ignore)]
        public string AvgRows { get; set; }

        /// <summary>
        /// 总返回行
        /// </summary>
        [JsonProperty("total_rows", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalRows { get; set; }

        /// <summary>
        /// 最近返回行
        /// </summary>
        [JsonProperty("last_rows", NullValueHandling = NullValueHandling.Ignore)]
        public string LastRows { get; set; }

        /// <summary>
        /// 最小返回行
        /// </summary>
        [JsonProperty("min_rows", NullValueHandling = NullValueHandling.Ignore)]
        public string MinRows { get; set; }

        /// <summary>
        /// 最大返回行
        /// </summary>
        [JsonProperty("max_rows", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxRows { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TopObject {\n");
            sb.Append("  rowId: ").Append(RowId).Append("\n");
            sb.Append("  databaseName: ").Append(DatabaseName).Append("\n");
            sb.Append("  schemaName: ").Append(SchemaName).Append("\n");
            sb.Append("  objectName: ").Append(ObjectName).Append("\n");
            sb.Append("  objectId: ").Append(ObjectId).Append("\n");
            sb.Append("  objectType: ").Append(ObjectType).Append("\n");
            sb.Append("  sqlStatement: ").Append(SqlStatement).Append("\n");
            sb.Append("  executionCount: ").Append(ExecutionCount).Append("\n");
            sb.Append("  planGenerationNum: ").Append(PlanGenerationNum).Append("\n");
            sb.Append("  lastExecutionTime: ").Append(LastExecutionTime).Append("\n");
            sb.Append("  avgWorkerTime: ").Append(AvgWorkerTime).Append("\n");
            sb.Append("  totalWorkerTime: ").Append(TotalWorkerTime).Append("\n");
            sb.Append("  lastWorkerTime: ").Append(LastWorkerTime).Append("\n");
            sb.Append("  minWorkerTime: ").Append(MinWorkerTime).Append("\n");
            sb.Append("  maxWorkerTime: ").Append(MaxWorkerTime).Append("\n");
            sb.Append("  avgLogicalReads: ").Append(AvgLogicalReads).Append("\n");
            sb.Append("  totalLogicalReads: ").Append(TotalLogicalReads).Append("\n");
            sb.Append("  lastLogicalReads: ").Append(LastLogicalReads).Append("\n");
            sb.Append("  minLogicalReads: ").Append(MinLogicalReads).Append("\n");
            sb.Append("  maxLogicalReads: ").Append(MaxLogicalReads).Append("\n");
            sb.Append("  avgLogicalWrites: ").Append(AvgLogicalWrites).Append("\n");
            sb.Append("  totalLogicalWrites: ").Append(TotalLogicalWrites).Append("\n");
            sb.Append("  lastLogicalWrites: ").Append(LastLogicalWrites).Append("\n");
            sb.Append("  minLogicalWrites: ").Append(MinLogicalWrites).Append("\n");
            sb.Append("  maxLogicalWrites: ").Append(MaxLogicalWrites).Append("\n");
            sb.Append("  avgLogicalIo: ").Append(AvgLogicalIo).Append("\n");
            sb.Append("  totalLogicalIo: ").Append(TotalLogicalIo).Append("\n");
            sb.Append("  lastLogicalIo: ").Append(LastLogicalIo).Append("\n");
            sb.Append("  minLogicalIo: ").Append(MinLogicalIo).Append("\n");
            sb.Append("  maxLogicalIo: ").Append(MaxLogicalIo).Append("\n");
            sb.Append("  avgPhysicalReads: ").Append(AvgPhysicalReads).Append("\n");
            sb.Append("  totalPhysicalReads: ").Append(TotalPhysicalReads).Append("\n");
            sb.Append("  lastPhysicalReads: ").Append(LastPhysicalReads).Append("\n");
            sb.Append("  minPhysicalReads: ").Append(MinPhysicalReads).Append("\n");
            sb.Append("  maxPhysicalReads: ").Append(MaxPhysicalReads).Append("\n");
            sb.Append("  avgElapsedTime: ").Append(AvgElapsedTime).Append("\n");
            sb.Append("  totalElapsedTime: ").Append(TotalElapsedTime).Append("\n");
            sb.Append("  lastElapsedTime: ").Append(LastElapsedTime).Append("\n");
            sb.Append("  minElapsedTime: ").Append(MinElapsedTime).Append("\n");
            sb.Append("  maxElapsedTime: ").Append(MaxElapsedTime).Append("\n");
            sb.Append("  avgRows: ").Append(AvgRows).Append("\n");
            sb.Append("  totalRows: ").Append(TotalRows).Append("\n");
            sb.Append("  lastRows: ").Append(LastRows).Append("\n");
            sb.Append("  minRows: ").Append(MinRows).Append("\n");
            sb.Append("  maxRows: ").Append(MaxRows).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TopObject);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TopObject input)
        {
            if (input == null) return false;
            if (this.RowId != input.RowId || (this.RowId != null && !this.RowId.Equals(input.RowId))) return false;
            if (this.DatabaseName != input.DatabaseName || (this.DatabaseName != null && !this.DatabaseName.Equals(input.DatabaseName))) return false;
            if (this.SchemaName != input.SchemaName || (this.SchemaName != null && !this.SchemaName.Equals(input.SchemaName))) return false;
            if (this.ObjectName != input.ObjectName || (this.ObjectName != null && !this.ObjectName.Equals(input.ObjectName))) return false;
            if (this.ObjectId != input.ObjectId || (this.ObjectId != null && !this.ObjectId.Equals(input.ObjectId))) return false;
            if (this.ObjectType != input.ObjectType || (this.ObjectType != null && !this.ObjectType.Equals(input.ObjectType))) return false;
            if (this.SqlStatement != input.SqlStatement || (this.SqlStatement != null && !this.SqlStatement.Equals(input.SqlStatement))) return false;
            if (this.ExecutionCount != input.ExecutionCount || (this.ExecutionCount != null && !this.ExecutionCount.Equals(input.ExecutionCount))) return false;
            if (this.PlanGenerationNum != input.PlanGenerationNum || (this.PlanGenerationNum != null && !this.PlanGenerationNum.Equals(input.PlanGenerationNum))) return false;
            if (this.LastExecutionTime != input.LastExecutionTime || (this.LastExecutionTime != null && !this.LastExecutionTime.Equals(input.LastExecutionTime))) return false;
            if (this.AvgWorkerTime != input.AvgWorkerTime || (this.AvgWorkerTime != null && !this.AvgWorkerTime.Equals(input.AvgWorkerTime))) return false;
            if (this.TotalWorkerTime != input.TotalWorkerTime || (this.TotalWorkerTime != null && !this.TotalWorkerTime.Equals(input.TotalWorkerTime))) return false;
            if (this.LastWorkerTime != input.LastWorkerTime || (this.LastWorkerTime != null && !this.LastWorkerTime.Equals(input.LastWorkerTime))) return false;
            if (this.MinWorkerTime != input.MinWorkerTime || (this.MinWorkerTime != null && !this.MinWorkerTime.Equals(input.MinWorkerTime))) return false;
            if (this.MaxWorkerTime != input.MaxWorkerTime || (this.MaxWorkerTime != null && !this.MaxWorkerTime.Equals(input.MaxWorkerTime))) return false;
            if (this.AvgLogicalReads != input.AvgLogicalReads || (this.AvgLogicalReads != null && !this.AvgLogicalReads.Equals(input.AvgLogicalReads))) return false;
            if (this.TotalLogicalReads != input.TotalLogicalReads || (this.TotalLogicalReads != null && !this.TotalLogicalReads.Equals(input.TotalLogicalReads))) return false;
            if (this.LastLogicalReads != input.LastLogicalReads || (this.LastLogicalReads != null && !this.LastLogicalReads.Equals(input.LastLogicalReads))) return false;
            if (this.MinLogicalReads != input.MinLogicalReads || (this.MinLogicalReads != null && !this.MinLogicalReads.Equals(input.MinLogicalReads))) return false;
            if (this.MaxLogicalReads != input.MaxLogicalReads || (this.MaxLogicalReads != null && !this.MaxLogicalReads.Equals(input.MaxLogicalReads))) return false;
            if (this.AvgLogicalWrites != input.AvgLogicalWrites || (this.AvgLogicalWrites != null && !this.AvgLogicalWrites.Equals(input.AvgLogicalWrites))) return false;
            if (this.TotalLogicalWrites != input.TotalLogicalWrites || (this.TotalLogicalWrites != null && !this.TotalLogicalWrites.Equals(input.TotalLogicalWrites))) return false;
            if (this.LastLogicalWrites != input.LastLogicalWrites || (this.LastLogicalWrites != null && !this.LastLogicalWrites.Equals(input.LastLogicalWrites))) return false;
            if (this.MinLogicalWrites != input.MinLogicalWrites || (this.MinLogicalWrites != null && !this.MinLogicalWrites.Equals(input.MinLogicalWrites))) return false;
            if (this.MaxLogicalWrites != input.MaxLogicalWrites || (this.MaxLogicalWrites != null && !this.MaxLogicalWrites.Equals(input.MaxLogicalWrites))) return false;
            if (this.AvgLogicalIo != input.AvgLogicalIo || (this.AvgLogicalIo != null && !this.AvgLogicalIo.Equals(input.AvgLogicalIo))) return false;
            if (this.TotalLogicalIo != input.TotalLogicalIo || (this.TotalLogicalIo != null && !this.TotalLogicalIo.Equals(input.TotalLogicalIo))) return false;
            if (this.LastLogicalIo != input.LastLogicalIo || (this.LastLogicalIo != null && !this.LastLogicalIo.Equals(input.LastLogicalIo))) return false;
            if (this.MinLogicalIo != input.MinLogicalIo || (this.MinLogicalIo != null && !this.MinLogicalIo.Equals(input.MinLogicalIo))) return false;
            if (this.MaxLogicalIo != input.MaxLogicalIo || (this.MaxLogicalIo != null && !this.MaxLogicalIo.Equals(input.MaxLogicalIo))) return false;
            if (this.AvgPhysicalReads != input.AvgPhysicalReads || (this.AvgPhysicalReads != null && !this.AvgPhysicalReads.Equals(input.AvgPhysicalReads))) return false;
            if (this.TotalPhysicalReads != input.TotalPhysicalReads || (this.TotalPhysicalReads != null && !this.TotalPhysicalReads.Equals(input.TotalPhysicalReads))) return false;
            if (this.LastPhysicalReads != input.LastPhysicalReads || (this.LastPhysicalReads != null && !this.LastPhysicalReads.Equals(input.LastPhysicalReads))) return false;
            if (this.MinPhysicalReads != input.MinPhysicalReads || (this.MinPhysicalReads != null && !this.MinPhysicalReads.Equals(input.MinPhysicalReads))) return false;
            if (this.MaxPhysicalReads != input.MaxPhysicalReads || (this.MaxPhysicalReads != null && !this.MaxPhysicalReads.Equals(input.MaxPhysicalReads))) return false;
            if (this.AvgElapsedTime != input.AvgElapsedTime || (this.AvgElapsedTime != null && !this.AvgElapsedTime.Equals(input.AvgElapsedTime))) return false;
            if (this.TotalElapsedTime != input.TotalElapsedTime || (this.TotalElapsedTime != null && !this.TotalElapsedTime.Equals(input.TotalElapsedTime))) return false;
            if (this.LastElapsedTime != input.LastElapsedTime || (this.LastElapsedTime != null && !this.LastElapsedTime.Equals(input.LastElapsedTime))) return false;
            if (this.MinElapsedTime != input.MinElapsedTime || (this.MinElapsedTime != null && !this.MinElapsedTime.Equals(input.MinElapsedTime))) return false;
            if (this.MaxElapsedTime != input.MaxElapsedTime || (this.MaxElapsedTime != null && !this.MaxElapsedTime.Equals(input.MaxElapsedTime))) return false;
            if (this.AvgRows != input.AvgRows || (this.AvgRows != null && !this.AvgRows.Equals(input.AvgRows))) return false;
            if (this.TotalRows != input.TotalRows || (this.TotalRows != null && !this.TotalRows.Equals(input.TotalRows))) return false;
            if (this.LastRows != input.LastRows || (this.LastRows != null && !this.LastRows.Equals(input.LastRows))) return false;
            if (this.MinRows != input.MinRows || (this.MinRows != null && !this.MinRows.Equals(input.MinRows))) return false;
            if (this.MaxRows != input.MaxRows || (this.MaxRows != null && !this.MaxRows.Equals(input.MaxRows))) return false;

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
                if (this.RowId != null) hashCode = hashCode * 59 + this.RowId.GetHashCode();
                if (this.DatabaseName != null) hashCode = hashCode * 59 + this.DatabaseName.GetHashCode();
                if (this.SchemaName != null) hashCode = hashCode * 59 + this.SchemaName.GetHashCode();
                if (this.ObjectName != null) hashCode = hashCode * 59 + this.ObjectName.GetHashCode();
                if (this.ObjectId != null) hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.ObjectType != null) hashCode = hashCode * 59 + this.ObjectType.GetHashCode();
                if (this.SqlStatement != null) hashCode = hashCode * 59 + this.SqlStatement.GetHashCode();
                if (this.ExecutionCount != null) hashCode = hashCode * 59 + this.ExecutionCount.GetHashCode();
                if (this.PlanGenerationNum != null) hashCode = hashCode * 59 + this.PlanGenerationNum.GetHashCode();
                if (this.LastExecutionTime != null) hashCode = hashCode * 59 + this.LastExecutionTime.GetHashCode();
                if (this.AvgWorkerTime != null) hashCode = hashCode * 59 + this.AvgWorkerTime.GetHashCode();
                if (this.TotalWorkerTime != null) hashCode = hashCode * 59 + this.TotalWorkerTime.GetHashCode();
                if (this.LastWorkerTime != null) hashCode = hashCode * 59 + this.LastWorkerTime.GetHashCode();
                if (this.MinWorkerTime != null) hashCode = hashCode * 59 + this.MinWorkerTime.GetHashCode();
                if (this.MaxWorkerTime != null) hashCode = hashCode * 59 + this.MaxWorkerTime.GetHashCode();
                if (this.AvgLogicalReads != null) hashCode = hashCode * 59 + this.AvgLogicalReads.GetHashCode();
                if (this.TotalLogicalReads != null) hashCode = hashCode * 59 + this.TotalLogicalReads.GetHashCode();
                if (this.LastLogicalReads != null) hashCode = hashCode * 59 + this.LastLogicalReads.GetHashCode();
                if (this.MinLogicalReads != null) hashCode = hashCode * 59 + this.MinLogicalReads.GetHashCode();
                if (this.MaxLogicalReads != null) hashCode = hashCode * 59 + this.MaxLogicalReads.GetHashCode();
                if (this.AvgLogicalWrites != null) hashCode = hashCode * 59 + this.AvgLogicalWrites.GetHashCode();
                if (this.TotalLogicalWrites != null) hashCode = hashCode * 59 + this.TotalLogicalWrites.GetHashCode();
                if (this.LastLogicalWrites != null) hashCode = hashCode * 59 + this.LastLogicalWrites.GetHashCode();
                if (this.MinLogicalWrites != null) hashCode = hashCode * 59 + this.MinLogicalWrites.GetHashCode();
                if (this.MaxLogicalWrites != null) hashCode = hashCode * 59 + this.MaxLogicalWrites.GetHashCode();
                if (this.AvgLogicalIo != null) hashCode = hashCode * 59 + this.AvgLogicalIo.GetHashCode();
                if (this.TotalLogicalIo != null) hashCode = hashCode * 59 + this.TotalLogicalIo.GetHashCode();
                if (this.LastLogicalIo != null) hashCode = hashCode * 59 + this.LastLogicalIo.GetHashCode();
                if (this.MinLogicalIo != null) hashCode = hashCode * 59 + this.MinLogicalIo.GetHashCode();
                if (this.MaxLogicalIo != null) hashCode = hashCode * 59 + this.MaxLogicalIo.GetHashCode();
                if (this.AvgPhysicalReads != null) hashCode = hashCode * 59 + this.AvgPhysicalReads.GetHashCode();
                if (this.TotalPhysicalReads != null) hashCode = hashCode * 59 + this.TotalPhysicalReads.GetHashCode();
                if (this.LastPhysicalReads != null) hashCode = hashCode * 59 + this.LastPhysicalReads.GetHashCode();
                if (this.MinPhysicalReads != null) hashCode = hashCode * 59 + this.MinPhysicalReads.GetHashCode();
                if (this.MaxPhysicalReads != null) hashCode = hashCode * 59 + this.MaxPhysicalReads.GetHashCode();
                if (this.AvgElapsedTime != null) hashCode = hashCode * 59 + this.AvgElapsedTime.GetHashCode();
                if (this.TotalElapsedTime != null) hashCode = hashCode * 59 + this.TotalElapsedTime.GetHashCode();
                if (this.LastElapsedTime != null) hashCode = hashCode * 59 + this.LastElapsedTime.GetHashCode();
                if (this.MinElapsedTime != null) hashCode = hashCode * 59 + this.MinElapsedTime.GetHashCode();
                if (this.MaxElapsedTime != null) hashCode = hashCode * 59 + this.MaxElapsedTime.GetHashCode();
                if (this.AvgRows != null) hashCode = hashCode * 59 + this.AvgRows.GetHashCode();
                if (this.TotalRows != null) hashCode = hashCode * 59 + this.TotalRows.GetHashCode();
                if (this.LastRows != null) hashCode = hashCode * 59 + this.LastRows.GetHashCode();
                if (this.MinRows != null) hashCode = hashCode * 59 + this.MinRows.GetHashCode();
                if (this.MaxRows != null) hashCode = hashCode * 59 + this.MaxRows.GetHashCode();
                return hashCode;
            }
        }
    }
}
