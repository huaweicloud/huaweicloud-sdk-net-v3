using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 音频。
    /// </summary>
    public class PoliciesAudio 
    {
        /// <summary>
        /// 播音场景。取值为： 无损播音：LossLess。 语音通话：Speech Call。 音乐播音：Music Play。 自动识别：Automatic Identification。
        /// </summary>
        /// <value>播音场景。取值为： 无损播音：LossLess。 语音通话：Speech Call。 音乐播音：Music Play。 自动识别：Automatic Identification。</value>
        [JsonConverter(typeof(EnumClassConverter<PlayClassificationEnum>))]
        public class PlayClassificationEnum
        {
            /// <summary>
            /// Enum LOSSLESS for value: LossLess
            /// </summary>
            public static readonly PlayClassificationEnum LOSSLESS = new PlayClassificationEnum("LossLess");

            /// <summary>
            /// Enum SPEECH_CALL for value: Speech Call
            /// </summary>
            public static readonly PlayClassificationEnum SPEECH_CALL = new PlayClassificationEnum("Speech Call");

            /// <summary>
            /// Enum MUSIC_PLAY for value: Music Play
            /// </summary>
            public static readonly PlayClassificationEnum MUSIC_PLAY = new PlayClassificationEnum("Music Play");

            /// <summary>
            /// Enum AUTOMATIC_IDENTIFICATION for value: Automatic Identification
            /// </summary>
            public static readonly PlayClassificationEnum AUTOMATIC_IDENTIFICATION = new PlayClassificationEnum("Automatic Identification");

            private static readonly Dictionary<string, PlayClassificationEnum> StaticFields =
            new Dictionary<string, PlayClassificationEnum>()
            {
                { "LossLess", LOSSLESS },
                { "Speech Call", SPEECH_CALL },
                { "Music Play", MUSIC_PLAY },
                { "Automatic Identification", AUTOMATIC_IDENTIFICATION },
            };

            private string _value;

            public PlayClassificationEnum()
            {

            }

            public PlayClassificationEnum(string value)
            {
                _value = value;
            }

            public static PlayClassificationEnum FromValue(string value)
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

                if (this.Equals(obj as PlayClassificationEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PlayClassificationEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PlayClassificationEnum a, PlayClassificationEnum b)
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

            public static bool operator !=(PlayClassificationEnum a, PlayClassificationEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 录音场景。取值为： 无损录音：LossLess。 语音通话：Speech Call。 音乐录音：Music Record。 自动识别：Automatic Identification。
        /// </summary>
        /// <value>录音场景。取值为： 无损录音：LossLess。 语音通话：Speech Call。 音乐录音：Music Record。 自动识别：Automatic Identification。</value>
        [JsonConverter(typeof(EnumClassConverter<RecordClassificationEnum>))]
        public class RecordClassificationEnum
        {
            /// <summary>
            /// Enum LOSSLESS for value: LossLess
            /// </summary>
            public static readonly RecordClassificationEnum LOSSLESS = new RecordClassificationEnum("LossLess");

            /// <summary>
            /// Enum SPEECH_CALL for value: Speech Call
            /// </summary>
            public static readonly RecordClassificationEnum SPEECH_CALL = new RecordClassificationEnum("Speech Call");

            /// <summary>
            /// Enum MUSIC_RECORD for value: Music Record
            /// </summary>
            public static readonly RecordClassificationEnum MUSIC_RECORD = new RecordClassificationEnum("Music Record");

            /// <summary>
            /// Enum AUTOMATIC_IDENTIFICATION for value: Automatic Identification
            /// </summary>
            public static readonly RecordClassificationEnum AUTOMATIC_IDENTIFICATION = new RecordClassificationEnum("Automatic Identification");

            private static readonly Dictionary<string, RecordClassificationEnum> StaticFields =
            new Dictionary<string, RecordClassificationEnum>()
            {
                { "LossLess", LOSSLESS },
                { "Speech Call", SPEECH_CALL },
                { "Music Record", MUSIC_RECORD },
                { "Automatic Identification", AUTOMATIC_IDENTIFICATION },
            };

            private string _value;

            public RecordClassificationEnum()
            {

            }

            public RecordClassificationEnum(string value)
            {
                _value = value;
            }

            public static RecordClassificationEnum FromValue(string value)
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

                if (this.Equals(obj as RecordClassificationEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RecordClassificationEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RecordClassificationEnum a, RecordClassificationEnum b)
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

            public static bool operator !=(RecordClassificationEnum a, RecordClassificationEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 是否开启音频重定向。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("audio_redirection_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AudioRedirectionEnable { get; set; }

        /// <summary>
        /// 是否开启播音重定向。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("play_redirection_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PlayRedirectionEnable { get; set; }

        /// <summary>
        /// 播音场景。取值为： 无损播音：LossLess。 语音通话：Speech Call。 音乐播音：Music Play。 自动识别：Automatic Identification。
        /// </summary>
        [JsonProperty("play_classification", NullValueHandling = NullValueHandling.Ignore)]
        public PlayClassificationEnum PlayClassification { get; set; }
        /// <summary>
        /// 是否开启录音重定向。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("record_redirection_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RecordRedirectionEnable { get; set; }

        /// <summary>
        /// 录音场景。取值为： 无损录音：LossLess。 语音通话：Speech Call。 音乐录音：Music Record。 自动识别：Automatic Identification。
        /// </summary>
        [JsonProperty("record_classification", NullValueHandling = NullValueHandling.Ignore)]
        public RecordClassificationEnum RecordClassification { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesAudio {\n");
            sb.Append("  audioRedirectionEnable: ").Append(AudioRedirectionEnable).Append("\n");
            sb.Append("  playRedirectionEnable: ").Append(PlayRedirectionEnable).Append("\n");
            sb.Append("  playClassification: ").Append(PlayClassification).Append("\n");
            sb.Append("  recordRedirectionEnable: ").Append(RecordRedirectionEnable).Append("\n");
            sb.Append("  recordClassification: ").Append(RecordClassification).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesAudio);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesAudio input)
        {
            if (input == null) return false;
            if (this.AudioRedirectionEnable != input.AudioRedirectionEnable || (this.AudioRedirectionEnable != null && !this.AudioRedirectionEnable.Equals(input.AudioRedirectionEnable))) return false;
            if (this.PlayRedirectionEnable != input.PlayRedirectionEnable || (this.PlayRedirectionEnable != null && !this.PlayRedirectionEnable.Equals(input.PlayRedirectionEnable))) return false;
            if (this.PlayClassification != input.PlayClassification) return false;
            if (this.RecordRedirectionEnable != input.RecordRedirectionEnable || (this.RecordRedirectionEnable != null && !this.RecordRedirectionEnable.Equals(input.RecordRedirectionEnable))) return false;
            if (this.RecordClassification != input.RecordClassification) return false;

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
                if (this.AudioRedirectionEnable != null) hashCode = hashCode * 59 + this.AudioRedirectionEnable.GetHashCode();
                if (this.PlayRedirectionEnable != null) hashCode = hashCode * 59 + this.PlayRedirectionEnable.GetHashCode();
                hashCode = hashCode * 59 + this.PlayClassification.GetHashCode();
                if (this.RecordRedirectionEnable != null) hashCode = hashCode * 59 + this.RecordRedirectionEnable.GetHashCode();
                hashCode = hashCode * 59 + this.RecordClassification.GetHashCode();
                return hashCode;
            }
        }
    }
}
