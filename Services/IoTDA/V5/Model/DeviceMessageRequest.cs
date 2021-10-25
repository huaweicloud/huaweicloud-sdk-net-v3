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
    /// 
    /// </summary>
    public class DeviceMessageRequest 
    {

        /// <summary>
        /// **参数说明**：消息id，由用户生成（推荐使用UUID），同一个设备下唯一， 如果用户填写的id在设备下不唯一， 则接口返回错误。 **取值范围**：长度不超过100，只允许字母、数字、下划线（_）、连接符（-）的组合。
        /// </summary>
        [JsonProperty("message_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageId { get; set; }

        /// <summary>
        /// **参数说明**：消息名称。 **取值范围**：长度不超过128，只允许中文、字母、数字、以及_?&#39;#().,&amp;%@!-等字符的组合。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数说明**：消息内容，支持string和json格式。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public Object Message { get; set; }

        /// <summary>
        /// **参数说明**：消息内容编码格式。默认值none。 **取值范围**： - none  - base64：只能通过topic_full_name字段自定义的topic发送消息,否则会发送失败。
        /// </summary>
        [JsonProperty("encoding", NullValueHandling = NullValueHandling.Ignore)]
        public string Encoding { get; set; }

        /// <summary>
        /// **参数说明**：有效负载格式，在消息内容编码格式为none时有效。默认值standard（平台封装的标准格式）。 **取值范围**： - standard  - raw：时直接将消息内容作为有效负载下发， 注意： 取值为raw时，只能通过topic_full_name字段自定义的topic发送消息，否则会发送失败。
        /// </summary>
        [JsonProperty("payload_format", NullValueHandling = NullValueHandling.Ignore)]
        public string PayloadFormat { get; set; }

        /// <summary>
        /// **参数说明**：消息下行到设备的topic, 可选， 仅适用于MQTT协议接入的设备。 用户只能填写在租户产品界面配置的topic, 否则会校验不通过。 平台给消息topic添加的前缀为$oc/devices/{device_id}/user/， 用户可以在前缀的基础上增加自定义部分， 如增加messageDown，则平台拼接前缀后完整的topic为 $oc/devices/{device_id}/user/messageDown，其中device_id以实际设备的网关id替代。 如果用户指定该topic，消息会通过该topic下行到设备，如果用户不指定， 则消息通过系统默认的topic下行到设备,系统默认的topic格式为： $oc/devices/{device_id}/sys/messages/down。此字段与topic_full_name字段只可填写一个。
        /// </summary>
        [JsonProperty("topic", NullValueHandling = NullValueHandling.Ignore)]
        public string Topic { get; set; }

        /// <summary>
        /// **参数说明**：消息下行到设备的完整topic名称, 可选。用户需要下发用户自定义的topic给设备时，可以使用该参数指定完整的topic名称，物联网平台不校验该topic是否在平台定义，直接透传给设备。设备需要提前订阅该topic。此字段与topic字段只可填写一个。
        /// </summary>
        [JsonProperty("topic_full_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicFullName { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceMessageRequest {\n");
            sb.Append("  messageId: ").Append(MessageId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  encoding: ").Append(Encoding).Append("\n");
            sb.Append("  payloadFormat: ").Append(PayloadFormat).Append("\n");
            sb.Append("  topic: ").Append(Topic).Append("\n");
            sb.Append("  topicFullName: ").Append(TopicFullName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeviceMessageRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeviceMessageRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MessageId == input.MessageId ||
                    (this.MessageId != null &&
                    this.MessageId.Equals(input.MessageId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Encoding == input.Encoding ||
                    (this.Encoding != null &&
                    this.Encoding.Equals(input.Encoding))
                ) && 
                (
                    this.PayloadFormat == input.PayloadFormat ||
                    (this.PayloadFormat != null &&
                    this.PayloadFormat.Equals(input.PayloadFormat))
                ) && 
                (
                    this.Topic == input.Topic ||
                    (this.Topic != null &&
                    this.Topic.Equals(input.Topic))
                ) && 
                (
                    this.TopicFullName == input.TopicFullName ||
                    (this.TopicFullName != null &&
                    this.TopicFullName.Equals(input.TopicFullName))
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
                if (this.MessageId != null)
                    hashCode = hashCode * 59 + this.MessageId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Encoding != null)
                    hashCode = hashCode * 59 + this.Encoding.GetHashCode();
                if (this.PayloadFormat != null)
                    hashCode = hashCode * 59 + this.PayloadFormat.GetHashCode();
                if (this.Topic != null)
                    hashCode = hashCode * 59 + this.Topic.GetHashCode();
                if (this.TopicFullName != null)
                    hashCode = hashCode * 59 + this.TopicFullName.GetHashCode();
                return hashCode;
            }
        }
    }
}
