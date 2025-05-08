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
    public class ObjectImageSpriteTask 
    {
        /// <summary>
        /// 采样类型，取值： - PERCENT：按百分比 - TIME：按时间间隔 
        /// </summary>
        /// <value>采样类型，取值： - PERCENT：按百分比 - TIME：按时间间隔 </value>
        [JsonConverter(typeof(EnumClassConverter<SampleTypeEnum>))]
        public class SampleTypeEnum
        {
            /// <summary>
            /// Enum PERCENT for value: PERCENT
            /// </summary>
            public static readonly SampleTypeEnum PERCENT = new SampleTypeEnum("PERCENT");

            /// <summary>
            /// Enum TIME for value: TIME
            /// </summary>
            public static readonly SampleTypeEnum TIME = new SampleTypeEnum("TIME");

            private static readonly Dictionary<string, SampleTypeEnum> StaticFields =
            new Dictionary<string, SampleTypeEnum>()
            {
                { "PERCENT", PERCENT },
                { "TIME", TIME },
            };

            private string _value;

            public SampleTypeEnum()
            {

            }

            public SampleTypeEnum(string value)
            {
                _value = value;
            }

            public static SampleTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SampleTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SampleTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SampleTypeEnum a, SampleTypeEnum b)
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

            public static bool operator !=(SampleTypeEnum a, SampleTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 分辨率自适应，可选值： - open：开启，此时，Width 代表视频的长边，Height 表示视频的短边； - close：关闭，此时，Width 代表视频的宽度，Height 表示视频的高度。 
        /// </summary>
        /// <value>分辨率自适应，可选值： - open：开启，此时，Width 代表视频的长边，Height 表示视频的短边； - close：关闭，此时，Width 代表视频的宽度，Height 表示视频的高度。 </value>
        [JsonConverter(typeof(EnumClassConverter<ResolutionAdaptiveEnum>))]
        public class ResolutionAdaptiveEnum
        {
            /// <summary>
            /// Enum OPEN for value: open
            /// </summary>
            public static readonly ResolutionAdaptiveEnum OPEN = new ResolutionAdaptiveEnum("open");

            /// <summary>
            /// Enum CLOSE for value: close
            /// </summary>
            public static readonly ResolutionAdaptiveEnum CLOSE = new ResolutionAdaptiveEnum("close");

            private static readonly Dictionary<string, ResolutionAdaptiveEnum> StaticFields =
            new Dictionary<string, ResolutionAdaptiveEnum>()
            {
                { "open", OPEN },
                { "close", CLOSE },
            };

            private string _value;

            public ResolutionAdaptiveEnum()
            {

            }

            public ResolutionAdaptiveEnum(string value)
            {
                _value = value;
            }

            public static ResolutionAdaptiveEnum FromValue(string value)
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

                if (this.Equals(obj as ResolutionAdaptiveEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ResolutionAdaptiveEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ResolutionAdaptiveEnum a, ResolutionAdaptiveEnum b)
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

            public static bool operator !=(ResolutionAdaptiveEnum a, ResolutionAdaptiveEnum b)
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

            public static bool operator !=(FillTypeEnum a, FillTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 图片格式，取值为 jpg、png。默认为 jpg。
        /// </summary>
        /// <value>图片格式，取值为 jpg、png。默认为 jpg。</value>
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

            public static bool operator !=(FormatEnum a, FormatEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 采样类型，取值： - PERCENT：按百分比 - TIME：按时间间隔 
        /// </summary>
        [JsonProperty("sample_type", NullValueHandling = NullValueHandling.Ignore)]
        public SampleTypeEnum SampleType { get; set; }
        /// <summary>
        /// 采样间隔。 -当 sample_type 为 PERCENT 时，指定采样间隔的百分比，(0&lt;sample_interval&lt;&#x3D;100)。 -当 sample_type 为 TIME 时，指定采样间隔的时间，单位为秒(&gt;0)。 
        /// </summary>
        [JsonProperty("sample_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? SampleInterval { get; set; }

        /// <summary>
        /// 雪碧图中小图的行数，行数*列数不得超过 100。
        /// </summary>
        [JsonProperty("row_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? RowCount { get; set; }

        /// <summary>
        /// 雪碧图中小图的列数，行数*列数不得超过 100。
        /// </summary>
        [JsonProperty("column_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ColumnCount { get; set; }

        /// <summary>
        /// 雪碧图中小图的宽度（或长边）的最大值，取值范围：0 和 [96, 4096]，单位：px。 - 当 width、height 均为 0，则分辨率同源； - 当 width 为 0，Height 非 0，则 Width 按比例缩放； - 当 width 非 0，Height 为 0，则 Height 按比例缩放； - 当 width、Height 均非 0，则分辨率按用户指定 
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }

        /// <summary>
        /// 雪碧图中小图的高度（或短边）的最大值，取值范围：0 和 [96, 4096]，单位：px。 - 当 width、height 均为 0，则分辨率同源； - 当 width 为 0，height 非 0，则 width 按比例缩放； - 当 width 非 0，height 为 0，则 height 按比例缩放； - 当 width、height 均非 0，则分辨率按用户指定。 
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }

        /// <summary>
        /// 分辨率自适应，可选值： - open：开启，此时，Width 代表视频的长边，Height 表示视频的短边； - close：关闭，此时，Width 代表视频的宽度，Height 表示视频的高度。 
        /// </summary>
        [JsonProperty("resolution_adaptive", NullValueHandling = NullValueHandling.Ignore)]
        public ResolutionAdaptiveEnum ResolutionAdaptive { get; set; }
        /// <summary>
        /// 填充方式，当视频流配置宽高参数与原始视频的宽高比不一致时，对转码的处理方式，即为“填充”。可选填充方式： - stretch：拉伸，对每一帧进行拉伸，填满整个画面，可能导致转码后的视频被“压扁“或者“拉长“； - black：留黑，保持视频宽高比不变，边缘剩余部分使用黑色填充。 - white：留白，保持视频宽高比不变，边缘剩余部分使用白色填充。 
        /// </summary>
        [JsonProperty("fill_type", NullValueHandling = NullValueHandling.Ignore)]
        public FillTypeEnum FillType { get; set; }
        /// <summary>
        /// 图片格式，取值为 jpg、png。默认为 jpg。
        /// </summary>
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public FormatEnum Format { get; set; }
        /// <summary>
        /// 截取雪碧图后，雪碧图图片文件的输出文件名，如果不填，则默认为：{inputName}_imageSprite_{雪碧图id}_{number}.{format}.{雪碧图id}和{number}从0开始递增 
        /// </summary>
        [JsonProperty("output_object_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OutputObjectName { get; set; }

        /// <summary>
        /// 截取雪碧图后，Web VTT 文件的输出路径，只能为相对路径。如果不填，则默认为相对路径：{inputName}_imageSprite_{雪碧图_id}.vtt 
        /// </summary>
        [JsonProperty("webvtt_object_name", NullValueHandling = NullValueHandling.Ignore)]
        public string WebvttObjectName { get; set; }

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
            sb.Append("class ObjectImageSpriteTask {\n");
            sb.Append("  sampleType: ").Append(SampleType).Append("\n");
            sb.Append("  sampleInterval: ").Append(SampleInterval).Append("\n");
            sb.Append("  rowCount: ").Append(RowCount).Append("\n");
            sb.Append("  columnCount: ").Append(ColumnCount).Append("\n");
            sb.Append("  width: ").Append(Width).Append("\n");
            sb.Append("  height: ").Append(Height).Append("\n");
            sb.Append("  resolutionAdaptive: ").Append(ResolutionAdaptive).Append("\n");
            sb.Append("  fillType: ").Append(FillType).Append("\n");
            sb.Append("  format: ").Append(Format).Append("\n");
            sb.Append("  outputObjectName: ").Append(OutputObjectName).Append("\n");
            sb.Append("  webvttObjectName: ").Append(WebvttObjectName).Append("\n");
            sb.Append("  output: ").Append(Output).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ObjectImageSpriteTask);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ObjectImageSpriteTask input)
        {
            if (input == null) return false;
            if (this.SampleType != input.SampleType) return false;
            if (this.SampleInterval != input.SampleInterval || (this.SampleInterval != null && !this.SampleInterval.Equals(input.SampleInterval))) return false;
            if (this.RowCount != input.RowCount || (this.RowCount != null && !this.RowCount.Equals(input.RowCount))) return false;
            if (this.ColumnCount != input.ColumnCount || (this.ColumnCount != null && !this.ColumnCount.Equals(input.ColumnCount))) return false;
            if (this.Width != input.Width || (this.Width != null && !this.Width.Equals(input.Width))) return false;
            if (this.Height != input.Height || (this.Height != null && !this.Height.Equals(input.Height))) return false;
            if (this.ResolutionAdaptive != input.ResolutionAdaptive) return false;
            if (this.FillType != input.FillType) return false;
            if (this.Format != input.Format) return false;
            if (this.OutputObjectName != input.OutputObjectName || (this.OutputObjectName != null && !this.OutputObjectName.Equals(input.OutputObjectName))) return false;
            if (this.WebvttObjectName != input.WebvttObjectName || (this.WebvttObjectName != null && !this.WebvttObjectName.Equals(input.WebvttObjectName))) return false;
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
                hashCode = hashCode * 59 + this.SampleType.GetHashCode();
                if (this.SampleInterval != null) hashCode = hashCode * 59 + this.SampleInterval.GetHashCode();
                if (this.RowCount != null) hashCode = hashCode * 59 + this.RowCount.GetHashCode();
                if (this.ColumnCount != null) hashCode = hashCode * 59 + this.ColumnCount.GetHashCode();
                if (this.Width != null) hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null) hashCode = hashCode * 59 + this.Height.GetHashCode();
                hashCode = hashCode * 59 + this.ResolutionAdaptive.GetHashCode();
                hashCode = hashCode * 59 + this.FillType.GetHashCode();
                hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.OutputObjectName != null) hashCode = hashCode * 59 + this.OutputObjectName.GetHashCode();
                if (this.WebvttObjectName != null) hashCode = hashCode * 59 + this.WebvttObjectName.GetHashCode();
                if (this.Output != null) hashCode = hashCode * 59 + this.Output.GetHashCode();
                return hashCode;
            }
        }
    }
}
