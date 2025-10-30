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
    public class WatermarkLocation 
    {
        /// <summary>
        /// 水印位置。  包含如下选项： - TOPLEFT：左上 - TOPRIGHT：右上 - BOTTOMLEFT：左下 - BOTTOMRIGHT：右下 - RANDOM：随机模式，图片水印将随机在视频流的左上、右上、左下、右下四个位置展示。
        /// </summary>
        /// <value>水印位置。  包含如下选项： - TOPLEFT：左上 - TOPRIGHT：右上 - BOTTOMLEFT：左下 - BOTTOMRIGHT：右下 - RANDOM：随机模式，图片水印将随机在视频流的左上、右上、左下、右下四个位置展示。</value>
        [JsonConverter(typeof(EnumClassConverter<LocationEnum>))]
        public class LocationEnum
        {
            /// <summary>
            /// Enum TOPLEFT for value: TOPLEFT
            /// </summary>
            public static readonly LocationEnum TOPLEFT = new LocationEnum("TOPLEFT");

            /// <summary>
            /// Enum TOPRIGHT for value: TOPRIGHT
            /// </summary>
            public static readonly LocationEnum TOPRIGHT = new LocationEnum("TOPRIGHT");

            /// <summary>
            /// Enum BOTTOMLEFT for value: BOTTOMLEFT
            /// </summary>
            public static readonly LocationEnum BOTTOMLEFT = new LocationEnum("BOTTOMLEFT");

            /// <summary>
            /// Enum BOTTOMRIGHT for value: BOTTOMRIGHT
            /// </summary>
            public static readonly LocationEnum BOTTOMRIGHT = new LocationEnum("BOTTOMRIGHT");

            /// <summary>
            /// Enum RANDOM for value: RANDOM
            /// </summary>
            public static readonly LocationEnum RANDOM = new LocationEnum("RANDOM");

            private static readonly Dictionary<string, LocationEnum> StaticFields =
            new Dictionary<string, LocationEnum>()
            {
                { "TOPLEFT", TOPLEFT },
                { "TOPRIGHT", TOPRIGHT },
                { "BOTTOMLEFT", BOTTOMLEFT },
                { "BOTTOMRIGHT", BOTTOMRIGHT },
                { "RANDOM", RANDOM },
            };

            private string _value;

            public LocationEnum()
            {

            }

            public LocationEnum(string value)
            {
                _value = value;
            }

            public static LocationEnum FromValue(string value)
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

                if (this.Equals(obj as LocationEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LocationEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LocationEnum a, LocationEnum b)
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

            public static bool operator !=(LocationEnum a, LocationEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 水印位置。  包含如下选项： - TOPLEFT：左上 - TOPRIGHT：右上 - BOTTOMLEFT：左下 - BOTTOMRIGHT：右下 - RANDOM：随机模式，图片水印将随机在视频流的左上、右上、左下、右下四个位置展示。
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public LocationEnum Location { get; set; }
        /// <summary>
        /// 水印相对输出视频的水平偏移量。 说明：值有两种形式： 1）整数型代表偏移像素，范围[1，4096]，单位px。 2）小数型代表水平偏移量与输出分辨率宽的比率，范围[0，1) 百分比限制最多保留小数点后4位
        /// </summary>
        [JsonProperty("x_offset", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? XOffset { get; set; }

        /// <summary>
        /// 水印相对输出视频的垂直偏移量 说明: 值有两种形式： 1）整数型代表偏移像素，范围[1，4096]，单位px。 2）小数型代表垂直偏移量与输出分辨率高的比率，范围[0，1) 百分比限制最多保留小数点后4位
        /// </summary>
        [JsonProperty("y_offset", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? YOffset { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WatermarkLocation {\n");
            sb.Append("  location: ").Append(Location).Append("\n");
            sb.Append("  xOffset: ").Append(XOffset).Append("\n");
            sb.Append("  yOffset: ").Append(YOffset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WatermarkLocation);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WatermarkLocation input)
        {
            if (input == null) return false;
            if (this.Location != input.Location) return false;
            if (this.XOffset != input.XOffset || (this.XOffset != null && !this.XOffset.Equals(input.XOffset))) return false;
            if (this.YOffset != input.YOffset || (this.YOffset != null && !this.YOffset.Equals(input.YOffset))) return false;

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
                hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.XOffset != null) hashCode = hashCode * 59 + this.XOffset.GetHashCode();
                if (this.YOffset != null) hashCode = hashCode * 59 + this.YOffset.GetHashCode();
                return hashCode;
            }
        }
    }
}
