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
    /// Top SQL信息
    /// </summary>
    public class TopSQLInfoResult 
    {

        /// <summary>
        /// **参数解释**: Top SQL的归一化SQL ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("sql_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlId { get; set; }

        /// <summary>
        /// **参数解释**: Top SQL的用户名。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// **参数解释**: Top SQL的SQL文本。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("sql_text", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlText { get; set; }

        /// <summary>
        /// **参数解释**: Top SQL的调用频率占比（%）。 **取值范围**: 0-100。
        /// </summary>
        [JsonProperty("calls_percent", NullValueHandling = NullValueHandling.Ignore)]
        public string CallsPercent { get; set; }

        /// <summary>
        /// **参数解释**: Top SQL的调用频率占比。 **取值范围**: 0-100。
        /// </summary>
        [JsonProperty("cpu_percent", NullValueHandling = NullValueHandling.Ignore)]
        public string CpuPercent { get; set; }

        /// <summary>
        /// **参数解释**: Top SQL的IO开销占比。 **取值范围**: 0-100。
        /// </summary>
        [JsonProperty("io_percent", NullValueHandling = NullValueHandling.Ignore)]
        public string IoPercent { get; set; }

        /// <summary>
        /// **参数解释** Top SQL的调用次数。 **取值范围** 大于等于0。
        /// </summary>
        [JsonProperty("calls", NullValueHandling = NullValueHandling.Ignore)]
        public string Calls { get; set; }

        /// <summary>
        /// **参数解释** Top SQL的返回元组数。 **取值范围** 大于等于0。
        /// </summary>
        [JsonProperty("returned_rows", NullValueHandling = NullValueHandling.Ignore)]
        public string ReturnedRows { get; set; }

        /// <summary>
        /// **参数解释** Top SQL的读取元组数。 **取值范围** 大于等于0。
        /// </summary>
        [JsonProperty("tuple_read", NullValueHandling = NullValueHandling.Ignore)]
        public string TupleRead { get; set; }

        /// <summary>
        /// **参数解释** Top SQL的平均时间开销。单位ms。 **取值范围** 大于等于0。
        /// </summary>
        [JsonProperty("avg_elapse_time", NullValueHandling = NullValueHandling.Ignore)]
        public string AvgElapseTime { get; set; }

        /// <summary>
        /// **参数解释** Top SQL的总时间开销。单位ms。 **取值范围** 大于等于0。
        /// </summary>
        [JsonProperty("total_elapse_time", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalElapseTime { get; set; }

        /// <summary>
        /// **参数解释**: Top SQL的CPU开销。单位ms。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("cpu_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CpuTime { get; set; }

        /// <summary>
        /// **参数解释**: Top SQL的IO开销。单位ms。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("io_time", NullValueHandling = NullValueHandling.Ignore)]
        public string IoTime { get; set; }

        /// <summary>
        /// **参数解释**: Top SQL的最小执行时间。单位ms。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("min_elapse_time", NullValueHandling = NullValueHandling.Ignore)]
        public string MinElapseTime { get; set; }

        /// <summary>
        /// **参数解释**: Top SQL最大执行时间。单位ms。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("max_elapse_time", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxElapseTime { get; set; }

        /// <summary>
        /// **参数解释** Top SQL的SQL命中率。 **取值范围** 大于等于0。
        /// </summary>
        [JsonProperty("sql_hit_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlHitRatio { get; set; }

        /// <summary>
        /// **参数解释**: Top SQL的节点ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// **参数解释**: Top SQL的数据库名（引擎版本8.200及以上支持）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// **参数解释**: Top SQL的节点名称。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("node_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TopSQLInfoResult {\n");
            sb.Append("  sqlId: ").Append(SqlId).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  sqlText: ").Append(SqlText).Append("\n");
            sb.Append("  callsPercent: ").Append(CallsPercent).Append("\n");
            sb.Append("  cpuPercent: ").Append(CpuPercent).Append("\n");
            sb.Append("  ioPercent: ").Append(IoPercent).Append("\n");
            sb.Append("  calls: ").Append(Calls).Append("\n");
            sb.Append("  returnedRows: ").Append(ReturnedRows).Append("\n");
            sb.Append("  tupleRead: ").Append(TupleRead).Append("\n");
            sb.Append("  avgElapseTime: ").Append(AvgElapseTime).Append("\n");
            sb.Append("  totalElapseTime: ").Append(TotalElapseTime).Append("\n");
            sb.Append("  cpuTime: ").Append(CpuTime).Append("\n");
            sb.Append("  ioTime: ").Append(IoTime).Append("\n");
            sb.Append("  minElapseTime: ").Append(MinElapseTime).Append("\n");
            sb.Append("  maxElapseTime: ").Append(MaxElapseTime).Append("\n");
            sb.Append("  sqlHitRatio: ").Append(SqlHitRatio).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  nodeName: ").Append(NodeName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TopSQLInfoResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TopSQLInfoResult input)
        {
            if (input == null) return false;
            if (this.SqlId != input.SqlId || (this.SqlId != null && !this.SqlId.Equals(input.SqlId))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.SqlText != input.SqlText || (this.SqlText != null && !this.SqlText.Equals(input.SqlText))) return false;
            if (this.CallsPercent != input.CallsPercent || (this.CallsPercent != null && !this.CallsPercent.Equals(input.CallsPercent))) return false;
            if (this.CpuPercent != input.CpuPercent || (this.CpuPercent != null && !this.CpuPercent.Equals(input.CpuPercent))) return false;
            if (this.IoPercent != input.IoPercent || (this.IoPercent != null && !this.IoPercent.Equals(input.IoPercent))) return false;
            if (this.Calls != input.Calls || (this.Calls != null && !this.Calls.Equals(input.Calls))) return false;
            if (this.ReturnedRows != input.ReturnedRows || (this.ReturnedRows != null && !this.ReturnedRows.Equals(input.ReturnedRows))) return false;
            if (this.TupleRead != input.TupleRead || (this.TupleRead != null && !this.TupleRead.Equals(input.TupleRead))) return false;
            if (this.AvgElapseTime != input.AvgElapseTime || (this.AvgElapseTime != null && !this.AvgElapseTime.Equals(input.AvgElapseTime))) return false;
            if (this.TotalElapseTime != input.TotalElapseTime || (this.TotalElapseTime != null && !this.TotalElapseTime.Equals(input.TotalElapseTime))) return false;
            if (this.CpuTime != input.CpuTime || (this.CpuTime != null && !this.CpuTime.Equals(input.CpuTime))) return false;
            if (this.IoTime != input.IoTime || (this.IoTime != null && !this.IoTime.Equals(input.IoTime))) return false;
            if (this.MinElapseTime != input.MinElapseTime || (this.MinElapseTime != null && !this.MinElapseTime.Equals(input.MinElapseTime))) return false;
            if (this.MaxElapseTime != input.MaxElapseTime || (this.MaxElapseTime != null && !this.MaxElapseTime.Equals(input.MaxElapseTime))) return false;
            if (this.SqlHitRatio != input.SqlHitRatio || (this.SqlHitRatio != null && !this.SqlHitRatio.Equals(input.SqlHitRatio))) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;
            if (this.DbName != input.DbName || (this.DbName != null && !this.DbName.Equals(input.DbName))) return false;
            if (this.NodeName != input.NodeName || (this.NodeName != null && !this.NodeName.Equals(input.NodeName))) return false;

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
                if (this.SqlId != null) hashCode = hashCode * 59 + this.SqlId.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.SqlText != null) hashCode = hashCode * 59 + this.SqlText.GetHashCode();
                if (this.CallsPercent != null) hashCode = hashCode * 59 + this.CallsPercent.GetHashCode();
                if (this.CpuPercent != null) hashCode = hashCode * 59 + this.CpuPercent.GetHashCode();
                if (this.IoPercent != null) hashCode = hashCode * 59 + this.IoPercent.GetHashCode();
                if (this.Calls != null) hashCode = hashCode * 59 + this.Calls.GetHashCode();
                if (this.ReturnedRows != null) hashCode = hashCode * 59 + this.ReturnedRows.GetHashCode();
                if (this.TupleRead != null) hashCode = hashCode * 59 + this.TupleRead.GetHashCode();
                if (this.AvgElapseTime != null) hashCode = hashCode * 59 + this.AvgElapseTime.GetHashCode();
                if (this.TotalElapseTime != null) hashCode = hashCode * 59 + this.TotalElapseTime.GetHashCode();
                if (this.CpuTime != null) hashCode = hashCode * 59 + this.CpuTime.GetHashCode();
                if (this.IoTime != null) hashCode = hashCode * 59 + this.IoTime.GetHashCode();
                if (this.MinElapseTime != null) hashCode = hashCode * 59 + this.MinElapseTime.GetHashCode();
                if (this.MaxElapseTime != null) hashCode = hashCode * 59 + this.MaxElapseTime.GetHashCode();
                if (this.SqlHitRatio != null) hashCode = hashCode * 59 + this.SqlHitRatio.GetHashCode();
                if (this.NodeId != null) hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.DbName != null) hashCode = hashCode * 59 + this.DbName.GetHashCode();
                if (this.NodeName != null) hashCode = hashCode * 59 + this.NodeName.GetHashCode();
                return hashCode;
            }
        }
    }
}
