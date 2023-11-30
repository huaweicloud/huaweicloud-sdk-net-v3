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
    /// 
    /// </summary>
    public class DocumentCreateRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public DocumentCreateRequestData Data { get; set; }

        /// <summary>
        /// 事件类型，可选值如下： default：默认事件 liberal_arts_education：文科教育 sciences_education：理科教育 news：新闻 forums：论坛 novels：小说
        /// </summary>
        [JsonProperty("event_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EventType { get; set; }

        /// <summary>
        /// 文档中图片需要检测的风险类型，不传或为空时表示不审核图片内容， 可取值如下： politics: 涉政检测 porn：涉黄检测 terrorism: 暴恐检测 bad_scene: 不良场景检测 image_text: 图文检测
        /// </summary>
        [JsonProperty("image_categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ImageCategories { get; set; }

        /// <summary>
        /// 文档中文本需要检测的风险类型，不传或为空时表示不审核文本内容， 可取值如下： default: 检测涉政、暴恐、违禁、色情、辱骂、广告等违规内容
        /// </summary>
        [JsonProperty("text_categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TextCategories { get; set; }

        /// <summary>
        /// 网页视频中图片需要检测的风险类型，不传或为空时表示不审核网页视频内容， 可取值如下： politics: 涉政检测 porn：涉黄检测 terrorism: 暴恐检测 bad_scene: 不良场景检测 image_text: 图文检测
        /// </summary>
        [JsonProperty("video_image_categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VideoImageCategories { get; set; }

        /// <summary>
        /// 网页视频中音频需要检测的风险类型，不传或为空时表示不审核网页视频中音频的内容， 可取值如下： politics: 涉政检测 porn：涉黄检测 ad：广告检测 abuse：辱骂检测 moan：娇喘检测
        /// </summary>
        [JsonProperty("audio_categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AudioCategories { get; set; }

        /// <summary>
        /// 回调http接口：当该字段非空时，服务将根据该字段回调通知用户审核结果。
        /// </summary>
        [JsonProperty("callback", NullValueHandling = NullValueHandling.Ignore)]
        public string Callback { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentCreateRequest {\n");
            sb.Append("  data: ").Append(Data).Append("\n");
            sb.Append("  eventType: ").Append(EventType).Append("\n");
            sb.Append("  imageCategories: ").Append(ImageCategories).Append("\n");
            sb.Append("  textCategories: ").Append(TextCategories).Append("\n");
            sb.Append("  videoImageCategories: ").Append(VideoImageCategories).Append("\n");
            sb.Append("  audioCategories: ").Append(AudioCategories).Append("\n");
            sb.Append("  callback: ").Append(Callback).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DocumentCreateRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DocumentCreateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.ImageCategories == input.ImageCategories ||
                    this.ImageCategories != null &&
                    input.ImageCategories != null &&
                    this.ImageCategories.SequenceEqual(input.ImageCategories)
                ) && 
                (
                    this.TextCategories == input.TextCategories ||
                    this.TextCategories != null &&
                    input.TextCategories != null &&
                    this.TextCategories.SequenceEqual(input.TextCategories)
                ) && 
                (
                    this.VideoImageCategories == input.VideoImageCategories ||
                    this.VideoImageCategories != null &&
                    input.VideoImageCategories != null &&
                    this.VideoImageCategories.SequenceEqual(input.VideoImageCategories)
                ) && 
                (
                    this.AudioCategories == input.AudioCategories ||
                    this.AudioCategories != null &&
                    input.AudioCategories != null &&
                    this.AudioCategories.SequenceEqual(input.AudioCategories)
                ) && 
                (
                    this.Callback == input.Callback ||
                    (this.Callback != null &&
                    this.Callback.Equals(input.Callback))
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
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.EventType != null)
                    hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.ImageCategories != null)
                    hashCode = hashCode * 59 + this.ImageCategories.GetHashCode();
                if (this.TextCategories != null)
                    hashCode = hashCode * 59 + this.TextCategories.GetHashCode();
                if (this.VideoImageCategories != null)
                    hashCode = hashCode * 59 + this.VideoImageCategories.GetHashCode();
                if (this.AudioCategories != null)
                    hashCode = hashCode * 59 + this.AudioCategories.GetHashCode();
                if (this.Callback != null)
                    hashCode = hashCode * 59 + this.Callback.GetHashCode();
                return hashCode;
            }
        }
    }
}
