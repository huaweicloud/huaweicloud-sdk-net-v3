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
    /// 多画面显示信息。
    /// </summary>
    public class MultiPicDisplayDO 
    {

        /// <summary>
        /// 是否为手工设置多画面。 * 0 ：系统自动多画面 * 1 ：手工设置多画面 
        /// </summary>
        [JsonProperty("manualSet", NullValueHandling = NullValueHandling.Ignore)]
        public int? ManualSet { get; set; }

        /// <summary>
        /// 画面类型。取值范围: * Single: 单画面 * Two: 二画面 * Three: 三画面， Three-2: 三画面-2， Three-3: 三画面-3， Three-4: 三画面-4 * Four: 四画面， Four-2: 四画面-2， Four-3: 四画面-3 * Five: 五画面， Five-2: 五画面-2 * Six: 六画面， Six-2: 六画面-2， Six-3: 六画面-3， Six-4: 六画面-4， Six-5: 六画面-5 * Seven: 七画面， Seven-2: 七画面-2， Seven-3: 七画面-3， Seven-4: 七画面-4 * Eight: 八画面， Eight-2: 八画面-2， Eight-3: 八画面-3， Eight-4: 八画面-4 * Nine: 九画面 * Ten: 十画面， Ten-2: 十画面-2， Ten-3: 十画面-3， Ten-4: 十画面-4， Ten-5: 十画面-5， Ten-6: 十画面-6 * Thirteen: 十三画面， Thirteen-2: 十三画面-2， Thirteen-3: 十三画面-3，Thirteen-4: 十三画面-4， Thirteen-5: 十三画面-5， ThirteenR: 十三画面R， ThirteenM: 十三画面M * Sixteen: 十六画面 * Seventeen: 十七画面 * Twenty-Five: 二十五画面 * Custom: 自定义多画面（当前不支持） 
        /// </summary>
        [JsonProperty("imageType", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageType { get; set; }

        /// <summary>
        /// 子画面列表。
        /// </summary>
        [JsonProperty("subscriberInPics", NullValueHandling = NullValueHandling.Ignore)]
        public List<PicInfoNotify> SubscriberInPics { get; set; }

        /// <summary>
        /// 表示轮询间隔，单位：秒。当同一个子画面中包含有多个视频源时，此参数有效。
        /// </summary>
        [JsonProperty("switchTime", NullValueHandling = NullValueHandling.Ignore)]
        public int? SwitchTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("picLayoutInfo", NullValueHandling = NullValueHandling.Ignore)]
        public PicLayoutInfo PicLayoutInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MultiPicDisplayDO {\n");
            sb.Append("  manualSet: ").Append(ManualSet).Append("\n");
            sb.Append("  imageType: ").Append(ImageType).Append("\n");
            sb.Append("  subscriberInPics: ").Append(SubscriberInPics).Append("\n");
            sb.Append("  switchTime: ").Append(SwitchTime).Append("\n");
            sb.Append("  picLayoutInfo: ").Append(PicLayoutInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MultiPicDisplayDO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MultiPicDisplayDO input)
        {
            if (input == null) return false;
            if (this.ManualSet != input.ManualSet || (this.ManualSet != null && !this.ManualSet.Equals(input.ManualSet))) return false;
            if (this.ImageType != input.ImageType || (this.ImageType != null && !this.ImageType.Equals(input.ImageType))) return false;
            if (this.SubscriberInPics != input.SubscriberInPics || (this.SubscriberInPics != null && input.SubscriberInPics != null && !this.SubscriberInPics.SequenceEqual(input.SubscriberInPics))) return false;
            if (this.SwitchTime != input.SwitchTime || (this.SwitchTime != null && !this.SwitchTime.Equals(input.SwitchTime))) return false;
            if (this.PicLayoutInfo != input.PicLayoutInfo || (this.PicLayoutInfo != null && !this.PicLayoutInfo.Equals(input.PicLayoutInfo))) return false;

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
                if (this.PicLayoutInfo != null) hashCode = hashCode * 59 + this.PicLayoutInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
