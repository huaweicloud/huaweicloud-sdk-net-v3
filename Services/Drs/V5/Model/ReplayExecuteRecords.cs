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
    /// 流量回放SQL的执行记录
    /// </summary>
    public class ReplayExecuteRecords 
    {

        /// <summary>
        /// 执行记录的时间，格式为秒级时间戳。
        /// </summary>
        [JsonProperty("execute_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExecuteTime { get; set; }

        /// <summary>
        /// 执行完的SQL数量。
        /// </summary>
        [JsonProperty("finished_sql", NullValueHandling = NullValueHandling.Ignore)]
        public long? FinishedSql { get; set; }

        /// <summary>
        /// 执行的异常SQL数量。
        /// </summary>
        [JsonProperty("abnormal_sql", NullValueHandling = NullValueHandling.Ignore)]
        public long? AbnormalSql { get; set; }

        /// <summary>
        /// 执行的慢SQL数量。
        /// </summary>
        [JsonProperty("slow_sql", NullValueHandling = NullValueHandling.Ignore)]
        public long? SlowSql { get; set; }

        /// <summary>
        /// 执行记录的SQL总数。
        /// </summary>
        [JsonProperty("total_sql", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalSql { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReplayExecuteRecords {\n");
            sb.Append("  executeTime: ").Append(ExecuteTime).Append("\n");
            sb.Append("  finishedSql: ").Append(FinishedSql).Append("\n");
            sb.Append("  abnormalSql: ").Append(AbnormalSql).Append("\n");
            sb.Append("  slowSql: ").Append(SlowSql).Append("\n");
            sb.Append("  totalSql: ").Append(TotalSql).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReplayExecuteRecords);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReplayExecuteRecords input)
        {
            if (input == null) return false;
            if (this.ExecuteTime != input.ExecuteTime || (this.ExecuteTime != null && !this.ExecuteTime.Equals(input.ExecuteTime))) return false;
            if (this.FinishedSql != input.FinishedSql || (this.FinishedSql != null && !this.FinishedSql.Equals(input.FinishedSql))) return false;
            if (this.AbnormalSql != input.AbnormalSql || (this.AbnormalSql != null && !this.AbnormalSql.Equals(input.AbnormalSql))) return false;
            if (this.SlowSql != input.SlowSql || (this.SlowSql != null && !this.SlowSql.Equals(input.SlowSql))) return false;
            if (this.TotalSql != input.TotalSql || (this.TotalSql != null && !this.TotalSql.Equals(input.TotalSql))) return false;

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
                if (this.ExecuteTime != null) hashCode = hashCode * 59 + this.ExecuteTime.GetHashCode();
                if (this.FinishedSql != null) hashCode = hashCode * 59 + this.FinishedSql.GetHashCode();
                if (this.AbnormalSql != null) hashCode = hashCode * 59 + this.AbnormalSql.GetHashCode();
                if (this.SlowSql != null) hashCode = hashCode * 59 + this.SlowSql.GetHashCode();
                if (this.TotalSql != null) hashCode = hashCode * 59 + this.TotalSql.GetHashCode();
                return hashCode;
            }
        }
    }
}
