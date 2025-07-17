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
    /// Response Object
    /// </summary>
    public class ShowRoomSettingResponse : SdkResponse
    {

        /// <summary>
        /// 网络研讨会介绍。
        /// </summary>
        [JsonProperty("roomIntroduce", NullValueHandling = NullValueHandling.Ignore)]
        public string RoomIntroduce { get; set; }

        /// <summary>
        /// 企业Logo的文件id。
        /// </summary>
        [JsonProperty("cropLogoId", NullValueHandling = NullValueHandling.Ignore)]
        public string CropLogoId { get; set; }

        /// <summary>
        /// 欢迎界面的文件id。
        /// </summary>
        [JsonProperty("coverPictureId", NullValueHandling = NullValueHandling.Ignore)]
        public string CoverPictureId { get; set; }

        /// <summary>
        /// 显示观众人数的模式。默认值为real_time。 - none: 不显示 - real_time: 实时显示 
        /// </summary>
        [JsonProperty("showAudienceMode", NullValueHandling = NullValueHandling.Ignore)]
        public string ShowAudienceMode { get; set; }

        /// <summary>
        /// 智能倍增开关。默认值为Y。 - Y 开启智能倍增 - N 关闭智能倍增 
        /// </summary>
        [JsonProperty("isRedoubleOpen", NullValueHandling = NullValueHandling.Ignore)]
        public string IsRedoubleOpen { get; set; }

        /// <summary>
        /// 基础设置人数(网络研讨会没人时显示的人数)。默认值为0。取值范围为[0, 10000]。
        /// </summary>
        [JsonProperty("baseAudienceCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? BaseAudienceCount { get; set; }

        /// <summary>
        /// 设置倍数(基础人数+真实人数*倍数)。默认值为1.0。 取值范围为[0, 10]，取1位小数。
        /// </summary>
        [JsonProperty("multiple", NullValueHandling = NullValueHandling.Ignore)]
        public double? Multiple { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRoomSettingResponse {\n");
            sb.Append("  roomIntroduce: ").Append(RoomIntroduce).Append("\n");
            sb.Append("  cropLogoId: ").Append(CropLogoId).Append("\n");
            sb.Append("  coverPictureId: ").Append(CoverPictureId).Append("\n");
            sb.Append("  showAudienceMode: ").Append(ShowAudienceMode).Append("\n");
            sb.Append("  isRedoubleOpen: ").Append(IsRedoubleOpen).Append("\n");
            sb.Append("  baseAudienceCount: ").Append(BaseAudienceCount).Append("\n");
            sb.Append("  multiple: ").Append(Multiple).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRoomSettingResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRoomSettingResponse input)
        {
            if (input == null) return false;
            if (this.RoomIntroduce != input.RoomIntroduce || (this.RoomIntroduce != null && !this.RoomIntroduce.Equals(input.RoomIntroduce))) return false;
            if (this.CropLogoId != input.CropLogoId || (this.CropLogoId != null && !this.CropLogoId.Equals(input.CropLogoId))) return false;
            if (this.CoverPictureId != input.CoverPictureId || (this.CoverPictureId != null && !this.CoverPictureId.Equals(input.CoverPictureId))) return false;
            if (this.ShowAudienceMode != input.ShowAudienceMode || (this.ShowAudienceMode != null && !this.ShowAudienceMode.Equals(input.ShowAudienceMode))) return false;
            if (this.IsRedoubleOpen != input.IsRedoubleOpen || (this.IsRedoubleOpen != null && !this.IsRedoubleOpen.Equals(input.IsRedoubleOpen))) return false;
            if (this.BaseAudienceCount != input.BaseAudienceCount || (this.BaseAudienceCount != null && !this.BaseAudienceCount.Equals(input.BaseAudienceCount))) return false;
            if (this.Multiple != input.Multiple || (this.Multiple != null && !this.Multiple.Equals(input.Multiple))) return false;

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
                if (this.RoomIntroduce != null) hashCode = hashCode * 59 + this.RoomIntroduce.GetHashCode();
                if (this.CropLogoId != null) hashCode = hashCode * 59 + this.CropLogoId.GetHashCode();
                if (this.CoverPictureId != null) hashCode = hashCode * 59 + this.CoverPictureId.GetHashCode();
                if (this.ShowAudienceMode != null) hashCode = hashCode * 59 + this.ShowAudienceMode.GetHashCode();
                if (this.IsRedoubleOpen != null) hashCode = hashCode * 59 + this.IsRedoubleOpen.GetHashCode();
                if (this.BaseAudienceCount != null) hashCode = hashCode * 59 + this.BaseAudienceCount.GetHashCode();
                if (this.Multiple != null) hashCode = hashCode * 59 + this.Multiple.GetHashCode();
                return hashCode;
            }
        }
    }
}
