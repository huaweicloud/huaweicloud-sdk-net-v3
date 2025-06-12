using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 素材图片图层配置。
    /// </summary>
    public class SmartImageLayerConfig 
    {

        /// <summary>
        /// 图片文件的URL。
        /// </summary>
        [JsonProperty("image_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// **参数解释**： 图片显示时长，单位s。  显示时长规则为，若携带reply_texts、reply_audios，则与播放语音内容时长保持一致。若未携带，则与匹配的关键词语音内容时长保持一致。
        /// </summary>
        [JsonProperty("display_duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? DisplayDuration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmartImageLayerConfig {\n");
            sb.Append("  imageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  displayDuration: ").Append(DisplayDuration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SmartImageLayerConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmartImageLayerConfig input)
        {
            if (input == null) return false;
            if (this.ImageUrl != input.ImageUrl || (this.ImageUrl != null && !this.ImageUrl.Equals(input.ImageUrl))) return false;
            if (this.DisplayDuration != input.DisplayDuration || (this.DisplayDuration != null && !this.DisplayDuration.Equals(input.DisplayDuration))) return false;

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
                if (this.ImageUrl != null) hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                if (this.DisplayDuration != null) hashCode = hashCode * 59 + this.DisplayDuration.GetHashCode();
                return hashCode;
            }
        }
    }
}
