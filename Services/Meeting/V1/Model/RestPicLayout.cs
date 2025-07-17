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
    /// 多画面布局。
    /// </summary>
    public class RestPicLayout 
    {

        /// <summary>
        /// 多画面轮询时间，单位秒。
        /// </summary>
        [JsonProperty("switchTime", NullValueHandling = NullValueHandling.Ignore)]
        public int? SwitchTime { get; set; }

        /// <summary>
        /// 多画面画面数量。
        /// </summary>
        [JsonProperty("picNum", NullValueHandling = NullValueHandling.Ignore)]
        public int? PicNum { get; set; }

        /// <summary>
        /// 多画面布局名称。
        /// </summary>
        [JsonProperty("layOutName", NullValueHandling = NullValueHandling.Ignore)]
        public string LayOutName { get; set; }

        /// <summary>
        /// 画面类型。
        /// </summary>
        [JsonProperty("imageType", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageType { get; set; }

        /// <summary>
        /// 布局UUID。
        /// </summary>
        [JsonProperty("uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uuid { get; set; }

        /// <summary>
        /// 子画面列表。
        /// </summary>
        [JsonProperty("subscriberInPics", NullValueHandling = NullValueHandling.Ignore)]
        public List<PicInfoNotify> SubscriberInPics { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestPicLayout {\n");
            sb.Append("  switchTime: ").Append(SwitchTime).Append("\n");
            sb.Append("  picNum: ").Append(PicNum).Append("\n");
            sb.Append("  layOutName: ").Append(LayOutName).Append("\n");
            sb.Append("  imageType: ").Append(ImageType).Append("\n");
            sb.Append("  uuid: ").Append(Uuid).Append("\n");
            sb.Append("  subscriberInPics: ").Append(SubscriberInPics).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestPicLayout);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestPicLayout input)
        {
            if (input == null) return false;
            if (this.SwitchTime != input.SwitchTime || (this.SwitchTime != null && !this.SwitchTime.Equals(input.SwitchTime))) return false;
            if (this.PicNum != input.PicNum || (this.PicNum != null && !this.PicNum.Equals(input.PicNum))) return false;
            if (this.LayOutName != input.LayOutName || (this.LayOutName != null && !this.LayOutName.Equals(input.LayOutName))) return false;
            if (this.ImageType != input.ImageType || (this.ImageType != null && !this.ImageType.Equals(input.ImageType))) return false;
            if (this.Uuid != input.Uuid || (this.Uuid != null && !this.Uuid.Equals(input.Uuid))) return false;
            if (this.SubscriberInPics != input.SubscriberInPics || (this.SubscriberInPics != null && input.SubscriberInPics != null && !this.SubscriberInPics.SequenceEqual(input.SubscriberInPics))) return false;

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
                if (this.SwitchTime != null) hashCode = hashCode * 59 + this.SwitchTime.GetHashCode();
                if (this.PicNum != null) hashCode = hashCode * 59 + this.PicNum.GetHashCode();
                if (this.LayOutName != null) hashCode = hashCode * 59 + this.LayOutName.GetHashCode();
                if (this.ImageType != null) hashCode = hashCode * 59 + this.ImageType.GetHashCode();
                if (this.Uuid != null) hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.SubscriberInPics != null) hashCode = hashCode * 59 + this.SubscriberInPics.GetHashCode();
                return hashCode;
            }
        }
    }
}
