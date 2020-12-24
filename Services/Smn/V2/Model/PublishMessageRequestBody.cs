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
    public class PublishMessageRequestBody 
    {

        /// <summary>
        /// 消息标题，给邮箱订阅者发送邮件时作为邮件主题，长度不能超过512个字符。
        /// </summary>
        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public string Subject { get; set; }

        /// <summary>
        /// 发送的消息。消息体必须是UTF-8编码的字符串，大小至多256KB。如果订阅者是手机号码，长度不超过490个字符，超出部分系统自动截断。短信内容不能包含“[]”或者“【】”符号。  对于移动推送订阅者推送消息，message消息必须符合移动推送平台的消息格式，消息格式请参见application消息体格式。否则移动app无法收到消息，目前支持的平台有HMS、APNS、APNS_SANDBOX。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// Json格式的字符串。支持“email”、“sms”、 “http”、“https”、“dms”、“functiongraph”、“functionstage”、“HMS”、“APNS”以及“APNS_SANDBOX”。其中，“HMS”、“APNS”以及“APNS_SANDBOX”三种消息的格式请参见application消息体格式。必须设置默认的消息“default”，当匹配不到消息协议时，按“default”中的内容发送。  说明： 三种消息发送方式  message  message_structure  message_template_name  只需要设置其中一个，如果同时设置，生效的优先级为 message_structure &gt; message_template_name &gt; message。  华为透传消息  {   \&quot;hps\&quot;: {     \&quot;msg\&quot;: {       \&quot;type\&quot;: 1,       \&quot;body\&quot;: {         \&quot;key\&quot;: \&quot;value\&quot;       }     }   } }  华为系统通知栏消息  {   \&quot;hps\&quot;: {     \&quot;msg\&quot;: {       \&quot;type\&quot;: 3,       \&quot;body\&quot;: {         \&quot;content\&quot;: \&quot;Push message content\&quot;,         \&quot;title\&quot;: \&quot;Push message content\&quot;       },       \&quot;action\&quot;: {         \&quot;type\&quot;: 1,         \&quot;param\&quot;: {           \&quot;intent\&quot;: \&quot;#Intent;compo&#x3D;com.rvr/.Activity;S.W&#x3D;U;end\&quot;         }       }     },     \&quot;ext\&quot;: {       \&quot;biTag\&quot;: \&quot;Trump\&quot;,       \&quot;icon\&quot;: \&quot;http://upload.w.org/00/150pxsvg.png\&quot;     }   } }  苹果平台消息格式  {   \&quot;aps\&quot;: {     \&quot;alert\&quot;: \&quot;hello world\&quot;   } }
        /// </summary>
        [JsonProperty("message_structure", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageStructure { get; set; }

        /// <summary>
        /// 消息模板名称，可通过[查询消息模板列表](https://support.huaweicloud.com/api-smn/smn_api_53004.html)获取名称。  说明： 三种消息发送方式:  message  message_structure  message_template_name  只需要设置其中一个，如果同时设置，生效的优先级为 message_structure &gt; message_template_name &gt; message。
        /// </summary>
        [JsonProperty("message_template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageTemplateName { get; set; }

        /// <summary>
        /// tag以及替换tag的参数组成的字典。消息模板中的标签对应的值。使用消息模板方式的消息发布必须携带该参数。字典中的key为消息模板中的参数名称，不超过21个字符。字典中的value为消息模板中的参数被替换后的值，不超过1KB。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public Object Tags { get; set; }

        /// <summary>
        /// 指消息在SMN系统内部的最长存留时间。超过该存留时间，系统将不再发送该消息。单位是s，变量默认值是3600s，即一小时。值为正整数且小于等于3600*24。
        /// </summary>
        [JsonProperty("time_to_live", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeToLive { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublishMessageRequestBody {\n");
            sb.Append("  subject: ").Append(Subject).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  messageStructure: ").Append(MessageStructure).Append("\n");
            sb.Append("  messageTemplateName: ").Append(MessageTemplateName).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  timeToLive: ").Append(TimeToLive).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PublishMessageRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PublishMessageRequestBody input)
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
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.MessageStructure == input.MessageStructure ||
                    (this.MessageStructure != null &&
                    this.MessageStructure.Equals(input.MessageStructure))
                ) && 
                (
                    this.MessageTemplateName == input.MessageTemplateName ||
                    (this.MessageTemplateName != null &&
                    this.MessageTemplateName.Equals(input.MessageTemplateName))
                ) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.Equals(input.Tags))
                ) && 
                (
                    this.TimeToLive == input.TimeToLive ||
                    (this.TimeToLive != null &&
                    this.TimeToLive.Equals(input.TimeToLive))
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
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.MessageStructure != null)
                    hashCode = hashCode * 59 + this.MessageStructure.GetHashCode();
                if (this.MessageTemplateName != null)
                    hashCode = hashCode * 59 + this.MessageTemplateName.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.TimeToLive != null)
                    hashCode = hashCode * 59 + this.TimeToLive.GetHashCode();
                return hashCode;
            }
        }
    }
}
