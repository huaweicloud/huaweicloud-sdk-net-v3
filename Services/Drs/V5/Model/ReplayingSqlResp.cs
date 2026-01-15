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
    /// 正在回放的SQL信息
    /// </summary>
    public class ReplayingSqlResp 
    {

        /// <summary>
        /// 库名或shema名称
        /// </summary>
        [JsonProperty("schema_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemaName { get; set; }

        /// <summary>
        /// SQL语句
        /// </summary>
        [JsonProperty("sql_statement", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlStatement { get; set; }

        /// <summary>
        /// 原始执行耗时
        /// </summary>
        [JsonProperty("latency", NullValueHandling = NullValueHandling.Ignore)]
        public int? Latency { get; set; }

        /// <summary>
        /// 回放执行耗时
        /// </summary>
        [JsonProperty("execute_latency", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExecuteLatency { get; set; }

        /// <summary>
        /// 执行状态 取值：INIT，RUNNING，FAILED，PAUSE，SUCCESS，FINISHED
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 客户端IP
        /// </summary>
        [JsonProperty("client", NullValueHandling = NullValueHandling.Ignore)]
        public string Client { get; set; }

        /// <summary>
        /// 连接ID
        /// </summary>
        [JsonProperty("connection_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectionId { get; set; }

        /// <summary>
        /// 回放开始时间
        /// </summary>
        [JsonProperty("replay_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ReplayStartTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReplayingSqlResp {\n");
            sb.Append("  schemaName: ").Append(SchemaName).Append("\n");
            sb.Append("  sqlStatement: ").Append(SqlStatement).Append("\n");
            sb.Append("  latency: ").Append(Latency).Append("\n");
            sb.Append("  executeLatency: ").Append(ExecuteLatency).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  _Client: ").Append(Client).Append("\n");
            sb.Append("  connectionId: ").Append(ConnectionId).Append("\n");
            sb.Append("  replayStartTime: ").Append(ReplayStartTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReplayingSqlResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReplayingSqlResp input)
        {
            if (input == null) return false;
            if (this.SchemaName != input.SchemaName || (this.SchemaName != null && !this.SchemaName.Equals(input.SchemaName))) return false;
            if (this.SqlStatement != input.SqlStatement || (this.SqlStatement != null && !this.SqlStatement.Equals(input.SqlStatement))) return false;
            if (this.Latency != input.Latency || (this.Latency != null && !this.Latency.Equals(input.Latency))) return false;
            if (this.ExecuteLatency != input.ExecuteLatency || (this.ExecuteLatency != null && !this.ExecuteLatency.Equals(input.ExecuteLatency))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Client != input.Client || (this.Client != null && !this.Client.Equals(input.Client))) return false;
            if (this.ConnectionId != input.ConnectionId || (this.ConnectionId != null && !this.ConnectionId.Equals(input.ConnectionId))) return false;
            if (this.ReplayStartTime != input.ReplayStartTime || (this.ReplayStartTime != null && !this.ReplayStartTime.Equals(input.ReplayStartTime))) return false;

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
                if (this.SchemaName != null) hashCode = hashCode * 59 + this.SchemaName.GetHashCode();
                if (this.SqlStatement != null) hashCode = hashCode * 59 + this.SqlStatement.GetHashCode();
                if (this.Latency != null) hashCode = hashCode * 59 + this.Latency.GetHashCode();
                if (this.ExecuteLatency != null) hashCode = hashCode * 59 + this.ExecuteLatency.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Client != null) hashCode = hashCode * 59 + this.Client.GetHashCode();
                if (this.ConnectionId != null) hashCode = hashCode * 59 + this.ConnectionId.GetHashCode();
                if (this.ReplayStartTime != null) hashCode = hashCode * 59 + this.ReplayStartTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
