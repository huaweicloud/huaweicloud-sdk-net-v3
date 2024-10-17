using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Sis.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AnalysisInfo 
    {
        /// <summary>
        /// 语音文件声道信息，可以为MONO（缺省), LEFT_AGENT, RIGHT_AGENT。  如果channel 为MONO，那么原始文件需要为单声道文件。  如果为双声道文件，系统会将其转换成单声道文件，可能会影响识别效果。  如果 channel 为 LEFT_AGENT或RIGHT_AGENT, 则原始文件需要为双声道文件，如果为单声道文件，系统会将其转换成双声道文件，可能会影响识别效果。  当channel 为 LEFT_AGENT或RIGHT_AGENT，且diarization为true时，系统会按照配置给出对应角色。其中：  LEFT_AGENT 指定左声道语音为agent（坐席）,  RIGHT_AGENT 指定右声道为agent（坐席）。
        /// </summary>
        /// <value>语音文件声道信息，可以为MONO（缺省), LEFT_AGENT, RIGHT_AGENT。  如果channel 为MONO，那么原始文件需要为单声道文件。  如果为双声道文件，系统会将其转换成单声道文件，可能会影响识别效果。  如果 channel 为 LEFT_AGENT或RIGHT_AGENT, 则原始文件需要为双声道文件，如果为单声道文件，系统会将其转换成双声道文件，可能会影响识别效果。  当channel 为 LEFT_AGENT或RIGHT_AGENT，且diarization为true时，系统会按照配置给出对应角色。其中：  LEFT_AGENT 指定左声道语音为agent（坐席）,  RIGHT_AGENT 指定右声道为agent（坐席）。</value>
        [JsonConverter(typeof(EnumClassConverter<ChannelEnum>))]
        public class ChannelEnum
        {
            /// <summary>
            /// Enum MONO for value: MONO
            /// </summary>
            public static readonly ChannelEnum MONO = new ChannelEnum("MONO");

            /// <summary>
            /// Enum LEFT_AGENT for value: LEFT_AGENT
            /// </summary>
            public static readonly ChannelEnum LEFT_AGENT = new ChannelEnum("LEFT_AGENT");

            /// <summary>
            /// Enum RIGHT_AGENT for value: RIGHT_AGENT
            /// </summary>
            public static readonly ChannelEnum RIGHT_AGENT = new ChannelEnum("RIGHT_AGENT");

            private static readonly Dictionary<string, ChannelEnum> StaticFields =
            new Dictionary<string, ChannelEnum>()
            {
                { "MONO", MONO },
                { "LEFT_AGENT", LEFT_AGENT },
                { "RIGHT_AGENT", RIGHT_AGENT },
            };

            private string _value;

            public ChannelEnum()
            {

            }

            public ChannelEnum(string value)
            {
                _value = value;
            }

            public static ChannelEnum FromValue(string value)
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

                if (this.Equals(obj as ChannelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ChannelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ChannelEnum a, ChannelEnum b)
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

            public static bool operator !=(ChannelEnum a, ChannelEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 是否需要做话者分离。缺省为true，表示会进行话者分离，识别结果中会包含role项（角色）。如果diarization为false, 那么结果中不会出现role项。
        /// </summary>
        [JsonProperty("diarization", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Diarization { get; set; }

        /// <summary>
        /// 语音文件声道信息，可以为MONO（缺省), LEFT_AGENT, RIGHT_AGENT。  如果channel 为MONO，那么原始文件需要为单声道文件。  如果为双声道文件，系统会将其转换成单声道文件，可能会影响识别效果。  如果 channel 为 LEFT_AGENT或RIGHT_AGENT, 则原始文件需要为双声道文件，如果为单声道文件，系统会将其转换成双声道文件，可能会影响识别效果。  当channel 为 LEFT_AGENT或RIGHT_AGENT，且diarization为true时，系统会按照配置给出对应角色。其中：  LEFT_AGENT 指定左声道语音为agent（坐席）,  RIGHT_AGENT 指定右声道为agent（坐席）。
        /// </summary>
        [JsonProperty("channel", NullValueHandling = NullValueHandling.Ignore)]
        public ChannelEnum Channel { get; set; }
        /// <summary>
        /// 是否需要做情绪检测, 缺省为true。
        /// </summary>
        [JsonProperty("emotion", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Emotion { get; set; }

        /// <summary>
        /// 是否需要输出语速信息, 缺省为true。
        /// </summary>
        [JsonProperty("speed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Speed { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalysisInfo {\n");
            sb.Append("  diarization: ").Append(Diarization).Append("\n");
            sb.Append("  channel: ").Append(Channel).Append("\n");
            sb.Append("  emotion: ").Append(Emotion).Append("\n");
            sb.Append("  speed: ").Append(Speed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AnalysisInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AnalysisInfo input)
        {
            if (input == null) return false;
            if (this.Diarization != input.Diarization || (this.Diarization != null && !this.Diarization.Equals(input.Diarization))) return false;
            if (this.Channel != input.Channel) return false;
            if (this.Emotion != input.Emotion || (this.Emotion != null && !this.Emotion.Equals(input.Emotion))) return false;
            if (this.Speed != input.Speed || (this.Speed != null && !this.Speed.Equals(input.Speed))) return false;

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
                if (this.Diarization != null) hashCode = hashCode * 59 + this.Diarization.GetHashCode();
                hashCode = hashCode * 59 + this.Channel.GetHashCode();
                if (this.Emotion != null) hashCode = hashCode * 59 + this.Emotion.GetHashCode();
                if (this.Speed != null) hashCode = hashCode * 59 + this.Speed.GetHashCode();
                return hashCode;
            }
        }
    }
}
