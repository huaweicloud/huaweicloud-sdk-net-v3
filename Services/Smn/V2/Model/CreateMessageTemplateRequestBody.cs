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
    public class CreateMessageTemplateRequestBody 
    {

        /// <summary>
        /// 创建模板的名称。只能包含大写字母、小写字母、数字、-和_，且必须由大写字母、小写字母或数字开头，长度在1到64个字符之间。
        /// </summary>
        [JsonProperty("message_template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageTemplateName { get; set; }

        /// <summary>
        /// 模板支持的协议类型。  目前支持的协议包括：  “default”：默认协议。  “email”：邮件传输协议。  “sms”：短信传输协议。  “functionstage”：FunctionGraph（函数）传输协议。  “dms”：DMS传输协议。  “http”、“https”：HTTP/HTTPS传输协议。
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }

        /// <summary>
        /// 模板内容，模板目前仅支持纯文本模式。模板内容不能空，最大支持256KB。
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateMessageTemplateRequestBody {\n");
            sb.Append("  messageTemplateName: ").Append(MessageTemplateName).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  content: ").Append(Content).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateMessageTemplateRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateMessageTemplateRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MessageTemplateName == input.MessageTemplateName ||
                    (this.MessageTemplateName != null &&
                    this.MessageTemplateName.Equals(input.MessageTemplateName))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
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
                if (this.MessageTemplateName != null)
                    hashCode = hashCode * 59 + this.MessageTemplateName.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                return hashCode;
            }
        }
    }
}
