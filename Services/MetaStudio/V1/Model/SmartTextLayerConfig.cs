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
    /// 素材视频图层配置。
    /// </summary>
    public class SmartTextLayerConfig 
    {
        /// <summary>
        /// **参数解释**： 文本类型。 * DYNAMIC：动态文本，需要进行关键字替换。 * STATIC：静态文本。
        /// </summary>
        /// <value>**参数解释**： 文本类型。 * DYNAMIC：动态文本，需要进行关键字替换。 * STATIC：静态文本。</value>
        [JsonConverter(typeof(EnumClassConverter<TextTypeEnum>))]
        public class TextTypeEnum
        {
            /// <summary>
            /// Enum DYNAMIC for value: DYNAMIC
            /// </summary>
            public static readonly TextTypeEnum DYNAMIC = new TextTypeEnum("DYNAMIC");

            /// <summary>
            /// Enum STATIC for value: STATIC
            /// </summary>
            public static readonly TextTypeEnum STATIC = new TextTypeEnum("STATIC");

            private static readonly Dictionary<string, TextTypeEnum> StaticFields =
            new Dictionary<string, TextTypeEnum>()
            {
                { "DYNAMIC", DYNAMIC },
                { "STATIC", STATIC },
            };

            private string _value;

            public TextTypeEnum()
            {

            }

            public TextTypeEnum(string value)
            {
                _value = value;
            }

            public static TextTypeEnum FromValue(string value)
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

                if (this.Equals(obj as TextTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TextTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TextTypeEnum a, TextTypeEnum b)
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

            public static bool operator !=(TextTypeEnum a, TextTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 文本类型。 * DYNAMIC：动态文本，需要进行关键字替换。 * STATIC：静态文本。
        /// </summary>
        [JsonProperty("text_type", NullValueHandling = NullValueHandling.Ignore)]
        public TextTypeEnum TextType { get; set; }
        /// <summary>
        /// 文本。
        /// </summary>
        [JsonProperty("text_context", NullValueHandling = NullValueHandling.Ignore)]
        public string TextContext { get; set; }

        /// <summary>
        /// **参数解释**： 字体。当前支持的字体： * HarmonyOS_Sans_SC_Black：鸿蒙粗体 * HarmonyOS_Sans_SC_Regular：鸿蒙常规 * HarmonyOS_Sans_SC_Thin：鸿蒙细体 * fzyouh：方正瘦体
        /// </summary>
        [JsonProperty("font_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FontName { get; set; }

        /// <summary>
        /// **参数解释**： 字体大小（像素）。  业务取值范围：[4, 120]，请以业务取值范围为准。
        /// </summary>
        [JsonProperty("font_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? FontSize { get; set; }

        /// <summary>
        /// **参数解释**： 字体颜色。RGB颜色值。
        /// </summary>
        [JsonProperty("font_color", NullValueHandling = NullValueHandling.Ignore)]
        public string FontColor { get; set; }

        /// <summary>
        /// **参数解释**： 文本显示时长，单位s。 显示时长规则为，若携带reply_texts、reply_audios，则与播放语音内容时长保持一致；若未携带，则与匹配的关键词语音内容时长保持一致。
        /// </summary>
        [JsonProperty("display_duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? DisplayDuration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmartTextLayerConfig {\n");
            sb.Append("  textType: ").Append(TextType).Append("\n");
            sb.Append("  textContext: ").Append(TextContext).Append("\n");
            sb.Append("  fontName: ").Append(FontName).Append("\n");
            sb.Append("  fontSize: ").Append(FontSize).Append("\n");
            sb.Append("  fontColor: ").Append(FontColor).Append("\n");
            sb.Append("  displayDuration: ").Append(DisplayDuration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SmartTextLayerConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmartTextLayerConfig input)
        {
            if (input == null) return false;
            if (this.TextType != input.TextType) return false;
            if (this.TextContext != input.TextContext || (this.TextContext != null && !this.TextContext.Equals(input.TextContext))) return false;
            if (this.FontName != input.FontName || (this.FontName != null && !this.FontName.Equals(input.FontName))) return false;
            if (this.FontSize != input.FontSize || (this.FontSize != null && !this.FontSize.Equals(input.FontSize))) return false;
            if (this.FontColor != input.FontColor || (this.FontColor != null && !this.FontColor.Equals(input.FontColor))) return false;
            if (this.DisplayDuration != input.DisplayDuration || (this.DisplayDuration != null && !this.DisplayDuration.Equals(input.DisplayDuration))) return false;

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
                hashCode = hashCode * 59 + this.TextType.GetHashCode();
                if (this.TextContext != null) hashCode = hashCode * 59 + this.TextContext.GetHashCode();
                if (this.FontName != null) hashCode = hashCode * 59 + this.FontName.GetHashCode();
                if (this.FontSize != null) hashCode = hashCode * 59 + this.FontSize.GetHashCode();
                if (this.FontColor != null) hashCode = hashCode * 59 + this.FontColor.GetHashCode();
                if (this.DisplayDuration != null) hashCode = hashCode * 59 + this.DisplayDuration.GetHashCode();
                return hashCode;
            }
        }
    }
}
