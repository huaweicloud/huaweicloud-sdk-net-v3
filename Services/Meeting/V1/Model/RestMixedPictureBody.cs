using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 设置多画面请求。
    /// </summary>
    public class RestMixedPictureBody 
    {

        /// <summary>
        /// 是否为手工设置多画面。 - 0: 系统自动多画面 - 1: 手工设置多画面
        /// </summary>
        [JsonProperty("manualSet", NullValueHandling = NullValueHandling.Ignore)]
        public int? ManualSet { get; set; }

        /// <summary>
        /// 多画面数目。手工设置多画面时有效。 - Single: 单画面 - Two: 二画面 - Three: 三画面 - Four: 四画面 - Six: 六画面 - Nine: 九画面 - Sixteen: 十六画面
        /// </summary>
        [JsonProperty("imageType", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageType { get; set; }

        /// <summary>
        /// 子画面列表（手工设置多画面时必填）。
        /// </summary>
        [JsonProperty("subscriberInPics", NullValueHandling = NullValueHandling.Ignore)]
        public List<SubscriberInPic> SubscriberInPics { get; set; }

        /// <summary>
        /// 表示轮询间隔。单位：秒。 当同一个子画面中包含有多个与会者时，此参数有效。
        /// </summary>
        [JsonProperty("switchTime", NullValueHandling = NullValueHandling.Ignore)]
        public int? SwitchTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestMixedPictureBody {\n");
            sb.Append("  manualSet: ").Append(ManualSet).Append("\n");
            sb.Append("  imageType: ").Append(ImageType).Append("\n");
            sb.Append("  subscriberInPics: ").Append(SubscriberInPics).Append("\n");
            sb.Append("  switchTime: ").Append(SwitchTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestMixedPictureBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestMixedPictureBody input)
        {
            if (input == null) return false;
            if (this.ManualSet != input.ManualSet || (this.ManualSet != null && !this.ManualSet.Equals(input.ManualSet))) return false;
            if (this.ImageType != input.ImageType || (this.ImageType != null && !this.ImageType.Equals(input.ImageType))) return false;
            if (this.SubscriberInPics != input.SubscriberInPics || (this.SubscriberInPics != null && input.SubscriberInPics != null && !this.SubscriberInPics.SequenceEqual(input.SubscriberInPics))) return false;
            if (this.SwitchTime != input.SwitchTime || (this.SwitchTime != null && !this.SwitchTime.Equals(input.SwitchTime))) return false;

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
                if (this.ManualSet != null) hashCode = hashCode * 59 + this.ManualSet.GetHashCode();
                if (this.ImageType != null) hashCode = hashCode * 59 + this.ImageType.GetHashCode();
                if (this.SubscriberInPics != null) hashCode = hashCode * 59 + this.SubscriberInPics.GetHashCode();
                if (this.SwitchTime != null) hashCode = hashCode * 59 + this.SwitchTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
