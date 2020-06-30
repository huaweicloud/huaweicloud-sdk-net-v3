using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 转发kafka消息结构
    /// </summary>
    public class ActionKafkaForwarding 
    {

        /// <summary>
        /// 转发kafka消息对应的region区域
        /// </summary>
        [JsonProperty("region_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionName { get; set; }

        /// <summary>
        /// 转发kafka消息对应的projectId信息
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 转发kafka消息对应的地址列表
        /// </summary>
        [JsonProperty("kafka_addresses", NullValueHandling = NullValueHandling.Ignore)]
        public List<NetAddress> KafkaAddresses { get; set; }

        /// <summary>
        /// 转发kafka消息关联的topic信息。
        /// </summary>
        [JsonProperty("kafka_topic", NullValueHandling = NullValueHandling.Ignore)]
        public string KafkaTopic { get; set; }

        /// <summary>
        /// 转发kafka关联的用户名信息。
        /// </summary>
        [JsonProperty("kafka_username", NullValueHandling = NullValueHandling.Ignore)]
        public string KafkaUsername { get; set; }

        /// <summary>
        /// 转发kafka关联的密码信息。
        /// </summary>
        [JsonProperty("kafka_password", NullValueHandling = NullValueHandling.Ignore)]
        public string KafkaPassword { get; set; }

        /// <summary>
        /// 转发kafka关联的鉴权机制。 类型说明： PAAS：非SASL鉴权。 PLAIN：SASL/PLAIN模式。需要填写对应的用户名密码信息。 
        /// </summary>
        [JsonProperty("kafka_mechanism", NullValueHandling = NullValueHandling.Ignore)]
        public string KafkaMechanism { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionKafkaForwarding {\n");
            sb.Append("  regionName: ").Append(RegionName).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  kafkaAddresses: ").Append(KafkaAddresses).Append("\n");
            sb.Append("  kafkaTopic: ").Append(KafkaTopic).Append("\n");
            sb.Append("  kafkaUsername: ").Append(KafkaUsername).Append("\n");
            sb.Append("  kafkaPassword: ").Append(KafkaPassword).Append("\n");
            sb.Append("  kafkaMechanism: ").Append(KafkaMechanism).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ActionKafkaForwarding);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ActionKafkaForwarding input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RegionName == input.RegionName ||
                    (this.RegionName != null &&
                    this.RegionName.Equals(input.RegionName))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.KafkaAddresses == input.KafkaAddresses ||
                    this.KafkaAddresses != null &&
                    input.KafkaAddresses != null &&
                    this.KafkaAddresses.SequenceEqual(input.KafkaAddresses)
                ) && 
                (
                    this.KafkaTopic == input.KafkaTopic ||
                    (this.KafkaTopic != null &&
                    this.KafkaTopic.Equals(input.KafkaTopic))
                ) && 
                (
                    this.KafkaUsername == input.KafkaUsername ||
                    (this.KafkaUsername != null &&
                    this.KafkaUsername.Equals(input.KafkaUsername))
                ) && 
                (
                    this.KafkaPassword == input.KafkaPassword ||
                    (this.KafkaPassword != null &&
                    this.KafkaPassword.Equals(input.KafkaPassword))
                ) && 
                (
                    this.KafkaMechanism == input.KafkaMechanism ||
                    (this.KafkaMechanism != null &&
                    this.KafkaMechanism.Equals(input.KafkaMechanism))
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
                if (this.RegionName != null)
                    hashCode = hashCode * 59 + this.RegionName.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.KafkaAddresses != null)
                    hashCode = hashCode * 59 + this.KafkaAddresses.GetHashCode();
                if (this.KafkaTopic != null)
                    hashCode = hashCode * 59 + this.KafkaTopic.GetHashCode();
                if (this.KafkaUsername != null)
                    hashCode = hashCode * 59 + this.KafkaUsername.GetHashCode();
                if (this.KafkaPassword != null)
                    hashCode = hashCode * 59 + this.KafkaPassword.GetHashCode();
                if (this.KafkaMechanism != null)
                    hashCode = hashCode * 59 + this.KafkaMechanism.GetHashCode();
                return hashCode;
            }
        }
    }
}
