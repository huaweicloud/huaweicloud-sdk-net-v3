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
        /// 文本审核场景，可选值如下： terrorism: 暴恐 porn: 色情 ban: 违禁 abuse: 辱骂 politics: 涉政 ad: 广告 当categories缺省或为空时，默认审核terrorism、porn、ban、abuse、ad。
        /// </summary>
        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Categories { get; set; }

        /// <summary>
        /// 检测时使用的自定义黑名单词库列表。自定义黑词库的创建和使用请参见[配置定义词库v3](https://support.huaweicloud.com/api-moderation/moderation_03_0097.html)。
        /// </summary>
        [JsonProperty("glossary_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> GlossaryNames { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public TextDetectionDataReq Data { get; set; }

        /// <summary>
        /// 检测时使用的自定义白名单词库列表。自定义白词库的创建和使用请参见[配置定义词库v3](https://support.huaweicloud.com/api-moderation/moderation_03_0097.html)。
        /// </summary>
        [JsonProperty("white_glossary_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> WhiteGlossaryNames { get; set; }

        /// <summary>
        /// 自定义审核策略名称，可在控制台配置;如果请求参数中传了biz_type则优先使用biz_type,如果用户没传biz_type则event_type必须传。
        /// </summary>
        [JsonProperty("biz_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BizType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextDetectionReq {\n");
            sb.Append("  eventType: ").Append(EventType).Append("\n");
            sb.Append("  categories: ").Append(Categories).Append("\n");
            sb.Append("  glossaryNames: ").Append(GlossaryNames).Append("\n");
            sb.Append("  data: ").Append(Data).Append("\n");
            sb.Append("  whiteGlossaryNames: ").Append(WhiteGlossaryNames).Append("\n");
            sb.Append("  bizType: ").Append(BizType).Append("\n");
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
            if (input == null) return false;
            if (this.EventType != input.EventType || (this.EventType != null && !this.EventType.Equals(input.EventType))) return false;
            if (this.Categories != input.Categories || (this.Categories != null && input.Categories != null && !this.Categories.SequenceEqual(input.Categories))) return false;
            if (this.GlossaryNames != input.GlossaryNames || (this.GlossaryNames != null && input.GlossaryNames != null && !this.GlossaryNames.SequenceEqual(input.GlossaryNames))) return false;
            if (this.Data != input.Data || (this.Data != null && !this.Data.Equals(input.Data))) return false;
            if (this.WhiteGlossaryNames != input.WhiteGlossaryNames || (this.WhiteGlossaryNames != null && input.WhiteGlossaryNames != null && !this.WhiteGlossaryNames.SequenceEqual(input.WhiteGlossaryNames))) return false;
            if (this.BizType != input.BizType || (this.BizType != null && !this.BizType.Equals(input.BizType))) return false;

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
                if (this.EventType != null) hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.Categories != null) hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.GlossaryNames != null) hashCode = hashCode * 59 + this.GlossaryNames.GetHashCode();
                if (this.Data != null) hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.WhiteGlossaryNames != null) hashCode = hashCode * 59 + this.WhiteGlossaryNames.GetHashCode();
                if (this.BizType != null) hashCode = hashCode * 59 + this.BizType.GetHashCode();
                return hashCode;
            }
        }
    }
}
