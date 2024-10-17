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
    /// 图像内容审核请求体
    /// </summary>
    public class ImageDetectionReq 
    {
        /// <summary>
        /// 可指定图片中文字语种类型
        /// </summary>
        /// <value>可指定图片中文字语种类型</value>
        [JsonConverter(typeof(EnumClassConverter<LanguageEnum>))]
        public class LanguageEnum
        {
            /// <summary>
            /// Enum ZH for value: zh
            /// </summary>
            public static readonly LanguageEnum ZH = new LanguageEnum("zh");

            private static readonly Dictionary<string, LanguageEnum> StaticFields =
            new Dictionary<string, LanguageEnum>()
            {
                { "zh", ZH },
            };

            private string _value;

            public LanguageEnum()
            {

            }

            public LanguageEnum(string value)
            {
                _value = value;
            }

            public static LanguageEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as LanguageEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LanguageEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LanguageEnum a, LanguageEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(LanguageEnum a, LanguageEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 事件类型。 可选值如下： head_image：头像 album：相册 dynamic：动态 article：帖子 comment：评论 room_cover：房间封面 group_message：群聊图片 message：私聊图片 product：商品图片
        /// </summary>
        [JsonProperty("event_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EventType { get; set; }

        /// <summary>
        /// 检测场景。可添加的检测场景如下： - terrorism：暴恐元素的检测。 - porn：涉黄元素的检测。 - image_text：广告图文的检测。 - 可通过配置上述场景，来完对应场景元素的检测。 &gt; 每个检测场景的检测次数会分类统计。
        /// </summary>
        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Categories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("image_text_config", NullValueHandling = NullValueHandling.Ignore)]
        public ImgTextConfig ImageTextConfig { get; set; }

        /// <summary>
        /// 图片url, 与image二选一，目前支持： - 公网HTTP/HTTPS URL
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 与url二选一，图片文件Base64编码字符串，要求base64编码后大小不超过10M，支持JPG/PNG/JPEG/WEBP/GIF/TIFF/TIF/HEIF等格式。
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public string Image { get; set; }

        /// <summary>
        /// 自定义审核策略名称，可在控制台配置;如果请求参数中传了biz_type则优先使用biz_type,如果用户没传biz_type则event_type和categories必须传。
        /// </summary>
        [JsonProperty("biz_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BizType { get; set; }

        /// <summary>
        /// 可指定图片中文字语种类型
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public LanguageEnum Language { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageDetectionReq {\n");
            sb.Append("  eventType: ").Append(EventType).Append("\n");
            sb.Append("  categories: ").Append(Categories).Append("\n");
            sb.Append("  imageTextConfig: ").Append(ImageTextConfig).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  image: ").Append(Image).Append("\n");
            sb.Append("  bizType: ").Append(BizType).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageDetectionReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageDetectionReq input)
        {
            if (input == null) return false;
            if (this.EventType != input.EventType || (this.EventType != null && !this.EventType.Equals(input.EventType))) return false;
            if (this.Categories != input.Categories || (this.Categories != null && input.Categories != null && !this.Categories.SequenceEqual(input.Categories))) return false;
            if (this.ImageTextConfig != input.ImageTextConfig || (this.ImageTextConfig != null && !this.ImageTextConfig.Equals(input.ImageTextConfig))) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.Image != input.Image || (this.Image != null && !this.Image.Equals(input.Image))) return false;
            if (this.BizType != input.BizType || (this.BizType != null && !this.BizType.Equals(input.BizType))) return false;
            if (this.Language != input.Language) return false;

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
                if (this.ImageTextConfig != null) hashCode = hashCode * 59 + this.ImageTextConfig.GetHashCode();
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Image != null) hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.BizType != null) hashCode = hashCode * 59 + this.BizType.GetHashCode();
                hashCode = hashCode * 59 + this.Language.GetHashCode();
                return hashCode;
            }
        }
    }
}
