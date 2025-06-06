using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Smn.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BatchAddSubscriptionsRequestBody 
    {

        /// <summary>
        /// 不同协议对应不同的endpoint（接受消息的接入点）。 目前支持的协议包括：  “email”：邮件传输协议，endpoint为邮箱地址。  “sms”：短信传输协议，endpoint为手机号码。  “functionstage”：FunctionGraph（函数）传输协议，endpoint为一个函数。  “functiongraph”：FunctionGraph（工作流）传输协议，endpoint为由一组函数编排成的工作流。  “http”、“https”：HTTP/HTTPS传输协议，endpoint为URL。  “callnotify”：语音通知传输协议，endpoint为手机号码。  “wechat”：微信群机器人传输协议。  “dingding”：钉钉群机器人传输协议。  “feishu”：飞书群机器人传输协议。  “welink”：welink群机器人传输协议。
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }

        /// <summary>
        /// 说明：  http协议，接入点必须以“http://”开头。  https协议，接入点必须以“https://”开头。  email协议，接入点必须是邮件地址。  sms协议，接入点必须是一个电话号码。  functionstage协议，接入点必须是一个函数。  functiongraph协议，接入点必须是一个函数工作流。  callnotify协议，接入点必须是一个电话号码。  dingding协议，接入点必须是一个钉钉自定义群机器人的地址，或添加了钉钉企业内部机器人的群组openConversationId。添加钉钉企业内部机器人对应的群组openConversationId时，该字段不能以“http://”或“https://”为开头。  wechat协议，接入点必须是一个微信群机器人的地址。  feishu协议，接入点必须是一个飞书群机器人的地址。  welink协议，接入点必须是一个welink的群号。
        /// </summary>
        [JsonProperty("endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string Endpoint { get; set; }

        /// <summary>
        /// 备注。最大支持128字节，约42个中文，必须是UTF-8编码的字符串，否则无法正常显示中文。
        /// </summary>
        [JsonProperty("remark", NullValueHandling = NullValueHandling.Ignore)]
        public string Remark { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extension", NullValueHandling = NullValueHandling.Ignore)]
        public SubscriptionExtension Extension { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchAddSubscriptionsRequestBody {\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  remark: ").Append(Remark).Append("\n");
            sb.Append("  extension: ").Append(Extension).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchAddSubscriptionsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchAddSubscriptionsRequestBody input)
        {
            if (input == null) return false;
            if (this.Protocol != input.Protocol || (this.Protocol != null && !this.Protocol.Equals(input.Protocol))) return false;
            if (this.Endpoint != input.Endpoint || (this.Endpoint != null && !this.Endpoint.Equals(input.Endpoint))) return false;
            if (this.Remark != input.Remark || (this.Remark != null && !this.Remark.Equals(input.Remark))) return false;
            if (this.Extension != input.Extension || (this.Extension != null && !this.Extension.Equals(input.Extension))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.Protocol != null) hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.Endpoint != null) hashCode = hashCode * 59 + this.Endpoint.GetHashCode();
                if (this.Remark != null) hashCode = hashCode * 59 + this.Remark.GetHashCode();
                if (this.Extension != null) hashCode = hashCode * 59 + this.Extension.GetHashCode();
                return hashCode;
            }
        }
    }
}
