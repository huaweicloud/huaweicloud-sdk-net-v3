using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Moderation.V3.Model
{
    /// <summary>
    /// 文本内容审核请求体
    /// </summary>
    public class TextDetectionReq 
    {

        /// <summary>
        /// 事件类型。  可选值如下：  nickname: 昵称  title: 标题  article: 帖⼦  comment: 评论  barrage: 弹幕  search: 搜索栏  profile: 个⼈简介
        /// </summary>
        [JsonProperty("event_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EventType { get; set; }

        /// <summary>
        /// 检测时使用的自定义黑名单词库列表。
        /// </summary>
        [JsonProperty("glossary_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> GlossaryNames { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public TextDetectionDataReq Data { get; set; }

        /// <summary>
        /// 检测时使用的自定义白名单词库列表。
        /// </summary>
        [JsonProperty("white_glossary_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> WhiteGlossaryNames { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextDetectionReq {\n");
            sb.Append("  eventType: ").Append(EventType).Append("\n");
            sb.Append("  glossaryNames: ").Append(GlossaryNames).Append("\n");
            sb.Append("  data: ").Append(Data).Append("\n");
            sb.Append("  whiteGlossaryNames: ").Append(WhiteGlossaryNames).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TextDetectionReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TextDetectionReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.GlossaryNames == input.GlossaryNames ||
                    this.GlossaryNames != null &&
                    input.GlossaryNames != null &&
                    this.GlossaryNames.SequenceEqual(input.GlossaryNames)
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.WhiteGlossaryNames == input.WhiteGlossaryNames ||
                    this.WhiteGlossaryNames != null &&
                    input.WhiteGlossaryNames != null &&
                    this.WhiteGlossaryNames.SequenceEqual(input.WhiteGlossaryNames)
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
                if (this.EventType != null)
                    hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.GlossaryNames != null)
                    hashCode = hashCode * 59 + this.GlossaryNames.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.WhiteGlossaryNames != null)
                    hashCode = hashCode * 59 + this.WhiteGlossaryNames.GetHashCode();
                return hashCode;
            }
        }
    }
}
