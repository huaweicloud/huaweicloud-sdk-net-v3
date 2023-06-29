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
    public class AnimatedGraphicsOutputParam 
    {
        /// <summary>
        /// 动图格式，目前仅支持取值 gif 
        /// </summary>
        /// <value>动图格式，目前仅支持取值 gif </value>
        [JsonConverter(typeof(EnumClassConverter<FormatEnum>))]
        public class FormatEnum
        {
            /// <summary>
            /// Enum GIF for value: gif
            /// </summary>
            public static readonly FormatEnum GIF = new FormatEnum("gif");

            private static readonly Dictionary<string, FormatEnum> StaticFields =
            new Dictionary<string, FormatEnum>()
            {
                { "gif", GIF },
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
        /// 动图格式，目前仅支持取值 gif 
        /// </summary>
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public FormatEnum Format { get; set; }
        /// <summary>
        /// 输出动图的宽。  取值范围：0，-1或[32,3840]之间2的倍数。  &gt;- 若设置为-1， 则宽根据高来自适应，此时“height”不能取-1或0。 &gt;- 若设置为0，则取原始视频的宽，此时“height”只能取0。 
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }

        /// <summary>
        /// 输出动图的高。  取值范围：0，-1或[32,2160]之间2的倍数。  &gt;- 若设置为-1， 则高根据宽来自适应，此时“width”不能取-1或0。 &gt;- 若设置为0，则取原始视频的高，此时“width”只能取0。 
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }

        /// <summary>
        /// 起始时间，单位：毫秒 
        /// </summary>
        [JsonProperty("start", NullValueHandling = NullValueHandling.Ignore)]
        public int? Start { get; set; }

        /// <summary>
        /// 结束时间。  单位：毫秒。  end、start差值最多60秒。 
        /// </summary>
        [JsonProperty("end", NullValueHandling = NullValueHandling.Ignore)]
        public int? End { get; set; }

        /// <summary>
        /// 动图帧率。  取值范围：[1,75] 
        /// </summary>
        [JsonProperty("frame_rate", NullValueHandling = NullValueHandling.Ignore)]
        public int? FrameRate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnimatedGraphicsOutputParam {\n");
            sb.Append("  format: ").Append(Format).Append("\n");
            sb.Append("  width: ").Append(Width).Append("\n");
            sb.Append("  height: ").Append(Height).Append("\n");
            sb.Append("  start: ").Append(Start).Append("\n");
            sb.Append("  end: ").Append(End).Append("\n");
            sb.Append("  frameRate: ").Append(FrameRate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AnimatedGraphicsOutputParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AnimatedGraphicsOutputParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
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
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
                ) && 
                (
                    this.End == input.End ||
                    (this.End != null &&
                    this.End.Equals(input.End))
                ) && 
                (
                    this.FrameRate == input.FrameRate ||
                    (this.FrameRate != null &&
                    this.FrameRate.Equals(input.FrameRate))
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
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Start != null)
                    hashCode = hashCode * 59 + this.Start.GetHashCode();
                if (this.End != null)
                    hashCode = hashCode * 59 + this.End.GetHashCode();
                if (this.FrameRate != null)
                    hashCode = hashCode * 59 + this.FrameRate.GetHashCode();
                return hashCode;
            }
        }
    }
}
