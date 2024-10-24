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
    public class EncoderSettingsExpandAudioDescriptions 
    {
        /// <summary>
        /// 语言代码控制。这里的设置不会修改音频实际的语言，只会修改音频对外展示的语言。  包含如下选项： - FOLLOW_INPUT：如果所选音频选择器对应的输出音频有语言，则与其保持一致，否则会以这里配置的语言代码和流名称进行兜底。推荐当前选项，为默认值。 - USE_CONFIGURED：用户根据实际情况自定义输出音频的语言和流名称。
        /// </summary>
        /// <value>语言代码控制。这里的设置不会修改音频实际的语言，只会修改音频对外展示的语言。  包含如下选项： - FOLLOW_INPUT：如果所选音频选择器对应的输出音频有语言，则与其保持一致，否则会以这里配置的语言代码和流名称进行兜底。推荐当前选项，为默认值。 - USE_CONFIGURED：用户根据实际情况自定义输出音频的语言和流名称。</value>
        [JsonConverter(typeof(EnumClassConverter<LanguageCodeControlEnum>))]
        public class LanguageCodeControlEnum
        {
            /// <summary>
            /// Enum FOLLOW_INPUT for value: FOLLOW_INPUT
            /// </summary>
            public static readonly LanguageCodeControlEnum FOLLOW_INPUT = new LanguageCodeControlEnum("FOLLOW_INPUT");

            /// <summary>
            /// Enum USE_CONFIGURED for value: USE_CONFIGURED
            /// </summary>
            public static readonly LanguageCodeControlEnum USE_CONFIGURED = new LanguageCodeControlEnum("USE_CONFIGURED");

            private static readonly Dictionary<string, LanguageCodeControlEnum> StaticFields =
            new Dictionary<string, LanguageCodeControlEnum>()
            {
                { "FOLLOW_INPUT", FOLLOW_INPUT },
                { "USE_CONFIGURED", USE_CONFIGURED },
            };

            private string _value;

            public LanguageCodeControlEnum()
            {

            }

            public LanguageCodeControlEnum(string value)
            {
                _value = value;
            }

            public static LanguageCodeControlEnum FromValue(string value)
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

                if (this.Equals(obj as LanguageCodeControlEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LanguageCodeControlEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LanguageCodeControlEnum a, LanguageCodeControlEnum b)
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

            public static bool operator !=(LanguageCodeControlEnum a, LanguageCodeControlEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 音频输出配置的名称。仅支持大小写字母，数字，中划线（-），下划线（_）。  同一个频道不同的音频输出配置名称，不允许重复。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 音频选择器名称
        /// </summary>
        [JsonProperty("audio_selector_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AudioSelectorName { get; set; }

        /// <summary>
        /// 语言代码控制。这里的设置不会修改音频实际的语言，只会修改音频对外展示的语言。  包含如下选项： - FOLLOW_INPUT：如果所选音频选择器对应的输出音频有语言，则与其保持一致，否则会以这里配置的语言代码和流名称进行兜底。推荐当前选项，为默认值。 - USE_CONFIGURED：用户根据实际情况自定义输出音频的语言和流名称。
        /// </summary>
        [JsonProperty("language_code_control", NullValueHandling = NullValueHandling.Ignore)]
        public LanguageCodeControlEnum LanguageCodeControl { get; set; }
        /// <summary>
        /// 语言代码，输入2或3个小写字母。
        /// </summary>
        [JsonProperty("language_code", NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// 流名称
        /// </summary>
        [JsonProperty("stream_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StreamName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EncoderSettingsExpandAudioDescriptions {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  audioSelectorName: ").Append(AudioSelectorName).Append("\n");
            sb.Append("  languageCodeControl: ").Append(LanguageCodeControl).Append("\n");
            sb.Append("  languageCode: ").Append(LanguageCode).Append("\n");
            sb.Append("  streamName: ").Append(StreamName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EncoderSettingsExpandAudioDescriptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EncoderSettingsExpandAudioDescriptions input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.AudioSelectorName != input.AudioSelectorName || (this.AudioSelectorName != null && !this.AudioSelectorName.Equals(input.AudioSelectorName))) return false;
            if (this.LanguageCodeControl != input.LanguageCodeControl) return false;
            if (this.LanguageCode != input.LanguageCode || (this.LanguageCode != null && !this.LanguageCode.Equals(input.LanguageCode))) return false;
            if (this.StreamName != input.StreamName || (this.StreamName != null && !this.StreamName.Equals(input.StreamName))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AudioSelectorName != null) hashCode = hashCode * 59 + this.AudioSelectorName.GetHashCode();
                hashCode = hashCode * 59 + this.LanguageCodeControl.GetHashCode();
                if (this.LanguageCode != null) hashCode = hashCode * 59 + this.LanguageCode.GetHashCode();
                if (this.StreamName != null) hashCode = hashCode * 59 + this.StreamName.GetHashCode();
                return hashCode;
            }
        }
    }
}
