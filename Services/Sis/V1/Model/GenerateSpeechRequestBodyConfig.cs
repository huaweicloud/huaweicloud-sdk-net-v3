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
    /// 语音合成配置信息。
    /// </summary>
    public class GenerateSpeechRequestBodyConfig 
    {

        /// <summary>
        /// 语音格式头：wav、mp3、pcm。 默认：wav
        /// </summary>
        [JsonProperty("audio_format", NullValueHandling = NullValueHandling.Ignore)]
        public string AudioFormat { get; set; }

        /// <summary>
        /// 采样率：8kHz、16kHz、24kHz。 默认：24kHz
        /// </summary>
        [JsonProperty("sample_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string SampleRate { get; set; }

        /// <summary>
        /// 音色名称。
        /// </summary>
        [JsonProperty("voice_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VoiceName { get; set; }

        /// <summary>
        /// 语速：-500~500。 默认：0
        /// </summary>
        [JsonProperty("speed", NullValueHandling = NullValueHandling.Ignore)]
        public int? Speed { get; set; }

        /// <summary>
        /// 音高：-500~500。 默认：0
        /// </summary>
        [JsonProperty("pitch", NullValueHandling = NullValueHandling.Ignore)]
        public int? Pitch { get; set; }

        /// <summary>
        /// 音量：0~100。 默认：50
        /// </summary>
        [JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)]
        public int? Volume { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GenerateSpeechRequestBodyConfig {\n");
            sb.Append("  audioFormat: ").Append(AudioFormat).Append("\n");
            sb.Append("  sampleRate: ").Append(SampleRate).Append("\n");
            sb.Append("  voiceName: ").Append(VoiceName).Append("\n");
            sb.Append("  speed: ").Append(Speed).Append("\n");
            sb.Append("  pitch: ").Append(Pitch).Append("\n");
            sb.Append("  volume: ").Append(Volume).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GenerateSpeechRequestBodyConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GenerateSpeechRequestBodyConfig input)
        {
            if (input == null) return false;
            if (this.AudioFormat != input.AudioFormat || (this.AudioFormat != null && !this.AudioFormat.Equals(input.AudioFormat))) return false;
            if (this.SampleRate != input.SampleRate || (this.SampleRate != null && !this.SampleRate.Equals(input.SampleRate))) return false;
            if (this.VoiceName != input.VoiceName || (this.VoiceName != null && !this.VoiceName.Equals(input.VoiceName))) return false;
            if (this.Speed != input.Speed || (this.Speed != null && !this.Speed.Equals(input.Speed))) return false;
            if (this.Pitch != input.Pitch || (this.Pitch != null && !this.Pitch.Equals(input.Pitch))) return false;
            if (this.Volume != input.Volume || (this.Volume != null && !this.Volume.Equals(input.Volume))) return false;

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
                if (this.AudioFormat != null) hashCode = hashCode * 59 + this.AudioFormat.GetHashCode();
                if (this.SampleRate != null) hashCode = hashCode * 59 + this.SampleRate.GetHashCode();
                if (this.VoiceName != null) hashCode = hashCode * 59 + this.VoiceName.GetHashCode();
                if (this.Speed != null) hashCode = hashCode * 59 + this.Speed.GetHashCode();
                if (this.Pitch != null) hashCode = hashCode * 59 + this.Pitch.GetHashCode();
                if (this.Volume != null) hashCode = hashCode * 59 + this.Volume.GetHashCode();
                return hashCode;
            }
        }
    }
}
