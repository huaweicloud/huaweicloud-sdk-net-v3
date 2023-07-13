using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Image.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ImageHighresolutionMattingInference 
    {
        /// <summary>
        /// 是否只返回处理结果的alpha通道，\&quot;foreground\&quot;代表返回带alpha通道的前景图片，\&quot;alpha\&quot;字符串代表仅返回alpha通道
        /// </summary>
        /// <value>是否只返回处理结果的alpha通道，\&quot;foreground\&quot;代表返回带alpha通道的前景图片，\&quot;alpha\&quot;字符串代表仅返回alpha通道</value>
        [JsonConverter(typeof(EnumClassConverter<ReturnTypeEnum>))]
        public class ReturnTypeEnum
        {
            /// <summary>
            /// Enum FOREGROUND for value: foreground
            /// </summary>
            public static readonly ReturnTypeEnum FOREGROUND = new ReturnTypeEnum("foreground");

            /// <summary>
            /// Enum ALPHA for value: alpha
            /// </summary>
            public static readonly ReturnTypeEnum ALPHA = new ReturnTypeEnum("alpha");

            private static readonly Dictionary<string, ReturnTypeEnum> StaticFields =
            new Dictionary<string, ReturnTypeEnum>()
            {
                { "foreground", FOREGROUND },
                { "alpha", ALPHA },
            };

            private string _value;

            public ReturnTypeEnum()
            {

            }

            public ReturnTypeEnum(string value)
            {
                _value = value;
            }

            public static ReturnTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ReturnTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ReturnTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ReturnTypeEnum a, ReturnTypeEnum b)
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

            public static bool operator !=(ReturnTypeEnum a, ReturnTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 是否只返回处理结果的alpha通道，\&quot;foreground\&quot;代表返回带alpha通道的前景图片，\&quot;alpha\&quot;字符串代表仅返回alpha通道
        /// </summary>
        [JsonProperty("return_type", NullValueHandling = NullValueHandling.Ignore)]
        public ReturnTypeEnum ReturnType { get; set; }
        /// <summary>
        /// 指定抠图区域坐标，默认全图，示例：[x_min,y_min,x_max,y_max]
        /// </summary>
        [JsonProperty("coord", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Coord { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageHighresolutionMattingInference {\n");
            sb.Append("  returnType: ").Append(ReturnType).Append("\n");
            sb.Append("  coord: ").Append(Coord).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageHighresolutionMattingInference);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageHighresolutionMattingInference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReturnType == input.ReturnType ||
                    (this.ReturnType != null &&
                    this.ReturnType.Equals(input.ReturnType))
                ) && 
                (
                    this.Coord == input.Coord ||
                    this.Coord != null &&
                    input.Coord != null &&
                    this.Coord.SequenceEqual(input.Coord)
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
                if (this.ReturnType != null)
                    hashCode = hashCode * 59 + this.ReturnType.GetHashCode();
                if (this.Coord != null)
                    hashCode = hashCode * 59 + this.Coord.GetHashCode();
                return hashCode;
            }
        }
    }
}
