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
        /// 事件类型。 可选值如下： head_image：头像 album：相册 dynamic：动态 article：帖子 comment：评论 room_cover：房间封面 group_message：群聊图片 message：私聊图片 product：商品图片
        /// </summary>
        [JsonProperty("event_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EventType { get; set; }

        /// <summary>
        /// 检测场景，可添加的检测场景如下，华为云当前支持全场景的，以下仅展示部门检测能力，如果有其它检测场景的需求，请在开通服务时咨询华为云工程师：  terrorism：涉政暴恐内容的检测。  porn：鉴黄内容的检测。  politics：政治敏感人物内容的检测 image_text：图文违规内容的检测。（检测图片中出现的广告、色情、暴恐、涉政的文字违规内容以及二维码内容）  备注：资料上线需要删除politics
        /// </summary>
        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Categories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("image_text_config", NullValueHandling = NullValueHandling.Ignore)]
        public ImgTextConfig ImageTextConfig { get; set; }

        /// <summary>
        /// 图片url, 与image二选一。 图片的URL路径，使用OBS数据需要进行授权。包括对服务授权、临时授权、匿名公开授权。详情请见配置OBS访问权限。 ​ 说明： 接口响应时间依赖图片的下载时间，如果图片下载时间过长，会返回接口调用失败。请保证被检测图片所在的存储服务稳定可靠，建议您使用华为云OBS存储。 图片url, 与image二选一。 图片的URL路径，使用OBS数据需要进行授权。包括对服务授权、临时授权、匿名公开授权。详情请见配置OBS访问权限。  说明： 接口响应时间依赖图片的下载时间，如果图片下载时间过长，会返回接口调用失败。请保证被检测图片所在的存储服务稳定可靠，建议您使用华为云OBS存储。
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 与url二选一。 ​ 图片文件Base64编码字符串。要求base64编码后大小不超过10M。 ​ 支持JPG/PNG/BMP/WEBP等格式。 与url二选一。  图片文件Base64编码字符串。要求base64编码后大小不超过10M。  支持JPG/PNG/BMP/WEBP等格式。
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public string Image { get; set; }


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
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
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
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                return hashCode;
            }
        }
    }
}
