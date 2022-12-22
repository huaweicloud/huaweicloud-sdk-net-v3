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
    /// 
    /// </summary>
    public class CreateInstanceTopicReq 
    {

        /// <summary>
        /// topic名称，长度为4-64，以字母开头且只支持大小写字母、中横线、下划线以及数字。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 副本数，配置数据的可靠性。 取值范围：1-3。
        /// </summary>
        [JsonProperty("replication", NullValueHandling = NullValueHandling.Ignore)]
        public int? Replication { get; set; }

        /// <summary>
        /// 是否使用同步落盘。默认值为false。同步落盘会导致性能降低。
        /// </summary>
        [JsonProperty("sync_message_flush", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncMessageFlush { get; set; }

        /// <summary>
        /// topic分区数，设置消费的并发数。 取值范围：[1-100](tag:hc,hk,hws,hws_hk,otc,hws_ocb,ctc,sbc,hk_sbc)[1-20](tag:cmcc)。
        /// </summary>
        [JsonProperty("partition", NullValueHandling = NullValueHandling.Ignore)]
        public int? Partition { get; set; }

        /// <summary>
        /// 是否开启同步复制，开启后，客户端生产消息时相应的也要设置acks&#x3D;-1，否则不生效，默认关闭。
        /// </summary>
        [JsonProperty("sync_replication", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncReplication { get; set; }

        /// <summary>
        /// 消息老化时间。默认值为72。 取值范围[1~168](tag:hc,hk,hws,hws_hk,hws_ocb,ctc,sbc,hk_sbc,hws_eu)[1-720](tag:ocb,otc)，单位小时。
        /// </summary>
        [JsonProperty("retention_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetentionTime { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateInstanceTopicReq {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  replication: ").Append(Replication).Append("\n");
            sb.Append("  syncMessageFlush: ").Append(SyncMessageFlush).Append("\n");
            sb.Append("  partition: ").Append(Partition).Append("\n");
            sb.Append("  syncReplication: ").Append(SyncReplication).Append("\n");
            sb.Append("  retentionTime: ").Append(RetentionTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateInstanceTopicReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateInstanceTopicReq input)
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
                    this.Replication == input.Replication ||
                    (this.Replication != null &&
                    this.Replication.Equals(input.Replication))
                ) && 
                (
                    this.SyncMessageFlush == input.SyncMessageFlush ||
                    (this.SyncMessageFlush != null &&
                    this.SyncMessageFlush.Equals(input.SyncMessageFlush))
                ) && 
                (
                    this.Partition == input.Partition ||
                    (this.Partition != null &&
                    this.Partition.Equals(input.Partition))
                ) && 
                (
                    this.SyncReplication == input.SyncReplication ||
                    (this.SyncReplication != null &&
                    this.SyncReplication.Equals(input.SyncReplication))
                ) && 
                (
                    this.RetentionTime == input.RetentionTime ||
                    (this.RetentionTime != null &&
                    this.RetentionTime.Equals(input.RetentionTime))
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
                if (this.Replication != null)
                    hashCode = hashCode * 59 + this.Replication.GetHashCode();
                if (this.SyncMessageFlush != null)
                    hashCode = hashCode * 59 + this.SyncMessageFlush.GetHashCode();
                if (this.Partition != null)
                    hashCode = hashCode * 59 + this.Partition.GetHashCode();
                if (this.SyncReplication != null)
                    hashCode = hashCode * 59 + this.SyncReplication.GetHashCode();
                if (this.RetentionTime != null)
                    hashCode = hashCode * 59 + this.RetentionTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
