using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 自动扣绿时，不抠图的区域。
    /// </summary>
    public class VerifyVideoMattingInfo 
    {
        /// <summary>
        /// 资源操作类型。 * RESERVED: 视频不需要抠绿的区域。 * DELETE：视频需要抠绿的区域。 * NO_DEGREEN：视频不需要去绿的区域。
        /// </summary>
        /// <value>资源操作类型。 * RESERVED: 视频不需要抠绿的区域。 * DELETE：视频需要抠绿的区域。 * NO_DEGREEN：视频不需要去绿的区域。</value>
        [JsonConverter(typeof(EnumClassConverter<MethodEnum>))]
        public class MethodEnum
        {
            /// <summary>
            /// Enum RESERVED for value: RESERVED
            /// </summary>
            public static readonly MethodEnum RESERVED = new MethodEnum("RESERVED");

            /// <summary>
            /// Enum DELETE for value: DELETE
            /// </summary>
            public static readonly MethodEnum DELETE = new MethodEnum("DELETE");

            /// <summary>
            /// Enum NO_DEGREEN for value: NO_DEGREEN
            /// </summary>
            public static readonly MethodEnum NO_DEGREEN = new MethodEnum("NO_DEGREEN");

            private static readonly Dictionary<string, MethodEnum> StaticFields =
            new Dictionary<string, MethodEnum>()
            {
                { "RESERVED", RESERVED },
                { "DELETE", DELETE },
                { "NO_DEGREEN", NO_DEGREEN },
            };

            private string _value;

            public MethodEnum()
            {

            }

            public MethodEnum(string value)
            {
                _value = value;
            }

            public static MethodEnum FromValue(string value)
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

                if (this.Equals(obj as MethodEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MethodEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(MethodEnum a, MethodEnum b)
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

            public static bool operator !=(MethodEnum a, MethodEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 区域左上角像素点的X轴位置值。
        /// </summary>
        [JsonProperty("dx", NullValueHandling = NullValueHandling.Ignore)]
        public int? Dx { get; set; }

        /// <summary>
        /// 区域左上角像素点的Y轴位置值。
        /// </summary>
        [JsonProperty("dy", NullValueHandling = NullValueHandling.Ignore)]
        public int? Dy { get; set; }

        /// <summary>
        /// 区域宽度像素值。
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }

        /// <summary>
        /// 区域高度像素值。
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }

        /// <summary>
        /// 资源操作类型。 * RESERVED: 视频不需要抠绿的区域。 * DELETE：视频需要抠绿的区域。 * NO_DEGREEN：视频不需要去绿的区域。
        /// </summary>
        [JsonProperty("method", NullValueHandling = NullValueHandling.Ignore)]
        public MethodEnum Method { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VerifyVideoMattingInfo {\n");
            sb.Append("  dx: ").Append(Dx).Append("\n");
            sb.Append("  dy: ").Append(Dy).Append("\n");
            sb.Append("  width: ").Append(Width).Append("\n");
            sb.Append("  height: ").Append(Height).Append("\n");
            sb.Append("  method: ").Append(Method).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VerifyVideoMattingInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VerifyVideoMattingInfo input)
        {
            if (input == null) return false;
            if (this.Dx != input.Dx || (this.Dx != null && !this.Dx.Equals(input.Dx))) return false;
            if (this.Dy != input.Dy || (this.Dy != null && !this.Dy.Equals(input.Dy))) return false;
            if (this.Width != input.Width || (this.Width != null && !this.Width.Equals(input.Width))) return false;
            if (this.Height != input.Height || (this.Height != null && !this.Height.Equals(input.Height))) return false;
            if (this.Method != input.Method) return false;

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
                if (this.Width != null) hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null) hashCode = hashCode * 59 + this.Height.GetHashCode();
                hashCode = hashCode * 59 + this.Method.GetHashCode();
                return hashCode;
            }
        }
    }
}
