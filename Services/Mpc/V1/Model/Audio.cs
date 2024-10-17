using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Audio 
    {
        /// <summary>
        /// 输出策略。  取值如下： - discard - transcode  &gt;- 当视频参数中的“output_policy”为\&quot;discard\&quot;，且音频参数中的“output_policy”为“transcode”时，表示只输出音频。 &gt;- 当视频参数中的“output_policy”为\&quot;transcode\&quot;，且音频参数中的“output_policy”为“discard”时，表示只输出视频。 &gt;- 同时为\&quot;discard\&quot;时不合法。 &gt;- 同时为“transcode”时，表示输出音视频。 
        /// </summary>
        /// <value>输出策略。  取值如下： - discard - transcode  &gt;- 当视频参数中的“output_policy”为\&quot;discard\&quot;，且音频参数中的“output_policy”为“transcode”时，表示只输出音频。 &gt;- 当视频参数中的“output_policy”为\&quot;transcode\&quot;，且音频参数中的“output_policy”为“discard”时，表示只输出视频。 &gt;- 同时为\&quot;discard\&quot;时不合法。 &gt;- 同时为“transcode”时，表示输出音视频。 </value>
        [JsonConverter(typeof(EnumClassConverter<OutputPolicyEnum>))]
        public class OutputPolicyEnum
        {
            /// <summary>
            /// Enum TRANSCODE for value: transcode
            /// </summary>
            public static readonly OutputPolicyEnum TRANSCODE = new OutputPolicyEnum("transcode");

            /// <summary>
            /// Enum DISCARD for value: discard
            /// </summary>
            public static readonly OutputPolicyEnum DISCARD = new OutputPolicyEnum("discard");

            /// <summary>
            /// Enum COPY for value: copy
            /// </summary>
            public static readonly OutputPolicyEnum COPY = new OutputPolicyEnum("copy");

            private static readonly Dictionary<string, OutputPolicyEnum> StaticFields =
            new Dictionary<string, OutputPolicyEnum>()
            {
                { "transcode", TRANSCODE },
                { "discard", DISCARD },
                { "copy", COPY },
            };

            private string _value;

            public OutputPolicyEnum()
            {

            }

            public OutputPolicyEnum(string value)
            {
                _value = value;
            }

            public static OutputPolicyEnum FromValue(string value)
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

                if (this.Equals(obj as OutputPolicyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OutputPolicyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OutputPolicyEnum a, OutputPolicyEnum b)
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

            public static bool operator !=(OutputPolicyEnum a, OutputPolicyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 输出策略。  取值如下： - discard - transcode  &gt;- 当视频参数中的“output_policy”为\&quot;discard\&quot;，且音频参数中的“output_policy”为“transcode”时，表示只输出音频。 &gt;- 当视频参数中的“output_policy”为\&quot;transcode\&quot;，且音频参数中的“output_policy”为“discard”时，表示只输出视频。 &gt;- 同时为\&quot;discard\&quot;时不合法。 &gt;- 同时为“transcode”时，表示输出音视频。 
        /// </summary>
        [JsonProperty("output_policy", NullValueHandling = NullValueHandling.Ignore)]
        public OutputPolicyEnum OutputPolicy { get; set; }
        /// <summary>
        /// 音频编码格式。  取值如下：  - 1：AAC格式。 - 2：HEAAC1格式 。 - 3：HEAAC2格式。 - 4：MP3格式 。 
        /// </summary>
        [JsonProperty("codec", NullValueHandling = NullValueHandling.Ignore)]
        public int? Codec { get; set; }

        /// <summary>
        /// 音频采样率。  取值如下：  - 1：AUDIO_SAMPLE_AUTO - 2：AUDIO_SAMPLE_22050（22050Hz） - 3：AUDIO_SAMPLE_32000（32000Hz） - 4：AUDIO_SAMPLE_44100（44100Hz） - 5：AUDIO_SAMPLE_48000（48000Hz） - 6：AUDIO_SAMPLE_96000（96000Hz） 
        /// </summary>
        [JsonProperty("sample_rate", NullValueHandling = NullValueHandling.Ignore)]
        public int? SampleRate { get; set; }

        /// <summary>
        /// 音频码率。  取值范围：0或[8,1000]。  单位：kbit/s。 
        /// </summary>
        [JsonProperty("bitrate", NullValueHandling = NullValueHandling.Ignore)]
        public int? Bitrate { get; set; }

        /// <summary>
        /// 声道数。  取值如下： - 1：AUDIO_CHANNELS_1 - 2：AUDIO_CHANNELS_2 - 6：AUDIO_CHANNELS_5_1 
        /// </summary>
        [JsonProperty("channels", NullValueHandling = NullValueHandling.Ignore)]
        public int? Channels { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Audio {\n");
            sb.Append("  outputPolicy: ").Append(OutputPolicy).Append("\n");
            sb.Append("  codec: ").Append(Codec).Append("\n");
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
            return this.Equals(input as Audio);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Audio input)
        {
            if (input == null) return false;
            if (this.OutputPolicy != input.OutputPolicy) return false;
            if (this.Codec != input.Codec || (this.Codec != null && !this.Codec.Equals(input.Codec))) return false;
            if (this.SampleRate != input.SampleRate || (this.SampleRate != null && !this.SampleRate.Equals(input.SampleRate))) return false;
            if (this.Bitrate != input.Bitrate || (this.Bitrate != null && !this.Bitrate.Equals(input.Bitrate))) return false;
            if (this.Channels != input.Channels || (this.Channels != null && !this.Channels.Equals(input.Channels))) return false;

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
                hashCode = hashCode * 59 + this.OutputPolicy.GetHashCode();
                if (this.Codec != null) hashCode = hashCode * 59 + this.Codec.GetHashCode();
                if (this.SampleRate != null) hashCode = hashCode * 59 + this.SampleRate.GetHashCode();
                if (this.Bitrate != null) hashCode = hashCode * 59 + this.Bitrate.GetHashCode();
                if (this.Channels != null) hashCode = hashCode * 59 + this.Channels.GetHashCode();
                return hashCode;
            }
        }
    }
}
