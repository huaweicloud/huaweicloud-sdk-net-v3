using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ConsumerGroup 
    {

        /// <summary>
        /// 是否可以消费。
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 是否广播。
        /// </summary>
        [JsonProperty("broadcast", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Broadcast { get; set; }

        /// <summary>
        /// 关联的代理列表。
        /// </summary>
        [JsonProperty("brokers", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Brokers { get; set; }

        /// <summary>
        /// 消费组名称，只能由英文字母、数字、百分号、竖线、中划线、下划线组成，长度3~64个字符。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 最大重试次数。
        /// </summary>
        [JsonProperty("retry_max_time", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? RetryMaxTime { get; set; }

        /// <summary>
        /// 是否重头消费。
        /// </summary>
        [JsonProperty("from_beginning", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FromBeginning { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsumerGroup {\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  broadcast: ").Append(Broadcast).Append("\n");
            sb.Append("  brokers: ").Append(Brokers).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  retryMaxTime: ").Append(RetryMaxTime).Append("\n");
            sb.Append("  fromBeginning: ").Append(FromBeginning).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConsumerGroup);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConsumerGroup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.Broadcast == input.Broadcast ||
                    (this.Broadcast != null &&
                    this.Broadcast.Equals(input.Broadcast))
                ) && 
                (
                    this.Brokers == input.Brokers ||
                    this.Brokers != null &&
                    input.Brokers != null &&
                    this.Brokers.SequenceEqual(input.Brokers)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.RetryMaxTime == input.RetryMaxTime ||
                    (this.RetryMaxTime != null &&
                    this.RetryMaxTime.Equals(input.RetryMaxTime))
                ) && 
                (
                    this.FromBeginning == input.FromBeginning ||
                    (this.FromBeginning != null &&
                    this.FromBeginning.Equals(input.FromBeginning))
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
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Broadcast != null)
                    hashCode = hashCode * 59 + this.Broadcast.GetHashCode();
                if (this.Brokers != null)
                    hashCode = hashCode * 59 + this.Brokers.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RetryMaxTime != null)
                    hashCode = hashCode * 59 + this.RetryMaxTime.GetHashCode();
                if (this.FromBeginning != null)
                    hashCode = hashCode * 59 + this.FromBeginning.GetHashCode();
                return hashCode;
            }
        }
    }
}
