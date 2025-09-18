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
    /// 合流参数  - 纯音频录制  encode_template 填 audio_only，音频合流会动态选择最大三方的声音。  layout_template、layout_panes 以及其他视频相关参数都不填，填就忽略。  - 音视频录制（包括共享桌面）  encode_template 非 audio_only，layout_template必须非空。  音频合流会动态选择最大三方的声音 
    /// </summary>
    public class MixParam 
    {
        /// <summary>
        /// 输出编码模板名称 - 1920*1080_30_4620：输出流是1080p，帧率30，码率4.62Mbps - 1920*1080_30_3150：输出流是1080p，帧率30，码率3.15Mbps - 1920*1080_15_3460：输出流是1080p，帧率15，码率3.46Mbps - 1920*1080_15_2080：输出流是1080p，帧率15，码率2.08Mbps - 1280*720_30_3420：输出流是720p，帧率30，码率3.42Mbps - 1280*720_30_1710：输出流是720p，帧率30，码率1.71Mbps - 1280*720_15_2260：输出流是720p，帧率15，码率2.26Mbps - 1280*720_15_1130：输出流是720p，帧率15，码率1.13Mbps - 640*480_30_1500：输出流是480p，帧率30，码率1.50Mbps - 640*480_15_500：输出流是480p，帧率15，码率500Kbps - 640*480_30_1000 输出流是480p，帧率30，码率1000Kbps - 480*360_30_490：输出流是360p，帧率30，码率490Kbps - 480*360_15_320：输出流是360p，帧率15，码率320Kbps 
        /// </summary>
        /// <value>输出编码模板名称 - 1920*1080_30_4620：输出流是1080p，帧率30，码率4.62Mbps - 1920*1080_30_3150：输出流是1080p，帧率30，码率3.15Mbps - 1920*1080_15_3460：输出流是1080p，帧率15，码率3.46Mbps - 1920*1080_15_2080：输出流是1080p，帧率15，码率2.08Mbps - 1280*720_30_3420：输出流是720p，帧率30，码率3.42Mbps - 1280*720_30_1710：输出流是720p，帧率30，码率1.71Mbps - 1280*720_15_2260：输出流是720p，帧率15，码率2.26Mbps - 1280*720_15_1130：输出流是720p，帧率15，码率1.13Mbps - 640*480_30_1500：输出流是480p，帧率30，码率1.50Mbps - 640*480_15_500：输出流是480p，帧率15，码率500Kbps - 640*480_30_1000 输出流是480p，帧率30，码率1000Kbps - 480*360_30_490：输出流是360p，帧率30，码率490Kbps - 480*360_15_320：输出流是360p，帧率15，码率320Kbps </value>
        [JsonConverter(typeof(EnumClassConverter<EncodeTemplateEnum>))]
        public class EncodeTemplateEnum
        {
            /// <summary>
            /// Enum _1920_1080_30_4620 for value: 1920*1080_30_4620
            /// </summary>
            public static readonly EncodeTemplateEnum _1920_1080_30_4620 = new EncodeTemplateEnum("1920*1080_30_4620");

            /// <summary>
            /// Enum _1920_1080_30_3150 for value: 1920*1080_30_3150
            /// </summary>
            public static readonly EncodeTemplateEnum _1920_1080_30_3150 = new EncodeTemplateEnum("1920*1080_30_3150");

            /// <summary>
            /// Enum _1920_1080_15_3460 for value: 1920*1080_15_3460
            /// </summary>
            public static readonly EncodeTemplateEnum _1920_1080_15_3460 = new EncodeTemplateEnum("1920*1080_15_3460");

            /// <summary>
            /// Enum _1920_1080_15_2080 for value: 1920*1080_15_2080
            /// </summary>
            public static readonly EncodeTemplateEnum _1920_1080_15_2080 = new EncodeTemplateEnum("1920*1080_15_2080");

            /// <summary>
            /// Enum _1280_720_30_3420 for value: 1280*720_30_3420
            /// </summary>
            public static readonly EncodeTemplateEnum _1280_720_30_3420 = new EncodeTemplateEnum("1280*720_30_3420");

            /// <summary>
            /// Enum _1280_720_30_1710 for value: 1280*720_30_1710
            /// </summary>
            public static readonly EncodeTemplateEnum _1280_720_30_1710 = new EncodeTemplateEnum("1280*720_30_1710");

            /// <summary>
            /// Enum _1280_720_15_2260 for value: 1280*720_15_2260
            /// </summary>
            public static readonly EncodeTemplateEnum _1280_720_15_2260 = new EncodeTemplateEnum("1280*720_15_2260");

            /// <summary>
            /// Enum _1280_720_15_1130 for value: 1280*720_15_1130
            /// </summary>
            public static readonly EncodeTemplateEnum _1280_720_15_1130 = new EncodeTemplateEnum("1280*720_15_1130");

            /// <summary>
            /// Enum _640_480_30_1000 for value: 640*480_30_1000
            /// </summary>
            public static readonly EncodeTemplateEnum _640_480_30_1000 = new EncodeTemplateEnum("640*480_30_1000");

            /// <summary>
            /// Enum _640_480_30_1500 for value: 640*480_30_1500
            /// </summary>
            public static readonly EncodeTemplateEnum _640_480_30_1500 = new EncodeTemplateEnum("640*480_30_1500");

            /// <summary>
            /// Enum _640_480_15_500 for value: 640*480_15_500
            /// </summary>
            public static readonly EncodeTemplateEnum _640_480_15_500 = new EncodeTemplateEnum("640*480_15_500");

            /// <summary>
            /// Enum _480_360_30_490 for value: 480*360_30_490
            /// </summary>
            public static readonly EncodeTemplateEnum _480_360_30_490 = new EncodeTemplateEnum("480*360_30_490");

            /// <summary>
            /// Enum _480_360_15_320 for value: 480*360_15_320
            /// </summary>
            public static readonly EncodeTemplateEnum _480_360_15_320 = new EncodeTemplateEnum("480*360_15_320");

            private static readonly Dictionary<string, EncodeTemplateEnum> StaticFields =
            new Dictionary<string, EncodeTemplateEnum>()
            {
                { "1920*1080_30_4620", _1920_1080_30_4620 },
                { "1920*1080_30_3150", _1920_1080_30_3150 },
                { "1920*1080_15_3460", _1920_1080_15_3460 },
                { "1920*1080_15_2080", _1920_1080_15_2080 },
                { "1280*720_30_3420", _1280_720_30_3420 },
                { "1280*720_30_1710", _1280_720_30_1710 },
                { "1280*720_15_2260", _1280_720_15_2260 },
                { "1280*720_15_1130", _1280_720_15_1130 },
                { "640*480_30_1000", _640_480_30_1000 },
                { "640*480_30_1500", _640_480_30_1500 },
                { "640*480_15_500", _640_480_15_500 },
                { "480*360_30_490", _480_360_30_490 },
                { "480*360_15_320", _480_360_15_320 },
            };

            private string _value;

            public EncodeTemplateEnum()
            {

            }

            public EncodeTemplateEnum(string value)
            {
                _value = value;
            }

            public static EncodeTemplateEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as EncodeTemplateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EncodeTemplateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EncodeTemplateEnum a, EncodeTemplateEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(EncodeTemplateEnum a, EncodeTemplateEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 房间id
        /// </summary>
        [JsonProperty("room_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RoomId { get; set; }

        /// <summary>
        /// 输出编码模板名称 - 1920*1080_30_4620：输出流是1080p，帧率30，码率4.62Mbps - 1920*1080_30_3150：输出流是1080p，帧率30，码率3.15Mbps - 1920*1080_15_3460：输出流是1080p，帧率15，码率3.46Mbps - 1920*1080_15_2080：输出流是1080p，帧率15，码率2.08Mbps - 1280*720_30_3420：输出流是720p，帧率30，码率3.42Mbps - 1280*720_30_1710：输出流是720p，帧率30，码率1.71Mbps - 1280*720_15_2260：输出流是720p，帧率15，码率2.26Mbps - 1280*720_15_1130：输出流是720p，帧率15，码率1.13Mbps - 640*480_30_1500：输出流是480p，帧率30，码率1.50Mbps - 640*480_15_500：输出流是480p，帧率15，码率500Kbps - 640*480_30_1000 输出流是480p，帧率30，码率1000Kbps - 480*360_30_490：输出流是360p，帧率30，码率490Kbps - 480*360_15_320：输出流是360p，帧率15，码率320Kbps 
        /// </summary>
        [JsonProperty("encode_template", NullValueHandling = NullValueHandling.Ignore)]
        public EncodeTemplateEnum EncodeTemplate { get; set; }
        /// <summary>
        /// 最长空闲频道时间。  取值范围：[5，43200]，默认值为30。  单位：秒。  如果频道内无连麦方的状态持续超过该时间，录制程序会自动退出。退出后，再次调用start请求，会产生新的录制任务。  连麦方指：joiner或者publisher的用户。 
        /// </summary>
        [JsonProperty("max_idle_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxIdleTime { get; set; }

        /// <summary>
        /// 视频布局模板编号，不混视频的时候，不需要带。 - nine_grids_view：九宫格模板（自适应模板） - screen_share_left：主视图在左边的屏幕共享模板（自适应模板） - screen_share_right：主视图在右边的屏幕共享模板（自适应模板） - custom：自定义布局 
        /// </summary>
        [JsonProperty("layout_template", NullValueHandling = NullValueHandling.Ignore)]
        public string LayoutTemplate { get; set; }

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
        /// 画布背景图地址，图片先上传obs，格式s3://bucket/object。默认使用等比缩放裁剪，保证铺满。
        /// </summary>
        [JsonProperty("background_image", NullValueHandling = NullValueHandling.Ignore)]
        public string BackgroundImage { get; set; }

        /// <summary>
        /// 需要混流的视频列表。若不需要混流视频，则可不传递该参数。  nine_grids_view模板不需要填写本字段。 
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
            sb.Append("class MixParam {\n");
            sb.Append("  roomId: ").Append(RoomId).Append("\n");
            sb.Append("  encodeTemplate: ").Append(EncodeTemplate).Append("\n");
            sb.Append("  maxIdleTime: ").Append(MaxIdleTime).Append("\n");
            sb.Append("  layoutTemplate: ").Append(LayoutTemplate).Append("\n");
            sb.Append("  defaultUserBackgroundImage: ").Append(DefaultUserBackgroundImage).Append("\n");
            sb.Append("  screenBackgroundImage: ").Append(ScreenBackgroundImage).Append("\n");
            sb.Append("  backgroundImage: ").Append(BackgroundImage).Append("\n");
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
            return this.Equals(input as MixParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MixParam input)
        {
            if (input == null) return false;
            if (this.RoomId != input.RoomId || (this.RoomId != null && !this.RoomId.Equals(input.RoomId))) return false;
            if (this.EncodeTemplate != input.EncodeTemplate) return false;
            if (this.MaxIdleTime != input.MaxIdleTime || (this.MaxIdleTime != null && !this.MaxIdleTime.Equals(input.MaxIdleTime))) return false;
            if (this.LayoutTemplate != input.LayoutTemplate || (this.LayoutTemplate != null && !this.LayoutTemplate.Equals(input.LayoutTemplate))) return false;
            if (this.DefaultUserBackgroundImage != input.DefaultUserBackgroundImage || (this.DefaultUserBackgroundImage != null && !this.DefaultUserBackgroundImage.Equals(input.DefaultUserBackgroundImage))) return false;
            if (this.ScreenBackgroundImage != input.ScreenBackgroundImage || (this.ScreenBackgroundImage != null && !this.ScreenBackgroundImage.Equals(input.ScreenBackgroundImage))) return false;
            if (this.BackgroundImage != input.BackgroundImage || (this.BackgroundImage != null && !this.BackgroundImage.Equals(input.BackgroundImage))) return false;
            if (this.LayoutPanes != input.LayoutPanes || (this.LayoutPanes != null && input.LayoutPanes != null && !this.LayoutPanes.SequenceEqual(input.LayoutPanes))) return false;
            if (this.UserBackgroundImages != input.UserBackgroundImages || (this.UserBackgroundImages != null && input.UserBackgroundImages != null && !this.UserBackgroundImages.SequenceEqual(input.UserBackgroundImages))) return false;

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
                if (this.RoomId != null) hashCode = hashCode * 59 + this.RoomId.GetHashCode();
                hashCode = hashCode * 59 + this.EncodeTemplate.GetHashCode();
                if (this.MaxIdleTime != null) hashCode = hashCode * 59 + this.MaxIdleTime.GetHashCode();
                if (this.LayoutTemplate != null) hashCode = hashCode * 59 + this.LayoutTemplate.GetHashCode();
                if (this.DefaultUserBackgroundImage != null) hashCode = hashCode * 59 + this.DefaultUserBackgroundImage.GetHashCode();
                if (this.ScreenBackgroundImage != null) hashCode = hashCode * 59 + this.ScreenBackgroundImage.GetHashCode();
                if (this.BackgroundImage != null) hashCode = hashCode * 59 + this.BackgroundImage.GetHashCode();
                if (this.LayoutPanes != null) hashCode = hashCode * 59 + this.LayoutPanes.GetHashCode();
                if (this.UserBackgroundImages != null) hashCode = hashCode * 59 + this.UserBackgroundImages.GetHashCode();
                return hashCode;
            }
        }
    }
}
