using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ThumbnailPara 
    {
        /// <summary>
        /// 采样类型。  取值如下： - \&quot;TIME\&quot;：根据时间间隔采样截图。 - \&quot;DOTS\&quot;：指定时间点截图。选择同步截图时，需指定此类型。 - \&quot;DOTS_MS\&quot;：同步截图指定时间点毫秒值。  默认值：\&quot;TIME\&quot; 
        /// </summary>
        /// <value>采样类型。  取值如下： - \&quot;TIME\&quot;：根据时间间隔采样截图。 - \&quot;DOTS\&quot;：指定时间点截图。选择同步截图时，需指定此类型。 - \&quot;DOTS_MS\&quot;：同步截图指定时间点毫秒值。  默认值：\&quot;TIME\&quot; </value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum TIME for value: TIME
            /// </summary>
            public static readonly TypeEnum TIME = new TypeEnum("TIME");

            /// <summary>
            /// Enum DOTS for value: DOTS
            /// </summary>
            public static readonly TypeEnum DOTS = new TypeEnum("DOTS");

            /// <summary>
            /// Enum DOTS_MS for value: DOTS_MS
            /// </summary>
            public static readonly TypeEnum DOTS_MS = new TypeEnum("DOTS_MS");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "TIME", TIME },
                { "DOTS", DOTS },
                { "DOTS_MS", DOTS_MS },
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 采样类型。  取值如下： - \&quot;TIME\&quot;：根据时间间隔采样截图。 - \&quot;DOTS\&quot;：指定时间点截图。选择同步截图时，需指定此类型。 - \&quot;DOTS_MS\&quot;：同步截图指定时间点毫秒值。  默认值：\&quot;TIME\&quot; 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 采样截图的时间间隔值。  默认值：12。  单位：秒 
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public int? Time { get; set; }

        /// <summary>
        /// 采样类型为“TIME”模式的开始时间，和“time”配合使用。  默认值：0。  单位：秒。 
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartTime { get; set; }

        /// <summary>
        /// 采样类型为“TIME”模式的持续时间，和“time”、“start_time”配合使用，表示从视频文件的第“start_time”开始，持续时间为“duration”，每间隔“time”生成一张截图。 取值范围：[数字，ToEND]。“ToEND”表示持续到视频结束。  默认值： ToEND。  单位：秒。 &gt; “duration”必须大于等0，若设置为0，则截图持续时间从“start_time”到视频结束。 
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? Duration { get; set; }

        /// <summary>
        /// 指定时间截图时的时间点数组，最多支持10个。 
        /// </summary>
        [JsonProperty("dots", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Dots { get; set; }

        /// <summary>
        /// 同步截图下，指定时间截图的时间点数组，单位毫秒  例如输入[1000]，截取视频第1000毫秒位置的图像帧，仅支持一个时间点 
        /// </summary>
        [JsonProperty("dots_ms", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> DotsMs { get; set; }

        /// <summary>
        /// 截图输出文件名。  - 如果只抽一张图（即：按DOTS方式，指定1个时间点）则按该指定文件名输出图片。  - 如果抽多张图（即：按DOTS方式指定多个时间点或按TIME间隔截图）则输出图片名在该指定文件名基础上在增加时间点（示例：output_filename_10.jpg）。  - 如果指定了压缩抽帧图片生成tar包，则tar包按该指定文件名输出。 
        /// </summary>
        [JsonProperty("output_filename", NullValueHandling = NullValueHandling.Ignore)]
        public string OutputFilename { get; set; }

        /// <summary>
        /// 截图文件格式。  取值如下：  1：表示jpg格式 
        /// </summary>
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public int? Format { get; set; }

        /// <summary>
        /// 图片宽度  取值范围：(96,3840]  单位：px 
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }

        /// <summary>
        /// 图片高度  取值范围：(96,2160]  单位：px 
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }

        /// <summary>
        /// 截图最长边的尺寸。宽边尺寸按照该尺寸与原始视频像素等比缩放计算。   取值范围：[240,3840]  默认值：480  单位：像素  &gt; 该参数和width/height选择使用，以width/height优先，若width/height都不等于0，则图片尺寸按width/height得出；反之，则图片尺寸按 max_length 得出。  &gt; 若该参数和width/height都未选择，则按源片源宽高输出截图 
        /// </summary>
        [JsonProperty("max_length", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxLength { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThumbnailPara {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  dots: ").Append(Dots).Append("\n");
            sb.Append("  dotsMs: ").Append(DotsMs).Append("\n");
            sb.Append("  outputFilename: ").Append(OutputFilename).Append("\n");
            sb.Append("  format: ").Append(Format).Append("\n");
            sb.Append("  width: ").Append(Width).Append("\n");
            sb.Append("  height: ").Append(Height).Append("\n");
            sb.Append("  maxLength: ").Append(MaxLength).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ThumbnailPara);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ThumbnailPara input)
        {
            if (input == null) return false;
            if (this.Type != input.Type) return false;
            if (this.Time != input.Time || (this.Time != null && !this.Time.Equals(input.Time))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;
            if (this.Dots != input.Dots || (this.Dots != null && input.Dots != null && !this.Dots.SequenceEqual(input.Dots))) return false;
            if (this.DotsMs != input.DotsMs || (this.DotsMs != null && input.DotsMs != null && !this.DotsMs.SequenceEqual(input.DotsMs))) return false;
            if (this.OutputFilename != input.OutputFilename || (this.OutputFilename != null && !this.OutputFilename.Equals(input.OutputFilename))) return false;
            if (this.Format != input.Format || (this.Format != null && !this.Format.Equals(input.Format))) return false;
            if (this.Width != input.Width || (this.Width != null && !this.Width.Equals(input.Width))) return false;
            if (this.Height != input.Height || (this.Height != null && !this.Height.Equals(input.Height))) return false;
            if (this.MaxLength != input.MaxLength || (this.MaxLength != null && !this.MaxLength.Equals(input.MaxLength))) return false;

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
                if (this.Time != null) hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.Dots != null) hashCode = hashCode * 59 + this.Dots.GetHashCode();
                if (this.DotsMs != null) hashCode = hashCode * 59 + this.DotsMs.GetHashCode();
                if (this.OutputFilename != null) hashCode = hashCode * 59 + this.OutputFilename.GetHashCode();
                if (this.Format != null) hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.Width != null) hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null) hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.MaxLength != null) hashCode = hashCode * 59 + this.MaxLength.GetHashCode();
                return hashCode;
            }
        }
    }
}
