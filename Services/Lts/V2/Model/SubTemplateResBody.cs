using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SubTemplateResBody 
    {

        /// <summary>
        /// **参数解释：**  消息模板的通知渠道。 **取值范围：**  - sms - dingding - wechat - webhook - email - voice - feishu - welink
        /// </summary>
        [JsonProperty("sub_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SubType { get; set; }

        /// <summary>
        /// **参数解释：**  对应通知渠道的消息模板正文，$符号后所跟变量仅支持以下变量，根据不同告警类型（关键词告警和sql告警），所支持的变量亦不相同。目前两种告警类型有共同变量如下： 告警级别：${event_severity}; 发生时间：${starts_at}; 告警源：$event.metadata.resource_provider; 资源类型：$event.metadata.resource_type; 资源标识：${resources}; 统计类型：关键词统计; 表达式：$event.annotations.condition_expression; 当前值: $event.annotations.current_value; 统计周期：$event.annotations.frequency; 关键词告警特有变量： 查询时间：$event.annotations.results[0].time; 查询日志：$event.annotations.results[0].raw_results; sql告警特有变量： 日志组/流名称：$event.annotations.results[0].resource_id; 查询语句：$event.annotations.results[0].sql; 查询时间：$event.annotations.results[0].time; 查询URL：$event.annotations.results[0].url; 查询日志：$event.annotations.results[0].raw_results;  告警级别：${event_severity}; 发生时间：${starts_at}; 告警源：$event.metadata.resource_provider; 资源类型：$event.metadata.resource_type; 资源标识：${resources}; 统计类型：关键词统计; 表达式：$event.annotations.condition_expression; 当前值: $event.annotations.current_value; 统计周期：$event.annotations.frequency; 关键词告警特有变量： 查询时间：$event.annotations.results[0].time; 查询日志：$event.annotations.results[0].raw_results; sql告警特有变量： 日志组/流名称：$event.annotations.results[0].resource_id; 查询语句：$event.annotations.results[0].sql; 查询时间：$event.annotations.results[0].time; 查询URL：$event.annotations.results[0].url; 查询日志：$event.annotations.results[0].raw_results;   &gt;变量后面的分号\&quot;;\&quot;为英文符号，必须添加，否则模板会出现替换失败的情况。  **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        /// <summary>
        /// **参数解释：**  邮件主题。通知渠道为邮件时生效，即sub_type&#x3D;email。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("topic", NullValueHandling = NullValueHandling.Ignore)]
        public string Topic { get; set; }

        /// <summary>
        /// **参数解释：**  当消息模板类型为webhook时生效，决定该消息的渲染方式。 **取值范围：**  - HTML - JSON
        /// </summary>
        [JsonProperty("sendType", NullValueHandling = NullValueHandling.Ignore)]
        public string SendType { get; set; }

        /// <summary>
        /// **参数解释：**  消息模板的适用版本。 **取值范围：**   v1：标识为LTS的消息模板。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubTemplateResBody {\n");
            sb.Append("  subType: ").Append(SubType).Append("\n");
            sb.Append("  content: ").Append(Content).Append("\n");
            sb.Append("  topic: ").Append(Topic).Append("\n");
            sb.Append("  sendType: ").Append(SendType).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubTemplateResBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubTemplateResBody input)
        {
            if (input == null) return false;
            if (this.SubType != input.SubType || (this.SubType != null && !this.SubType.Equals(input.SubType))) return false;
            if (this.Content != input.Content || (this.Content != null && !this.Content.Equals(input.Content))) return false;
            if (this.Topic != input.Topic || (this.Topic != null && !this.Topic.Equals(input.Topic))) return false;
            if (this.SendType != input.SendType || (this.SendType != null && !this.SendType.Equals(input.SendType))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;

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
                if (this.SubType != null) hashCode = hashCode * 59 + this.SubType.GetHashCode();
                if (this.Content != null) hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Topic != null) hashCode = hashCode * 59 + this.Topic.GetHashCode();
                if (this.SendType != null) hashCode = hashCode * 59 + this.SendType.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }
    }
}
