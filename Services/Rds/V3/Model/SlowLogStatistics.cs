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
    /// 慢日志信息。
    /// </summary>
    public class SlowLogStatistics 
    {

        /// <summary>
        /// 执行次数。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public string Count { get; set; }

        /// <summary>
        /// 平均执行时间。
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }

        /// <summary>
        /// 平均等待锁时间。
        /// </summary>
        [JsonProperty("lockTime", NullValueHandling = NullValueHandling.Ignore)]
        public string LockTime { get; set; }

        /// <summary>
        /// 平均结果行数量。
        /// </summary>
        [JsonProperty("rowsSent", NullValueHandling = NullValueHandling.Ignore)]
        public long? RowsSent { get; set; }

        /// <summary>
        /// 平均扫描的行数量。
        /// </summary>
        [JsonProperty("rowsExamined", NullValueHandling = NullValueHandling.Ignore)]
        public long? RowsExamined { get; set; }

        /// <summary>
        /// 所属数据库。
        /// </summary>
        [JsonProperty("database", NullValueHandling = NullValueHandling.Ignore)]
        public string Database { get; set; }

        /// <summary>
        /// 帐号。
        /// </summary>
        [JsonProperty("users", NullValueHandling = NullValueHandling.Ignore)]
        public string Users { get; set; }

        /// <summary>
        /// 执行语法。
        /// </summary>
        [JsonProperty("querySample", NullValueHandling = NullValueHandling.Ignore)]
        public string QuerySample { get; set; }

        /// <summary>
        /// 语句类型。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// IP地址。
        /// </summary>
        [JsonProperty("clientIP", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientIP { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SlowLogStatistics {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("  lockTime: ").Append(LockTime).Append("\n");
            sb.Append("  rowsSent: ").Append(RowsSent).Append("\n");
            sb.Append("  rowsExamined: ").Append(RowsExamined).Append("\n");
            sb.Append("  database: ").Append(Database).Append("\n");
            sb.Append("  users: ").Append(Users).Append("\n");
            sb.Append("  querySample: ").Append(QuerySample).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  clientIP: ").Append(ClientIP).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SlowLogStatistics);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SlowLogStatistics input)
        {
            if (input == null) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.Time != input.Time || (this.Time != null && !this.Time.Equals(input.Time))) return false;
            if (this.LockTime != input.LockTime || (this.LockTime != null && !this.LockTime.Equals(input.LockTime))) return false;
            if (this.RowsSent != input.RowsSent || (this.RowsSent != null && !this.RowsSent.Equals(input.RowsSent))) return false;
            if (this.RowsExamined != input.RowsExamined || (this.RowsExamined != null && !this.RowsExamined.Equals(input.RowsExamined))) return false;
            if (this.Database != input.Database || (this.Database != null && !this.Database.Equals(input.Database))) return false;
            if (this.Users != input.Users || (this.Users != null && !this.Users.Equals(input.Users))) return false;
            if (this.QuerySample != input.QuerySample || (this.QuerySample != null && !this.QuerySample.Equals(input.QuerySample))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.ClientIP != input.ClientIP || (this.ClientIP != null && !this.ClientIP.Equals(input.ClientIP))) return false;

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
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Time != null) hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.LockTime != null) hashCode = hashCode * 59 + this.LockTime.GetHashCode();
                if (this.RowsSent != null) hashCode = hashCode * 59 + this.RowsSent.GetHashCode();
                if (this.RowsExamined != null) hashCode = hashCode * 59 + this.RowsExamined.GetHashCode();
                if (this.Database != null) hashCode = hashCode * 59 + this.Database.GetHashCode();
                if (this.Users != null) hashCode = hashCode * 59 + this.Users.GetHashCode();
                if (this.QuerySample != null) hashCode = hashCode * 59 + this.QuerySample.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ClientIP != null) hashCode = hashCode * 59 + this.ClientIP.GetHashCode();
                return hashCode;
            }
        }
    }
}
