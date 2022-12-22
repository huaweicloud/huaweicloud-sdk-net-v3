using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dms.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SendMessageEntity 
    {

        /// <summary>
        /// 消息正文。
        /// </summary>
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public Object Body { get; set; }

        /// <summary>
        /// 属性列表，包含属性名称和属性值。  同一条消息的属性名称不可重复，否则属性值将被覆盖。 
        /// </summary>
        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Object Attributes { get; set; }

        /// <summary>
        /// 消息标签，即Label，是通过对消息增加Label来区分队列中的消息分类，DMS允许消费者按照Label对消息进行过滤，确保消费者最终只消费到他关心的消息类型。  消息标签只能包含a~z，A~Z，0-9，-，_，长度是[1，64]。  最多可添加3个标签。 
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public Object Tags { get; set; }

        /// <summary>
        /// 延时消息的延时时长。  延时消息是指消息发送到DMS服务后，并不期望这条消息立即被消费，而是延迟一段时间后才能被消费。  取值范围：0~604800000  单位：毫秒  不配置该参数或者配置为0，表示无延时。  配置为浮点数时，自动取小数点前面的整数值，比如配置为6000.9，则自动取值为6000。  仅NORMAL队列和FIFO队列可以设置延时消息，Kafka队列不支持延时消息的功能，如果向Kafka队列生产延时消息，提示{\&quot;code\&quot;:10540010, \&quot;message\&quot;:\&quot;Invalid request format: kafka queue message could not have delayTime.\&quot;}。 
        /// </summary>
        [JsonProperty("delay_time", NullValueHandling = NullValueHandling.Ignore)]
        public Object DelayTime { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendMessageEntity {\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("  attributes: ").Append(Attributes).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  delayTime: ").Append(DelayTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SendMessageEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SendMessageEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
                ) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.Equals(input.Tags))
                ) && 
                (
                    this.DelayTime == input.DelayTime ||
                    (this.DelayTime != null &&
                    this.DelayTime.Equals(input.DelayTime))
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
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.DelayTime != null)
                    hashCode = hashCode * 59 + this.DelayTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
