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
    /// 动作动画资产元数据。
    /// </summary>
    public class AnimationAssetMeta 
    {
        /// <summary>
        /// 动画插入位置限制。 * ONLY_BEGINNING：视频制作时，动画只允许出现在起始位置。 * ONLY_END：视频制作时，动画只允许出现在结束位置。
        /// </summary>
        /// <value>动画插入位置限制。 * ONLY_BEGINNING：视频制作时，动画只允许出现在起始位置。 * ONLY_END：视频制作时，动画只允许出现在结束位置。</value>
        [JsonConverter(typeof(EnumClassConverter<AnimationInsertRestrictionEnum>))]
        public class AnimationInsertRestrictionEnum
        {
            /// <summary>
            /// Enum ONLY_BEGINNING for value: ONLY_BEGINNING
            /// </summary>
            public static readonly AnimationInsertRestrictionEnum ONLY_BEGINNING = new AnimationInsertRestrictionEnum("ONLY_BEGINNING");

            /// <summary>
            /// Enum ONLY_END for value: ONLY_END
            /// </summary>
            public static readonly AnimationInsertRestrictionEnum ONLY_END = new AnimationInsertRestrictionEnum("ONLY_END");

            private static readonly Dictionary<string, AnimationInsertRestrictionEnum> StaticFields =
            new Dictionary<string, AnimationInsertRestrictionEnum>()
            {
                { "ONLY_BEGINNING", ONLY_BEGINNING },
                { "ONLY_END", ONLY_END },
            };

            private string _value;

            public AnimationInsertRestrictionEnum()
            {

            }

            public AnimationInsertRestrictionEnum(string value)
            {
                _value = value;
            }

            public static AnimationInsertRestrictionEnum FromValue(string value)
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

                if (this.Equals(obj as AnimationInsertRestrictionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AnimationInsertRestrictionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AnimationInsertRestrictionEnum a, AnimationInsertRestrictionEnum b)
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

            public static bool operator !=(AnimationInsertRestrictionEnum a, AnimationInsertRestrictionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 数字人模型风格ID。
        /// </summary>
        [JsonProperty("style_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StyleId { get; set; }

        /// <summary>
        /// 动作动画时长。
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public float? Duration { get; set; }

        /// <summary>
        /// 动作是否需要自动解析。
        /// </summary>
        [JsonProperty("auto_analysis", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoAnalysis { get; set; }

        /// <summary>
        /// 语音延迟播放时长。  单位秒。  使用场景举例：入场动画3秒，voice_delay设置成4秒，则语音从入场动画开始后第4秒开始播放。
        /// </summary>
        [JsonProperty("voice_delay", NullValueHandling = NullValueHandling.Ignore)]
        public float? VoiceDelay { get; set; }

        /// <summary>
        /// 动画插入位置限制。 * ONLY_BEGINNING：视频制作时，动画只允许出现在起始位置。 * ONLY_END：视频制作时，动画只允许出现在结束位置。
        /// </summary>
        [JsonProperty("animation_insert_restriction", NullValueHandling = NullValueHandling.Ignore)]
        public AnimationInsertRestrictionEnum AnimationInsertRestriction { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnimationAssetMeta {\n");
            sb.Append("  styleId: ").Append(StyleId).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  autoAnalysis: ").Append(AutoAnalysis).Append("\n");
            sb.Append("  voiceDelay: ").Append(VoiceDelay).Append("\n");
            sb.Append("  animationInsertRestriction: ").Append(AnimationInsertRestriction).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AnimationAssetMeta);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AnimationAssetMeta input)
        {
            if (input == null) return false;
            if (this.StyleId != input.StyleId || (this.StyleId != null && !this.StyleId.Equals(input.StyleId))) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;
            if (this.AutoAnalysis != input.AutoAnalysis || (this.AutoAnalysis != null && !this.AutoAnalysis.Equals(input.AutoAnalysis))) return false;
            if (this.VoiceDelay != input.VoiceDelay || (this.VoiceDelay != null && !this.VoiceDelay.Equals(input.VoiceDelay))) return false;
            if (this.AnimationInsertRestriction != input.AnimationInsertRestriction) return false;

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
                if (this.StyleId != null) hashCode = hashCode * 59 + this.StyleId.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.AutoAnalysis != null) hashCode = hashCode * 59 + this.AutoAnalysis.GetHashCode();
                if (this.VoiceDelay != null) hashCode = hashCode * 59 + this.VoiceDelay.GetHashCode();
                hashCode = hashCode * 59 + this.AnimationInsertRestriction.GetHashCode();
                return hashCode;
            }
        }
    }
}
