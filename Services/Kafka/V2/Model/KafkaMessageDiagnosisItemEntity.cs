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
    /// 消息积压诊断项
    /// </summary>
    public class KafkaMessageDiagnosisItemEntity 
    {

        /// <summary>
        /// 诊断项名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 诊断结果
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public string Result { get; set; }

        /// <summary>
        /// 诊断异常原因列表
        /// </summary>
        [JsonProperty("cause_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<KafkaMessageDiagnosisConclusionEntity> CauseIds { get; set; }

        /// <summary>
        /// 诊断异常建议列表
        /// </summary>
        [JsonProperty("advice_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<KafkaMessageDiagnosisConclusionEntity> AdviceIds { get; set; }

        /// <summary>
        /// 诊断异常受影响的分区列表
        /// </summary>
        [JsonProperty("partitions", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Partitions { get; set; }

        /// <summary>
        /// 诊断失败的分区列表
        /// </summary>
        [JsonProperty("failed_partitions", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> FailedPartitions { get; set; }

        /// <summary>
        /// 诊断异常受影响的broker列表
        /// </summary>
        [JsonProperty("broker_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> BrokerIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KafkaMessageDiagnosisItemEntity {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  causeIds: ").Append(CauseIds).Append("\n");
            sb.Append("  adviceIds: ").Append(AdviceIds).Append("\n");
            sb.Append("  partitions: ").Append(Partitions).Append("\n");
            sb.Append("  failedPartitions: ").Append(FailedPartitions).Append("\n");
            sb.Append("  brokerIds: ").Append(BrokerIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KafkaMessageDiagnosisItemEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KafkaMessageDiagnosisItemEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
                ) && 
                (
                    this.CauseIds == input.CauseIds ||
                    this.CauseIds != null &&
                    input.CauseIds != null &&
                    this.CauseIds.SequenceEqual(input.CauseIds)
                ) && 
                (
                    this.AdviceIds == input.AdviceIds ||
                    this.AdviceIds != null &&
                    input.AdviceIds != null &&
                    this.AdviceIds.SequenceEqual(input.AdviceIds)
                ) && 
                (
                    this.Partitions == input.Partitions ||
                    this.Partitions != null &&
                    input.Partitions != null &&
                    this.Partitions.SequenceEqual(input.Partitions)
                ) && 
                (
                    this.FailedPartitions == input.FailedPartitions ||
                    this.FailedPartitions != null &&
                    input.FailedPartitions != null &&
                    this.FailedPartitions.SequenceEqual(input.FailedPartitions)
                ) && 
                (
                    this.BrokerIds == input.BrokerIds ||
                    this.BrokerIds != null &&
                    input.BrokerIds != null &&
                    this.BrokerIds.SequenceEqual(input.BrokerIds)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.CauseIds != null)
                    hashCode = hashCode * 59 + this.CauseIds.GetHashCode();
                if (this.AdviceIds != null)
                    hashCode = hashCode * 59 + this.AdviceIds.GetHashCode();
                if (this.Partitions != null)
                    hashCode = hashCode * 59 + this.Partitions.GetHashCode();
                if (this.FailedPartitions != null)
                    hashCode = hashCode * 59 + this.FailedPartitions.GetHashCode();
                if (this.BrokerIds != null)
                    hashCode = hashCode * 59 + this.BrokerIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
