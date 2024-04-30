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
    public class CreateConsumerGroupOrBatchDeleteConsumerGroupReq 
    {

        /// <summary>
        /// 待删除的消费组列表。
        /// </summary>
        [JsonProperty("groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Groups { get; set; }

        /// <summary>
        /// 消费组名称，只能由英文字母、数字、百分号、竖线、中划线、下划线组成，长度3~64个字符。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 关联的代理列表（仅RocketMQ实例4.8.0版本需要填写此参数）。
        /// </summary>
        [JsonProperty("brokers", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Brokers { get; set; }

        /// <summary>
        /// 是否广播。
        /// </summary>
        [JsonProperty("broadcast", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Broadcast { get; set; }

        /// <summary>
        /// 最大重试次数，取值范围为1~16。
        /// </summary>
        [JsonProperty("retry_max_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetryMaxTime { get; set; }

        /// <summary>
        /// 是否可以消费。
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 是否按序消费（仅RocketMQ实例5.x版本需要填写此参数）。
        /// </summary>
        [JsonProperty("consume_orderly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ConsumeOrderly { get; set; }

        /// <summary>
        /// 消费组描述，长度0~200个字符。
        /// </summary>
        [JsonProperty("group_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupDesc { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateConsumerGroupOrBatchDeleteConsumerGroupReq {\n");
            sb.Append("  groups: ").Append(Groups).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  brokers: ").Append(Brokers).Append("\n");
            sb.Append("  broadcast: ").Append(Broadcast).Append("\n");
            sb.Append("  retryMaxTime: ").Append(RetryMaxTime).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  consumeOrderly: ").Append(ConsumeOrderly).Append("\n");
            sb.Append("  groupDesc: ").Append(GroupDesc).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateConsumerGroupOrBatchDeleteConsumerGroupReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateConsumerGroupOrBatchDeleteConsumerGroupReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    input.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Brokers == input.Brokers ||
                    this.Brokers != null &&
                    input.Brokers != null &&
                    this.Brokers.SequenceEqual(input.Brokers)
                ) && 
                (
                    this.Broadcast == input.Broadcast ||
                    (this.Broadcast != null &&
                    this.Broadcast.Equals(input.Broadcast))
                ) && 
                (
                    this.RetryMaxTime == input.RetryMaxTime ||
                    (this.RetryMaxTime != null &&
                    this.RetryMaxTime.Equals(input.RetryMaxTime))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.ConsumeOrderly == input.ConsumeOrderly ||
                    (this.ConsumeOrderly != null &&
                    this.ConsumeOrderly.Equals(input.ConsumeOrderly))
                ) && 
                (
                    this.GroupDesc == input.GroupDesc ||
                    (this.GroupDesc != null &&
                    this.GroupDesc.Equals(input.GroupDesc))
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
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Brokers != null)
                    hashCode = hashCode * 59 + this.Brokers.GetHashCode();
                if (this.Broadcast != null)
                    hashCode = hashCode * 59 + this.Broadcast.GetHashCode();
                if (this.RetryMaxTime != null)
                    hashCode = hashCode * 59 + this.RetryMaxTime.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.ConsumeOrderly != null)
                    hashCode = hashCode * 59 + this.ConsumeOrderly.GetHashCode();
                if (this.GroupDesc != null)
                    hashCode = hashCode * 59 + this.GroupDesc.GetHashCode();
                return hashCode;
            }
        }
    }
}
