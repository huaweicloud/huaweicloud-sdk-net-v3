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
    public class ObjectMetaData 
    {

        /// <summary>
        /// 总码率，单位：bit/秒 
        /// </summary>
        [JsonProperty("bitrate", NullValueHandling = NullValueHandling.Ignore)]
        public long? Bitrate { get; set; }

        /// <summary>
        /// 封装格式 
        /// </summary>
        [JsonProperty("container", NullValueHandling = NullValueHandling.Ignore)]
        public string Container { get; set; }

        /// <summary>
        /// 时长，单位：秒 
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? Duration { get; set; }

        /// <summary>
        /// 时长，单位：秒 
        /// </summary>
        [JsonProperty("video_duration", NullValueHandling = NullValueHandling.Ignore)]
        public float? VideoDuration { get; set; }

        /// <summary>
        /// 时长，单位：秒 
        /// </summary>
        [JsonProperty("audio_duration", NullValueHandling = NullValueHandling.Ignore)]
        public float? AudioDuration { get; set; }

        /// <summary>
        /// 时长，单位：秒 
        /// </summary>
        [JsonProperty("float_duration", NullValueHandling = NullValueHandling.Ignore)]
        public float? FloatDuration { get; set; }

        /// <summary>
        /// 视频高度 
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }

        /// <summary>
        /// 视频宽度 
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }

        /// <summary>
        /// 视频md5 
        /// </summary>
        [JsonProperty("md5", NullValueHandling = NullValueHandling.Ignore)]
        public string Md5 { get; set; }

        /// <summary>
        /// 视频拍摄角度 
        /// </summary>
        [JsonProperty("rotate", NullValueHandling = NullValueHandling.Ignore)]
        public float? Rotate { get; set; }

        /// <summary>
        /// 文件大小，单位：byte 
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public long? Size { get; set; }

        /// <summary>
        /// 视频流元数据 
        /// </summary>
        [JsonProperty("video_stream_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<MetaVideoInfo> VideoStreamList { get; set; }

        /// <summary>
        /// 音频流元数据 
        /// </summary>
        [JsonProperty("audio_stream_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<MetaAudioInfo> AudioStreamList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObjectMetaData {\n");
            sb.Append("  bitrate: ").Append(Bitrate).Append("\n");
            sb.Append("  container: ").Append(Container).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  videoDuration: ").Append(VideoDuration).Append("\n");
            sb.Append("  audioDuration: ").Append(AudioDuration).Append("\n");
            sb.Append("  floatDuration: ").Append(FloatDuration).Append("\n");
            sb.Append("  height: ").Append(Height).Append("\n");
            sb.Append("  width: ").Append(Width).Append("\n");
            sb.Append("  md5: ").Append(Md5).Append("\n");
            sb.Append("  rotate: ").Append(Rotate).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  videoStreamList: ").Append(VideoStreamList).Append("\n");
            sb.Append("  audioStreamList: ").Append(AudioStreamList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ObjectMetaData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ObjectMetaData input)
        {
            if (input == null) return false;
            if (this.Bitrate != input.Bitrate || (this.Bitrate != null && !this.Bitrate.Equals(input.Bitrate))) return false;
            if (this.Container != input.Container || (this.Container != null && !this.Container.Equals(input.Container))) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;
            if (this.VideoDuration != input.VideoDuration || (this.VideoDuration != null && !this.VideoDuration.Equals(input.VideoDuration))) return false;
            if (this.AudioDuration != input.AudioDuration || (this.AudioDuration != null && !this.AudioDuration.Equals(input.AudioDuration))) return false;
            if (this.FloatDuration != input.FloatDuration || (this.FloatDuration != null && !this.FloatDuration.Equals(input.FloatDuration))) return false;
            if (this.Height != input.Height || (this.Height != null && !this.Height.Equals(input.Height))) return false;
            if (this.Width != input.Width || (this.Width != null && !this.Width.Equals(input.Width))) return false;
            if (this.Md5 != input.Md5 || (this.Md5 != null && !this.Md5.Equals(input.Md5))) return false;
            if (this.Rotate != input.Rotate || (this.Rotate != null && !this.Rotate.Equals(input.Rotate))) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.VideoStreamList != input.VideoStreamList || (this.VideoStreamList != null && input.VideoStreamList != null && !this.VideoStreamList.SequenceEqual(input.VideoStreamList))) return false;
            if (this.AudioStreamList != input.AudioStreamList || (this.AudioStreamList != null && input.AudioStreamList != null && !this.AudioStreamList.SequenceEqual(input.AudioStreamList))) return false;

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
                if (this.Bitrate != null) hashCode = hashCode * 59 + this.Bitrate.GetHashCode();
                if (this.Container != null) hashCode = hashCode * 59 + this.Container.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.VideoDuration != null) hashCode = hashCode * 59 + this.VideoDuration.GetHashCode();
                if (this.AudioDuration != null) hashCode = hashCode * 59 + this.AudioDuration.GetHashCode();
                if (this.FloatDuration != null) hashCode = hashCode * 59 + this.FloatDuration.GetHashCode();
                if (this.Height != null) hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Width != null) hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Md5 != null) hashCode = hashCode * 59 + this.Md5.GetHashCode();
                if (this.Rotate != null) hashCode = hashCode * 59 + this.Rotate.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.VideoStreamList != null) hashCode = hashCode * 59 + this.VideoStreamList.GetHashCode();
                if (this.AudioStreamList != null) hashCode = hashCode * 59 + this.AudioStreamList.GetHashCode();
                return hashCode;
            }
        }
    }
}
