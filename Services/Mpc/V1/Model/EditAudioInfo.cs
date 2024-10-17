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
    public class EditAudioInfo 
    {

        /// <summary>
        /// 音频编码格式,取值有：[AAC, HEAAC, MP3]。
        /// </summary>
        [JsonProperty("codec", NullValueHandling = NullValueHandling.Ignore)]
        public string Codec { get; set; }

        /// <summary>
        /// 视频码率，单位: bit/s 
        /// </summary>
        [JsonProperty("bitrate", NullValueHandling = NullValueHandling.Ignore)]
        public int? Bitrate { get; set; }

        /// <summary>
        /// 采样率, 单位: HZ 
        /// </summary>
        [JsonProperty("sample", NullValueHandling = NullValueHandling.Ignore)]
        public int? Sample { get; set; }

        /// <summary>
        /// 声道数。
        /// </summary>
        [JsonProperty("channels", NullValueHandling = NullValueHandling.Ignore)]
        public string Channels { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EditAudioInfo {\n");
            sb.Append("  codec: ").Append(Codec).Append("\n");
            sb.Append("  bitrate: ").Append(Bitrate).Append("\n");
            sb.Append("  sample: ").Append(Sample).Append("\n");
            sb.Append("  channels: ").Append(Channels).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EditAudioInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EditAudioInfo input)
        {
            if (input == null) return false;
            if (this.Codec != input.Codec || (this.Codec != null && !this.Codec.Equals(input.Codec))) return false;
            if (this.Bitrate != input.Bitrate || (this.Bitrate != null && !this.Bitrate.Equals(input.Bitrate))) return false;
            if (this.Sample != input.Sample || (this.Sample != null && !this.Sample.Equals(input.Sample))) return false;
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
                if (this.Codec != null) hashCode = hashCode * 59 + this.Codec.GetHashCode();
                if (this.Bitrate != null) hashCode = hashCode * 59 + this.Bitrate.GetHashCode();
                if (this.Sample != null) hashCode = hashCode * 59 + this.Sample.GetHashCode();
                if (this.Channels != null) hashCode = hashCode * 59 + this.Channels.GetHashCode();
                return hashCode;
            }
        }
    }
}
