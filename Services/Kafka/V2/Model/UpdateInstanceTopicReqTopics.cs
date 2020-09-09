using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// 修改的topic。
    /// </summary>
    public class UpdateInstanceTopicReqTopics 
    {

        /// <summary>
        /// topic名称
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 老化时间，单位小时。
        /// </summary>
        [JsonProperty("retention_time", NullValueHandling = NullValueHandling.Ignore)]
        public string RetentionTime { get; set; }

        /// <summary>
        /// 是否同步复制。
        /// </summary>
        [JsonProperty("sync_replication", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncReplication { get; set; }

        /// <summary>
        /// 是否同步落盘。
        /// </summary>
        [JsonProperty("sync_message_flush", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncMessageFlush { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateInstanceTopicReqTopics {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  retentionTime: ").Append(RetentionTime).Append("\n");
            sb.Append("  syncReplication: ").Append(SyncReplication).Append("\n");
            sb.Append("  syncMessageFlush: ").Append(SyncMessageFlush).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateInstanceTopicReqTopics);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateInstanceTopicReqTopics input)
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
                    this.RetentionTime == input.RetentionTime ||
                    (this.RetentionTime != null &&
                    this.RetentionTime.Equals(input.RetentionTime))
                ) && 
                (
                    this.SyncReplication == input.SyncReplication ||
                    (this.SyncReplication != null &&
                    this.SyncReplication.Equals(input.SyncReplication))
                ) && 
                (
                    this.SyncMessageFlush == input.SyncMessageFlush ||
                    (this.SyncMessageFlush != null &&
                    this.SyncMessageFlush.Equals(input.SyncMessageFlush))
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
                if (this.RetentionTime != null)
                    hashCode = hashCode * 59 + this.RetentionTime.GetHashCode();
                if (this.SyncReplication != null)
                    hashCode = hashCode * 59 + this.SyncReplication.GetHashCode();
                if (this.SyncMessageFlush != null)
                    hashCode = hashCode * 59 + this.SyncMessageFlush.GetHashCode();
                return hashCode;
            }
        }
    }
}
