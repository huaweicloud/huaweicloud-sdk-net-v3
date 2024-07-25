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
    /// 图像审核批量同步接口请求参数Body体
    /// </summary>
    public class ImageBatchSyncReq 
    {

        /// <summary>
        /// 事件类型。可选值如下： - head_image：头像 - album：相册 - dynamic：动态 - article：帖子 - comment：评论 - room_cover：房间封面 - group_message：群聊图片 - message：私聊图片 - product：商品图片
        /// </summary>
        [JsonProperty("event_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EventType { get; set; }

        /// <summary>
        /// 检测场景。可添加的检测场景如下： - terrorism：暴恐元素的检测。 - porn：涉黄元素的检测。 - image_text：广告图文的检测。 可通过配置上述场景，来完对应场景元素的检测。每个检测场景的检测次数会分类统计。
        /// </summary>
        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Categories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("image_text_config", NullValueHandling = NullValueHandling.Ignore)]
        public ImageBatchSyncReqImageTextConfig ImageTextConfig { get; set; }

        /// <summary>
        /// 图片url列表。
        /// </summary>
        [JsonProperty("urls", NullValueHandling = NullValueHandling.Ignore)]
        public List<ImageBatchSyncReqUrls> Urls { get; set; }

        /// <summary>
        /// 指定图片中文字语种类型。 - zh: 中文 - en: 英文 默认值为zh，中国站仅支持zh。
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// 用户在控制台界面创建的自定义审核策略名称。 - 如果请求参数中包含biz_type则优先使用biztype。 - 如果未传biz_type则event_type和categories为必传参数。
        /// </summary>
        [JsonProperty("biz_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BizType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageBatchSyncReq {\n");
            sb.Append("  eventType: ").Append(EventType).Append("\n");
            sb.Append("  categories: ").Append(Categories).Append("\n");
            sb.Append("  imageTextConfig: ").Append(ImageTextConfig).Append("\n");
            sb.Append("  urls: ").Append(Urls).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  bizType: ").Append(BizType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageBatchSyncReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageBatchSyncReq input)
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
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && 
                (
                    this.ImageTextConfig == input.ImageTextConfig ||
                    (this.ImageTextConfig != null &&
                    this.ImageTextConfig.Equals(input.ImageTextConfig))
                ) && 
                (
                    this.Urls == input.Urls ||
                    this.Urls != null &&
                    input.Urls != null &&
                    this.Urls.SequenceEqual(input.Urls)
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.BizType == input.BizType ||
                    (this.BizType != null &&
                    this.BizType.Equals(input.BizType))
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
                if (this.Categories != null)
                    hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.ImageTextConfig != null)
                    hashCode = hashCode * 59 + this.ImageTextConfig.GetHashCode();
                if (this.Urls != null)
                    hashCode = hashCode * 59 + this.Urls.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.BizType != null)
                    hashCode = hashCode * 59 + this.BizType.GetHashCode();
                return hashCode;
            }
        }
    }
}
