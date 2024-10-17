using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AudioInfo 
    {
        /// <summary>
        /// 音频采样率(有效值范围)&lt;br/&gt; AUDIO_SAMPLE_AUTO (default), AUDIO_SAMPLE_22050：22050Hz&lt;br/&gt; AUDIO_SAMPLE_32000：32000Hz&lt;br/&gt; AUDIO_SAMPLE_44100：44100Hz&lt;br/&gt; AUDIO_SAMPLE_48000：48000Hz&lt;br/&gt; AUDIO_SAMPLE_96000：96000Hz&lt;br/&gt; 
        /// </summary>
        /// <value>音频采样率(有效值范围)&lt;br/&gt; AUDIO_SAMPLE_AUTO (default), AUDIO_SAMPLE_22050：22050Hz&lt;br/&gt; AUDIO_SAMPLE_32000：32000Hz&lt;br/&gt; AUDIO_SAMPLE_44100：44100Hz&lt;br/&gt; AUDIO_SAMPLE_48000：48000Hz&lt;br/&gt; AUDIO_SAMPLE_96000：96000Hz&lt;br/&gt; </value>
        [JsonConverter(typeof(EnumClassConverter<SampleRateEnum>))]
        public class SampleRateEnum
        {
            /// <summary>
            /// Enum AUDIO_SAMPLE_AUTO for value: AUDIO_SAMPLE_AUTO
            /// </summary>
            public static readonly SampleRateEnum AUDIO_SAMPLE_AUTO = new SampleRateEnum("AUDIO_SAMPLE_AUTO");

            /// <summary>
            /// Enum AUDIO_SAMPLE_22050 for value: AUDIO_SAMPLE_22050
            /// </summary>
            public static readonly SampleRateEnum AUDIO_SAMPLE_22050 = new SampleRateEnum("AUDIO_SAMPLE_22050");

            /// <summary>
            /// Enum AUDIO_SAMPLE_32000 for value: AUDIO_SAMPLE_32000
            /// </summary>
            public static readonly SampleRateEnum AUDIO_SAMPLE_32000 = new SampleRateEnum("AUDIO_SAMPLE_32000");

            /// <summary>
            /// Enum AUDIO_SAMPLE_44100 for value: AUDIO_SAMPLE_44100
            /// </summary>
            public static readonly SampleRateEnum AUDIO_SAMPLE_44100 = new SampleRateEnum("AUDIO_SAMPLE_44100");

            /// <summary>
            /// Enum AUDIO_SAMPLE_48000 for value: AUDIO_SAMPLE_48000
            /// </summary>
            public static readonly SampleRateEnum AUDIO_SAMPLE_48000 = new SampleRateEnum("AUDIO_SAMPLE_48000");

            /// <summary>
            /// Enum AUDIO_SAMPLE_96000 for value: AUDIO_SAMPLE_96000
            /// </summary>
            public static readonly SampleRateEnum AUDIO_SAMPLE_96000 = new SampleRateEnum("AUDIO_SAMPLE_96000");

            private static readonly Dictionary<string, SampleRateEnum> StaticFields =
            new Dictionary<string, SampleRateEnum>()
            {
                { "AUDIO_SAMPLE_AUTO", AUDIO_SAMPLE_AUTO },
                { "AUDIO_SAMPLE_22050", AUDIO_SAMPLE_22050 },
                { "AUDIO_SAMPLE_32000", AUDIO_SAMPLE_32000 },
                { "AUDIO_SAMPLE_44100", AUDIO_SAMPLE_44100 },
                { "AUDIO_SAMPLE_48000", AUDIO_SAMPLE_48000 },
                { "AUDIO_SAMPLE_96000", AUDIO_SAMPLE_96000 },
            };

            private string _value;

            public SampleRateEnum()
            {

            }

            public SampleRateEnum(string value)
            {
                _value = value;
            }

            public static SampleRateEnum FromValue(string value)
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

                if (this.Equals(obj as SampleRateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SampleRateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SampleRateEnum a, SampleRateEnum b)
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

            public static bool operator !=(SampleRateEnum a, SampleRateEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 声道数(有效值范围)&lt;br/&gt; AUDIO_CHANNELS_1:单声道&lt;br/&gt; AUDIO_CHANNELS_2：双声道&lt;br/&gt; AUDIO_CHANNELS_5_1：5.1声道&lt;br/&gt; 
        /// </summary>
        /// <value>声道数(有效值范围)&lt;br/&gt; AUDIO_CHANNELS_1:单声道&lt;br/&gt; AUDIO_CHANNELS_2：双声道&lt;br/&gt; AUDIO_CHANNELS_5_1：5.1声道&lt;br/&gt; </value>
        [JsonConverter(typeof(EnumClassConverter<ChannelsEnum>))]
        public class ChannelsEnum
        {
            /// <summary>
            /// Enum AUDIO_CHANNELS_1 for value: AUDIO_CHANNELS_1
            /// </summary>
            public static readonly ChannelsEnum AUDIO_CHANNELS_1 = new ChannelsEnum("AUDIO_CHANNELS_1");

            /// <summary>
            /// Enum AUDIO_CHANNELS_2 for value: AUDIO_CHANNELS_2
            /// </summary>
            public static readonly ChannelsEnum AUDIO_CHANNELS_2 = new ChannelsEnum("AUDIO_CHANNELS_2");

            /// <summary>
            /// Enum AUDIO_CHANNELS_5_1 for value: AUDIO_CHANNELS_5_1
            /// </summary>
            public static readonly ChannelsEnum AUDIO_CHANNELS_5_1 = new ChannelsEnum("AUDIO_CHANNELS_5_1");

            private static readonly Dictionary<string, ChannelsEnum> StaticFields =
            new Dictionary<string, ChannelsEnum>()
            {
                { "AUDIO_CHANNELS_1", AUDIO_CHANNELS_1 },
                { "AUDIO_CHANNELS_2", AUDIO_CHANNELS_2 },
                { "AUDIO_CHANNELS_5_1", AUDIO_CHANNELS_5_1 },
            };

            private string _value;

            public ChannelsEnum()
            {

            }

            public ChannelsEnum(string value)
            {
                _value = value;
            }

            public static ChannelsEnum FromValue(string value)
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

                if (this.Equals(obj as ChannelsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ChannelsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ChannelsEnum a, ChannelsEnum b)
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

            public static bool operator !=(ChannelsEnum a, ChannelsEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 音频采样率(有效值范围)&lt;br/&gt; AUDIO_SAMPLE_AUTO (default), AUDIO_SAMPLE_22050：22050Hz&lt;br/&gt; AUDIO_SAMPLE_32000：32000Hz&lt;br/&gt; AUDIO_SAMPLE_44100：44100Hz&lt;br/&gt; AUDIO_SAMPLE_48000：48000Hz&lt;br/&gt; AUDIO_SAMPLE_96000：96000Hz&lt;br/&gt; 
        /// </summary>
        [JsonProperty("sample_rate", NullValueHandling = NullValueHandling.Ignore)]
        public SampleRateEnum SampleRate { get; set; }
        /// <summary>
        /// 音频码率（单位：Kbps）&lt;br/&gt; 
        /// </summary>
        [JsonProperty("bitrate", NullValueHandling = NullValueHandling.Ignore)]
        public int? Bitrate { get; set; }

        /// <summary>
        /// 声道数(有效值范围)&lt;br/&gt; AUDIO_CHANNELS_1:单声道&lt;br/&gt; AUDIO_CHANNELS_2：双声道&lt;br/&gt; AUDIO_CHANNELS_5_1：5.1声道&lt;br/&gt; 
        /// </summary>
        [JsonProperty("channels", NullValueHandling = NullValueHandling.Ignore)]
        public ChannelsEnum Channels { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AudioInfo {\n");
            sb.Append("  sampleRate: ").Append(SampleRate).Append("\n");
            sb.Append("  bitrate: ").Append(Bitrate).Append("\n");
            sb.Append("  channels: ").Append(Channels).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AudioInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AudioInfo input)
        {
            if (input == null) return false;
            if (this.SampleRate != input.SampleRate) return false;
            if (this.Bitrate != input.Bitrate || (this.Bitrate != null && !this.Bitrate.Equals(input.Bitrate))) return false;
            if (this.Channels != input.Channels) return false;

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
                hashCode = hashCode * 59 + this.SampleRate.GetHashCode();
                if (this.Bitrate != null) hashCode = hashCode * 59 + this.Bitrate.GetHashCode();
                hashCode = hashCode * 59 + this.Channels.GetHashCode();
                return hashCode;
            }
        }
    }
}
