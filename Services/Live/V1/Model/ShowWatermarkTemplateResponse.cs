using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowWatermarkTemplateResponse : SdkResponse
    {
        /// <summary>
        /// 业务属性，cloud_live：云直播，默认值；media_live：媒体直播，不支持修改
        /// </summary>
        /// <value>业务属性，cloud_live：云直播，默认值；media_live：媒体直播，不支持修改</value>
        [JsonConverter(typeof(EnumClassConverter<SceneEnum>))]
        public class SceneEnum
        {
            /// <summary>
            /// Enum CLOUD_LIVE for value: cloud_live
            /// </summary>
            public static readonly SceneEnum CLOUD_LIVE = new SceneEnum("cloud_live");

            /// <summary>
            /// Enum MEDIA_LIVE for value: media_live
            /// </summary>
            public static readonly SceneEnum MEDIA_LIVE = new SceneEnum("media_live");

            private static readonly Dictionary<string, SceneEnum> StaticFields =
            new Dictionary<string, SceneEnum>()
            {
                { "cloud_live", CLOUD_LIVE },
                { "media_live", MEDIA_LIVE },
            };

            private string _value;

            public SceneEnum()
            {

            }

            public SceneEnum(string value)
            {
                _value = value;
            }

            public static SceneEnum FromValue(string value)
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

                if (this.Equals(obj as SceneEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SceneEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SceneEnum a, SceneEnum b)
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

            public static bool operator !=(SceneEnum a, SceneEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 水印模板名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 水印类型，0图片，1文字,2图文共存
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; }

        /// <summary>
        /// 模板注释
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 图片下载路径 校验规则：图片URL长度大于0，最大长度2048，能够正常按URL格式解析，必须是 http 或 https 协议。（OTT 场景限制只支持https） 图片格式: .png/.jpg/.PNG/.JPG结尾
        /// </summary>
        [JsonProperty("picture_url", NullValueHandling = NullValueHandling.Ignore)]
        public string PictureUrl { get; set; }

        /// <summary>
        /// 1）整数型代表水印图片宽的像素值，范围0或[8，4096]，单位px。 2）小数型代表相对输出视频分辨率宽的比率，范围[0,1) 建议宽高只设置一项，另外一项会自适应缩放，避免变形。宽高全部设置为0表示水印图片原始宽高 百分比限制最多保留小数点后4位，width和height 只支持同时为像素或是百分比，不支持一个像素，一个百分比
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Width { get; set; }

        /// <summary>
        /// 水印图片高，值有两种形式： 1）整数型代表水印图片高的像素值，范围0或[8，4096]，单位px。 2）小数型代表相对输出视频分辨率高的比率，范围[0，1) 建议宽高只设置一项，另外一项会自适应缩放，避免变形。宽高全部设置为0表示水印图片原始宽高 百分比限制最多保留小数点后4位，width和height 只支持同时为像素或是百分比，不支持一个像素，一个百分比
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Height { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public WatermarkLocation Location { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public WordWaterMarkInfo Text { get; set; }

        /// <summary>
        /// 业务属性，cloud_live：云直播，默认值；media_live：媒体直播，不支持修改
        /// </summary>
        [JsonProperty("scene", NullValueHandling = NullValueHandling.Ignore)]
        public SceneEnum Scene { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-request-id", IsHeader = true)]
        [JsonProperty("X-request-id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowWatermarkTemplateResponse {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  pictureUrl: ").Append(PictureUrl).Append("\n");
            sb.Append("  width: ").Append(Width).Append("\n");
            sb.Append("  height: ").Append(Height).Append("\n");
            sb.Append("  location: ").Append(Location).Append("\n");
            sb.Append("  text: ").Append(Text).Append("\n");
            sb.Append("  scene: ").Append(Scene).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowWatermarkTemplateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowWatermarkTemplateResponse input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.PictureUrl != input.PictureUrl || (this.PictureUrl != null && !this.PictureUrl.Equals(input.PictureUrl))) return false;
            if (this.Width != input.Width || (this.Width != null && !this.Width.Equals(input.Width))) return false;
            if (this.Height != input.Height || (this.Height != null && !this.Height.Equals(input.Height))) return false;
            if (this.Location != input.Location || (this.Location != null && !this.Location.Equals(input.Location))) return false;
            if (this.Text != input.Text || (this.Text != null && !this.Text.Equals(input.Text))) return false;
            if (this.Scene != input.Scene) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.PictureUrl != null) hashCode = hashCode * 59 + this.PictureUrl.GetHashCode();
                if (this.Width != null) hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null) hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Location != null) hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Text != null) hashCode = hashCode * 59 + this.Text.GetHashCode();
                hashCode = hashCode * 59 + this.Scene.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
