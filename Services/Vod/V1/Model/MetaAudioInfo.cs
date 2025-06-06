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
    public class MetaAudioInfo 
    {

        /// <summary>
        /// 音频编码格式 
        /// </summary>
        [JsonProperty("codec", NullValueHandling = NullValueHandling.Ignore)]
        public string Codec { get; set; }

        /// <summary>
        /// 音频采样率 
        /// </summary>
        [JsonProperty("sampling_rate", NullValueHandling = NullValueHandling.Ignore)]
        public int? SamplingRate { get; set; }

        /// <summary>
        /// 音频码率，单位：bit/s 
        /// </summary>
        [JsonProperty("bitrate", NullValueHandling = NullValueHandling.Ignore)]
        public long? Bitrate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetaAudioInfo {\n");
            sb.Append("  codec: ").Append(Codec).Append("\n");
            sb.Append("  samplingRate: ").Append(SamplingRate).Append("\n");
            sb.Append("  bitrate: ").Append(Bitrate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MetaAudioInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MetaAudioInfo input)
        {
            if (input == null) return false;
            if (this.Codec != input.Codec || (this.Codec != null && !this.Codec.Equals(input.Codec))) return false;
            if (this.SamplingRate != input.SamplingRate || (this.SamplingRate != null && !this.SamplingRate.Equals(input.SamplingRate))) return false;
            if (this.Bitrate != input.Bitrate || (this.Bitrate != null && !this.Bitrate.Equals(input.Bitrate))) return false;

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
                if (this.Codec != null) hashCode = hashCode * 59 + this.Codec.GetHashCode();
                if (this.SamplingRate != null) hashCode = hashCode * 59 + this.SamplingRate.GetHashCode();
                if (this.Bitrate != null) hashCode = hashCode * 59 + this.Bitrate.GetHashCode();
                return hashCode;
            }
        }
    }
}
