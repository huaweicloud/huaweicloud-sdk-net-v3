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
    /// 设置自定义多画面请求。
    /// </summary>
    public class RestCustomMultiPictureBody 
    {

        /// <summary>
        /// 是否为手工设置多画面。 * 0： 系统自动多画面 * 1： 手工设置多画面 
        /// </summary>
        [JsonProperty("manualSet", NullValueHandling = NullValueHandling.Ignore)]
        public int? ManualSet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("picLayoutInfo", NullValueHandling = NullValueHandling.Ignore)]
        public PicLayoutInfo PicLayoutInfo { get; set; }

        /// <summary>
        /// 画面类型。手工设置多画面时有效。 - Single: 单画面 - Two: 二画面 - Three: 三画面 - Three-2: 三画面 - Three-3: 三画面 - Three-4: 三画面 - Four: 四画面 - Four-2: 四画面 - Four-3: 四画面 - Five: 五画面 - Five-2: 五画面 - Six: 六画面 - Six-2: 六画面 - Six-3: 六画面 - Six-4: 六画面 - Six-5: 六画面 - Seven: 七画面 - Seven-2: 七画面 - Seven-3: 七画面 - Seven-4: 七画面 - Eight: 八画面 - Eight-2: 八画面 - Eight-3: 八画面 - Eight-4: 八画面 - Nine: 九画面 - Ten: 十画面 - Ten-2: 十画面 - Ten-3: 十画面 - Ten-4: 十画面 - Ten-5: 十画面 - Ten-6: 十画面 - Thirteen: 十三画面 - Thirteen-2: 十三画面 - Thirteen-3: 十三画面 - Thirteen-4: 十三画面 - Thirteen-5: 十三画面 - Sixteen: 十六画面 - Seventeen: 十七画面 - Twenty-Five: 二十五画面 
        /// </summary>
        [JsonProperty("imageType", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageType { get; set; }

        /// <summary>
        /// 子画面列表（手工设置多画面时必填）。
        /// </summary>
        [JsonProperty("subscriberInPics", NullValueHandling = NullValueHandling.Ignore)]
        public List<RestSubscriberInPic> SubscriberInPics { get; set; }

        /// <summary>
        /// 表示轮询间隔,取值范围：10-120，默认10。单位：秒。 当同一个子画面中包含有多个与会者时，此参数有效。 &gt; 仅针对专业会议终端生效，对软终端不生效。 
        /// </summary>
        [JsonProperty("switchTime", NullValueHandling = NullValueHandling.Ignore)]
        public int? SwitchTime { get; set; }

        /// <summary>
        /// 多画面是否仅保存。 * true： 仅保存 * false： 保存并应用 &gt; * ”仅保存“效果：仅保存当前画面布局，不进行广播等操作。 &gt; * ”保存并应用“效果：1、当会议状态为广播多画面、声控单画面、声控多画面、主持人观看多画面时，保存并应用后，改变画面布局，不改变状态。2、当会议状态为非广播多画面、声控单画面、声控多画面、主持人观看多画面时，如自动多画面、广播与会者、点名与会者时，保存并应用后，变为广播多画面。 &gt; * 当处于广播多画面、声控多画面、声控单画面状态下，无法设置主持人观看多画面。 
        /// </summary>
        [JsonProperty("multiPicSaveOnly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MultiPicSaveOnly { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestCustomMultiPictureBody {\n");
            sb.Append("  manualSet: ").Append(ManualSet).Append("\n");
            sb.Append("  picLayoutInfo: ").Append(PicLayoutInfo).Append("\n");
            sb.Append("  imageType: ").Append(ImageType).Append("\n");
            sb.Append("  subscriberInPics: ").Append(SubscriberInPics).Append("\n");
            sb.Append("  switchTime: ").Append(SwitchTime).Append("\n");
            sb.Append("  multiPicSaveOnly: ").Append(MultiPicSaveOnly).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestCustomMultiPictureBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestCustomMultiPictureBody input)
        {
            if (input == null) return false;
            if (this.ManualSet != input.ManualSet || (this.ManualSet != null && !this.ManualSet.Equals(input.ManualSet))) return false;
            if (this.PicLayoutInfo != input.PicLayoutInfo || (this.PicLayoutInfo != null && !this.PicLayoutInfo.Equals(input.PicLayoutInfo))) return false;
            if (this.ImageType != input.ImageType || (this.ImageType != null && !this.ImageType.Equals(input.ImageType))) return false;
            if (this.SubscriberInPics != input.SubscriberInPics || (this.SubscriberInPics != null && input.SubscriberInPics != null && !this.SubscriberInPics.SequenceEqual(input.SubscriberInPics))) return false;
            if (this.SwitchTime != input.SwitchTime || (this.SwitchTime != null && !this.SwitchTime.Equals(input.SwitchTime))) return false;
            if (this.MultiPicSaveOnly != input.MultiPicSaveOnly || (this.MultiPicSaveOnly != null && !this.MultiPicSaveOnly.Equals(input.MultiPicSaveOnly))) return false;

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
                if (this.PicLayoutInfo != null) hashCode = hashCode * 59 + this.PicLayoutInfo.GetHashCode();
                if (this.ImageType != null) hashCode = hashCode * 59 + this.ImageType.GetHashCode();
                if (this.SubscriberInPics != null) hashCode = hashCode * 59 + this.SubscriberInPics.GetHashCode();
                if (this.SwitchTime != null) hashCode = hashCode * 59 + this.SwitchTime.GetHashCode();
                if (this.MultiPicSaveOnly != null) hashCode = hashCode * 59 + this.MultiPicSaveOnly.GetHashCode();
                return hashCode;
            }
        }
    }
}
