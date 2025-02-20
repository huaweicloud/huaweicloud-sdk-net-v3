using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 修复进度明细
    /// </summary>
    public class JobDetailRespRepairProgressInfoRepairProgressDetails 
    {

        /// <summary>
        /// 对比任务ID。
        /// </summary>
        [JsonProperty("query_id", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryId { get; set; }

        /// <summary>
        /// 库名。
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// schema名。
        /// </summary>
        [JsonProperty("schema_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemaName { get; set; }

        /// <summary>
        /// 表名。
        /// </summary>
        [JsonProperty("table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TableName { get; set; }

        /// <summary>
        /// 总行数。
        /// </summary>
        [JsonProperty("total_row_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalRowCount { get; set; }

        /// <summary>
        /// 完成行数。
        /// </summary>
        [JsonProperty("complete_row_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? CompleteRowCount { get; set; }

        /// <summary>
        /// 过滤行数。
        /// </summary>
        [JsonProperty("filter_row_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FilterRowCount { get; set; }

        /// <summary>
        /// 已修复行数。
        /// </summary>
        [JsonProperty("repaired_row_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepairedRowCount { get; set; }

        /// <summary>
        /// 失败行数。
        /// </summary>
        [JsonProperty("failed_row_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FailedRowCount { get; set; }

        /// <summary>
        /// 修复状态。
        /// </summary>
        [JsonProperty("repair_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepairStatus { get; set; }

        /// <summary>
        /// 开始时间。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 更新时间。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobDetailRespRepairProgressInfoRepairProgressDetails {\n");
            sb.Append("  queryId: ").Append(QueryId).Append("\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  schemaName: ").Append(SchemaName).Append("\n");
            sb.Append("  tableName: ").Append(TableName).Append("\n");
            sb.Append("  totalRowCount: ").Append(TotalRowCount).Append("\n");
            sb.Append("  completeRowCount: ").Append(CompleteRowCount).Append("\n");
            sb.Append("  filterRowCount: ").Append(FilterRowCount).Append("\n");
            sb.Append("  repairedRowCount: ").Append(RepairedRowCount).Append("\n");
            sb.Append("  failedRowCount: ").Append(FailedRowCount).Append("\n");
            sb.Append("  repairStatus: ").Append(RepairStatus).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobDetailRespRepairProgressInfoRepairProgressDetails);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobDetailRespRepairProgressInfoRepairProgressDetails input)
        {
            if (input == null) return false;
            if (this.QueryId != input.QueryId || (this.QueryId != null && !this.QueryId.Equals(input.QueryId))) return false;
            if (this.DbName != input.DbName || (this.DbName != null && !this.DbName.Equals(input.DbName))) return false;
            if (this.SchemaName != input.SchemaName || (this.SchemaName != null && !this.SchemaName.Equals(input.SchemaName))) return false;
            if (this.TableName != input.TableName || (this.TableName != null && !this.TableName.Equals(input.TableName))) return false;
            if (this.TotalRowCount != input.TotalRowCount || (this.TotalRowCount != null && !this.TotalRowCount.Equals(input.TotalRowCount))) return false;
            if (this.CompleteRowCount != input.CompleteRowCount || (this.CompleteRowCount != null && !this.CompleteRowCount.Equals(input.CompleteRowCount))) return false;
            if (this.FilterRowCount != input.FilterRowCount || (this.FilterRowCount != null && !this.FilterRowCount.Equals(input.FilterRowCount))) return false;
            if (this.RepairedRowCount != input.RepairedRowCount || (this.RepairedRowCount != null && !this.RepairedRowCount.Equals(input.RepairedRowCount))) return false;
            if (this.FailedRowCount != input.FailedRowCount || (this.FailedRowCount != null && !this.FailedRowCount.Equals(input.FailedRowCount))) return false;
            if (this.RepairStatus != input.RepairStatus || (this.RepairStatus != null && !this.RepairStatus.Equals(input.RepairStatus))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;

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
                if (this.QueryId != null) hashCode = hashCode * 59 + this.QueryId.GetHashCode();
                if (this.DbName != null) hashCode = hashCode * 59 + this.DbName.GetHashCode();
                if (this.SchemaName != null) hashCode = hashCode * 59 + this.SchemaName.GetHashCode();
                if (this.TableName != null) hashCode = hashCode * 59 + this.TableName.GetHashCode();
                if (this.TotalRowCount != null) hashCode = hashCode * 59 + this.TotalRowCount.GetHashCode();
                if (this.CompleteRowCount != null) hashCode = hashCode * 59 + this.CompleteRowCount.GetHashCode();
                if (this.FilterRowCount != null) hashCode = hashCode * 59 + this.FilterRowCount.GetHashCode();
                if (this.RepairedRowCount != null) hashCode = hashCode * 59 + this.RepairedRowCount.GetHashCode();
                if (this.FailedRowCount != null) hashCode = hashCode * 59 + this.FailedRowCount.GetHashCode();
                if (this.RepairStatus != null) hashCode = hashCode * 59 + this.RepairStatus.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
