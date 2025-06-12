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
    /// 图片元数据
    /// </summary>
    public class ImageAssetMeta 
    {
        /// <summary>
        /// **参数解释**： 图片形态。 **约束限制**： 用户无需填写，系统自行提取。 **取值范围**： * Horizontal：横向 * Vertical：纵向  **默认取值**： 不涉及。
        /// </summary>
        /// <value>**参数解释**： 图片形态。 **约束限制**： 用户无需填写，系统自行提取。 **取值范围**： * Horizontal：横向 * Vertical：纵向  **默认取值**： 不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<ModeEnum>))]
        public class ModeEnum
        {
            /// <summary>
            /// Enum HORIZONTAL for value: Horizontal
            /// </summary>
            public static readonly ModeEnum HORIZONTAL = new ModeEnum("Horizontal");

            /// <summary>
            /// Enum VERTICAL for value: Vertical
            /// </summary>
            public static readonly ModeEnum VERTICAL = new ModeEnum("Vertical");

            private static readonly Dictionary<string, ModeEnum> StaticFields =
            new Dictionary<string, ModeEnum>()
            {
                { "Horizontal", HORIZONTAL },
                { "Vertical", VERTICAL },
            };

            private string _value;

            public ModeEnum()
            {

            }

            public ModeEnum(string value)
            {
                _value = value;
            }

            public static ModeEnum FromValue(string value)
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

                if (this.Equals(obj as ModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ModeEnum a, ModeEnum b)
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

            public static bool operator !=(ModeEnum a, ModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 图片编码格式。 **约束限制**： 用户无需填写，系统自行提取。 **取值范围**： 字符长度0-32位。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("codec", NullValueHandling = NullValueHandling.Ignore)]
        public string Codec { get; set; }

        /// <summary>
        /// **参数解释**： 图片宽度。 **约束限制**： 用户无需填写，系统自行提取。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }

        /// <summary>
        /// **参数解释**： 图片高度。 **约束限制**： 用户无需填写，系统自行提取。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }

        /// <summary>
        /// **参数解释**： 图片大小。 **约束限制**： 用户无需填写，系统自行提取。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public long? Size { get; set; }

        /// <summary>
        /// **参数解释**： 图片形态。 **约束限制**： 用户无需填写，系统自行提取。 **取值范围**： * Horizontal：横向 * Vertical：纵向  **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public ModeEnum Mode { get; set; }
        /// <summary>
        /// **参数解释**： 视频帧率。 **约束限制**： 用户无需填写，系统自行提取。 **取值范围**： 字符长度0-32位。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("frame_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string FrameRate { get; set; }

        /// <summary>
        /// **参数解释**： 时长,单位秒。 **约束限制**： 用户无需填写，系统自行提取。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("error_info", NullValueHandling = NullValueHandling.Ignore)]
        public ErrorResponse ErrorInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageAssetMeta {\n");
            sb.Append("  codec: ").Append(Codec).Append("\n");
            sb.Append("  width: ").Append(Width).Append("\n");
            sb.Append("  height: ").Append(Height).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  frameRate: ").Append(FrameRate).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  errorInfo: ").Append(ErrorInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageAssetMeta);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageAssetMeta input)
        {
            if (input == null) return false;
            if (this.Codec != input.Codec || (this.Codec != null && !this.Codec.Equals(input.Codec))) return false;
            if (this.Width != input.Width || (this.Width != null && !this.Width.Equals(input.Width))) return false;
            if (this.Height != input.Height || (this.Height != null && !this.Height.Equals(input.Height))) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.Mode != input.Mode) return false;
            if (this.FrameRate != input.FrameRate || (this.FrameRate != null && !this.FrameRate.Equals(input.FrameRate))) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;
            if (this.ErrorInfo != input.ErrorInfo || (this.ErrorInfo != null && !this.ErrorInfo.Equals(input.ErrorInfo))) return false;

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
                if (this.Codec != null) hashCode = hashCode * 59 + this.Codec.GetHashCode();
                if (this.Width != null) hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null) hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.FrameRate != null) hashCode = hashCode * 59 + this.FrameRate.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.ErrorInfo != null) hashCode = hashCode * 59 + this.ErrorInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
