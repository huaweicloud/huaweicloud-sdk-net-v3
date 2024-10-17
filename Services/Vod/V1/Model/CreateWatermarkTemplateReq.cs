using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateWatermarkTemplateReq 
    {
        /// <summary>
        /// 水印类型，当前只支持Image（图片水印）。
        /// </summary>
        /// <value>水印类型，当前只支持Image（图片水印）。</value>
        [JsonConverter(typeof(EnumClassConverter<WatermarkTypeEnum>))]
        public class WatermarkTypeEnum
        {
            /// <summary>
            /// Enum IMAGE for value: IMAGE
            /// </summary>
            public static readonly WatermarkTypeEnum IMAGE = new WatermarkTypeEnum("IMAGE");

            /// <summary>
            /// Enum TEXT for value: TEXT
            /// </summary>
            public static readonly WatermarkTypeEnum TEXT = new WatermarkTypeEnum("TEXT");

            private static readonly Dictionary<string, WatermarkTypeEnum> StaticFields =
            new Dictionary<string, WatermarkTypeEnum>()
            {
                { "IMAGE", IMAGE },
                { "TEXT", TEXT },
            };

            private string _value;

            public WatermarkTypeEnum()
            {

            }

            public WatermarkTypeEnum(string value)
            {
                _value = value;
            }

            public static WatermarkTypeEnum FromValue(string value)
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

                if (this.Equals(obj as WatermarkTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(WatermarkTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(WatermarkTypeEnum a, WatermarkTypeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(WatermarkTypeEnum a, WatermarkTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// type设置为Image时有效。  目前包括： - Original：只做简单缩放，不做其他处理 - Transparent：图片底色透明 - Grayed：彩色图片变灰
        /// </summary>
        /// <value>type设置为Image时有效。  目前包括： - Original：只做简单缩放，不做其他处理 - Transparent：图片底色透明 - Grayed：彩色图片变灰</value>
        [JsonConverter(typeof(EnumClassConverter<ImageProcessEnum>))]
        public class ImageProcessEnum
        {
            /// <summary>
            /// Enum ORIGINAL for value: ORIGINAL
            /// </summary>
            public static readonly ImageProcessEnum ORIGINAL = new ImageProcessEnum("ORIGINAL");

            /// <summary>
            /// Enum TRANSPARENT for value: TRANSPARENT
            /// </summary>
            public static readonly ImageProcessEnum TRANSPARENT = new ImageProcessEnum("TRANSPARENT");

            /// <summary>
            /// Enum GRAYED for value: GRAYED
            /// </summary>
            public static readonly ImageProcessEnum GRAYED = new ImageProcessEnum("GRAYED");

            private static readonly Dictionary<string, ImageProcessEnum> StaticFields =
            new Dictionary<string, ImageProcessEnum>()
            {
                { "ORIGINAL", ORIGINAL },
                { "TRANSPARENT", TRANSPARENT },
                { "GRAYED", GRAYED },
            };

            private string _value;

            public ImageProcessEnum()
            {

            }

            public ImageProcessEnum(string value)
            {
                _value = value;
            }

            public static ImageProcessEnum FromValue(string value)
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

                if (this.Equals(obj as ImageProcessEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ImageProcessEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ImageProcessEnum a, ImageProcessEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ImageProcessEnum a, ImageProcessEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 水印的位置。
        /// </summary>
        /// <value>水印的位置。</value>
        [JsonConverter(typeof(EnumClassConverter<PositionEnum>))]
        public class PositionEnum
        {
            /// <summary>
            /// Enum TOPRIGHT for value: TOPRIGHT
            /// </summary>
            public static readonly PositionEnum TOPRIGHT = new PositionEnum("TOPRIGHT");

            /// <summary>
            /// Enum TOPLEFT for value: TOPLEFT
            /// </summary>
            public static readonly PositionEnum TOPLEFT = new PositionEnum("TOPLEFT");

            /// <summary>
            /// Enum BOTTOMRIGHT for value: BOTTOMRIGHT
            /// </summary>
            public static readonly PositionEnum BOTTOMRIGHT = new PositionEnum("BOTTOMRIGHT");

            /// <summary>
            /// Enum BOTTOMLEFT for value: BOTTOMLEFT
            /// </summary>
            public static readonly PositionEnum BOTTOMLEFT = new PositionEnum("BOTTOMLEFT");

            private static readonly Dictionary<string, PositionEnum> StaticFields =
            new Dictionary<string, PositionEnum>()
            {
                { "TOPRIGHT", TOPRIGHT },
                { "TOPLEFT", TOPLEFT },
                { "BOTTOMRIGHT", BOTTOMRIGHT },
                { "BOTTOMLEFT", BOTTOMLEFT },
            };

            private string _value;

            public PositionEnum()
            {

            }

            public PositionEnum(string value)
            {
                _value = value;
            }

            public static PositionEnum FromValue(string value)
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

                if (this.Equals(obj as PositionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PositionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PositionEnum a, PositionEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(PositionEnum a, PositionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 水印模板名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 水印类型，当前只支持Image（图片水印）。
        /// </summary>
        [JsonProperty("watermark_type", NullValueHandling = NullValueHandling.Ignore)]
        public WatermarkTypeEnum WatermarkType { get; set; }
        /// <summary>
        /// type设置为Image时有效。  目前包括： - Original：只做简单缩放，不做其他处理 - Transparent：图片底色透明 - Grayed：彩色图片变灰
        /// </summary>
        [JsonProperty("image_process", NullValueHandling = NullValueHandling.Ignore)]
        public ImageProcessEnum ImageProcess { get; set; }
        /// <summary>
        /// 水印图片相对输出视频的水平偏移量，默认值是0。
        /// </summary>
        [JsonProperty("dx", NullValueHandling = NullValueHandling.Ignore)]
        public string Dx { get; set; }

        /// <summary>
        /// 水印图片相对输出视频的垂直偏移量，默认值是0。
        /// </summary>
        [JsonProperty("dy", NullValueHandling = NullValueHandling.Ignore)]
        public string Dy { get; set; }

        /// <summary>
        /// 水印的位置。
        /// </summary>
        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public PositionEnum Position { get; set; }
        /// <summary>
        /// 水印图片宽。
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public string Width { get; set; }

        /// <summary>
        /// 水印图片高。
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public string Height { get; set; }

        /// <summary>
        /// 水印开始时间，与\&quot;timeline_duration\&quot;配合使用。 取值范围:[0, END)。\&quot;END\&quot;表示视频结束时间。 单位:秒。 
        /// </summary>
        [JsonProperty("timeline_start", NullValueHandling = NullValueHandling.Ignore)]
        public string TimelineStart { get; set; }

        /// <summary>
        /// 水印持续时间，与\&quot;timeline_start\&quot;配合使用。 取值范围:(0,END-开始时间]。\&quot;END\&quot;表示视频结束时间。 单位:秒。 默认:END。 
        /// </summary>
        [JsonProperty("timeline_duration", NullValueHandling = NullValueHandling.Ignore)]
        public string TimelineDuration { get; set; }

        /// <summary>
        /// 水印图片格式类型。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 水印图片MD5值。
        /// </summary>
        [JsonProperty("md5", NullValueHandling = NullValueHandling.Ignore)]
        public string Md5 { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateWatermarkTemplateReq {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  watermarkType: ").Append(WatermarkType).Append("\n");
            sb.Append("  imageProcess: ").Append(ImageProcess).Append("\n");
            sb.Append("  dx: ").Append(Dx).Append("\n");
            sb.Append("  dy: ").Append(Dy).Append("\n");
            sb.Append("  position: ").Append(Position).Append("\n");
            sb.Append("  width: ").Append(Width).Append("\n");
            sb.Append("  height: ").Append(Height).Append("\n");
            sb.Append("  timelineStart: ").Append(TimelineStart).Append("\n");
            sb.Append("  timelineDuration: ").Append(TimelineDuration).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  md5: ").Append(Md5).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateWatermarkTemplateReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateWatermarkTemplateReq input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.WatermarkType != input.WatermarkType) return false;
            if (this.ImageProcess != input.ImageProcess) return false;
            if (this.Dx != input.Dx || (this.Dx != null && !this.Dx.Equals(input.Dx))) return false;
            if (this.Dy != input.Dy || (this.Dy != null && !this.Dy.Equals(input.Dy))) return false;
            if (this.Position != input.Position) return false;
            if (this.Width != input.Width || (this.Width != null && !this.Width.Equals(input.Width))) return false;
            if (this.Height != input.Height || (this.Height != null && !this.Height.Equals(input.Height))) return false;
            if (this.TimelineStart != input.TimelineStart || (this.TimelineStart != null && !this.TimelineStart.Equals(input.TimelineStart))) return false;
            if (this.TimelineDuration != input.TimelineDuration || (this.TimelineDuration != null && !this.TimelineDuration.Equals(input.TimelineDuration))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Md5 != input.Md5 || (this.Md5 != null && !this.Md5.Equals(input.Md5))) return false;

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
                hashCode = hashCode * 59 + this.WatermarkType.GetHashCode();
                hashCode = hashCode * 59 + this.ImageProcess.GetHashCode();
                if (this.Dx != null) hashCode = hashCode * 59 + this.Dx.GetHashCode();
                if (this.Dy != null) hashCode = hashCode * 59 + this.Dy.GetHashCode();
                hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.Width != null) hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null) hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.TimelineStart != null) hashCode = hashCode * 59 + this.TimelineStart.GetHashCode();
                if (this.TimelineDuration != null) hashCode = hashCode * 59 + this.TimelineDuration.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Md5 != null) hashCode = hashCode * 59 + this.Md5.GetHashCode();
                return hashCode;
            }
        }
    }
}
