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
    public class ObjectThumbnailTask 
    {
        /// <summary>
        /// 采样类型。 取值如下： PERCENT：根据视频时长百分比间隔采样时的百分比值。 DOTS：指定时间点截图。选择同步截图时，需指定此类型。 
        /// </summary>
        /// <value>采样类型。 取值如下： PERCENT：根据视频时长百分比间隔采样时的百分比值。 DOTS：指定时间点截图。选择同步截图时，需指定此类型。 </value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum PERCENT for value: PERCENT
            /// </summary>
            public static readonly TypeEnum PERCENT = new TypeEnum("PERCENT");

            /// <summary>
            /// Enum DOTS for value: DOTS
            /// </summary>
            public static readonly TypeEnum DOTS = new TypeEnum("DOTS");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "PERCENT", PERCENT },
                { "DOTS", DOTS },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 截图文件格式 取值如下：jpg、png 
        /// </summary>
        /// <value>截图文件格式 取值如下：jpg、png </value>
        [JsonConverter(typeof(EnumClassConverter<FormatEnum>))]
        public class FormatEnum
        {
            /// <summary>
            /// Enum JPG for value: jpg
            /// </summary>
            public static readonly FormatEnum JPG = new FormatEnum("jpg");

            /// <summary>
            /// Enum PNG for value: png
            /// </summary>
            public static readonly FormatEnum PNG = new FormatEnum("png");

            private static readonly Dictionary<string, FormatEnum> StaticFields =
            new Dictionary<string, FormatEnum>()
            {
                { "jpg", JPG },
                { "png", PNG },
            };

            private string _value;

            public FormatEnum()
            {

            }

            public FormatEnum(string value)
            {
                _value = value;
            }

            public static FormatEnum FromValue(string value)
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

                if (this.Equals(obj as FormatEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FormatEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FormatEnum a, FormatEnum b)
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

            public static bool operator !=(FormatEnum a, FormatEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 填充方式，当视频流配置宽高参数与原始视频的宽高比不一致时，对转码的处理方式，即为“填充”。可选填充方式： - stretch：拉伸，对每一帧进行拉伸，填满整个画面，可能导致转码后的视频被“压扁“或者“拉长“； - black：留黑，保持视频宽高比不变，边缘剩余部分使用黑色填充。 - white：留白，保持视频宽高比不变，边缘剩余部分使用白色填充。 
        /// </summary>
        /// <value>填充方式，当视频流配置宽高参数与原始视频的宽高比不一致时，对转码的处理方式，即为“填充”。可选填充方式： - stretch：拉伸，对每一帧进行拉伸，填满整个画面，可能导致转码后的视频被“压扁“或者“拉长“； - black：留黑，保持视频宽高比不变，边缘剩余部分使用黑色填充。 - white：留白，保持视频宽高比不变，边缘剩余部分使用白色填充。 </value>
        [JsonConverter(typeof(EnumClassConverter<FillTypeEnum>))]
        public class FillTypeEnum
        {
            /// <summary>
            /// Enum STRETCH for value: stretch
            /// </summary>
            public static readonly FillTypeEnum STRETCH = new FillTypeEnum("stretch");

            /// <summary>
            /// Enum BLACK for value: black
            /// </summary>
            public static readonly FillTypeEnum BLACK = new FillTypeEnum("black");

            /// <summary>
            /// Enum WHITE for value: white
            /// </summary>
            public static readonly FillTypeEnum WHITE = new FillTypeEnum("white");

            /// <summary>
            /// Enum GAUSS for value: gauss
            /// </summary>
            public static readonly FillTypeEnum GAUSS = new FillTypeEnum("gauss");

            private static readonly Dictionary<string, FillTypeEnum> StaticFields =
            new Dictionary<string, FillTypeEnum>()
            {
                { "stretch", STRETCH },
                { "black", BLACK },
                { "white", WHITE },
                { "gauss", GAUSS },
            };

            private string _value;

            public FillTypeEnum()
            {

            }

            public FillTypeEnum(string value)
            {
                _value = value;
            }

            public static FillTypeEnum FromValue(string value)
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

                if (this.Equals(obj as FillTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FillTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FillTypeEnum a, FillTypeEnum b)
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

            public static bool operator !=(FillTypeEnum a, FillTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 采样类型。 取值如下： PERCENT：根据视频时长百分比间隔采样时的百分比值。 DOTS：指定时间点截图。选择同步截图时，需指定此类型。 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 根据视频时长百分比间隔采样时的百分比值。 
        /// </summary>
        [JsonProperty("percent", NullValueHandling = NullValueHandling.Ignore)]
        public int? Percent { get; set; }

        /// <summary>
        /// 指定时间截图的时间点数组 例如输入[1,3,5]，分别截取视频第1秒、第3秒、第5秒位置的图像帧 最多支持10个时间点 
        /// </summary>
        [JsonProperty("dots", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Dots { get; set; }

        /// <summary>
        /// 截图输出文件名。 - 如果只抽一张图（即：按DOTS方式，指定1个时间点）则按该指定文件名输出图片。 - 如果抽多张图（即：按DOTS方式指定多个时间点或按TIME间隔截图）则输出图片名在该指定文件名基础上在增加时间点（示例：output_filename_10.jpg）。 - 如果按照PERCENT截图则按照output_filename_0.jpg,output_filename_1.jpg顺序命名 
        /// </summary>
        [JsonProperty("output_filename", NullValueHandling = NullValueHandling.Ignore)]
        public string OutputFilename { get; set; }

        /// <summary>
        /// 截图文件格式 取值如下：jpg、png 
        /// </summary>
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public FormatEnum Format { get; set; }
        /// <summary>
        /// 填充方式，当视频流配置宽高参数与原始视频的宽高比不一致时，对转码的处理方式，即为“填充”。可选填充方式： - stretch：拉伸，对每一帧进行拉伸，填满整个画面，可能导致转码后的视频被“压扁“或者“拉长“； - black：留黑，保持视频宽高比不变，边缘剩余部分使用黑色填充。 - white：留白，保持视频宽高比不变，边缘剩余部分使用白色填充。 
        /// </summary>
        [JsonProperty("fill_type", NullValueHandling = NullValueHandling.Ignore)]
        public FillTypeEnum FillType { get; set; }
        /// <summary>
        /// 图片宽度 取值范围： - [96,3840] - 0：自适应，保持原有宽高 单位：px 
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }

        /// <summary>
        /// 图片高度 取值范围： - [96,2160] - 0：自适应，保持原有宽高 单位：px 
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("output", NullValueHandling = NullValueHandling.Ignore)]
        public ObsInfo Output { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObjectThumbnailTask {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  percent: ").Append(Percent).Append("\n");
            sb.Append("  dots: ").Append(Dots).Append("\n");
            sb.Append("  outputFilename: ").Append(OutputFilename).Append("\n");
            sb.Append("  format: ").Append(Format).Append("\n");
            sb.Append("  fillType: ").Append(FillType).Append("\n");
            sb.Append("  width: ").Append(Width).Append("\n");
            sb.Append("  height: ").Append(Height).Append("\n");
            sb.Append("  output: ").Append(Output).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ObjectThumbnailTask);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ObjectThumbnailTask input)
        {
            if (input == null) return false;
            if (this.Type != input.Type) return false;
            if (this.Percent != input.Percent || (this.Percent != null && !this.Percent.Equals(input.Percent))) return false;
            if (this.Dots != input.Dots || (this.Dots != null && input.Dots != null && !this.Dots.SequenceEqual(input.Dots))) return false;
            if (this.OutputFilename != input.OutputFilename || (this.OutputFilename != null && !this.OutputFilename.Equals(input.OutputFilename))) return false;
            if (this.Format != input.Format) return false;
            if (this.FillType != input.FillType) return false;
            if (this.Width != input.Width || (this.Width != null && !this.Width.Equals(input.Width))) return false;
            if (this.Height != input.Height || (this.Height != null && !this.Height.Equals(input.Height))) return false;
            if (this.Output != input.Output || (this.Output != null && !this.Output.Equals(input.Output))) return false;

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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Percent != null) hashCode = hashCode * 59 + this.Percent.GetHashCode();
                if (this.Dots != null) hashCode = hashCode * 59 + this.Dots.GetHashCode();
                if (this.OutputFilename != null) hashCode = hashCode * 59 + this.OutputFilename.GetHashCode();
                hashCode = hashCode * 59 + this.Format.GetHashCode();
                hashCode = hashCode * 59 + this.FillType.GetHashCode();
                if (this.Width != null) hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null) hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Output != null) hashCode = hashCode * 59 + this.Output.GetHashCode();
                return hashCode;
            }
        }
    }
}
