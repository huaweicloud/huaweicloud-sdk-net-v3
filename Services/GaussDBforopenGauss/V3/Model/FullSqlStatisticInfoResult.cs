using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 全量SQL聚合统计信息。
    /// </summary>
    public class FullSqlStatisticInfoResult 
    {

        /// <summary>
        /// **参数解释**: SQL模板。未开启实例内核GUC参数（track_stmt_parameter）时，展示的是归一化SQL模板内容；开启该参数后，展示的是随机一条SQL记录中截断参数列表后的内容。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("template", NullValueHandling = NullValueHandling.Ignore)]
        public string Template { get; set; }

        /// <summary>
        /// **参数解释**: 归一化SQL ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("sql_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlId { get; set; }

        /// <summary>
        /// **参数解释**: 汇总SQL条目数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("sql_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? SqlCount { get; set; }

        /// <summary>
        /// **参数解释**: 总SQL耗时（微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("total_sql_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalSqlTime { get; set; }

        /// <summary>
        /// **参数解释**: 平均SQL耗时（微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("avg_sql_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? AvgSqlTime { get; set; }

        /// <summary>
        /// **参数解释**: 总有效DB耗时（微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("total_db_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalDbTime { get; set; }

        /// <summary>
        /// **参数解释**: 总CPU耗时（微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("total_cpu_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalCpuTime { get; set; }

        /// <summary>
        /// **参数解释**: 平均解释器时间（微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("avg_parse_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? AvgParseTime { get; set; }

        /// <summary>
        /// **参数解释**: 平均执行计划时间（微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("avg_plan_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? AvgPlanTime { get; set; }

        /// <summary>
        /// **参数解释**: 总IO耗时（微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("total_data_io_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalDataIoTime { get; set; }

        /// <summary>
        /// **参数解释**: 平均返回行数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("avg_n_returned_rows", NullValueHandling = NullValueHandling.Ignore)]
        public long? AvgNReturnedRows { get; set; }

        /// <summary>
        /// **参数解释**: 平均扫描行数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("avg_n_tuples_fetched", NullValueHandling = NullValueHandling.Ignore)]
        public long? AvgNTuplesFetched { get; set; }

        /// <summary>
        /// **参数解释**: 平均有效DB耗时（微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("avg_db_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? AvgDbTime { get; set; }

        /// <summary>
        /// **参数解释**: 平均CPU执行耗时（微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("avg_cpu_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? AvgCpuTime { get; set; }

        /// <summary>
        /// **参数解释**: 平均IO耗时（微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("avg_data_io_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? AvgDataIoTime { get; set; }

        /// <summary>
        /// **参数解释**: 平均SQL执行器内执行时间（微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("avg_execution_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? AvgExecutionTime { get; set; }

        /// <summary>
        /// **参数解释**: 平均Buffer块命中次数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("avg_n_blocks_hit", NullValueHandling = NullValueHandling.Ignore)]
        public long? AvgNBlocksHit { get; set; }

        /// <summary>
        /// **参数解释**: 开始时间戳。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("start_time_stamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTimeStamp { get; set; }

        /// <summary>
        /// **参数解释**: 结束时间戳。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("end_time_stamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTimeStamp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FullSqlStatisticInfoResult {\n");
            sb.Append("  template: ").Append(Template).Append("\n");
            sb.Append("  sqlId: ").Append(SqlId).Append("\n");
            sb.Append("  sqlCount: ").Append(SqlCount).Append("\n");
            sb.Append("  totalSqlTime: ").Append(TotalSqlTime).Append("\n");
            sb.Append("  avgSqlTime: ").Append(AvgSqlTime).Append("\n");
            sb.Append("  totalDbTime: ").Append(TotalDbTime).Append("\n");
            sb.Append("  totalCpuTime: ").Append(TotalCpuTime).Append("\n");
            sb.Append("  avgParseTime: ").Append(AvgParseTime).Append("\n");
            sb.Append("  avgPlanTime: ").Append(AvgPlanTime).Append("\n");
            sb.Append("  totalDataIoTime: ").Append(TotalDataIoTime).Append("\n");
            sb.Append("  avgNReturnedRows: ").Append(AvgNReturnedRows).Append("\n");
            sb.Append("  avgNTuplesFetched: ").Append(AvgNTuplesFetched).Append("\n");
            sb.Append("  avgDbTime: ").Append(AvgDbTime).Append("\n");
            sb.Append("  avgCpuTime: ").Append(AvgCpuTime).Append("\n");
            sb.Append("  avgDataIoTime: ").Append(AvgDataIoTime).Append("\n");
            sb.Append("  avgExecutionTime: ").Append(AvgExecutionTime).Append("\n");
            sb.Append("  avgNBlocksHit: ").Append(AvgNBlocksHit).Append("\n");
            sb.Append("  startTimeStamp: ").Append(StartTimeStamp).Append("\n");
            sb.Append("  endTimeStamp: ").Append(EndTimeStamp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FullSqlStatisticInfoResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FullSqlStatisticInfoResult input)
        {
            if (input == null) return false;
            if (this.Template != input.Template || (this.Template != null && !this.Template.Equals(input.Template))) return false;
            if (this.SqlId != input.SqlId || (this.SqlId != null && !this.SqlId.Equals(input.SqlId))) return false;
            if (this.SqlCount != input.SqlCount || (this.SqlCount != null && !this.SqlCount.Equals(input.SqlCount))) return false;
            if (this.TotalSqlTime != input.TotalSqlTime || (this.TotalSqlTime != null && !this.TotalSqlTime.Equals(input.TotalSqlTime))) return false;
            if (this.AvgSqlTime != input.AvgSqlTime || (this.AvgSqlTime != null && !this.AvgSqlTime.Equals(input.AvgSqlTime))) return false;
            if (this.TotalDbTime != input.TotalDbTime || (this.TotalDbTime != null && !this.TotalDbTime.Equals(input.TotalDbTime))) return false;
            if (this.TotalCpuTime != input.TotalCpuTime || (this.TotalCpuTime != null && !this.TotalCpuTime.Equals(input.TotalCpuTime))) return false;
            if (this.AvgParseTime != input.AvgParseTime || (this.AvgParseTime != null && !this.AvgParseTime.Equals(input.AvgParseTime))) return false;
            if (this.AvgPlanTime != input.AvgPlanTime || (this.AvgPlanTime != null && !this.AvgPlanTime.Equals(input.AvgPlanTime))) return false;
            if (this.TotalDataIoTime != input.TotalDataIoTime || (this.TotalDataIoTime != null && !this.TotalDataIoTime.Equals(input.TotalDataIoTime))) return false;
            if (this.AvgNReturnedRows != input.AvgNReturnedRows || (this.AvgNReturnedRows != null && !this.AvgNReturnedRows.Equals(input.AvgNReturnedRows))) return false;
            if (this.AvgNTuplesFetched != input.AvgNTuplesFetched || (this.AvgNTuplesFetched != null && !this.AvgNTuplesFetched.Equals(input.AvgNTuplesFetched))) return false;
            if (this.AvgDbTime != input.AvgDbTime || (this.AvgDbTime != null && !this.AvgDbTime.Equals(input.AvgDbTime))) return false;
            if (this.AvgCpuTime != input.AvgCpuTime || (this.AvgCpuTime != null && !this.AvgCpuTime.Equals(input.AvgCpuTime))) return false;
            if (this.AvgDataIoTime != input.AvgDataIoTime || (this.AvgDataIoTime != null && !this.AvgDataIoTime.Equals(input.AvgDataIoTime))) return false;
            if (this.AvgExecutionTime != input.AvgExecutionTime || (this.AvgExecutionTime != null && !this.AvgExecutionTime.Equals(input.AvgExecutionTime))) return false;
            if (this.AvgNBlocksHit != input.AvgNBlocksHit || (this.AvgNBlocksHit != null && !this.AvgNBlocksHit.Equals(input.AvgNBlocksHit))) return false;
            if (this.StartTimeStamp != input.StartTimeStamp || (this.StartTimeStamp != null && !this.StartTimeStamp.Equals(input.StartTimeStamp))) return false;
            if (this.EndTimeStamp != input.EndTimeStamp || (this.EndTimeStamp != null && !this.EndTimeStamp.Equals(input.EndTimeStamp))) return false;

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
                if (this.Template != null) hashCode = hashCode * 59 + this.Template.GetHashCode();
                if (this.SqlId != null) hashCode = hashCode * 59 + this.SqlId.GetHashCode();
                if (this.SqlCount != null) hashCode = hashCode * 59 + this.SqlCount.GetHashCode();
                if (this.TotalSqlTime != null) hashCode = hashCode * 59 + this.TotalSqlTime.GetHashCode();
                if (this.AvgSqlTime != null) hashCode = hashCode * 59 + this.AvgSqlTime.GetHashCode();
                if (this.TotalDbTime != null) hashCode = hashCode * 59 + this.TotalDbTime.GetHashCode();
                if (this.TotalCpuTime != null) hashCode = hashCode * 59 + this.TotalCpuTime.GetHashCode();
                if (this.AvgParseTime != null) hashCode = hashCode * 59 + this.AvgParseTime.GetHashCode();
                if (this.AvgPlanTime != null) hashCode = hashCode * 59 + this.AvgPlanTime.GetHashCode();
                if (this.TotalDataIoTime != null) hashCode = hashCode * 59 + this.TotalDataIoTime.GetHashCode();
                if (this.AvgNReturnedRows != null) hashCode = hashCode * 59 + this.AvgNReturnedRows.GetHashCode();
                if (this.AvgNTuplesFetched != null) hashCode = hashCode * 59 + this.AvgNTuplesFetched.GetHashCode();
                if (this.AvgDbTime != null) hashCode = hashCode * 59 + this.AvgDbTime.GetHashCode();
                if (this.AvgCpuTime != null) hashCode = hashCode * 59 + this.AvgCpuTime.GetHashCode();
                if (this.AvgDataIoTime != null) hashCode = hashCode * 59 + this.AvgDataIoTime.GetHashCode();
                if (this.AvgExecutionTime != null) hashCode = hashCode * 59 + this.AvgExecutionTime.GetHashCode();
                if (this.AvgNBlocksHit != null) hashCode = hashCode * 59 + this.AvgNBlocksHit.GetHashCode();
                if (this.StartTimeStamp != null) hashCode = hashCode * 59 + this.StartTimeStamp.GetHashCode();
                if (this.EndTimeStamp != null) hashCode = hashCode * 59 + this.EndTimeStamp.GetHashCode();
                return hashCode;
            }
        }
    }
}
