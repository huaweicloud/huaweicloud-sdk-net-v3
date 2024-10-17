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
    /// 发送给SMN消息结构
    /// </summary>
    public class ActionSmnForwarding 
    {

        /// <summary>
        /// **参数说明**：SMN服务对应的region区域。
        /// </summary>
        [JsonProperty("region_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionName { get; set; }

        /// <summary>
        /// **参数说明**：SMN服务对应的projectId信息。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数说明**：SMN服务对应的主题名称。
        /// </summary>
        [JsonProperty("theme_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ThemeName { get; set; }

        /// <summary>
        /// **参数说明**：SMN服务对应的topic的主题URN。
        /// </summary>
        [JsonProperty("topic_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicUrn { get; set; }

        /// <summary>
        /// **参数说明**：短信或邮件的内容。
        /// </summary>
        [JsonProperty("message_content", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageContent { get; set; }

        /// <summary>
        /// **参数说明**：SMN服务对应的模板名称。
        /// </summary>
        [JsonProperty("message_template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageTemplateName { get; set; }

        /// <summary>
        /// **参数说明**：短信或邮件的主题。最大长度支持UTF-8编码后的521个字节。
        /// </summary>
        [JsonProperty("message_title", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageTitle { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionSmnForwarding {\n");
            sb.Append("  regionName: ").Append(RegionName).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  themeName: ").Append(ThemeName).Append("\n");
            sb.Append("  topicUrn: ").Append(TopicUrn).Append("\n");
            sb.Append("  messageContent: ").Append(MessageContent).Append("\n");
            sb.Append("  messageTemplateName: ").Append(MessageTemplateName).Append("\n");
            sb.Append("  messageTitle: ").Append(MessageTitle).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ActionSmnForwarding);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ActionSmnForwarding input)
        {
            if (input == null) return false;
            if (this.RegionName != input.RegionName || (this.RegionName != null && !this.RegionName.Equals(input.RegionName))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ThemeName != input.ThemeName || (this.ThemeName != null && !this.ThemeName.Equals(input.ThemeName))) return false;
            if (this.TopicUrn != input.TopicUrn || (this.TopicUrn != null && !this.TopicUrn.Equals(input.TopicUrn))) return false;
            if (this.MessageContent != input.MessageContent || (this.MessageContent != null && !this.MessageContent.Equals(input.MessageContent))) return false;
            if (this.MessageTemplateName != input.MessageTemplateName || (this.MessageTemplateName != null && !this.MessageTemplateName.Equals(input.MessageTemplateName))) return false;
            if (this.MessageTitle != input.MessageTitle || (this.MessageTitle != null && !this.MessageTitle.Equals(input.MessageTitle))) return false;

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
                if (this.RegionName != null) hashCode = hashCode * 59 + this.RegionName.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ThemeName != null) hashCode = hashCode * 59 + this.ThemeName.GetHashCode();
                if (this.TopicUrn != null) hashCode = hashCode * 59 + this.TopicUrn.GetHashCode();
                if (this.MessageContent != null) hashCode = hashCode * 59 + this.MessageContent.GetHashCode();
                if (this.MessageTemplateName != null) hashCode = hashCode * 59 + this.MessageTemplateName.GetHashCode();
                if (this.MessageTitle != null) hashCode = hashCode * 59 + this.MessageTitle.GetHashCode();
                return hashCode;
            }
        }
    }
}
