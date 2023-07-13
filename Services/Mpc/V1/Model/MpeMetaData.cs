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
    public class MpeMetaData 
    {

        /// <summary>
        /// 封装类型。
        /// </summary>
        [JsonProperty("pack_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PackType { get; set; }

        /// <summary>
        /// 视频时长。
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public double? Duration { get; set; }

        /// <summary>
        /// 视频大小。
        /// </summary>
        [JsonProperty("video_size", NullValueHandling = NullValueHandling.Ignore)]
        public long? VideoSize { get; set; }

        /// <summary>
        /// 视频宽度。
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }

        /// <summary>
        /// 视频高度。
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }

        /// <summary>
        /// 码率。
        /// </summary>
        [JsonProperty("bit_rate", NullValueHandling = NullValueHandling.Ignore)]
        public int? BitRate { get; set; }

        /// <summary>
        /// 音频码率。
        /// </summary>
        [JsonProperty("audio_bit_rate", NullValueHandling = NullValueHandling.Ignore)]
        public int? AudioBitRate { get; set; }

        /// <summary>
        /// 帧率。  取值范围：0或[5,60]，0表示自适应。  单位：帧每秒。  &gt; 若设置的帧率不在取值范围内，则自动调整为0，若设置的帧率高于片源帧率，则自动调整为片源帧率。 
        /// </summary>
        [JsonProperty("frame_rate", NullValueHandling = NullValueHandling.Ignore)]
        public int? FrameRate { get; set; }

        /// <summary>
        /// 编码类型名称。
        /// </summary>
        [JsonProperty("codec_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CodecName { get; set; }

        /// <summary>
        /// 音频编码类型。
        /// </summary>
        [JsonProperty("audio_codec_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AudioCodecName { get; set; }

        /// <summary>
        /// 声道数。
        /// </summary>
        [JsonProperty("channels", NullValueHandling = NullValueHandling.Ignore)]
        public int? Channels { get; set; }

        /// <summary>
        /// 采样率。
        /// </summary>
        [JsonProperty("sample", NullValueHandling = NullValueHandling.Ignore)]
        public int? Sample { get; set; }

        /// <summary>
        /// 是否音频。
        /// </summary>
        [JsonProperty("is_audio", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAudio { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MpeMetaData {\n");
            sb.Append("  packType: ").Append(PackType).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  videoSize: ").Append(VideoSize).Append("\n");
            sb.Append("  width: ").Append(Width).Append("\n");
            sb.Append("  height: ").Append(Height).Append("\n");
            sb.Append("  bitRate: ").Append(BitRate).Append("\n");
            sb.Append("  audioBitRate: ").Append(AudioBitRate).Append("\n");
            sb.Append("  frameRate: ").Append(FrameRate).Append("\n");
            sb.Append("  codecName: ").Append(CodecName).Append("\n");
            sb.Append("  audioCodecName: ").Append(AudioCodecName).Append("\n");
            sb.Append("  channels: ").Append(Channels).Append("\n");
            sb.Append("  sample: ").Append(Sample).Append("\n");
            sb.Append("  isAudio: ").Append(IsAudio).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MpeMetaData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MpeMetaData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PackType == input.PackType ||
                    (this.PackType != null &&
                    this.PackType.Equals(input.PackType))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.VideoSize == input.VideoSize ||
                    (this.VideoSize != null &&
                    this.VideoSize.Equals(input.VideoSize))
                ) && 
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.BitRate == input.BitRate ||
                    (this.BitRate != null &&
                    this.BitRate.Equals(input.BitRate))
                ) && 
                (
                    this.AudioBitRate == input.AudioBitRate ||
                    (this.AudioBitRate != null &&
                    this.AudioBitRate.Equals(input.AudioBitRate))
                ) && 
                (
                    this.FrameRate == input.FrameRate ||
                    (this.FrameRate != null &&
                    this.FrameRate.Equals(input.FrameRate))
                ) && 
                (
                    this.CodecName == input.CodecName ||
                    (this.CodecName != null &&
                    this.CodecName.Equals(input.CodecName))
                ) && 
                (
                    this.AudioCodecName == input.AudioCodecName ||
                    (this.AudioCodecName != null &&
                    this.AudioCodecName.Equals(input.AudioCodecName))
                ) && 
                (
                    this.Channels == input.Channels ||
                    (this.Channels != null &&
                    this.Channels.Equals(input.Channels))
                ) && 
                (
                    this.Sample == input.Sample ||
                    (this.Sample != null &&
                    this.Sample.Equals(input.Sample))
                ) && 
                (
                    this.IsAudio == input.IsAudio ||
                    (this.IsAudio != null &&
                    this.IsAudio.Equals(input.IsAudio))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.PackType != null)
                    hashCode = hashCode * 59 + this.PackType.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.VideoSize != null)
                    hashCode = hashCode * 59 + this.VideoSize.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.BitRate != null)
                    hashCode = hashCode * 59 + this.BitRate.GetHashCode();
                if (this.AudioBitRate != null)
                    hashCode = hashCode * 59 + this.AudioBitRate.GetHashCode();
                if (this.FrameRate != null)
                    hashCode = hashCode * 59 + this.FrameRate.GetHashCode();
                if (this.CodecName != null)
                    hashCode = hashCode * 59 + this.CodecName.GetHashCode();
                if (this.AudioCodecName != null)
                    hashCode = hashCode * 59 + this.AudioCodecName.GetHashCode();
                if (this.Channels != null)
                    hashCode = hashCode * 59 + this.Channels.GetHashCode();
                if (this.Sample != null)
                    hashCode = hashCode * 59 + this.Sample.GetHashCode();
                if (this.IsAudio != null)
                    hashCode = hashCode * 59 + this.IsAudio.GetHashCode();
                return hashCode;
            }
        }
    }
}
