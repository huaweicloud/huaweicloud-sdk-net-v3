using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class CreateRedislogRequest 
    {

        /// <summary>
        /// 实例ID。
        /// </summary>
        [SDKProperty("instance_id", IsPath = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 日期偏移量，表示从过去的n天开始查询，例如：传入0则表示查询今天的日志，传入7则表示查询过去7天的日志。最大支持0-7。
        /// </summary>
        [SDKProperty("query_time", IsQuery = true)]
        [JsonProperty("query_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? QueryTime { get; set; }

        /// <summary>
        /// 返回日志的类型，当前仅支持Redis运行日志，类型为run
        /// </summary>
        [SDKProperty("log_type", IsQuery = true)]
        [JsonProperty("log_type", NullValueHandling = NullValueHandling.Ignore)]
        public string LogType { get; set; }

        /// <summary>
        /// 副本ID，可以从分片与副本中查询对应节点的副本ID
        /// </summary>
        [SDKProperty("replication_id", IsQuery = true)]
        [JsonProperty("replication_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ReplicationId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRedislogRequest {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  queryTime: ").Append(QueryTime).Append("\n");
            sb.Append("  logType: ").Append(LogType).Append("\n");
            sb.Append("  replicationId: ").Append(ReplicationId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateRedislogRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateRedislogRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.QueryTime == input.QueryTime ||
                    (this.QueryTime != null &&
                    this.QueryTime.Equals(input.QueryTime))
                ) && 
                (
                    this.LogType == input.LogType ||
                    (this.LogType != null &&
                    this.LogType.Equals(input.LogType))
                ) && 
                (
                    this.ReplicationId == input.ReplicationId ||
                    (this.ReplicationId != null &&
                    this.ReplicationId.Equals(input.ReplicationId))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.QueryTime != null)
                    hashCode = hashCode * 59 + this.QueryTime.GetHashCode();
                if (this.LogType != null)
                    hashCode = hashCode * 59 + this.LogType.GetHashCode();
                if (this.ReplicationId != null)
                    hashCode = hashCode * 59 + this.ReplicationId.GetHashCode();
                return hashCode;
            }
        }
    }
}
