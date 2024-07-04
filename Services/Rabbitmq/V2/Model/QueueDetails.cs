using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rabbitmq.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class QueueDetails 
    {

        /// <summary>
        /// Queue所属Vhost名称
        /// </summary>
        [JsonProperty("vhost", NullValueHandling = NullValueHandling.Ignore)]
        public string Vhost { get; set; }

        /// <summary>
        /// Queue名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 是否持久化
        /// </summary>
        [JsonProperty("durable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Durable { get; set; }

        /// <summary>
        /// 是否自动删除
        /// </summary>
        [JsonProperty("auto_delete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoDelete { get; set; }

        /// <summary>
        /// 待消费消息数
        /// </summary>
        [JsonProperty("messages", NullValueHandling = NullValueHandling.Ignore)]
        public int? Messages { get; set; }

        /// <summary>
        /// 连接的消费者数
        /// </summary>
        [JsonProperty("consumers", NullValueHandling = NullValueHandling.Ignore)]
        public int? Consumers { get; set; }

        /// <summary>
        /// 策略（AMQP版本不支持policy，不涉及此参数）
        /// </summary>
        [JsonProperty("policy", NullValueHandling = NullValueHandling.Ignore)]
        public string Policy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("arguments", NullValueHandling = NullValueHandling.Ignore)]
        public QueueArguments Arguments { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueDetails {\n");
            sb.Append("  vhost: ").Append(Vhost).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  durable: ").Append(Durable).Append("\n");
            sb.Append("  autoDelete: ").Append(AutoDelete).Append("\n");
            sb.Append("  messages: ").Append(Messages).Append("\n");
            sb.Append("  consumers: ").Append(Consumers).Append("\n");
            sb.Append("  policy: ").Append(Policy).Append("\n");
            sb.Append("  arguments: ").Append(Arguments).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueueDetails);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueueDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Vhost == input.Vhost ||
                    (this.Vhost != null &&
                    this.Vhost.Equals(input.Vhost))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Durable == input.Durable ||
                    (this.Durable != null &&
                    this.Durable.Equals(input.Durable))
                ) && 
                (
                    this.AutoDelete == input.AutoDelete ||
                    (this.AutoDelete != null &&
                    this.AutoDelete.Equals(input.AutoDelete))
                ) && 
                (
                    this.Messages == input.Messages ||
                    (this.Messages != null &&
                    this.Messages.Equals(input.Messages))
                ) && 
                (
                    this.Consumers == input.Consumers ||
                    (this.Consumers != null &&
                    this.Consumers.Equals(input.Consumers))
                ) && 
                (
                    this.Policy == input.Policy ||
                    (this.Policy != null &&
                    this.Policy.Equals(input.Policy))
                ) && 
                (
                    this.Arguments == input.Arguments ||
                    (this.Arguments != null &&
                    this.Arguments.Equals(input.Arguments))
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
                if (this.Vhost != null)
                    hashCode = hashCode * 59 + this.Vhost.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Durable != null)
                    hashCode = hashCode * 59 + this.Durable.GetHashCode();
                if (this.AutoDelete != null)
                    hashCode = hashCode * 59 + this.AutoDelete.GetHashCode();
                if (this.Messages != null)
                    hashCode = hashCode * 59 + this.Messages.GetHashCode();
                if (this.Consumers != null)
                    hashCode = hashCode * 59 + this.Consumers.GetHashCode();
                if (this.Policy != null)
                    hashCode = hashCode * 59 + this.Policy.GetHashCode();
                if (this.Arguments != null)
                    hashCode = hashCode * 59 + this.Arguments.GetHashCode();
                return hashCode;
            }
        }
    }
}
