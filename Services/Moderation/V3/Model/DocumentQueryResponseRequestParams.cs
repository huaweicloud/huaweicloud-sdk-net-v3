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
    /// 作业创建参数
    /// </summary>
    public class DocumentQueryResponseRequestParams 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public DocumentQueryResponseRequestParamsData Data { get; set; }

        /// <summary>
        /// 创建作业时传的event_type参数
        /// </summary>
        [JsonProperty("event_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EventType { get; set; }

        /// <summary>
        /// 创建作业时传的image_categories参数
        /// </summary>
        [JsonProperty("image_categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ImageCategories { get; set; }

        /// <summary>
        /// 创建作业时传的text_categories参数
        /// </summary>
        [JsonProperty("text_categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TextCategories { get; set; }

        /// <summary>
        /// 创建作业时传的video_image_categories参数
        /// </summary>
        [JsonProperty("video_image_categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VideoImageCategories { get; set; }

        /// <summary>
        /// 创建作业时传的audio_categories参数
        /// </summary>
        [JsonProperty("audio_categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AudioCategories { get; set; }

        /// <summary>
        /// 创建作业时传的callback参数
        /// </summary>
        [JsonProperty("callback", NullValueHandling = NullValueHandling.Ignore)]
        public string Callback { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentQueryResponseRequestParams {\n");
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
            return this.Equals(input as DocumentQueryResponseRequestParams);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DocumentQueryResponseRequestParams input)
        {
            if (input == null) return false;
            if (this.Data != input.Data || (this.Data != null && !this.Data.Equals(input.Data))) return false;
            if (this.EventType != input.EventType || (this.EventType != null && !this.EventType.Equals(input.EventType))) return false;
            if (this.ImageCategories != input.ImageCategories || (this.ImageCategories != null && input.ImageCategories != null && !this.ImageCategories.SequenceEqual(input.ImageCategories))) return false;
            if (this.TextCategories != input.TextCategories || (this.TextCategories != null && input.TextCategories != null && !this.TextCategories.SequenceEqual(input.TextCategories))) return false;
            if (this.VideoImageCategories != input.VideoImageCategories || (this.VideoImageCategories != null && input.VideoImageCategories != null && !this.VideoImageCategories.SequenceEqual(input.VideoImageCategories))) return false;
            if (this.AudioCategories != input.AudioCategories || (this.AudioCategories != null && input.AudioCategories != null && !this.AudioCategories.SequenceEqual(input.AudioCategories))) return false;
            if (this.Callback != input.Callback || (this.Callback != null && !this.Callback.Equals(input.Callback))) return false;

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
                if (this.Data != null) hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.EventType != null) hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.ImageCategories != null) hashCode = hashCode * 59 + this.ImageCategories.GetHashCode();
                if (this.TextCategories != null) hashCode = hashCode * 59 + this.TextCategories.GetHashCode();
                if (this.VideoImageCategories != null) hashCode = hashCode * 59 + this.VideoImageCategories.GetHashCode();
                if (this.AudioCategories != null) hashCode = hashCode * 59 + this.AudioCategories.GetHashCode();
                if (this.Callback != null) hashCode = hashCode * 59 + this.Callback.GetHashCode();
                return hashCode;
            }
        }
    }
}
