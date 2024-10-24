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
    /// 音频选择器语言设置
    /// </summary>
    public class AudioSelectorLangSelection 
    {
        /// <summary>
        /// 语言输出策略。  取值如下： - LOOSE：宽松匹配，示例“eng”会优先匹配源流中语言为English的音轨，如果匹配不到，则选择PID最小的音轨。 - STRICT：严格匹配，示例“eng”会严格匹配源流中语言为English的音轨，如果匹配不到，媒体直播服务会自动补齐一个静音分片，当终端使用此音频选择器播放视频时，会静音播放。
        /// </summary>
        /// <value>语言输出策略。  取值如下： - LOOSE：宽松匹配，示例“eng”会优先匹配源流中语言为English的音轨，如果匹配不到，则选择PID最小的音轨。 - STRICT：严格匹配，示例“eng”会严格匹配源流中语言为English的音轨，如果匹配不到，媒体直播服务会自动补齐一个静音分片，当终端使用此音频选择器播放视频时，会静音播放。</value>
        [JsonConverter(typeof(EnumClassConverter<LanguageSelectionPolicyEnum>))]
        public class LanguageSelectionPolicyEnum
        {
            /// <summary>
            /// Enum LOOSE for value: LOOSE
            /// </summary>
            public static readonly LanguageSelectionPolicyEnum LOOSE = new LanguageSelectionPolicyEnum("LOOSE");

            /// <summary>
            /// Enum STRICT for value: STRICT
            /// </summary>
            public static readonly LanguageSelectionPolicyEnum STRICT = new LanguageSelectionPolicyEnum("STRICT");

            private static readonly Dictionary<string, LanguageSelectionPolicyEnum> StaticFields =
            new Dictionary<string, LanguageSelectionPolicyEnum>()
            {
                { "LOOSE", LOOSE },
                { "STRICT", STRICT },
            };

            private string _value;

            public LanguageSelectionPolicyEnum()
            {

            }

            public LanguageSelectionPolicyEnum(string value)
            {
                _value = value;
            }

            public static LanguageSelectionPolicyEnum FromValue(string value)
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

                if (this.Equals(obj as LanguageSelectionPolicyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LanguageSelectionPolicyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LanguageSelectionPolicyEnum a, LanguageSelectionPolicyEnum b)
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

            public static bool operator !=(LanguageSelectionPolicyEnum a, LanguageSelectionPolicyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 语言简称，输入2或3个小写字母的语言代码。
        /// </summary>
        [JsonProperty("language_code", NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// 语言输出策略。  取值如下： - LOOSE：宽松匹配，示例“eng”会优先匹配源流中语言为English的音轨，如果匹配不到，则选择PID最小的音轨。 - STRICT：严格匹配，示例“eng”会严格匹配源流中语言为English的音轨，如果匹配不到，媒体直播服务会自动补齐一个静音分片，当终端使用此音频选择器播放视频时，会静音播放。
        /// </summary>
        [JsonProperty("language_selection_policy", NullValueHandling = NullValueHandling.Ignore)]
        public LanguageSelectionPolicyEnum LanguageSelectionPolicy { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AudioSelectorLangSelection {\n");
            sb.Append("  languageCode: ").Append(LanguageCode).Append("\n");
            sb.Append("  languageSelectionPolicy: ").Append(LanguageSelectionPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AudioSelectorLangSelection);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AudioSelectorLangSelection input)
        {
            if (input == null) return false;
            if (this.LanguageCode != input.LanguageCode || (this.LanguageCode != null && !this.LanguageCode.Equals(input.LanguageCode))) return false;
            if (this.LanguageSelectionPolicy != input.LanguageSelectionPolicy) return false;

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
                if (this.LanguageCode != null) hashCode = hashCode * 59 + this.LanguageCode.GetHashCode();
                hashCode = hashCode * 59 + this.LanguageSelectionPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
