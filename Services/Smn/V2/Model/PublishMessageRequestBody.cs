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
        /// 消息标题，给邮箱订阅者发送邮件时作为邮件主题，长度不能超过512个字节。
        /// </summary>
        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public string Subject { get; set; }

        /// <summary>
        /// 发送的消息。消息体必须是UTF-8编码的字符串，大小至多256KB。如果订阅者是手机号码，短信长度限制为490字，超出则可能被运营商拦截。短信内容不能包含“[]”或者“【】”符号。 说明： 三种消息发送方式：message、message_structure、message_template_name  至少设置其中一个，如果同时设置，生效的优先级为 message_structure &gt; message_template_name &gt; message。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// Json格式的字符串。支持“email”、“sms”、“http”、“https”、“functiongraph”、“functionstage”、“dingding”、“wechat”、“feishu”、“welink”、“dingTalkBot”。必须设置默认的消息“default”，当匹配不到消息协议时，按“default”中的内容发送。  - 其中，钉钉、微信、飞书、welink、dingTalkBot协议类型的消息需指定msgType字段；钉钉，微信和飞书机器人协议支持msgType为text（纯文本）和markdown（MD）格式消息，welink机器人类型暂仅支持msgType为text的纯文本消息。   - 企业微信机器人对消息长度的限制请参考[官方文档](https://developer.work.weixin.qq.com/document/path/91770)。  - 钉钉机器人协议支持通过at字段实现@群组成员。当您需要@群成员时，可以在isAtAll字段中传入布尔值，表示是否需要@群组内所有人。您可以在atMobiles字段中传入需要@的人的手机号列表，或在atUserIds字段中传入需要@的钉钉userID列表。当您使用atMobiles字段或atUserIds字段时，需要在消息内容中同时传入@对应手机号或userID的信息。展示效果请参考钉钉[官方文档](https://open.dingtalk.com/document/orgapp/custom-robots-send-group-messages)。钉钉群机器人消息限制在20000bytes以内，详情请参考[钉钉官方文档](https://open.dingtalk.com/document/orgapp/custom-robot-access)描述。  - 飞书机器人协议的markdown消息支持通过传入color字段设置标题的底色。能够支持的color字段可参考飞书[官方文档](https://open.feishu.cn/document/common-capabilities/message-card/message-cards-content/card-header)。飞书群机器人消息限制在30KB以内，详情请参考[飞书官方文档](https://feishu.apifox.cn/doc-1944903)描述。   - 个人钉钉消息对长度的限制请参考[官方文档](https://open.dingtalk.com/document/orgapp/the-robot-sends-a-group-message)。  说明： 三种消息发送方式：message、message_structure、message_template_name  至少设置其中一个，如果同时设置，生效的优先级为 message_structure &gt; message_template_name &gt; message。
        /// </summary>
        [JsonProperty("message_structure", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageStructure { get; set; }

        /// <summary>
        /// 消息模板名称，可通过[查询消息模板列表](ListMessageTemplates.xml)获取名称。  说明： 三种消息发送方式：message、message_structure、message_template_name  至少设置其中一个，如果同时设置，生效的优先级为 message_structure &gt; message_template_name &gt; message。
        /// </summary>
        [JsonProperty("message_template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageTemplateName { get; set; }

        /// <summary>
        /// tag以及替换tag的参数组成的字典。消息模板中的标签对应的值。使用消息模板方式的消息发布必须携带该参数。字典中的key为消息模板中的参数名称，不超过21个字符。字典中的value为消息模板中的参数被替换后的值，不超过1KB。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// 指消息在SMN系统内部的最长存留时间。超过该存留时间，系统将不再发送该消息。单位是s，变量默认值是3600s，即一小时。值为正整数且小于等于3600*24。
        /// </summary>
        [JsonProperty("time_to_live", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeToLive { get; set; }

        /// <summary>
        /// 消息属性列表
        /// </summary>
        [JsonProperty("message_attributes", NullValueHandling = NullValueHandling.Ignore)]
        public List<MessageAttribute> MessageAttributes { get; set; }

        /// <summary>
        /// 语言，发送出去的消息中SMN附加系统内容的语言，若没传入，使用账号的语言。取值范围是该局点支持的语言，比如：zh-cn,en-us等
        /// </summary>
        [JsonProperty("locale", NullValueHandling = NullValueHandling.Ignore)]
        public string Locale { get; set; }



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
            sb.Append("  messageAttributes: ").Append(MessageAttributes).Append("\n");
            sb.Append("  locale: ").Append(Locale).Append("\n");
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
            if (input == null) return false;
            if (this.Subject != input.Subject || (this.Subject != null && !this.Subject.Equals(input.Subject))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.MessageStructure != input.MessageStructure || (this.MessageStructure != null && !this.MessageStructure.Equals(input.MessageStructure))) return false;
            if (this.MessageTemplateName != input.MessageTemplateName || (this.MessageTemplateName != null && !this.MessageTemplateName.Equals(input.MessageTemplateName))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.TimeToLive != input.TimeToLive || (this.TimeToLive != null && !this.TimeToLive.Equals(input.TimeToLive))) return false;
            if (this.MessageAttributes != input.MessageAttributes || (this.MessageAttributes != null && input.MessageAttributes != null && !this.MessageAttributes.SequenceEqual(input.MessageAttributes))) return false;
            if (this.Locale != input.Locale || (this.Locale != null && !this.Locale.Equals(input.Locale))) return false;

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
                if (this.Subject != null) hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.MessageStructure != null) hashCode = hashCode * 59 + this.MessageStructure.GetHashCode();
                if (this.MessageTemplateName != null) hashCode = hashCode * 59 + this.MessageTemplateName.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.TimeToLive != null) hashCode = hashCode * 59 + this.TimeToLive.GetHashCode();
                if (this.MessageAttributes != null) hashCode = hashCode * 59 + this.MessageAttributes.GetHashCode();
                if (this.Locale != null) hashCode = hashCode * 59 + this.Locale.GetHashCode();
                return hashCode;
            }
        }
    }
}
