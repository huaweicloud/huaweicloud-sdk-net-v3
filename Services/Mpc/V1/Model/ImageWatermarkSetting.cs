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
    public class ImageWatermarkSetting 
    {
        /// <summary>
        /// 水印叠加母体  取值如下： - input ：水印叠加在输入片源上，转码输出后实际大小按图像等比例缩放 - output ：水印叠加在转码输出文件上。 
        /// </summary>
        /// <value>水印叠加母体  取值如下： - input ：水印叠加在输入片源上，转码输出后实际大小按图像等比例缩放 - output ：水印叠加在转码输出文件上。 </value>
        [JsonConverter(typeof(EnumClassConverter<BaseEnum>))]
        public class BaseEnum
        {
            /// <summary>
            /// Enum INPUT for value: input
            /// </summary>
            public static readonly BaseEnum INPUT = new BaseEnum("input");

            /// <summary>
            /// Enum OUTPUT for value: output
            /// </summary>
            public static readonly BaseEnum OUTPUT = new BaseEnum("output");

            private static readonly Dictionary<string, BaseEnum> StaticFields =
            new Dictionary<string, BaseEnum>()
            {
                { "input", INPUT },
                { "output", OUTPUT },
            };

            private string _value;

            public BaseEnum()
            {

            }

            public BaseEnum(string value)
            {
                _value = value;
            }

            public static BaseEnum FromValue(string value)
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

                if (this.Equals(obj as BaseEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(BaseEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(BaseEnum a, BaseEnum b)
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

            public static bool operator !=(BaseEnum a, BaseEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 水印图片起点相对输出视频顶点的水平偏移量。  设置方法有如下两种：  - 整数型：表示图片起点水平偏移视频顶点的像素值，单位px。取值范围：[0，4096] - 小数型：表示图片起点相对于视频分辨率宽的水平偏移比率。取值范围：(0，1)，支持4位小数，如0.9999，超出部分系统自动丢弃。  示例：输出视频分辨率宽1920，设置“dx”为“0.1”，“referpos”为“TopRight”（右上角），则水印图片右上角到视频右顶点在水平方向上偏移距离为192。 
        /// </summary>
        [JsonProperty("dx", NullValueHandling = NullValueHandling.Ignore)]
        public string Dx { get; set; }

        /// <summary>
        /// 水印图片起点相对输出视频顶点的垂直偏移量。  - 设置方法有如下两种：整数型：表示图片起点垂直偏移视频顶点的像素值，单位px。取值范围：[0，4096] - 小数型：表示图片起点相对于视频分辨率高的垂直偏移比率。取值范围：(0，1)，支持4位小数，如0.9999，超出部分系统自动丢弃。  示例：输出视频分辨率高1080，设置“dy”为“0.1”，“referpos”为“TopRight”（右上角），则水印图片右上角到视频右顶点在垂直方向上的偏移距离为108。 
        /// </summary>
        [JsonProperty("dy", NullValueHandling = NullValueHandling.Ignore)]
        public string Dy { get; set; }

        /// <summary>
        /// 水印的位置。  取值如下： - TopRight：右上角。 - TopLeft：左上角。 - BottomRight：右下角。 - BottomLeft：左下角。 
        /// </summary>
        [JsonProperty("referpos", NullValueHandling = NullValueHandling.Ignore)]
        public string Referpos { get; set; }

        /// <summary>
        /// 水印开始时间，与“timeline_duration”配合使用。  取值范围：数字。  单位：秒。 
        /// </summary>
        [JsonProperty("timeline_start", NullValueHandling = NullValueHandling.Ignore)]
        public string TimelineStart { get; set; }

        /// <summary>
        /// 水印持续时间，与“timeline_start”配合使用。  取值范围：[数字，ToEND]。“ToEND”表示持续到视频结束。  默认值：ToEND。 
        /// </summary>
        [JsonProperty("timeline_duration", NullValueHandling = NullValueHandling.Ignore)]
        public string TimelineDuration { get; set; }

        /// <summary>
        /// 对应拼接列表中第几个片段打水印，从0开始，\&quot;0表示第1个，“1”表示第二个，不带或填\&quot;ALL\&quot;表示所有拼接片源打水印。 
        /// </summary>
        [JsonProperty("overlay_input", NullValueHandling = NullValueHandling.Ignore)]
        public string OverlayInput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("input", NullValueHandling = NullValueHandling.Ignore)]
        public ObsObjInfo Input { get; set; }

        /// <summary>
        /// 水印叠加母体  取值如下： - input ：水印叠加在输入片源上，转码输出后实际大小按图像等比例缩放 - output ：水印叠加在转码输出文件上。 
        /// </summary>
        [JsonProperty("base", NullValueHandling = NullValueHandling.Ignore)]
        public BaseEnum Base { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageWatermarkSetting {\n");
            sb.Append("  dx: ").Append(Dx).Append("\n");
            sb.Append("  dy: ").Append(Dy).Append("\n");
            sb.Append("  referpos: ").Append(Referpos).Append("\n");
            sb.Append("  timelineStart: ").Append(TimelineStart).Append("\n");
            sb.Append("  timelineDuration: ").Append(TimelineDuration).Append("\n");
            sb.Append("  overlayInput: ").Append(OverlayInput).Append("\n");
            sb.Append("  input: ").Append(Input).Append("\n");
            sb.Append("  Base: ").Append(Base).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageWatermarkSetting);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageWatermarkSetting input)
        {
            if (input == null) return false;
            if (this.Dx != input.Dx || (this.Dx != null && !this.Dx.Equals(input.Dx))) return false;
            if (this.Dy != input.Dy || (this.Dy != null && !this.Dy.Equals(input.Dy))) return false;
            if (this.Referpos != input.Referpos || (this.Referpos != null && !this.Referpos.Equals(input.Referpos))) return false;
            if (this.TimelineStart != input.TimelineStart || (this.TimelineStart != null && !this.TimelineStart.Equals(input.TimelineStart))) return false;
            if (this.TimelineDuration != input.TimelineDuration || (this.TimelineDuration != null && !this.TimelineDuration.Equals(input.TimelineDuration))) return false;
            if (this.OverlayInput != input.OverlayInput || (this.OverlayInput != null && !this.OverlayInput.Equals(input.OverlayInput))) return false;
            if (this.Input != input.Input || (this.Input != null && !this.Input.Equals(input.Input))) return false;
            if (this.Base != input.Base) return false;

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
                if (this.Dx != null) hashCode = hashCode * 59 + this.Dx.GetHashCode();
                if (this.Dy != null) hashCode = hashCode * 59 + this.Dy.GetHashCode();
                if (this.Referpos != null) hashCode = hashCode * 59 + this.Referpos.GetHashCode();
                if (this.TimelineStart != null) hashCode = hashCode * 59 + this.TimelineStart.GetHashCode();
                if (this.TimelineDuration != null) hashCode = hashCode * 59 + this.TimelineDuration.GetHashCode();
                if (this.OverlayInput != null) hashCode = hashCode * 59 + this.OverlayInput.GetHashCode();
                if (this.Input != null) hashCode = hashCode * 59 + this.Input.GetHashCode();
                hashCode = hashCode * 59 + this.Base.GetHashCode();
                return hashCode;
            }
        }
    }
}
