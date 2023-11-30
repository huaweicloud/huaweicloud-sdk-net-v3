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
    /// 慢日志单个条目
    /// </summary>
    public class SlowlogItem 
    {

        /// <summary>
        /// 慢日志的唯一标识
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 慢命令
        /// </summary>
        [JsonProperty("command", NullValueHandling = NullValueHandling.Ignore)]
        public string Command { get; set; }

        /// <summary>
        /// 执行开始时间,格式为“2020-06-19T07:06:07Z”
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 持续时间，单位是ms
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public string Duration { get; set; }

        /// <summary>
        /// 慢命令所在的分片名称，仅在实例类型为集群时支持
        /// </summary>
        [JsonProperty("shard_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ShardName { get; set; }

        /// <summary>
        /// 数据库id，当前只对指定客户开放
        /// </summary>
        [JsonProperty("database_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? DatabaseId { get; set; }

        /// <summary>
        /// 操作慢日志的账号名称，当前只对指定客户开放
        /// </summary>
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SlowlogItem {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  command: ").Append(Command).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  shardName: ").Append(ShardName).Append("\n");
            sb.Append("  databaseId: ").Append(DatabaseId).Append("\n");
            sb.Append("  username: ").Append(Username).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SlowlogItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SlowlogItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Command == input.Command ||
                    (this.Command != null &&
                    this.Command.Equals(input.Command))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.ShardName == input.ShardName ||
                    (this.ShardName != null &&
                    this.ShardName.Equals(input.ShardName))
                ) && 
                (
                    this.DatabaseId == input.DatabaseId ||
                    (this.DatabaseId != null &&
                    this.DatabaseId.Equals(input.DatabaseId))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Command != null)
                    hashCode = hashCode * 59 + this.Command.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.ShardName != null)
                    hashCode = hashCode * 59 + this.ShardName.GetHashCode();
                if (this.DatabaseId != null)
                    hashCode = hashCode * 59 + this.DatabaseId.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                return hashCode;
            }
        }
    }
}
