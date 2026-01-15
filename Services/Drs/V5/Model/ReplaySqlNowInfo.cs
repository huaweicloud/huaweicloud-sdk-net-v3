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
    /// 正在回放的sql信息
    /// </summary>
    public class ReplaySqlNowInfo 
    {

        /// <summary>
        /// 会话id
        /// </summary>
        [JsonProperty("thread_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? ThreadId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("modified_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? ModifiedAt { get; set; }

        /// <summary>
        /// 分片id
        /// </summary>
        [JsonProperty("shard_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? ShardId { get; set; }

        /// <summary>
        /// schema名称
        /// </summary>
        [JsonProperty("schema_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemaName { get; set; }

        /// <summary>
        /// sql语句
        /// </summary>
        [JsonProperty("sql_statement", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlStatement { get; set; }

        /// <summary>
        /// 原始耗时
        /// </summary>
        [JsonProperty("latency", NullValueHandling = NullValueHandling.Ignore)]
        public long? Latency { get; set; }

        /// <summary>
        /// 执行耗时
        /// </summary>
        [JsonProperty("execute_latency", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExecuteLatency { get; set; }

        /// <summary>
        /// 目标库类型
        /// </summary>
        [JsonProperty("target_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetType { get; set; }

        /// <summary>
        /// 目标库标识
        /// </summary>
        [JsonProperty("target_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetName { get; set; }

        /// <summary>
        /// 回放状态。取值： - running：执行中。 - finish：已完成。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReplaySqlNowInfo {\n");
            sb.Append("  threadId: ").Append(ThreadId).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  modifiedAt: ").Append(ModifiedAt).Append("\n");
            sb.Append("  shardId: ").Append(ShardId).Append("\n");
            sb.Append("  schemaName: ").Append(SchemaName).Append("\n");
            sb.Append("  sqlStatement: ").Append(SqlStatement).Append("\n");
            sb.Append("  latency: ").Append(Latency).Append("\n");
            sb.Append("  executeLatency: ").Append(ExecuteLatency).Append("\n");
            sb.Append("  targetType: ").Append(TargetType).Append("\n");
            sb.Append("  targetName: ").Append(TargetName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReplaySqlNowInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReplaySqlNowInfo input)
        {
            if (input == null) return false;
            if (this.ThreadId != input.ThreadId || (this.ThreadId != null && !this.ThreadId.Equals(input.ThreadId))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.ModifiedAt != input.ModifiedAt || (this.ModifiedAt != null && !this.ModifiedAt.Equals(input.ModifiedAt))) return false;
            if (this.ShardId != input.ShardId || (this.ShardId != null && !this.ShardId.Equals(input.ShardId))) return false;
            if (this.SchemaName != input.SchemaName || (this.SchemaName != null && !this.SchemaName.Equals(input.SchemaName))) return false;
            if (this.SqlStatement != input.SqlStatement || (this.SqlStatement != null && !this.SqlStatement.Equals(input.SqlStatement))) return false;
            if (this.Latency != input.Latency || (this.Latency != null && !this.Latency.Equals(input.Latency))) return false;
            if (this.ExecuteLatency != input.ExecuteLatency || (this.ExecuteLatency != null && !this.ExecuteLatency.Equals(input.ExecuteLatency))) return false;
            if (this.TargetType != input.TargetType || (this.TargetType != null && !this.TargetType.Equals(input.TargetType))) return false;
            if (this.TargetName != input.TargetName || (this.TargetName != null && !this.TargetName.Equals(input.TargetName))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                if (this.ThreadId != null) hashCode = hashCode * 59 + this.ThreadId.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.ModifiedAt != null) hashCode = hashCode * 59 + this.ModifiedAt.GetHashCode();
                if (this.ShardId != null) hashCode = hashCode * 59 + this.ShardId.GetHashCode();
                if (this.SchemaName != null) hashCode = hashCode * 59 + this.SchemaName.GetHashCode();
                if (this.SqlStatement != null) hashCode = hashCode * 59 + this.SqlStatement.GetHashCode();
                if (this.Latency != null) hashCode = hashCode * 59 + this.Latency.GetHashCode();
                if (this.ExecuteLatency != null) hashCode = hashCode * 59 + this.ExecuteLatency.GetHashCode();
                if (this.TargetType != null) hashCode = hashCode * 59 + this.TargetType.GetHashCode();
                if (this.TargetName != null) hashCode = hashCode * 59 + this.TargetName.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
