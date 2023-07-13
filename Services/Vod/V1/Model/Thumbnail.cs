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
    /// 截图参数
    /// </summary>
    public class Thumbnail 
    {
        /// <summary>
        /// 截图类型。  取值如下： - time：每次进行截图的间隔时间。 - dots: 按照指定的时间点截图。
        /// </summary>
        /// <value>截图类型。  取值如下： - time：每次进行截图的间隔时间。 - dots: 按照指定的时间点截图。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum TIME for value: time
            /// </summary>
            public static readonly TypeEnum TIME = new TypeEnum("time");

            /// <summary>
            /// Enum DOTS for value: dots
            /// </summary>
            public static readonly TypeEnum DOTS = new TypeEnum("dots");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "time", TIME },
                { "dots", DOTS },
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
        /// 截图类型。  取值如下： - time：每次进行截图的间隔时间。 - dots: 按照指定的时间点截图。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// **type**取值为time时必填。根据时间间隔采样时的时间间隔值。  取值范围：[1,12]之间的整数。  单位：秒。
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public int? Time { get; set; }

        /// <summary>
        /// **type**取值为dots时必填。指定时间截图时的时间点数组。
        /// </summary>
        [JsonProperty("dots", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Dots { get; set; }

        /// <summary>
        /// 该值表示指定第几张截图作为封面。  默认值：1。
        /// </summary>
        [JsonProperty("cover_position", NullValueHandling = NullValueHandling.Ignore)]
        public int? CoverPosition { get; set; }

        /// <summary>
        /// 截图文件格式。  取值如下： - 1：jpg。  默认值：1 。
        /// </summary>
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public int? Format { get; set; }

        /// <summary>
        /// 纵横比，图像缩放方式。  取值如下： - 0：自适应（保持原有宽高比）。 - 1：16:9。  默认值：0。
        /// </summary>
        [JsonProperty("aspect_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public int? AspectRatio { get; set; }

        /// <summary>
        /// 截图最长边的尺寸。  单位：像素。  宽边尺寸按照该尺寸与原始视频像素等比缩放计算。
        /// </summary>
        [JsonProperty("max_length", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxLength { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Thumbnail {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("  dots: ").Append(Dots).Append("\n");
            sb.Append("  coverPosition: ").Append(CoverPosition).Append("\n");
            sb.Append("  format: ").Append(Format).Append("\n");
            sb.Append("  aspectRatio: ").Append(AspectRatio).Append("\n");
            sb.Append("  maxLength: ").Append(MaxLength).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Thumbnail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Thumbnail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.Dots == input.Dots ||
                    this.Dots != null &&
                    input.Dots != null &&
                    this.Dots.SequenceEqual(input.Dots)
                ) && 
                (
                    this.CoverPosition == input.CoverPosition ||
                    (this.CoverPosition != null &&
                    this.CoverPosition.Equals(input.CoverPosition))
                ) && 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
                ) && 
                (
                    this.AspectRatio == input.AspectRatio ||
                    (this.AspectRatio != null &&
                    this.AspectRatio.Equals(input.AspectRatio))
                ) && 
                (
                    this.MaxLength == input.MaxLength ||
                    (this.MaxLength != null &&
                    this.MaxLength.Equals(input.MaxLength))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Dots != null)
                    hashCode = hashCode * 59 + this.Dots.GetHashCode();
                if (this.CoverPosition != null)
                    hashCode = hashCode * 59 + this.CoverPosition.GetHashCode();
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.AspectRatio != null)
                    hashCode = hashCode * 59 + this.AspectRatio.GetHashCode();
                if (this.MaxLength != null)
                    hashCode = hashCode * 59 + this.MaxLength.GetHashCode();
                return hashCode;
            }
        }
    }
}
