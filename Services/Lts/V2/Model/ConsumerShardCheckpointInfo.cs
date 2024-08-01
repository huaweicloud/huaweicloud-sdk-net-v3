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
    public class ConsumerShardCheckpointInfo 
    {

        /// <summary>
        /// 日志Shard ID
        /// </summary>
        [JsonProperty("shard_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ShardId { get; set; }

        /// <summary>
        /// 游标值
        /// </summary>
        [JsonProperty("checkpoint", NullValueHandling = NullValueHandling.Ignore)]
        public long? Checkpoint { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsumerShardCheckpointInfo {\n");
            sb.Append("  shardId: ").Append(ShardId).Append("\n");
            sb.Append("  checkpoint: ").Append(Checkpoint).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConsumerShardCheckpointInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConsumerShardCheckpointInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ShardId == input.ShardId ||
                    (this.ShardId != null &&
                    this.ShardId.Equals(input.ShardId))
                ) && 
                (
                    this.Checkpoint == input.Checkpoint ||
                    (this.Checkpoint != null &&
                    this.Checkpoint.Equals(input.Checkpoint))
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
                if (this.ShardId != null)
                    hashCode = hashCode * 59 + this.ShardId.GetHashCode();
                if (this.Checkpoint != null)
                    hashCode = hashCode * 59 + this.Checkpoint.GetHashCode();
                return hashCode;
            }
        }
    }
}
