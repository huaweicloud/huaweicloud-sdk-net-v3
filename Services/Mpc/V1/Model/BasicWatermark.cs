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
    public class BasicWatermark 
    {

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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BasicWatermark {\n");
            sb.Append("  dx: ").Append(Dx).Append("\n");
            sb.Append("  dy: ").Append(Dy).Append("\n");
            sb.Append("  referpos: ").Append(Referpos).Append("\n");
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
            return this.Equals(input as BasicWatermark);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BasicWatermark input)
        {
            if (input == null)
                return false;

            return 
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
                    this.Referpos == input.Referpos ||
                    (this.Referpos != null &&
                    this.Referpos.Equals(input.Referpos))
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
                if (this.Dx != null)
                    hashCode = hashCode * 59 + this.Dx.GetHashCode();
                if (this.Dy != null)
                    hashCode = hashCode * 59 + this.Dy.GetHashCode();
                if (this.Referpos != null)
                    hashCode = hashCode * 59 + this.Referpos.GetHashCode();
                if (this.TimelineStart != null)
                    hashCode = hashCode * 59 + this.TimelineStart.GetHashCode();
                if (this.TimelineDuration != null)
                    hashCode = hashCode * 59 + this.TimelineDuration.GetHashCode();
                return hashCode;
            }
        }
    }
}
