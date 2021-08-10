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
    public class UpdateWatermarkTemplateReq 
    {
        /// <summary>
        /// 水印的位置&lt;br/&gt;
        /// </summary>
        /// <value>水印的位置&lt;br/&gt;</value>
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

            private string Value;

            public PositionEnum(string value)
            {
                Value = value;
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
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
        /// 水印类型，当前只支持Image（图片水印）&lt;br/&gt;
        /// </summary>
        /// <value>水印类型，当前只支持Image（图片水印）&lt;br/&gt;</value>
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

            private string Value;

            public WatermarkTypeEnum(string value)
            {
                Value = value;
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
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

            private string Value;

            public ImageProcessEnum(string value)
            {
                Value = value;
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
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
        /// 水印模板配置id&lt;br/&gt;
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 水印模板名称&lt;br/&gt;
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 水印图片相对输出视频的水平偏移量，默认值是0&lt;br/&gt;
        /// </summary>
        [JsonProperty("dx", NullValueHandling = NullValueHandling.Ignore)]
        public string Dx { get; set; }

        /// <summary>
        /// 水印图片相对输出视频的垂直偏移量，默认值是0&lt;br/&gt;
        /// </summary>
        [JsonProperty("dy", NullValueHandling = NullValueHandling.Ignore)]
        public string Dy { get; set; }

        /// <summary>
        /// 水印的位置&lt;br/&gt;
        /// </summary>
        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public PositionEnum Position { get; set; }
        /// <summary>
        /// 水印图片宽&lt;br/&gt;
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public string Width { get; set; }

        /// <summary>
        /// 水印图片高&lt;br/&gt;
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public string Height { get; set; }

        /// <summary>
        /// 水印类型，当前只支持Image（图片水印）&lt;br/&gt;
        /// </summary>
        [JsonProperty("watermark_type", NullValueHandling = NullValueHandling.Ignore)]
        public WatermarkTypeEnum WatermarkType { get; set; }
        /// <summary>
        /// type设置为Image时有效。  目前包括： - Original：只做简单缩放，不做其他处理 - Transparent：图片底色透明 - Grayed：彩色图片变灰
        /// </summary>
        [JsonProperty("image_process", NullValueHandling = NullValueHandling.Ignore)]
        public ImageProcessEnum ImageProcess { get; set; }
        /// <summary>
        /// 水印开始时间&lt;br/&gt;
        /// </summary>
        [JsonProperty("timeline_start", NullValueHandling = NullValueHandling.Ignore)]
        public string TimelineStart { get; set; }

        /// <summary>
        /// 水印持续时间&lt;br/&gt;
        /// </summary>
        [JsonProperty("timeline_duration", NullValueHandling = NullValueHandling.Ignore)]
        public string TimelineDuration { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateWatermarkTemplateReq {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  dx: ").Append(Dx).Append("\n");
            sb.Append("  dy: ").Append(Dy).Append("\n");
            sb.Append("  position: ").Append(Position).Append("\n");
            sb.Append("  width: ").Append(Width).Append("\n");
            sb.Append("  height: ").Append(Height).Append("\n");
            sb.Append("  watermarkType: ").Append(WatermarkType).Append("\n");
            sb.Append("  imageProcess: ").Append(ImageProcess).Append("\n");
            sb.Append("  timelineStart: ").Append(TimelineStart).Append("\n");
            sb.Append("  timelineDuration: ").Append(TimelineDuration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateWatermarkTemplateReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateWatermarkTemplateReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Dx == input.Dx ||
                    (this.Dx != null &&
                    this.Dx.Equals(input.Dx))
                ) && 
                (
                    this.Dy == input.Dy ||
                    (this.Dy != null &&
                    this.Dy.Equals(input.Dy))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.WatermarkType == input.WatermarkType ||
                    (this.WatermarkType != null &&
                    this.WatermarkType.Equals(input.WatermarkType))
                ) && 
                (
                    this.ImageProcess == input.ImageProcess ||
                    (this.ImageProcess != null &&
                    this.ImageProcess.Equals(input.ImageProcess))
                ) && 
                (
                    this.TimelineStart == input.TimelineStart ||
                    (this.TimelineStart != null &&
                    this.TimelineStart.Equals(input.TimelineStart))
                ) && 
                (
                    this.TimelineDuration == input.TimelineDuration ||
                    (this.TimelineDuration != null &&
                    this.TimelineDuration.Equals(input.TimelineDuration))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Dx != null)
                    hashCode = hashCode * 59 + this.Dx.GetHashCode();
                if (this.Dy != null)
                    hashCode = hashCode * 59 + this.Dy.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.WatermarkType != null)
                    hashCode = hashCode * 59 + this.WatermarkType.GetHashCode();
                if (this.ImageProcess != null)
                    hashCode = hashCode * 59 + this.ImageProcess.GetHashCode();
                if (this.TimelineStart != null)
                    hashCode = hashCode * 59 + this.TimelineStart.GetHashCode();
                if (this.TimelineDuration != null)
                    hashCode = hashCode * 59 + this.TimelineDuration.GetHashCode();
                return hashCode;
            }
        }
    }
}
