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
    /// 直播使用互动配置信息
    /// </summary>
    public class LiveRoomInteractionConfig 
    {
        /// <summary>
        /// 播放类型。 - APPEND：追加，放置在场景播放队列尾部 - INSERT： 插入，在两个音频文件，或者文本句末添加。 - PLAY_NOW : 立即插入，收到指令后，立即播放，无需等待句末。
        /// </summary>
        /// <value>播放类型。 - APPEND：追加，放置在场景播放队列尾部 - INSERT： 插入，在两个音频文件，或者文本句末添加。 - PLAY_NOW : 立即插入，收到指令后，立即播放，无需等待句末。</value>
        [JsonConverter(typeof(EnumClassConverter<PlayTypeEnum>))]
        public class PlayTypeEnum
        {
            /// <summary>
            /// Enum APPEND for value: APPEND
            /// </summary>
            public static readonly PlayTypeEnum APPEND = new PlayTypeEnum("APPEND");

            /// <summary>
            /// Enum INSERT for value: INSERT
            /// </summary>
            public static readonly PlayTypeEnum INSERT = new PlayTypeEnum("INSERT");

            /// <summary>
            /// Enum PLAY_NOW for value: PLAY_NOW
            /// </summary>
            public static readonly PlayTypeEnum PLAY_NOW = new PlayTypeEnum("PLAY_NOW");

            private static readonly Dictionary<string, PlayTypeEnum> StaticFields =
            new Dictionary<string, PlayTypeEnum>()
            {
                { "APPEND", APPEND },
                { "INSERT", INSERT },
                { "PLAY_NOW", PLAY_NOW },
            };

            private string _value;

            public PlayTypeEnum()
            {

            }

            public PlayTypeEnum(string value)
            {
                _value = value;
            }

            public static PlayTypeEnum FromValue(string value)
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

                if (this.Equals(obj as PlayTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PlayTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PlayTypeEnum a, PlayTypeEnum b)
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

            public static bool operator !=(PlayTypeEnum a, PlayTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 播放类型。 - APPEND：追加，放置在场景播放队列尾部 - INSERT： 插入，在两个音频文件，或者文本句末添加。 - PLAY_NOW : 立即插入，收到指令后，立即播放，无需等待句末。
        /// </summary>
        [JsonProperty("play_type", NullValueHandling = NullValueHandling.Ignore)]
        public PlayTypeEnum PlayType { get; set; }
        /// <summary>
        /// 忽略互动回复中断句子后半句不再播放。用于立即中断场景。默认不忽略。
        /// </summary>
        [JsonProperty("ignore_current_sentence", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IgnoreCurrentSentence { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LiveRoomInteractionConfig {\n");
            sb.Append("  playType: ").Append(PlayType).Append("\n");
            sb.Append("  ignoreCurrentSentence: ").Append(IgnoreCurrentSentence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LiveRoomInteractionConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LiveRoomInteractionConfig input)
        {
            if (input == null) return false;
            if (this.PlayType != input.PlayType) return false;
            if (this.IgnoreCurrentSentence != input.IgnoreCurrentSentence || (this.IgnoreCurrentSentence != null && !this.IgnoreCurrentSentence.Equals(input.IgnoreCurrentSentence))) return false;

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
                hashCode = hashCode * 59 + this.PlayType.GetHashCode();
                if (this.IgnoreCurrentSentence != null) hashCode = hashCode * 59 + this.IgnoreCurrentSentence.GetHashCode();
                return hashCode;
            }
        }
    }
}
