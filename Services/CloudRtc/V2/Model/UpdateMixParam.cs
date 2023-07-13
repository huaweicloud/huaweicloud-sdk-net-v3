using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudRtc.V2.Model
{
    /// <summary>
    /// 可修改的合流参数
    /// </summary>
    public class UpdateMixParam 
    {

        /// <summary>
        /// 视频布局模板编号，仅支持自定义模板之间的更新。
        /// </summary>
        [JsonProperty("layout_template", NullValueHandling = NullValueHandling.Ignore)]
        public string LayoutTemplate { get; set; }

        /// <summary>
        /// 画布背景图地址，图片先上传obs。默认使用等比缩放裁剪，保证铺满。格式s3://bucket/object
        /// </summary>
        [JsonProperty("background_image", NullValueHandling = NullValueHandling.Ignore)]
        public string BackgroundImage { get; set; }

        /// <summary>
        /// 默认用户背景图地址，图片先上传obs，格式s3://bucket/object。默认使用等比缩放裁剪，保证铺满。
        /// </summary>
        [JsonProperty("default_user_background_image", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultUserBackgroundImage { get; set; }

        /// <summary>
        /// 共享屏幕的背景图地址，图片先上传obs，格式s3://bucket/object。  在一大多小的布局场景下，无论大窗是显示非指定用户（屏幕共享人的桌面）还是指定用户的共享桌面，都通过该字段指定背景图。 
        /// </summary>
        [JsonProperty("screen_background_image", NullValueHandling = NullValueHandling.Ignore)]
        public string ScreenBackgroundImage { get; set; }

        /// <summary>
        /// 最长空闲频道时间。  取值范围：[5，43200]，默认值为30。  单位：秒。  如果频道内无连麦方的状态持续超过该时间，录制程序会自动退出。退出后，再次调用start请求，会产生新的录制任务。  连麦方指：joiner或者publisher的用户。 
        /// </summary>
        [JsonProperty("max_idle_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxIdleTime { get; set; }

        /// <summary>
        /// 需要混流的视频列表。若不需要视频混流，则可不传递该参数。
        /// </summary>
        [JsonProperty("layout_panes", NullValueHandling = NullValueHandling.Ignore)]
        public List<MixLayoutPane> LayoutPanes { get; set; }

        /// <summary>
        /// 指定用户背景图，优先级大于default_user_background_image
        /// </summary>
        [JsonProperty("user_background_images", NullValueHandling = NullValueHandling.Ignore)]
        public List<MixUserBackgroundImage> UserBackgroundImages { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateMixParam {\n");
            sb.Append("  layoutTemplate: ").Append(LayoutTemplate).Append("\n");
            sb.Append("  backgroundImage: ").Append(BackgroundImage).Append("\n");
            sb.Append("  defaultUserBackgroundImage: ").Append(DefaultUserBackgroundImage).Append("\n");
            sb.Append("  screenBackgroundImage: ").Append(ScreenBackgroundImage).Append("\n");
            sb.Append("  maxIdleTime: ").Append(MaxIdleTime).Append("\n");
            sb.Append("  layoutPanes: ").Append(LayoutPanes).Append("\n");
            sb.Append("  userBackgroundImages: ").Append(UserBackgroundImages).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateMixParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateMixParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LayoutTemplate == input.LayoutTemplate ||
                    (this.LayoutTemplate != null &&
                    this.LayoutTemplate.Equals(input.LayoutTemplate))
                ) && 
                (
                    this.BackgroundImage == input.BackgroundImage ||
                    (this.BackgroundImage != null &&
                    this.BackgroundImage.Equals(input.BackgroundImage))
                ) && 
                (
                    this.DefaultUserBackgroundImage == input.DefaultUserBackgroundImage ||
                    (this.DefaultUserBackgroundImage != null &&
                    this.DefaultUserBackgroundImage.Equals(input.DefaultUserBackgroundImage))
                ) && 
                (
                    this.ScreenBackgroundImage == input.ScreenBackgroundImage ||
                    (this.ScreenBackgroundImage != null &&
                    this.ScreenBackgroundImage.Equals(input.ScreenBackgroundImage))
                ) && 
                (
                    this.MaxIdleTime == input.MaxIdleTime ||
                    (this.MaxIdleTime != null &&
                    this.MaxIdleTime.Equals(input.MaxIdleTime))
                ) && 
                (
                    this.LayoutPanes == input.LayoutPanes ||
                    this.LayoutPanes != null &&
                    input.LayoutPanes != null &&
                    this.LayoutPanes.SequenceEqual(input.LayoutPanes)
                ) && 
                (
                    this.UserBackgroundImages == input.UserBackgroundImages ||
                    this.UserBackgroundImages != null &&
                    input.UserBackgroundImages != null &&
                    this.UserBackgroundImages.SequenceEqual(input.UserBackgroundImages)
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
                if (this.LayoutTemplate != null)
                    hashCode = hashCode * 59 + this.LayoutTemplate.GetHashCode();
                if (this.BackgroundImage != null)
                    hashCode = hashCode * 59 + this.BackgroundImage.GetHashCode();
                if (this.DefaultUserBackgroundImage != null)
                    hashCode = hashCode * 59 + this.DefaultUserBackgroundImage.GetHashCode();
                if (this.ScreenBackgroundImage != null)
                    hashCode = hashCode * 59 + this.ScreenBackgroundImage.GetHashCode();
                if (this.MaxIdleTime != null)
                    hashCode = hashCode * 59 + this.MaxIdleTime.GetHashCode();
                if (this.LayoutPanes != null)
                    hashCode = hashCode * 59 + this.LayoutPanes.GetHashCode();
                if (this.UserBackgroundImages != null)
                    hashCode = hashCode * 59 + this.UserBackgroundImages.GetHashCode();
                return hashCode;
            }
        }
    }
}
