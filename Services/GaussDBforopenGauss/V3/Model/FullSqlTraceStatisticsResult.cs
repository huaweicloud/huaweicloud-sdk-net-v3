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
    /// 链路详情信息
    /// </summary>
    public class FullSqlTraceStatisticsResult 
    {

        /// <summary>
        /// **参数解释**: 命中率。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("hit_rate", NullValueHandling = NullValueHandling.Ignore)]
        public double? HitRate { get; set; }

        /// <summary>
        /// **参数解释**: 有效DB时间花费。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("db_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? DbTime { get; set; }

        /// <summary>
        /// **参数解释**: CPU时间（单位：微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("cpu_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? CpuTime { get; set; }

        /// <summary>
        /// **参数解释**: IO时间（单位：微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("io_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? IoTime { get; set; }

        /// <summary>
        /// **参数解释**: 执行器内执行时间（单位：微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("execution_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExecutionTime { get; set; }

        /// <summary>
        /// **参数解释**: 扫描行数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("scan_rows", NullValueHandling = NullValueHandling.Ignore)]
        public int? ScanRows { get; set; }

        /// <summary>
        /// **参数解释**: 更新行数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("update_rows", NullValueHandling = NullValueHandling.Ignore)]
        public int? UpdateRows { get; set; }

        /// <summary>
        /// **参数解释**: 插入行数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("insert_rows", NullValueHandling = NullValueHandling.Ignore)]
        public int? InsertRows { get; set; }

        /// <summary>
        /// **参数解释**: 删除行数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("delete_rows", NullValueHandling = NullValueHandling.Ignore)]
        public int? DeleteRows { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FullSqlTraceStatisticsResult {\n");
            sb.Append("  hitRate: ").Append(HitRate).Append("\n");
            sb.Append("  dbTime: ").Append(DbTime).Append("\n");
            sb.Append("  cpuTime: ").Append(CpuTime).Append("\n");
            sb.Append("  ioTime: ").Append(IoTime).Append("\n");
            sb.Append("  executionTime: ").Append(ExecutionTime).Append("\n");
            sb.Append("  scanRows: ").Append(ScanRows).Append("\n");
            sb.Append("  updateRows: ").Append(UpdateRows).Append("\n");
            sb.Append("  insertRows: ").Append(InsertRows).Append("\n");
            sb.Append("  deleteRows: ").Append(DeleteRows).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FullSqlTraceStatisticsResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FullSqlTraceStatisticsResult input)
        {
            if (input == null) return false;
            if (this.HitRate != input.HitRate || (this.HitRate != null && !this.HitRate.Equals(input.HitRate))) return false;
            if (this.DbTime != input.DbTime || (this.DbTime != null && !this.DbTime.Equals(input.DbTime))) return false;
            if (this.CpuTime != input.CpuTime || (this.CpuTime != null && !this.CpuTime.Equals(input.CpuTime))) return false;
            if (this.IoTime != input.IoTime || (this.IoTime != null && !this.IoTime.Equals(input.IoTime))) return false;
            if (this.ExecutionTime != input.ExecutionTime || (this.ExecutionTime != null && !this.ExecutionTime.Equals(input.ExecutionTime))) return false;
            if (this.ScanRows != input.ScanRows || (this.ScanRows != null && !this.ScanRows.Equals(input.ScanRows))) return false;
            if (this.UpdateRows != input.UpdateRows || (this.UpdateRows != null && !this.UpdateRows.Equals(input.UpdateRows))) return false;
            if (this.InsertRows != input.InsertRows || (this.InsertRows != null && !this.InsertRows.Equals(input.InsertRows))) return false;
            if (this.DeleteRows != input.DeleteRows || (this.DeleteRows != null && !this.DeleteRows.Equals(input.DeleteRows))) return false;

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
                if (this.HitRate != null) hashCode = hashCode * 59 + this.HitRate.GetHashCode();
                if (this.DbTime != null) hashCode = hashCode * 59 + this.DbTime.GetHashCode();
                if (this.CpuTime != null) hashCode = hashCode * 59 + this.CpuTime.GetHashCode();
                if (this.IoTime != null) hashCode = hashCode * 59 + this.IoTime.GetHashCode();
                if (this.ExecutionTime != null) hashCode = hashCode * 59 + this.ExecutionTime.GetHashCode();
                if (this.ScanRows != null) hashCode = hashCode * 59 + this.ScanRows.GetHashCode();
                if (this.UpdateRows != null) hashCode = hashCode * 59 + this.UpdateRows.GetHashCode();
                if (this.InsertRows != null) hashCode = hashCode * 59 + this.InsertRows.GetHashCode();
                if (this.DeleteRows != null) hashCode = hashCode * 59 + this.DeleteRows.GetHashCode();
                return hashCode;
            }
        }
    }
}
