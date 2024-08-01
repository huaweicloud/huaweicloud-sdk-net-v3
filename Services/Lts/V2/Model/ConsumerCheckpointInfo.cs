using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ConsumerCheckpointInfo 
    {

        /// <summary>
        /// 游标值
        /// </summary>
        [JsonProperty("checkpoint", NullValueHandling = NullValueHandling.Ignore)]
        public long? Checkpoint { get; set; }

        /// <summary>
        /// 消费组名
        /// </summary>
        [JsonProperty("consumer_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumerGroupName { get; set; }

        /// <summary>
        /// 消费者名
        /// </summary>
        [JsonProperty("consumer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumerName { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 日志Shard ID
        /// </summary>
        [JsonProperty("shard_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ShardId { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsumerCheckpointInfo {\n");
            sb.Append("  checkpoint: ").Append(Checkpoint).Append("\n");
            sb.Append("  consumerGroupName: ").Append(ConsumerGroupName).Append("\n");
            sb.Append("  consumerName: ").Append(ConsumerName).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  shardId: ").Append(ShardId).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConsumerCheckpointInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConsumerCheckpointInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Checkpoint == input.Checkpoint ||
                    (this.Checkpoint != null &&
                    this.Checkpoint.Equals(input.Checkpoint))
                ) && 
                (
                    this.ConsumerGroupName == input.ConsumerGroupName ||
                    (this.ConsumerGroupName != null &&
                    this.ConsumerGroupName.Equals(input.ConsumerGroupName))
                ) && 
                (
                    this.ConsumerName == input.ConsumerName ||
                    (this.ConsumerName != null &&
                    this.ConsumerName.Equals(input.ConsumerName))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.ShardId == input.ShardId ||
                    (this.ShardId != null &&
                    this.ShardId.Equals(input.ShardId))
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    (this.UpdateTime != null &&
                    this.UpdateTime.Equals(input.UpdateTime))
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
                if (this.Checkpoint != null)
                    hashCode = hashCode * 59 + this.Checkpoint.GetHashCode();
                if (this.ConsumerGroupName != null)
                    hashCode = hashCode * 59 + this.ConsumerGroupName.GetHashCode();
                if (this.ConsumerName != null)
                    hashCode = hashCode * 59 + this.ConsumerName.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ShardId != null)
                    hashCode = hashCode * 59 + this.ShardId.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
