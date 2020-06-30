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
    public class CreateSubscriptionResponse : SdkResponse
    {

        /// <summary>
        /// 订阅ID，用于唯一标识一个订阅，在创建订阅时由物联网平台分配获得。
        /// </summary>
        [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public Subject Subject { get; set; }

        /// <summary>
        /// 订阅的回调地址，用于接收对应资源事件的通知消息。
        /// </summary>
        [JsonProperty("callbackurl", NullValueHandling = NullValueHandling.Ignore)]
        public string Callbackurl { get; set; }

        /// <summary>
        /// 物联网平台推送通知消息时使用的协议通道。使用“http”填充，表示该订阅推送协议通道为http(s)协议。
        /// </summary>
        [JsonProperty("channel", NullValueHandling = NullValueHandling.Ignore)]
        public string Channel { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSubscriptionResponse {\n");
            sb.Append("  subscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  subject: ").Append(Subject).Append("\n");
            sb.Append("  callbackurl: ").Append(Callbackurl).Append("\n");
            sb.Append("  channel: ").Append(Channel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSubscriptionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSubscriptionResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SubscriptionId == input.SubscriptionId ||
                    (this.SubscriptionId != null &&
                    this.SubscriptionId.Equals(input.SubscriptionId))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Callbackurl == input.Callbackurl ||
                    (this.Callbackurl != null &&
                    this.Callbackurl.Equals(input.Callbackurl))
                ) && 
                (
                    this.Channel == input.Channel ||
                    (this.Channel != null &&
                    this.Channel.Equals(input.Channel))
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
                if (this.SubscriptionId != null)
                    hashCode = hashCode * 59 + this.SubscriptionId.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Callbackurl != null)
                    hashCode = hashCode * 59 + this.Callbackurl.GetHashCode();
                if (this.Channel != null)
                    hashCode = hashCode * 59 + this.Channel.GetHashCode();
                return hashCode;
            }
        }
    }
}
