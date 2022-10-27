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
    /// Response Object
    /// </summary>
    public class ShowDeviceMessageResponse : SdkResponse
    {

        /// <summary>
        /// 设备消息ID，用于唯一标识一条消息，在下发设备消息时由物联网平台分配获得。
        /// </summary>
        [JsonProperty("message_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageId { get; set; }

        /// <summary>
        /// 消息名称,在下发消息时由用户指定。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 消息内容。 
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public Object Message { get; set; }

        /// <summary>
        /// 消息内容编码格式，取值范围none|base64,默认值none, base64格式仅支持透传。 
        /// </summary>
        [JsonProperty("encoding", NullValueHandling = NullValueHandling.Ignore)]
        public string Encoding { get; set; }

        /// <summary>
        /// 有效负载格式，在消息内容编码格式为none时有效，取值范围standard|raw，默认值standard（平台封装的标准格式），取值为raw时直接将消息内容作为有效负载下发。 
        /// </summary>
        [JsonProperty("payload_format", NullValueHandling = NullValueHandling.Ignore)]
        public string PayloadFormat { get; set; }

        /// <summary>
        /// 消息topic
        /// </summary>
        [JsonProperty("topic", NullValueHandling = NullValueHandling.Ignore)]
        public string Topic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public PropertiesDTO Properties { get; set; }

        /// <summary>
        /// 消息状态，包含PENDING，DELIVERED，FAILED和TIMEOUT，PENDING指设备不在线，消息被缓存起来，等设备上线之后下发； DELIVERED指消息发送成功；FAILED消息发送失败；TIMEOUT指消息在平台默认时间内（1天）还没有下发送给设备，则平台会将消息设置为超时，状态为TIMEOUT。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("error_info", NullValueHandling = NullValueHandling.Ignore)]
        public ErrorInfoDTO ErrorInfo { get; set; }

        /// <summary>
        /// 消息的创建时间，\&quot;yyyyMMdd&#39;T&#39;HHmmss&#39;Z&#39;\&quot;格式的UTC字符串。
        /// </summary>
        [JsonProperty("created_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// 消息结束时间, \&quot;yyyyMMdd&#39;T&#39;HHmmss&#39;Z&#39;\&quot;格式的UTC字符串，包含消息转换到DELIVERED和TIMEOUT两个状态的时间。
        /// </summary>
        [JsonProperty("finished_time", NullValueHandling = NullValueHandling.Ignore)]
        public string FinishedTime { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDeviceMessageResponse {\n");
            sb.Append("  messageId: ").Append(MessageId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  encoding: ").Append(Encoding).Append("\n");
            sb.Append("  payloadFormat: ").Append(PayloadFormat).Append("\n");
            sb.Append("  topic: ").Append(Topic).Append("\n");
            sb.Append("  properties: ").Append(Properties).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  errorInfo: ").Append(ErrorInfo).Append("\n");
            sb.Append("  createdTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  finishedTime: ").Append(FinishedTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDeviceMessageResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDeviceMessageResponse input)
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
                    this.Properties == input.Properties ||
                    (this.Properties != null &&
                    this.Properties.Equals(input.Properties))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.ErrorInfo == input.ErrorInfo ||
                    (this.ErrorInfo != null &&
                    this.ErrorInfo.Equals(input.ErrorInfo))
                ) && 
                (
                    this.CreatedTime == input.CreatedTime ||
                    (this.CreatedTime != null &&
                    this.CreatedTime.Equals(input.CreatedTime))
                ) && 
                (
                    this.FinishedTime == input.FinishedTime ||
                    (this.FinishedTime != null &&
                    this.FinishedTime.Equals(input.FinishedTime))
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
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ErrorInfo != null)
                    hashCode = hashCode * 59 + this.ErrorInfo.GetHashCode();
                if (this.CreatedTime != null)
                    hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.FinishedTime != null)
                    hashCode = hashCode * 59 + this.FinishedTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
