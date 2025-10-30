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
    /// 
    /// </summary>
    public class WordWaterMarkInfo 
    {

        /// <summary>
        /// 水印文字内容，必填 字幕内容1-64 type为1或2时必填，type为0时非必填
        /// </summary>
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public string Format { get; set; }

        /// <summary>
        /// 参数校验：首位为#、除#外为6位或8位，每位字符由 0-9、a~f、A~F 组成【务必校验，错误时转码默认白色】
        /// </summary>
        [JsonProperty("font_color", NullValueHandling = NullValueHandling.Ignore)]
        public string FontColor { get; set; }

        /// <summary>
        /// 字体大小
        /// </summary>
        [JsonProperty("font_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? FontSize { get; set; }

        /// <summary>
        /// 字体，缺省值 空，可选值：harmonyRegular（鸿蒙）、douyu2.0（斗鱼追光体）
        /// </summary>
        [JsonProperty("font", NullValueHandling = NullValueHandling.Ignore)]
        public string Font { get; set; }

        /// <summary>
        /// 时区，【取值参考 UTC-1200 至 UTC+1200，前三位UTC，第四位+或-，五六位表示小时，七八位固定00】
        /// </summary>
        [JsonProperty("time_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeZone { get; set; }

        /// <summary>
        /// 缺省值 none，参数校验：首位为#、除#外为6位或8位，每位字符由 0-9、a~f、A~F 组成【务必校验，错误时转码默认黑色】
        /// </summary>
        [JsonProperty("shadow_color", NullValueHandling = NullValueHandling.Ignore)]
        public string ShadowColor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public WatermarkLocation Location { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WordWaterMarkInfo {\n");
            sb.Append("  format: ").Append(Format).Append("\n");
            sb.Append("  fontColor: ").Append(FontColor).Append("\n");
            sb.Append("  fontSize: ").Append(FontSize).Append("\n");
            sb.Append("  font: ").Append(Font).Append("\n");
            sb.Append("  timeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  shadowColor: ").Append(ShadowColor).Append("\n");
            sb.Append("  location: ").Append(Location).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WordWaterMarkInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WordWaterMarkInfo input)
        {
            if (input == null) return false;
            if (this.Format != input.Format || (this.Format != null && !this.Format.Equals(input.Format))) return false;
            if (this.FontColor != input.FontColor || (this.FontColor != null && !this.FontColor.Equals(input.FontColor))) return false;
            if (this.FontSize != input.FontSize || (this.FontSize != null && !this.FontSize.Equals(input.FontSize))) return false;
            if (this.Font != input.Font || (this.Font != null && !this.Font.Equals(input.Font))) return false;
            if (this.TimeZone != input.TimeZone || (this.TimeZone != null && !this.TimeZone.Equals(input.TimeZone))) return false;
            if (this.ShadowColor != input.ShadowColor || (this.ShadowColor != null && !this.ShadowColor.Equals(input.ShadowColor))) return false;
            if (this.Location != input.Location || (this.Location != null && !this.Location.Equals(input.Location))) return false;

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
                if (this.Format != null) hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.FontColor != null) hashCode = hashCode * 59 + this.FontColor.GetHashCode();
                if (this.FontSize != null) hashCode = hashCode * 59 + this.FontSize.GetHashCode();
                if (this.Font != null) hashCode = hashCode * 59 + this.Font.GetHashCode();
                if (this.TimeZone != null) hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                if (this.ShadowColor != null) hashCode = hashCode * 59 + this.ShadowColor.GetHashCode();
                if (this.Location != null) hashCode = hashCode * 59 + this.Location.GetHashCode();
                return hashCode;
            }
        }
    }
}
