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
    /// 创建订阅请求结构体
    /// </summary>
    public class CreateSubReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public Subject Subject { get; set; }

        /// <summary>
        /// 订阅的回调地址，用于接收对应资源事件的通知消息，例如：https://10.10.10.10:443/callbackurltest。
        /// </summary>
        [JsonProperty("callbackurl", NullValueHandling = NullValueHandling.Ignore)]
        public string Callbackurl { get; set; }

        /// <summary>
        /// 资源空间ID。此参数为非必选参数，存在多资源空间的用户需要使用该接口时，建议携带该参数指定订阅哪个资源空间下的消息通知，否则订阅的消息通知将会归属到[默认资源空间](https://support.huaweicloud.com/usermanual-iothub/iot_01_0006.html#section0)下。
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

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
            sb.Append("class CreateSubReq {\n");
            sb.Append("  subject: ").Append(Subject).Append("\n");
            sb.Append("  callbackurl: ").Append(Callbackurl).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  channel: ").Append(Channel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSubReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSubReq input)
        {
            if (input == null)
                return false;

            return 
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
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
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
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Callbackurl != null)
                    hashCode = hashCode * 59 + this.Callbackurl.GetHashCode();
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.Channel != null)
                    hashCode = hashCode * 59 + this.Channel.GetHashCode();
                return hashCode;
            }
        }
    }
}
