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
    /// 结构化类型。
    /// </summary>
    public class ShowStructTemplateclusterInfo 
    {

        /// <summary>
        /// 测试
        /// </summary>
        [JsonProperty("cluster_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterName { get; set; }

        /// <summary>
        /// 测试
        /// </summary>
        [JsonProperty("kafka_bootstrap_servers", NullValueHandling = NullValueHandling.Ignore)]
        public string KafkaBootstrapServers { get; set; }

        /// <summary>
        /// 测试
        /// </summary>
        [JsonProperty("kafka_ssl_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? KafkaSslEnable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowStructTemplateclusterInfo {\n");
            sb.Append("  clusterName: ").Append(ClusterName).Append("\n");
            sb.Append("  kafkaBootstrapServers: ").Append(KafkaBootstrapServers).Append("\n");
            sb.Append("  kafkaSslEnable: ").Append(KafkaSslEnable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowStructTemplateclusterInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowStructTemplateclusterInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterName == input.ClusterName ||
                    (this.ClusterName != null &&
                    this.ClusterName.Equals(input.ClusterName))
                ) && 
                (
                    this.KafkaBootstrapServers == input.KafkaBootstrapServers ||
                    (this.KafkaBootstrapServers != null &&
                    this.KafkaBootstrapServers.Equals(input.KafkaBootstrapServers))
                ) && 
                (
                    this.KafkaSslEnable == input.KafkaSslEnable ||
                    (this.KafkaSslEnable != null &&
                    this.KafkaSslEnable.Equals(input.KafkaSslEnable))
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
                if (this.ClusterName != null)
                    hashCode = hashCode * 59 + this.ClusterName.GetHashCode();
                if (this.KafkaBootstrapServers != null)
                    hashCode = hashCode * 59 + this.KafkaBootstrapServers.GetHashCode();
                if (this.KafkaSslEnable != null)
                    hashCode = hashCode * 59 + this.KafkaSslEnable.GetHashCode();
                return hashCode;
            }
        }
    }
}
