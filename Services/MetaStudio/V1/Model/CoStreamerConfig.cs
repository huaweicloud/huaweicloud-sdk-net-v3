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
    /// 助播配置
    /// </summary>
    public class CoStreamerConfig 
    {
        /// <summary>
        /// **参数解释**： 助播出声时主播行为设置。 **约束限制**： 不涉及 **取值范围**： * SILENCE：静默 * VOLUME_DOWN：音量降低  **默认取值**： 不涉及。
        /// </summary>
        /// <value>**参数解释**： 助播出声时主播行为设置。 **约束限制**： 不涉及 **取值范围**： * SILENCE：静默 * VOLUME_DOWN：音量降低  **默认取值**： 不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<StreamerActionEnum>))]
        public class StreamerActionEnum
        {
            /// <summary>
            /// Enum SILENCE for value: SILENCE
            /// </summary>
            public static readonly StreamerActionEnum SILENCE = new StreamerActionEnum("SILENCE");

            /// <summary>
            /// Enum VOLUME_DOWN for value: VOLUME_DOWN
            /// </summary>
            public static readonly StreamerActionEnum VOLUME_DOWN = new StreamerActionEnum("VOLUME_DOWN");

            private static readonly Dictionary<string, StreamerActionEnum> StaticFields =
            new Dictionary<string, StreamerActionEnum>()
            {
                { "SILENCE", SILENCE },
                { "VOLUME_DOWN", VOLUME_DOWN },
            };

            private string _value;

            public StreamerActionEnum()
            {

            }

            public StreamerActionEnum(string value)
            {
                _value = value;
            }

            public static StreamerActionEnum FromValue(string value)
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

                if (this.Equals(obj as StreamerActionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StreamerActionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StreamerActionEnum a, StreamerActionEnum b)
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

            public static bool operator !=(StreamerActionEnum a, StreamerActionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("voice_config", NullValueHandling = NullValueHandling.Ignore)]
        public VoiceConfig VoiceConfig { get; set; }

        /// <summary>
        /// **参数解释**： 助播出声时主播行为设置。 **约束限制**： 不涉及 **取值范围**： * SILENCE：静默 * VOLUME_DOWN：音量降低  **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("streamer_action", NullValueHandling = NullValueHandling.Ignore)]
        public StreamerActionEnum StreamerAction { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CoStreamerConfig {\n");
            sb.Append("  voiceConfig: ").Append(VoiceConfig).Append("\n");
            sb.Append("  streamerAction: ").Append(StreamerAction).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CoStreamerConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CoStreamerConfig input)
        {
            if (input == null) return false;
            if (this.VoiceConfig != input.VoiceConfig || (this.VoiceConfig != null && !this.VoiceConfig.Equals(input.VoiceConfig))) return false;
            if (this.StreamerAction != input.StreamerAction) return false;

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
                if (this.VoiceConfig != null) hashCode = hashCode * 59 + this.VoiceConfig.GetHashCode();
                hashCode = hashCode * 59 + this.StreamerAction.GetHashCode();
                return hashCode;
            }
        }
    }
}
